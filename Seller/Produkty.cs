using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seller
{
    public partial class Produkty : Form
    {
        public bool CANCEL = true;

        public List<Produkt> PRODUKTY = new List<Produkt>();

        public float SUM = 0;

        public float VATSUM = 0;

        public Produkty()
        {
            InitializeComponent();
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            PRODUKTY = null;

            Close();
        }

        private void CalculateSum()
        {
            for (int i = 0; i < PRODUKTY.Count; i++)
            {
                SUM += PRODUKTY[i].PRICE;
                VATSUM += PRODUKTY[i].VATPRICE;
            }
        }

        private void cmdWprowadz_Click(object sender, EventArgs e)
        {
            if (PRODUKTY.Count == 0) { Message.ErrorMessage("Lista produktów jest pusta"); return; }

            CalculateSum();

            CANCEL = false;
            Close();
        }

        private void LoadProducts()
        {
            dgvProdukty.DataSource = null;

            dgvProdukty.DataSource = PRODUKTY;

            
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            //Selectt selectProduct = new Selectt("Wybierz produkt", "Wybierz", -1);

            //selectProduct.ShowDialog();

            //if (selectProduct.CANCEL) return;

            //PRODUKTY.Add(selectProduct.PRODUCT);

            //LoadProducts();
        }

        private void cmdUsun_Click(object sender, EventArgs e)
        {

            Produkt SelectedProdukt = null;

            try { SelectedProdukt = (Produkt)dgvProdukty.CurrentRow.DataBoundItem; }
            catch { return; }

            dgvProdukty.DataSource = null;

            PRODUKTY.Remove(SelectedProdukt);

            LoadProducts();
        }

        private void Produkty_Load(object sender, EventArgs e)
        {
            if (PRODUKTY != null) LoadProducts();
        }
    }
}
