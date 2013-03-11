using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Seller
{
    public partial class FINDKind : Form
    {

        #region PUBLIC

        public enum TYPE
        {
            NEW,
            VIEW,
            EDIT,
            FIND,
            PRODUKT,
            PRODUKT_VIEW,
            PRODUKT_FIND_BY_KONTRAHENT,
            MAGAZYN_FIND,
            MAGAZYN_FIND_BY_WZ,
            MAGAZYN_VIEW,
            MAGAZYN_VIEW_WZ,
            MAGAZYN_ADD,
            MAGAZYN_ADD_VIEW
        }   

        public bool CANCEL = true;

        //public DataTable table;

        
        //public int KATID = -1;
        //public int KID = -1;

        //public int DOCID = -1;

        //public string DOSTAWCA = "";

        //public string CATNAME { get { return cbxKategorie.Text; } }

        //public bool ILOSC_ENABLED { set { txtIlosc.Enabled = value; } }

        #endregion

        #region PRIVATE

        private float oldBrutto = 0;

        private TextBox txtVAT = new TextBox();

        private Number num = new Number();

        private List<Control> ctrlList = new List<Control>();

        private TYPE TrybPracy = TYPE.NEW;

        #endregion

        public FINDKind(TYPE tryb)
        {
            InitializeComponent();

            this.TrybPracy = tryb;

            LoadCategories();
            LoadMagazyny();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadMagazyny()
        {
            List<Mgzyn> magazyny = new List<Mgzyn> { new Mgzyn { ID = -1, MAGAZYN = "Wszystkie" } };

            magazyny.AddRange(Settings.MAGAZYNY);

            cbxMagazynI.DataSource = magazyny;

            cbxMagazynI.DisplayMember = "MAGAZYN";

            cbxMagazynI.ValueMember = "ID";
        }

        private bool GetWindowState()
        {
            if (TrybPracy == TYPE.VIEW || TrybPracy == TYPE.PRODUKT_VIEW || TrybPracy == TYPE.MAGAZYN_VIEW
                || TrybPracy == TYPE.MAGAZYN_ADD) return true;
            else return false;
        }

        private void MNtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GetWindowState()) e.Handled = true;
            else num.CheckNumberLetterHash(this, e);
        }


        #region ACCESS

        public Produkt PRODUKT = null;

        public int CID = -1;

        public string NAZWA_TOWARU
        {
            set { MNNtextBox.Text = value; }
            get { return MNNtextBox.Text; }
        }

        public string NUMER_KATALOGOWY
        {
            set { txtKAT.Text = value; }
            get { return txtKAT.Text; }
        }

        public int KATID { get { return int.Parse(cbxKategorie.SelectedValue.ToString()); } set { cbxKategorie.SelectedValue = value; } }

        public string NUMER_SERYJNY
        {
            set { MNtextBox.Text = value; }
            get { return MNtextBox.Text; }
        }

        public string MODEL
        {
            set { txtMODEL.Text = value; }
            get { return txtMODEL.Text; }
        }

        public string OPIS
        {
            set { txtDSC.Text = value; }
            get { return txtDSC.Text; }
        }

        public float PRICE
        {
            set { OCNtextBox.Text = MathHelp.AddZero(value.ToString()); }
            get 
            {
                if (OCNtextBox.Text == "") return 0;

                return float.Parse(OCNtextBox.Text); 
            }
        }

        public float VATPRICE
        {
            set { OCBtextBox.Text = MathHelp.AddZero(value.ToString()); }
            get 
            {
                if (OCBtextBox.Text == "") return 0;
                return float.Parse(OCBtextBox.Text);
            }
        }

        public float PRICE2
        {
            set { txtNetto.Text = MathHelp.AddZero(value.ToString()); }
            get
            {
                if (txtNetto.Text == "") return 0;

                return float.Parse(txtNetto.Text);
            }
        }

        public float VATPRICE2
        {
            set { txtBrutto.Text = MathHelp.AddZero(value.ToString()); }
            get
            {
                if (txtBrutto.Text == "") return 0;
                return float.Parse(txtBrutto.Text);
            }
        }

        public int PROWIZJA { get; set; }

        public string KONTRAHENT
        {
            set { txtKontrahent.Text = value; }
            get { return txtKontrahent.Text; }
        }

        public float ILOSC { get { if (String.IsNullOrEmpty(txtIlosc.Text)) return 0; else return float.Parse(txtIlosc.Text); } set { txtIlosc.Text = value.ToString(); } }

        public string JEDNOSTKA { get { return txtJednostka.Text; } set { txtJednostka.Text = value; } }

        public float STAN
        {
            get 
            {
                if (String.IsNullOrEmpty(txtStanMagazynu.Text)) return 0;
                else return float.Parse(txtStanMagazynu.Text);
            }

            set
            {
                txtStanMagazynu.Text = value.ToString();
            }
        }

        public int MID 
        {
            get
            {
                if (cbxMagazynI.SelectedValue != null) return int.Parse(cbxMagazynI.SelectedValue.ToString());
                else return -1;
            }

            set 
            {
                cbxMagazynI.SelectedValue = value;
            } 
        }


        
        #endregion

        #region LOAD

        private void LoadCategories()
        {
            cbxKategorie.DisplayMember = "";
            cbxKategorie.ValueMember = "";
            cbxKategorie.DataSource = null;


            if (Settings.CATEORIES == null) return;

            List<Category> categorie = new List<Category>();

            categorie.Add(new Category { ID = -1, NAME = "Wybierz" });

            categorie.AddRange(Settings.CATEORIES);

            cbxKategorie.DataSource = categorie;

            cbxKategorie.DisplayMember = "NAME";

            cbxKategorie.ValueMember = "ID";

            //if (Settings.SELECTEDCATEGORY > 0) cbxKategorie.SelectedIndex = Settings.SELECTEDCATEGORY;
        }

        private void LoadEdit()
        {

            this.Text = "Edycja części";
            Savebutton.Text = "Zapisz";

            lblIlosc.Visible = false;
            txtIlosc.Enabled = false;
            txtIlosc.Visible = false;

            lblMagazynI.Visible = false;
            cbxMagazynI.Enabled = false;
            cbxMagazynI.Visible = false;

            lblStanMagazynu.Visible = false;
            txtStanMagazynu.Enabled = false;
            txtStanMagazynu.Visible = false;

            LoadProdukt();

        }

        private void LoadProdukt()
        {
            if (PRODUKT == null) return;

            List<Klient> klient = CustomerDatabase.GetCustomers(PRODUKT.CID, "", "", "",
                "", "", "");

            txtKontrahent.DataSource = klient;
            txtKontrahent.DisplayMember = "LISTA";
            txtKontrahent.ValueMember = "ID";


            CID = PRODUKT.CID;
            NAZWA_TOWARU = PRODUKT.NAME;
            NUMER_KATALOGOWY = PRODUKT.NUMERKAT;
            //MID = PRODUKT.MID;
            MODEL = PRODUKT.MODEL;
            NUMER_SERYJNY = PRODUKT.NUMERSER;
            OPIS = PRODUKT.OPIS;
            KATID = PRODUKT.CATID;
            PRICE = PRODUKT.PRICE;
            VATPRICE = PRODUKT.VATPRICE;
            PRICE2 = PRODUKT.PRICE2;
            VATPRICE2 = PRODUKT.VATPRICE2;
            //ILOSC = PRODUKT.COUNT;
            ILOSC = PRODUKT.STAN;
            STAN = PRODUKT.COUNT;
            JEDNOSTKA = PRODUKT.JEDNOSTKA;

            if (TrybPracy == TYPE.MAGAZYN_VIEW_WZ)
            {
                Produkt towar = CustomerDatabase.CheckTowarInMagazyn(PRODUKT.ID, MID);

                STAN = towar.COUNT;
            }
        }

        private void LoadView()
        {
            this.Text = "Baza części - podgląd";
            Savebutton.Visible = false;
            Cancelbutton.Text = "Zamknij";

            LoadProdukt();

            cmdDodaj.Enabled = false;
            cmdKontrahent.Enabled = false;
            cmdKatDodaj.Enabled = false;

            cbxMagazynI.Visible = false;
            lblMagazynI.Visible = false;

            lblIlosc.Visible = false;
            txtIlosc.Visible = false;

            lblStanMagazynu.Visible = false;
            txtStanMagazynu.Visible = false;


        }

        private void LoadProduktAdd()
        {
            this.Text = "Baza części - podgląd";
            //Savebutton.Visible = false;
            Cancelbutton.Text = "Zamknij";

            LoadProdukt();

            cmdDodaj.Enabled = false;
            cmdKontrahent.Enabled = false;
            cmdKatDodaj.Enabled = false;

            cbxMagazynI.Visible = false;
            lblMagazynI.Visible = false;

            lblStanMagazynu.Visible = false;
            txtStanMagazynu.Visible = false;
        }

        private void LoadProduktView()
        {
            this.Text = "Baza części - podgląd";
            Savebutton.Visible = false;
            Cancelbutton.Text = "Zamknij";

            LoadProdukt();

            cmdDodaj.Enabled = false;
            cmdKontrahent.Enabled = false;
            cmdKatDodaj.Enabled = false;

            cbxMagazynI.Visible = false;
            lblMagazynI.Visible = false;

            lblStanMagazynu.Visible = false;
            txtStanMagazynu.Visible = false;
        }

        private void LoadProduktInMagazynView()
        {
            this.Text = "Magazyn - podgląd";
            Savebutton.Visible = false;
            Cancelbutton.Text = "Zamknij";

            LoadProdukt();

            cmdDodaj.Enabled = false;
            cmdKontrahent.Enabled = false;
            cmdKatDodaj.Enabled = false;

            //cbxMagazynI.Visible = false;
            //lblMagazynI.Visible = false;

            //lblStanMagazynu.Visible = false;
            //txtStanMagazynu.Visible = false;

            lblIlosc.Visible = false;
            txtIlosc.Visible = false;
            cbxMagazynI.Enabled = false;

            cbxKategorie.Enabled = false;
            txtJednostka.Enabled = false;
        }

        private void LoadAddedProduktFromMagazyn()
        {
            this.Text = "Części - podgląd";
            Savebutton.Visible = false;
            Cancelbutton.Text = "Zamknij";

            LoadProdukt();

            cmdDodaj.Enabled = false;
            cmdKontrahent.Enabled = false;
            cmdKatDodaj.Enabled = false;

            //cbxMagazynI.Visible = false;
            //lblMagazynI.Visible = false;

            lblStanMagazynu.Visible = false;
            txtStanMagazynu.Visible = false;

            //lblIlosc.Visible = false;
            //txtIlosc.Visible = false;
            cbxMagazynI.Enabled = false;

            cbxKategorie.Enabled = false;
            txtJednostka.Enabled = false;
        }

        private void LoadProduktFormMagazynAdd()
        {
            this.Text = "Magazyn - dodawanie części";
            Savebutton.Text = "Dodaj";
            Cancelbutton.Text = "Anuluj";

            LoadProdukt();

            cmdDodaj.Enabled = false;
            cmdKontrahent.Enabled = false;
            cmdKatDodaj.Enabled = false;

            //cbxMagazynI.Visible = false;
            //lblMagazynI.Visible = false;

            //lblStanMagazynu.Visible = false;
            //txtStanMagazynu.Visible = false;

            //lblIlosc.Visible = false;
            //txtIlosc.Visible = false;
            cbxMagazynI.Enabled = false;

            cbxKategorie.Enabled = false;
            txtJednostka.Enabled = false;
        }

        private void LoadProduktInMagazynWz()
        {
            this.Text = "Magazyn - podgląd";
            Savebutton.Text = "Dodaj";
            Cancelbutton.Text = "Anuluj";

            LoadProdukt();

            cmdDodaj.Enabled = false;
            cmdKontrahent.Enabled = false;
            cmdKatDodaj.Enabled = false;

            //cbxMagazynI.Visible = false;
            //lblMagazynI.Visible = false;

            //lblStanMagazynu.Visible = false;
            //txtStanMagazynu.Visible = false;

            //lblIlosc.Visible = false;
            //txtIlosc.Visible = false;
            cbxMagazynI.Enabled = false;

            cbxKategorie.Enabled = false;
            txtJednostka.Enabled = false;
        }

        private void LoadFind()
        {
            this.Text = "Baza części - wyszukiwanie";
            Savebutton.Text = "Szukaj";

            cmdDodaj.Enabled = false;
            cmdKatDodaj.Enabled = false;


            lblIlosc.Visible = false;
            txtIlosc.Visible = false;

            lblStanMagazynu.Visible = false;
            txtStanMagazynu.Visible = false;

            txtJednostka.Visible = false;
            lblJednostka.Visible = false;

            lblMagazynI.Visible = false;
            cbxMagazynI.Visible = false;

            txtDSC.Enabled = false;

            txtNetto.Enabled = false;
            txtBrutto.Enabled = false;

            OCNtextBox.Enabled = false;
            OCBtextBox.Enabled = false;

            txtKontrahent.Text =
                MNNtextBox.Text =
                txtKAT.Text =
                MNtextBox.Text =
                txtMODEL.Text = "Wszystkie";

        }

        private void LoadProduktFindByKontrahent()
        {
            this.Text = "Magazyn - wyszukiwanie";
            Savebutton.Text = "Szukaj";

            cmdDodaj.Enabled = false;
            cmdKatDodaj.Enabled = false;

            cmdKontrahent.Enabled = false;

            lblIlosc.Visible = false;
            txtIlosc.Visible = false;

            lblStanMagazynu.Visible = false;
            txtStanMagazynu.Visible = false;

            txtJednostka.Visible = false;
            lblJednostka.Visible = false;

            lblMagazynI.Visible = false;
            cbxMagazynI.Visible = false;

            txtDSC.Enabled = false;

            txtNetto.Visible = false;
            txtBrutto.Visible = false;

            OCNtextBox.Visible = false;
            OCBtextBox.Visible = false;

            groupBox10.Visible = false;
            groupBox1.Visible = false;

            label8.Visible = false;
            txtDSC.Visible = false;

            this.Height = 220;

            txtKontrahent.DataSource = CustomerDatabase.GetCustomers(CID,
                "", "", "", "", "", "");

            txtKontrahent.DisplayMember = "LISTA";
            txtKontrahent.ValueMember = "ID";

            txtKontrahent.SelectedValue = CID;

            txtKontrahent.Enabled = false;

            
                MNNtextBox.Text =
                txtKAT.Text =
                MNtextBox.Text =
                txtMODEL.Text = "Wszystkie";
        }

        private void LoadMagazynFind()
        {
            this.Text = "Magazyn - wyszukiwanie";
            Savebutton.Text = "Szukaj";

            cmdDodaj.Enabled = false;
            cmdKatDodaj.Enabled = false;


            lblIlosc.Visible = false;
            txtIlosc.Visible = false;

            lblStanMagazynu.Visible = false;
            txtStanMagazynu.Visible = false;

            txtJednostka.Visible = false;
            lblJednostka.Visible = false;

            //lblMagazynI.Visible = false;
            //cbxMagazynI.Visible = false;

            txtDSC.Enabled = false;

            txtNetto.Visible = false;
            txtBrutto.Visible = false;

            OCNtextBox.Visible = false;
            OCBtextBox.Visible = false;

            groupBox10.Visible = false;
            groupBox1.Visible = false;

            this.Height = 270;

            txtKontrahent.Text =
                MNNtextBox.Text =
                txtKAT.Text =
                MNtextBox.Text =
                txtMODEL.Text = "Wszystkie";
        }

        private void LoadMagazynFindByWz()
        {
            this.Text = "Magazyn - wyszukiwanie";
            Savebutton.Text = "Szukaj";

            cmdDodaj.Enabled = false;
            cmdKatDodaj.Enabled = false;


            lblIlosc.Visible = false;
            txtIlosc.Visible = false;

            lblStanMagazynu.Visible = false;
            txtStanMagazynu.Visible = false;

            txtJednostka.Visible = false;
            lblJednostka.Visible = false;

            //lblMagazynI.Visible = false;
            cbxMagazynI.Enabled = false;

            txtDSC.Enabled = false;

            txtNetto.Visible = false;
            txtBrutto.Visible = false;

            OCNtextBox.Visible = false;
            OCBtextBox.Visible = false;

            groupBox10.Visible = false;
            groupBox1.Visible = false;

            

            this.Height = 270;

            txtKontrahent.Text =
                MNNtextBox.Text =
                txtKAT.Text =
                MNtextBox.Text =
                txtMODEL.Text = "Wszystkie";
        }

        private void LoadNew()
        {
            this.Text = "Nowa część";
            Savebutton.Text = "Dodaj";

            lblIlosc.Visible = false;
            txtIlosc.Enabled = false;
            txtIlosc.Visible = false;

            lblMagazynI.Visible = false;
            cbxMagazynI.Enabled = false;
            cbxMagazynI.Visible = false;

            lblStanMagazynu.Visible = false;
            txtStanMagazynu.Enabled = false;
            txtStanMagazynu.Visible = false;

         
        }

        private void SetUpForMgzNew()
        {
            //if (produkt == null) return;

            //CID = produkt.CID;
            //CNAME = produkt.CNAME;
            //NAZWA = produkt.NAME;
            //KAT = produkt.NUMERKAT;
            //MODEL = produkt.MODEL;
            //SERIAL = produkt.NUMERSER;
            //DSC = produkt.OPIS;
            //KATID = produkt.CATID;
            //PRICE = produkt.PRICE;
            //VATPRICE = produkt.VATPRICE;
            //////STAN = produkt.COUNT;
            //JEDNOSTKA = produkt.JEDNOSTKA;



            //if (DOCID != 0) STAN = produkt.COUNT;

            //PROWIZJA = produkt.PROWIZJA;

            cbxKategorie.SelectedValue = KATID;
            cbxKategorie.Enabled = false;
            cbxMagazynI.Enabled = false;

            //txtIlosc.Enabled = false;
            txtJednostka.Enabled = false;
            //txtProwizja.Enabled = false;

            if (CID > 0)
            {
                cmdKontrahent.Enabled = false;
                cmdDodaj.Enabled = false;

                //txtKontrahent.Text = CNAME;


            }
        }


        private void NEWKind_Load(object sender, EventArgs e)
        {
            txtVAT.Name = "txtVAT";

            txtVAT.Text = Settings.PROCENT.ToString();

           

            switch (TrybPracy)
            {
                case TYPE.NEW:
                    LoadNew();
                    break;

                case TYPE.VIEW:
                    LoadView();
                    break;

                case TYPE.PRODUKT:
                    LoadProduktAdd();
                    break;

                case TYPE.PRODUKT_VIEW:
                    LoadProduktView();
                    break;

                case TYPE.EDIT:
                    LoadEdit();
                    break;

                case TYPE.FIND:
                    LoadFind();
                    break;

                case TYPE.PRODUKT_FIND_BY_KONTRAHENT:
                    LoadProduktFindByKontrahent();
                    break;

                case TYPE.MAGAZYN_FIND:
                    LoadMagazynFind();
                    break;

                case TYPE.MAGAZYN_FIND_BY_WZ:
                    LoadMagazynFindByWz();
                    break;

                case TYPE.MAGAZYN_VIEW:
                    LoadProduktInMagazynView();
                    break;

                case TYPE.MAGAZYN_ADD:
                    LoadProduktFormMagazynAdd();
                    break;

                case TYPE.MAGAZYN_ADD_VIEW:
                    LoadAddedProduktFromMagazyn();
                    break;

                case TYPE.MAGAZYN_VIEW_WZ:
                    LoadProduktInMagazynWz();
                    break;
            }

            oldBrutto = VATPRICE2;
        }

        #endregion

        #region VAT CALCULATION

        private void OCNtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GetWindowState()) { e.Handled = true; return; }

            int DotIndex = OCNtextBox.Text.LastIndexOf(',');

            int LastIndex = OCNtextBox.Text.Length;

            int Len = LastIndex - DotIndex;

            if (DotIndex > 0 && Len >= 3 && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }

            num.CheckNumberDot(this, e);

        }

        private void OVcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CalculateBrutto()
        {
            int last = OCNtextBox.Text.LastIndexOf(',') + 1;

            int len = OCNtextBox.Text.Length;

            if (last == len) return;

            float mng = 100 + Settings.PROCENT;

            mng /= 100;

            float netto = float.Parse(OCNtextBox.Text);

            mng *= netto;

            mng = (float)Math.Round(mng, 2);

            //OCBtextBox.Text = mng.ToString();

            VATPRICE = mng;

        }

        private void CaluculateNetto()
        {
            int last = OCBtextBox.Text.LastIndexOf(',') + 1;

            int len = OCBtextBox.Text.Length;

            if (last == len) return;

            float mng = 100 + Settings.PROCENT;

            mng /= 100;

            float brutto = float.Parse(OCBtextBox.Text);

            brutto /= mng;

            brutto = (float)Math.Round(brutto, 2);

            //OCNtextBox.Text = brutto.ToString();

            PRICE = brutto;

        }

        private void OCNtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!OCNtextBox.ContainsFocus) return;

            CalculateBrutto();

        }

        private void OVcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OCNtextBox.Text != "") CalculateBrutto();
            else if (OCBtextBox.Text != "") CaluculateNetto();
        }

        private void OCBtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GetWindowState()) { e.Handled = true; return; }

            int DotIndex = OCBtextBox.Text.LastIndexOf(',');

            int LastIndex = OCBtextBox.Text.Length;

            int Len = LastIndex - DotIndex;

            if (DotIndex > 0 && Len >= 3 && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }

            num.CheckNumberDot(this, e);
        }

        private void OCBtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!OCBtextBox.ContainsFocus) return;

            CaluculateNetto();

        }

        #endregion
 
     
        private void cbxCATEGORY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKategorie.ValueMember == "" || cbxKategorie.DisplayMember == "") return;

            KATID = int.Parse(cbxKategorie.SelectedValue.ToString());
 
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (TrybPracy == TYPE.NEW || TrybPracy == TYPE.EDIT)
            {
                bool Result = CheckEntry.CheckEntryCtrl(new List<Control>{
                    MNNtextBox,txtKAT, OCBtextBox, OCNtextBox, txtNetto,txtBrutto});

                bool Result_int = false;

                if (CID < 0) { txtKontrahent.BackColor = Color.Yellow; Result_int = true; }
                if (KATID < 0) { cbxKategorie.BackColor = Color.Yellow; Result_int = true; }

                if (!Result && Result_int) Message.NotAll();

                if (Result || Result_int) return;
            }
            else if (TrybPracy == TYPE.PRODUKT)
            {
                if (ILOSC == 0)
                {
                    Message.ErrorMessage("Proszę uzupełnić ilość");
                    txtIlosc.BackColor = Color.Yellow;
                    return;
                }
                else txtIlosc.BackColor = Color.White;

                PRODUKT.STAN = ILOSC;

                PRODUKT.SUMA = (float)Math.Round(ILOSC * PRODUKT.VATPRICE2, 2);
            }
            else if (TrybPracy == TYPE.MAGAZYN_VIEW_WZ || TrybPracy == TYPE.MAGAZYN_ADD)
            {
                if (ILOSC == 0)
                {
                    Message.ErrorMessage("Proszę uzupełnić ilość");
                    txtIlosc.BackColor = Color.Yellow;
                    return;
                }
                else txtIlosc.BackColor = Color.White;

                if (ILOSC > STAN)
                {
                    Message.ErrorMessage("Ilość przekracza stan magazynu");
                    txtIlosc.BackColor = Color.Yellow;
                    return;
                }
                else txtIlosc.BackColor = Color.White;

                if (VATPRICE2 == 0)
                {
                    Message.ErrorMessage("Proszę uzupełnić cenę sprzedaży");
                    txtBrutto.BackColor = Color.Yellow;
                    return;
                }
                else txtBrutto.BackColor = Color.White;

                if (oldBrutto != VATPRICE2)
                {
                    if (Message.AskMessage("Cena sprzedaży została zmieniona.\nCzy zapisać nową cenę do bazy danych?"))
                    {
                        CustomerDatabase.UpdateProgram(PRODUKT.ID, PRODUKT.CATID, PRODUKT.CID, PRODUKT.NAME,
                            PRODUKT.NUMERKAT, PRODUKT.MODEL, PRODUKT.NUMERSER, PRODUKT.OPIS,
                            PRODUKT.PRICE, PRODUKT.VATPRICE, PRODUKT.JEDNOSTKA, PRODUKT.PROWIZJA,
                            PRICE2, VATPRICE2);

                        Message.InfoMessage("Nowa cena została zapisana");
                    }

                    PRODUKT.VATPRICE2 = VATPRICE2;
                    PRODUKT.PRICE2 = PRICE2;
                }

                PRODUKT.STAN = ILOSC;

                PRODUKT.SUMA = (float)Math.Round(ILOSC * PRODUKT.VATPRICE2);
            }
            else CheckEntry.ClearForAll(new List<Control>{MNNtextBox,txtKAT,MNtextBox,
                txtMODEL});
                
            CANCEL = false;

            Close();
        }

        //private bool CheckEntry()
        //{
            //ClearControls();

            //if (String.IsNullOrEmpty(txtKontrahent.Text)) MarkControl(txtKontrahent);
            //if (String.IsNullOrEmpty(MNNtextBox.Text)) MarkControl(MNNtextBox);
            //if (String.IsNullOrEmpty(OCNtextBox.Text)) MarkControl(OCNtextBox);
            //if (String.IsNullOrEmpty(OCBtextBox.Text)) MarkControl(OCBtextBox);
            //if (txtJednostka.Text == "Wybierz lub wpisz") MarkControl(txtJednostka);

            //if ((int)cbxKategorie.SelectedValue == -1) MarkControl(cbxKategorie);

            //if (txtIlosc.Enabled)
            //{
            //    if (String.IsNullOrEmpty(txtIlosc.Text)) MarkControl(txtIlosc);
            //    if (DOCID != 0 && DOCID > 0)
            //    {
            //        if (STAN == 0) { Message.ErrorMessage("Brak wybranego towaru na magazynie"); return false; }
            //        else if (COUNT > STAN) { Message.ErrorMessage("Wpisana ilość towaru przekracza stan magazynu"); return false; }
            //    }

            //    if (COUNT == 0) { MarkControl(txtIlosc); Message.ErrorMessage("Ilość musi być większa od zera"); return false; }
            //}

            //if (String.IsNullOrEmpty(txtJednostka.Text)) MarkControl(txtJednostka);


            //if (ctrlList.Count > 0)
            //{ Message.ErrorMessage("Proszę uzupełnić wymagane pola (zaznaczone na żółto)"); return false; }

            //return true;
        //}

       

        private void btnWK_Click(object sender, EventArgs e)
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

            CID = -1;

            txtKontrahent.DataSource = klienci;
            txtKontrahent.DisplayMember = "LISTA";
            txtKontrahent.ValueMember = "ID";

            txtKontrahent.Text = "Wybierz z listy";

            Settings.ShowDropDownList(ref txtKontrahent);

            //Selectt selectCustomer = new Selectt("Wybierz kontrahenta", "Wybierz",-1);

            //selectCustomer.ShowDialog();

            //if (selectCustomer.CANCEL) return;

            //CID = selectCustomer.CUSTOMER.ID;

            //txtKontrahent.Text = selectCustomer.CUSTOMER.FIRMA + ", " + selectCustomer.CUSTOMER.NAZWISKO + " " +
            //    selectCustomer.CUSTOMER.IMIE + ", " + selectCustomer.CUSTOMER.ADRES;


            //txtKontrahent.BackColor = Color.White;
        }

     

        private void txtIlosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Savebutton.Visible) e.Handled = true;
            else num.CheckNumberDot(this, e);
        }

        private void txtProwizja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumber(this, e);
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer(Customer.TYPE.NEW);

            newCustomer.ShowDialog();

            if (newCustomer.CANCEL) return;

            int Result = -1;

            Result = CustomerDatabase.NewCustomer(newCustomer.FIRMA, newCustomer.IMIE, newCustomer.NAZWISKO, newCustomer.ADRES,
                    newCustomer.NIP, newCustomer.PESEL, newCustomer.BANK,newCustomer.TELEFON);
           

            if (Result < 0) { Message.ErrorDatabase(); return; }

            txtKontrahent.Text = newCustomer.FIRMA + ", " + newCustomer.NAZWISKO + " " +
                newCustomer.IMIE + ", " + newCustomer.ADRES;

            Message.InfoMessage("Nowy kontrahent został dodany");

            CID = Result;

            txtKontrahent.BackColor = Color.White;
        }

        private void cmdKatDodaj_Click(object sender, EventArgs e)
        {
            newCategory newCat = new newCategory("Nowa kategoria", "Dodaj");

            newCat.ShowDialog();

            if (newCat.CANCEL) return;

            cbxKategorie.DisplayMember = "";
            cbxKategorie.ValueMember = "";

            cbxKategorie.DataSource = null;

            if (CustomerDatabase.GetCategories(newCat.CATEGORY) != null)
            { Message.ErrorMessage("Podana kategoria już istnieje"); return; }

            int katid = CustomerDatabase.NewCategory(newCat.CATEGORY);

            Message.InfoMessage("Nowa kategoria została dodana");

            Settings.LoadCategories();

            LoadCategories();

            cbxKategorie.SelectedValue = katid;
        }

        private void txtKontrahent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtKontrahent.DisplayMember == "" || txtKontrahent.ValueMember == "") return;

            CID = (int)txtKontrahent.SelectedValue;
        }

       

        private void txtNoKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCenaSNetto_TextChanged(object sender, EventArgs e)
        {
            if (!txtNetto.ContainsFocus) return;

            MathHelp.Netto_TextChanged(sender, e, ref txtNetto, ref txtBrutto, ref txtVAT);
        }

      

        private void txtCenaSNetto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GetWindowState()) { e.Handled = true; return; }

            int DotIndex = txtNetto.Text.LastIndexOf(',');

            int LastIndex = txtNetto.Text.Length;

            int Len = LastIndex - DotIndex;

            if (DotIndex > 0 && Len >= 3 && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }

            num.CheckNumberDot(this, e);
        }

        private void txtCenaSBrutto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GetWindowState()) { e.Handled = true; return; }

            int DotIndex = txtBrutto.Text.LastIndexOf(',');

            int LastIndex = txtBrutto.Text.Length;

            int Len = LastIndex - DotIndex;

            if (DotIndex > 0 && Len >= 3 && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }

            num.CheckNumberDot(this, e);
        }

        private void txtBrutto_TextChanged(object sender, EventArgs e)
        {
            if (!txtBrutto.ContainsFocus) return;

            MathHelp.Netto_TextChanged(sender, e, ref txtNetto, ref txtBrutto, ref txtVAT);
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == "Wszystkie") txt.Clear();
        }

        private void txtBrutto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW || TrybPracy == TYPE.PRODUKT_VIEW || TrybPracy == TYPE.MAGAZYN_VIEW) e.Handled = true;
            else
            {
                num.CheckNumberDot(this, e);

            }
        }




      

      
       


    }
}
