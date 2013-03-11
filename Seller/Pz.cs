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
    public partial class Pz : Form
    {
        #region PUBLIC

        public enum TYPE
        {
            PZ,
            WZ,
            VIEW
        }

        public bool CANCEL = true;

        public List<Produkt> PRODUKTY = new List<Produkt>();

        public Produkt SELECTED = null;

        public int CID = -1;

        #endregion

        #region PRIVATE

        private TYPE TrybPracy = TYPE.PZ;

        private int prevSelectedIndex = -1;

        private int SelectedIndex = -1;

        #endregion

        #region ACCESS

        public float SUMA
        {
            get { if (String.IsNullOrEmpty(txtSuma.Text)) return 0; else return float.Parse(txtSuma.Text); }
            set { txtSuma.Text = MathHelp.AddZero(value.ToString()); }
        }

        public int MID 
        {
            get 
            {
                try { return int.Parse(cbxMagazynI.SelectedValue.ToString()); }
                catch { return -1; }
            } 
            set { cbxMagazynI.SelectedValue = value; } }

        public int TYP_DOKUMENTU
        {
            get
            {
                if (TrybPracy == TYPE.PZ) return 0;
                else if (TrybPracy == TYPE.WZ) return 1;

                return -1;
            }

            set
            {
                if (TrybPracy == TYPE.PZ) txtDocument.Text = "PZ - przyjęcie zewnętrzne";
                else if (TrybPracy == TYPE.WZ) txtDocument.Text = "WZ - wydanie zewnętrzne";
                else if (TrybPracy == TYPE.VIEW)
                {
                    if (value == 0) { txtDocument.Text = "PZ - przyjęcie zewnętrzne"; this.Text = "Przyjęcie magazynowe - podgląd"; lblKOntrahent.Text = "Dostawca"; }
                    else { txtDocument.Text = "WZ - wydanie zewnętrzne"; this.Text = "Wydanie magazynowe - podgląd"; lblKOntrahent.Text = "Klient"; }
                }
            }
        }

        public string DATA { get { return DateHelp.GetDate(dtpData.Value); } set { dtpData.Value = DateTime.Parse(value); } }

        #endregion

        public Pz(TYPE tryb)
        {
            InitializeComponent();

            this.TrybPracy = tryb;
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdKoniec_Click(object sender, EventArgs e)
        {
            if (MID < 0)
            {
                Message.ErrorMessage("Proszę wybrać magazyn");
                cbxMagazynI.BackColor = Color.Yellow;
                return;
            }
            else cbxMagazynI.BackColor = Color.White;

            if (CID < 0)
            {
                Message.ErrorMessage("Proszę wybrać klienta");
                txtKontrahent.BackColor = Color.Yellow;
                return;
            }
            else txtKontrahent.BackColor = Color.White;

            if (dgvProdukty.Rows.Count == 0) { Message.ErrorMessage("Nie wprowadzono towaru"); return; }

            if (TrybPracy == TYPE.PZ)
            { if (!Message.AskMessage("Czy napewno zakończyć przyjęcie towaru? Poźniejsze zmiany nie będą możliwe.")) return; }
            else if (TrybPracy == TYPE.WZ)
                if (!Message.AskMessage("Czy napewno zakończyć wydanie towaru? Poźniejsze zmiany nie będą możliwe")) return;

            for (int i = 0; i < PRODUKTY.Count; i++)
            {
                PRODUKTY[i].MID = this.MID;
                PRODUKTY[i].PID = PRODUKTY[i].ID;
            }

            CANCEL = false;

            Close();
        }


        private void LoadProducts()
        {
            dgvProdukty.DataSource = null;

            dgvProdukty.DataSource = PRODUKTY;

            SetDataGridView.SetAddedProduktView(ref dgvProdukty);
        }

        private void cmdUsun_Click(object sender, EventArgs e)
        {
            Produkt selected = null;

            try { selected = (Produkt)dgvProdukty.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            if (!Message.AskMessage("Czy napewno usunąć wybraną pozycję?")) return;

            dgvProdukty.DataSource = null;

            SUMA -= selected.SUMA;

            PRODUKTY.Remove(selected);

            LoadProducts();
        }

        private void txtKontrahent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #region LOAD

        private void LoadMagazyny()
        {
            cbxMagazynI.DisplayMember = "";
            cbxMagazynI.ValueMember = "";
            cbxMagazynI.DataSource = null;

            List<Mgzyn> magazyny = new List<Mgzyn> { new Mgzyn { ID = -1, MAGAZYN = "Wybierz lub dodaj" } };

            if (Settings.MAGAZYNY != null) magazyny.AddRange(Settings.MAGAZYNY);

            cbxMagazynI.DataSource = magazyny;

            cbxMagazynI.DisplayMember = "MAGAZYN";

            cbxMagazynI.ValueMember = "ID";

        }


        private void LoadForPz()
        {
            this.Text = "Przyjęcie towaru do magazynu";
            this.cmdKoniec.Text = "Zakończ przyjęcie";

            lblKOntrahent.Text = "Dostawca";

            TYP_DOKUMENTU = 0;

            button1.Enabled = false;
        }

        private void LoadForWz()
        {
            this.Text = "Wydanie towaru z magazynu";
            this.cmdKoniec.Text = "Zakończ wydanie";

            lblKOntrahent.Text = "Klient";

            TYP_DOKUMENTU = 1;
        }

        private void LoadProdukt()
        {
            if (this.SELECTED == null) return;

            TYP_DOKUMENTU = SELECTED.TYPE;

            DATA = SELECTED.DATA;

            SUMA = SELECTED.SUMA;

            MID = SELECTED.MID;

            List<Klient> klienci = CustomerDatabase.GetCustomers(SELECTED.CID, "", "", "", "",
                "", "");

            txtKontrahent.DataSource = klienci;
            txtKontrahent.DisplayMember = "LISTA";
            txtKontrahent.ValueMember = "ID";

            CID = SELECTED.CID;

            PRODUKTY.AddRange(CustomerDatabase.GetPzWzItems(SELECTED.PZWZID));

            LoadProducts();
        }

        private void LoadView()
        {
            LoadProdukt();

            //if (TrybPracy == TYPE.PZ) {   }
            //else if (TrybPracy == TYPE.WZ) {   }

            cmdKoniec.Visible = false;
            cmdAnuluj.Text = "Zamknij";

            cbxMagazynI.Enabled = false;
            cmdMagazynDodaj.Enabled = false;

            button1.Enabled = false;
            cmdKontrahent.Enabled = false;

            label7.Visible = false;
            cbxTowar.Visible = false;

            cmdTowarSzukaj.Visible = false;
            cmdTowarUsun.Visible = false;

            
        }

        private void Pz_Load(object sender, EventArgs e)
        {
            LoadCurrentUser();

            LoadMagazyny();

            switch (TrybPracy)
            {
                case TYPE.PZ:
                    LoadForPz();
                    break;

                case TYPE.WZ:
                    LoadForWz();
                    break;

                case TYPE.VIEW:
                    LoadView();
                    break;
            }

           
        }

        private void LoadCurrentUser()
        {
            cbxUser.Text = USER.User.IMIE + " " + USER.User.NAZWISKO;
        }

        #endregion

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

            CID = -1;

            txtKontrahent.DataSource = klienci;
            txtKontrahent.DisplayMember = "LISTA";
            txtKontrahent.ValueMember = "ID";

            txtKontrahent.Text = "Wybierz z listy";

            Settings.ShowDropDownList(ref txtKontrahent);
        }

        private void cmdPodgląd_Click(object sender, EventArgs e)
        {
            Produkt program = null;

            try { program = (Produkt)dgvProdukty.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            FINDKind viewProduct = new FINDKind(FINDKind.TYPE.PRODUKT_VIEW);

            viewProduct.PRODUKT = program;

            viewProduct.ShowDialog();
        }
       
       

        private void button1_Click(object sender, EventArgs e)//nowy kontrahent
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

        private void txtKontrahent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtKontrahent.DisplayMember == "" || txtKontrahent.ValueMember == "") return;

            CID = (int)txtKontrahent.SelectedValue;

            Klient kontrahent = (Klient)txtKontrahent.SelectedItem;

            //CNAME = kontrahent.LISTA;

            if (TrybPracy == TYPE.PZ)
            {
                cmdKontrahent.Enabled = false;
                button1.Enabled = false;
            }
        }


        private void cmdMagazynDodaj_Click(object sender, EventArgs e)
        {
            Magazyny magazyn = new Magazyny();

            magazyn.ShowDialog();

            if (magazyn.CANCEL) return;

            int mid = CustomerDatabase.NewMagazyn(magazyn.MAGAZYN, magazyn.ADRES);

            Settings.LoadMagazyny();

            LoadMagazyny();

            cbxMagazynI.SelectedValue = mid;

            //cbxMagazynI.SelectedValue = MID;

            Message.InfoMessage("Nowy magazyn został dodany");


        }

        private void cmdTowarSzukaj_Click(object sender, EventArgs e)
        {
            FINDKind.TYPE Typ = FINDKind.TYPE.PRODUKT_FIND_BY_KONTRAHENT;

            if (CID < 0 && TrybPracy == TYPE.PZ)
            {
                Message.ErrorMessage("Proszę wybrać kontrahenta");
                txtKontrahent.BackColor = Color.Yellow;
                return;
            }
            else txtKontrahent.BackColor = Color.White;

            if (MID < 0 && TrybPracy == TYPE.WZ)
            {
                Message.ErrorMessage("Proszę wybrać magazyn");
                cbxMagazynI.BackColor = Color.Yellow;
                return;
            }
            else cbxMagazynI.BackColor = Color.White;

            

            if (TrybPracy == TYPE.PZ) Typ = FINDKind.TYPE.PRODUKT_FIND_BY_KONTRAHENT;
            else if (TrybPracy == TYPE.WZ) Typ = FINDKind.TYPE.MAGAZYN_FIND_BY_WZ;

            FINDKind products = new FINDKind(Typ);

            if (TrybPracy == TYPE.PZ) products.CID = CID;
            else if (TrybPracy == TYPE.WZ) products.MID = MID;

            products.ShowDialog();

            if (products.CANCEL) return;

            List<Produkt> product = CustomerDatabase.GetPrograms(-1, products.KATID,
                products.CID, products.NAZWA_TOWARU, products.NUMER_KATALOGOWY,
                products.MODEL, products.NUMER_SERYJNY);

            if (product == null) { Message.InfoMessage("Nie znaleziono"); return; }

            cbxTowar.DisplayMember = "";
            cbxTowar.ValueMember = "";
            cbxTowar.DataSource = null;

            cbxTowar.DataSource = product;
            cbxTowar.DisplayMember = "CZESC";
            cbxTowar.ValueMember = "ID";

            Settings.ShowDropDownList(ref cbxTowar);

        }

        private void cbxTowar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTowar.DisplayMember == "" || cbxTowar.ValueMember == "") return;

            FINDKind.TYPE typ = FINDKind.TYPE.PRODUKT;

            if (TrybPracy == TYPE.PZ) typ = FINDKind.TYPE.PRODUKT;
            else if (TrybPracy == TYPE.WZ) typ = FINDKind.TYPE.MAGAZYN_VIEW_WZ;

            FINDKind newProgram = new FINDKind(typ);

            Produkt product;

            try { product = (Produkt)cbxTowar.SelectedItem; }
            catch { return; }

            newProgram.PRODUKT = product;

            newProgram.MID = MID;

            newProgram.ShowDialog();

            if (newProgram.CANCEL) return;

            PRODUKTY.Add(newProgram.PRODUKT);

            SUMA += newProgram.PRODUKT.SUMA;

            LoadProducts();

            cbxTowar.DisplayMember = "";
            cbxTowar.ValueMember = "";
            cbxTowar.DataSource = null;


        }

        private void txtDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxMagazynI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMagazynI.DisplayMember == "" || cbxMagazynI.ValueMember == "") return;

            //MID = int.Parse(cbxMagazynI.SelectedValue.ToString());
        }

        private void cmdNowyTowar_Click(object sender, EventArgs e)
        {
            FINDKind newProgram = new FINDKind(FINDKind.TYPE.NEW);

            newProgram.ShowDialog();

            if (newProgram.CANCEL) return;

            if (CustomerDatabase.CheckProgram(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL,
                newProgram.MODEL, newProgram.PRICE, newProgram.VATPRICE, newProgram.JEDNOSTKA, newProgram.PROWIZJA,
                newProgram.PRICE2, newProgram.VATPRICE2))
            { Message.ErrorMessage("Podany produkt już istnieje"); return; }

            CustomerDatabase.NewProgram(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL,
                     newProgram.NUMER_SERYJNY, newProgram.OPIS, newProgram.PRICE, newProgram.VATPRICE, newProgram.JEDNOSTKA,
                     newProgram.PROWIZJA, newProgram.PRICE2, newProgram.VATPRICE2);

            Message.InfoMessage("Produkt został dodany");
        }

       



       


        
    }
}
