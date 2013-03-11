using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.CONTROLS;
using Seller.Class;

namespace Seller
{
    public partial class UslugaDEF : Form
    {

        #region PUBLIC

        public enum TYPE
        {
            NEW,
            VIEW,
            EDIT,
            FIND,
            ADD,
            FIND_BY
        }

        public UslugaC USLUGA = null;

        public TYPE TrybPracy = TYPE.NEW;

        public bool CANCEL = true;

        #endregion

        #region PRIVATE

        private Number num = new Number();

        #endregion

        #region ACCESS

        public string OPIS { get { return txtOpis.Text; } set { txtOpis.Text = value; } }

        public int VAT { get { return int.Parse(txtVAT.Text); } set { txtVAT.Text = value.ToString(); } }

        public float CENA_NETTO { get { return float.Parse(txtNetto.Text); } set { txtNetto.Text = value.ToString(); } }

        public float CENA_BRUTTO { get { return float.Parse(txtBrutto.Text); } set { txtBrutto.Text = value.ToString(); } }

        public string NUMER { get { return txtNumer.Text; } set { txtNumer.Text = value; } }

        public string NAZWA { get { return txtNazwa.Text; } set { txtNazwa.Text = value; } }

        public WorkIdx.TYPE TIME_IDX
        {
            get
            {
                if (rdbConst.Checked) return WorkIdx.TYPE.SELECT;
                else return (WorkIdx.TYPE)cbxVar.SelectedValue;
            }

            set
            {
                if (value == WorkIdx.TYPE.SELECT)
                {
                    cbxVar.Enabled = false;
                    rdbConst.Checked = true;

                }
                else
                {
                    cbxVar.Enabled = true;
                    rdbVar.Checked = true;
                }

                cbxVar.SelectedValue = value;
            }
        }

        #endregion

        public UslugaDEF(TYPE typ)
        {
            InitializeComponent();

            TrybPracy = typ;
        }
       

        //private void cmdKontrahent_Click(object sender, EventArgs e)
        //{
        //    Customer selectCustomer = new Customer(Customer.TYPE.FIND);

        //    selectCustomer.ShowDialog();

        //    if (selectCustomer.CANCEL) return;

        //    List<Klient> klienci = CustomerDatabase.GetCustomers(-1, selectCustomer.FIRMA,
        //        selectCustomer.IMIE, selectCustomer.NAZWISKO, selectCustomer.NIP,
        //        selectCustomer.PESEL, selectCustomer.BANK);

        //    if (klienci == null) { Message.NotFound(); return; }

        //    cbxKontrahent.ValueMember = "";
        //    cbxKontrahent.DisplayMember = "";
        //    cbxKontrahent.DataSource = null;
        //    CID = -1;

        //    cbxKontrahent.DataSource = klienci;
        //    cbxKontrahent.DisplayMember = "LISTA";
        //    cbxKontrahent.ValueMember = "ID";

        //    cbxKontrahent.Text = "Wybierz z listy";

        //    Settings.ShowDropDownList(ref cbxKontrahent);
       // }

        //private void cmdDodaj_Click(object sender, EventArgs e)
        //{
        //    Customer newCustomer = new Customer(Customer.TYPE.NEW);

        //    newCustomer.ShowDialog();

        //    if (newCustomer.CANCEL) return;


        //    CID = CustomerDatabase.NewCustomer(newCustomer.FIRMA, newCustomer.IMIE, newCustomer.NAZWISKO, newCustomer.ADRES,
        //            newCustomer.NIP, newCustomer.PESEL, newCustomer.BANK,newCustomer.TELEFON);


        //    if (CID < 0) { Message.ErrorDatabase(); return; }

        //    cbxKontrahent.DisplayMember = "";
        //    cbxKontrahent.ValueMember = "";
        //    cbxKontrahent.DataSource = null;
           

        //    cbxKontrahent.Text = newCustomer.FIRMA + ", " + newCustomer.NAZWISKO + " " +
        //        newCustomer.IMIE + ", " + newCustomer.ADRES;

        //    FIRMA = newCustomer.FIRMA;
        //    NAZWISKO = newCustomer.NAZWISKO;
        //    IMIE = newCustomer.IMIE;
        //    ADRES = newCustomer.ADRES;

        //    Message.InfoMessage("Nowy kontrahent został dodany");

        //}

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdKioniec_Click(object sender, EventArgs e)
        {
            if (TrybPracy == TYPE.NEW || TrybPracy == TYPE.EDIT)
            {
                CheckEntry.CheckEntryCtrl(new List<Control> { txtNetto, txtBrutto, txtVAT, txtNumer, txtNazwa });

                if (rdbVar.Checked && TIME_IDX == WorkIdx.TYPE.SELECT)
                {
                    Message.ErrorMessage("Proszę wybrać jednostę czasu");
                    cbxVar.BackColor = Color.Yellow;
                    return;
                }
                else cbxVar.BackColor = Color.White;
            }

            if (TrybPracy == TYPE.FIND) CheckEntry.ClearForAll(new List<Control>{txtNumer,
                txtNazwa});

            CANCEL = false;

            Close();
        }

        #region LOAD

        private void LoadNew()
        {
            this.Text = "Nowa usługa";
            cmdKioniec.Text = "Wprowadź";
        }

        private void LoadView()
        {
            this.Text = "Podgląd usługi";
            cmdAnuluj.Text = "Zamknij";

            cmdKioniec.Enabled = false;
            cmdKioniec.Visible =
                rdbVar.Enabled =
                rdbConst.Enabled =
                cbxVar.Enabled = false;

            LoadUsluga();
        }

        private void LoadUsluga()
        {
            if (USLUGA != null)
            {
                NUMER = USLUGA.NUMER;
                NAZWA = USLUGA.NAZWA;

                CENA_NETTO = USLUGA.Netto;
                VAT = USLUGA.VAT;
                CENA_BRUTTO = USLUGA.Brutto;

                TIME_IDX = USLUGA.TIME_INDEX;

                OPIS = USLUGA.OPIS;
            }
        }

        private void LoadAdd()
        {
            this.Text = "Wybrana usługa";
            cmdAnuluj.Text = "Zamknij";

            cmdKioniec.Text = "Dodaj";

            LoadUsluga();
        }

        private void LoadEdit()
        {
            this.Text = "Edycja usługi";
            cmdAnuluj.Text = "Anuluj";

            cmdKioniec.Text = "Zapisz";

            //txtBrutto.Enabled = false;
            //txtNetto.Enabled = false;
            //txtVAT.Enabled = false;

            LoadUsluga();
        }

        private void LoadTimeIndex()
        {
            WorkIdxData.LoadWorkIndex(ref cbxVar);
        }

        private void LoadFind()
        {
            this.Text = "Usługi - wyszukiwanie";
            cmdKioniec.Text = "Szukaj";

            txtNetto.Enabled =
                txtVAT.Enabled =
                txtBrutto.Enabled =
                rdbVar.Enabled = 
                rdbConst.Enabled =
                cbxVar.Enabled =
                txtOpis.Enabled = false;

            NUMER = NAZWA = "Wszystkie";

        }



        private void UslugaDEF_Load(object sender, EventArgs e)
        {

            LoadTimeIndex();

            switch (TrybPracy)
            {
                case TYPE.NEW:
                    LoadNew();
                    break;

                case TYPE.EDIT:
                    LoadEdit();
                    break;

                case TYPE.VIEW:
                    LoadView();
                    break;

                case TYPE.FIND:
                    LoadFind();
                    break;

                case TYPE.ADD:
                    LoadAdd();
                    break;

                case TYPE.FIND_BY:
                    
                    break;
            }
        }

        #endregion

        private void txtNetto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else MathHelp.Cena_KeyPress(sender, e);
        }

        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumber(this, e);
        }

        private void txtNetto_TextChanged(object sender, EventArgs e)
        {
            MathHelp.Netto_TextChanged(sender, e, ref txtNetto, ref txtBrutto, ref txtVAT);
        }

        //private void cmdDodajUsluge_Click(object sender, EventArgs e)
        //{
        //    Usluga usluga = new Usluga(Usluga.TYPE.NEW);

        //    usluga.ShowDialog();

        //    if (usluga.CANCEL) return;

        //    UDEFID = CustomerDatabase.NewUslugaDef(usluga.NUMER_USLUGI, usluga.NAZWA);

        //    cbxUsluga.DisplayMember = "";
        //    cbxUsluga.ValueMember = "";
        //    cbxUsluga.DataSource = null;

        //    cbxUsluga.Text = usluga.NUMER_USLUGI + "   " + usluga.NAZWA;

        //    NUMER = usluga.NUMER_USLUGI;
        //    NAZWA = usluga.NAZWA;

        //    Message.InfoMessage("Dodano nową usługę");
        //}

        //private void cmdSzukaj_Click(object sender, EventArgs e)
        //{
        //    Usluga usluga = new Usluga(Usluga.TYPE.FIND);

        //    usluga.ShowDialog();

        //    if (usluga.CANCEL) return;

        //    List<UslugaC> uslugiDef = CustomerDatabase.GetUslugiDef(usluga.NUMER_USLUGI,
        //        usluga.NAZWA);

        //    if (uslugiDef == null)
        //    { Message.InfoMessage("Nie znaleziono"); return; }

        //    cbxUsluga.DisplayMember = "";
        //    cbxUsluga.ValueMember = "";
        //    cbxUsluga.DataSource = null;
        //    UDEFID = -1;
           

        //    cbxUsluga.DataSource = uslugiDef;
        //    cbxUsluga.DisplayMember = "Nazwa";

        //    cbxUsluga.ValueMember = "ID";

        //    cbxUsluga.Text = "Wybierz z listy usług";

        //    Settings.ShowDropDownList(ref cbxUsluga);


        //}

        //private void cbxUsluga_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbxUsluga.DisplayMember == "" || cbxUsluga.ValueMember == "") return;

        //    UDEFID = int.Parse(cbxUsluga.SelectedValue.ToString());

        //    UslugaC selUsluga = (UslugaC)cbxUsluga.SelectedItem;

        //    NUMER = selUsluga.NUMER;
        //    NAZWA = selUsluga.NAZWA;

        //    cbxUsluga.BackColor = Color.White;
        //}

        private void cbxUsluga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //private void cbxKontrahent_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbxKontrahent.DisplayMember == "" || cbxKontrahent.ValueMember == "") return;

        //    CID = int.Parse(cbxKontrahent.SelectedValue.ToString());

        //    Klient selKlient = (Klient)cbxKontrahent.SelectedItem;

        //    FIRMA = selKlient.FIRMA;
        //    IMIE = selKlient.IMIE;
        //    NAZWISKO = selKlient.NAZWISKO;
        //    ADRES = selKlient.ADRES;

        //    cbxKontrahent.BackColor = Color.White;
        //}

        private void txtOpis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumberLetterHash(this, e);
        }

        private void txtCzas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumber(this, e);
        }

        private void cbxPracownik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNazwa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumberLetterHash(this, e);
        }

        private void rdbConst_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConst.Checked) cbxVar.Enabled = false;
            else cbxVar.Enabled = true;
        }

        private void cbxVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       

       

    }
}
