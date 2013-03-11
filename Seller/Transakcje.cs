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
using Seller.CONTROLS.UslugiCtrl;
using Seller.CONTROLS.Samochody;
using Seller.CONTROLS.Usterki;

namespace Seller
{
    public partial class Transakcje : Form
    {

        #region PUBLIC

        public enum TYPE
        {
            NEW,
            EDIT,
            VIEW,
            PRINT,
            FIND
        }

        public bool CANCEL = true;

        public enum SAVE
        {
            SAVE,
            PRINT_ORDER,
            PRINT,
            PRINT_PROTOKOL,
            INFO
        }

        public SAVE SAVE_ONLY = SAVE.SAVE;

        #endregion

        #region PRIVATE

        private TYPE TrybPracy = TYPE.NEW;

        private Number num = new Number();

        #endregion

        #region ACCESS

        public int ID = -1;

        public int CARID = -1;

        

        public string NUMER { get { return txtNumerFaktury.Text; } set { txtNumerFaktury.Text = value; } }

        public FakturaTyp.TYPE TYP { get { return (FakturaTyp.TYPE)cbxTypFaktury.SelectedIndex; } set { cbxTypFaktury.SelectedIndex = (int)value; } }

        public string PRACOWNIK { get { return txtPracownik.Text; } set { txtPracownik.Text = value; } }

        public int UID = -1;

        public string DATA { get { return DateHelp.GetDate(dtpData.Value); } set { dtpData.Value = DateTime.Parse(value); } }

        public string KLIENT { get { return cbxKontrahent.Text; } set { cbxKontrahent.Text = value; } }

        public string TERMIN_ZAPLATY { get { return DateHelp.GetDate(dtpTerminZaplaty.Value); } set { dtpTerminZaplaty.Value = DateTime.Parse(value); } }

        public string TERMIN_UKONCZENIA { get { return DateHelp.GetDate(dtpTerminUkonczenia.Value); } set { dtpTerminUkonczenia.Value = DateTime.Parse(value); } }

        public int CID = -1;

        public float SUMA_NETTO
        {
            get
            {
                if (String.IsNullOrEmpty(txtSumaNetto.Text)) return 0;
                else return float.Parse(txtSumaNetto.Text);
            }

            set { txtSumaNetto.Text = MathHelp.AddZero(value.ToString()); }
        }

        public float SUMA_BRUTTO
        {
            get
            {
                if (String.IsNullOrEmpty(txtSuma.Text)) return 0;
                else return float.Parse(txtSuma.Text);
            }

            set { txtSuma.Text = MathHelp.AddZero(value.ToString()); }
        }

        public int PLATNOSC { get { return cbxPlatnosc.SelectedIndex; } set { cbxPlatnosc.SelectedIndex = value; } }

        public string PLATNOSC_OPIS { get { return cbxPlatnosc.Text; } }

        public string UWAGI { get { return txtUwagi.Text; } set { txtUwagi.Text = value; } }

        public List<Produkt> PRODUKTY = new List<Produkt>();

        public List<UslugaC> USLUGI = new List<UslugaC>();

        public List<Produkt> PREV_PRODUKTY = new List<Produkt>();

        public List<UslugaC> PREV_USLUGI = new List<UslugaC>();

        public Invoice TRANSAKCJA = null;

        public string FIRMA { get; set; }

        public string ADRES { get; set; }

        public string NIP { get; set; }

        public string TELEFON { get; set; }

        public int LICZNIK 
        {
            get
            {
                try { return int.Parse(txtStanLicznika.Text); }
                catch { return -1; }
            }

            set { txtStanLicznika.Text = value.ToString(); }
                
        }

        public int PALIWO
        {
            get
            {
                return cbxPaliwo.SelectedIndex;
            }

            set { cbxPaliwo.SelectedIndex = value; }
        }

        public int DOWOD
        {
            get { return cbxDowod.SelectedIndex; }
            set { cbxDowod.SelectedIndex = value; }
        }

        #endregion


        public Transakcje(TYPE tryb)
        {
            InitializeComponent();

            TrybPracy = tryb;
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            if (TrybPracy != TYPE.VIEW && TrybPracy != TYPE.PRINT)
                if (!Message.AskMessage("Czy napewno anulować?")) return;

            Close();
        }

        private bool CheckForEnd()
        {
            if (CheckEntry.CheckEntryCtrl(new List<Control> { txtNumerFaktury })) return false; ;

            if (CID < 0)
            {
                Message.ErrorMessage("Nie wybrano kontrahenta");

                cbxKontrahent.BackColor = Color.Yellow;

                return false;
            }

            if (CARID < 0)
            {
                Message.ErrorMessage("Nie wybrano pojazdu");

                cbxCar.BackColor = Color.Yellow;

                return false;
            }

            if (String.IsNullOrEmpty(txtStanLicznika.Text))
            {
                Message.ErrorMessage("Proszę wpisać aktualny przebieg");

                txtStanLicznika.BackColor = Color.Yellow;

                return false;
            }
            else txtStanLicznika.BackColor = Color.White;

            return true;
        }


        private void cmdKoniec_Click(object sender, EventArgs e)
        {


            if (!CheckForEnd()) return;
           

            //if (PRODUKTY.Count == 0 && USLUGI.Count == 0)
            //{ Message.ErrorMessage("Lista towarów oraz usług jest pusta"); return; }

            SAVE_ONLY = SAVE.PRINT;

            CANCEL = false;

            Close();
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


        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            FINDKind szukajTowar = new FINDKind(FINDKind.TYPE.MAGAZYN_FIND);

            //szukajTowar.MID = MID;

            szukajTowar.ShowDialog();

            if (szukajTowar.CANCEL) { return; }

            List<Produkt> produkty = CustomerDatabase.GetTowarFromMagazyn(szukajTowar.CID, szukajTowar.KATID, -1,
                szukajTowar.MID, szukajTowar.NAZWA_TOWARU,
                szukajTowar.NUMER_KATALOGOWY, szukajTowar.MODEL, szukajTowar.NUMER_SERYJNY);


            if (produkty == null) { Message.NotFound(); return; }

            cbxTowary.DisplayMember = "";
            cbxTowary.ValueMember = "";
            cbxTowary.DataSource = null;

            cbxTowary.DataSource = produkty;
            cbxTowary.DisplayMember = "TOWAR";
            cbxTowary.ValueMember = "ID";

            Settings.ShowDropDownList(ref cbxTowary);

            cbxTowary.Text = "Wybierz towar z listy";

    
        }




        private void LoadProducts()
        {
            dgvProdukty.DataSource = null;

            dgvProdukty.DataSource = PRODUKTY;

            SetDataGridView.SetAddedTowarView(ref dgvProdukty);

        }

        private void cmdUsun_Click(object sender, EventArgs e)
        {
            Produkt selected = null;

            try { selected = (Produkt)dgvProdukty.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            if (!Message.AskMessage("Czy napewno usunąć wybraną pozycję z listy?")) return;

            SUMA_NETTO -= selected.SUMA_NETTO;
            SUMA_BRUTTO -= selected.SUMA_BRUTTO;

            //CNT -= selected.COUNT;

            PRODUKTY.Remove(selected);

            LoadProducts();

            Message.InfoMessage("Wybrana pozycja została usunięta");
        }

        private void cmdPodgląd_Click(object sender, EventArgs e)
        {
            Produkt program = null;

            try { program = (Produkt)dgvProdukty.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            FINDKind viewProduct = new FINDKind(FINDKind.TYPE.MAGAZYN_ADD_VIEW);

            viewProduct.PRODUKT = program;

            viewProduct.ShowDialog();
        }

        private void txtSuma_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private string GetNumerFaktury()
        {
            return (CustomerDatabase.GetMaxTransakcja() + 1).ToString() + "/" +
                DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void LoadNew()
        {
            this.Text = "Nowe zlecenie";
            cmdKoniec.Text = "Zapisz do bazy oraz drukuj fakturę";
            cmdKoniecSave.Text = "Zapisz do bazy";

            NUMER = GetNumerFaktury();

            cbxTypFaktury.SelectedIndex = 0;

            txtPracownik.Text = USER.User.IMIE + " " + USER.User.NAZWISKO;
            UID = USER.User.ID;

            cbxKontrahent.Text = "Wyszukaj lub dodaj nowy";

            cbxPlatnosc.SelectedIndex = 0;

            dtpTerminZaplaty.Value = DateTime.Parse(Settings.TERMIN);
        }

        private void LoadView()
        {
            this.Text = "Podgląd zlecenia";

            cmdAnuluj.Text = "Zamknij";
            cmdKoniec.Enabled = false;
            cmdKoniec.Visible = false;
            cmdPrintOrder.Visible = false;
            cmdKoniecSave.Enabled = false;
            cmdKoniecSave.Visible = false;
            cmdProtokolPrint.Visible = false;

            //cmdUsterki.Enabled = false;

            cmdPrintInfo.Visible = false;

            cbxTypFaktury.Enabled = false;

            dtpData.Enabled = false;

            cmdKontrahent.Enabled = false;
            cmdKontrahentDodaj.Enabled = false;

            cbxPlatnosc.Enabled = false;

            cbxKontrahent.Enabled = false;
           
            cbxTowary.Enabled = false;

            cmdTowaryDodaj.Enabled = false;
            cmdTowaryUsun.Enabled = false;

            cmdUslugiDodaj.Enabled = false;
            cmdUslugiUsun.Enabled = false;

            cmdCarAdd.Enabled = false;
            cmsCarSearch.Enabled = false;

            if (TRANSAKCJA != null)
            {
                NUMER = TRANSAKCJA.NUMER;
                TYP = TRANSAKCJA.TYP_FAKTURY;
                UID = TRANSAKCJA.UID;
                CID = TRANSAKCJA.CID;
                CARID = TRANSAKCJA.CARID;
                if (!String.IsNullOrEmpty(TRANSAKCJA.TERMIN)) TERMIN_ZAPLATY = TRANSAKCJA.TERMIN;
                if (!String.IsNullOrEmpty(TRANSAKCJA.TERMIN_UKONCZENIA)) TERMIN_UKONCZENIA = TRANSAKCJA.TERMIN_UKONCZENIA;


                LoadCar(CARID);

                txtPracownik.Text = TRANSAKCJA.UNAME;

                DATA = TRANSAKCJA.DATA;

                cbxKontrahent.Text = TRANSAKCJA.CNAME;

                List<Klient> klient = CustomerDatabase.GetCustomers(CID, "", "", "", "", "", "");


                if (!String.IsNullOrEmpty(klient[0].FIRMA)) FIRMA = klient[0].FIRMA + ", ";
                
                if(!String.IsNullOrEmpty(klient[0].IMIE)) FIRMA += klient[0].IMIE + " " + klient[0].NAZWISKO;

                ADRES = klient[0].ADRES;
                NIP = klient[0].NIP;
                TELEFON = klient[0].TELEFON;

                SUMA_NETTO = TRANSAKCJA.PRICE;
                SUMA_BRUTTO = TRANSAKCJA.VATPRICE;

                PLATNOSC = TRANSAKCJA.PLATNOSC;

                UWAGI = TRANSAKCJA.UWAGI;

                LICZNIK = TRANSAKCJA.Licznik;
                PALIWO = TRANSAKCJA.Paliwo;
                DOWOD = TRANSAKCJA.Dowod;

                List<Produkt> produkty = CustomerDatabase.GetTransItems(TRANSAKCJA.ID);

                if (produkty != null) PRODUKTY = produkty;

                LoadProducts();

                List<UslugaC> uslugi = CustomerDatabase.GetUslugiItems(TRANSAKCJA.ID);

                if (uslugi != null) USLUGI = uslugi;

                LoadUslugi();

                //cbxTypFaktury_SelectedIndexChanged(this, null);
            }
        }

        private void LoadPrint()
        {
            LoadView();

            this.Text = "Zlecenie - drukowanie";

            if (TRANSAKCJA.TYP_FAKTURY != FakturaTyp.TYPE.Paragon)
            {
                cmdKoniec.Enabled = true;
                cmdKoniec.Visible = true;
            }

            cmdPrintInfo.Visible = true;

            cmdPrintOrder.Visible = true;

            cmdProtokolPrint.Visible = true;

            //cmdKoniec.Text = "Drukuj";

            
        }

        private void LoadEdit()
        {
            LoadView();

            this.Text = "Zlecenie - edycja";

            cmdKoniec.Enabled = true;
            cmdKoniec.Visible = true;

            cmdKoniecSave.Enabled = true;
            cmdKoniecSave.Visible = true;

            cmdPrintInfo.Visible = true;

            cmdPrintOrder.Visible = true;

            cmdProtokolPrint.Visible = true;

            cmdUsterki.Enabled = true;

            cmdPrintInfo.Visible = true;


            //cmdKoniec.Text = "Drukuj";

            cmdAnuluj.Text = "Anuluj";

            //cbxTypFaktury.SelectedIndex = 0;
            cbxTypFaktury.Enabled = true;

            //txtNumerFaktury.Enabled = true;

            dtpData.Enabled = true;

            cmdTowaryDodaj.Enabled = true;
            cmdTowaryUsun.Enabled = true;

            cmdUslugiDodaj.Enabled = true;
            cmdUslugiUsun.Enabled = true;

            cbxKontrahent.Enabled = true;
            cmdKontrahent.Enabled = true;
            cmdKontrahentDodaj.Enabled = true;

            cbxTowary.Enabled = true;
          
          

            if (PRODUKTY != null) PREV_PRODUKTY.AddRange(PRODUKTY);
            if (USLUGI != null) PREV_USLUGI.AddRange(USLUGI);
        }

        private void Transakcje_Load(object sender, EventArgs e)
        {
            switch (TrybPracy)
            {
                case TYPE.NEW:
                    LoadNew();
                    break;

                case TYPE.VIEW:
                    LoadView();
                    break;

                case TYPE.PRINT:
                    LoadPrint();
                    break;

                case TYPE.EDIT:
                    LoadEdit();
                    break;
            }

        }




        //private void dtpData_CloseUp(object sender, EventArgs e)
        //{
        //    NUMER_FAKTURY = (CustomerDatabase.GetMaxTransakcja() + 1).ToString() + "/" + dtpData.Value.Month.ToString() +
        //            "/" + dtpData.Value.Year.ToString();
        //}





        private void button2_Click(object sender, EventArgs e)
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

            FIRMA = newCustomer.FIRMA;
            ADRES = newCustomer.ADRES;
            NIP = newCustomer.NIP;

            ResetCar();

            Message.InfoMessage("Nowy kontrahent został dodany");
        }

        private void cmdUslugiDodaj_Click(object sender, EventArgs e)
        {
            UslugaPrc usluga = new UslugaPrc(UslugaPrc.TYPE.NEW);

            usluga.ShowDialog();

            if (usluga.CANCEL) return;

            if (usluga.USLUGA.TIME_INDEX != WorkIdx.TYPE.SELECT)
            {
                usluga.USLUGA.SumaBrutto = (float)Math.Round(usluga.USLUGA.Brutto * usluga.CZAS, 2);
                usluga.USLUGA.SumaNetto = (float)Math.Round(usluga.USLUGA.Netto * usluga.CZAS, 2);
            }
            else
            {
                usluga.USLUGA.SumaBrutto = usluga.USLUGA.Brutto;
                usluga.USLUGA.SumaNetto = usluga.USLUGA.Netto;
            }

            SUMA_NETTO += usluga.USLUGA.SumaNetto;
            SUMA_BRUTTO += usluga.USLUGA.SumaBrutto;

            usluga.USLUGA.KWOTA_VAT = (float)Math.Round((usluga.USLUGA.SumaBrutto - usluga.USLUGA.SumaNetto), 2);

            USLUGI.Add(usluga.USLUGA);


            LoadUslugi();

            //List<UslugaC> lstUslugi =
            //    CustomerDatabase.GetUslugi(-1, usluga.NUMER, usluga.NAZWA);

            //if (lstUslugi == null)
            //{ Message.InfoMessage("Nie znaleziono"); return; }

            //cbxUslugi.DisplayMember = "";
            //cbxUslugi.ValueMember = "";
            //cbxUslugi.DataSource = null;

            //cbxUslugi.DataSource = lstUslugi;
            //cbxUslugi.DisplayMember = "USLUGA";

            //cbxUslugi.ValueMember = "ID";

            //cbxUslugi.Text = "Wybierz z listy usług";

            //Settings.ShowDropDownList(ref cbxUslugi);
        }

        private int GetTowarIndex(Produkt towar)
        {
            for (int i = 0; i < PRODUKTY.Count; i++)
                if (PRODUKTY[i].ID == towar.ID) return i;


            return -1;
        }



        private void cbxTowary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTowary.DisplayMember == "" || cbxTowary.ValueMember == "") return;

            Produkt towar = (Produkt)cbxTowary.SelectedItem;

            FINDKind selectProduct = new FINDKind(FINDKind.TYPE.MAGAZYN_ADD);

            //int index = GetTowarIndex(towar);

            //if (index > 0) towar.COUNT -= PRODUKTY[index].COUNT;

            selectProduct.PRODUKT = towar;

            //selectProduct.DOCID = 2;

            //selectProduct.MID = towar.MID;

            selectProduct.ShowDialog();

            if (selectProduct.CANCEL) { towar = null; return; }

            //towar.STAN = selectProduct.ILOSC;

            
            

            //towar.SUMA_NETTO = selectProduct.COUNT * selectProduct.PRICE;
            towar.SUMA_BRUTTO = towar.SUMA = (float)Math.Round(selectProduct.ILOSC * selectProduct.VATPRICE2, 2);

            towar.SUMA_NETTO = (float)Math.Round((towar.SUMA_BRUTTO / (1 + (Settings.PROCENT * 0.01))), 2);

            towar.KWOTA_VAT = (float)Math.Round((towar.SUMA_BRUTTO - towar.SUMA_NETTO), 2);

            SUMA_NETTO += towar.SUMA_NETTO;
            SUMA_BRUTTO += towar.SUMA_BRUTTO;

            //towar.STAN = selectProduct.STAN;

            //if (index > -1)
            //{
            //    PRODUKTY[index].COUNT += towar.COUNT;
            //    PRODUKTY[index].SUMA_NETTO += towar.SUMA_NETTO;
            //    PRODUKTY[index].SUMA_BRUTTO += towar.SUMA_BRUTTO;
            //    PRODUKTY[index].SUMA += towar.SUMA_BRUTTO;
            //}

            PRODUKTY.Add(selectProduct.PRODUKT);

            LoadProducts();

            cbxTowary.DisplayMember = "";
            cbxTowary.ValueMember = "";
            cbxTowary.DataSource = null;

        }

        private void LoadUslugi()
        {
            dgvUslugi.DataSource = null;

            dgvUslugi.DataSource = USLUGI;

            SetDataGridView.SetUslugiView(ref dgvUslugi);
        }

        //private void cbxUslugi_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbxUslugi.DisplayMember == "" || cbxUslugi.ValueMember == "") return;

        //    UslugaC usluga = (UslugaC)cbxUslugi.SelectedItem;


        //    UslugaDEF uslugaView = new UslugaDEF(UslugaDEF.TYPE.ADD);

        //    uslugaView.USLUGA = usluga;

        //    uslugaView.ShowDialog();

        //    if (uslugaView.CANCEL) return;

        //}

        private void cbxKontrahent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKontrahent.DisplayMember == "" || cbxKontrahent.ValueMember == "") return;

            CID = int.Parse(cbxKontrahent.SelectedValue.ToString());

            FIRMA = ((Klient)cbxKontrahent.SelectedItem).FIRMA;

            if (!String.IsNullOrEmpty(FIRMA)) FIRMA += ", ";

            if(!String.IsNullOrEmpty(((Klient)cbxKontrahent.SelectedItem).IMIE))
                FIRMA += ((Klient)cbxKontrahent.SelectedItem).IMIE + " " +
                    ((Klient)cbxKontrahent.SelectedItem).NAZWISKO;

            ADRES = ((Klient)cbxKontrahent.SelectedItem).ADRES;
            NIP = ((Klient)cbxKontrahent.SelectedItem).NIP;

            cbxKontrahent.BackColor = Color.White;

            

            ResetCar();

            //cmdKontrahent.Enabled = false;
            //cmdKontrahentDodaj.Enabled = false;
        }

        private void cmdUslugiUsun_Click(object sender, EventArgs e)
        {
            UslugaC selected = null;

            try { selected = (UslugaC)dgvUslugi.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            if (!Message.AskMessage("Czy napewno usunąć wybraną pozycję z listy?")) return;

            SUMA_NETTO -= selected.SumaNetto;
            SUMA_BRUTTO -= selected.SumaBrutto;

            USLUGI.Remove(selected);

            LoadUslugi();

            Message.InfoMessage("Wybrana pozycja została usunięta");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CID < 0)
            {
                Message.ErrorMessage("Proszę wybrać kontrahenta na którego będzie wystawiona faktura");
                return;
            }

                UslugaDEF usluga = new UslugaDEF(UslugaDEF.TYPE.NEW);

                usluga.ShowDialog();

                if (usluga.CANCEL) return;

                int idUslugi = CustomerDatabase.NewUsluga(usluga.NUMER, usluga.NAZWA, usluga.OPIS,
                    usluga.CENA_NETTO, usluga.VAT, usluga.CENA_BRUTTO,(int)usluga.TIME_IDX);

                USLUGI.Add(new UslugaC
                {
                    ID = idUslugi,
                  
                    OPIS = usluga.OPIS,
                   
                    Netto = usluga.CENA_NETTO,
                    VAT = usluga.VAT,
                    Brutto = usluga.CENA_BRUTTO,
                    KWOTA_VAT = (float)Math.Round((usluga.CENA_BRUTTO - usluga.CENA_NETTO), 2),
                    
                    NUMER = usluga.NUMER,
                    NAZWA = usluga.NAZWA,
                  

                });
            
                SUMA_NETTO += usluga.CENA_NETTO;
                SUMA_BRUTTO += usluga.CENA_BRUTTO;


                LoadUslugi();

                Message.InfoMessage("Nowa usługa została pomyślnie wprowadzona");
            }

        private void cmdUslugiPodglad_Click(object sender, EventArgs e)
        {
            UslugaC selected = null;

            try { selected = (UslugaC)dgvUslugi.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            UslugaPrc usluga = new UslugaPrc(UslugaPrc.TYPE.VIEW);

            usluga.USLUGA = selected;

            usluga.ShowDialog();
        }

        private void cmdTowaryView_Click(object sender, EventArgs e)
        {
            Lista.TYPE Tryb;

            if(TrybPracy == TYPE.VIEW || TrybPracy == TYPE.PRINT) Tryb = Lista.TYPE.PRODUKTY_VIEW;
            else Tryb = Lista.TYPE.PRODUKTY_EDIT;

            Lista listaTowarow = new Lista(Tryb, ref txtSumaNetto, ref txtSuma, CID);

            listaTowarow.PRODUKTY = PRODUKTY;

            listaTowarow.ShowDialog();

            PRODUKTY = listaTowarow.PRODUKTY;

            LoadProducts();
        }

        private void cmdUslugiView_Click(object sender, EventArgs e)
        {
            //if (CID < 0)
            //{ Message.ErrorMessage("Proszę wybrać kontrahenta na którego będzie wystawiona faktura"); return; }

            Lista.TYPE Tryb;

            if (TrybPracy == TYPE.VIEW || TrybPracy == TYPE.PRINT) Tryb = Lista.TYPE.USLUGI_VIEW;
            else Tryb = Lista.TYPE.USLUGI_EDIT;

            Lista listaUslug = new Lista(Tryb, ref txtSumaNetto, ref txtSuma, CID);

            listaUslug.USLUGI = USLUGI;

            listaUslug.ShowDialog();

            USLUGI = listaUslug.USLUGI;

            LoadUslugi();
        }

        private void txtNumerFaktury_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy != TYPE.VIEW && TrybPracy != TYPE.PRINT) num.CheckNumberLetterHash(this, e);
            else e.Handled = true;
        }

        private void cbxTypFaktury_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxTypFaktury_SelectedIndexChanged(object sender, EventArgs e)
        {
            FakturaTyp.TYPE typRachunku = (FakturaTyp.TYPE)cbxTypFaktury.SelectedIndex;

            cmdKoniec.Visible = true;

            switch (typRachunku)
            {
                case FakturaTyp.TYPE.Faktura:
                    cmdKoniec.Text = "Drukuj fakturę";
                    break;

                case FakturaTyp.TYPE.Korygująca:
                    cmdKoniec.Text = "Drukuj fakturę";
                    break;

                case FakturaTyp.TYPE.Korygująca_anulowana:
                    cmdKoniec.Text = "Drukuj fakturę";
                    break;

                case FakturaTyp.TYPE.Paragon:
                    cmdKoniec.Visible = false;
                    break;

                case FakturaTyp.TYPE.Rachunek_uproszczony:
                    cmdKoniec.Text = "Drukuj rachunek";
                    break;
            }
        }

        private void cmsCarSearch_Click(object sender, EventArgs e)
        {
            if (CID < 0) { Message.ErrorMessage("Proszę wybrać kontrahenta"); return; }

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

        private void ResetCar()
        {
            cbxCar.DisplayMember = "";
            cbxCar.ValueMember = "";
            cbxCar.DataSource = null;

            cbxCar.Text = "Wybierz lub dodaj pojazd";

            CARID = -1;
        }

        private void cmdCarAdd_Click(object sender, EventArgs e)
        {
            if (CID < 0) { Message.ErrorMessage("Proszę wybrać kontrahenta"); return; }

            CarsFrm NewCar = new CarsFrm(CarsFrm.TYPE.NEW_BY);

            NewCar.CID = CID;

            NewCar.ShowDialog();

            if (NewCar.CANCEL) return;

            int id = CustomerDatabase.NewCar(CID, NewCar.MARKA, NewCar.MODEL,
                NewCar.POJEMNOSC, NewCar.TYP, NewCar.ROK_PRODUKCJI, NewCar.REJESTRACJA,
                NewCar.VIN, NewCar.OPIS, NewCar.SILNIK, NewCar.BADANIE, -1,
                -1, NewCar.DATA_PRZYJECIA, NewCar.DATA_WYDANIA, -1);

            LoadCar(id);

            Message.InfoMessage("Nowy pojazd został dodany do bazy");
        }

        private void LoadCar(int id)
        {
            cbxCar.DataSource = CustomerDatabase.GetCars(id, -1, "", "", "", "", "", "", "", "","","");

            cbxCar.DisplayMember = "SAMOCHOD";

            cbxCar.ValueMember = "ID";

            CARID = id;

            cbxCar.BackColor = Color.White;
        }

        private void cbxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCar.DisplayMember == "" || cbxCar.ValueMember == "") return;

            Car car = (Car)cbxCar.SelectedItem;

            CarsFrm cars = new CarsFrm(CarsFrm.TYPE.UPDATE);

            cars.CAR = car;

            cars.ShowDialog();

            if (cars.CANCEL) return;

            CustomerDatabase.UpdateCar(car.ID, cars.CID, cars.MARKA, cars.MODEL, cars.POJEMNOSC,
                cars.TYP, cars.ROK_PRODUKCJI, cars.REJESTRACJA, cars.VIN, cars.OPIS, cars.SILNIK, cars.BADANIE,
                -1, -1, cars.DATA_PRZYJECIA, cars.DATA_WYDANIA, -1);

            CARID = int.Parse(cbxCar.SelectedValue.ToString());

            cbxCar.BackColor = Color.White;
        }

        private void cmdKoniecSave_Click(object sender, EventArgs e)
        {
            if (!CheckForEnd()) return;

            SAVE_ONLY = SAVE.SAVE;

            CANCEL = false;

            Close();
        }

        private void cmdPrintOrder_Click(object sender, EventArgs e)
        {
            if (!CheckForEnd()) return;

            SAVE_ONLY = SAVE.PRINT_ORDER;

            CANCEL = false;

            Close();
        }

        private void cmdPrintInfo_Click(object sender, EventArgs e)
        {
            if (!CheckForEnd()) return;

            SAVE_ONLY = SAVE.INFO;

            Transakcje transakcja = (Transakcje)this;

            Drukuj.PrintInfo(ref transakcja);
        }

        private void txtStanLicznika_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumber(this, e);
        }

        private void cbxPaliwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxDowod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmdUsterki_Click(object sender, EventArgs e)
        {
            if (CARID < 0) { Message.ErrorMessage("Proszę dodać lub wybrać pojazd"); return; }

            Usterki usterki;

            if (TrybPracy == TYPE.VIEW || TrybPracy == TYPE.PRINT) usterki = new Usterki(CARID, Usterki.TYPE.VIEW);
            else usterki = new Usterki(CARID, Usterki.TYPE.EDIT);

            usterki.ShowDialog();


        }

        private void cmdProtokolPrint_Click(object sender, EventArgs e)
        {
            if (!CheckForEnd()) return;

            SAVE_ONLY = SAVE.PRINT_PROTOKOL;

            this.CANCEL = false;

            Close();  
        }


        
        
    }
}
