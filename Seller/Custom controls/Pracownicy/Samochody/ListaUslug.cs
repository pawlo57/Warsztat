using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.Class;
using Seller.CONTROLS.UslugiCtrl;

namespace Seller.CONTROLS.Samochody
{
    public partial class ListaUslug : Form
    {
        #region PRIVATE

        private List<UslugaC> USLUGI = null;

        private Car CAR = null;

        private int IID = -1;

        #endregion

      
        public ListaUslug(Car car, int iid)
        {
            InitializeComponent();

            this.CAR = car;
            this.IID = iid;
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadUslugi()
        {
            if (IID < 0) return;

            List<UslugaC> uslugi = CustomerDatabase.GetUslugiItems(IID);

            if (uslugi != null) USLUGI = uslugi;

            dgvMain.DataSource = null;

            dgvMain.DataSource = USLUGI;

            SetDataGridView.SetUslugiView(ref dgvMain);
        }

        private void ListaUslug_Load(object sender, EventArgs e)
        {
            this.Text = "Lista wykonanych zleceń/napraw";

            cmdAnuluj.Text = "Zamknij";
            cmdPrint.Text = "Drukuj";

            LoadUslugi();
        }


        private void cmdUslugiPodglad_Click(object sender, EventArgs e)
        {
            UslugaC selected = null;

            try { selected = (UslugaC)dgvMain.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            UslugaPrc usluga = new UslugaPrc(UslugaPrc.TYPE.VIEW);

            usluga.USLUGA = selected;

            usluga.ShowDialog();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {


            Drukuj.PrintKsiazkaSerwisowaItem(CAR, USLUGI);
        }
    }
}
