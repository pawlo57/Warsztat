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

namespace Seller
{
    public partial class Lista : Form
    {
        #region PUBLIC

        public enum TYPE
        {
            PRODUKTY_EDIT,
            PRODUKTY_VIEW,
            USLUGI_EDIT,
            USLUGI_VIEW
        }

        public List<Produkt> PRODUKTY = null;

        public List<UslugaC> USLUGI = null;

        #endregion

        #region PRIVATE

        private TYPE TrybPracy;

        private TextBox txtSumaNetto;

        private TextBox txtSuma;

        private int CID = -1;

        #endregion

        #region ACCESS

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
        

        #endregion

        public Lista(TYPE tryb, ref TextBox txtNetto, ref TextBox txtBrutto, int cid)
        {
            InitializeComponent();

            txtSumaNetto = txtNetto;
            txtSuma = txtBrutto;

            TrybPracy = tryb;

            CID = cid;

        }

        private void cmdZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdTowaryDodaj_Click(object sender, EventArgs e)
        {
            if (TrybPracy == TYPE.PRODUKTY_EDIT)
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
            else if (TrybPracy == TYPE.USLUGI_EDIT)
            {
                UslugaPrc usluga = new UslugaPrc(UslugaPrc.TYPE.NEW);

                usluga.ShowDialog();

                if (usluga.CANCEL) return;


                SUMA_NETTO += usluga.USLUGA.Netto;
                SUMA_BRUTTO += usluga.USLUGA.Brutto;

                usluga.USLUGA.KWOTA_VAT = (float)Math.Round((usluga.USLUGA.Brutto - usluga.USLUGA.Netto), 2);

                USLUGI.Add(usluga.USLUGA);


                LoadUslugi();
            }
        }

        private void cmdTowaryUsun_Click(object sender, EventArgs e)
        {
            if( TrybPracy == TYPE.PRODUKTY_EDIT)
            {
            Produkt selected = null;

            try { selected = (Produkt)dgvLista.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            if (!Message.AskMessage("Czy napewno usunąć wybraną pozycję z listy?")) return;

            SUMA_NETTO -= selected.SUMA_NETTO;
            SUMA_BRUTTO -= selected.SUMA_BRUTTO;

            //CNT -= selected.COUNT;

            PRODUKTY.Remove(selected);

            LoadProducts();

            Message.InfoMessage("Wybrana pozycja została usunięta");
            }
            else if( TrybPracy == TYPE.USLUGI_EDIT)
            {
                            UslugaC selected = null;

            try { selected = (UslugaC)dgvLista.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            if (!Message.AskMessage("Czy napewno usunąć wybraną pozycję z listy?")) return;

            SUMA_NETTO -= selected.Netto;
            SUMA_BRUTTO -= selected.Brutto;

            USLUGI.Remove(selected);

            LoadUslugi();

            Message.InfoMessage("Wybrana pozycja została usunięta");
            }
        }

        private void cmdTowaryPodgląd_Click(object sender, EventArgs e)
        {
            if(TrybPracy == TYPE.PRODUKTY_VIEW)
            {
                Produkt program = null;

                try { program = (Produkt)dgvLista.CurrentRow.DataBoundItem; }
                catch { Message.Position(); return; }

                FINDKind viewProduct = new FINDKind(FINDKind.TYPE.VIEW);

                viewProduct.PRODUKT = program;

                viewProduct.ShowDialog();
            }
            else if( TrybPracy == TYPE.USLUGI_VIEW)
            {
                UslugaC selected = null;

                try { selected = (UslugaC)dgvLista.CurrentRow.DataBoundItem; }
                catch { Message.Position(); return; }

                UslugaPrc usluga = new UslugaPrc(UslugaPrc.TYPE.VIEW);

                usluga.USLUGA = selected;

                usluga.ShowDialog();
            }
        }

        private void LoadProducts()
        {
            dgvLista.DataSource = null;

            dgvLista.DataSource = PRODUKTY;

            SetDataGridView.SetAddedTowarView(ref dgvLista);

        }

        private void LoadUslugi()
        {
            dgvLista.DataSource = null;

            dgvLista.DataSource = USLUGI;

            SetDataGridView.SetUslugiView(ref dgvLista);
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

            if (TrybPracy == TYPE.PRODUKTY_EDIT)
            {
                Produkt towar = (Produkt)cbxTowary.SelectedItem;

                FINDKind selectProduct = new FINDKind(FINDKind.TYPE.NEW);

                int index = GetTowarIndex(towar);

                if (index > 0) towar.COUNT -= PRODUKTY[index].COUNT;

                selectProduct.PRODUKT = towar;

                //selectProduct.DOCID = 2;

                selectProduct.MID = towar.MID;

                selectProduct.ShowDialog();

                if (selectProduct.CANCEL) { towar = null; return; }

                towar.COUNT = selectProduct.ILOSC;

                towar.SUMA_NETTO = selectProduct.ILOSC * selectProduct.PRICE;
                towar.SUMA_BRUTTO = towar.SUMA = selectProduct.ILOSC * selectProduct.VATPRICE;

                SUMA_NETTO += towar.SUMA_NETTO;
                SUMA_BRUTTO += towar.SUMA_BRUTTO;

                towar.STAN = selectProduct.STAN;

                if (index > -1)
                {
                    PRODUKTY[index].COUNT += towar.COUNT;
                    PRODUKTY[index].SUMA_NETTO += towar.SUMA_NETTO;
                    PRODUKTY[index].SUMA_BRUTTO += towar.SUMA_BRUTTO;
                    PRODUKTY[index].SUMA += towar.SUMA_BRUTTO;
                }
                else PRODUKTY.Add(selectProduct.PRODUKT);

                LoadProducts();

                cbxTowary.DisplayMember = "";
                cbxTowary.ValueMember = "";
                cbxTowary.DataSource = null;
            }
            else if (TrybPracy == TYPE.USLUGI_EDIT)
            {
                UslugaC usluga = (UslugaC)cbxTowary.SelectedItem;


                UslugaDEF uslugaView = new UslugaDEF(UslugaDEF.TYPE.ADD);

                uslugaView.USLUGA = usluga;

                uslugaView.ShowDialog();

                if (uslugaView.CANCEL) return;

                SUMA_NETTO += usluga.Netto;
                SUMA_BRUTTO += usluga.Brutto;

                USLUGI.Add(usluga);

                cbxTowary.DisplayMember = "";
                cbxTowary.ValueMember = "";
                cbxTowary.DataSource = null;

                LoadUslugi();
            }
        }


        private void Lista_Load(object sender, EventArgs e)
        {
            if (TrybPracy == TYPE.PRODUKTY_EDIT || TrybPracy == TYPE.PRODUKTY_VIEW)
            {
                LoadProducts();

                if (TrybPracy == TYPE.PRODUKTY_VIEW)
                {
                    this.Text = "Lista produktów - podgląd";

                    cmdTowaryDodaj.Enabled = false;
                    cmdTowaryUsun.Enabled = false;
                    cbxTowary.Enabled = false;
                }
                else if (TrybPracy == TYPE.PRODUKTY_EDIT)
                    this.Text = "Lista towarów";
            }
            else if (TrybPracy == TYPE.USLUGI_EDIT || TrybPracy == TYPE.USLUGI_VIEW)
            {
                LoadUslugi();

                if (TrybPracy == TYPE.USLUGI_VIEW)
                {
                    this.Text = "Lista usług - podgląd";

                    cmdTowaryDodaj.Enabled = false;
                    cmdTowaryUsun.Enabled = false;
                    cbxTowary.Enabled = false;
                }
                else if (TrybPracy == TYPE.USLUGI_EDIT)
                    this.Text = "Lista usług";
            }
        }
    }
}
