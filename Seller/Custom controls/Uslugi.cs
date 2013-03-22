using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.Class;

namespace Seller.CONTROLS
{
    public partial class Uslugi : UserControl
    {
        public Uslugi()
        {
            InitializeComponent();
        }

        private void cmdNowy_Click(object sender, EventArgs e)
        {
            UslugaDEF usluga = new UslugaDEF(UslugaDEF.TYPE.NEW);

            usluga.ShowDialog();

            if (usluga.CANCEL) return;

            int id = CustomerDatabase.NewUsluga(usluga.NUMER, usluga.NAZWA, usluga.OPIS,
                 usluga.CENA_NETTO, usluga.VAT, usluga.CENA_BRUTTO, (int)usluga.TIME_IDX);

            LoadUslugi(id, "", "");

            Message.InfoMessage("Nowa usługa została pomyślnie wprowadzona");
        }

        private void cmdSzukaj_Click(object sender, EventArgs e)
        {
            UslugaDEF usluga = new UslugaDEF(UslugaDEF.TYPE.FIND);

            usluga.ShowDialog();

            if (usluga.CANCEL) return;

            LoadUslugi(-1, usluga.NUMER, usluga.NAZWA);


        }

        private void LoadUslugi(int ID, string Numer, string Nazwa)
        {


            List<UslugaC> lstUslugi =
                CustomerDatabase.GetUslugi(ID, Numer, Nazwa);

            if (lstUslugi == null)
            { Message.InfoMessage("Nie znaleziono"); return; }

            dgwUslugi.DataSource = null;

            dgwUslugi.DataSource = lstUslugi;

            SetDataGridView.SetUslugiView(ref dgwUslugi);

         
        }

        private void cmdView_Click(object sender, EventArgs e)
        {
            UslugaC selected = null;

            try { selected = (UslugaC)dgwUslugi.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            UslugaDEF usluga = new UslugaDEF(UslugaDEF.TYPE.VIEW);

            usluga.USLUGA = selected;

            usluga.ShowDialog();
        }

        private void cmdEdytuj_Click(object sender, EventArgs e)
        {
            UslugaC selected = null;

            try { selected = (UslugaC)dgwUslugi.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            UslugaDEF usluga = new UslugaDEF(UslugaDEF.TYPE.EDIT);

            usluga.USLUGA = selected;

            usluga.ShowDialog();

            if (usluga.CANCEL) return;

            CustomerDatabase.UpdateUsluga(selected.ID, usluga.NUMER, usluga.NAZWA,
                usluga.OPIS, usluga.CENA_NETTO, usluga.VAT,
                usluga.CENA_BRUTTO,(int)usluga.TIME_IDX);

            Message.InfoMessage("Usługa została zapisana");

            LoadUslugi(selected.ID, "", "");
        }
    }
}
