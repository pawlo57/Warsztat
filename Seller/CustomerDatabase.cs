using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Seller.Class;

namespace Seller
{
    public static class CustomerDatabase
    {

        public static bool ActivateCustomer(int PID, string numer, string firma, string imie, string nazwisko)
        {
            string Query = "SELECT IV.*, Customers.FIRMA, Customers.IMIE, Customers.NAZWISKO FROM " +
                "(SELECT * FROM Invoice WHERE NUMER='" + numer + "' AND PID=" + PID + " AND STATUS='Zrealizowana') IV INNER JOIN Customers ON IV.CID=Customers.ID " +
                "WHERE Customers.FIRMA='" + firma + "' AND Customers.IMIE='" + imie + 
                "' AND Customers.NAZWISKO='" + nazwisko + "'";

            DataTable table = new DataTable();
                
            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return false;

            SetActivated((int)table.Rows[0][0]);

            return true;
        }

        public static void SetActivated(int ID)
        {
            Connect.SetCommand("UPDATE Invoice SET ACTIVATED=TRUE, ACTIVDATA='" + DateTime.Now.ToShortDateString() +
                "' WHERE ID=" + ID);
        }

        #region ITEMS

        public static List<Produkt> GetItems(int IID)
        {
            string Query = "SELECT Programs.* FROM (SELECT * FROM Items WHERE ID IS NOT NULL";

            if (IID > 0) Query += " AND IID=" + IID + ")";

            Query += " ITM INNER JOIN Programs ON ITM.PID=Programs.ID";

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Produkt> items = new List<Produkt>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Produkt item = new Produkt();

                item.ID = (int)table.Rows[i]["ID"];
                item.NAME = table.Rows[i]["NAZWA"].ToString();
                //item. = (int)table.Rows[i]["PID"];

                items.Add(item);
            }

            return items;
           
        }

        public static void NewItem(int IID, int PID)
        {
            Connect.SetCommand("INSERT INTO Items (IID,PID) VALUES(" + IID + "," + PID + ")");
        }

        #endregion

        #region TRANSAKCJE

        public static List<Statystyka> GetTransakcjeStatictic(string dataFrom, string dataTo, 
            string bdataFrom, string bdataTo)
        {
            List<Worker> pracownicy = GetWorkers(-1, "", "", "", "", "");

            if (pracownicy == null) return null;

            List<Statystyka> statystyki = new List<Statystyka>();

            foreach (Worker pracownik in pracownicy)
            {
                string Query = "SELECT SUM(VATPRICE) AS SUMA, SUM(CNT) AS SUMA2 FROM Transakcje WHERE WID=" + pracownik.ID;

                if (!String.IsNullOrEmpty(dataFrom))
                    Query += " AND DATA >= '" + dataFrom + "' AND DATA <= '" + dataTo + "' AND STATUS=0";

                if (!String.IsNullOrEmpty(bdataFrom))
                    Query += " AND BDATA >= '" + bdataFrom + "' AND BDATA <= '" + bdataTo + "' AND STATUS>0";

                Query += " ORDER BY SUMA2";

                DataTable table = Connect.FillCommand(Query);

                if (table == null || String.IsNullOrEmpty(table.Rows[0][0].ToString())) continue;

                Statystyka statystka = new Statystyka();

                statystka.Pracownik = pracownik.IMIE + " " + pracownik.NAZWISKO;

                statystka.Kwota = table.Rows[0][0].ToString();

                statystka.Ilosc = table.Rows[0][1].ToString();

                statystyki.Add(statystka);
                
            }

            return statystyki;
        }


        public static List<Invoice> GetTransakcje(int ID, string numer, int CID, int UID, 
            string DataOD, string DataDo, string BDataOd, string BDataDo, int status, int CARID)
        {
            string Query = "SELECT CAR.*, (Cars.Marka + ' ' + Cars.Model + ' ' + Cars.Poj + ' ' + Cars.Rej) AS CARNAME FROM " +
                "(SELECT INVU.*, (Urs.IMIE + ' ' + Urs.NAZWISKO) AS [Urs] FROM " +
                "(SELECT INV.*, (Customers.FIRMA + ',' + Customers.NAZWISKO + ' ' + Customers.IMIE + ',' + Customers.ADRES) AS [CUSTOMER] FROM " +
                "(SELECT * FROM Transakcje WHERE ID IS NOT NULL";

            if (ID > 0) Query += " AND ID=" + ID;
            if (!String.IsNullOrEmpty(numer)) Query += " AND NUMER LIKE '" + numer + "%'";
            if (CID > 0) Query += " AND CID=" + CID;
            if (UID > 1) Query += " AND UID=" + UID;
            if (!String.IsNullOrEmpty(DataOD)) Query += " AND DATA >= '" + DataOD + "'";
            if (!String.IsNullOrEmpty(DataDo)) Query += " AND DATA <= '" + DataDo + "'";
            if (!String.IsNullOrEmpty(BDataOd)) Query += " AND BDATA >= '" + BDataOd + "'";
            if (!String.IsNullOrEmpty(BDataDo)) Query += " AND BDATA <= '" + BDataDo + "'";
            if (status > -1) Query += " AND STATUS=" + status;
            if(CARID>0) Query += " AND CARID=" + CARID;

            Query += ") INV INNER JOIN Customers ON  INV.CID=Customers.ID)";

            Query += " INVU INNER JOIN Urs ON INVU.UID=Urs.ID";

            Query += ") CAR INNER JOIN Cars ON CAR.CARID=Cars.ID";

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Invoice> invoices = new List<Invoice>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Invoice invoice = new Invoice();

                invoice.ID = int.Parse(table.Rows[i]["ID"].ToString());
                invoice.NUMER = table.Rows[i]["NUMER"].ToString();
                invoice.PRICE = float.Parse(table.Rows[i]["PRICE"].ToString());
                invoice.VATPRICE = float.Parse(table.Rows[i]["VATPRICE"].ToString());
                invoice.CID = int.Parse(table.Rows[i]["CID"].ToString());
                invoice.UID = int.Parse(table.Rows[i]["UID"].ToString());
                invoice.DATA = table.Rows[i]["DATA"].ToString().Substring(0,10);
                invoice.STATUS = (int)table.Rows[i]["STATUS"];
                invoice.CNAME = table.Rows[i]["CUSTOMER"].ToString();
                invoice.UNAME = table.Rows[i]["Urs"].ToString();
                invoice.PLATNOSC = (int)table.Rows[i]["PLATNOSC"];
                invoice.UWAGI = table.Rows[i]["UWAGI"].ToString();
                //invoice.ILOSC_SZTUK = float.Parse(table.Rows[i]["CNT"].ToString());
                invoice.TYP_FAKTURY = (FakturaTyp.TYPE)int.Parse(table.Rows[i]["STATUS"].ToString());
                invoice.CARID = int.Parse(table.Rows[i]["CARID"].ToString());
                invoice.CAR_NAME = table.Rows[i]["CARNAME"].ToString();

                try { invoice.TERMIN = DateTime.Parse(table.Rows[i]["TERMIN"].ToString()).ToShortDateString(); }
                catch { invoice.TERMIN = ""; }

                try { invoice.TERMIN_UKONCZENIA = DateTime.Parse(table.Rows[i]["TERMINU"].ToString()).ToShortDateString(); }
                catch { invoice.TERMIN_UKONCZENIA = ""; }

                //try { invoice.DATA_ZWROTU = table.Rows[i]["BDATA"].ToString().Substring(0, 10); }
                //catch { invoice.DATA_ZWROTU = ""; }

                if (invoice.TYP_FAKTURY == 0) invoice.TYP_FAKTURY_NAZWA = "Faktura";
                else invoice.TYP_FAKTURY_NAZWA = "Faktura korygująca";

                try { invoice.Licznik = int.Parse(table.Rows[i]["Licznik"].ToString()); }
                catch { invoice.Licznik = -1; }

                try { invoice.Paliwo = int.Parse(table.Rows[i]["Paliwo"].ToString()); }
                catch { invoice.Paliwo = -1; }

                try { invoice.Dowod = int.Parse(table.Rows[i]["Dowod"].ToString()); }
                catch { invoice.Dowod = -1; }

                invoices.Add(invoice);
            }


            return invoices;


        }

        public static List<Invoice> GetFaktury(int ID, string numer, int TYP, int CID, int WID, int UID,
           string DataOD, string DataDo, int STATUS)
        {
            string Query = "SELECT INVW.*, (Workers.IMIE + ' ' + Workers.NAZWISKO + ', ' + Workers.ADRESS) AS [WORKER] FROM " +
                "(SELECT INVU.*, (Urs.IMIE + ' ' + Urs.NAZWISKO) AS [Urs] FROM " +
                "(SELECT INV.*, (Customers.FIRMA + ',' + Customers.NAZWISKO + ' ' + Customers.IMIE + ',' + Customers.ADRES) AS [CUSTOMER] FROM " +
                "(SELECT FAK.*, Transakcje.NUMER AS TNUMER, Transakcje.PRICE, Transakcje.VATPRICE, Transakcje.CNT, Transakcje.CID, Transakcje.WID, Transakcje.UID, Transakcje.SUMAPROWIZJI, Transakcje.PLATNOSC, Transakcje.BDATA, Transakcje.STATUS, Transakcje.ACTIVATED, Transakcje.ACTIVDATA, Transakcje.UWAGI FROM " +
                "(SELECT NUMER, TYP, TID, DATA FROM Faktury WHERE ID IS NOT NULL";

            if (ID > 0) Query += " AND ID=" + ID;
            if (!String.IsNullOrEmpty(numer)) Query += " AND NUMER LIKE '" + numer + "%'";
            if (UID > 1) Query += " AND UID=" + UID;
            if (TYP > 0) Query += " AND TYP=" + TYP;
            if (!String.IsNullOrEmpty(DataOD)) Query += " AND DATA >= '" + DataOD + "'";
            if (!String.IsNullOrEmpty(DataDo)) Query += " AND DATA <= '" + DataDo + "'";

            Query += ") FAK INNER JOIN Transakcje ON FAK.TID=Transakcje.ID WHERE Transakcje.ID IS NOT NULL";

            if (CID > 0) Query += " AND CID=" + CID;
            if (WID > 0) Query += " AND WID=" + WID;
            if (STATUS > 0) Query += " AND STATUS=" + STATUS;

            Query += ") INV INNER JOIN Customers ON  INV.CID=Customers.ID)";

            Query += " INVU INNER JOIN Urs ON INVU.UID=Urs.ID) INVW INNER JOIN Workers ON INVW.WID=Workers.ID";

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Invoice> invoices = new List<Invoice>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Invoice invoice = new Invoice();

                invoice.ID = int.Parse(table.Rows[i]["TID"].ToString());
                invoice.NUMER = table.Rows[i]["NUMER"].ToString();
                invoice.PRICE = float.Parse(table.Rows[i]["PRICE"].ToString());
                invoice.VATPRICE = float.Parse(table.Rows[i]["VATPRICE"].ToString());
                invoice.CID = int.Parse(table.Rows[i]["CID"].ToString());
                invoice.WID = (int)table.Rows[i]["WID"];
                invoice.UID = int.Parse(table.Rows[i]["UID"].ToString());
                invoice.DATA = table.Rows[i]["DATA"].ToString();
                invoice.STATUS = (int)table.Rows[i]["STATUS"];
                invoice.ACTIVATED = table.Rows[i]["ACTIVATED"].ToString();
                invoice.ACTIVDATA = table.Rows[i]["ACTIVDATA"].ToString();
                invoice.CNAME = table.Rows[i]["CUSTOMER"].ToString();
                invoice.UNAME = table.Rows[i]["Urs"].ToString();
                invoice.WNAME = table.Rows[i]["WORKER"].ToString();
                invoice.SUMA_PROWIZJI = float.Parse(table.Rows[i]["SUMAPROWIZJI"].ToString());
                invoice.PLATNOSC = (int)table.Rows[i]["PLATNOSC"];
                invoice.UWAGI = table.Rows[i]["UWAGI"].ToString();
                invoice.TYP_FAKTURY = (FakturaTyp.TYPE)int.Parse(table.Rows[i]["TYP"].ToString());
        
                
                invoices.Add(invoice);
            }


            return invoices;


        }

        public static void NewFaktura(string numer,int UID, int TYP, int TID, string DATA)
        {
            Connect.SetCommand("INSERT INTO Faktury (NUMER,UID,TYP,TID,DATA) VALUES('" + numer + "'," +
                UID + "," + TYP + "," + TID + ",'" + DATA + "')");
        }

        public static List<Produkt> GetTransItems(int IID)
        {
            string Query = "SELECT TCID.*, Customers.FIRMA, Customers.IMIE, Customers.NAZWISKO, Customers.ADRES AS CADRES FROM " +
                "(SELECT TCAT.*, Categories.CATEGORY FROM " +
                "(SELECT TM.*, Programs.CATID, Programs.CID, Programs.NUMERKAT, Programs.MODEL, Programs.NUMERSER, Programs.OPIS, Programs.NAZWA, Programs.PRICE AS PPRICE, Programs.VATPRICE AS PVATPRICE, Programs.PRICE2, Programs.VATPRICE2, Programs.JEDNOSTKA, Programs.PROWIZJA FROM " +
                "(SELECT TI.*, MagType.MAGAZYN, MagType.ADRES FROM " +
                "(SELECT * FROM TransItems WHERE IID=" + IID + " AND MAGID>0";

            Query += ") TI INNER JOIN MagType ON TI.MAGID=MagType.ID";

            Query += ") TM INNER JOIN Programs ON TM.PID=Programs.ID";

            Query += ") TCAT INNER JOIN Categories ON TCAT.CATID=Categories.ID";

            Query += ") TCID INNER JOIN Customers ON TCID.CID=Customers.ID";

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Produkt> towary = new List<Produkt>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Produkt towar = new Produkt();

                towar.TIID = (int)table.Rows[i]["ID"];
                towar.IID = (int)table.Rows[i]["IID"];
                towar.MID = (int)table.Rows[i]["MAGID"];
                towar.MAGAZYN = table.Rows[i]["MAGAZYN"].ToString();
                towar.MAGAZYNADRES = table.Rows[i]["ADRES"].ToString();
                towar.PID = (int)table.Rows[i]["PID"];
                towar.ID = (int)table.Rows[i]["PID"];
                towar.CATID = (int)table.Rows[i]["CATID"];
                towar.CATNAME = table.Rows[i]["CATEGORY"].ToString();
                towar.CID = (int)table.Rows[i]["CID"];
                towar.CNAME = table.Rows[i]["FIRMA"].ToString() + ", " +
                    table.Rows[i]["IMIE"].ToString() + " " +
                    table.Rows[i]["NAZWISKO"].ToString() + ", " +
                    table.Rows[i]["CADRES"].ToString();

                towar.NUMERKAT = table.Rows[i]["NUMERKAT"].ToString();
                towar.MODEL = table.Rows[i]["MODEL"].ToString();
                towar.NUMERSER = table.Rows[i]["NUMERSER"].ToString();
                towar.OPIS = table.Rows[i]["OPIS"].ToString();
                towar.NAME = table.Rows[i]["NAZWA"].ToString();
                towar.PRICE = float.Parse(table.Rows[i]["PPRICE"].ToString());
                towar.VATPRICE = float.Parse(table.Rows[i]["PVATPRICE"].ToString());
                try { towar.PRICE2 = float.Parse(table.Rows[i]["PRICE2"].ToString()); }
                catch { towar.PRICE2 = 0; }
                try { towar.VATPRICE2 = float.Parse(table.Rows[i]["VATPRICE2"].ToString()); }
                catch { towar.VATPRICE2 = 0; }
                towar.STAN = float.Parse(table.Rows[i]["CNT"].ToString());
                towar.SUMA_NETTO = float.Parse(table.Rows[i]["PRICE"].ToString());
                towar.SUMA_BRUTTO = float.Parse(table.Rows[i]["VATPRICE"].ToString());
                towar.SUMA = float.Parse(table.Rows[i]["VATPRICE"].ToString());
                towar.JEDNOSTKA = table.Rows[i]["JEDNOSTKA"].ToString();
               // towar.KWOTA_VAT = float.Parse(MathHelp.AddZero(Math.Round((towar.SUMA_NETTO * Settings.PROCENT) / 100, 2).ToString()));
                towar.KWOTA_VAT = (float)Math.Round(towar.SUMA_BRUTTO - towar.SUMA_NETTO,2);

                towary.Add(towar);
            }

            return towary;
        }

        public static List<UslugaC> GetUslugiItems(int IID)
        {
            string Query = "SELECT TW.*, (Workers.IMIE + ' ' + Workers.NAZWISKO + ' ' + Workers.ADRESS) AS WNAME FROM " +
                "(SELECT TI.*, Uslugi.Opis, Uslugi.Netto, Uslugi.VAT, Uslugi.Brutto, Uslugi.Numer, Uslugi.Nazwa, Uslugi.TimeIndex FROM " +
                "(SELECT * FROM TransItems WHERE IID=" + IID + " AND MAGID<0";

            

            Query += ") TI INNER JOIN Uslugi ON TI.PID=Uslugi.ID";

            Query += ") TW INNER JOIN Workers ON TW.WID=Workers.ID";

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<UslugaC> uslugi = new List<UslugaC>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                UslugaC usluga = new UslugaC();

                usluga.ID = int.Parse(table.Rows[i]["PID"].ToString());
                usluga.OPIS = table.Rows[i]["Opis"].ToString();
                usluga.Netto = float.Parse(table.Rows[i]["Netto"].ToString());
                usluga.VAT = int.Parse(table.Rows[i]["VAT"].ToString());
                usluga.Brutto = float.Parse(table.Rows[i]["Brutto"].ToString());
                usluga.SumaNetto = float.Parse(table.Rows[i]["PRICE"].ToString());
                usluga.SumaBrutto = float.Parse(table.Rows[i]["VATPRICE"].ToString());
                usluga.NUMER = table.Rows[i]["Numer"].ToString();
                usluga.NAZWA = table.Rows[i]["Nazwa"].ToString();
                usluga.WID = int.Parse(table.Rows[i]["WID"].ToString());
                usluga.W_NAME = table.Rows[i]["WNAME"].ToString();
                usluga.CZAS = int.Parse(table.Rows[i]["CNT"].ToString());

                try { usluga.TIME_INDEX = (WorkIdx.TYPE)int.Parse(table.Rows[i]["TimeIndex"].ToString()); }
                catch { usluga.TIME_INDEX = WorkIdx.TYPE.SELECT; }

                usluga.KWOTA_VAT = (float)Math.Round((usluga.SumaBrutto - usluga.SumaNetto), 2);

                uslugi.Add(usluga);
            }

            return uslugi;
        }

        public static List<UslugaRepCls> GetWorkersReport(int WID, string DATA_OD, string DATA_DO)
        {
            string Query = "SELECT USL.*, Uslugi.Opis, Uslugi.Netto, Uslugi.VAT, Uslugi.Brutto, Uslugi.Numer, Uslugi.Nazwa FROM " +
                "(SELECT WI.*, Workers.IMIE, Workers.NAZWISKO, Workers.ADRESS, Workers.PESEL, Workers.NIP, Workers.BANK FROM " +
                "(SELECT TI.*, Transakcje.DATA FROM " +
                "(SELECT * FROM TransItems WHERE ID IS NOT NULL";

            if (WID > 0) Query += " AND WID=" + WID;

            Query += ") TI INNER JOIN Transakcje ON TI.IID=Transakcje.ID";

            if (!String.IsNullOrEmpty(DATA_OD)) Query += " AND Transakcje.DATA >= '" + DATA_OD +
                "' AND Transakcje.DATA <= '" + DATA_DO + "'";

            Query += ") WI INNER JOIN Workers ON WI.WID=Workers.ID";

            Query += ") USL INNER JOIN Uslugi ON USL.PID=Uslugi.ID ORDER BY NAZWISKO";

            DataTable table = Connect.FillCommand(Query);

            if (table == null) return null;
            if (table != null)
                if (table.Rows.Count == 0) return null;

            List<UslugaRepCls> uslugi = new List<UslugaRepCls>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                UslugaRepCls usluga = new UslugaRepCls();

                usluga.ID = int.Parse(table.Rows[i]["PID"].ToString());
                usluga.OPIS = table.Rows[i]["Opis"].ToString();
                usluga.Netto = float.Parse(table.Rows[i]["PRICE"].ToString());
                usluga.VAT = int.Parse(table.Rows[i]["VAT"].ToString());
                usluga.Brutto = float.Parse(table.Rows[i]["VATPRICE"].ToString());
                usluga.NUMER = table.Rows[i]["Numer"].ToString();
                usluga.NAZWA = table.Rows[i]["Nazwa"].ToString();
                usluga.WID = int.Parse(table.Rows[i]["WID"].ToString());
                usluga.CZAS = int.Parse(table.Rows[i]["CNT"].ToString());
                usluga.KWOTA_VAT = float.Parse(MathHelp.AddZero(Math.Round((usluga.Netto * usluga.VAT) / 100, 2).ToString()));

                usluga.DATA = DateTime.Parse(table.Rows[i]["DATA"].ToString()).ToShortDateString();
                usluga.IMIE = table.Rows[i]["IMIE"].ToString();
                usluga.NAZWISKO = table.Rows[i]["NAZWISKO"].ToString();
                usluga.ADRES = table.Rows[i]["ADRESS"].ToString();



                uslugi.Add(usluga);
            }

            return uslugi;
        }

        public static int GetMaxTransakcja()
        {
            DataTable table = new DataTable();

            table = Connect.FillCommand("SELECT NUMER FROM Transakcje");

            if (table.Rows.Count == 0) return 0;

            int MAx = -1;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                int index = table.Rows[i]["NUMER"].ToString().IndexOf('/');

                int numer = int.Parse(table.Rows[i]["NUMER"].ToString().Substring(0, index));

                if (numer > MAx) MAx = numer;
            }

            return MAx;
        }

        public static int NewTranskacja(string numer, int CID, int UID,int platnosc,
            float price, float vatprice,int status, string Data, string uwagi, int CARID, string termin,
            string termin_ukonczenia, int licznik, int paliwo, int dowod)
        {
            return Connect.SetIDCommand("INSERT INTO Transakcje (NUMER,PRICE,VATPRICE,CID,UID,PLATNOSC,DATA,STATUS,UWAGI,CARID,TERMIN,TERMINU,Licznik,Paliwo,Dowod) VALUES('" +
                numer + "'," + price.ToString().Replace(',', '.') + "," + vatprice.ToString().Replace(',', '.') +
                "," + CID + "," + UID + "," + platnosc + ",'" + Data + "'," + status + ",'" + uwagi + 
                "'," + CARID + ",'" +  termin + "','" + termin_ukonczenia + "'," + licznik +
                "," + paliwo + "," + dowod + ")");
        }

        public static void NewItemsInvoice(int IID, int MAGID, int PID, float COUNT, float price, float vatprice, int WID)
        {
            Connect.SetCommand("INSERT INTO TransItems (IID,MAGID,PID,CNT,PRICE,VATPRICE,WID) VALUES(" + IID + "," + MAGID +
                "," + PID + "," + COUNT + "," + price.ToString().Replace(',', '.') + "," +
                vatprice.ToString().Replace(',', '.') + "," + WID + ")");
        }

        public static void RemoveItemsInvoice(int IID)
        {
            Connect.SetCommand("DELETE FROM TransItems WHERE IID=" + IID);
        }


        public static void UpdateTransakcja(int ID, string numer, int CID, int UID, int platnosc,
            float price, float vatprice, int status, string Data, string uwagi,
            int CARID, string termin, string terminu, int licznik, int paliwo, int dowod)
        {
            string Query = "UPDATE Transakcje SET NUMER='" + numer + "', PRICE=" +
                price.ToString().Replace(',', '.') + ", VATPRICE=" +
                vatprice.ToString().Replace(',', '.') + ", CID=" + CID + ", UID=" + UID +
                ", PLATNOSC=" + platnosc + ", DATA='" + Data + "', STATUS=" + status +
                ", UWAGI='" + uwagi + "', CARID=" + CARID + ", TERMIN='" + termin + 
                "', TERMINU='" + terminu + "', Licznik=" + licznik + ", Paliwo=" + paliwo +
                ",Dowod=" + dowod +
                " WHERE ID=" + ID;

            Connect.SetCommand(Query);
        }


        #endregion

        #region CUSTOMERS

        public static List<Klient> GetCustomers(int ID, string firma, string imie, string nazwisko, string nip,
            string pesel, string bank)
        {
            string Query = "SELECT * FROM Customers WHERE ID IS NOT NULL";

            if (ID > 0) Query += " AND ID=" + ID;
            if (!String.IsNullOrEmpty(firma)) Query += " AND FIRMA LIKE '" + firma + "%'";
            if (!String.IsNullOrEmpty(imie)) Query += " AND IMIE LIKE '" + imie + "%'";
            if (!String.IsNullOrEmpty(nazwisko)) Query += " AND NAZWISKO LIKE '" + nazwisko + "%'";
            if (!String.IsNullOrEmpty(nip)) Query += " AND NIP LIKE '" + nip + "%'";
            if (!String.IsNullOrEmpty(pesel)) Query += " AND PESEL LIKE '" + pesel + "%'";
            if (!String.IsNullOrEmpty(bank)) Query += " AND BANK LIKE '" + bank + "%'";

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Klient> customers = new List<Klient>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Klient customer = new Klient();

                customer.ID = int.Parse(table.Rows[i][0].ToString());
                customer.FIRMA = table.Rows[i][1].ToString();
                customer.IMIE = table.Rows[i][2].ToString();
                customer.NAZWISKO = table.Rows[i][3].ToString();
                customer.ADRES = table.Rows[i][4].ToString();
                customer.NIP = table.Rows[i][5].ToString();
                customer.PESEL = table.Rows[i][6].ToString();
                customer.BANK = table.Rows[i]["BANK"].ToString();
                customer.TELEFON = table.Rows[i]["TEL"].ToString();

                customers.Add(customer);
            }

            return customers;
        }

        public static int NewCustomer(string firma, string imie, string nazwisko, string adres, string nip, 
            string pesel, string bank, string telefon)
        {
            return Connect.SetIDCommand("INSERT INTO Customers (FIRMA,IMIE,NAZWISKO,ADRES,NIP,PESEL,BANK,TEL) VALUES('" + firma + "','" +
                imie + "','" + nazwisko + "','" + adres + "','" + nip + "','" + pesel + "','" + bank + 
                "','" + telefon + "')");
        }

        public static void UpdateCustomer(int CID, string firma, string imie, string nazwisko, string adres, 
            string nip, string pesel, string bank, string telefon)
        {
            Connect.SetCommand("UPDATE Customers SET FIRMA='" + firma + "', IMIE='" + imie + "', NAZWISKO='" +
                nazwisko + "', ADRES='" + adres + "', NIP='" + nip + "', PESEL='" + pesel + 
                "', BANK='" + bank + "', TEL='" + telefon + "' WHERE ID=" + CID);
        }

        #endregion

        #region CARSs

        public static List<Car> GetCars(int ID, int CID, string MARKA, string MODEL,
            string POJ, string TYP, string ROK, string REJESTRACJA, string VIN,
            string SILNIK, string BadanieOd, string BadanieDo)
        {
            string Query = "SELECT CR.*, (Customers.FIRMA + ',' + Customers.IMIE + ' ' + Customers.NAZWISKO + ',' + Customers.ADRES) AS KONTRAHENT FROM " + 
                "(SELECT * FROM Cars WHERE ID IS NOT NULL";

            if (ID > 0) Query += " AND ID=" + ID;
            if (CID > 0) Query += " AND CID=" + CID;
            if (!String.IsNullOrEmpty(MARKA)) Query += " AND Marka LIKE '" + MARKA + "%'";
            if (!String.IsNullOrEmpty(MODEL)) Query += " AND Model LIKE '" + MODEL + "%'";
            if (!String.IsNullOrEmpty(POJ)) Query += " AND Poj LIKE '" + POJ + "%'";
            if (!String.IsNullOrEmpty(TYP)) Query += " AND Typ LIKE '" + TYP + "%'";
            if (!String.IsNullOrEmpty(ROK)) Query += " AND Rok LIKE '" + ROK + "%'";
            if (!String.IsNullOrEmpty(REJESTRACJA)) Query += " AND Rej LIKE '" + REJESTRACJA + "%'";
            if (!String.IsNullOrEmpty(VIN)) Query += " AND Vin LIKE '" + VIN + "%'";
            if (!String.IsNullOrEmpty(SILNIK)) Query += " AND Silnik LIKE '" + SILNIK + "%'";
            if (!String.IsNullOrEmpty(BadanieOd)) Query += " AND Badanie >= '" + BadanieOd + 
                "' AND Badanie <= '" + BadanieDo + "'";

            Query += ") CR INNER JOIN Customers ON CR.CID=Customers.ID";

            DataTable table = Connect.FillCommand(Query);

            if (table == null) return null;
            else if (table.Rows.Count == 0) return null;

            List<Car> cars = new List<Car>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Car car = new Car();

                car.ID = int.Parse(table.Rows[i]["ID"].ToString());
                car.CID = int.Parse(table.Rows[i]["CID"].ToString());
                car.KONTRAHENT = table.Rows[i]["KONTRAHENT"].ToString();
                car.MARKA = table.Rows[i]["Marka"].ToString();
                car.MODEL = table.Rows[i]["Model"].ToString();
                car.POJEMNOSC = table.Rows[i]["Poj"].ToString();
                car.TYP = table.Rows[i]["Typ"].ToString();
                car.ROK = table.Rows[i]["Rok"].ToString();
                car.REJESTRACJA = table.Rows[i]["Rej"].ToString();
                car.VIN = table.Rows[i]["Vin"].ToString();
                car.OPIS = table.Rows[i]["Opis"].ToString();
                car.SILNIK = table.Rows[i]["Silnik"].ToString();
                car.BADANIE = DateTime.Parse(table.Rows[i]["Badanie"].ToString()).ToShortDateString();
                try { car.STAN_LICZNIKA = int.Parse(table.Rows[i]["Licznik"].ToString()); }
                catch { car.STAN_LICZNIKA = -1; }

                try { car.STAN_PALIWA = int.Parse(table.Rows[i]["Paliwo"].ToString()); }
                catch { car.STAN_PALIWA = -1; }

                try { car.DATA_PRZYJECIA = DateTime.Parse(table.Rows[i]["DataP"].ToString()).ToShortDateString(); }
                catch { car.DATA_PRZYJECIA = null; }

                try { car.DATA_WYDANIA = DateTime.Parse(table.Rows[i]["DataW"].ToString()).ToShortDateString(); }
                catch { car.DATA_WYDANIA = null; }

                try { car.DOWOD = int.Parse(table.Rows[i]["Dowod"].ToString()); }
                catch { car.DOWOD = -1; }

                cars.Add(car);
            }

            return cars;
        }

        public static int NewCar(int CID, string MARKA, string MODEL,
            string POJ, string TYP, string ROK, string REJESTRACJA, string VIN,
            string OPIS, string SILNIK, string BADANIE, int LICZNIK, int PALIWO,
            string DATAP, string DATAW, int DOWOD)
        {
            return Connect.SetIDCommand("INSERT INTO Cars(CID,Marka,Model,Poj,Typ,Rok,Rej,Vin,Opis,Silnik,Badanie,Licznik,Paliwo,DataP,DataW,Dowod) " +
                "VALUES(" + CID + ",'" + MARKA + "','" + MODEL + "','" + POJ + "','" +
                TYP + "','" + ROK + "','" + REJESTRACJA + "','" + VIN + "','" +
                OPIS + "','" + SILNIK + "','" + BADANIE + "'," + LICZNIK + "," +
                PALIWO + ",'" + DATAP + "','" + DATAW + "'," + DOWOD + ")");
        }

        public static void UpdateCar(int ID, int CID, string MARKA, string MODEL,
            string POJ, string TYP, string ROK, string REJESTRACJA, string VIN,
            string OPIS, string SILNIK, string BADANIE, int LICZNIK, int PALIWO,
            string DATAP, string DATAW, int DOWOD)
        {
            Connect.SetCommand("UPDATE Cars SET CID=" + CID + ", Marka='" + MARKA +
                "', Model='" + MODEL + "', Poj='" + POJ + "', Typ='" + TYP + "', Rok='" +
                ROK + "', Rej='" + REJESTRACJA + "', Vin='" + VIN + "', Opis='" + OPIS +
                "', Silnik='" + SILNIK + "', Badanie='" + BADANIE + "', Licznik=" +
                LICZNIK + ", Paliwo=" + PALIWO + ", DataP='" + DATAP + "', DataW='" +
                DATAW + "', Dowod=" + DOWOD + " WHERE ID=" + ID);
        }

        #endregion

        #region USTERKI

        public static List<UsterkaCls> GetUsterki(int CARID)
        {
            string Query = "SELECT * FROM Usterki WHERE ID IS NOT NULL";

            if (CARID > -1) Query += " AND CARID=" + CARID;

            DataTable table = Connect.FillCommand(Query);

            if (table == null) return null;
            if (table.Rows.Count == 0) return null;

            List<UsterkaCls> usterki = new List<UsterkaCls>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                UsterkaCls usterka = new UsterkaCls();

                usterka.ID = int.Parse(table.Rows[i]["ID"].ToString());
                usterka.CARID = int.Parse(table.Rows[i]["CARID"].ToString());
                usterka.USTERKA = table.Rows[i]["USTERKA"].ToString();

                usterki.Add(usterka);
            }

            return usterki;
        }

        public static void NewUsterka(int CARID, string USTERKA)
        {
            Connect.SetCommand("INSERT INTO Usterki(CARID,USTERKA) VALUES(" + CARID +
                ",'" + USTERKA + "')");
        }

        public static void UpdateUsterka(int ID, int CARID, string USTERKA)
        {
            Connect.SetCommand("UPDATE Usterki SET CARID=" + CARID + ", USTERKA='" +
                USTERKA + "' WHERE ID=" + ID);
        }

        public static void DeleteUsterka(int ID)
        {
            Connect.SetCommand("DELETE FROM Usterki WHERE ID=" + ID);
        }

        #endregion

        #region KSIEGA

        public static int GetMaxLp()
        {

            DataTable table = Connect.FillCommand("SELECT MAX(LP) AS MX FROM Ksiega");

            if (table == null) return 0;

            if (String.IsNullOrEmpty(table.Rows[0]["MX"].ToString())) return 0;

            return int.Parse(table.Rows[0]["MX"].ToString());
        }

        public static List<KsiegaCls> GetUmarli(int ID, string DataPOd, string DataPDo,
            string Imie, string Nazwisko, string DataUrOd, string DataUrDo,
            string DataZgOd, string DataZgDo, int CMID, int KATGRID,
            int POLE_OD, int POLE_DO, int RZAD_OD, int RZAD_DO,
            int SEKTOR_OD, int SEKTOR_DO, int CID, 
            string DataAbOd, string DataAbDo, int PLEC)
        {
            string Query = "SELECT * FROM Ksiega WHERE ID IS NOT NULL";

            if (ID > 0) Query += " AND ID=" + ID;
            if (!String.IsNullOrEmpty(DataPOd)) Query += " AND DATA >= '" + DataPOd +
                "' AND DATA <= '" + DataPDo + "'";
            if (!String.IsNullOrEmpty(Imie)) Query += " AND IMIE LIKE '" + Imie + "%'";
            if (!String.IsNullOrEmpty(Nazwisko)) Query += " AND NAZWISKO LIKE '" + Nazwisko + "%'";
            if (!String.IsNullOrEmpty(DataUrOd)) Query += " AND DATAUR >= '" + DataUrOd +
                "' AND DATAUR <= '" + DataUrDo + "'";
            if (!String.IsNullOrEmpty(DataZgOd)) Query += " AND DATAZG >= '" + DataZgOd +
                "' AND DATAZG <= '" + DataZgDo + "'";

            if (KATGRID > 0) Query += " AND KATGRID=" + KATGRID;

            if (POLE_OD > 0 && POLE_DO < 0) Query += " AND POLE=" + POLE_OD;
            if (POLE_OD > 0 && POLE_DO > 0) Query += " AND POLE >= " + POLE_OD +
                " AND POLE <= " + POLE_DO;
            if (RZAD_OD > 0 && RZAD_DO < 0) Query += " AND RZAD=" + RZAD_OD;
            if (RZAD_OD > 0 && RZAD_DO > 0) Query += " AND RZAD >= " + RZAD_OD + 
                " AND RZAD <= " + RZAD_DO;
            if (SEKTOR_OD > 0 && SEKTOR_DO < 0) Query += " AND SEKTOR=" + SEKTOR_OD;
            if (SEKTOR_OD > 0 && SEKTOR_DO > 0) Query += " AND SEKTOR >= " + SEKTOR_OD +
                " AND SEKTOR <= " + SEKTOR_DO;
            if (CID > 0) Query += " AND CID=" + CID;
            
            if (!String.IsNullOrEmpty(DataAbOd)) Query += " AND DATAAB >= '" + DataAbOd +
                "' AND DATAAB <= '" + DataAbDo + "'";
            if (PLEC > 0) Query += " AND PLEC=" + PLEC;

            DataTable table = Connect.FillCommand(Query);

            if (table == null) return null;
            else if (table.Rows.Count == 0) return null;

            List<KsiegaCls> umarli = new List<KsiegaCls>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                KsiegaCls umarly = new KsiegaCls();

                umarly.ID = int.Parse(table.Rows[i]["ID"].ToString());
                umarly.LP = int.Parse(table.Rows[i]["LP"].ToString());
                umarly.DATA_POGRZEBU = DateTime.Parse(table.Rows[i]["DATA"].ToString()).ToShortDateString();
                umarly.IMIE = table.Rows[i]["IMIE"].ToString();
                umarly.NAZWISKO = table.Rows[i]["NAZWISKO"].ToString();
                umarly.ADRES = table.Rows[i]["ADRES"].ToString();
                umarly.DATA_URODZENIA = DateTime.Parse(table.Rows[i]["DATAUR"].ToString()).ToShortDateString();
                umarly.DATA_ZGONU = DateTime.Parse(table.Rows[i]["DATAZG"].ToString()).ToShortDateString();
                umarly.CMID = int.Parse(table.Rows[i]["CMID"].ToString());
                umarly.KATGRID = int.Parse(table.Rows[i]["KATGRID"].ToString());

                try { umarly.POLE = int.Parse(table.Rows[i]["POLE"].ToString()); }
                catch { }

                try { umarly.RZAD = int.Parse(table.Rows[i]["RZAD"].ToString()); }
                catch { }

                try { umarly.SEKTOR = int.Parse(table.Rows[i]["SEKTOR"].ToString()); }
                catch { }

                umarly.UWAGI = table.Rows[i]["UWAGI"].ToString();
                umarly.CID = int.Parse(table.Rows[i]["CID"].ToString());
                umarly.LAT = int.Parse(table.Rows[i]["LAT"].ToString());
                umarly.DATA_ABONAMENT = DateTime.Parse(table.Rows[i]["DATAAB"].ToString()).ToShortDateString();
                umarly.PLEC = int.Parse(table.Rows[i]["PLEC"].ToString());

                umarli.Add(umarly);
            }

            return umarli;

        }

        public static int NewUmarly(int LP, string Data, string Imie, string Nazwisko, string Adres,
            string DataUr, string DataZg, int CMID, int KATGRID, int POLE, int RZAD,
            int SEKTOR, string UWAGI, int CID, int LAT, string DataAb, int PLEC)
        {
            return Connect.SetIDCommand("INSERT INTO Ksiega(LP,DATA,IMIE,NAZWISKO,ADRES," +
                "DATAUR,DATAZG,CMID,KATGRID,POLE,RZAD,SEKTOR,UWAGI,CID,LAT,DATAAB," +
                "PLEC) VALUES(" + LP + ",'" + Data + "','" + Imie + "','" + Nazwisko +
                "','" + Adres + "','" + DataUr + "','" + DataZg + "'," + CMID +
                "," + KATGRID + "," + POLE + "," + RZAD + "," + SEKTOR + ",'" +
                UWAGI + "'," + CID + "," + LAT + ",'" + DataAb + "'," + PLEC + ")");
        }


        public static void UpdateUmarly(int ID, int LP, string Data, string Imie, string Nazwisko, string Adres,
            string DataUr, string DataZg, int CMID, int KATGRID, int POLE, int RZAD,
            int SEKTOR, string UWAGI, int CID, int LAT, string DataAb, int PLEC)
        {
            Connect.SetCommand("UPDATE Ksiega SET LP=" + LP + ", DATA='" + Data +
                "', IMIE='" + Imie + "', NAZWISKO='" + Nazwisko + "', ADRES='" +
                Adres + "', DATAUR='" + DataUr + "', DATAZG='" + DataZg +
                "', CMID=" + CMID + ", KATGRID=" + KATGRID + ", POLE=" + POLE +
                ", RZAD=" + RZAD + ", SEKTOR=" + SEKTOR + ", UWAGI='" + UWAGI +
                "', CID=" + CID + ", LAT=" + LAT + ", DATAAB='" + DataAb +
                "', PLEC='" + PLEC + "' WHERE ID=" + ID);
        }

        #region CMENTARZE

        public static List<CmentarzCls> GetCmentarze(int ID, string nazwa)
        {
            string Query = "SELECT * FROM Cmentarze WHERE ID IS NOT NULL";

            if (ID > 0) Query += " AND ID=" + ID;
            if (!String.IsNullOrEmpty(nazwa)) Query += " AND NAZWA LIKE '" + nazwa + "%'";

            DataTable table = Connect.FillCommand(Query);

            if (table == null) return null;

            List<CmentarzCls> cmentarze = new List<CmentarzCls>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                CmentarzCls cmentarz = new CmentarzCls();

                cmentarz.ID = int.Parse(table.Rows[i]["ID"].ToString());
                cmentarz.NAZWA = table.Rows[i]["NAZWA"].ToString();
                cmentarz.ADRES = table.Rows[i]["ADRES"].ToString();

                cmentarze.Add(cmentarz);
            }

            return cmentarze;
        }

        public static int NewCmentarz(string nazwa, string adres)
        {
            return Connect.SetIDCommand("INSERT INTO Cmentarze(NAZWA,ADRES) VALUES('" +
                nazwa + "','" + adres + "')");
        }

        public static void UpdateCmentarz(string nazwa, string adres)
        {
            Connect.SetCommand("UPDATE Cmentarze SET NAZWA='" + nazwa + "', ADRES='" +
                adres + "'");
        }

        #endregion

        #region KATEGORIE GROBOW

        public static List<KatGrobCls> GetKatGrobow(int ID, string nazwa)
        {
            string Query = "SELECT * FROM KatGrob WHERE ID IS NOT NULL";

            if (ID > 0) Query += " AND ID=" + ID;
            if (!String.IsNullOrEmpty(nazwa)) Query += " AND NAZWA='" + nazwa + "'";

            DataTable table = Connect.FillCommand(Query);

            if (table == null) return null;

            List<KatGrobCls> kategorie = new List<KatGrobCls>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                KatGrobCls kategoria = new KatGrobCls();

                kategoria.ID = int.Parse(table.Rows[i]["ID"].ToString());
                kategoria.NAZWA = table.Rows[i]["NAZWA"].ToString();

                kategorie.Add(kategoria);
            }

            return kategorie;
        }

        public static int NewKategoriaGrobu(string nazwa)
        {
            return Connect.SetIDCommand("INSERT INTO KatGrob(NAZWA) VALUES('" +
                nazwa + "')");
        }

        public static void UpdateKategoria(string nazwa)
        {
            Connect.SetCommand("UPDATE KatGrob SET NAZWA='" + nazwa + "'");
        }

        #endregion

        #endregion

        #region Users

        public static Users Login(string user, string password)
        {
            DataTable table = new DataTable();

            table = Connect.FillCommand("SELECT * FROM Urs WHERE USR='" + user + 
                "' AND PASS='" + password + "'");

            if (table == null || table.Rows.Count == 0) return null;

            Users User = new Users();

            User.ID = int.Parse(table.Rows[0][0].ToString());

            User.IMIE = table.Rows[0][3].ToString();
            User.NAZWISKO = table.Rows[0][4].ToString();
            User.PRIV = (int)table.Rows[0]["PRIV"];

            return User;
        }

        public static bool LoginCheck(string user, string password)
        {
            DataTable table = new DataTable();

            table = Connect.FillCommand("SELECT * FROM Urs WHERE USR='" + user +
                "' AND PASS='" + password + "'");

            if (table == null || table.Rows.Count == 0) return false;

            return true;
        }

        public static List<Users> GetUsers()
        {
            DataTable table = new DataTable();

            table = Connect.FillCommand("SELECT ID, (IMIE + ' ' + NAZWISKO) AS UNAME, PRIV FROM Urs");

            if (table.Rows.Count == 0) return null;

            List<Users> Urs = new List<Users>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Users user = new Users();

                user.ID = (int)table.Rows[i][0];
                user.IMIE = table.Rows[i][1].ToString();
                user.PRIV = (int)table.Rows[i]["PRIV"];

                Urs.Add(user);
            }

            return Urs;
        }

        public static List<Users> GetUserList()
        {
            DataTable table = new DataTable();

            table = Connect.FillCommand("SELECT * FROM Urs");

            if (table.Rows.Count == 0) return null;

            List<Users> Urs = new List<Users>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Users user = new Users();

                user.ID = (int)table.Rows[i]["ID"];
                user.IMIE = table.Rows[i]["IMIE"].ToString();
                user.NAZWISKO = table.Rows[i]["NAZWISKO"].ToString();
                user.LOGIN = table.Rows[i]["USR"].ToString();
                user.PRIV = (int)table.Rows[i]["PRIV"];

                Urs.Add(user);
            }

            return Urs;
        }

        public static bool CheckUserName(string user)
        {
            if (Connect.FillCommand("SELECT * FROM Urs WHERE USR='" + user + "'") != null)
                return false;

            return true;
        }


        public static void NewUser(string newUser, string newPassword, string imie, string nazwisko, int priv)
        {

            Connect.SetCommand("INSERT INTO Urs (USR,PASS,IMIE,NAZWISKO,PRIV) VALUES('" + newUser + "','" +
                newPassword + "','" + imie + "','" + nazwisko + "'," + priv + ")");

        }

        public static void UpdateUser(int id, string password, int priv)
        {
            string Query = "UPDATE Urs SET ";

            if (!String.IsNullOrEmpty(password)) Query += "PASS='" + password + "', ";

            Query += "PRIV=" + priv + " WHERE ID=" + id;

            Connect.SetCommand(Query);
        }


        #endregion

        #region WORKERS

        public static List<Worker> GetWorkers(int ID, string imie, string nazwisko, string pesel, string nip, 
            string bank)
        {
            string Query = "SELECT * FROM Workers WHERE ID IS NOT NULL";

            if (ID > 0) Query += " AND ID=" + ID;
            if (!String.IsNullOrEmpty(imie)) Query += " AND IMIE LIKE '" + imie + "%'";
            if (!String.IsNullOrEmpty(nazwisko)) Query += " AND NAZWISKO LIKE '" + nazwisko + "%'";
            if (!String.IsNullOrEmpty(pesel)) Query += " AND PESEL LIKE '" + pesel + "%'";
            if (!String.IsNullOrEmpty(nip)) Query += " AND NIP LIKE '" + nip + "%'";
            if (!String.IsNullOrEmpty(bank)) Query += " AND BANK LIKE '" + bank + "%'";

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Worker> workers = new List<Worker>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Worker worker = new Worker();

                worker.ID = (int)table.Rows[i]["ID"];
                worker.IMIE = table.Rows[i]["IMIE"].ToString();
                worker.NAZWISKO = table.Rows[i]["NAZWISKO"].ToString();
                worker.ADRES = table.Rows[i]["ADRESS"].ToString();
                worker.PESEL = table.Rows[i]["PESEL"].ToString();
                worker.NIP = table.Rows[i]["NIP"].ToString();
                worker.BANK = table.Rows[i]["BANK"].ToString();

                workers.Add(worker);
            }

            return workers;
        }

        public static int NewWorker(string imie, string nazwisko,string adres, string pesel, string nip,
            string bank)
        {
            return Connect.SetIDCommand("INSERT INTO Workers (IMIE,NAZWISKO,ADRESS,PESEL,NIP,BANK) VALUES('" + imie + 
                "','" + nazwisko + "','" + adres + "','" + pesel + "','" + nip + "','" + bank + "')");
        }

        public static void UpdateWorker(int ID, string imie, string nazwisko, string adres, string pesel,
            string nip, string bank)
        {
            Connect.SetCommand("UPDATE Workers SET IMIE='" + imie + "', NAZWISKO='" + nazwisko + "', ADRESS='" +
                adres + "', PESEL='" + pesel + "', NIP='" + nip + "', BANK='" + bank + "' WHERE ID=" + ID);
        }

        #endregion

        #region MAGAZYN

        #region PZWZ

        public static List<Produkt> GetPzWz(int UID, int CID, int MIDI, int MIDII, int TYPE, string DataOd,
            string DataDo)
        {
            string Query = "SELECT PWZM.*, MagType.MAGAZYN AS MAGAZYN FROM " +
                "(SELECT PWZC.*, (Customers.FIRMA + ', ' + Customers.IMIE + ' ' + Customers.NAZWISKO + ', ' + Customers.ADRES) AS FIRMA FROM " +
                "(SELECT PWZ.*, (Urs.IMIE + ' ' + Urs.NAZWISKO) AS Urs FROM " +
                "(SELECT * FROM PZWZ WHERE ID IS NOT NULL";

            if (UID > 0) Query += " AND UID=" + UID;
            if (TYPE > 1)
            {
                if (MIDI > 0) Query += " AND MID=" + MIDI;
                if (MIDII > 0) Query += " AND CID=" + MIDII;
            }
            else
            {
                if (CID > 0) Query += " AND CID=" + CID;
                if (MIDI > 0) Query += " AND MID=" + MIDI;
            }

            if (TYPE > 0) Query += " AND TYPE=" + TYPE;

            if (!String.IsNullOrEmpty(DataOd)) Query += " AND DATA >= '" + DateTime.Parse(DataOd) + "'";
            if (!String.IsNullOrEmpty(DataDo)) Query += " AND DATA <= '" + DateTime.Parse(DataDo) + "'";

            Query += ") PWZ INNER JOIN Urs ON PWZ.UID=Urs.ID";

            Query += ") PWZC INNER JOIN Customers ON PWZC.CID=Customers.ID";

            Query += ") PWZM INNER JOIN MagType ON PWZM.MID=MagType.ID";

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Produkt> pzwzLista = new List<Produkt>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Produkt pzwz = new Produkt();

                pzwz.PZWZID = (int)table.Rows[i]["ID"];
                pzwz.UID = (int)table.Rows[i]["UID"];
                pzwz.CID = (int)table.Rows[i]["CID"];
                pzwz.MID = (int)table.Rows[i]["MID"];
                pzwz.TYPE = (int)table.Rows[i]["TYPE"];
                pzwz.DATA = table.Rows[i]["DATA"].ToString().Substring(0,10);
                pzwz.SUMA = float.Parse(table.Rows[i]["SUMA"].ToString());
                pzwz.UNAME = table.Rows[i]["Urs"].ToString();
                pzwz.CNAME = table.Rows[i]["FIRMA"].ToString();
                //pzwz.MID = (int)table.Rows[i]["MagType.ID"];
                pzwz.MAGAZYN = table.Rows[i]["MAGAZYN"].ToString();

                pzwzLista.Add(pzwz);
            }

            return pzwzLista;
          
        }

        public static List<Produkt> GetPzWzItems(int PZID)
        {
            string Query = "SELECT ITC.*, Customers.FIRMA, Customers.IMIE, Customers.NAZWISKO, Customers.ADRES FROM" +
                " (SELECT IT.*, Programs.CATID, Programs.CID, Programs.NUMERKAT, Programs.MODEL, Programs.NUMERSER, Programs.OPIS, Programs.NAZWA, Programs.PRICE, Programs.VATPRICE AS PVATPRICE, Programs.PRICE2, Programs.VATPRICE2 , Programs.JEDNOSTKA, Programs.PROWIZJA FROM" +
                " (SELECT * FROM ItemsPzWz WHERE PZID=" + PZID;

            Query += ") IT INNER JOIN Programs ON IT.PID=Programs.ID";

            Query += ") ITC INNER JOIN Customers ON ITC.CID=Customers.ID";

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Produkt> pzwzs = new List<Produkt>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Produkt pzwz = new Produkt();

                pzwz.ID = (int)table.Rows[i]["ID"];
                pzwz.PID = (int)table.Rows[i]["PID"];
                pzwz.STAN = float.Parse(table.Rows[i]["CNT"].ToString());
                pzwz.SUMA = float.Parse(table.Rows[i]["VATPRICE"].ToString());
                //pzwz.PID = (int)table.Rows[i]["Programs.ID"];
                pzwz.CATID = (int)table.Rows[i]["CATID"];
                pzwz.CID = (int)table.Rows[i]["CID"];
                pzwz.NAME = table.Rows[i]["NAZWA"].ToString();
                pzwz.PRICE = float.Parse(table.Rows[i]["PRICE"].ToString());
                pzwz.VATPRICE = float.Parse(table.Rows[i]["PVATPRICE"].ToString());
                try { pzwz.PRICE2 = float.Parse(table.Rows[i]["PRICE2"].ToString()); }
                catch { pzwz.PRICE2 = 0; }
                try { pzwz.VATPRICE2 = float.Parse(table.Rows[i]["VATPRICE2"].ToString()); }
                catch { pzwz.VATPRICE2 = 0; }
                pzwz.JEDNOSTKA = table.Rows[i]["JEDNOSTKA"].ToString();
                pzwz.PROWIZJA = int.Parse(table.Rows[i]["PROWIZJA"].ToString());
                pzwz.CNAME = table.Rows[i]["FIRMA"].ToString() + ", " + table.Rows[i]["IMIE"].ToString() + " " +
                    table.Rows[i]["NAZWISKO"].ToString() + ", " + table.Rows[i]["ADRES"].ToString();

                //pzwz.SUMA = float.Parse(table.Rows[i]["VATPRICE"].ToString());

                pzwzs.Add(pzwz);
            }

            return pzwzs;
        }

        public static int NewPzWz(int UID, int CID, int MID, int TYPE, string DATA, float SUMA)
        {
            return Connect.SetIDCommand("INSERT INTO PZWZ (UID,CID,MID,TYPE,DATA,SUMA) VALUES(" + UID + "," + 
                CID + "," + MID + "," + TYPE + ",'" + DATA + "'," + SUMA.ToString().Replace(',','.') + ")");
        }

        public static void NewPzWzItems(int PZWZID, Produkt[] towary)
        {
            for (int i = 0; i < towary.Length; i++)
                Connect.SetCommand("INSERT INTO ItemsPzWz (PZID,PID,CNT,VATPRICE) VALUES(" + PZWZID +
                    "," + towary[i].ID + "," + towary[i].STAN + "," + 
                    towary[i].SUMA.ToString().Replace(',','.') + ")");
            
        }

    

        #endregion

        #region MAGAZYN

        public static Produkt CheckTowarInMagazyn(int PID, int MID)
        {
            DataTable table = new DataTable();

            table = Connect.FillCommand("SELECT * FROM Magazyn WHERE PID=" + PID + " AND MID=" + MID);

            if (table.Rows.Count == 0) return null;

            Produkt towar = new Produkt();

            towar.ID = (int)table.Rows[0]["ID"];
            towar.COUNT = float.Parse(table.Rows[0]["CNT"].ToString());

            return towar;
        }

        public static List<Produkt> GetTowarFromMagazyn(int CID, int CATID, int PID, int MID, string nazwa_towaru,
            string numer_kat, string model, string numer_seryjny)
        {
            string Query = "SELECT TPCAT.*, Categories.CATEGORY FROM" +
                " (SELECT TPC.*, Customers.FIRMA, Customers.IMIE, Customers.NAZWISKO, Customers.ADRES AS CADRESS FROM" +
                " (SELECT TPP.*, MagType.MAGAZYN, MagType.ADRES FROM" +
                 " (SELECT TP.*, Programs.CATID, Programs.CID, Programs.NUMERKAT, Programs.MODEL, Programs.NUMERSER, Programs.OPIS, Programs.NAZWA, Programs.PRICE, Programs.VATPRICE, Programs.PRICE2, Programs.VATPRICE2, Programs.JEDNOSTKA, Programs.PROWIZJA  FROM" + 
                 " (SELECT ID, PID, MID, CNT FROM Magazyn WHERE ID IS NOT NULL";

            if (PID > 0) Query += " AND PID=" + PID;
            if (MID > 0) Query += " AND MID=" + MID;

            Query += ") TP INNER JOIN Programs ON TP.PID=Programs.ID WHERE Programs.ID IS NOT NULL";

            if (PID > 0) Query += " AND Programs.ID=" + PID;
            if (CID > 0) Query += " AND Programs.CID=" + CID;

            if (!String.IsNullOrEmpty(nazwa_towaru)) Query += " AND NAZWA LIKE '" + nazwa_towaru + "%'";
            if (!String.IsNullOrEmpty(numer_kat)) Query += " AND NUMERKAT LIKE '" + numer_kat + "%'";
            if (!String.IsNullOrEmpty(model)) Query += " AND MODEL LIKE '" + model + "%'";
            if (!String.IsNullOrEmpty(numer_seryjny)) Query += " AND NUMERSER LIKE '" + numer_seryjny + "%'";

            Query += ") TPP INNER JOIN MagType ON TPP.MID=MagType.ID";

            Query += ") TPC INNER JOIN Customers ON TPC.CID=Customers.ID";

            Query += ") TPCAT INNER JOIN Categories ON TPCAT.CATID=Categories.ID";

            if (CATID > 0) Query += " WHERE Categories.ID=" + CATID;

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Produkt> towary = new List<Produkt>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Produkt towar = new Produkt();


                towar.ID = (int)table.Rows[i]["ID"];
                towar.PID = (int)table.Rows[i]["PID"];
                towar.MID = (int)table.Rows[i]["MID"];
                towar.COUNT = float.Parse(table.Rows[i]["CNT"].ToString());
                towar.CATID = (int)table.Rows[i]["CATID"];
                towar.CID = (int)table.Rows[i]["CID"];
                towar.NUMERKAT = table.Rows[i]["NUMERKAT"].ToString();
                towar.MODEL = table.Rows[i]["MODEL"].ToString();
                towar.NUMERSER = table.Rows[i]["NUMERSER"].ToString();
                towar.OPIS = table.Rows[i]["OPIS"].ToString();
                towar.NAME = table.Rows[i]["NAZWA"].ToString();
                towar.PRICE = float.Parse(table.Rows[i]["PRICE"].ToString());
                try { towar.PRICE2 = float.Parse(table.Rows[i]["PRICE2"].ToString()); }
                catch { towar.PRICE2 = 0; }
                towar.VATPRICE = float.Parse(table.Rows[i]["VATPRICE"].ToString());
                try { towar.VATPRICE2 = float.Parse(table.Rows[i]["VATPRICE2"].ToString()); }
                catch { towar.VATPRICE2 = 0; }
                towar.JEDNOSTKA = table.Rows[i]["JEDNOSTKA"].ToString();
                towar.MAGAZYN = table.Rows[i]["MAGAZYN"].ToString();
                towar.MAGAZYNADRES = table.Rows[i]["ADRES"].ToString();
                towar.CNAME = table.Rows[i]["FIRMA"].ToString() + ", "
                    + table.Rows[i]["IMIE"].ToString() + " " + table.Rows[i]["NAZWISKO"].ToString() + ", " +
                    table.Rows[i]["CADRESS"].ToString();

                towar.CATNAME = table.Rows[i]["CATEGORY"].ToString();

                towar.PROWIZJA = int.Parse(table.Rows[i]["PROWIZJA"].ToString());

                towary.Add(towar);
            }

            return towary;
        }

        public static void NewTowarToMagazyn(List<Produkt> noweTowary)
        {
            for (int i = 0; i < noweTowary.Count; i++)
            {
                //int PID = -1;

                //if(noweTowary[i].PID == 0)
                
                List<Produkt> towary = GetTowarFromMagazyn(-1, -1, noweTowary[i].PID, noweTowary[i].MID, "", "", "", "");

                //Program towarCount = CheckTowarInMagazyn(noweTowary[i].PID,noweTowary[i].MID);

                if (towary == null)
                    Connect.SetCommand("INSERT INTO Magazyn (PID,MID,CNT) VALUES(" + noweTowary[i].PID + "," +
                        noweTowary[i].MID + "," + noweTowary[i].STAN + ")");

                else
                    Connect.SetCommand("UPDATE Magazyn SET CNT=" + (noweTowary[i].STAN + towary[0].COUNT) +
                        " WHERE ID=" + towary[0].ID);
            }
        }

        public static void RemoveTowarFromMagazyn(List<Produkt> listaTowarow)
        {
            for (int i = 0; i < listaTowarow.Count; i++)
            {
                List<Produkt> towary = GetTowarFromMagazyn(-1, -1, listaTowarow[i].PID, listaTowarow[i].MID, "", "", "", "");
 
                Connect.SetCommand("UPDATE Magazyn SET CNT=" + (towary[0].COUNT - listaTowarow[i].STAN) +
                " WHERE ID=" + towary[0].ID);
            }
        }



        #endregion

        #region MAGAZYNY


        public static List<Mgzyn> GetMagazyny(string magazyn, string adres)
        {
            string Query = "SELECT * FROM MagType WHERE ID IS NOT NULL";

            if (!String.IsNullOrEmpty(magazyn)) Query += " AND MAGAZYN='" + magazyn + "'";
            if (!String.IsNullOrEmpty(adres)) Query += " AND ADRES='" + adres + "'";

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Mgzyn> magazyny = new List<Mgzyn>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Mgzyn newMagazyn = new Mgzyn();

                newMagazyn.ID = (int)table.Rows[i]["ID"];
                newMagazyn.MAGAZYN = table.Rows[i]["MAGAZYN"].ToString();
                newMagazyn.ADRES = table.Rows[i]["ADRES"].ToString();

                magazyny.Add(newMagazyn);
            }

            return magazyny;
        }

        public static int NewMagazyn(string name, string adres)
        {
            return Connect.SetIDCommand("INSERT INTO MagType(MAGAZYN,ADRES) VALUES('" + name + "','" + adres + "')");
        }

        public static void UpdateMagazyn(int ID, string name, string adres)
        {
            Connect.SetCommand("UPDATE MagType SET MAGAZYN='" + name + "', ADRES='" + adres + "' WHERE ID=" + ID);
        }

        #endregion

        #endregion

        #region PRODUCTS

        public static bool CheckProgram(int CATID, int CID, string name, string numerKat, string model,
            string numerSer, float price, float vatprice, string jednostka, int prowizja, 
            float price2, float vatprice2)
        {
            DataTable table = new DataTable();

            table = Connect.FillCommand("SELECT * FROM Programs WHERE CATID=" + CATID + " AND CID=" + CID +
                " AND NAZWA='" + name + "' AND NUMERKAT='" + numerKat + "' AND MODEL='" + model +
                "' AND NUMERSER='" + numerSer + "' AND PRICE=" + price.ToString().Replace(',', '.') +
                " AND VATPRICE=" + vatprice.ToString().Replace(',', '.') +
                " AND JEDNOSTKA='" + jednostka +
                "' AND PROWIZJA=" + prowizja +
                " AND PRICE2=" + price2.ToString().Replace(',', '.') +
                " AND VATPRICE2=" + vatprice2.ToString().Replace(',', '.'));

            if (table.Rows.Count > 0) return true;

            return false;
        }

        public static List<Produkt> GetPrograms(int ID, int CATID, int CID, string name, string numerKat, string model,
            string numerSer)
        {
            DataTable table = new DataTable();

            string Query = "SELECT PRG.*, (Customers.FIRMA + ', ' + Customers.IMIE + ' ' + Customers.NAZWISKO + ', ' + Customers.ADRES) AS [CUSTOMER] FROM" +
                " (SELECT * FROM Programs WHERE ID IS NOT NULL";

            if (ID > 0) Query += " AND ID=" + ID;
            if (!String.IsNullOrEmpty(name)) Query += " AND NAZWA LIKE '" + name + "%'";
            if (CATID > 0) Query += " AND CATID=" + CATID;
            if (CID > 0) Query += " AND CID=" + CID;
            if (!String.IsNullOrEmpty(numerKat)) Query += " AND NUMERKAT LIKE '" + numerKat + "%'";
            if (!String.IsNullOrEmpty(model)) Query += " AND MODEL LIKE '" + model + "%'";
            if (!String.IsNullOrEmpty(numerSer)) Query += " AND NUMERSER LIKE '" + numerSer + "%'";

            Query += ") PRG INNER JOIN Customers ON PRG.CID=Customers.ID";

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Produkt> programs = new List<Produkt>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Produkt program = new Produkt();

                program.ID = int.Parse(table.Rows[i]["ID"].ToString());
                program.NAME = table.Rows[i]["NAZWA"].ToString();
                program.PRICE = float.Parse(table.Rows[i]["PRICE"].ToString().Replace('.',','));
                program.VATPRICE = float.Parse(table.Rows[i]["VATPRICE"].ToString().Replace('.', ','));
                program.CNAME = table.Rows[i]["CUSTOMER"].ToString();
                program.NUMERKAT = table.Rows[i]["NUMERKAT"].ToString();
                program.MODEL = table.Rows[i]["MODEL"].ToString();
                program.NUMERSER = table.Rows[i]["NUMERSER"].ToString();
                program.OPIS = table.Rows[i]["OPIS"].ToString();
                program.CATID = (int)table.Rows[i]["CATID"];
                program.CID = (int)table.Rows[i]["CID"];
                //program.STAN = int.Parse(table.Rows[i]["CNT"].ToString());
                program.JEDNOSTKA = table.Rows[i]["JEDNOSTKA"].ToString();
                program.PROWIZJA = float.Parse(table.Rows[i]["PROWIZJA"].ToString().Replace('.',','));

                try { program.PRICE2 = float.Parse(table.Rows[i]["PRICE2"].ToString().Replace('.', ',')); }
                catch { program.PRICE2 = 0; }

                try { program.VATPRICE2 = float.Parse(table.Rows[i]["VATPRICE2"].ToString().Replace('.', ',')); }
                catch { program.VATPRICE2 = 0; }

                programs.Add(program);
            }

            return programs;
        }

        public static int NewProgram(int CATID ,int CID ,string name,string numerKat, string model,
            string numerSer, string opis, float price, float vatprice, string jednostka, float prowizja,
            float price2, float vatprice2)
        {
            return Connect.SetIDCommand("INSERT INTO Programs (CATID,CID,NAZWA,NUMERKAT,MODEL,NUMERSER,OPIS,PRICE,VATPRICE,JEDNOSTKA,PROWIZJA,PRICE2,VATPRICE2) VALUES("
                + CATID + "," + CID + ",'" + name + "','" + numerKat + "','" + model + "','" + numerSer + "','" + opis + "'," +
                price.ToString().Replace(',', '.') + "," + vatprice.ToString().Replace(',', '.') + ",'" +
                 jednostka + "'," + prowizja.ToString().Replace(',', '.') +
                 "," + price2.ToString().Replace(',', '.') + "," +
                 vatprice2.ToString().Replace(',', '.') + ")");   
        }

        public static void UpdateProgram(int ID, int CATID, int CID, string name,string numerKat, string model,
            string numerSer, string opis, float price, float vatprice, string jednostka, float prowizja,
            float price2, float vatprice2)
        {
            Connect.SetCommand("UPDATE Programs SET CATID=" + CATID + ", CID=" + CID + ", NAZWA='" + name + "', NUMERKAT='" + numerKat +
                "', MODEL='" + model + "', NUMERSER='" + numerSer + "', OPIS='" + opis + "', PRICE=" +
                price.ToString().Replace(',', '.') + ", VATPRICE=" + vatprice.ToString().Replace(',', '.') +
                ", JEDNOSTKA='" + jednostka + "', PROWIZJA=" + prowizja.ToString().Replace(',', '.') +
                ", PRICE2=" + price2.ToString().Replace(',', '.') +
                ", VATPRICE2=" + vatprice2.ToString().Replace(',', '.') + " WHERE ID=" + ID);
        }

        #endregion

        #region CATEGORIES

        public static List<Category> GetCategories(string name)
        {
            DataTable table = new DataTable();

            string Query = "SELECT * FROM Categories";

            if (!String.IsNullOrEmpty(name)) Query += " WHERE CATEGORY='" + name + "'";

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<Category> categories = new List<Category>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Category category = new Category();

                category.ID = int.Parse(table.Rows[i]["ID"].ToString());
                category.NAME = table.Rows[i]["CATEGORY"].ToString();

                categories.Add(category);
            }

            return categories;
        }

        public static int NewCategory(string name)
        {
            return Connect.SetIDCommand("INSERT INTO Categories (CATEGORY) VALUES('" + name + "')");
        }

        public static void UpdateCategory(int ID, string name)
        {
            Connect.SetCommand("UPDATE Categories SET CATEGORY='" + name + "' WHERE ID=" + ID);
        }

        #endregion

        #region USLUGI

        public static List<UslugaC> GetUslugi(int ID, string Numer,
            string Nazwa)
        {
            string Query = "SELECT * FROM Uslugi WHERE ID IS NOT NULL";

            if (ID > 0) Query += " AND ID=" + ID;
            if (!String.IsNullOrEmpty(Numer)) Query += " AND Numer LIKE '" + Numer + "%'";
            if (!String.IsNullOrEmpty(Nazwa)) Query += " AND Nazwa LIKE '" + Nazwa + "%'";

            DataTable table = new DataTable();

            table = Connect.FillCommand(Query);

            if (table.Rows.Count == 0) return null;

            List<UslugaC> uslugi = new List<UslugaC>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                UslugaC usluga = new UslugaC();

                usluga.ID = int.Parse(table.Rows[i]["ID"].ToString());
                usluga.NUMER = table.Rows[i]["Numer"].ToString();
                usluga.NAZWA = table.Rows[i]["Nazwa"].ToString();
               
                usluga.Netto = float.Parse(table.Rows[i]["Netto"].ToString());
                usluga.VAT = int.Parse(table.Rows[i]["VAT"].ToString());
                usluga.Brutto = float.Parse(table.Rows[i]["Brutto"].ToString());
                usluga.OPIS = table.Rows[i]["Opis"].ToString();

                try { usluga.TIME_INDEX = (WorkIdx.TYPE)(int.Parse(table.Rows[i]["TimeIndex"].ToString())); }
                catch { usluga.TIME_INDEX = WorkIdx.TYPE.SELECT; }

                uslugi.Add(usluga);
            }

            return uslugi;
        }

        public static int NewUsluga(string Numer, string Nazwa, string Opis,
            float Netto, int VAT, float Brutto, int Time_Index)
        {
            return Connect.SetIDCommand("INSERT INTO Uslugi(Numer,Nazwa,Opis,Netto,VAT,Brutto,TimeIndex)" +
                " VALUES('" + Numer + "','" + Nazwa + "','" + Opis + "'," +
                Netto.ToString().Replace(',','.') + "," + VAT + "," +
                Brutto.ToString().Replace(',','.') + "," + Time_Index + ")");
        }

        public static void UpdateUsluga(int ID, string Numer, string Nazwa, string Opis,
            float Netto, int VAT, float Brutto, int Time_Index)
        {
            Connect.SetCommand("UPDATE Uslugi SET Numer='" + Numer + "', Nazwa='" +
                Nazwa + "', Opis='" + Opis + "', Netto=" +
                Netto.ToString().Replace(',', '.') + ", VAT=" + VAT + ", Brutto=" +
                Brutto.ToString().Replace(',', '.') + ", TimeIndex=" + Time_Index +
                " WHERE ID=" + ID);
        }


        #endregion
    }
}
