namespace Seller
{
    partial class FINDKind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FINDKind));
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.MNNtextBox = new System.Windows.Forms.TextBox();
            this.MNtextBox = new System.Windows.Forms.TextBox();
            this.OCNtextBox = new System.Windows.Forms.TextBox();
            this.OCBtextBox = new System.Windows.Forms.TextBox();
            this.cbxKategorie = new System.Windows.Forms.ComboBox();
            this.txtDSC = new System.Windows.Forms.TextBox();
            this.txtMODEL = new System.Windows.Forms.TextBox();
            this.txtKAT = new System.Windows.Forms.TextBox();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.txtKontrahent = new System.Windows.Forms.ComboBox();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.cmdKatDodaj = new System.Windows.Forms.Button();
            this.txtJednostka = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStanMagazynu = new System.Windows.Forms.TextBox();
            this.cbxMagazynI = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdKontrahent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMagazynI = new System.Windows.Forms.Label();
            this.lblStanMagazynu = new System.Windows.Forms.Label();
            this.lblIlosc = new System.Windows.Forms.Label();
            this.lblJednostka = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBrutto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNetto = new System.Windows.Forms.TextBox();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancelbutton.Image = ((System.Drawing.Image)(resources.GetObject("Cancelbutton.Image")));
            this.Cancelbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelbutton.Location = new System.Drawing.Point(19, 363);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(501, 23);
            this.Cancelbutton.TabIndex = 15;
            this.Cancelbutton.Text = "Anuluj";
            this.Cancelbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Savebutton.Image = ((System.Drawing.Image)(resources.GetObject("Savebutton.Image")));
            this.Savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Savebutton.Location = new System.Drawing.Point(19, 334);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(501, 23);
            this.Savebutton.TabIndex = 14;
            this.Savebutton.Text = "Wprowadź";
            this.Savebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // MNNtextBox
            // 
            this.MNNtextBox.Location = new System.Drawing.Point(104, 40);
            this.MNNtextBox.MaxLength = 100;
            this.MNNtextBox.Name = "MNNtextBox";
            this.MNNtextBox.Size = new System.Drawing.Size(416, 20);
            this.MNNtextBox.TabIndex = 1;
            this.MNNtextBox.Click += new System.EventHandler(this.TextBox_Click);
            this.MNNtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MNtextBox_KeyPress);
            // 
            // MNtextBox
            // 
            this.MNtextBox.Location = new System.Drawing.Point(104, 92);
            this.MNtextBox.MaxLength = 100;
            this.MNtextBox.Name = "MNtextBox";
            this.MNtextBox.Size = new System.Drawing.Size(131, 20);
            this.MNtextBox.TabIndex = 4;
            this.MNtextBox.Click += new System.EventHandler(this.TextBox_Click);
            this.MNtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MNtextBox_KeyPress);
            // 
            // OCNtextBox
            // 
            this.OCNtextBox.Location = new System.Drawing.Point(55, 19);
            this.OCNtextBox.MaxLength = 10;
            this.OCNtextBox.Name = "OCNtextBox";
            this.OCNtextBox.Size = new System.Drawing.Size(109, 20);
            this.OCNtextBox.TabIndex = 0;
            this.OCNtextBox.TextChanged += new System.EventHandler(this.OCNtextBox_TextChanged);
            this.OCNtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OCNtextBox_KeyPress);
            // 
            // OCBtextBox
            // 
            this.OCBtextBox.Location = new System.Drawing.Point(277, 19);
            this.OCBtextBox.MaxLength = 10;
            this.OCBtextBox.Name = "OCBtextBox";
            this.OCBtextBox.Size = new System.Drawing.Size(109, 20);
            this.OCBtextBox.TabIndex = 1;
            this.OCBtextBox.TextChanged += new System.EventHandler(this.OCBtextBox_TextChanged);
            this.OCBtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OCBtextBox_KeyPress);
            // 
            // cbxKategorie
            // 
            this.cbxKategorie.FormattingEnabled = true;
            this.cbxKategorie.Location = new System.Drawing.Point(321, 66);
            this.cbxKategorie.Name = "cbxKategorie";
            this.cbxKategorie.Size = new System.Drawing.Size(160, 21);
            this.cbxKategorie.TabIndex = 3;
            this.cbxKategorie.Text = "Wybierz kategorię";
            this.cbxKategorie.SelectedIndexChanged += new System.EventHandler(this.cbxCATEGORY_SelectedIndexChanged);
            this.cbxKategorie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoKeyPress);
            // 
            // txtDSC
            // 
            this.txtDSC.Location = new System.Drawing.Point(104, 118);
            this.txtDSC.MaxLength = 100;
            this.txtDSC.Name = "txtDSC";
            this.txtDSC.Size = new System.Drawing.Size(416, 20);
            this.txtDSC.TabIndex = 6;
            this.txtDSC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MNtextBox_KeyPress);
            // 
            // txtMODEL
            // 
            this.txtMODEL.Location = new System.Drawing.Point(321, 92);
            this.txtMODEL.MaxLength = 100;
            this.txtMODEL.Name = "txtMODEL";
            this.txtMODEL.Size = new System.Drawing.Size(199, 20);
            this.txtMODEL.TabIndex = 5;
            this.txtMODEL.Click += new System.EventHandler(this.TextBox_Click);
            this.txtMODEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MNtextBox_KeyPress);
            // 
            // txtKAT
            // 
            this.txtKAT.Location = new System.Drawing.Point(104, 66);
            this.txtKAT.MaxLength = 100;
            this.txtKAT.Name = "txtKAT";
            this.txtKAT.Size = new System.Drawing.Size(131, 20);
            this.txtKAT.TabIndex = 2;
            this.txtKAT.Click += new System.EventHandler(this.TextBox_Click);
            this.txtKAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MNtextBox_KeyPress);
            // 
            // txtIlosc
            // 
            this.txtIlosc.Location = new System.Drawing.Point(104, 143);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(75, 20);
            this.txtIlosc.TabIndex = 7;
            this.txtIlosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIlosc_KeyPress);
            // 
            // txtKontrahent
            // 
            this.txtKontrahent.FormattingEnabled = true;
            this.txtKontrahent.Location = new System.Drawing.Point(171, 12);
            this.txtKontrahent.Name = "txtKontrahent";
            this.txtKontrahent.Size = new System.Drawing.Size(287, 21);
            this.txtKontrahent.TabIndex = 0;
            this.txtKontrahent.Text = "Wybierz lub dodaj dostawcę";
            this.txtKontrahent.SelectedIndexChanged += new System.EventHandler(this.txtKontrahent_SelectedIndexChanged);
            this.txtKontrahent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoKeyPress);
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.Location = new System.Drawing.Point(464, 9);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(25, 25);
            this.cmdDodaj.TabIndex = 0;
            this.cmdDodaj.Text = "+";
            this.cmdDodaj.UseVisualStyleBackColor = true;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // cmdKatDodaj
            // 
            this.cmdKatDodaj.Location = new System.Drawing.Point(495, 63);
            this.cmdKatDodaj.Name = "cmdKatDodaj";
            this.cmdKatDodaj.Size = new System.Drawing.Size(25, 25);
            this.cmdKatDodaj.TabIndex = 5;
            this.cmdKatDodaj.Text = "+";
            this.cmdKatDodaj.UseVisualStyleBackColor = true;
            this.cmdKatDodaj.Click += new System.EventHandler(this.cmdKatDodaj_Click);
            // 
            // txtJednostka
            // 
            this.txtJednostka.FormattingEnabled = true;
            this.txtJednostka.Items.AddRange(new object[] {
            "Wybierz lub wpisz",
            "sztuk",
            "litrów",
            "metrów",
            "kilogramów",
            "centymetrów",
            "milimetrów",
            "ton",
            "gramów"});
            this.txtJednostka.Location = new System.Drawing.Point(104, 169);
            this.txtJednostka.Name = "txtJednostka";
            this.txtJednostka.Size = new System.Drawing.Size(107, 21);
            this.txtJednostka.TabIndex = 10;
            this.txtJednostka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MNtextBox_KeyPress);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.OCBtextBox);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.OCNtextBox);
            this.groupBox10.Location = new System.Drawing.Point(104, 205);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(416, 51);
            this.groupBox10.TabIndex = 18;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Cena zakupu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(236, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Brutto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Netto";
            // 
            // txtStanMagazynu
            // 
            this.txtStanMagazynu.Location = new System.Drawing.Point(464, 143);
            this.txtStanMagazynu.Name = "txtStanMagazynu";
            this.txtStanMagazynu.Size = new System.Drawing.Size(57, 20);
            this.txtStanMagazynu.TabIndex = 9;
            this.txtStanMagazynu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoKeyPress);
            // 
            // cbxMagazynI
            // 
            this.cbxMagazynI.FormattingEnabled = true;
            this.cbxMagazynI.Location = new System.Drawing.Point(254, 144);
            this.cbxMagazynI.Name = "cbxMagazynI";
            this.cbxMagazynI.Size = new System.Drawing.Size(109, 21);
            this.cbxMagazynI.TabIndex = 8;
            this.cbxMagazynI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kontrahent (dostawca towaru)";
            // 
            // cmdKontrahent
            // 
            this.cmdKontrahent.Image = ((System.Drawing.Image)(resources.GetObject("cmdKontrahent.Image")));
            this.cmdKontrahent.Location = new System.Drawing.Point(495, 9);
            this.cmdKontrahent.Name = "cmdKontrahent";
            this.cmdKontrahent.Size = new System.Drawing.Size(25, 25);
            this.cmdKontrahent.TabIndex = 1;
            this.cmdKontrahent.UseVisualStyleBackColor = true;
            this.cmdKontrahent.Click += new System.EventHandler(this.btnWK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nazwa towaru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Numer kat.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Kategoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Numer seryjny";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Opis";
            // 
            // lblMagazynI
            // 
            this.lblMagazynI.AutoSize = true;
            this.lblMagazynI.Location = new System.Drawing.Point(198, 147);
            this.lblMagazynI.Name = "lblMagazynI";
            this.lblMagazynI.Size = new System.Drawing.Size(50, 13);
            this.lblMagazynI.TabIndex = 49;
            this.lblMagazynI.Text = "Magazyn";
            // 
            // lblStanMagazynu
            // 
            this.lblStanMagazynu.AutoSize = true;
            this.lblStanMagazynu.Location = new System.Drawing.Point(378, 147);
            this.lblStanMagazynu.Name = "lblStanMagazynu";
            this.lblStanMagazynu.Size = new System.Drawing.Size(80, 13);
            this.lblStanMagazynu.TabIndex = 50;
            this.lblStanMagazynu.Text = "Stan magazynu";
            // 
            // lblIlosc
            // 
            this.lblIlosc.AutoSize = true;
            this.lblIlosc.Location = new System.Drawing.Point(16, 146);
            this.lblIlosc.Name = "lblIlosc";
            this.lblIlosc.Size = new System.Drawing.Size(29, 13);
            this.lblIlosc.TabIndex = 51;
            this.lblIlosc.Text = "Ilość";
            // 
            // lblJednostka
            // 
            this.lblJednostka.AutoSize = true;
            this.lblJednostka.Location = new System.Drawing.Point(16, 172);
            this.lblJednostka.Name = "lblJednostka";
            this.lblJednostka.Size = new System.Drawing.Size(56, 13);
            this.lblJednostka.TabIndex = 52;
            this.lblJednostka.Text = "Jednostka";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBrutto);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtNetto);
            this.groupBox1.Location = new System.Drawing.Point(105, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 51);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cena sprzedaży";
            // 
            // txtBrutto
            // 
            this.txtBrutto.Location = new System.Drawing.Point(277, 19);
            this.txtBrutto.MaxLength = 10;
            this.txtBrutto.Name = "txtBrutto";
            this.txtBrutto.Size = new System.Drawing.Size(109, 20);
            this.txtBrutto.TabIndex = 1;
            this.txtBrutto.TextChanged += new System.EventHandler(this.txtBrutto_TextChanged);
            this.txtBrutto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrutto_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(236, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Brutto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Netto";
            // 
            // txtNetto
            // 
            this.txtNetto.Location = new System.Drawing.Point(55, 19);
            this.txtNetto.MaxLength = 10;
            this.txtNetto.Name = "txtNetto";
            this.txtNetto.Size = new System.Drawing.Size(109, 20);
            this.txtNetto.TabIndex = 0;
            this.txtNetto.TextChanged += new System.EventHandler(this.txtCenaSNetto_TextChanged);
            this.txtNetto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrutto_KeyPress);
            // 
            // FINDKind
            // 
            this.AcceptButton = this.Savebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 400);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblJednostka);
            this.Controls.Add(this.txtJednostka);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.lblIlosc);
            this.Controls.Add(this.lblStanMagazynu);
            this.Controls.Add(this.txtStanMagazynu);
            this.Controls.Add(this.cbxMagazynI);
            this.Controls.Add(this.lblMagazynI);
            this.Controls.Add(this.txtDSC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMODEL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MNtextBox);
            this.Controls.Add(this.cbxKategorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdKatDodaj);
            this.Controls.Add(this.txtKAT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MNNtextBox);
            this.Controls.Add(this.cmdKontrahent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.txtKontrahent);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Savebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FINDKind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie nowego towaru";
            this.Load += new System.EventHandler(this.NEWKind_Load);
            this.Click += new System.EventHandler(this.btnWK_Click);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox MNtextBox;
        private System.Windows.Forms.TextBox MNNtextBox;
        private System.Windows.Forms.ComboBox cbxKategorie;
        private System.Windows.Forms.TextBox txtDSC;
        private System.Windows.Forms.TextBox OCNtextBox;
        private System.Windows.Forms.TextBox OCBtextBox;
        private System.Windows.Forms.TextBox txtMODEL;
        private System.Windows.Forms.TextBox txtKAT;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtStanMagazynu;
        private System.Windows.Forms.ComboBox cbxMagazynI;
        private System.Windows.Forms.ComboBox txtJednostka;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.Button cmdKatDodaj;
        private System.Windows.Forms.ComboBox txtKontrahent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdKontrahent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMagazynI;
        private System.Windows.Forms.Label lblStanMagazynu;
        private System.Windows.Forms.Label lblIlosc;
        private System.Windows.Forms.Label lblJednostka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBrutto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNetto;
    }
}