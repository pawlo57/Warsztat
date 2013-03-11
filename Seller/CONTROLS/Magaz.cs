using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seller.CONTROLS
{
    public partial class Magaz : UserControl
    {
        private enum TRYB
        {
            NONE,
            MAGAZYN,
            PZWZ,
            LISTA_MAGAZYNOW
        }

        private TRYB Tryb = TRYB.NONE;

        private List<Produkt> PRODUKTY = new List<Produkt>();


        public Magaz()
        {
            InitializeComponent();
        }

        private void cmdPz_Click(object sender, EventArgs e)
        {
            Pz pz = new Pz(0);

            pz.ShowDialog();

            if (pz.CANCEL) return;

            ProcessTowar(pz);
            
        }

        private void ProcessTowar(Pz pz)
        {
           
                int newRowID = CustomerDatabase.NewPzWz(USER.User.ID, pz.CID, pz.MID, pz.TYP_DOKUMENTU, pz.DATA, pz.SUMA);

                if (newRowID < 0) { Message.ErrorMessage("Błąd dodawania danych do bazy"); return; }

                CustomerDatabase.NewPzWzItems(newRowID, pz.PRODUKTY.ToArray());

                if (pz.TYP_DOKUMENTU == 0) CustomerDatabase.NewTowarToMagazyn(pz.PRODUKTY);
                else if (pz.TYP_DOKUMENTU == 1) CustomerDatabase.RemoveTowarFromMagazyn(pz.PRODUKTY);

                ProcessResult(ErrorCode.CODE.SUCCES, pz.TYP_DOKUMENTU);

            

            //else if (pz.TYPE == 2)
            //{
            //    int newRowID = CustomerDatabase.NewPzWz(USER.User.ID, pz.MIDII, pz.MID, pz.TYPE, pz.DATA, pz.SUMA);

            //    if (newRowID < 0) { Message.ErrorMessage("Błąd dodawania danych do bazy"); return; }

            //    CustomerDatabase.NewPzWzItems(newRowID, pz.PRODUKTY.ToArray());

            //    CustomerDatabase.RemoveTowarFromMagazyn(pz.PRODUKTY);

            //    for (int i = 0; i < pz.PRODUKTY.Count; i++)
            //    { pz.PRODUKTY[i].MID = pz.MIDII; }

            //    CustomerDatabase.NewTowarToMagazyn(pz.PRODUKTY);

            //    ProcessResult(ErrorCode.CODE.SUCCES, pz.TYPE);

            //}

           
        }

       

        private void cmdMagazyny_Click(object sender, EventArgs e)
        {
            dgwMagazyn.DataSource = null;

            dgwMagazyn.DataSource = Settings.MAGAZYNY;

            SetDataGridView.SetMagazynyView(ref dgwMagazyn);
        }

        private void LoadPzWz(int UID, int CID, int MIDI, int MIDII, int TYPE, string DATA_FROM, string DATA_TO)
        {
            List<Produkt> pzwzs = CustomerDatabase.GetPzWz(UID, CID, MIDI, MIDII, TYPE, DATA_FROM, DATA_TO);

            if (pzwzs == null) { Message.NotFound(); return; }

            dgwMagazyn.DataSource = null;

            dgwMagazyn.DataSource = pzwzs;

            SetDataGridView.SetPzWzView(ref dgwMagazyn);

        }

        private void cmdSzukaj_Click(object sender, EventArgs e)
        {
            fPz fpz = new fPz();

            fpz.ShowDialog();

            if (fpz.CANCEL) return;

            LoadPzWz(fpz.UID, fpz.CID, fpz.MIDI, -1, fpz.TYPE, fpz.DATA_FROM, fpz.DATA_TO);

            Tryb = TRYB.PZWZ;

        }

       

        private void ProcessResult(ErrorCode.CODE Result, int TYPE)
        {
            if (Result == ErrorCode.CODE.SUCCES && TYPE == 0)
                Message.InfoMessage("Przyjęcie towaru zakończone pomyślnie");
            else if (Result == ErrorCode.CODE.SUCCES && TYPE == 1)
                Message.InfoMessage("Wydanie towaru zakończone pomyślnie");
            else if (Result == ErrorCode.CODE.SUCCES && TYPE == 2)
                Message.InfoMessage("Przesunięcie magazynowe zakończone pomyślnie");
        }

        private void cmdWZ_Click(object sender, EventArgs e)
        {
            Pz pz = new Pz(Pz.TYPE.WZ);

            pz.ShowDialog();

            if (pz.CANCEL) return;

            ProcessTowar(pz);
        }

        private void cmdPodgladPzWz_Click(object sender, EventArgs e)
        {
            if (Tryb != TRYB.PZWZ) { Message.InfoMessage("Proszę wyszukać dokument PZ lub WZ"); return; }

            Produkt selectedPzWz;

            try { selectedPzWz = (Produkt)dgwMagazyn.CurrentRow.DataBoundItem; }
            catch {  Message.Position(); return; }


            Pz viewPzWz = new Pz(Pz.TYPE.VIEW);

            viewPzWz.SELECTED = selectedPzWz;

            viewPzWz.ShowDialog();
        }

        private void cmdNowyMagazyn_Click(object sender, EventArgs e)
        {
            Magazyny magazyn = new Magazyny();

            magazyn.ShowDialog();

            if (magazyn.CANCEL) return;

            CustomerDatabase.NewMagazyn(magazyn.MAGAZYN, magazyn.ADRES);

            Settings.LoadMagazyny();

            dgwMagazyn.Refresh();
            //cbxMagazyn.Refresh();

            Message.InfoMessage("Nowy magazyn został dodany");
        }

        private void cmdEdycjaMagazynu_Click(object sender, EventArgs e)
        {
            Mgzyn magazyn = null;

            try { magazyn = (Mgzyn)dgwMagazyn.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            Magazyny editMagazyn = new Magazyny();

            editMagazyn.MAGAZYN = magazyn.MAGAZYN;
            editMagazyn.ADRES = magazyn.ADRES;

            editMagazyn.ShowDialog();

            if (editMagazyn.CANCEL) return;

            CustomerDatabase.UpdateMagazyn(magazyn.ID, editMagazyn.MAGAZYN, editMagazyn.ADRES);

            Settings.LoadMagazyny();

            dgwMagazyn.Refresh();

            Message.InfoMessage("Zaktualizowano dane magazynu");
        }

        private void cmdMagazynSzukaj_Click(object sender, EventArgs e)
        {
            FINDKind szukajTowar = new FINDKind(FINDKind.TYPE.MAGAZYN_FIND);

            szukajTowar.ShowDialog();

            if (szukajTowar.CANCEL) return;

            List<Produkt> produkty = CustomerDatabase.GetTowarFromMagazyn(szukajTowar.CID, szukajTowar.KATID, -1,
                szukajTowar.MID, szukajTowar.NAZWA_TOWARU,
                szukajTowar.NUMER_KATALOGOWY, szukajTowar.MODEL, szukajTowar.NUMER_SERYJNY);


            if (produkty == null) { Message.NotFound(); return; }


            PRODUKTY.Clear();

            PRODUKTY.AddRange(produkty);

            LoadProducts();

            Tryb = TRYB.MAGAZYN;
        }

      

        private void LoadProducts()
        {
            dgwMagazyn.DataSource = null;

            dgwMagazyn.DataSource = PRODUKTY;

            SetDataGridView.SetTowaryView(ref dgwMagazyn);
        }

        //private void LoadMagazynyCombo()
        //{
        //    cbxMagazyn.DataSource = null;

        //    cbxMagazyn.DataSource = Settings.MAGAZYNY;

        //    cbxMagazyn.DisplayMember = "MAGAZYN";

        //    cbxMagazyn.ValueMember = "ID";
        //}

        private void cbxMagazyn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Magaz_Load(object sender, EventArgs e)
        {
            //LoadMagazynyCombo();   
        }

        private void cmdMagazynPodglad_Click(object sender, EventArgs e)
        {
            if (Tryb != TRYB.MAGAZYN) { Message.InfoMessage("Proszę wcześniej wyszukać towar"); return; }

            Produkt produkt = null;

            try { produkt = (Produkt)dgwMagazyn.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            FINDKind viewTowar = new FINDKind(FINDKind.TYPE.MAGAZYN_VIEW);

            viewTowar.PRODUKT = produkt;

            viewTowar.ShowDialog();
        }
    }
}
