using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.Class;

namespace Seller.CONTROLS.Samochody
{
    public partial class KsiazkaSerwisowa : Form
    {

        #region PUBLIC

       

        #endregion


        #region ACCESS

        public int CID = -1;

        public Car CAR = null;

        public string MARKA { get { return txtMarka.Text; } set { txtMarka.Text = value; } }

        public string REJESTRACJA { get { return txtRejestracja.Text; } set { txtRejestracja.Text = value; } }

        public string POJEMNOSC { get { return txtPojemnosc.Text; } set { txtPojemnosc.Text = value; } }

        public string VIN { get { return txtVin.Text; } set { txtVin.Text = value; } }

        public string MODEL { get { return txtModel.Text; } set { txtModel.Text = value; } }

        public string TYP { get { return txtTyp.Text; } set { txtTyp.Text = value; } }

        public string ROK_PRODUKCJI { get { return txtRokProdukcji.Text; } set { txtRokProdukcji.Text = value; } }

        public string SILNIK { get { return txtSilnik.Text; } set { txtSilnik.Text = value; } }

        public string OPIS { get { return txtOpis.Text; } set { txtOpis.Text = value; } }

        public string BADANIE { get { return txtPrzeglad.Text; } set { txtPrzeglad.Text = value; } }

        #endregion

        public KsiazkaSerwisowa()
        {
            InitializeComponent();
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadCar()
        {
            if (CAR == null) return;

            MARKA = CAR.MARKA;
            MODEL = CAR.MODEL;
            ROK_PRODUKCJI = CAR.ROK;
            POJEMNOSC = CAR.POJEMNOSC;
            TYP = CAR.TYP;
            SILNIK = CAR.SILNIK;
            VIN = CAR.VIN;
            REJESTRACJA = CAR.REJESTRACJA;
            OPIS = CAR.OPIS;
            CID = CAR.CID;
            BADANIE = CAR.BADANIE;
        }

        private void LoadKontrahent()
        {
            if (CID > 0)
            {
                txtKontrahent.Text =
                    CustomerDatabase.GetCustomers(CID, "", "", "", "", "", "")[0].LISTA;
                
            }
        }

        private void LoadZlecenia()
        {
            List<Invoice> invoices =
                CustomerDatabase.GetTransakcje(-1, "", CID, -1, "", "", "",
                "", -1, CAR.ID);

            if (invoices == null)
            {
                this.Text = "Książka serwisowa - liczba wynonanych zleceń: 0";
                return;
            }

            dgvMain.DataSource = null;

            dgvMain.DataSource = invoices;

            SetDataGridView.SetTransakcjeViewKsiazka(ref dgvMain);

            this.Text = "Książka serwisowa - liczba wynonanych zleceń: " + dgvMain.Rows.Count;
        }

        private void KsiazkaSerwisowa_Load(object sender, EventArgs e)
        {
            LoadCar();
            LoadKontrahent();

            LoadZlecenia();
        }

        private void txtMarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmdUslugi_Click(object sender, EventArgs e)
        {
            Invoice selected = null;

            try { selected = (Invoice)dgvMain.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            ListaUslug uslugi = new ListaUslug(CAR, selected.ID);

            uslugi.ShowDialog();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            if (CAR == null) return;

            Drukuj.PrintKsiazkaSerwisowa(CAR);
        }
    }
}
