using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Stampa;
using System.Windows.Forms;
using Seller.Class;
using Seller.CONTROLS.Pracownicy;
using System.IO;
using System.Drawing;

namespace Seller.Class
{
    public static class Drukuj
    {

        #region PRIVATE

        private static ReportDocument document = new ReportDocument();

        private static DataTable printTable = new DataTable("tabela");
        private static DataTable printTable2 = new DataTable("tabela2");
        private static DataTable printTable3 = new DataTable("tabela3");

        private static DataTable printSuma = new DataTable("tabelaSuma");

        #endregion

        static Drukuj()
        {

        }

        #region INVOICE

        private static void SetForNormalInvoice(ref Transakcje transakcje)
        {
            if (transakcje.PRODUKTY == null) goto uslugi;
            //for(int O=0;O<40;O++)
            for (int i = 0; i < transakcje.PRODUKTY.Count; i++)
                printTable.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].STAN,
                        MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE2.ToString()), MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_NETTO.ToString()), Settings.PROCENT + "%",
                        MathHelp.AddZero(transakcje.PRODUKTY[i].KWOTA_VAT.ToString()), MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));

            uslugi:

            int i2 = 0;

            if (transakcje.USLUGI == null) return;

            if (transakcje.PRODUKTY != null) i2 = transakcje.PRODUKTY.Count;
            else i2 = 0;

            for (int i = 0; i < transakcje.USLUGI.Count; i++)
                printTable.Rows.Add(i + i2 + 1, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, "1",
                      MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()), MathHelp.AddZero(transakcje.USLUGI[i].SumaNetto.ToString()), transakcje.USLUGI[i].VAT + "%",
                      MathHelp.AddZero(transakcje.USLUGI[i].KWOTA_VAT.ToString()), MathHelp.AddZero(transakcje.USLUGI[i].SumaBrutto.ToString()));


        }

        private static void SetForMediumInvoice(ref Transakcje transakcje)
        {
            for (int i = 0; i < transakcje.PRODUKTY.Count; i++)
            {
                if (i < 35) printTable.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].STAN,
                        MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE.ToString()), MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_NETTO.ToString()), Settings.PROCENT,
                        MathHelp.AddZero(Math.Round((transakcje.PRODUKTY[i].SUMA_NETTO * Settings.PROCENT) / 100, 2).ToString()),
                MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));
                else
                    printTable2.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].COUNT,
                         MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE.ToString()), MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_NETTO.ToString()), Settings.PROCENT,
                         MathHelp.AddZero(Math.Round((transakcje.PRODUKTY[i].SUMA_NETTO * Settings.PROCENT) / 100, 2).ToString()),
                 MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));
          
            }

            int i2 = transakcje.PRODUKTY.Count;

            for (int i = 0; i < transakcje.USLUGI.Count; i++)
            {
                if (i2 < 35) printTable.Rows.Add(i + i2 + 1, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, transakcje.USLUGI[i].TIME_INDEX,
                      MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()), MathHelp.AddZero(transakcje.USLUGI[i].SumaNetto.ToString()), transakcje.USLUGI[i].VAT,
                      MathHelp.AddZero(Math.Round(transakcje.USLUGI[i].KWOTA_VAT ,2).ToString()),
              MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
                else
                    printTable2.Rows.Add(i + i2 + 1, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, transakcje.USLUGI[i].TIME_INDEX,
                         MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()), MathHelp.AddZero(transakcje.USLUGI[i].SumaNetto.ToString()), transakcje.USLUGI[i].VAT,
                         MathHelp.AddZero(Math.Round(transakcje.USLUGI[i].KWOTA_VAT, 2).ToString()),
                 MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
          
            }
        }

        private static void SetForLongInvoice(ref Transakcje transakcje)
        {
            int i2 = 0;

            for (int i = 0; i < transakcje.PRODUKTY.Count; i++)
            {
                i2++;

                int r = transakcje.PRODUKTY.Count - i2;

                if (i2 < 35) printTable.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].STAN,
                        MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE.ToString()), MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_NETTO.ToString()), Settings.PROCENT,
                        MathHelp.AddZero(Math.Round((transakcje.PRODUKTY[i].SUMA_NETTO * Settings.PROCENT) / 100, 2).ToString()),
                MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));
                else if (i2 < 88 || r > 30)
                    printTable2.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].COUNT,
                         MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE.ToString()), MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_NETTO.ToString()), Settings.PROCENT,
                         MathHelp.AddZero(Math.Round((transakcje.PRODUKTY[i].SUMA_NETTO * Settings.PROCENT) / 100, 2).ToString()),
                 MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));
                else
                    printTable3.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].COUNT,
                        MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE.ToString()), MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_NETTO.ToString()), Settings.PROCENT,
                        MathHelp.AddZero(Math.Round((transakcje.PRODUKTY[i].SUMA_NETTO * Settings.PROCENT) / 100, 2).ToString()),
                MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));
            }


            for (int i = 0; i < transakcje.USLUGI.Count; i++)
            {
                i2 += i + 1;

                int r = transakcje.PRODUKTY.Count + transakcje.USLUGI.Count - i2;

                if (i2 < 35) printTable.Rows.Add(i2, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, transakcje.USLUGI[i].TIME_INDEX,
                      MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()), MathHelp.AddZero(transakcje.USLUGI[i].Netto.ToString()), Settings.PROCENT,
                      MathHelp.AddZero(Math.Round(transakcje.USLUGI[i].KWOTA_VAT, 2).ToString()),
              MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
                else if (i2 < 88 || r > 30)
                    printTable2.Rows.Add(i2, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, transakcje.USLUGI[i].TIME_INDEX,
                         MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()), MathHelp.AddZero(transakcje.USLUGI[i].Netto.ToString()), Settings.PROCENT,
                         MathHelp.AddZero(Math.Round(transakcje.USLUGI[i].KWOTA_VAT, 2).ToString()),
                 MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
                else
                    printTable3.Rows.Add(i2, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, transakcje.USLUGI[i].TIME_INDEX,
                        MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()), MathHelp.AddZero(transakcje.USLUGI[i].Netto.ToString()), Settings.PROCENT,
                        MathHelp.AddZero(Math.Round(transakcje.USLUGI[i].KWOTA_VAT, 2).ToString()),
                MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
            }
        }

        #endregion

        #region RECIPT

        private static void SetForNormalRecipt(ref Transakcje transakcje)
        {
            if (transakcje.PRODUKTY == null) goto uslugi;

            for (int i = 0; i < transakcje.PRODUKTY.Count; i++)
                printTable.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].COUNT,
                        MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE.ToString()), MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));

            uslugi:

            int i2 = 0;

            if (transakcje.USLUGI == null) return;

            if (transakcje.PRODUKTY != null) i2 = transakcje.PRODUKTY.Count;
            else i2 = 0;

            for (int i = 0; i < transakcje.USLUGI.Count; i++)
                printTable.Rows.Add(i + i2 + 1, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, 1,
                      MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()), 
                      MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));


        }

        private static void SetForMediumRecipt(ref Transakcje transakcje)
        {
            for (int i = 0; i < transakcje.PRODUKTY.Count; i++)
            {
                if (i < 35) printTable.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].COUNT,
                        MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE.ToString()),
                MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));
                else
                    printTable2.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].COUNT,
                         MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE.ToString()), 
                 MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));
          
            }

            int i2 = transakcje.PRODUKTY.Count;
            
            for (int i = 0; i < transakcje.USLUGI.Count; i++)
            {
                if (i2 < 35) printTable.Rows.Add(i + i2 + 1, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, 1,
                      MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()), 
              MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
                else
                    printTable2.Rows.Add(i + i2 + 1, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, 1,
                         MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()),
                 MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
          
            }
        }

        private static void SetForLongRecipt(ref Transakcje transakcje)
        {
            int i2 = 0;

           
            for (int i = 0; i < transakcje.PRODUKTY.Count; i++)
            {
                i2++;

                int r = transakcje.PRODUKTY.Count - i2;

                if (i2 < 35) printTable.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].COUNT,
                        MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE.ToString()),
                MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));
                else if (i2 < 88 || r > 30)
                    printTable2.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].COUNT,
                         MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE.ToString()), 
                 MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));
                else
                    printTable3.Rows.Add(i + 1, transakcje.PRODUKTY[i].NUMERKAT, transakcje.PRODUKTY[i].NAME, transakcje.PRODUKTY[i].COUNT,
                        MathHelp.AddZero(transakcje.PRODUKTY[i].VATPRICE.ToString()),
                MathHelp.AddZero(transakcje.PRODUKTY[i].SUMA_BRUTTO.ToString()));
            }

            
            for (int i = 0; i < transakcje.USLUGI.Count; i++)
            {
                i2 += i + 1;

                int r = transakcje.PRODUKTY.Count + transakcje.USLUGI.Count - i2;

                if (i2 < 35) printTable.Rows.Add(i2, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, 1,
                      MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()), 
              MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
                else if (i2 < 88 || r > 30)
                    printTable2.Rows.Add(i2, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, 1,
                         MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()), 
                 MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
                else
                    printTable3.Rows.Add(i2, transakcje.USLUGI[i].NUMER, transakcje.USLUGI[i].NAZWA, 1,
                        MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()), 
                MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
            }


        }

        #endregion

        #region ORDER

        private static void SetForNormalOrder(ref Transakcje transakcje)
        {

            if (transakcje.USLUGI == null) return;

            for (int i = 0; i < transakcje.USLUGI.Count; i++)
                printTable.Rows.Add(i + 1, transakcje.USLUGI[i].USLUGA, "",
                      MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));


        }

        private static void SetForMediumOrder(ref Transakcje transakcje)
        {

            int i2 = 0;

            for (int i = 0; i < transakcje.USLUGI.Count; i++)
            {
                if (i2 < 35) printTable.Rows.Add(i + i2 + 1, transakcje.USLUGI[i].USLUGA, "",
              MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
                else
                    printTable2.Rows.Add(i + i2 + 1, transakcje.USLUGI[i].USLUGA, "",
                 MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));

            }
        }

        private static void SetForLongOrder(ref Transakcje transakcje)
        {
            int i2 = 0;

            
            for (int i = 0; i < transakcje.USLUGI.Count; i++)
            {
                i2 += i + 1;

                int r = transakcje.USLUGI.Count - i2;

                if (i2 < 35) printTable.Rows.Add(i2, transakcje.USLUGI[i].USLUGA, "",
              MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
                else if (i2 < 88 || r > 30)
                    printTable2.Rows.Add(i2, transakcje.USLUGI[i].USLUGA, "",
                 MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
                else
                    printTable3.Rows.Add(i2, transakcje.USLUGI[i].USLUGA, "",
                MathHelp.AddZero(transakcje.USLUGI[i].Brutto.ToString()));
            }


        }

        #endregion

        private static void LoadLogo()
        {
            if (String.IsNullOrEmpty(Settings.LOGO)) return;

            Image logoImage;

            try
            {
                logoImage = Image.FromFile(Settings.AppDirectory +
                    "\\Logo\\" + Settings.LOGO);
            }
            catch
            {
                Message.InfoMessage("Błąd ładowania logo firmy");
                return; 
            }

            Bitmap logo;

            int sizeX = logoImage.Size.Width;
            int sizeY = logoImage.Size.Height;

            int newY = (int)((320 * sizeY) / sizeX);

            if (newY < 120)
            {
                logo = new Bitmap(logoImage, new Size(320, newY));
                document.AddPicture("pbxLogo", logo);
            }
            else
            {
                int newX = (int)((120 * 320) / newY);

                logo = new Bitmap(logoImage, new Size(newX, 120));
                document.AddPicture("pbxLogo", logo);
            }

            
            


        }

        public static void PrintOrder(ref Transakcje transakcje)
        {
           
            printSuma.Rows.Clear();
            printTable.Rows.Clear();
            printTable2.Rows.Clear();
            printTable3.Rows.Clear();

            printSuma.Columns.Clear();
            printTable.Columns.Clear();
            printTable2.Columns.Clear();
            printTable3.Columns.Clear();

            for (int i = 0; i < 6; i++)
            { printTable.Columns.Add(i.ToString()); printTable2.Columns.Add(i.ToString()); printTable3.Columns.Add(i.ToString()); }

            for (int i = 0; i < 1; i++) printSuma.Columns.Add(i.ToString());

            List<UslugaC> Uslugi = new List<UslugaC>();

            //int minRows = 15;
            //int minRows2 = -1;


            document = new Stampa.ReportDocument();

            PrintPreviewDialog printDLG = new PrintPreviewDialog();

            List<Car> pojazdy = CustomerDatabase.GetCars(transakcje.CARID,-1,"","","","",
                "","","","","","");

            Car pojazd = new Car();

            pojazd = pojazdy[0];

            document.AddText("Tytul", "Zlecenie naprawy");
   
            document.AddText("rodzaj", "");

            document.AddText("nrfaktury", "Nr: " + transakcje.NUMER);

            document.AddText("dataw", "Data: " + transakcje.DATA);

            document.AddText("numrej", "Nr. rej.: " + pojazd.REJESTRACJA);

            document.AddText("koniec", "Termin wykonania.: " + transakcje.TERMIN_UKONCZENIA);

            DataTable tblFirma = new DataTable("tblFirma");

            tblFirma.Columns.Add("0");

            tblFirma.Rows.Add(Settings.FRIMA);

            tblFirma.Rows.Add(Settings.ADRES);

            if(!String.IsNullOrEmpty(Settings.TELEFON)) tblFirma.Rows.Add("Telefon: " + Settings.TELEFON);

            if (!String.IsNullOrEmpty(Settings.EMAIL)) tblFirma.Rows.Add("Email: " + Settings.EMAIL);

            if (!String.IsNullOrEmpty(Settings.WWW)) tblFirma.Rows.Add(Settings.WWW);

            DataTable tblInfo = new DataTable("tblInfo");

            for (int i = 0; i < 4; i++) tblInfo.Columns.Add(i.ToString());

            List<Klient> klienci = CustomerDatabase.GetCustomers(pojazd.CID, "", "", "", "", "", "");

            Klient klient = new Klient();

            klient = klienci[0];

            tblInfo.Rows.Add("Marka i model", pojazd.MARKA + " " + pojazd.MODEL, "Imię i Nazwisko", klient.IMIE + " " + klient.NAZWISKO);

            tblInfo.Rows.Add("Rok produkcji", pojazd.ROK, "Adres", klient.ADRES);

            tblInfo.Rows.Add("Pojemność silnika", pojazd.POJEMNOSC, "Telefon", klient.TELEFON);

            string yes = "TAK";

            if (transakcje.DOWOD == 1) yes = "NIE";

            tblInfo.Rows.Add("Numer VIN", pojazd.VIN, "Dowód rejestracyjny", yes);

            if(transakcje.LICZNIK>0) tblInfo.Rows.Add("Stan licznika", transakcje.LICZNIK, "", "");

            string paliwo = "";

            switch (transakcje.PALIWO)
            {
                case 0:
                    paliwo = "0%";
                    break;

                case 1:
                    paliwo = "25%";
                    break;

                case 2:
                    paliwo = "50%";
                    break;

                case 3:
                    paliwo = "75%";
                    break;

                case 4:
                    paliwo = "100%";
                    break;

                default:
                    paliwo = "";
                    break;
            }

            tblInfo.Rows.Add("Stan paliwa", paliwo, "", "");

            //tblInfo.Rows.Add("Data przyjęcia", pojazd.DATA_PRZYJECIA, "Data Wydania", "");

           
            
            //document.AddText("dozaplaty", "Suma do zapłaty: " + MathHelp.AddZero(transakcje.SUMA_BRUTTO.ToString()) + " zł");

           
            document.AddText("sposob", "Sposób zapłaty: " + transakcje.PLATNOSC_OPIS);

            int maxRows = 0;

            //if (transakcje.PRODUKTY != null) maxRows += transakcje.PRODUKTY.Count;
            if (transakcje.USLUGI != null) maxRows += transakcje.USLUGI.Count;

            if (maxRows <= 15) SetForNormalOrder(ref transakcje);
            else if (maxRows > 15 && maxRows <= 55) SetForMediumOrder(ref transakcje);
            else SetForLongOrder(ref transakcje);

           
            if (transakcje.USLUGI != null) Uslugi.AddRange(transakcje.USLUGI);

           

            while (Uslugi.Count > 0)
            {
                UslugaC usl = new UslugaC();

                usl.VAT = Uslugi[0].VAT;
                usl.Netto = Uslugi[0].Netto;
                usl.Brutto = Uslugi[0].Brutto;
                usl.KWOTA_VAT = Uslugi[0].KWOTA_VAT;

                Uslugi.RemoveAt(0);

                for (int i = 0; i < Uslugi.Count; i++)
                {
                    if (usl.VAT == Uslugi[i].VAT)
                    {
                        usl.Netto += Uslugi[i].Netto;
                        usl.Brutto += Uslugi[i].Brutto;
                        usl.KWOTA_VAT += Uslugi[i].KWOTA_VAT;

                        Uslugi.RemoveAt(i);
                    }
                }

                printSuma.Rows.Add(MathHelp.AddZero(usl.Brutto.ToString()));


            }


            if (maxRows <= 15)
                document.setXML(Settings.AppDirectory +
                "\\XML\\Orders\\order.xml");
            else if (maxRows > 15 && maxRows <= 55) document.setXML(Settings.AppDirectory +
                "\\XML\\Orders\\lorder.xml");
            else document.setXML(Settings.AppDirectory +
                "\\XML\\Orders\\l2order.xml");

            document.AddData(printTable);
            if (printTable2.Rows.Count > 0) document.AddData(printTable2);
            if (printTable3.Rows.Count > 0) document.AddData(printTable3);



            DataTable tblRazem = new DataTable("tblRazem");

            tblRazem.Columns.Add("0");
            tblRazem.Columns.Add("1");

            tblRazem.Rows.Add("DO ZAPŁATY ŁĄCZNA KWOTA BRUTTO:", "");

            document.AddData(tblRazem);
            document.AddData(tblFirma);
            document.AddData(tblInfo);


            LoadLogo();

            printDLG.Document = document;

            printDLG.Width = Screen.PrimaryScreen.Bounds.Width;
            printDLG.Height = Screen.PrimaryScreen.Bounds.Height;

            printDLG.Document.PrinterSettings.Copies = (short)Settings.KOPIA;

            printDLG.ShowDialog();
        }

        public static void PrintProtokol(ref Transakcje transakcje)
        {

            printSuma.Rows.Clear();
            printTable.Rows.Clear();
            printTable2.Rows.Clear();
            printTable3.Rows.Clear();

            printSuma.Columns.Clear();
            printTable.Columns.Clear();
            printTable2.Columns.Clear();
            printTable3.Columns.Clear();

            for (int i = 0; i < 6; i++)
            { printTable.Columns.Add(i.ToString()); printTable2.Columns.Add(i.ToString()); printTable3.Columns.Add(i.ToString()); }

            for (int i = 0; i < 1; i++) printSuma.Columns.Add(i.ToString());

            List<UslugaC> Uslugi = new List<UslugaC>();

            //int minRows = 15;
            //int minRows2 = -1;


            document = new Stampa.ReportDocument();

            PrintPreviewDialog printDLG = new PrintPreviewDialog();

            List<Car> pojazdy = CustomerDatabase.GetCars(transakcje.CARID, -1, "", "", "", "",
                "", "", "", "", "", "");

            Car pojazd = new Car();

            pojazd = pojazdy[0];

            document.AddText("Tytul", "Protokół przyjęcia pojazdu");

            document.AddText("rodzaj", "");

            document.AddText("nrfaktury", "Nr: " + transakcje.NUMER);

            document.AddText("dataw", "Data: " + transakcje.DATA);

            document.AddText("numrej", "Nr. rej.: " + pojazd.REJESTRACJA);

            document.AddText("koniec", "Termin wykonania.: " + transakcje.TERMIN_UKONCZENIA);

            DataTable tblFirma = new DataTable("tblFirma");

            tblFirma.Columns.Add("0");

            tblFirma.Rows.Add(Settings.FRIMA);

            tblFirma.Rows.Add(Settings.ADRES);

            if (!String.IsNullOrEmpty(Settings.TELEFON)) tblFirma.Rows.Add("Telefon: " + Settings.TELEFON);

            if (!String.IsNullOrEmpty(Settings.EMAIL)) tblFirma.Rows.Add("Email: " + Settings.EMAIL);

            if (!String.IsNullOrEmpty(Settings.WWW)) tblFirma.Rows.Add(Settings.WWW);

            DataTable tblInfo = new DataTable("tblInfo");

            for (int i = 0; i < 4; i++) tblInfo.Columns.Add(i.ToString());

            List<Klient> klienci = CustomerDatabase.GetCustomers(pojazd.CID, "", "", "", "", "", "");

            Klient klient = new Klient();

            klient = klienci[0];

            tblInfo.Rows.Add("Marka i model", pojazd.MARKA + " " + pojazd.MODEL, "Imię i Nazwisko", klient.IMIE + " " + klient.NAZWISKO);

            tblInfo.Rows.Add("Rok produkcji", pojazd.ROK, "Adres", klient.ADRES);

            tblInfo.Rows.Add("Pojemność silnika", pojazd.POJEMNOSC, "Telefon", klient.TELEFON);

            string yes = "TAK";

            if (transakcje.DOWOD == 1) yes = "NIE";

            tblInfo.Rows.Add("Numer VIN", pojazd.VIN, "Dowód rejestracyjny", yes);

            if (transakcje.LICZNIK > 0) tblInfo.Rows.Add("Stan licznika", transakcje.LICZNIK, "", "");

            string paliwo = "";

            switch (transakcje.PALIWO)
            {
                case 0:
                    paliwo = "0%";
                    break;

                case 1:
                    paliwo = "25%";
                    break;

                case 2:
                    paliwo = "50%";
                    break;

                case 3:
                    paliwo = "75%";
                    break;

                case 4:
                    paliwo = "100%";
                    break;

                default:
                    paliwo = "";
                    break;
            }

            tblInfo.Rows.Add("Stan paliwa", paliwo, "", "");

            //tblInfo.Rows.Add("Data przyjęcia", pojazd.DATA_PRZYJECIA, "Data Wydania", "");



            //document.AddText("dozaplaty", "Suma do zapłaty: " + MathHelp.AddZero(transakcje.SUMA_BRUTTO.ToString()) + " zł");


            document.AddText("sposob", "Sposób zapłaty: " + transakcje.PLATNOSC_OPIS);

            int maxRows = 0;

            //if (transakcje.PRODUKTY != null) maxRows += transakcje.PRODUKTY.Count;
            if (transakcje.USLUGI != null) maxRows += transakcje.USLUGI.Count;

            //if (maxRows <= 15) 

            



            //SetForNormalOrder(ref transakcje);
            //else if (maxRows > 15 && maxRows <= 55) SetForMediumOrder(ref transakcje);
            //else SetForLongOrder(ref transakcje);


            List<UsterkaCls> usterki = CustomerDatabase.GetUsterki(transakcje.CARID);


            if (usterki != null)
                for (int i = 0; i < usterki.Count; i++)
                    printTable.Rows.Add(i + 1, usterki[i].USTERKA);


            //while (Uslugi.Count > 0)
            //{
            //    UslugaC usl = new UslugaC();

            //    usl.VAT = Uslugi[0].VAT;
            //    usl.Netto = Uslugi[0].Netto;
            //    usl.Brutto = Uslugi[0].Brutto;
            //    usl.KWOTA_VAT = Uslugi[0].KWOTA_VAT;

            //    Uslugi.RemoveAt(0);

            //    for (int i = 0; i < Uslugi.Count; i++)
            //    {
            //        if (usl.VAT == Uslugi[i].VAT)
            //        {
            //            usl.Netto += Uslugi[i].Netto;
            //            usl.Brutto += Uslugi[i].Brutto;
            //            usl.KWOTA_VAT += Uslugi[i].KWOTA_VAT;

            //            Uslugi.RemoveAt(i);
            //        }
            //    }

            //    printSuma.Rows.Add(MathHelp.AddZero(usl.Brutto.ToString()));


            //}


            //if (maxRows <= 15)
                document.setXML(Settings.AppDirectory +
                "\\XML\\Shym\\shym.xml");
            //else if (maxRows > 15 && maxRows <= 55) document.setXML(Settings.AppDirectory +
            //    "\\XML\\Orders\\lorder.xml");
            //else document.setXML(Settings.AppDirectory +
            //    "\\XML\\Orders\\l2order.xml");

            document.AddData(printTable);
            //if (printTable2.Rows.Count > 0) document.AddData(printTable2);
            //if (printTable3.Rows.Count > 0) document.AddData(printTable3);



            //DataTable tblRazem = new DataTable("tblRazem");

            //tblRazem.Columns.Add("0");
            //tblRazem.Columns.Add("1");

            //tblRazem.Rows.Add("DO ZAPŁATY ŁĄCZNA KWOTA BRUTTO:", "");

            //document.AddData(tblRazem);
            document.AddData(tblFirma);
            document.AddData(tblInfo);


            LoadLogo();

            printDLG.Document = document;

            printDLG.Width = Screen.PrimaryScreen.Bounds.Width;
            printDLG.Height = Screen.PrimaryScreen.Bounds.Height;

            printDLG.Document.PrinterSettings.Copies = (short)Settings.KOPIA;

            printDLG.ShowDialog();
        }

        public static void PrintRecipt(ref Transakcje transakcje)
        {
            printSuma.Rows.Clear();
            printTable.Rows.Clear();
            printTable2.Rows.Clear();
            printTable3.Rows.Clear();

            printSuma.Columns.Clear();
            printTable.Columns.Clear();
            printTable2.Columns.Clear();
            printTable3.Columns.Clear();

            for (int i = 0; i < 6; i++)
            { printTable.Columns.Add(i.ToString()); printTable2.Columns.Add(i.ToString()); printTable3.Columns.Add(i.ToString()); }

            for (int i = 0; i < 1; i++) printSuma.Columns.Add(i.ToString());

            List<UslugaC> Uslugi = new List<UslugaC>();

            //int minRows = 15;
            //int minRows2 = -1;


            document = new Stampa.ReportDocument();

            PrintPreviewDialog printDLG = new PrintPreviewDialog();

            document.AddText("Tytul", "RACHUNEK");
   
            document.AddText("rodzaj", "ORYGINAŁ / KOPIA");

            document.AddText("nrfaktury", "Nr: " + transakcje.NUMER);

            document.AddText("dataw", "Data wystawienia: " + transakcje.DATA);

            document.AddText("datas", "Miejsce wystawienia: " + Settings.MIASTO);

            document.AddText("miasto", "");

            document.AddText("firma", Settings.FRIMA);

            document.AddText("klientfirma", transakcje.FIRMA);

            document.AddText("adres", Settings.ADRES);

            document.AddText("klientadres", transakcje.ADRES);

            document.AddText("nip", Settings.NIP);

            document.AddText("klientnip", transakcje.NIP);

            document.AddText("telefon", "Nr. telefonu: " + Settings.TELEFON);

            document.AddText("email", "Email: " + Settings.EMAIL);

            
            document.AddText("dozaplaty", "Suma do zapłaty: " + MathHelp.AddZero(transakcje.SUMA_BRUTTO.ToString()) + " zł");

           
            document.AddText("sposob", "Sposób zapłaty: " + transakcje.PLATNOSC_OPIS);

            if (transakcje.PLATNOSC == 1) document.AddText("bank", "Na konto: " + Settings.BANK);
            else document.AddText("bank", "");

            document.AddText("termin", "Termin zapłaty: " + transakcje.TERMIN_ZAPLATY);

           
            //for (int i = 0; i < 52; i++) transakcje.PRODUKTY.Add(transakcje.PRODUKTY[0]);

            int maxRows = 0;

            if (transakcje.PRODUKTY != null) maxRows += transakcje.PRODUKTY.Count;
            if (transakcje.USLUGI != null) maxRows += transakcje.USLUGI.Count;

            if (maxRows <= 15) SetForNormalRecipt(ref transakcje);
            else if (maxRows > 15 && maxRows <= 55) SetForMediumRecipt(ref transakcje);
            else SetForLongRecipt(ref transakcje);

           
            float produktySumaBrutto = 0;
           

            for (int i = 0; i < transakcje.PRODUKTY.Count; i++)
                produktySumaBrutto += transakcje.PRODUKTY[i].SUMA_BRUTTO;
                

           
            produktySumaBrutto = (float)Math.Round(produktySumaBrutto, 2);
         

            if (produktySumaBrutto > 0)
            {
                Uslugi.Insert(0, new UslugaC
                {
                    Netto = 0,
                    VAT = Settings.PROCENT,
                    Brutto = produktySumaBrutto,
                    KWOTA_VAT = 0
                });
            }

            if (transakcje.USLUGI != null) Uslugi.AddRange(transakcje.USLUGI);

            while (Uslugi.Count > 0)
            {
                UslugaC usl = new UslugaC();

                usl.VAT = Uslugi[0].VAT;
                usl.Netto = Uslugi[0].Netto;
                usl.Brutto = Uslugi[0].Brutto;
                usl.KWOTA_VAT = Uslugi[0].KWOTA_VAT;

                Uslugi.RemoveAt(0);

                for (int i = 0; i < Uslugi.Count; i++)
                {
                    if (usl.VAT == Uslugi[i].VAT)
                    {
                        usl.Netto += Uslugi[i].Netto;
                        usl.Brutto += Uslugi[i].Brutto;
                        usl.KWOTA_VAT += Uslugi[i].KWOTA_VAT;

                        Uslugi.RemoveAt(i);
                    }
                }

                printSuma.Rows.Add(MathHelp.AddZero(usl.Brutto.ToString()));


            }


            if (maxRows <= 15) document.setXML(Settings.AppDirectory +
                "\\XML\\PrintRecipt\\recipt.xml");
            else if (maxRows > 15 && maxRows <= 55) document.setXML(Settings.AppDirectory +
                "\\XML\\PrintRecipt\\lrecipt.xml");
            else document.setXML(Settings.AppDirectory +
                "\\XML\\PrintRecipt\\l2recipt.xml");

            document.AddData(printTable);
            if (printTable2.Rows.Count > 0) document.AddData(printTable2);
            if (printTable3.Rows.Count > 0) document.AddData(printTable3);

            document.AddData(printSuma);

            LoadLogo();

            printDLG.Document = document;

            printDLG.Width = Screen.PrimaryScreen.Bounds.Width;
            printDLG.Height = Screen.PrimaryScreen.Bounds.Height;

            printDLG.Document.PrinterSettings.Copies = (short)Settings.KOPIA;

            printDLG.ShowDialog();
        }

        public static void PrintInfo(ref Transakcje transakcje)
        {
            printSuma.Rows.Clear();
            printTable.Rows.Clear();
            printTable2.Rows.Clear();
            printTable3.Rows.Clear();

            printSuma.Columns.Clear();
            printTable.Columns.Clear();
            printTable2.Columns.Clear();
            printTable3.Columns.Clear();

            for (int i = 0; i < 9; i++)
            { printTable.Columns.Add(i.ToString()); printTable2.Columns.Add(i.ToString()); printTable3.Columns.Add(i.ToString()); }

            for (int i = 0; i < 4; i++) printSuma.Columns.Add(i.ToString());


            if (transakcje.TYP == FakturaTyp.TYPE.Rachunek_uproszczony)
            {
                PrintRecipt(ref transakcje);
                return;
            }

            List<UslugaC> Uslugi = new List<UslugaC>();



            //int minRows = 15;
            //int minRows2 = -1;


            document = new Stampa.ReportDocument();

            PrintPreviewDialog printDLG = new PrintPreviewDialog();

            document.AddText("Tytul", "Kosztorys naprawy");
            

            document.AddText("rodzaj", "");

            document.AddText("nrfaktury", "Nr zlecenia: " + transakcje.NUMER);

            document.AddText("dataw", "Data: " + transakcje.DATA);

            document.AddText("datas", "Miejsce: " + Settings.MIASTO);

            document.AddText("miasto", "");

            document.AddText("firma", Settings.FRIMA);

            document.AddText("klientfirma", transakcje.FIRMA);

            document.AddText("adres", Settings.ADRES);

            document.AddText("klientadres", transakcje.ADRES);

            document.AddText("nip", Settings.NIP);

            document.AddText("klientnip", transakcje.NIP);

            document.AddText("telefon", "Nr. telefonu: " + Settings.TELEFON);

            document.AddText("ktelefon", "Nr. telefonu: " + transakcje.TELEFON);

            document.AddText("email", "Email: " + Settings.EMAIL);

            document.AddText("dozaplaty", "Koszt całkowity: " + MathHelp.AddZero(transakcje.SUMA_BRUTTO.ToString()) + " zł");


            int maxRows = 0;

            if (transakcje.PRODUKTY != null) maxRows += transakcje.PRODUKTY.Count;
            if (transakcje.USLUGI != null) maxRows += transakcje.USLUGI.Count;

            if (maxRows <= 15) SetForNormalInvoice(ref transakcje);
            else if (maxRows > 15 && maxRows <= 55) SetForMediumInvoice(ref transakcje);
            else SetForLongInvoice(ref transakcje);



            float produktySumaNetto = 0;
            float produktySumaBrutto = 0;


            for (int i = 0; i < transakcje.PRODUKTY.Count; i++)
            {
                produktySumaNetto += transakcje.PRODUKTY[i].SUMA_NETTO;
                produktySumaBrutto += transakcje.PRODUKTY[i].SUMA_BRUTTO;
            }


            produktySumaBrutto = (float)Math.Round(produktySumaBrutto, 2);

            if (produktySumaBrutto > 0)
            {
                Uslugi.Insert(0, new UslugaC
                {
                    Netto = produktySumaNetto,
                    VAT = Settings.PROCENT,
                    Brutto = produktySumaBrutto,
                    KWOTA_VAT = (float)Math.Round((float)(produktySumaBrutto - produktySumaNetto), 2)
                });
            }

            if (transakcje.USLUGI != null) Uslugi.AddRange(transakcje.USLUGI);

            while (Uslugi.Count > 0)
            {
                UslugaC usl = new UslugaC();

                usl.VAT = Uslugi[0].VAT;
                usl.Netto = Uslugi[0].Netto;
                usl.Brutto = Uslugi[0].Brutto;
                usl.KWOTA_VAT = Uslugi[0].KWOTA_VAT;

                Uslugi.RemoveAt(0);

                for (int i = 0; i < Uslugi.Count; i++)
                {
                    if (usl.VAT == Uslugi[i].VAT)
                    {
                        usl.Netto += Uslugi[i].Netto;
                        usl.Brutto += Uslugi[i].Brutto;
                        usl.KWOTA_VAT += Uslugi[i].KWOTA_VAT;

                        Uslugi.RemoveAt(i);
                    }
                }

                printSuma.Rows.Add(MathHelp.AddZero(usl.Netto.ToString()), usl.VAT,
                    MathHelp.AddZero(usl.KWOTA_VAT.ToString()),
                    MathHelp.AddZero(usl.Brutto.ToString()));


            }

            document.AddText("sposob", "");

            document.AddText("bank", "");

            document.AddText("termin", "");

            if (maxRows <= 15) document.setXML(Settings.AppDirectory + "\\invoice.xml");
            else if (maxRows > 15 && maxRows <= 55) document.setXML(Settings.AppDirectory + "\\linvoice.xml");
            else document.setXML(Settings.AppDirectory + "\\l2invoice.xml");

            document.AddData(printTable);
            if (printTable2.Rows.Count > 0) document.AddData(printTable2);
            if (printTable3.Rows.Count > 0) document.AddData(printTable3);

            document.AddData(printSuma);

            LoadLogo();

            printDLG.Document = document;

            printDLG.Width = Screen.PrimaryScreen.Bounds.Width;
            printDLG.Height = Screen.PrimaryScreen.Bounds.Height;

            printDLG.Document.PrinterSettings.Copies = (short)Settings.KOPIA;

            printDLG.ShowDialog();
        }

        public static void PrintInvoice(ref Transakcje transakcje)
        {
            printSuma.Rows.Clear();
            printTable.Rows.Clear();
            printTable2.Rows.Clear();
            printTable3.Rows.Clear();

            printSuma.Columns.Clear();
            printTable.Columns.Clear();
            printTable2.Columns.Clear();
            printTable3.Columns.Clear();

            for (int i = 0; i < 9; i++)
            { printTable.Columns.Add(i.ToString()); printTable2.Columns.Add(i.ToString()); printTable3.Columns.Add(i.ToString()); }

            for (int i = 0; i < 4; i++) printSuma.Columns.Add(i.ToString());


            if (transakcje.TYP == FakturaTyp.TYPE.Rachunek_uproszczony)
            {
                PrintRecipt(ref transakcje);
                return;
            }

            List<UslugaC> Uslugi = new List<UslugaC>();

           

            //int minRows = 15;
            //int minRows2 = -1;


            document = new Stampa.ReportDocument();

            PrintPreviewDialog printDLG = new PrintPreviewDialog();

            if (transakcje.TYP == 0) document.AddText("Tytul", "Faktura VAT");
            else document.AddText("Tytul", "Faktura VAT - korygująca");

            document.AddText("rodzaj", "ORYGINAŁ / KOPIA");

            document.AddText("nrfaktury", "Nr Faktury: " + transakcje.NUMER);

            document.AddText("dataw", "Data wystawienia: " + transakcje.DATA);

            document.AddText("datas", "Miejsce wystawienia: " + Settings.MIASTO);

            List<Car> pojazdy = CustomerDatabase.GetCars(transakcje.CARID,-1,"","","","",
                "","","","","","");

            Car pojazd = new Car();

            document.AddText("miasto", "Nr. rej.: " + pojazdy[0].REJESTRACJA);

            //document.AddText("miasto", "");

            document.AddText("firma", Settings.FRIMA);

            document.AddText("klientfirma", transakcje.FIRMA);

            document.AddText("adres", Settings.ADRES);

            document.AddText("klientadres", transakcje.ADRES);

            document.AddText("nip", Settings.NIP + "   Nr. telefonu: " + Settings.TELEFON +
                "   Email: " + Settings.EMAIL);

            string telefon = transakcje.NIP;

            if(!String.IsNullOrEmpty(transakcje.TELEFON)) telefon += "   Nr. telefonu: " + transakcje.TELEFON;


            document.AddText("klientnip", telefon);

            //document.AddText("telefon", "Nr. telefonu: " + Settings.TELEFON);

            //document.AddText("ktelefon", "Nr. telefonu: " + transakcje.TELEFON);

            //document.AddText("email", "Email: " + Settings.EMAIL);

            if (transakcje.TYP == FakturaTyp.TYPE.Korygująca_anulowana) document.AddText("dozaplaty", "Suma do zapłaty: 0 zł");
            else document.AddText("dozaplaty", "Suma do zapłaty: " + MathHelp.AddZero(transakcje.SUMA_BRUTTO.ToString()) + " zł");



            if (transakcje.TYP != FakturaTyp.TYPE.Korygująca_anulowana)
            {
                document.AddText("sposob", "Sposób zapłaty: " + transakcje.PLATNOSC_OPIS);

                if (transakcje.PLATNOSC == 1) document.AddText("bank", "Na konto: " + Settings.BANK);
                else document.AddText("bank", "");

                document.AddText("termin", "Termin zapłaty: " + transakcje.TERMIN_ZAPLATY);

            }
            else
            {
                document.AddText("sposob", "");

                document.AddText("bank", "");

                document.AddText("termin", "");
            }

            //for (int i = 0; i < 52; i++) transakcje.PRODUKTY.Add(transakcje.PRODUKTY[0]);

            int maxRows = 0;

            if (transakcje.PRODUKTY != null) maxRows += transakcje.PRODUKTY.Count;
            if (transakcje.USLUGI != null) maxRows += transakcje.USLUGI.Count;

            SetForNormalInvoice(ref transakcje);
            //else if (maxRows > 15 && maxRows <= 55) SetForMediumInvoice(ref transakcje);
            //else SetForLongInvoice(ref transakcje);

            printTable.Rows.Add(null, null, null, null,
                       null, null, null,
                       null, null);

            printTable.Rows.Add(null, null, null, null,
                      null, null, null,
                      null, null);

            printTable.Rows.Add(null, null, null, null,
                      "RAZEM:", null, null,
                      null, null);



            float produktySumaNetto = 0;
            float produktySumaBrutto = 0;




            for (int i = 0; i < transakcje.PRODUKTY.Count; i++)
            {
                produktySumaNetto += transakcje.PRODUKTY[i].SUMA_NETTO;
                produktySumaBrutto += transakcje.PRODUKTY[i].SUMA_BRUTTO;
            }
              
           
            produktySumaBrutto = (float)Math.Round(produktySumaBrutto,2);

            if (produktySumaBrutto > 0)
            {
                Uslugi.Insert(0, new UslugaC
                {
                    Netto = produktySumaNetto,
                    VAT = Settings.PROCENT,
                    Brutto = produktySumaBrutto,
                    KWOTA_VAT = (float)Math.Round((float)(produktySumaBrutto - produktySumaNetto),2)
                });
            }

            if (transakcje.USLUGI != null) Uslugi.AddRange(transakcje.USLUGI);

                while (Uslugi.Count > 0)
                {
                    UslugaC usl = new UslugaC();

                    usl.VAT = Uslugi[0].VAT;
                    usl.Netto = Uslugi[0].Netto;
                    usl.Brutto = Uslugi[0].Brutto;
                    usl.KWOTA_VAT = Uslugi[0].KWOTA_VAT;

                    Uslugi.RemoveAt(0);

                    for (int i = 0; i < Uslugi.Count; i++)
                    {
                        if (usl.VAT == Uslugi[i].VAT)
                        {
                            usl.Netto += Uslugi[i].Netto;
                            usl.Brutto += Uslugi[i].Brutto;
                            usl.KWOTA_VAT += Uslugi[i].KWOTA_VAT;

                            Uslugi.RemoveAt(i);
                        }
                    }

                    //printSuma.Rows.Add(MathHelp.AddZero(usl.Netto.ToString()), usl.VAT,
                    //    MathHelp.AddZero(usl.KWOTA_VAT.ToString()), 
                    //    MathHelp.AddZero(usl.Brutto.ToString()));

                    printTable.Rows.Add(null, null, null, null,
                        null, MathHelp.AddZero(usl.Netto.ToString()), usl.VAT + "%",
                        MathHelp.AddZero(usl.KWOTA_VAT.ToString()), MathHelp.AddZero(usl.Brutto.ToString()));



                }
            

            document.setXML(Settings.AppDirectory + "\\invoice.xml");
            //else if (maxRows > 15 && maxRows <= 55) document.setXML(Settings.AppDirectory + "\\linvoice.xml");
            //else document.setXML(Settings.AppDirectory + "\\l2invoice.xml");

            document.AddData(printTable);
            if (printTable2.Rows.Count > 0) document.AddData(printTable2);
            if (printTable3.Rows.Count > 0) document.AddData(printTable3);

            document.AddData(printSuma);

            LoadLogo();

            printDLG.Document = document;

            printDLG.Width = Screen.PrimaryScreen.Bounds.Width;
            printDLG.Height = Screen.PrimaryScreen.Bounds.Height;

            printDLG.Document.PrinterSettings.Copies = (short)Settings.KOPIA;

            printDLG.ShowDialog();
        }

        public static void PrintCar(Car car)
        {
            document.Dispose();

            document = new ReportDocument();

            DataTable printTbl = new DataTable("tabela");

            printTbl.Columns.Add("0");
            printTbl.Columns.Add("1");

            string kontrahent = CustomerDatabase.GetCustomers(car.CID, "", "", "", "", "", "")[0].LISTA;

            printTbl.Rows.Add("Dane właściciela", kontrahent);
            printTbl.Rows.Add("Numer rejestracyjny", car.REJESTRACJA);
            printTbl.Rows.Add("MARKA", car.MARKA);
            printTbl.Rows.Add("MODEL", car.MODEL);
            printTbl.Rows.Add("Pojemność silnika", car.POJEMNOSC);
            printTbl.Rows.Add("Rok produkcji", car.ROK);

            if (!String.IsNullOrEmpty(car.TYP)) printTbl.Rows.Add("Typ", car.TYP);
            if (!String.IsNullOrEmpty(car.SILNIK)) printTbl.Rows.Add("Kod silnika", car.SILNIK);
            if (!String.IsNullOrEmpty(car.VIN)) printTbl.Rows.Add("Numer nadwozia", car.VIN);
            if (!String.IsNullOrEmpty(car.OPIS)) printTbl.Rows.Add("Opis", car.OPIS);


            document.AddText("Tytul", "Baza pojazdów - wydruk pozycji");

            document.AddText("rodzaj", "");

            document.AddData(printTbl);


            PrintPreviewDialog printDLG = new PrintPreviewDialog();

            document.setXML(Settings.AppDirectory + "\\Um.xml");

            printDLG.Document = document;

            printDLG.Width = Screen.PrimaryScreen.Bounds.Width;
            printDLG.Height = Screen.PrimaryScreen.Bounds.Height;


            printDLG.ShowDialog();
        }

        public static void PrintKsiazkaSerwisowa(Car car)
        {
            document.Dispose();

            document = new ReportDocument();

            DataTable printTbl = new DataTable("tabela");
            DataTable printZlecenia = new DataTable("tblZlecenia");
            DataTable printZlecenia2 = new DataTable("tblZlecenia2");

            printTbl.Columns.Add("0");
            printTbl.Columns.Add("1");

            for (int i = 0; i < 6; i++)
            {
                printZlecenia.Columns.Add(i.ToString());
                printZlecenia2.Columns.Add(i.ToString());
            }

            

            printTbl.Rows.Add("Dane właściciela", car.KONTRAHENT);
            printTbl.Rows.Add("Numer rejestracyjny", car.REJESTRACJA);
            printTbl.Rows.Add("MARKA", car.MARKA);
            printTbl.Rows.Add("MODEL", car.MODEL);
            printTbl.Rows.Add("Pojemność silnika", car.POJEMNOSC);
            printTbl.Rows.Add("Rok produkcji", car.ROK);

            //if (!String.IsNullOrEmpty(car.TYP)) printTbl.Rows.Add("Typ", car.TYP);
            //if (!String.IsNullOrEmpty(car.SILNIK)) printTbl.Rows.Add("Kod silnika", car.SILNIK);
            //if (!String.IsNullOrEmpty(car.VIN)) printTbl.Rows.Add("Numer nadwozia", car.VIN);
            //if (!String.IsNullOrEmpty(car.OPIS)) printTbl.Rows.Add("Opis", car.OPIS);

            printTbl.Rows.Add("Typ", car.TYP);
            printTbl.Rows.Add("Kod silnika", car.SILNIK);
            printTbl.Rows.Add("Numer nadwozia", car.VIN);
            printTbl.Rows.Add("Opis", car.OPIS);


            List<Invoice> invoices =
                CustomerDatabase.GetTransakcje(-1, "", car.CID, -1, "", "", "",
                "", -1, car.ID);

            int numOdRows = 0;

            
                for (int i = 0; i < invoices.Count; i++)
                {
                    if (numOdRows < 35) printZlecenia.Rows.Add((i + 1), invoices[i].NUMER, invoices[i].DATA,
                           "", "", "");
                    else printZlecenia2.Rows.Add((i + 1), invoices[i].NUMER, invoices[i].DATA,
                           "", "", "");

                    numOdRows++;

                    List<UslugaC> uslugi = CustomerDatabase.GetUslugiItems(invoices[i].ID);

                    for (int j = 0; j < uslugi.Count; j++)
                    {
                        if (numOdRows < 35) printZlecenia.Rows.Add("", "", "", uslugi[j].NUMER, uslugi[j].NAZWA,
                            uslugi[j].W_NAME);
                        else printZlecenia2.Rows.Add("", "", "", uslugi[j].NUMER, uslugi[j].NAZWA,
                            uslugi[j].W_NAME);

                        numOdRows++;
                    }

                    
                }
                
            


            document.AddText("Tytul", "Ksiązka serwisowa");

            document.AddText("rodzaj", "");

            document.AddData(printTbl);

            document.AddData(printZlecenia);

            if (printZlecenia2.Rows.Count > 0) document.AddData(printZlecenia2);

            PrintPreviewDialog printDLG = new PrintPreviewDialog();

            document.setXML(Settings.AppDirectory + "\\Ksiazka.xml");

            printDLG.Document = document;

            printDLG.Width = Screen.PrimaryScreen.Bounds.Width;
            printDLG.Height = Screen.PrimaryScreen.Bounds.Height;


            printDLG.ShowDialog();
        }

        public static void PrintKsiazkaSerwisowaItem(Car car, List<UslugaC> uslugi)
        {
            document.Dispose();

            document = new ReportDocument();

            DataTable printTbl = new DataTable("tabela");
            DataTable printZlecenia = new DataTable("tblZlecenia");
            DataTable printZlecenia2 = new DataTable("tblZlecenia2");

            printTbl.Columns.Add("0");
            printTbl.Columns.Add("1");

            for (int i = 0; i < 6; i++)
            {
                printZlecenia.Columns.Add(i.ToString());
                printZlecenia2.Columns.Add(i.ToString());
            }

            

            printTbl.Rows.Add("Dane właściciela", car.KONTRAHENT);
            printTbl.Rows.Add("Numer rejestracyjny", car.REJESTRACJA);
            printTbl.Rows.Add("MARKA", car.MARKA);
            printTbl.Rows.Add("MODEL", car.MODEL);
            printTbl.Rows.Add("Pojemność silnika", car.POJEMNOSC);
            printTbl.Rows.Add("Rok produkcji", car.ROK);

            //if (!String.IsNullOrEmpty(car.TYP)) printTbl.Rows.Add("Typ", car.TYP);
            //if (!String.IsNullOrEmpty(car.SILNIK)) printTbl.Rows.Add("Kod silnika", car.SILNIK);
            //if (!String.IsNullOrEmpty(car.VIN)) printTbl.Rows.Add("Numer nadwozia", car.VIN);
            //if (!String.IsNullOrEmpty(car.OPIS)) printTbl.Rows.Add("Opis", car.OPIS);

            printTbl.Rows.Add("Typ", car.TYP);
            printTbl.Rows.Add("Kod silnika", car.SILNIK);
            printTbl.Rows.Add("Numer nadwozia", car.VIN);
            printTbl.Rows.Add("Opis", car.OPIS);


            List<Invoice> invoices =
                CustomerDatabase.GetTransakcje(-1, "", car.CID, -1, "", "", "",
                "", -1, car.ID);


            printZlecenia.Rows.Add("", invoices[0].NUMER, invoices[0].DATA,
                    "", "", "");

            int numOfRows = 0;


            for (int j = 0; j < uslugi.Count; j++)
            {
                if (numOfRows < 35) printZlecenia.Rows.Add("", "", "", uslugi[j].NUMER,
                     uslugi[j].NAZWA, uslugi[j].W_NAME);

                else printZlecenia2.Rows.Add("", "", "", uslugi[j].NUMER,
                    uslugi[j].NAZWA, uslugi[j].W_NAME);

                numOfRows++;
            }
            


            document.AddText("Tytul", "Ksiązka serwisowa - wydruk zlecenia");

            document.AddText("rodzaj", "");

            document.AddData(printTbl);

            document.AddData(printZlecenia);

            if (printZlecenia2.Rows.Count > 0) document.AddData(printZlecenia2);

            PrintPreviewDialog printDLG = new PrintPreviewDialog();

            document.setXML(Settings.AppDirectory + "\\Ksiazka.xml");

            printDLG.Document = document;

            printDLG.Width = Screen.PrimaryScreen.Bounds.Width;
            printDLG.Height = Screen.PrimaryScreen.Bounds.Height;


            printDLG.ShowDialog();
        }

        public static string GetMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return "Styczeń";

                case 2:
                    return "Luty";

                case 3:
                    return "Marzec";

                case 4:
                    return "Kwiecień";

                case 5:
                    return "Maj";

                case 6:
                    return "Czerwiec";

                case 7:
                    return "Lipiec";

                case 8:
                    return "Sierpień";

                case 9:
                    return "Wrzesień";

                case 10: return "Październik";

                case 11: return "Listopad";

                case 12: return "Grudzień";
            }

            return "";
        }

        public static void PrintWorkersReport(List<UslugaRepCls> uslugi, WorkerRep.TYPE typ,
            string Data_Od, string Data_Do)
        {
            document.Dispose();

            document = new ReportDocument();

            DataTable printTbl = new DataTable("tblRaport");


            for (int i = 0; i < 8; i++)
                printTbl.Columns.Add(i.ToString());

            float SumaBrutto = 0;
            int SumaCzas = 0;

            for (int j = 0; j < uslugi.Count; j++)
            {
                printTbl.Rows.Add((j + 1).ToString(), uslugi[j].IMIE, uslugi[j].NAZWISKO,
                    uslugi[j].ADRES, uslugi[j].NUMER, uslugi[j].NAZWA, uslugi[j].Brutto,
                    uslugi[j].CZAS);

                SumaBrutto += uslugi[j].Brutto;
                SumaCzas += uslugi[j].CZAS;
            }

            printTbl.Rows.Add("", "", "", "", "", "", "", "");

            printTbl.Rows.Add("", "", "", "", "", "RAZEM:", SumaBrutto, SumaCzas);


            string TytulRaportu = "";
            string TypRaportu = "";

            switch (typ)
            {
                case WorkerRep.TYPE.VIEWBYMONTH:
                    TytulRaportu = "Raport czasu pracy za msc. " + GetMonthName(DateTime.Today.Month);
                    TypRaportu = "Data: " + DateTime.Today.ToShortDateString();
                    break;

                case WorkerRep.TYPE.VIEWBYDAY:
                    TytulRaportu = "Dzienny raport czasu pracy";
                    TypRaportu = "Data: " + DateTime.Today.ToShortDateString();
                    break;

                case WorkerRep.TYPE.VIEWBYDATE:
                    TytulRaportu = "Raport czasu pracy za okres od " + Data_Od + " do " + Data_Do;
                    TypRaportu = "Data: " + DateTime.Today.ToShortDateString();
                    break;
            }

            document.AddText("Tytul", TytulRaportu);

            document.AddText("rodzaj", TypRaportu);

            document.AddData(printTbl);

            PrintPreviewDialog printDLG = new PrintPreviewDialog();

            document.setXML(Settings.AppDirectory + "\\Workers.xml");

            printDLG.Document = document;

            printDLG.Width = Screen.PrimaryScreen.Bounds.Width;
            printDLG.Height = Screen.PrimaryScreen.Bounds.Height;


            printDLG.ShowDialog();
        }
    }
}
