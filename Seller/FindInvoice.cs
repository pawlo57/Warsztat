using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.CONTROLS.Samochody;
using Seller.Class;

namespace Seller
{
    public partial class FindInvoice : Form
    {
        #region PRIVATE

        private Number num = new Number();

        private class RodzFaktury
        {
            public int ID { get; set; }

            public string Rodzaj { get; set; }
        }

        #endregion

        #region PUBLIC

        public bool CANCEL = true;

        public int CID = -1;

        public int WID = -1;

        public int PID = -1;

        public int CARID = -1;

        public int UID { get { return (int)cbxUser.SelectedValue; } }

        public string NUMER { get { return txtNumer.Text; } }

        public int STATUS { get { return int.Parse(cbxStatus.SelectedValue.ToString()); } }

        public string DATA_OD { get { if (cbcDataWpr.Checked) return DateHelp.GetDate(dtpOD.Value); else return ""; } }

        public string DATA_DO { get { if (cbcDataWpr.Checked) return DateHelp.GetDate(dtpDO.Value); else return ""; } }


        #endregion

        public FindInvoice()
        {
            InitializeComponent();
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            CANCEL = false;
            Close();
        }

        #region LOAD

        private void LoadUsers()
        {

            cbxUser.DataSource = USER.Users;

            cbxUser.DisplayMember = "IMIE";

            cbxUser.ValueMember = "ID";
        }

        private void LoadFaktury()
        {
            List<RodzFaktury> faktury =
                new List<RodzFaktury> 
                {
                    new RodzFaktury { ID = -1, Rodzaj = "Wszystkie" },
                    new RodzFaktury { ID = 0, Rodzaj = "Faktura" },  
                    new RodzFaktury { ID = 1, Rodzaj = "Faktura - korygująca" },
                    new RodzFaktury { ID = 2, Rodzaj = "Faktura - korygująca-anulowana" },
                    new RodzFaktury { ID = 3, Rodzaj = "Paragon" },
                    new RodzFaktury { ID = 4, Rodzaj = "Rachunek uproszczony" }
                };

            cbxStatus.DataSource = faktury;
            cbxStatus.DisplayMember = "Rodzaj";
            cbxStatus.ValueMember = "ID";
        }

        private void FindInvoice_Load(object sender, EventArgs e)
        {
            //cbxStatus.SelectedIndex = 0;

            LoadUsers();

            LoadFaktury();

        }

        #endregion

        private void cbxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNumer_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumberLetterHash(this, e);
        }

        private void cbcDataWpr_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbcDataWpr.Checked) dtpDO.Enabled = dtpOD.Enabled = true;
            else dtpOD.Enabled = dtpDO.Enabled = false;
        }

        

   

        private void cmdKontrahent_Click_1(object sender, EventArgs e)
        {
            Customer selectCustomer = new Customer(Customer.TYPE.FIND);

            selectCustomer.ShowDialog();

            if (selectCustomer.CANCEL) return;

            List<Klient> klienci = CustomerDatabase.GetCustomers(-1, selectCustomer.FIRMA,
                selectCustomer.IMIE, selectCustomer.NAZWISKO, selectCustomer.NIP,
                selectCustomer.PESEL, selectCustomer.BANK);

            if (klienci == null) { Message.NotFound(); return; }

            cbxKontrahent.ValueMember = "";
            cbxKontrahent.DisplayMember = "";
            cbxKontrahent.DataSource = null;
            CID = -1;

            cbxKontrahent.DataSource = klienci;
            cbxKontrahent.DisplayMember = "LISTA";
            cbxKontrahent.ValueMember = "ID";

            cbxKontrahent.Text = "Wybierz z listy";

            Settings.ShowDropDownList(ref cbxKontrahent);
        }

        private void cbxKontrahent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKontrahent.DisplayMember == "" || cbxKontrahent.ValueMember == "") return;

            CID = int.Parse(cbxKontrahent.SelectedValue.ToString());

            cbxKontrahent.BackColor = Color.White;
        }

        private void cmsCarSearch_Click(object sender, EventArgs e)
        {
            //if (CID < 0) { Message.ErrorMessage("Proszę wybrać kontrahenta"); return; }

            CarsFrm CarFind = new CarsFrm(CarsFrm.TYPE.FIND_BY);

            CarFind.CID = CID;

            CarFind.ShowDialog();

            if (CarFind.CANCEL) return;

            List<Car> cars = CustomerDatabase.GetCars(-1, CID, CarFind.MARKA, CarFind.MODEL,
                CarFind.POJEMNOSC, CarFind.TYP, CarFind.ROK_PRODUKCJI, CarFind.REJESTRACJA,
                CarFind.VIN, CarFind.SILNIK, "","");

            if (cars == null) { Message.NotFound(); return; }


            cbxCar.ValueMember = "";
            cbxCar.DisplayMember = "";
            cbxCar.DataSource = null;

            cbxCar.DataSource = cars;
            cbxCar.DisplayMember = "SAMOCHOD";
            cbxCar.ValueMember = "ID";


            Settings.ShowDropDownList(ref cbxCar);
        }

        private void cbxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCar.DisplayMember == "" || cbxCar.ValueMember == "") return;

            CARID = int.Parse(cbxCar.SelectedValue.ToString());
        }

       

    }
}
