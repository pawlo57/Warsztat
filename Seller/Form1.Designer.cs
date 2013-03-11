namespace Seller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zalogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazynToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrahenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transakcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakturyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.użytkownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaUżytkownikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiaZapasowaBazyDanychFolderDomyślnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiaZapasowaBazyDanychWybranaLokalizacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.importujBazęDanychFolderDomyślnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importBazyDanychWybranaLokalizacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.informacjeOProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbProdukty = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUslugi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMagazyn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPracownicy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbKontrahenci = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInvoices = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFaktury = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFakturyTrue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.kategorieToolStripMenuItem,
            this.użytkownicyToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.bazaDanychToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zalogujToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zalogujToolStripMenuItem
            // 
            this.zalogujToolStripMenuItem.Name = "zalogujToolStripMenuItem";
            this.zalogujToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zalogujToolStripMenuItem.Text = "Wyloguj";
            this.zalogujToolStripMenuItem.ToolTipText = "Wylogowanie obecnego użytkownika";
            this.zalogujToolStripMenuItem.Click += new System.EventHandler(this.zalogujToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.ToolTipText = "Koniec programu";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // kategorieToolStripMenuItem
            // 
            this.kategorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produktyToolStripMenuItem,
            this.magazynToolStripMenuItem,
            this.pracownicyToolStripMenuItem,
            this.kontrahenciToolStripMenuItem,
            this.transakcjeToolStripMenuItem,
            this.fakturyToolStripMenuItem});
            this.kategorieToolStripMenuItem.Name = "kategorieToolStripMenuItem";
            this.kategorieToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.kategorieToolStripMenuItem.Text = "Kategorie";
            // 
            // produktyToolStripMenuItem
            // 
            this.produktyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produktyToolStripMenuItem.Image")));
            this.produktyToolStripMenuItem.Name = "produktyToolStripMenuItem";
            this.produktyToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.produktyToolStripMenuItem.Text = "Części";
            this.produktyToolStripMenuItem.Click += new System.EventHandler(this.produktyToolStripMenuItem_Click);
            // 
            // magazynToolStripMenuItem
            // 
            this.magazynToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("magazynToolStripMenuItem.Image")));
            this.magazynToolStripMenuItem.Name = "magazynToolStripMenuItem";
            this.magazynToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.magazynToolStripMenuItem.Text = "Magazyn";
            this.magazynToolStripMenuItem.Click += new System.EventHandler(this.magazynToolStripMenuItem_Click);
            // 
            // pracownicyToolStripMenuItem
            // 
            this.pracownicyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pracownicyToolStripMenuItem.Image")));
            this.pracownicyToolStripMenuItem.Name = "pracownicyToolStripMenuItem";
            this.pracownicyToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pracownicyToolStripMenuItem.Text = "Pracownicy";
            this.pracownicyToolStripMenuItem.Click += new System.EventHandler(this.pracownicyToolStripMenuItem_Click);
            // 
            // kontrahenciToolStripMenuItem
            // 
            this.kontrahenciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kontrahenciToolStripMenuItem.Image")));
            this.kontrahenciToolStripMenuItem.Name = "kontrahenciToolStripMenuItem";
            this.kontrahenciToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.kontrahenciToolStripMenuItem.Text = "Klienci/Kontrahenci";
            this.kontrahenciToolStripMenuItem.Click += new System.EventHandler(this.kontrahenciToolStripMenuItem_Click);
            // 
            // transakcjeToolStripMenuItem
            // 
            this.transakcjeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("transakcjeToolStripMenuItem.Image")));
            this.transakcjeToolStripMenuItem.Name = "transakcjeToolStripMenuItem";
            this.transakcjeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.transakcjeToolStripMenuItem.Text = "Zlecenia/naprawy";
            this.transakcjeToolStripMenuItem.Click += new System.EventHandler(this.transakcjeToolStripMenuItem_Click);
            // 
            // fakturyToolStripMenuItem
            // 
            this.fakturyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fakturyToolStripMenuItem.Image")));
            this.fakturyToolStripMenuItem.Name = "fakturyToolStripMenuItem";
            this.fakturyToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.fakturyToolStripMenuItem.Text = "Baza pojazdów";
            this.fakturyToolStripMenuItem.Click += new System.EventHandler(this.fakturyToolStripMenuItem_Click);
            // 
            // użytkownicyToolStripMenuItem
            // 
            this.użytkownicyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bazaUżytkownikówToolStripMenuItem});
            this.użytkownicyToolStripMenuItem.Name = "użytkownicyToolStripMenuItem";
            this.użytkownicyToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.użytkownicyToolStripMenuItem.Text = "Użytkownicy";
            // 
            // bazaUżytkownikówToolStripMenuItem
            // 
            this.bazaUżytkownikówToolStripMenuItem.Name = "bazaUżytkownikówToolStripMenuItem";
            this.bazaUżytkownikówToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.bazaUżytkownikówToolStripMenuItem.Text = "Baza użytkowników";
            this.bazaUżytkownikówToolStripMenuItem.ToolTipText = "Baza danych użytkowników obsługujących ten program";
            this.bazaUżytkownikówToolStripMenuItem.Click += new System.EventHandler(this.bazaUżytkownikówToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaProgramuToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // ustawieniaProgramuToolStripMenuItem
            // 
            this.ustawieniaProgramuToolStripMenuItem.Name = "ustawieniaProgramuToolStripMenuItem";
            this.ustawieniaProgramuToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ustawieniaProgramuToolStripMenuItem.Text = "Ustawienia programu";
            this.ustawieniaProgramuToolStripMenuItem.ToolTipText = "Główne ustawienia";
            this.ustawieniaProgramuToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaProgramuToolStripMenuItem_Click);
            // 
            // bazaDanychToolStripMenuItem
            // 
            this.bazaDanychToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopiaZapasowaBazyDanychFolderDomyślnyToolStripMenuItem,
            this.kopiaZapasowaBazyDanychWybranaLokalizacjaToolStripMenuItem,
            this.toolStripSeparator9,
            this.importujBazęDanychFolderDomyślnyToolStripMenuItem,
            this.importBazyDanychWybranaLokalizacjaToolStripMenuItem});
            this.bazaDanychToolStripMenuItem.Name = "bazaDanychToolStripMenuItem";
            this.bazaDanychToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.bazaDanychToolStripMenuItem.Text = "Baza danych";
            // 
            // kopiaZapasowaBazyDanychFolderDomyślnyToolStripMenuItem
            // 
            this.kopiaZapasowaBazyDanychFolderDomyślnyToolStripMenuItem.Name = "kopiaZapasowaBazyDanychFolderDomyślnyToolStripMenuItem";
            this.kopiaZapasowaBazyDanychFolderDomyślnyToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
            this.kopiaZapasowaBazyDanychFolderDomyślnyToolStripMenuItem.Text = "Kopia zapasowa bazy danych - folder domyślny";
            this.kopiaZapasowaBazyDanychFolderDomyślnyToolStripMenuItem.Click += new System.EventHandler(this.kopiaZapasowaBazyDanychFolderDomyślnyToolStripMenuItem_Click);
            // 
            // kopiaZapasowaBazyDanychWybranaLokalizacjaToolStripMenuItem
            // 
            this.kopiaZapasowaBazyDanychWybranaLokalizacjaToolStripMenuItem.Name = "kopiaZapasowaBazyDanychWybranaLokalizacjaToolStripMenuItem";
            this.kopiaZapasowaBazyDanychWybranaLokalizacjaToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
            this.kopiaZapasowaBazyDanychWybranaLokalizacjaToolStripMenuItem.Text = "Kopia zapasowa bazy danych - wybrana lokalizacja";
            this.kopiaZapasowaBazyDanychWybranaLokalizacjaToolStripMenuItem.Click += new System.EventHandler(this.kopiaZapasowaBazyDanychWybranaLokalizacjaToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(337, 6);
            // 
            // importujBazęDanychFolderDomyślnyToolStripMenuItem
            // 
            this.importujBazęDanychFolderDomyślnyToolStripMenuItem.Name = "importujBazęDanychFolderDomyślnyToolStripMenuItem";
            this.importujBazęDanychFolderDomyślnyToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
            this.importujBazęDanychFolderDomyślnyToolStripMenuItem.Text = "Import bazy danych - folder domyślny";
            this.importujBazęDanychFolderDomyślnyToolStripMenuItem.Click += new System.EventHandler(this.importujBazęDanychFolderDomyślnyToolStripMenuItem_Click);
            // 
            // importBazyDanychWybranaLokalizacjaToolStripMenuItem
            // 
            this.importBazyDanychWybranaLokalizacjaToolStripMenuItem.Name = "importBazyDanychWybranaLokalizacjaToolStripMenuItem";
            this.importBazyDanychWybranaLokalizacjaToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
            this.importBazyDanychWybranaLokalizacjaToolStripMenuItem.Text = "Import bazy danych - wybrana lokalizacja";
            this.importBazyDanychWybranaLokalizacjaToolStripMenuItem.Click += new System.EventHandler(this.importBazyDanychWybranaLokalizacjaToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem1,
            this.toolStripSeparator7,
            this.informacjeOProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.pomocToolStripMenuItem1.Text = "Pomoc";
            this.pomocToolStripMenuItem1.ToolTipText = "Pomoc programu";
            this.pomocToolStripMenuItem1.Click += new System.EventHandler(this.pomocToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(196, 6);
            // 
            // informacjeOProgramieToolStripMenuItem
            // 
            this.informacjeOProgramieToolStripMenuItem.Name = "informacjeOProgramieToolStripMenuItem";
            this.informacjeOProgramieToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.informacjeOProgramieToolStripMenuItem.Text = "Informacje o programie";
            this.informacjeOProgramieToolStripMenuItem.Click += new System.EventHandler(this.informacjeOProgramieToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProdukty,
            this.toolStripSeparator1,
            this.tsbUslugi,
            this.toolStripSeparator8,
            this.tsbMagazyn,
            this.toolStripSeparator4,
            this.tsbPracownicy,
            this.toolStripSeparator2,
            this.tsbKontrahenci,
            this.toolStripSeparator3,
            this.tsbInvoices,
            this.toolStripSeparator5,
            this.tsbFaktury,
            this.toolStripSeparator6,
            this.tsbFakturyTrue,
            this.toolStripSeparator10});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 61);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbProdukty
            // 
            this.tsbProdukty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsbProdukty.Image = ((System.Drawing.Image)(resources.GetObject("tsbProdukty.Image")));
            this.tsbProdukty.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbProdukty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProdukty.Name = "tsbProdukty";
            this.tsbProdukty.Size = new System.Drawing.Size(52, 58);
            this.tsbProdukty.Text = "Części";
            this.tsbProdukty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbProdukty.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbProdukty.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbProdukty.ToolTipText = "Kliknij aby przejść do bazy produktów";
            this.tsbProdukty.Click += new System.EventHandler(this.tsbProdukty_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 61);
            // 
            // tsbUslugi
            // 
            this.tsbUslugi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsbUslugi.Image = ((System.Drawing.Image)(resources.GetObject("tsbUslugi.Image")));
            this.tsbUslugi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUslugi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUslugi.Name = "tsbUslugi";
            this.tsbUslugi.Size = new System.Drawing.Size(68, 58);
            this.tsbUslugi.Text = "Usługi";
            this.tsbUslugi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbUslugi.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbUslugi.Click += new System.EventHandler(this.tsbUslugi_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 61);
            // 
            // tsbMagazyn
            // 
            this.tsbMagazyn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsbMagazyn.Image = ((System.Drawing.Image)(resources.GetObject("tsbMagazyn.Image")));
            this.tsbMagazyn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMagazyn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMagazyn.Name = "tsbMagazyn";
            this.tsbMagazyn.Size = new System.Drawing.Size(64, 58);
            this.tsbMagazyn.Text = "Magazyn";
            this.tsbMagazyn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbMagazyn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbMagazyn.ToolTipText = "Kliknij aby przejść do magazynu";
            this.tsbMagazyn.Click += new System.EventHandler(this.tsbMagazyn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 61);
            // 
            // tsbPracownicy
            // 
            this.tsbPracownicy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsbPracownicy.Image = ((System.Drawing.Image)(resources.GetObject("tsbPracownicy.Image")));
            this.tsbPracownicy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPracownicy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPracownicy.Name = "tsbPracownicy";
            this.tsbPracownicy.Size = new System.Drawing.Size(84, 58);
            this.tsbPracownicy.Text = "Pracownicy";
            this.tsbPracownicy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbPracownicy.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbPracownicy.ToolTipText = "Kliknij aby przejść do bazy pracowników w twojej firmie";
            this.tsbPracownicy.Click += new System.EventHandler(this.tsbPracownicy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 61);
            // 
            // tsbKontrahenci
            // 
            this.tsbKontrahenci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbKontrahenci.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsbKontrahenci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbKontrahenci.Image = ((System.Drawing.Image)(resources.GetObject("tsbKontrahenci.Image")));
            this.tsbKontrahenci.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbKontrahenci.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKontrahenci.Name = "tsbKontrahenci";
            this.tsbKontrahenci.Size = new System.Drawing.Size(121, 58);
            this.tsbKontrahenci.Text = "Klienci/Kontrahenci";
            this.tsbKontrahenci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbKontrahenci.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbKontrahenci.ToolTipText = "Kliknij aby przejść do bazy kontrahentów (Klienci oraz dostawcy)";
            this.tsbKontrahenci.Click += new System.EventHandler(this.tsbKontrahenci_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 61);
            // 
            // tsbInvoices
            // 
            this.tsbInvoices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsbInvoices.Image = ((System.Drawing.Image)(resources.GetObject("tsbInvoices.Image")));
            this.tsbInvoices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbInvoices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInvoices.Name = "tsbInvoices";
            this.tsbInvoices.Size = new System.Drawing.Size(109, 58);
            this.tsbInvoices.Text = "Zlecenia/naprawy";
            this.tsbInvoices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbInvoices.ToolTipText = "Kliknij aby przejść do bazy transakcji sprzedaży";
            this.tsbInvoices.Click += new System.EventHandler(this.tsbInvoices_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 61);
            // 
            // tsbFaktury
            // 
            this.tsbFaktury.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsbFaktury.Image = ((System.Drawing.Image)(resources.GetObject("tsbFaktury.Image")));
            this.tsbFaktury.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFaktury.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFaktury.Name = "tsbFaktury";
            this.tsbFaktury.Size = new System.Drawing.Size(93, 58);
            this.tsbFaktury.Text = "Baza pojazdów";
            this.tsbFaktury.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbFaktury.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbFaktury.ToolTipText = "Kliknij aby przejść do faktur";
            this.tsbFaktury.Click += new System.EventHandler(this.tsbFaktury_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 61);
            // 
            // tsbFakturyTrue
            // 
            this.tsbFakturyTrue.Enabled = false;
            this.tsbFakturyTrue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsbFakturyTrue.Image = ((System.Drawing.Image)(resources.GetObject("tsbFakturyTrue.Image")));
            this.tsbFakturyTrue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFakturyTrue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFakturyTrue.Name = "tsbFakturyTrue";
            this.tsbFakturyTrue.Size = new System.Drawing.Size(64, 58);
            this.tsbFakturyTrue.Text = "Faktury";
            this.tsbFakturyTrue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbFakturyTrue.ToolTipText = "Faktury";
            this.tsbFakturyTrue.Visible = false;
            this.tsbFakturyTrue.Click += new System.EventHandler(this.tsbFakturyTrue_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 61);
            this.toolStripSeparator10.Visible = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 85);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1008, 647);
            this.MainPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 732);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "warsztat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbProdukty;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPracownicy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbKontrahenci;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbInvoices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbMagazyn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbFaktury;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem zalogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazynToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pracownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrahenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transakcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakturyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem użytkownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaUżytkownikówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem informacjeOProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton tsbUslugi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem bazaDanychToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiaZapasowaBazyDanychFolderDomyślnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiaZapasowaBazyDanychWybranaLokalizacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem importujBazęDanychFolderDomyślnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importBazyDanychWybranaLokalizacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbFakturyTrue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;

    }
}

