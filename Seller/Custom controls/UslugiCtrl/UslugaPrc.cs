using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.Class;

namespace Seller.CONTROLS.UslugiCtrl
{
    public partial class UslugaPrc : Form
    {
        #region PUBLIC

        public bool CANCEL = true;

       

        public enum TYPE
        {
            NEW,
            EDIT,
            VIEW
        }

        #endregion

        #region PRIVATE

        private TYPE TrybPracy;

        private Number num = new Number();

        #endregion

        #region ACCESS

        public UslugaC USLUGA = null;

        public Worker PRACOWNIK = null;

        public int CZAS 
        {
            get 
            {
                try { return int.Parse(txtCzas.Text); }
                catch { return 0; }
            }
            set { txtCzas.Text = value.ToString(); } 
        }

        public float KOSZT 
        {
            get 
            {
                try { return float.Parse(txtKOszt.Text); }
                catch { return 0; }
            }
            set { txtKOszt.Text = value.ToString(); }
        }

        #endregion

        public UslugaPrc(TYPE tryb)
        {
            InitializeComponent();

            TrybPracy = tryb;
        }

        #region LOAD

        private void LoadNew()
        {
            this.Text = "Dodawanie usługi/naprawy";
            cmdAnuluj.Text = "Anuluj";
            cmdKioniec.Text = "Wprowadź";
 

        }

        private void LOadView()
        {
            this.Text = "Podgląd usługi/naprawy";
            cmdAnuluj.Text = "Zamknij";
            cmdKioniec.Enabled = false;
            cmdKioniec.Visible = false;


            if (USLUGA != null)
            {
                cbxUslugi.DataSource = new List<UslugaC> { USLUGA };
                cbxUslugi.DisplayMember = "USLUGA";
                cbxUslugi.ValueMember = "ID";

                cmdUslugaDodaj.Enabled = false;
                cmdUslugaFind.Enabled = false;

                CZAS = USLUGA.CZAS;


                if (USLUGA.TIME_INDEX == WorkIdx.TYPE.SELECT) txtVar.Clear();
                else txtVar.Text = WorkIdxData.workIndex[(int)(USLUGA.TIME_INDEX)].JEDNOSTKA_CZASU;

                KOSZT = USLUGA.SumaBrutto;
            }

            if (USLUGA.WID >0)
            {
                cbxPracownik.DataSource = CustomerDatabase.GetWorkers(USLUGA.WID, "", "", "", "", "");
                cbxPracownik.DisplayMember = "PRACOWNIK";

                cmdPracownikDodaj.Enabled = false;
                cmdPracownikSearch.Enabled = false;
            }


        }

        private void UslugaPrc_Load(object sender, EventArgs e)
        {
            switch (TrybPracy)
            {
                case TYPE.NEW:
                    LoadNew();
                    break;

                case TYPE.VIEW:
                    LOadView();
                    break;

            }
        }

        #endregion

        private void cmdUslugaDodaj_Click(object sender, EventArgs e)
        {
         
            UslugaDEF usluga = new UslugaDEF(UslugaDEF.TYPE.NEW);

            usluga.ShowDialog();

            if (usluga.CANCEL) return;

            int idUslugi = CustomerDatabase.NewUsluga(usluga.NUMER, usluga.NAZWA, usluga.OPIS,
                usluga.CENA_NETTO, usluga.VAT, usluga.CENA_BRUTTO,(int)usluga.TIME_IDX);


            cbxUslugi.DisplayMember = "";
            cbxUslugi.ValueMember = "";
            cbxUslugi.DataSource = null;

            List<UslugaC> lstUslugi =
                CustomerDatabase.GetUslugi(idUslugi, "", "");

            cbxUslugi.DataSource = lstUslugi;
            cbxUslugi.DisplayMember = "USLUGA";
            cbxUslugi.ValueMember = "ID";

            cbxUslugi.SelectedValue = idUslugi;

            USLUGA = (UslugaC)cbxUslugi.SelectedItem;

            if (USLUGA.TIME_INDEX == WorkIdx.TYPE.SELECT) txtVar.Clear();
            else txtVar.Text = WorkIdxData.workIndex[(int)(USLUGA.TIME_INDEX)].JEDNOSTKA_CZASU;

            Message.InfoMessage("Nowa usługa została pomyślnie wprowadzona");
        }

        private void cmdUslugaFind_Click(object sender, EventArgs e)
        {
            UslugaDEF usluga = new UslugaDEF(UslugaDEF.TYPE.FIND);

            usluga.ShowDialog();

            if (usluga.CANCEL) return;

            List<UslugaC> lstUslugi =
                CustomerDatabase.GetUslugi(-1, usluga.NUMER, usluga.NAZWA);

            if (lstUslugi == null)
            { Message.InfoMessage("Nie znaleziono"); return; }

            cbxUslugi.DisplayMember = "";
            cbxUslugi.ValueMember = "";
            cbxUslugi.DataSource = null;

            cbxUslugi.DataSource = lstUslugi;
            cbxUslugi.DisplayMember = "USLUGA";

            cbxUslugi.ValueMember = "ID";

            cbxUslugi.Text = "Wybierz z listy usług";

            Settings.ShowDropDownList(ref cbxUslugi);
        }

        private void cbxUslugi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUslugi.DisplayMember == "" || cbxUslugi.ValueMember == "") return;

            USLUGA = (UslugaC)cbxUslugi.SelectedItem;

            if (USLUGA.TIME_INDEX == WorkIdx.TYPE.SELECT) txtVar.Clear();
            else txtVar.Text = WorkIdxData.workIndex[(int)(USLUGA.TIME_INDEX)].JEDNOSTKA_CZASU;

            cbxUslugi.BackColor = Color.White;
        }

      
        private void cmdKioniec_Click(object sender, EventArgs e)
        {
            if (USLUGA == null || PRACOWNIK == null || String.IsNullOrEmpty(txtCzas.Text))
            {
                if (USLUGA == null) cbxUslugi.BackColor = Color.Yellow;
                if (PRACOWNIK == null) cbxPracownik.BackColor = Color.Yellow;

                bool result = CheckEntry.CheckEntryCtrl(new List<Control> { txtCzas });

                if (!result) Message.NotAll();

                return;
            }

            USLUGA.WID = PRACOWNIK.ID;
            USLUGA.W_NAME = cbxPracownik.Text;
            USLUGA.CZAS = CZAS;

            //KOSZT = USLUGA.Brutto = (float)Math.Round(USLUGA.Brutto * CZAS, 2);
            //USLUGA.Netto = (float)Math.Round(USLUGA.Netto * CZAS, 2);

            CANCEL = false;

            Close();
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdPracownikSearch_Click(object sender, EventArgs e)
        {
            FindWorker findWorkers = new FindWorker("Wyszukaj pracowników", "Szukaj");

            findWorkers.ShowDialog();

            if (findWorkers.CANCEL) return;

            List<Worker> workers =
                CustomerDatabase.GetWorkers(-1, findWorkers.IMIE, findWorkers.NAZWISKO,
                findWorkers.PESEL, findWorkers.NIP, findWorkers.BANK);

            if (workers == null) { Message.InfoMessage("Nie znaleziono"); return; }

            cbxPracownik.DisplayMember = "";
            cbxPracownik.ValueMember = "";
            cbxPracownik.DataSource = null;
           

            cbxPracownik.DataSource = workers;
            cbxPracownik.DisplayMember = "PRACOWNIK";
            cbxPracownik.ValueMember = "ID";

            Settings.ShowDropDownList(ref cbxPracownik);
        }

        private void cmdPracownikDodaj_Click(object sender, EventArgs e)
        {
            FindWorker newWorker = new FindWorker("Nowy pracownik", "Dodaj");

            newWorker.ShowDialog();

            if (newWorker.CANCEL) return;

            int id = CustomerDatabase.NewWorker(newWorker.IMIE, newWorker.NAZWISKO, newWorker.ADRES, newWorker.PESEL,
                newWorker.NIP, newWorker.BANK);


            List<Worker> pracownicy = CustomerDatabase.GetWorkers(id, "", "", "", "", "");

            cbxPracownik.DisplayMember = "";
            cbxPracownik.ValueMember = "";
            cbxPracownik.DataSource = null;

            cbxPracownik.DataSource = pracownicy;
            cbxPracownik.DisplayMember = "PRACOWNIK";
            cbxPracownik.ValueMember = "ID";

            cbxPracownik.SelectedValue = id;

            PRACOWNIK = (Worker)cbxPracownik.SelectedItem;

            Message.InfoMessage("Nowy pracownik został dodany");
        }

        private void cbxPracownik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPracownik.DisplayMember == "" || cbxPracownik.ValueMember == "") return;

            PRACOWNIK = (Worker)cbxPracownik.SelectedItem;

            cbxPracownik.BackColor = Color.White;
        }

        private void cbxUslugi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCzas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumber(this, e);
        }

        private void txtVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCzas_TextChanged(object sender, EventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) { KOSZT = USLUGA.Brutto; return; }

            if (USLUGA.TIME_INDEX == WorkIdx.TYPE.SELECT) KOSZT = USLUGA.Brutto;
            else
            {
                KOSZT = (float)Math.Round(USLUGA.Brutto * CZAS, 2);
               
            }
        }

      
    }
}
