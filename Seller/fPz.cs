using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.Class;

namespace Seller
{
    public partial class fPz : Form
    {

        #region PUBLIC

        public class DOC_TYPE
        {
            public int ID { get; set; }
            public string TYP_DOKUMENTU { get; set; }
        }

        #endregion

        #region ACCESS

        public bool CANCEL = true;

        public int TYPE { get { return int.Parse(cbxDoment.SelectedValue.ToString()); } set { cbxDoment.SelectedValue = value; } }

        public int CID
        {
            get
            {
                try
                {
                    return int.Parse(txtKontrahent.SelectedValue.ToString());
                }
                catch { return -1; }
            }
        }

        public string CNAME { get; set; }

        public int UID { get { return (int)cbxUser.SelectedValue; } }

        public string UNAME { get { return cbxUser.Text; } }

        public string DATA_FROM { get { return DateHelp.GetDate(dtpData.Value); } }

        public string DATA_TO { get { return DateHelp.GetDate(dtpDataDo.Value); } }

        public int MIDI { get { return (int)cbxMagazynI.SelectedValue; } }

        #endregion

        public fPz()
        {
            InitializeComponent();
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadType()
        {
            List<DOC_TYPE> doki = new List<DOC_TYPE>{new DOC_TYPE{ID = -1,TYP_DOKUMENTU="Wszystkie"},
                new DOC_TYPE{ID = 0,TYP_DOKUMENTU = "PZ - przyjęcie zewnętrzne"},
                new DOC_TYPE{ID = 1,TYP_DOKUMENTU = "WZ - wydanie zewnętrzne"}};

            cbxDoment.DataSource = doki;

            cbxDoment.DisplayMember = "TYP_DOKUMENTU";
            cbxDoment.ValueMember = "ID";
        }

        private void cmdKontrahent_Click(object sender, EventArgs e)
        {
            Customer selectCustomer = new Customer(Customer.TYPE.FIND);

            selectCustomer.ShowDialog();

            if (selectCustomer.CANCEL) return;

            List<Klient> klienci = CustomerDatabase.GetCustomers(-1, selectCustomer.FIRMA,
                selectCustomer.IMIE, selectCustomer.NAZWISKO, selectCustomer.NIP,
                selectCustomer.PESEL, selectCustomer.BANK);

            if (klienci == null) { Message.NotFound(); return; }

            txtKontrahent.ValueMember = "";
            txtKontrahent.DisplayMember = "";
            txtKontrahent.DataSource = null;

            //CID = -1;

            txtKontrahent.DataSource = klienci;
            txtKontrahent.DisplayMember = "LISTA";
            txtKontrahent.ValueMember = "ID";

            txtKontrahent.Text = "Wybierz z listy";

            Settings.ShowDropDownList(ref txtKontrahent);

        }

        private void cbxDoment_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxDoment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmdKoniec_Click(object sender, EventArgs e)
        {
            
            CANCEL = false;

            Close();
        }

        private void LoadMagazyny()
        {
            List<Mgzyn> magazyny = new List<Mgzyn>();

            List<Mgzyn> magazynyII = new List<Mgzyn>();

            magazyny.Add(new Mgzyn { ID = -1,MAGAZYN = "Wszystkie" });

            magazyny.AddRange(Settings.MAGAZYNY);

            cbxMagazynI.DataSource = magazyny;

            cbxMagazynI.DisplayMember = "MAGAZYN";

            cbxMagazynI.ValueMember = "ID";

        }

        private void LoadUsers()
        {
            cbxUser.DataSource = USER.Users;

            cbxUser.DisplayMember = "IMIE";

            cbxUser.ValueMember = "ID";
        }

        private void LoadKOntrahent()
        {

        }

        private void fPz_Load(object sender, EventArgs e)
        {

            LoadUsers();

            LoadMagazyny();

            LoadType();


            dtpData.Value = DateTime.Today - TimeSpan.FromDays(30);
        }

        

     
       

        
    }
}
