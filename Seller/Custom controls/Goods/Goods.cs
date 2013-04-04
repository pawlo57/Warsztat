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
using Pawel.Workshop.Properties;

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
                    Id = -1,
                    categoryID = comboBoxCategories.value,
                    catalogueNumber = textBoxCatalogueNumber.Text,
                    model = textBoxModel.Text,
                    serialNumber = textBoxSerialNumber.Text,
                    description = textBoxDescription.Text,
                    name = textBoxGoodName.Text,
                    unit = textBoxUnit.Text,
                    nettoPriceSell = textBoxNettoPriceSell.value,
                    bruttoPriceSell = textBoxBruttoPriceSell.value,
                    nettoPriceBuy = textBoxNettoPriceBuy.value,
                    bruttoPriceBuy = textBoxBruttoPriceBuy.value,
                    vat = textBoxVat.value
                };
            }

            set
            {
                    //ID = -1,
                comboBoxCategories.value = value.categoryID;
                textBoxCatalogueNumber.Text = value.catalogueNumber;
                textBoxModel.Text = value.model;
                textBoxSerialNumber.Text = value.serialNumber;
                textBoxDescription.Text = value.description;
                textBoxGoodName.Text = value.name;
                textBoxUnit.Text = value.unit;
                kontrahent = value.kontrahent;
                textBoxNettoPriceSell.value = value.nettoPriceSell;
                textBoxBruttoPriceSell.value = value.bruttoPriceSell;
                textBoxNettoPriceBuy.value = value.nettoPriceBuy;
                textBoxBruttoPriceBuy.value = value.bruttoPriceBuy;
                textBoxVat.value = value.vat;
            }
        }

        private Kontrahent kontrahent
        {
            get
            {
                return null;
            }

            set
            {
                textBoxKontrahent.Text = value.ToString();
            }
        }


        private List<Categories> categories = new List<Categories>();

        private void loadCategories()
        {
            categories.Add(new Categories { ID = -1, CATEGORY = strings.All });
            categories.AddRange(DatabaseDataProvider.getCategories());

            categoriesBindingSource.DataSource = categories;
        }

        private void loadGoods()
        {
            List<Good> goodList = DatabaseDataProvider.getGoodsByGood(currentGood);

            if (goodList == null) { Seller.Message.InfoMessage("Nie znaleziono"); return; }

            goodBindingSource.DataSource = goodList;
        }

        private void Programs_Load(object sender, EventArgs e)
        {
            loadCategories();
            newCurrentGood();
            loadGoods();
        }

        private void newCurrentGood()
        {
            this.currentGood = new Good { bruttoPriceSell = 0, vat = AppSettings.Default.Vat, bruttoPriceBuy = 0, kontrahent = new Kontrahent { Id = -1 } };
        }

        private void loadSelectedGood()
        {
            Good good = (Good)goodBindingSource.Current;
            this.currentGood = good;
        }

        private void cmdSzukaj_Click(object sender, EventArgs e)
        {
            FINDKind products = new FINDKind(FINDKind.TYPE.FIND);

            products.ShowDialog();

            if (products.CANCEL) return;

            //LoadProducts(products.KATID, products.CID, products.NAZWA_TOWARU, 
            //    products.NUMER_KATALOGOWY, products.MODEL, products.NUMER_SERYJNY);
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

            //LoadProducts(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL, 
            //    newProgram.NUMER_SERYJNY);
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

            //LoadProducts(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL,
            //    newProgram.NUMER_SERYJNY);
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
            textBoxBruttoPriceSell.value = currentGood.bruttoPriceSell;
        }

        private void textBoxBruttoPriceSell_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxBruttoPriceSell.Focused)
            {
                return;
            }
            textBoxNettoPriceSell.value = currentGood.nettoPriceSell;
        }

        private void textBoxNettoPriceBuy_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxNettoPriceBuy.Focused)
            {
                return;
            }
            textBoxBruttoPriceBuy.value = currentGood.bruttoPriceBuy;

        }

        private void textBoxBruttoPriceBuy_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxBruttoPriceBuy.Focused)
            {
                return;
            }
            textBoxNettoPriceBuy.value = currentGood.nettoPriceBuy;
        }

        private void textBoxVat_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxVat.Focused)
            {
                return;
            }
            textBoxNettoPriceSell.value = currentGood.nettoPriceSell;
            textBoxNettoPriceBuy.value = currentGood.nettoPriceBuy;
        }

        private void toolStripButtonNewGood_Click(object sender, EventArgs e)
        {
            newCurrentGood();
            loadGoods();
        }

        private void textBoxGoodName_TextChanged(object sender, EventArgs e)
        {
            loadGoods();
        }

        private void toolStripButtonOpenGood_Click(object sender, EventArgs e)
        {
            loadSelectedGood();
        }

        private void dataGridViewGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            loadSelectedGood();
        }
    }
}