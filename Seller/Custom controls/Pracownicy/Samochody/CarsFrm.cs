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
    public partial class CarsFrm : Form
    {
        #region PUBLIC

        public bool CANCEL = true;

        public enum TYPE
        {
            NEW,
            NEW_BY,
            FIND,
            FIND_BY,
            EDIT,
            UPDATE,
            VIEW,
            PRINT
        }

        public int CID = -1;

        public Car CAR = null;

        #endregion

        #region PRIVATE

        private TYPE TrybPracy;

        private Number num = new Number();

        #endregion

        #region ACCESS

        public string MARKA { get { return txtMarka.Text; } set { txtMarka.Text = value; } }

        public string REJESTRACJA { get { return txtRejestracja.Text; } set { txtRejestracja.Text = value; } }

        public string POJEMNOSC { get { return txtPojemnosc.Text; } set { txtPojemnosc.Text = value; } }

        public string VIN { get { return txtVin.Text; } set { txtVin.Text = value; } }

        public string MODEL { get { return txtModel.Text; } set { txtModel.Text = value; } }

        public string TYP { get { return txtTyp.Text; } set { txtTyp.Text = value; } }

        public string ROK_PRODUKCJI { get { return txtRokProdukcji.Text; } set { txtRokProdukcji.Text = value; } }

        public string SILNIK { get { return txtSilnik.Text; } set { txtSilnik.Text = value; } }

        public string OPIS { get { return txtOpis.Text; } set { txtOpis.Text = value; } }

        public string BADANIE { get { return DateHelp.GetDate(dtpBadanie.Value); } set { dtpBadanie.Value = DateTime.Parse(value); } }

        //public int STAN_LICZNIKA 
        //{
        //    get
        //    {
        //        try { return int.Parse(txtStanLicznika.Text); }
        //        catch { return -1; }
        //    }

        //    set { txtStanLicznika.Text = value.ToString(); }
        //}

        //public int PALIWO
        //{
        //    get
        //    {
        //        try { return cbxPaliwo.SelectedIndex; }
        //        catch { return -1; }
        //    }
        //    set { cbxPaliwo.SelectedIndex = value; }
        //}

        public string DATA_PRZYJECIA { get { return DateHelp.GetDate(dtpDataP.Value); } set { try { dtpDataP.Value = DateTime.Parse(value); } catch { } } }

        public string DATA_WYDANIA { get { return DateHelp.GetDate(dtpDataW.Value); } set { try { dtpDataW.Value = DateTime.Parse(value); } catch { } } }

        //public int DOWOD
        //{
        //    get
        //    {
        //        try { return cbxDowod.SelectedIndex; }
        //        catch { return -1; }
        //    }

        //    set { cbxDowod.SelectedIndex = value; }
        //}

        #endregion

        #region LOAD

        private void LoadNew()
        {
            this.Text = "Baza pojazdów - nowy";
            cmdAnuluj.Text = "Anuluj";
            cmdKoniec.Text = "Wprowadź";

           
            //cbxPaliwo.Text = "Wybierz";

            //cbxDowod.Text = "Wybierz";

        }

        private void LoadFindByKontrahent()
        {
            this.Text = "Baza pojazdów - wyszukiwanie";
            cmdAnuluj.Text = "Anuluj";
            cmdKoniec.Text = "Szukaj";
            dtpBadanie.Enabled = false;
            dtpBadanie.Visible = false;
            lblBadanie.Visible = false;
            LoadKontrahent();

            cmdKontrahent.Enabled = false;
            cmdKontrahentDodaj.Enabled = false;

            //txtStanLicznika.Visible = false;

            //cbxPaliwo.Enabled = false;

            dtpDataP.Enabled = false;
            dtpDataW.Enabled = false;

            CheckEntry.SetForAll(new List<Control>{txtMarka,txtModel,
                txtRokProdukcji,txtPojemnosc,txtTyp,txtSilnik,
                txtVin,txtRejestracja});
            
        }

        private void LoadNewByKontrahent()
        {
            LoadNew();
            LoadKontrahent();

            cmdKontrahent.Enabled = false;
            cmdKontrahentDodaj.Enabled = false;

        }

        private void LoadKontrahent()
        {
            if (CID > 0)
            {
                cbxKontrahent.DataSource = CustomerDatabase.GetCustomers(CID, "", "", "", "", "", "");
                cbxKontrahent.DisplayMember = "LISTA";
                cbxKontrahent.ValueMember = "ID";
            }
        }

        private void LoadView()
        {
            this.Text = "Baza pojazdów - podgląd";
            cmdAnuluj.Text = "Zamknij";
            cmdKoniec.Enabled = false;
            cmdKoniec.Visible = false;

            cmdKontrahent.Enabled = false;
            cmdKontrahentDodaj.Enabled = false;

            dtpBadanie.Enabled = false;

            LoadCar();

            LoadKontrahent();
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
            //STAN_LICZNIKA = CAR.STAN_LICZNIKA;
            //PALIWO = CAR.STAN_PALIWA;
            DATA_PRZYJECIA = CAR.DATA_PRZYJECIA;
            DATA_WYDANIA = CAR.DATA_WYDANIA;
            //DOWOD = CAR.DOWOD;

        }

        private void LoadFind()
        {
            this.Text = "Baza pojazdów - wyszukiwanie";
            cmdAnuluj.Text = "Anuluj";
            cmdKoniec.Text = "Szukaj";
            txtOpis.Enabled = false;
            dtpBadanie.Enabled = false;
            //dtpBadanie.Visible = false;
            //lblBadanie.Visible = false;
            cmdKontrahentDodaj.Enabled = false;

            dtpDataP.Enabled = false;
            
            dtpDataW.Enabled = false;
         
            //txtStanLicznika.Enabled = false;
            
            //cbxPaliwo.Enabled = false;
          
            CheckEntry.SetForAll(new List<Control>{txtMarka,txtModel,
                txtRokProdukcji,txtPojemnosc,txtTyp,txtSilnik,
                txtVin,txtRejestracja,cbxKontrahent});

          
        }

        private void LoadEdit()
        {
            this.Text = "Baza pojazdów - edycja";
            cmdKoniec.Text = "Zapisz";
            cmdAnuluj.Text = "Anuluj";

            LoadCar();
            LoadKontrahent();
        }

        private void LoadEditToEntry()
        {
            this.Text = "Baza pojazdów - aktualizacja danych pojazdu";
            cmdKoniec.Text = "Wprowadź";
            cmdAnuluj.Text = "Anuluj";

            LoadCar();
            LoadKontrahent();
        }

        private void LoadPrint()
        {
            this.Text = "Baza pojazdów - drukowanie";
            cmdKoniec.Text = "Drukuj";
            cmdAnuluj.Text = "Anuluj";

            LoadCar();
            LoadKontrahent();
        }

        private void CarsFrm_Load(object sender, EventArgs e)
        {
            switch (TrybPracy)
            {
                case TYPE.NEW:
                    LoadNew();
                    break;

                case TYPE.NEW_BY:
                    LoadNewByKontrahent();
                    break;

                case TYPE.FIND_BY:
                    LoadFindByKontrahent();
                    break;

                case TYPE.VIEW:
                    LoadView();
                    break;
                   
                case TYPE.FIND:
                    LoadFind();
                    break;

                case TYPE.EDIT:
                    LoadEdit();
                    break;

                case TYPE.PRINT:
                    LoadPrint();
                    break;

                case TYPE.UPDATE:
                    LoadEditToEntry();
                    break;
            }
        }

        #endregion

        public CarsFrm(TYPE tryb)
        {
            InitializeComponent();

            TrybPracy = tryb;
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdKoniec_Click(object sender, EventArgs e)
        {
            if (TrybPracy != TYPE.FIND_BY && TrybPracy != TYPE.FIND)
            {
                if (CheckEntry.CheckEntryCtrl(new List<Control>{txtRejestracja,txtMarka,txtPojemnosc,
                txtModel,txtRokProdukcji})) return;

                if (CID < 0)
                {
                    Message.ErrorMessage("Proszę wybrać kontrahenta");
                    cbxKontrahent.BackColor = Color.Yellow;
                    return;
                }
                else cbxKontrahent.BackColor = Color.White;

                //if (PALIWO < 0)
                //{
                //    Message.ErrorMessage("Proszę podać stan paliwa");
                //    cbxPaliwo.BackColor = Color.Yellow;
                //    return;
                //}
                //else cbxPaliwo.BackColor = Color.White;

                //if (DOWOD < 0)
                //{
                //    cbxDowod.BackColor = Color.Yellow;
                //    return;
                //}
                //else cbxDowod.BackColor = Color.White;


                //if (dtpDataP.Value >= dtpDataW.Value)
                //{
                //    Message.ErrorMessage("Data wydania pojazdu musi być większa od daty przyjęcia");
                //    return;
                //}

               

                if (TrybPracy != TYPE.EDIT && TrybPracy != TYPE.PRINT && TrybPracy != TYPE.UPDATE)
                {
                    List<Car> cars = CustomerDatabase.GetCars(-1, -1, "", "", "", "", "",
                    REJESTRACJA, "", "", "", "");

                    if (cars != null)
                    {
                        Message.ErrorMessage("Istnieje już pojazd o takim numerze rejestracyjnym");
                        return;
                    }
                }
            }
            else if (TrybPracy == TYPE.FIND || TrybPracy == TYPE.FIND_BY)
            {
                CheckEntry.ClearForAll(new List<Control>{txtMarka,txtModel,
                txtRokProdukcji,txtPojemnosc,txtTyp,txtSilnik,
                txtVin,txtRejestracja,cbxKontrahent});
            }


            CANCEL = false;

            Close();
        }

      
        private void cbxKontrahent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKontrahent.DisplayMember == "" || cbxKontrahent.ValueMember == "") return;

            CID = int.Parse(cbxKontrahent.SelectedValue.ToString());
        }

        private void cbxKontrahent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtRejestracja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumberLetter(this, e);

            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtPojemnosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumberLetterHash(this, e);
        }

        private void txtRokProdukcji_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumber(this, e);
        }

        private void txtMarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumberLetter(this, e);
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

        private void cmdKontrahentDodaj_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer(Customer.TYPE.NEW);

            newCustomer.ShowDialog();

            if (newCustomer.CANCEL) return;

            CID = CustomerDatabase.NewCustomer(newCustomer.FIRMA, newCustomer.IMIE, newCustomer.NAZWISKO, newCustomer.ADRES,
                    newCustomer.NIP, newCustomer.PESEL, newCustomer.BANK, newCustomer.TELEFON);


            if (CID < 0) { Message.ErrorDatabase(); return; }

            cbxKontrahent.DisplayMember = "";
            cbxKontrahent.ValueMember = "";
            cbxKontrahent.DataSource = null;


            cbxKontrahent.Text = newCustomer.FIRMA + ", " + newCustomer.NAZWISKO + " " +
                newCustomer.IMIE + ", " + newCustomer.ADRES;

            //FIRMA = newCustomer.FIRMA;
            //ADRES = newCustomer.ADRES;
            //NIP = newCustomer.NIP;


            Message.InfoMessage("Nowy kontrahent został dodany");
        }

        private void txtMarka_Click(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            if (String.IsNullOrEmpty(textbox.Text)) return;

            if (textbox.Text == "Wszystkie") textbox.Clear();
        }

        private void cbxPaliwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    

      

       

       

       
    }
}
