using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.CONTROLS;
using System.Diagnostics;
using System.IO;
using Seller.CONTROLS.SaveCopy;

namespace Seller
{
    public partial class Form1 : Form
    {
        private Programs programs = new Programs();
        private Workers workers = new Workers();
        private Customers Customers = new Customers();
        private Magaz magazyn = new Magaz();
        private Faktury faktury = new Faktury();
        private Welcome welcome = new Welcome();
        private Uslugi uslugi = new Uslugi();
        private FakturyTrue fakturyTrue = new FakturyTrue();

        private ToolStripButton SelectedButton = null;

        private Color SelectedButtonColor = Color.LightBlue;

        private Transactions transactions = new Transactions();

        public Form1()
        {
            InitializeComponent();

            SetUpControls();

            //Connect.Upgrade();
            //RSA.Test();
        }

        private void SetUpControls()
        {
            programs.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;

            workers.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;

            Customers.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;

            transactions.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;

            magazyn.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;

            faktury.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;

            welcome.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;

            uslugi.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;

            fakturyTrue.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
        }

        private void SetColor(ToolStripButton control, Color color)
        {
            if (SelectedButton != null) SelectedButton.BackColor = Color.Transparent;

            control.BackColor = color;

            SelectedButton = control;
        }

        private void SetName(string name)
        {
            this.Text = Settings.Nazwa_Programu + " - [" + name + "]";
        }

        private void tsbProdukty_Click(object sender, EventArgs e)
        {
            if (((USER.User.PRIV & (1 << (int)USER.PRIV.PRODUKTY)) != (1 << (int)USER.PRIV.PRODUKTY)))
            { Message.PrivError(); return; }


            SetColor(tsbProdukty, SelectedButtonColor);

            MainPanel.Controls.Clear();

            programs.Width = MainPanel.Width;
            programs.Height = MainPanel.Height;

            MainPanel.Controls.Add(programs);

            SetName("Produkty");
        }

        private void tsbPracownicy_Click(object sender, EventArgs e)
        {
            if (((USER.User.PRIV & (1 << (int)USER.PRIV.PRACOWNICY)) != (1 << (int)USER.PRIV.PRACOWNICY)))
            { Message.PrivError(); return; }


            SetColor(tsbPracownicy, SelectedButtonColor);


            MainPanel.Controls.Clear();

            workers.Width = MainPanel.Width;
            workers.Height = MainPanel.Height;

            MainPanel.Controls.Add(workers);

            SetName("Pracownicy");
        }

        private void tsbKontrahenci_Click(object sender, EventArgs e)
        {
            if (((USER.User.PRIV & (1 << (int)USER.PRIV.KONTRAHENCI)) != (1 << (int)USER.PRIV.KONTRAHENCI)))
            { Message.PrivError(); return; }

            SetColor(tsbKontrahenci, SelectedButtonColor);

            MainPanel.Controls.Clear();

            Customers.Width = MainPanel.Width;
            Customers.Height = MainPanel.Height;

            MainPanel.Controls.Add(Customers);

            SetName("Kontrahenci");
        }

        private void tsbInvoices_Click(object sender, EventArgs e)
        {
            if (((USER.User.PRIV & (1 << (int)USER.PRIV.TRANSAKCJE)) != (1 << (int)USER.PRIV.TRANSAKCJE)))
            { Message.PrivError(); return; }

            SetColor(tsbInvoices, SelectedButtonColor);

            MainPanel.Controls.Clear();

            transactions.Width = MainPanel.Width;
            transactions.Height = MainPanel.Height;

            MainPanel.Controls.Add(transactions);

            SetName("Zlecenia/naprawy");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            informacjeOProgramieToolStripMenuItem_Click(this, e);

            if (!Aktuwuj()) { Close(); return; }


            USER.LoadUsers();

            if (!USER.LoginUser()) { Close(); return; }

            SetName("Zalogowany: " + USER.User.IMIE + " " + USER.User.NAZWISKO);

            if (!Settings.LoadSettings())
            {
                Ustawiania ustawienia = new Ustawiania();

                ustawienia.ShowDialog();

                if (ustawienia.CANCEL) { Message.ErrorMessage("Nie wprowadzono koniecznych ustawień"); Close(); return; }
            }
            else
            {
                this.Location = new Point(Settings.X, Settings.Y);
                this.Size = new Size(Settings.WITH, Settings.HEGIHT);

            }

           
            Settings.LoadCategories();

            Settings.LoadMagazyny();

            LoadPriviliges();
           
        }

        private void LoadPriviliges()
        {
            bool ResultSet = true;

            if (((USER.User.PRIV & (1 << (int)USER.PRIV.UZYTKOWNICY))
                != (1 << (int)USER.PRIV.UZYTKOWNICY))) ResultSet = false;
            
                bazaDanychToolStripMenuItem.Enabled = ResultSet;
                ustawieniaToolStripMenuItem.Enabled = ResultSet;
                użytkownicyToolStripMenuItem.Enabled = ResultSet;
          
        }



        private bool Aktuwuj()
        {
            Aktywacja aktywacja = new Aktywacja();

            return aktywacja.ReadRegisty();
        }

        private void tsbMagazyn_Click(object sender, EventArgs e)
        {
            if (((USER.User.PRIV & (1 << (int)USER.PRIV.MAGAZYN)) != (1 << (int)USER.PRIV.MAGAZYN)))
            { Message.PrivError(); return; }

            SetColor(tsbMagazyn, SelectedButtonColor);

            MainPanel.Controls.Clear();

            magazyn.Width = MainPanel.Width;
            magazyn.Height = MainPanel.Height;

            MainPanel.Controls.Add(magazyn);

            SetName("Magazyn");
        }

        private void tsbFaktury_Click(object sender, EventArgs e)
        {
            if (((USER.User.PRIV & (1 << (int)USER.PRIV.FAKTURY)) != (1 << (int)USER.PRIV.FAKTURY)))
            { Message.PrivError(); return; }

            SetColor(tsbFaktury, SelectedButtonColor);

            MainPanel.Controls.Clear();

            faktury.Width = MainPanel.Width;
            faktury.Height = MainPanel.Height;

            MainPanel.Controls.Add(faktury);

            SetName("Baza pojazdów");
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Message.EndMessage()) Close();
        }

        private void bazaUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((USER.User.PRIV & (1 << (int)USER.PRIV.UZYTKOWNICY)) != (1 << (int)USER.PRIV.UZYTKOWNICY)))
            { Message.PrivError(); return; }

            Uzytkownicy uzytkownicy = new Uzytkownicy();

            uzytkownicy.ShowDialog();
        }

        private void ustawieniaProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((USER.User.PRIV & (1 << (int)USER.PRIV.UZYTKOWNICY)) != (1 << (int)USER.PRIV.UZYTKOWNICY)))
            { Message.PrivError(); return; }
            
            Ustawiania ustawienia = new Ustawiania();

            ustawienia.ShowDialog();

            if (ustawienia.CANCEL) return;
        }

        private void produktyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbProdukty_Click(this, e);
        }

        private void magazynToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbMagazyn_Click(this, e);
        }

        private void pracownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbPracownicy_Click(this, e);
        }

        private void kontrahenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbKontrahenci_Click(this, e);
        }

        private void transakcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbInvoices_Click(this, e);
        }

        private void fakturyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbFaktury_Click(this, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.WriteSize(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

            SaveCopyFrm saveCopy = new SaveCopyFrm(SaveCopyFrm.TYPE.DEFAULT);

            saveCopy.ShowDialog();
        }

        private void zalogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!USER.LoginUser()) { Close(); return; }

            SetName("Zalogowany: " + USER.User.IMIE + " " + USER.User.NAZWISKO);

            informacjeOProgramieToolStripMenuItem_Click(this, e);

            LoadPriviliges();
        }

        private void informacjeOProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedButton != null) SelectedButton.BackColor = Color.Transparent;

            MainPanel.Controls.Clear();

            welcome.Width = MainPanel.Width;
            welcome.Height = MainPanel.Height;

            MainPanel.Controls.Add(welcome);
        }

        private void tsbUslugi_Click(object sender, EventArgs e)
        {
            if (((USER.User.PRIV & (1 << (int)USER.PRIV.USŁUGI)) != (1 << (int)USER.PRIV.USŁUGI)))
            { Message.PrivError(); return; }

            MainPanel.Controls.Clear();

            uslugi.Width = MainPanel.Width;
            uslugi.Height = MainPanel.Height;

            MainPanel.Controls.Add(uslugi);

            SetColor(tsbUslugi, SelectedButtonColor);

            SetName("Usługi");
        }

        private void pomocToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Process.Start(Directory.GetCurrentDirectory() + "//warsztat_pomoc.pdf");
        }

        private void kopiaZapasowaBazyDanychFolderDomyślnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCopyFrm saveCopy = new SaveCopyFrm(SaveCopyFrm.TYPE.DEFAULT);

            saveCopy.ShowDialog();

            if (!saveCopy.RESULT) return;

            Message.InfoMessage("Wykonano kopię zapasową bazy danych do domyślnego folderu");
        }

        private void kopiaZapasowaBazyDanychWybranaLokalizacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCopyFrm saveCopy = new SaveCopyFrm(SaveCopyFrm.TYPE.DIR);

            saveCopy.ShowDialog();

            if (!saveCopy.RESULT) return;

            Message.InfoMessage("Baza danych została skopiowana pomyślnie");
        }

        private void importujBazęDanychFolderDomyślnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Message.AskMessage("Czy napewno importować bazę danych?\n" +
                "Wszystkie dane wprowadzone od momentu uruchomienia programu zostaną utranone!")) return;

            SaveCopyFrm restoreCopy = new SaveCopyFrm(SaveCopyFrm.TYPE.DEFAULT_RESTORE);

            restoreCopy.ShowDialog();

            if (restoreCopy.RESULT == false) return;

            Message.InfoMessage("Baza danych została importowana pomyślnie");

            zalogujToolStripMenuItem_Click(this, e);
        }

        private void importBazyDanychWybranaLokalizacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Message.AskMessage("Czy napewno importować bazę danych?\n" +
                "Wszystkie dane wprowadzone od momentu uruchomienia programu zostaną utracone!")) return;

            SaveCopyFrm saveCopy = new SaveCopyFrm(SaveCopyFrm.TYPE.DEFAULT);

            saveCopy.ShowDialog();

            saveCopy.Dispose();

            SaveCopyFrm restoreCopy = new SaveCopyFrm(SaveCopyFrm.TYPE.DIR_RESTORE);

            restoreCopy.ShowDialog();

            if (restoreCopy.RESULT == false) return;

            Message.InfoMessage("Baza danych została importowana pomyślnie");

            zalogujToolStripMenuItem_Click(this, e);
        }

        private void tsbFakturyTrue_Click(object sender, EventArgs e)
        {
            //if (((USER.User.PRIV & (1 << (int)USER.PRIV.PRODUKTY)) != (1 << (int)USER.PRIV.PRODUKTY)))
            //{ Message.PrivError(); return; }

            SetColor(tsbFakturyTrue, SelectedButtonColor);

            MainPanel.Controls.Clear();

            fakturyTrue.Width = MainPanel.Width;
            fakturyTrue.Height = MainPanel.Height;

            MainPanel.Controls.Add(fakturyTrue);

            SetName("Faktury");
        }

      

       

      
    }
}
