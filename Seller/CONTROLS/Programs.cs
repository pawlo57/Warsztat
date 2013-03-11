using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller;

namespace Seller.CONTROLS
{
    public partial class Programs : UserControl
    {
        //private List<SellServiceData.Category> categories = new List<Seller.SellServiceData.Category>();


        public Programs()
        {
            InitializeComponent();
        }

        private void LoadCategories()
        {
            dgwProdukty.DataSource = null;

            dgwProdukty.DataSource = Settings.CATEORIES;

            SetDataGridView.SetKategorieView(ref dgwProdukty);
        }

        private void LoadProducts(int CATID, int CID, string name,string numerKat, string model,
            string numerSer)
        {

            List<Produkt> product = CustomerDatabase.GetPrograms(-1, CATID, CID, name, numerKat, model, numerSer);
            
            if (product == null) { Message.InfoMessage("Nie znaleziono"); return; }

            dgwProdukty.DataSource = product;

            SetDataGridView.SetProduktyView(ref dgwProdukty);
        }

        private void Programs_Load(object sender, EventArgs e)
        {
            //LoadCategories();
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
            { Message.ErrorMessage("Podana kategoria już istnieje"); return; }

            CustomerDatabase.NewCategory(newCat.CATEGORY);
            
            Message.InfoMessage("Nowa kategoria została dodana");

            Settings.LoadCategories();

            LoadCategories();
        }

        private void cmdEdytujKat_Click(object sender, EventArgs e)
        {
            Category selected = null;

            try { selected = (Category)dgwProdukty.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            newCategory editCat = new newCategory("Edycja kategorii", "Zmień");

            editCat.CATEGORY = selected.NAME;

            editCat.ShowDialog();

            if (editCat.CANCEL) return;

            if (CustomerDatabase.GetCategories(editCat.CATEGORY) != null)
            { Message.ErrorMessage("Podana kategoria już istnieje"); return; }

            CustomerDatabase.UpdateCategory(selected.ID, editCat.CATEGORY);
            
            Message.InfoMessage("Kategoria została zapisana");

            Settings.LoadCategories();

            LoadCategories();
        }


        private void cmdNowy_Click(object sender, EventArgs e)
        {
            FINDKind newProgram = new FINDKind(FINDKind.TYPE.NEW);

            newProgram.ShowDialog();

            if (newProgram.CANCEL) return;

            if (CustomerDatabase.CheckProgram(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL,
                newProgram.MODEL, newProgram.PRICE, newProgram.VATPRICE, newProgram.JEDNOSTKA,newProgram.PROWIZJA,
                newProgram.PRICE2,newProgram.VATPRICE2))
            { Message.ErrorMessage("Podany produkt już istnieje"); return; }

            CustomerDatabase.NewProgram(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL,
                     newProgram.NUMER_SERYJNY, newProgram.OPIS, newProgram.PRICE, newProgram.VATPRICE, newProgram.JEDNOSTKA,
                     newProgram.PROWIZJA, newProgram.PRICE2, newProgram.VATPRICE2);
           
                Message.InfoMessage("Produkt został dodany");

            LoadProducts(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL, 
                newProgram.NUMER_SERYJNY);
        }

        private void cmdEdytuj_Click(object sender, EventArgs e)
        {
            FINDKind newProgram = new FINDKind(FINDKind.TYPE.EDIT);

            Produkt product;

            try { product = (Produkt)dgwProdukty.CurrentRow.DataBoundItem; }
            catch { return; }

            newProgram.PRODUKT = product;
            
            newProgram.ShowDialog();

            if (newProgram.CANCEL) return;

            if (CustomerDatabase.CheckProgram(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL,
                newProgram.MODEL, newProgram.PRICE, newProgram.VATPRICE, newProgram.JEDNOSTKA, newProgram.PROWIZJA, newProgram.PRICE2,newProgram.VATPRICE2))
            { Message.ErrorMessage("Podany produkt już istnieje"); return; }

            CustomerDatabase.UpdateProgram(product.ID, newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU,
                 newProgram.NUMER_KATALOGOWY, newProgram.MODEL, newProgram.NUMER_SERYJNY, newProgram.OPIS, newProgram.PRICE,
                 newProgram.VATPRICE, newProgram.JEDNOSTKA, newProgram.PROWIZJA, newProgram.PRICE2, newProgram.VATPRICE2);
           
                Message.InfoMessage("Produkt został zmieniony");

            LoadProducts(newProgram.KATID, newProgram.CID, newProgram.NAZWA_TOWARU, newProgram.NUMER_KATALOGOWY, newProgram.MODEL,
                newProgram.NUMER_SERYJNY);
        }

        private void cmdListaKat_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void cmdPodglad_Click(object sender, EventArgs e)
        {
            FINDKind newProgram = new FINDKind(FINDKind.TYPE.VIEW);

            Produkt product;

            try { product = (Produkt)dgwProdukty.CurrentRow.DataBoundItem; }
            catch { return; }

            newProgram.PRODUKT = product;

            newProgram.ShowDialog();
        }
    }
}