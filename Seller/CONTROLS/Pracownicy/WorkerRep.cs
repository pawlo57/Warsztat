using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.Class;

namespace Seller.CONTROLS.Pracownicy
{
    public partial class WorkerRep : Form
    {
        #region PUBLIC

        public enum TYPE
        {
            CANCEL,
            VIEWBYMONTH,
            VIEWBYDAY,
            VIEWBYDATE
        }

        public TYPE RESULT = TYPE.CANCEL;

        #endregion

        #region ACCESS

        public int WID = -1;

        public string DATA_OD { get { return DateHelp.GetDate(dtpDATA_OD.Value); } }

        public string DATA_DO { get { return DateHelp.GetDate(dtpDATA_DO.Value); } }

        #endregion


        public WorkerRep()
        {
            InitializeComponent();
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdMonth_Click(object sender, EventArgs e)
        {
            RESULT = TYPE.VIEWBYMONTH;

            Close();
        }

        private void cmdDay_Click(object sender, EventArgs e)
        {
            RESULT = TYPE.VIEWBYDAY;

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RESULT = TYPE.VIEWBYDATE;

            Close();
        }

        private void cmsWorkerSearch_Click(object sender, EventArgs e)
        {
            FindWorker findWorkers = new FindWorker("Wyszukaj pracowników", "Szukaj");

            findWorkers.ShowDialog();

            if (findWorkers.CANCEL) return;

            List<Worker> workers =
                CustomerDatabase.GetWorkers(-1, findWorkers.IMIE, findWorkers.NAZWISKO,
                findWorkers.PESEL, findWorkers.NIP, findWorkers.BANK);

            if (workers == null) { Message.InfoMessage("Nie znaleziono"); return; }

            cbxWorker.DataSource = workers;

            cbxWorker.DisplayMember = "PRACOWNIK";

            cbxWorker.ValueMember = "ID";

            Settings.ShowDropDownList(ref cbxWorker);
        }

        private void cbxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxWorker.DisplayMember == "" || cbxWorker.ValueMember == "") return;

            WID = int.Parse(cbxWorker.SelectedValue.ToString());
        }

    }
}
