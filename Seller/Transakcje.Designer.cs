namespace Seller
{
    partial class Transakcje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transakcje));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdTowaryPodgląd = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cmdKontrahentDodaj = new System.Windows.Forms.Button();
            this.cmdKontrahent = new System.Windows.Forms.Button();
            this.cbxKontrahent = new System.Windows.Forms.ComboBox();
            this.cmdTowaryDodaj = new System.Windows.Forms.Button();
            this.txtPracownik = new System.Windows.Forms.TextBox();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.cmdKoniec = new System.Windows.Forms.Button();
            this.dgvProdukty = new System.Windows.Forms.DataGridView();
            this.cmdTowaryUsun = new System.Windows.Forms.Button();
            this.txtSumaNetto = new System.Windows.Forms.TextBox();
            this.txtNumerFaktury = new System.Windows.Forms.TextBox();
            this.cbxPlatnosc = new System.Windows.Forms.ComboBox();
            this.txtUwagi = new System.Windows.Forms.TextBox();
            this.cbxTypFaktury = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdTowaryView = new System.Windows.Forms.Button();
            this.cbxTowary = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cmdUslugiView = new System.Windows.Forms.Button();
            this.dgvUslugi = new System.Windows.Forms.DataGridView();
            this.cmdUslugiUsun = new System.Windows.Forms.Button();
            this.cmdUslugiDodaj = new System.Windows.Forms.Button();
            this.cmdUslugiPodglad = new System.Windows.Forms.Button();
            this.cmdCarAdd = new System.Windows.Forms.Button();
            this.cmsCarSearch = new System.Windows.Forms.Button();
            this.cbxCar = new System.Windows.Forms.ComboBox();
            this.cmdKoniecSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpTerminZaplaty = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmdPrintOrder = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpTerminUkonczenia = new System.Windows.Forms.DateTimePicker();
            this.cmdPrintInfo = new System.Windows.Forms.Button();
            this.cmdUsterki = new System.Windows.Forms.Button();
            this.cbxDowod = new System.Windows.Forms.ComboBox();
            this.lblDowod = new System.Windows.Forms.Label();
            this.cbxPaliwo = new System.Windows.Forms.ComboBox();
            this.lblStanPaliwa = new System.Windows.Forms.Label();
            this.txtStanLicznika = new System.Windows.Forms.TextBox();
            this.lblStanLicznika = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdProtokolPrint = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUslugi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdTowaryPodgląd
            // 
            this.cmdTowaryPodgląd.Image = ((System.Drawing.Image)(resources.GetObject("cmdTowaryPodgląd.Image")));
            this.cmdTowaryPodgląd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdTowaryPodgląd.Location = new System.Drawing.Point(441, 120);
            this.cmdTowaryPodgląd.Name = "cmdTowaryPodgląd";
            this.cmdTowaryPodgląd.Size = new System.Drawing.Size(75, 23);
            this.cmdTowaryPodgląd.TabIndex = 32;
            this.cmdTowaryPodgląd.Text = "Podgląd";
            this.cmdTowaryPodgląd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdTowaryPodgląd, "Kliknij aby zobaczyć szczegóły");
            this.cmdTowaryPodgląd.UseVisualStyleBackColor = true;
            this.cmdTowaryPodgląd.Click += new System.EventHandler(this.cmdPodgląd_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSuma.Location = new System.Drawing.Point(551, 221);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(110, 22);
            this.txtSuma.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtSuma, "Całkowity koszt brutto zleenia");
            this.txtSuma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuma_KeyPress);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(647, 12);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(79, 20);
            this.dtpData.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dtpData, "Data wykonania zlecenia");
            this.dtpData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTypFaktury_KeyPress);
            // 
            // cmdKontrahentDodaj
            // 
            this.cmdKontrahentDodaj.Location = new System.Drawing.Point(337, 61);
            this.cmdKontrahentDodaj.Name = "cmdKontrahentDodaj";
            this.cmdKontrahentDodaj.Size = new System.Drawing.Size(25, 25);
            this.cmdKontrahentDodaj.TabIndex = 42;
            this.cmdKontrahentDodaj.Text = "+";
            this.toolTip1.SetToolTip(this.cmdKontrahentDodaj, "Dodawanie nowego kontrahenta do bazy");
            this.cmdKontrahentDodaj.UseVisualStyleBackColor = true;
            this.cmdKontrahentDodaj.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdKontrahent
            // 
            this.cmdKontrahent.Image = ((System.Drawing.Image)(resources.GetObject("cmdKontrahent.Image")));
            this.cmdKontrahent.Location = new System.Drawing.Point(368, 61);
            this.cmdKontrahent.Name = "cmdKontrahent";
            this.cmdKontrahent.Size = new System.Drawing.Size(25, 25);
            this.cmdKontrahent.TabIndex = 41;
            this.toolTip1.SetToolTip(this.cmdKontrahent, "Wyszukiwanie kontrahenta z bazy");
            this.cmdKontrahent.UseVisualStyleBackColor = true;
            this.cmdKontrahent.Click += new System.EventHandler(this.cmdKontrahent_Click);
            // 
            // cbxKontrahent
            // 
            this.cbxKontrahent.FormattingEnabled = true;
            this.cbxKontrahent.Location = new System.Drawing.Point(132, 64);
            this.cbxKontrahent.Name = "cbxKontrahent";
            this.cbxKontrahent.Size = new System.Drawing.Size(199, 21);
            this.cbxKontrahent.TabIndex = 37;
            this.cbxKontrahent.Text = "Wybierz kontrahenta";
            this.toolTip1.SetToolTip(this.cbxKontrahent, "Kontrahent (właściciel) zlecający wykonanie");
            this.cbxKontrahent.SelectedIndexChanged += new System.EventHandler(this.cbxKontrahent_SelectedIndexChanged);
            this.cbxKontrahent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTypFaktury_KeyPress);
            // 
            // cmdTowaryDodaj
            // 
            this.cmdTowaryDodaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdTowaryDodaj.Image")));
            this.cmdTowaryDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdTowaryDodaj.Location = new System.Drawing.Point(520, 120);
            this.cmdTowaryDodaj.Name = "cmdTowaryDodaj";
            this.cmdTowaryDodaj.Size = new System.Drawing.Size(86, 23);
            this.cmdTowaryDodaj.TabIndex = 22;
            this.cmdTowaryDodaj.Text = "Dodaj";
            this.cmdTowaryDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdTowaryDodaj, "Dodawanie nowej części do listy");
            this.cmdTowaryDodaj.UseVisualStyleBackColor = true;
            this.cmdTowaryDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // txtPracownik
            // 
            this.txtPracownik.Location = new System.Drawing.Point(132, 38);
            this.txtPracownik.Name = "txtPracownik";
            this.txtPracownik.Size = new System.Drawing.Size(199, 20);
            this.txtPracownik.TabIndex = 35;
            this.toolTip1.SetToolTip(this.txtPracownik, "Pracownik wprowadzający zlecenie do bazy");
            this.txtPracownik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuma_KeyPress);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnuluj.Image")));
            this.cmdAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnuluj.Location = new System.Drawing.Point(15, 591);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(710, 23);
            this.cmdAnuluj.TabIndex = 26;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdAnuluj, "Anuluj całe zlecenie");
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // cmdKoniec
            // 
            this.cmdKoniec.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cmdKoniec.Image = ((System.Drawing.Image)(resources.GetObject("cmdKoniec.Image")));
            this.cmdKoniec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdKoniec.Location = new System.Drawing.Point(390, 560);
            this.cmdKoniec.Name = "cmdKoniec";
            this.cmdKoniec.Size = new System.Drawing.Size(119, 23);
            this.cmdKoniec.TabIndex = 25;
            this.cmdKoniec.Text = "Drukuj fakturę";
            this.cmdKoniec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdKoniec, "Drukowanie faktury");
            this.cmdKoniec.UseVisualStyleBackColor = false;
            this.cmdKoniec.Click += new System.EventHandler(this.cmdKoniec_Click);
            // 
            // dgvProdukty
            // 
            this.dgvProdukty.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProdukty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdukty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdukty.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProdukty.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProdukty.Location = new System.Drawing.Point(16, 19);
            this.dgvProdukty.Name = "dgvProdukty";
            this.dgvProdukty.Size = new System.Drawing.Size(646, 95);
            this.dgvProdukty.TabIndex = 24;
            this.toolTip1.SetToolTip(this.dgvProdukty, "Lista części użytych w zleceniu naprawy");
            // 
            // cmdTowaryUsun
            // 
            this.cmdTowaryUsun.Image = ((System.Drawing.Image)(resources.GetObject("cmdTowaryUsun.Image")));
            this.cmdTowaryUsun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdTowaryUsun.Location = new System.Drawing.Point(612, 120);
            this.cmdTowaryUsun.Name = "cmdTowaryUsun";
            this.cmdTowaryUsun.Size = new System.Drawing.Size(86, 23);
            this.cmdTowaryUsun.TabIndex = 23;
            this.cmdTowaryUsun.Text = "Usuń";
            this.cmdTowaryUsun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdTowaryUsun, "Usuwanie części z listy");
            this.cmdTowaryUsun.UseVisualStyleBackColor = true;
            this.cmdTowaryUsun.Click += new System.EventHandler(this.cmdUsun_Click);
            // 
            // txtSumaNetto
            // 
            this.txtSumaNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSumaNetto.Location = new System.Drawing.Point(551, 193);
            this.txtSumaNetto.Name = "txtSumaNetto";
            this.txtSumaNetto.Size = new System.Drawing.Size(109, 22);
            this.txtSumaNetto.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtSumaNetto, "Całkowity koszt netto zlecenia");
            this.txtSumaNetto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuma_KeyPress);
            // 
            // txtNumerFaktury
            // 
            this.txtNumerFaktury.Location = new System.Drawing.Point(132, 12);
            this.txtNumerFaktury.Name = "txtNumerFaktury";
            this.txtNumerFaktury.Size = new System.Drawing.Size(93, 20);
            this.txtNumerFaktury.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNumerFaktury, "Kolejny numer zleceania naprawy (generowany automatycznie lub ustawiony ręcznie)");
            this.txtNumerFaktury.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerFaktury_KeyPress);
            // 
            // cbxPlatnosc
            // 
            this.cbxPlatnosc.FormattingEnabled = true;
            this.cbxPlatnosc.Items.AddRange(new object[] {
            "Gotówka",
            "Przelew"});
            this.cbxPlatnosc.Location = new System.Drawing.Point(132, 169);
            this.cbxPlatnosc.Name = "cbxPlatnosc";
            this.cbxPlatnosc.Size = new System.Drawing.Size(142, 21);
            this.cbxPlatnosc.TabIndex = 38;
            this.toolTip1.SetToolTip(this.cbxPlatnosc, "Forma płatności (gotówka, przelew)");
            this.cbxPlatnosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuma_KeyPress);
            // 
            // txtUwagi
            // 
            this.txtUwagi.Location = new System.Drawing.Point(132, 91);
            this.txtUwagi.Name = "txtUwagi";
            this.txtUwagi.Size = new System.Drawing.Size(261, 20);
            this.txtUwagi.TabIndex = 0;
            this.txtUwagi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerFaktury_KeyPress);
            // 
            // cbxTypFaktury
            // 
            this.cbxTypFaktury.FormattingEnabled = true;
            this.cbxTypFaktury.Items.AddRange(new object[] {
            "Faktura",
            "Faktura - korygująca",
            "Faktura - korygująca-anulowana",
            "Paragon",
            "Rachunek uproszczony"});
            this.cbxTypFaktury.Location = new System.Drawing.Point(326, 12);
            this.cbxTypFaktury.Name = "cbxTypFaktury";
            this.cbxTypFaktury.Size = new System.Drawing.Size(170, 21);
            this.cbxTypFaktury.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbxTypFaktury, "Rodzaj rachunku dla klienta (faktura, paragon...)");
            this.cbxTypFaktury.SelectedIndexChanged += new System.EventHandler(this.cbxTypFaktury_SelectedIndexChanged);
            this.cbxTypFaktury.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTypFaktury_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdTowaryView);
            this.groupBox6.Controls.Add(this.cbxTowary);
            this.groupBox6.Controls.Add(this.cmdTowaryUsun);
            this.groupBox6.Controls.Add(this.dgvProdukty);
            this.groupBox6.Controls.Add(this.cmdTowaryDodaj);
            this.groupBox6.Controls.Add(this.cmdTowaryPodgląd);
            this.groupBox6.Location = new System.Drawing.Point(12, 253);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(714, 150);
            this.groupBox6.TabIndex = 40;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lista użytych części";
            this.toolTip1.SetToolTip(this.groupBox6, "Lista części użytych w zleceniu naprawy");
            // 
            // cmdTowaryView
            // 
            this.cmdTowaryView.Image = ((System.Drawing.Image)(resources.GetObject("cmdTowaryView.Image")));
            this.cmdTowaryView.Location = new System.Drawing.Point(668, 19);
            this.cmdTowaryView.Name = "cmdTowaryView";
            this.cmdTowaryView.Size = new System.Drawing.Size(30, 30);
            this.cmdTowaryView.TabIndex = 34;
            this.toolTip1.SetToolTip(this.cmdTowaryView, "Kliknij aby rozwinąć listę częsci użytych w naprawie");
            this.cmdTowaryView.UseVisualStyleBackColor = true;
            this.cmdTowaryView.Click += new System.EventHandler(this.cmdTowaryView_Click);
            // 
            // cbxTowary
            // 
            this.cbxTowary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTowary.FormattingEnabled = true;
            this.cbxTowary.Location = new System.Drawing.Point(12, 122);
            this.cbxTowary.Name = "cbxTowary";
            this.cbxTowary.Size = new System.Drawing.Size(423, 21);
            this.cbxTowary.TabIndex = 33;
            this.cbxTowary.SelectedIndexChanged += new System.EventHandler(this.cbxTowary_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cmdUslugiView);
            this.groupBox8.Controls.Add(this.dgvUslugi);
            this.groupBox8.Controls.Add(this.cmdUslugiUsun);
            this.groupBox8.Controls.Add(this.cmdUslugiDodaj);
            this.groupBox8.Controls.Add(this.cmdUslugiPodglad);
            this.groupBox8.Location = new System.Drawing.Point(12, 400);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(714, 154);
            this.groupBox8.TabIndex = 40;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Lista usług/napraw";
            this.toolTip1.SetToolTip(this.groupBox8, "Lista wykonanych usług (napraw)");
            // 
            // cmdUslugiView
            // 
            this.cmdUslugiView.Image = ((System.Drawing.Image)(resources.GetObject("cmdUslugiView.Image")));
            this.cmdUslugiView.Location = new System.Drawing.Point(668, 19);
            this.cmdUslugiView.Name = "cmdUslugiView";
            this.cmdUslugiView.Size = new System.Drawing.Size(30, 30);
            this.cmdUslugiView.TabIndex = 35;
            this.toolTip1.SetToolTip(this.cmdUslugiView, "Kliknij aby rozwinąć listę wykonanych usług (napraw)");
            this.cmdUslugiView.UseVisualStyleBackColor = true;
            this.cmdUslugiView.Click += new System.EventHandler(this.cmdUslugiView_Click);
            // 
            // dgvUslugi
            // 
            this.dgvUslugi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUslugi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUslugi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvUslugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUslugi.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUslugi.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUslugi.Location = new System.Drawing.Point(12, 19);
            this.dgvUslugi.Name = "dgvUslugi";
            this.dgvUslugi.Size = new System.Drawing.Size(650, 95);
            this.dgvUslugi.TabIndex = 34;
            this.toolTip1.SetToolTip(this.dgvUslugi, "Lista wykonanych usług (napraw)");
            // 
            // cmdUslugiUsun
            // 
            this.cmdUslugiUsun.Image = ((System.Drawing.Image)(resources.GetObject("cmdUslugiUsun.Image")));
            this.cmdUslugiUsun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUslugiUsun.Location = new System.Drawing.Point(612, 120);
            this.cmdUslugiUsun.Name = "cmdUslugiUsun";
            this.cmdUslugiUsun.Size = new System.Drawing.Size(86, 23);
            this.cmdUslugiUsun.TabIndex = 23;
            this.cmdUslugiUsun.Text = "Usuń";
            this.cmdUslugiUsun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdUslugiUsun, "Usuń pozycję (naprwę) z listy");
            this.cmdUslugiUsun.UseVisualStyleBackColor = true;
            this.cmdUslugiUsun.Click += new System.EventHandler(this.cmdUslugiUsun_Click);
            // 
            // cmdUslugiDodaj
            // 
            this.cmdUslugiDodaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdUslugiDodaj.Image")));
            this.cmdUslugiDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUslugiDodaj.Location = new System.Drawing.Point(520, 120);
            this.cmdUslugiDodaj.Name = "cmdUslugiDodaj";
            this.cmdUslugiDodaj.Size = new System.Drawing.Size(86, 23);
            this.cmdUslugiDodaj.TabIndex = 22;
            this.cmdUslugiDodaj.Text = "Dodaj";
            this.cmdUslugiDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdUslugiDodaj, "Dodaj nową usługę (naprawę)");
            this.cmdUslugiDodaj.UseVisualStyleBackColor = true;
            this.cmdUslugiDodaj.Click += new System.EventHandler(this.cmdUslugiDodaj_Click);
            // 
            // cmdUslugiPodglad
            // 
            this.cmdUslugiPodglad.Image = ((System.Drawing.Image)(resources.GetObject("cmdUslugiPodglad.Image")));
            this.cmdUslugiPodglad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUslugiPodglad.Location = new System.Drawing.Point(439, 120);
            this.cmdUslugiPodglad.Name = "cmdUslugiPodglad";
            this.cmdUslugiPodglad.Size = new System.Drawing.Size(75, 23);
            this.cmdUslugiPodglad.TabIndex = 32;
            this.cmdUslugiPodglad.Text = "Podgląd";
            this.cmdUslugiPodglad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdUslugiPodglad, "Podgląd szczegółowy");
            this.cmdUslugiPodglad.UseVisualStyleBackColor = true;
            this.cmdUslugiPodglad.Click += new System.EventHandler(this.cmdUslugiPodglad_Click);
            // 
            // cmdCarAdd
            // 
            this.cmdCarAdd.Location = new System.Drawing.Point(255, 20);
            this.cmdCarAdd.Name = "cmdCarAdd";
            this.cmdCarAdd.Size = new System.Drawing.Size(25, 25);
            this.cmdCarAdd.TabIndex = 42;
            this.cmdCarAdd.Text = "+";
            this.toolTip1.SetToolTip(this.cmdCarAdd, "Dodawanie pojazdu do bazy");
            this.cmdCarAdd.UseVisualStyleBackColor = true;
            this.cmdCarAdd.Click += new System.EventHandler(this.cmdCarAdd_Click);
            // 
            // cmsCarSearch
            // 
            this.cmsCarSearch.Image = ((System.Drawing.Image)(resources.GetObject("cmsCarSearch.Image")));
            this.cmsCarSearch.Location = new System.Drawing.Point(286, 20);
            this.cmsCarSearch.Name = "cmsCarSearch";
            this.cmsCarSearch.Size = new System.Drawing.Size(25, 25);
            this.cmsCarSearch.TabIndex = 41;
            this.toolTip1.SetToolTip(this.cmsCarSearch, "Wyszukiwanie pojazdu z bazy");
            this.cmsCarSearch.UseVisualStyleBackColor = true;
            this.cmsCarSearch.Click += new System.EventHandler(this.cmsCarSearch_Click);
            // 
            // cbxCar
            // 
            this.cbxCar.FormattingEnabled = true;
            this.cbxCar.Location = new System.Drawing.Point(16, 23);
            this.cbxCar.Name = "cbxCar";
            this.cbxCar.Size = new System.Drawing.Size(233, 21);
            this.cbxCar.TabIndex = 37;
            this.cbxCar.Text = "Wybierz lub dodaj pojazd";
            this.cbxCar.SelectedIndexChanged += new System.EventHandler(this.cbxCar_SelectedIndexChanged);
            this.cbxCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTypFaktury_KeyPress);
            // 
            // cmdKoniecSave
            // 
            this.cmdKoniecSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdKoniecSave.Image")));
            this.cmdKoniecSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdKoniecSave.Location = new System.Drawing.Point(15, 560);
            this.cmdKoniecSave.Name = "cmdKoniecSave";
            this.cmdKoniecSave.Size = new System.Drawing.Size(119, 23);
            this.cmdKoniecSave.TabIndex = 44;
            this.cmdKoniecSave.Text = "Zapisz do bazy";
            this.cmdKoniecSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdKoniecSave, "Zapisuje do bazy");
            this.cmdKoniecSave.UseVisualStyleBackColor = true;
            this.cmdKoniecSave.Click += new System.EventHandler(this.cmdKoniecSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Numer zlecenia/rach.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Typ rachunku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Wystawił";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Kontrahent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Forma płatności";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Uwagi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(465, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "Suma netto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(465, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "Suma brutto";
            // 
            // dtpTerminZaplaty
            // 
            this.dtpTerminZaplaty.Location = new System.Drawing.Point(132, 117);
            this.dtpTerminZaplaty.Name = "dtpTerminZaplaty";
            this.dtpTerminZaplaty.Size = new System.Drawing.Size(142, 20);
            this.dtpTerminZaplaty.TabIndex = 55;
            this.toolTip1.SetToolTip(this.dtpTerminZaplaty, "Termin zapłaty na fakturze");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Termin zapłaty";
            // 
            // cmdPrintOrder
            // 
            this.cmdPrintOrder.BackColor = System.Drawing.Color.LightGreen;
            this.cmdPrintOrder.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrintOrder.Image")));
            this.cmdPrintOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrintOrder.Location = new System.Drawing.Point(265, 560);
            this.cmdPrintOrder.Name = "cmdPrintOrder";
            this.cmdPrintOrder.Size = new System.Drawing.Size(119, 23);
            this.cmdPrintOrder.TabIndex = 57;
            this.cmdPrintOrder.Text = "Drukuj zlecenie";
            this.cmdPrintOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdPrintOrder, "Zlecenie dla klienta lub mechanika wykonującego naprawę");
            this.cmdPrintOrder.UseVisualStyleBackColor = false;
            this.cmdPrintOrder.Click += new System.EventHandler(this.cmdPrintOrder_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Termin ukończenia";
            // 
            // dtpTerminUkonczenia
            // 
            this.dtpTerminUkonczenia.Location = new System.Drawing.Point(132, 143);
            this.dtpTerminUkonczenia.Name = "dtpTerminUkonczenia";
            this.dtpTerminUkonczenia.Size = new System.Drawing.Size(142, 20);
            this.dtpTerminUkonczenia.TabIndex = 58;
            this.toolTip1.SetToolTip(this.dtpTerminUkonczenia, "Orientacyjny termin ukończenia");
            // 
            // cmdPrintInfo
            // 
            this.cmdPrintInfo.BackColor = System.Drawing.Color.LightGreen;
            this.cmdPrintInfo.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrintInfo.Image")));
            this.cmdPrintInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrintInfo.Location = new System.Drawing.Point(140, 560);
            this.cmdPrintInfo.Name = "cmdPrintInfo";
            this.cmdPrintInfo.Size = new System.Drawing.Size(119, 23);
            this.cmdPrintInfo.TabIndex = 60;
            this.cmdPrintInfo.Text = "Drukuj kosztorys";
            this.cmdPrintInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdPrintInfo, "Orientacyjny kosztorys dla klienta");
            this.cmdPrintInfo.UseVisualStyleBackColor = false;
            this.cmdPrintInfo.Click += new System.EventHandler(this.cmdPrintInfo_Click);
            // 
            // cmdUsterki
            // 
            this.cmdUsterki.Image = ((System.Drawing.Image)(resources.GetObject("cmdUsterki.Image")));
            this.cmdUsterki.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUsterki.Location = new System.Drawing.Point(10, 16);
            this.cmdUsterki.Name = "cmdUsterki";
            this.cmdUsterki.Size = new System.Drawing.Size(270, 23);
            this.cmdUsterki.TabIndex = 35;
            this.cmdUsterki.Text = "Lista usterek (objawów) zgłoszonych przez klienta";
            this.cmdUsterki.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdUsterki, "Kliknij aby otworzyć listę zgłoszonych przez klienta usterek");
            this.cmdUsterki.UseVisualStyleBackColor = true;
            this.cmdUsterki.Click += new System.EventHandler(this.cmdUsterki_Click);
            // 
            // cbxDowod
            // 
            this.cbxDowod.FormattingEnabled = true;
            this.cbxDowod.Items.AddRange(new object[] {
            "TAK",
            "NIE"});
            this.cbxDowod.Location = new System.Drawing.Point(167, 106);
            this.cbxDowod.Name = "cbxDowod";
            this.cbxDowod.Size = new System.Drawing.Size(82, 21);
            this.cbxDowod.TabIndex = 70;
            this.toolTip1.SetToolTip(this.cbxDowod, "Czy klienat pozostawił dowód rejestracyjny?");
            this.cbxDowod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxDowod_KeyPress);
            // 
            // lblDowod
            // 
            this.lblDowod.AutoSize = true;
            this.lblDowod.Location = new System.Drawing.Point(51, 109);
            this.lblDowod.Name = "lblDowod";
            this.lblDowod.Size = new System.Drawing.Size(115, 13);
            this.lblDowod.TabIndex = 69;
            this.lblDowod.Text = "Dowód rejestracyjny (*)";
            // 
            // cbxPaliwo
            // 
            this.cbxPaliwo.FormattingEnabled = true;
            this.cbxPaliwo.Items.AddRange(new object[] {
            "0",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.cbxPaliwo.Location = new System.Drawing.Point(167, 80);
            this.cbxPaliwo.Name = "cbxPaliwo";
            this.cbxPaliwo.Size = new System.Drawing.Size(82, 21);
            this.cbxPaliwo.TabIndex = 68;
            this.toolTip1.SetToolTip(this.cbxPaliwo, "Orientacyjny stan paliwa w chwili pozostawienia pojazdu przez klienta");
            this.cbxPaliwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxPaliwo_KeyPress);
            // 
            // lblStanPaliwa
            // 
            this.lblStanPaliwa.AutoSize = true;
            this.lblStanPaliwa.Location = new System.Drawing.Point(90, 84);
            this.lblStanPaliwa.Name = "lblStanPaliwa";
            this.lblStanPaliwa.Size = new System.Drawing.Size(76, 13);
            this.lblStanPaliwa.TabIndex = 67;
            this.lblStanPaliwa.Text = "Stan Paliwa (*)";
            // 
            // txtStanLicznika
            // 
            this.txtStanLicznika.Location = new System.Drawing.Point(105, 51);
            this.txtStanLicznika.Name = "txtStanLicznika";
            this.txtStanLicznika.Size = new System.Drawing.Size(144, 20);
            this.txtStanLicznika.TabIndex = 66;
            this.toolTip1.SetToolTip(this.txtStanLicznika, "Wpisz przebieg samochodu");
            this.txtStanLicznika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStanLicznika_KeyPress);
            // 
            // lblStanLicznika
            // 
            this.lblStanLicznika.AutoSize = true;
            this.lblStanLicznika.Location = new System.Drawing.Point(51, 54);
            this.lblStanLicznika.Name = "lblStanLicznika";
            this.lblStanLicznika.Size = new System.Drawing.Size(48, 13);
            this.lblStanLicznika.TabIndex = 65;
            this.lblStanLicznika.Text = "Przebieg";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStanLicznika);
            this.groupBox1.Controls.Add(this.cbxDowod);
            this.groupBox1.Controls.Add(this.cbxCar);
            this.groupBox1.Controls.Add(this.lblDowod);
            this.groupBox1.Controls.Add(this.cmsCarSearch);
            this.groupBox1.Controls.Add(this.cbxPaliwo);
            this.groupBox1.Controls.Add(this.cmdCarAdd);
            this.groupBox1.Controls.Add(this.lblStanPaliwa);
            this.groupBox1.Controls.Add(this.lblStanLicznika);
            this.groupBox1.Location = new System.Drawing.Point(399, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 140);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przedmiot naprawy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdUsterki);
            this.groupBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 51);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            // 
            // cmdProtokolPrint
            // 
            this.cmdProtokolPrint.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdProtokolPrint.Image = ((System.Drawing.Image)(resources.GetObject("cmdProtokolPrint.Image")));
            this.cmdProtokolPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdProtokolPrint.Location = new System.Drawing.Point(563, 560);
            this.cmdProtokolPrint.Name = "cmdProtokolPrint";
            this.cmdProtokolPrint.Size = new System.Drawing.Size(162, 23);
            this.cmdProtokolPrint.TabIndex = 73;
            this.cmdProtokolPrint.Text = "Drukuj protokół przyjęcia";
            this.cmdProtokolPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdProtokolPrint, "Protokół przyjęcia na warsztat samochodu z  listą zaoobserwowanych przez klienta " +
                    "usterek");
            this.cmdProtokolPrint.UseVisualStyleBackColor = false;
            this.cmdProtokolPrint.Click += new System.EventHandler(this.cmdProtokolPrint_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "km";
            // 
            // Transakcje
            // 
            this.AcceptButton = this.cmdKoniec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 626);
            this.ControlBox = false;
            this.Controls.Add(this.cmdProtokolPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdPrintInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpTerminUkonczenia);
            this.Controls.Add(this.cmdPrintOrder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpTerminZaplaty);
            this.Controls.Add(this.txtSumaNetto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUwagi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxPlatnosc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdKontrahent);
            this.Controls.Add(this.cmdKontrahentDodaj);
            this.Controls.Add(this.cbxKontrahent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPracownik);
            this.Controls.Add(this.cbxTypFaktury);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumerFaktury);
            this.Controls.Add(this.cmdKoniecSave);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdKoniec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Transakcje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zlecenia";
            this.Load += new System.EventHandler(this.Transakcje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUslugi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdTowaryPodgląd;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button cmdTowaryDodaj;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.Button cmdKoniec;
        private System.Windows.Forms.DataGridView dgvProdukty;
        private System.Windows.Forms.Button cmdTowaryUsun;
        private System.Windows.Forms.TextBox txtPracownik;
        private System.Windows.Forms.TextBox txtSumaNetto;
        private System.Windows.Forms.TextBox txtNumerFaktury;
        private System.Windows.Forms.ComboBox cbxPlatnosc;
        private System.Windows.Forms.TextBox txtUwagi;
        private System.Windows.Forms.ComboBox cbxTypFaktury;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbxKontrahent;
        private System.Windows.Forms.ComboBox cbxTowary;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button cmdUslugiUsun;
        private System.Windows.Forms.Button cmdUslugiDodaj;
        private System.Windows.Forms.Button cmdUslugiPodglad;
        private System.Windows.Forms.DataGridView dgvUslugi;
        private System.Windows.Forms.Button cmdTowaryView;
        private System.Windows.Forms.Button cmdUslugiView;
        private System.Windows.Forms.Button cmdKontrahentDodaj;
        private System.Windows.Forms.Button cmdKontrahent;
        private System.Windows.Forms.Button cmdCarAdd;
        private System.Windows.Forms.Button cmsCarSearch;
        private System.Windows.Forms.ComboBox cbxCar;
        private System.Windows.Forms.Button cmdKoniecSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpTerminZaplaty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdPrintOrder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpTerminUkonczenia;
        private System.Windows.Forms.Button cmdPrintInfo;
        private System.Windows.Forms.Button cmdUsterki;
        private System.Windows.Forms.ComboBox cbxDowod;
        private System.Windows.Forms.Label lblDowod;
        private System.Windows.Forms.ComboBox cbxPaliwo;
        private System.Windows.Forms.Label lblStanPaliwa;
        private System.Windows.Forms.TextBox txtStanLicznika;
        private System.Windows.Forms.Label lblStanLicznika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdProtokolPrint;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
    }
}