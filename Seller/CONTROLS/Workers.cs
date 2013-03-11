using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.Class;
using Seller.CONTROLS.Pracownicy;

namespace Seller.CONTROLS
{
    public partial class Workers : UserControl
    {


        #region PRIVATE

        private WorkerRep.TYPE TYP = WorkerRep.TYPE.CANCEL;

        private string DATA_OD = "";
        private string DATA_DO = "";

        #endregion


        public Workers()
        {
            InitializeComponent();
        }

        private void LoadWorkers(int ID, string imie, string naziwko, string pesel, string nip, string bank)
        {
            List<Worker> workers = CustomerDatabase.GetWorkers(ID, imie, naziwko, pesel, nip, bank); 

            if (workers == null) { Message.InfoMessage("Nie znaleziono"); return; }

            dgwWorkers.DataSource = workers;

            SetDataGridView.SetWorkersView(ref dgwWorkers);
        }

        private void cmdSzukaj_Click(object sender, EventArgs e)
        {
            FindWorker findWorkers = new FindWorker("Wyszukaj pracowników", "Szukaj");

            findWorkers.ShowDialog();

            if (findWorkers.CANCEL) return;

            LoadWorkers(-1, findWorkers.IMIE, findWorkers.NAZWISKO, findWorkers.PESEL, findWorkers.NIP, findWorkers.BANK);
        }

        private void cmdNowy_Click(object sender, EventArgs e)
        {
            FindWorker newWorker = new FindWorker("Nowy pracownik", "Dodaj");

            newWorker.ShowDialog();

            if (newWorker.CANCEL) return;

            CustomerDatabase.NewWorker(newWorker.IMIE, newWorker.NAZWISKO, newWorker.ADRES, newWorker.PESEL,
                newWorker.NIP, newWorker.BANK);

            LoadWorkers(-1, newWorker.IMIE, newWorker.NAZWISKO, newWorker.PESEL, newWorker.NIP, newWorker.BANK);

            Message.InfoMessage("Nowy pracownik został dodany");
        }

            

        private void SendErrorMessage(ErrorCode.CODE Result)
        {
            if (Result == ErrorCode.CODE.LOGIN) { Message.ErrorMessage("Błąd logowania"); return; }
            else if (Result == ErrorCode.CODE.EXIST) { Message.ErrorMessage("Podany pracownik juz istnieje"); return; }
        
        }

        private void cmdEdytuj_Click(object sender, EventArgs e)
        {
            Worker worker ;

            try { worker = (Worker)dgwWorkers.CurrentRow.DataBoundItem; }
            catch { return; }
            
            FindWorker newWorker = new FindWorker("Edycja pracownika", "Zapisz");

            newWorker.IMIE = worker.IMIE;
            newWorker.NAZWISKO = worker.NAZWISKO;
            newWorker.ADRES = worker.ADRES;
            newWorker.PESEL = worker.PESEL;
            newWorker.NIP = worker.NIP;
            newWorker.BANK = worker.BANK;

            newWorker.ShowDialog();

            if (newWorker.CANCEL) return;

            CustomerDatabase.UpdateWorker(worker.ID, newWorker.IMIE, newWorker.NAZWISKO,
                newWorker.ADRES, newWorker.PESEL, newWorker.NIP,newWorker.BANK);

            LoadWorkers(worker.ID, "", "", "", "", "");

            Message.InfoMessage("Zaktulizowano dane pracownika");
        }

        private void cmdCzasPracy_Click(object sender, EventArgs e)
        {
            TYP = WorkerRep.TYPE.VIEWBYMONTH;

            string startDate = DateTime.Today.Year + "-" + DateTime.Today.Month + "-01";

            string endDate = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" +
                DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);


            List<UslugaRepCls> uslugiRep = CustomerDatabase.GetWorkersReport(-1, startDate, endDate);

            if (uslugiRep == null) Message.NotFound();

            dgwWorkers.DataSource = uslugiRep;

            SetDataGridView.SetWorkerReportView(ref dgwWorkers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TYP = WorkerRep.TYPE.VIEWBYDAY;

            List<UslugaRepCls> uslugiRep = CustomerDatabase.GetWorkersReport(-1, DateTime.Today.ToShortDateString(),
                DateTime.Today.ToShortDateString());

            if (uslugiRep == null) Message.NotFound();

            dgwWorkers.DataSource = uslugiRep;

            SetDataGridView.SetWorkerReportView(ref dgwWorkers);
        }

        private void cmdRapDet_Click(object sender, EventArgs e)
        {
            WorkerRep findWorker = new WorkerRep();

            findWorker.ShowDialog();

            TYP = findWorker.RESULT;

            DATA_OD = findWorker.DATA_OD;
            DATA_DO = findWorker.DATA_DO;

            List<UslugaRepCls> uslugiRep = null;

            switch (findWorker.RESULT)
            {
                case WorkerRep.TYPE.CANCEL:
                    return;

                case WorkerRep.TYPE.VIEWBYMONTH:
                    string startDate = DateTime.Today.Year + "-" + DateTime.Today.Month + "-01";

                    string endDate = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" +
                        DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);

                    uslugiRep = CustomerDatabase.GetWorkersReport(findWorker.WID,
                        startDate, endDate);
                    break;

                case WorkerRep.TYPE.VIEWBYDAY:
                    uslugiRep = CustomerDatabase.GetWorkersReport(findWorker.WID, DateTime.Today.ToShortDateString(),
                        DateTime.Today.ToShortDateString());
                    break;

                case WorkerRep.TYPE.VIEWBYDATE:
                    uslugiRep = CustomerDatabase.GetWorkersReport(findWorker.WID,
                        findWorker.DATA_OD, findWorker.DATA_DO);
                    break;
            }

            if (uslugiRep == null) Message.NotFound();

            dgwWorkers.DataSource = uslugiRep;

            SetDataGridView.SetWorkerReportView(ref dgwWorkers);
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            if (dgwWorkers.Rows.Count == 0)
            { Message.ErrorMessage("Brak danych do wydruku"); return; }

            List<UslugaRepCls> uslugi = (List<UslugaRepCls>)dgwWorkers.DataSource;

            Drukuj.PrintWorkersReport(uslugi, TYP, DATA_OD, DATA_DO);
        }

      

      
    }
}
