using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Seller.Class;

namespace Seller.CONTROLS
{
    public partial class Transactions : UserControl
    {
        #region PRIVATE

        private DataTable table = new DataTable();

        

        #endregion

        public Transactions()
        {
            InitializeComponent();

            
        }

        private void LoadTransactions(int ID,string numer, int CID, int UID, string DataOD, string DataDo,
            string BDataOd, string BDataDo, int status, int CARID)
        {
           
            List<Invoice> invoices = CustomerDatabase.GetTransakcje(ID, numer, CID, UID, DataOD, DataDo, BDataOd, 
                BDataDo, status, CARID); 

            if (invoices == null) { Message.InfoMessage("Nic nie znaleziono"); return; }

            dgwTransactions.DataSource = null;

            dgwTransactions.DataSource = invoices;

            SetDataGridView.SetTransakcjeView(ref dgwTransactions);

        }

       

        private void cmdSzukaj_Click(object sender, EventArgs e)
        {
            FindInvoice fi = new FindInvoice();

            fi.ShowDialog();

            if (fi.CANCEL) return;

            LoadTransactions(-1, fi.NUMER, fi.CID, fi.UID, fi.DATA_OD, fi.DATA_DO, "",
                "", fi.STATUS, fi.CARID);
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdNowy_Click(object sender, EventArgs e)
        {
            Transakcje nowaSprzedaz = new Transakcje(Transakcje.TYPE.NEW);

            nowaSprzedaz.ShowDialog();

            if (nowaSprzedaz.CANCEL) return;

            int newRowID = CustomerDatabase.NewTranskacja(nowaSprzedaz.NUMER, nowaSprzedaz.CID, USER.User.ID,
                nowaSprzedaz.PLATNOSC, nowaSprzedaz.SUMA_NETTO, nowaSprzedaz.SUMA_BRUTTO, (int)nowaSprzedaz.TYP,
                nowaSprzedaz.DATA, nowaSprzedaz.UWAGI, nowaSprzedaz.CARID, nowaSprzedaz.TERMIN_ZAPLATY, nowaSprzedaz.TERMIN_UKONCZENIA,
                nowaSprzedaz.LICZNIK, nowaSprzedaz.PALIWO, nowaSprzedaz.DOWOD);

            if (newRowID < 0) { Message.ErrorMessage("Błąd dodawania danych do bazy"); return; }

            for (int i = 0; i < nowaSprzedaz.PRODUKTY.Count; i++)
                CustomerDatabase.NewItemsInvoice(newRowID, nowaSprzedaz.PRODUKTY[i].MID, nowaSprzedaz.PRODUKTY[i].PID,
                    nowaSprzedaz.PRODUKTY[i].STAN, nowaSprzedaz.PRODUKTY[i].SUMA_NETTO, nowaSprzedaz.PRODUKTY[i].SUMA_BRUTTO, -1);

            for (int i = 0; i < nowaSprzedaz.USLUGI.Count; i++)
                CustomerDatabase.NewItemsInvoice(newRowID, -1, nowaSprzedaz.USLUGI[i].ID, nowaSprzedaz.USLUGI[i].CZAS, nowaSprzedaz.USLUGI[i].SumaNetto,
                    nowaSprzedaz.USLUGI[i].SumaBrutto, nowaSprzedaz.USLUGI[i].WID);


            CustomerDatabase.RemoveTowarFromMagazyn(nowaSprzedaz.PRODUKTY);

        //    Message.InfoMessage("Transakcja wprowadzona pomyślnie");

            LoadTransactions(newRowID, "", -1, -1, "", "", "", "", -1, -1);

            if (nowaSprzedaz.SAVE_ONLY == Transakcje.SAVE.PRINT) Drukuj.PrintInvoice(ref nowaSprzedaz);
            else if (nowaSprzedaz.SAVE_ONLY == Transakcje.SAVE.PRINT_ORDER) Drukuj.PrintOrder(ref nowaSprzedaz);
            else if (nowaSprzedaz.SAVE_ONLY == Transakcje.SAVE.PRINT_PROTOKOL) Drukuj.PrintProtokol(ref nowaSprzedaz);
        }

        private void cmdPodglad_Click(object sender, EventArgs e)
        {
            Invoice selected = null;

            try { selected = (Invoice)dgwTransactions.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            Transakcje podgladTransakcji = new Transakcje(Transakcje.TYPE.VIEW);

            podgladTransakcji.TRANSAKCJA = selected;

            podgladTransakcji.ShowDialog();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            Invoice selected = null;

            try { selected = (Invoice)dgwTransactions.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            //if (selected.TYP_FAKTURY == FakturaTyp.TYPE.Paragon)
            //{
            //    Message.ErrorMessage("To jest paragon i może być drukowany wyłącznie na kasie fiskalnej");
            //    cmdPodglad_Click(this, e);
            //    return;
            //}

            Transakcje podgladTransakcji = new Transakcje(Transakcje.TYPE.PRINT);

            podgladTransakcji.TRANSAKCJA = selected;

            podgladTransakcji.ShowDialog();

            if (podgladTransakcji.CANCEL) return;

            if (podgladTransakcji.SAVE_ONLY == Transakcje.SAVE.PRINT) Drukuj.PrintInvoice(ref podgladTransakcji);
            else if (podgladTransakcji.SAVE_ONLY == Transakcje.SAVE.PRINT_ORDER) Drukuj.PrintOrder(ref podgladTransakcji);
            else if (podgladTransakcji.SAVE_ONLY == Transakcje.SAVE.PRINT_PROTOKOL) Drukuj.PrintProtokol(ref podgladTransakcji);
        }

        private void cmdKoryguj_Click(object sender, EventArgs e)
        {
            Invoice selected = null;

            try { selected = (Invoice)dgwTransactions.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            //if (selected.TYP_FAKTURY != 0)
            //{ Message.ErrorMessage("Wybrana faktura jest już korygująca. Nie można jej ponownie edytować."); cmdPodglad_Click(this, e); return; }

            Transakcje nowaSprzedaz = new Transakcje(Transakcje.TYPE.EDIT);

            nowaSprzedaz.TRANSAKCJA = selected;

            nowaSprzedaz.ShowDialog();

            if (nowaSprzedaz.CANCEL) return;

            if (nowaSprzedaz.TYP == FakturaTyp.TYPE.Korygująca_anulowana)
            {
                nowaSprzedaz.SUMA_BRUTTO = 0;
                nowaSprzedaz.SUMA_NETTO = 0;
            }

            CustomerDatabase.UpdateTransakcja(selected.ID, nowaSprzedaz.NUMER, nowaSprzedaz.CID,
                nowaSprzedaz.UID, nowaSprzedaz.PLATNOSC, nowaSprzedaz.SUMA_NETTO,
                nowaSprzedaz.SUMA_BRUTTO, (int)nowaSprzedaz.TYP, nowaSprzedaz.DATA,
                nowaSprzedaz.UWAGI, nowaSprzedaz.CARID, nowaSprzedaz.TERMIN_ZAPLATY, nowaSprzedaz.TERMIN_UKONCZENIA,
                nowaSprzedaz.LICZNIK, nowaSprzedaz.PALIWO, nowaSprzedaz.DOWOD);

            //int newRowID = CustomerDatabase.NewTranskacja(nowaSprzedaz.NUMER, nowaSprzedaz.CID, USER.User.ID,
            //   nowaSprzedaz.PLATNOSC, nowaSprzedaz.SUMA_NETTO, nowaSprzedaz.SUMA_BRUTTO, nowaSprzedaz.TYP,
            //   nowaSprzedaz.DATA, nowaSprzedaz.UWAGI,nowaSprzedaz.CARID);



            //if (newRowID < 0) { Message.ErrorMessage("Błąd dodawania danych do bazy"); return; }

            CustomerDatabase.RemoveItemsInvoice(selected.ID);

            for (int i = 0; i < nowaSprzedaz.PRODUKTY.Count; i++)
                CustomerDatabase.NewItemsInvoice(selected.ID, nowaSprzedaz.PRODUKTY[i].MID, nowaSprzedaz.PRODUKTY[i].PID,
                    nowaSprzedaz.PRODUKTY[i].STAN, nowaSprzedaz.PRODUKTY[i].SUMA_NETTO,
                    nowaSprzedaz.PRODUKTY[i].SUMA_BRUTTO, -1);

            for (int i = 0; i < nowaSprzedaz.USLUGI.Count; i++)
                CustomerDatabase.NewItemsInvoice(selected.ID, -1, nowaSprzedaz.USLUGI[i].ID, 0, nowaSprzedaz.USLUGI[i].SumaNetto,
                    nowaSprzedaz.USLUGI[i].SumaBrutto, nowaSprzedaz.USLUGI[i].WID);

            CustomerDatabase.NewTowarToMagazyn(nowaSprzedaz.PREV_PRODUKTY);


            if (nowaSprzedaz.TYP !=  FakturaTyp.TYPE.Korygująca_anulowana) CustomerDatabase.RemoveTowarFromMagazyn(nowaSprzedaz.PRODUKTY);

            //    Message.InfoMessage("Transakcja wprowadzona pomyślnie");

            LoadTransactions(selected.ID, "", -1, -1, "", "", "", "", -1, -1);

            if (nowaSprzedaz.SAVE_ONLY == Transakcje.SAVE.PRINT) Drukuj.PrintInvoice(ref nowaSprzedaz);
            else if (nowaSprzedaz.SAVE_ONLY == Transakcje.SAVE.PRINT_ORDER) Drukuj.PrintOrder(ref nowaSprzedaz);
            else if (nowaSprzedaz.SAVE_ONLY == Transakcje.SAVE.PRINT_PROTOKOL) Drukuj.PrintProtokol(ref nowaSprzedaz);
        }

       


        //private void SendErrorMessage(ErrorCode.CODE Result)
        //{
        //    if (Result == ErrorCode.CODE.LOGIN) Message.ErrorMessage("Błąd logowania");
        //    else if (Result == ErrorCode.CODE.EXIST) Message.ErrorMessage("Podana transakcja już istnieje");

        //}


        //private void cmdEdit_Click(object sender, EventArgs e)
        //{
        //    Invoice selected = null;

        //    try { selected = (Invoice)dgwTransactions.CurrentRow.DataBoundItem; }
        //    catch { Message.Position(); return; }

        //    if (selected.STATUS == 3) { Message.InfoMessage("Nie można edytować tej transkacji gdyż została anulowana"); return; }

        //    Transakcje podgladTransakcji = new Transakcje(null, Settings.TYP.EDIT);

        //    podgladTransakcji.TRANSAKCJA = selected;

        //    podgladTransakcji.ShowDialog();

        //    if (podgladTransakcji.CANCEL) return;

        //    if (podgladTransakcji.prevStatus == 0 && podgladTransakcji.STATUS != 0)
        //    {
        //        CustomerDatabase.UpdateTransakcja(selected.ID, podgladTransakcji.NUMER_FAKTURY,
        //         podgladTransakcji.CID, podgladTransakcji.WID, podgladTransakcji.DATA.ToShortDateString(),
        //         podgladTransakcji.STATUS, podgladTransakcji.DATA_ZWROTU.ToShortDateString(), podgladTransakcji.PLATNOSC,
        //         podgladTransakcji.UWAGI);

        //        CustomerDatabase.NewTowarToMagazyn(podgladTransakcji.PRODUKTY);
        //    }
        //    else if (podgladTransakcji.prevStatus != 0 && podgladTransakcji.STATUS != 0 || (podgladTransakcji.STATUS == podgladTransakcji.prevStatus))
        //    {
        //        CustomerDatabase.UpdateTransakcja(selected.ID, podgladTransakcji.NUMER_FAKTURY,
        //            podgladTransakcji.CID, podgladTransakcji.WID, podgladTransakcji.DATA.ToShortDateString(),
        //            podgladTransakcji.STATUS, "", podgladTransakcji.PLATNOSC, podgladTransakcji.UWAGI);
        //    }
        //    else if (podgladTransakcji.prevStatus != 0 && podgladTransakcji.STATUS == 0)
        //    {
        //        CustomerDatabase.UpdateTransakcja(selected.ID, podgladTransakcji.NUMER_FAKTURY,
        //            podgladTransakcji.CID, podgladTransakcji.WID, podgladTransakcji.DATA.ToShortDateString(),
        //            podgladTransakcji.STATUS, "", podgladTransakcji.PLATNOSC, podgladTransakcji.UWAGI);

        //        CustomerDatabase.RemoveTowarFromMagazyn(podgladTransakcji.PRODUKTY);
        //    }

        //    LoadTransactions(selected.ID, "", -1, -1, -1, "", "", "", "", -1, "");

        //    Message.InfoMessage("Transakcja została zapisana");

        }



      
    
}
