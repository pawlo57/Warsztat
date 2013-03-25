using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller;
using Pawel.Workshop.Database.Database_model;
using Pawel.Workshop.Data_providers.Databse;
using Pawel.Workshop.Strings;
using Pawel.Workshop.Entities;

namespace Pawel.Workshop.Custom_controls.Goods
{
    public partial class Goods : UserControl
    {
        public Goods()
        {
            InitializeComponent();
        }

        public Good currentGood
        {
            get
            {
                return new Good
                {
                    ID = -1,
                    categoryID = -1,
                    catalogueNumber = textBoxCatalogueNumber.Text,
                    model = textBoxModel.Text,
                    serialNumber = textBoxSerialNumber.Text,
                    description = textBoxDescription.Text,
                    name = textBoxGoodName.Text,
                    //nettoPriceSell = this.nettoPriceSell,
                    bruttoPriceSell = this.bruttoPriceSell,
                    //nettoPriceBuy = this.nettoPriceBuy,
                    bruttoPriceBuy = this.bruttoPriceBuy,
                    vat = this.vat
                };
            }

            set
            {
                    //ID = -1,
                    //categoryID = -1,
                    textBoxCatalogueNumber.Text = value.catalogueNumber;
                    textBoxModel.Text = value.model;
                    textBoxSerialNumber.Text = value.serialNumber;
                    textBoxDescription.Text = value.description;
                    textBoxGoodName.Text = value.name;
                    this.nettoPriceSell = value.nettoPriceSell;
                    this.bruttoPriceSell = value.bruttoPriceSell;
                    this.nettoPriceBuy = value.nettoPriceBuy;
                    this.bruttoPriceBuy = value.bruttoPriceBuy;
                    this.vat = value.vat;
                
            }
        }

        private List<Categories> categories = new List<Categories>();

        private int vat
        {
            get
            {
                int result = 0;
                int.TryParse(textBoxVat.Text,out result);

                return result;
            }

            set { textBoxVat.Text = value.ToString(); }
        }
        private decimal vatMuller
        {
            get
            {
                return ((decimal)100 + vat) / 100;
            }
        }
        private decimal nettoPriceSell
        {
            get
            {
                decimal result = 0;
                decimal.TryParse(textBoxNettoPriceSell.Text, out result);

                return result;
            }

            set { textBoxNettoPriceSell.Text = value.ToString(); }
        }
        private decimal bruttoPriceSell
        {
            get
            {
                decimal result = 0;
                decimal.TryParse(textBoxBruttoPriceSell.Text, out result);

                return result;
            }

            set { textBoxBruttoPriceSell.Text = value.ToString(); }
        }
        private decimal nettoPriceBuy
        {
            get
            {
                decimal result = 0;
                decimal.TryParse(textBoxNettoPriceBuy.Text, out result);

                return result;
            }

            set { textBoxNettoPriceBuy.Text = value.ToString(); }
        }
        private decimal bruttoPriceBuy
        {
            get
            {
                decimal result = 0;
                decimal.TryParse(textBoxBruttoPriceBuy.Text, out result);

                return result;
            }

            set { textBoxBruttoPriceBuy.Text = value.ToString(); }
        }


        private void loadCategories()
        {
            categories.Add(new Categories { ID = -1, CATEGORY = strings.All });
            categories.AddRange(DatabaseDataProvider.getCategories());

            categoriesBindingSource.DataSource = categories;
        }

        private void LoadProducts(int CATID, int CID, string name,string numerKat, string model,
            string numerSer)
        {
            List<Produkt> product = CustomerDatabase.GetPrograms(-1, CATID, CID, name, numerKat, model, numerSer);

            if (product == null) { Seller.Message.InfoMessage("Nie znaleziono"); return; }

            dataGridViewGoods.DataSource = product;

            SetDataGridView.SetProduktyView(ref dataGridViewGoods);
        }

        private void Programs_Load(object sender, EventArgs e)
        {
            loadCategories();

            newCurrentGood();

            goodBindingSource.DataSource = DatabaseDataProvider.getGoodsByGood();
        }

        private void newCurrentGood()
        {
            this.currentGood = new Good { bruttoPriceSell = 2.23M, vat = 23, bruttoPriceBuy = 0 };
        }

        private void cmdSzukaj_Click(object sender, EventArgs e)
        {
            FINDKind products = new FINDKind(FINDKind.TYPE.FIND);

            products.ShowDialog();

            if (products.CANCEL) return;

            LoadProducts(products.KATID, products.CID, products.NAZWA_TOWARU, 
                products.NUMER_KATALOGOWY, products.MODEL, products.NUMER_SERYJNY);
        }

        private void cmdNowaKat_Click(object sender, EventArgs e)
        {
            newCategory newCat = new newCategory("Nowa kategoria", "Dodaj");

            newCat.ShowDialog();

            if (newCat.CANCEL) return;

            if (CustomerDatabase.GetCategories(newCat.CATEGORY) != null)
            { Seller.Message.ErrorMessage("Podana kategoria już istnieje"); return; }

            CustomerDatabase.NewCategory(newCat.CATEGORY);

            Seller.Message.InfoMessage("Nowa kategoria została dodana");

            Settings.LoadCategories();

            //LoadCategories();
        }

        private void cmdEdytujKat_Click(object sender, EventArgs e)
        {
            Category selected = null;

            try { selected = (Category)dataGridViewGoods.CurrentRow.DataBoundItem; }
            catch { Seller.Message.Position(); return; }

            newCategory editCat = new newCategory("Edycja kategorii", "Zmień");

            editCat.CATEGORY = selected.NAME;

            editCat.ShowDialog();

            if (editCat.CANCEL) return;

            if (CustomerDatabase.GetCategories(editCat.CATEGORY) != null)
            { Seller.Message.ErrorMessage("Podana kategoria już istnieje"); return; }

            CustomerDatabase.UpdateCategory(selected.ID, editCat.CATEGORY);
            
            Seller.Message.InfoMessage("Kategoria została zapisana");

            Settings.LoadCategories();

            //LoadCategories();
        }


        private void cmdNowy_Click(object sender, EventArgs e)
        {
            FINDKind newProgram = new FINDKind(FINDKind.TYPE.NEW);

            newProgram.ShowDialog();

            if (newProgram.CANCEL) return;

            if (CustomerDatabase.CheckProgram(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL,
                newProgram.MODEL, newProgram.PRICE, newProgram.VATPRICE, newProgram.JEDNOSTKA,newProgram.PROWIZJA,
                newProgram.PRICE2,newProgram.VATPRICE2))
            { Seller.Message.ErrorMessage("Podany produkt już istnieje"); return; }

            CustomerDatabase.NewProgram(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL,
                     newProgram.NUMER_SERYJNY, newProgram.OPIS, newProgram.PRICE, newProgram.VATPRICE, newProgram.JEDNOSTKA,
                     newProgram.PROWIZJA, newProgram.PRICE2, newProgram.VATPRICE2);

            Seller.Message.InfoMessage("Produkt został dodany");

            LoadProducts(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL, 
                newProgram.NUMER_SERYJNY);
        }

        private void cmdEdytuj_Click(object sender, EventArgs e)
        {
            FINDKind newProgram = new FINDKind(FINDKind.TYPE.EDIT);

            Produkt product;

            try { product = (Produkt)dataGridViewGoods.CurrentRow.DataBoundItem; }
            catch { return; }

            newProgram.PRODUKT = product;
            
            newProgram.ShowDialog();

            if (newProgram.CANCEL) return;

            if (CustomerDatabase.CheckProgram(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL,
                newProgram.MODEL, newProgram.PRICE, newProgram.VATPRICE, newProgram.JEDNOSTKA, newProgram.PROWIZJA, newProgram.PRICE2,newProgram.VATPRICE2))
            { Seller.Message.ErrorMessage("Podany produkt już istnieje"); return; }

            CustomerDatabase.UpdateProgram(product.ID, newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU,
                 newProgram.NUMER_KATALOGOWY, newProgram.MODEL, newProgram.NUMER_SERYJNY, newProgram.OPIS, newProgram.PRICE,
                 newProgram.VATPRICE, newProgram.JEDNOSTKA, newProgram.PROWIZJA, newProgram.PRICE2, newProgram.VATPRICE2);

            Seller.Message.InfoMessage("Produkt został zmieniony");

            LoadProducts(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL,
                newProgram.NUMER_SERYJNY);
        }

        private void cmdListaKat_Click(object sender, EventArgs e)
        {
            //LoadCategories();
        }

        private void cmdPodglad_Click(object sender, EventArgs e)
        {
            FINDKind newProgram = new FINDKind(FINDKind.TYPE.VIEW);

            Produkt product;

            try { product = (Produkt)dataGridViewGoods.CurrentRow.DataBoundItem; }
            catch { return; }

            newProgram.PRODUKT = product;

            newProgram.ShowDialog();
        }


        private void textBoxNettoPriceSell_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxNettoPriceSell.Focused)
            {
                return;
            }
            bruttoPriceSell = currentGood.bruttoPriceSell;
        }

        private void textBoxBruttoPriceSell_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxBruttoPriceSell.Focused)
            {
                return;
            }
            nettoPriceSell = currentGood.nettoPriceSell;
        }

        private void textBoxNettoPriceBuy_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxNettoPriceBuy.Focused)
            {
                return;
            }
            bruttoPriceBuy = currentGood.bruttoPriceBuy;

        }

        private void textBoxBruttoPriceBuy_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxBruttoPriceBuy.Focused)
            {
                return;
            }
            nettoPriceBuy = currentGood.nettoPriceBuy;
        }
    }
}