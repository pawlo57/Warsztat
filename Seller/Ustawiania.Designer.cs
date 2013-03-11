namespace Seller
{
    partial class Ustawiania
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
            this.txtNazwaFirmy = new System.Windows.Forms.TextBox();
            this.txtKodPocztowy = new System.Windows.Forms.TextBox();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.txtNumerKontaBankowego = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStawkaVAT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTerminPlatnosci = new System.Windows.Forms.TextBox();
            this.cmdZapisz = new System.Windows.Forms.Button();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiasto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWWW = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.cmdLogo = new System.Windows.Forms.Button();
            this.cmdLogoKasuj = new System.Windows.Forms.Button();
            this.cbFakturaKopia = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNazwaFirmy
            // 
            this.txtNazwaFirmy.Location = new System.Drawing.Point(105, 12);
            this.txtNazwaFirmy.Name = "txtNazwaFirmy";
            this.txtNazwaFirmy.Size = new System.Drawing.Size(323, 20);
            this.txtNazwaFirmy.TabIndex = 0;
            this.txtNazwaFirmy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNazwaFirmy_KeyPress);
            // 
            // txtKodPocztowy
            // 
            this.txtKodPocztowy.Location = new System.Drawing.Point(105, 38);
            this.txtKodPocztowy.Name = "txtKodPocztowy";
            this.txtKodPocztowy.Size = new System.Drawing.Size(73, 20);
            this.txtKodPocztowy.TabIndex = 1;
            this.txtKodPocztowy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdresFirmy_KeyPress);
            // 
            // txtNIP
            // 
            this.txtNIP.Location = new System.Drawing.Point(105, 90);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(323, 20);
            this.txtNIP.TabIndex = 4;
            this.txtNIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIP_KeyPress);
            // 
            // txtNumerKontaBankowego
            // 
            this.txtNumerKontaBankowego.Location = new System.Drawing.Point(105, 116);
            this.txtNumerKontaBankowego.Name = "txtNumerKontaBankowego";
            this.txtNumerKontaBankowego.Size = new System.Drawing.Size(323, 20);
            this.txtNumerKontaBankowego.TabIndex = 5;
            this.txtNumerKontaBankowego.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIP_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(209, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "%";
            // 
            // txtStawkaVAT
            // 
            this.txtStawkaVAT.Location = new System.Drawing.Point(155, 194);
            this.txtStawkaVAT.Name = "txtStawkaVAT";
            this.txtStawkaVAT.Size = new System.Drawing.Size(48, 20);
            this.txtStawkaVAT.TabIndex = 8;
            this.txtStawkaVAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStawkaVAT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(402, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "dni";
            // 
            // txtTerminPlatnosci
            // 
            this.txtTerminPlatnosci.Location = new System.Drawing.Point(330, 194);
            this.txtTerminPlatnosci.Name = "txtTerminPlatnosci";
            this.txtTerminPlatnosci.Size = new System.Drawing.Size(66, 20);
            this.txtTerminPlatnosci.TabIndex = 9;
            this.txtTerminPlatnosci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTerminPlatnosci_KeyPress);
            // 
            // cmdZapisz
            // 
            this.cmdZapisz.Location = new System.Drawing.Point(23, 279);
            this.cmdZapisz.Name = "cmdZapisz";
            this.cmdZapisz.Size = new System.Drawing.Size(403, 23);
            this.cmdZapisz.TabIndex = 0;
            this.cmdZapisz.Text = "Zapisz";
            this.cmdZapisz.UseVisualStyleBackColor = true;
            this.cmdZapisz.Click += new System.EventHandler(this.cmdZapisz_Click);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Location = new System.Drawing.Point(22, 308);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(404, 23);
            this.cmdAnuluj.TabIndex = 1;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nazwa firmy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kod pocztowy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Miasto";
            // 
            // txtMiasto
            // 
            this.txtMiasto.Location = new System.Drawing.Point(251, 38);
            this.txtMiasto.Name = "txtMiasto";
            this.txtMiasto.Size = new System.Drawing.Size(177, 20);
            this.txtMiasto.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ulica";
            // 
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(105, 64);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(323, 20);
            this.txtUlica.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "NIP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Konto bankowe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Strona www";
            // 
            // txtWWW
            // 
            this.txtWWW.Location = new System.Drawing.Point(105, 168);
            this.txtWWW.Name = "txtWWW";
            this.txtWWW.Size = new System.Drawing.Size(124, 20);
            this.txtWWW.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(312, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Stawka VAT dla towarów";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Termin płatności";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Telefon kontakotwy";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(129, 142);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(299, 20);
            this.txtTelefon.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Logo firmy";
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(105, 220);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(158, 20);
            this.txtLogo.TabIndex = 24;
            this.txtLogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogo_KeyPress);
            // 
            // cmdLogo
            // 
            this.cmdLogo.Location = new System.Drawing.Point(269, 218);
            this.cmdLogo.Name = "cmdLogo";
            this.cmdLogo.Size = new System.Drawing.Size(44, 23);
            this.cmdLogo.TabIndex = 25;
            this.cmdLogo.Text = "Ładuj";
            this.cmdLogo.UseVisualStyleBackColor = true;
            this.cmdLogo.Click += new System.EventHandler(this.cmdLogo_Click);
            // 
            // cmdLogoKasuj
            // 
            this.cmdLogoKasuj.Location = new System.Drawing.Point(319, 218);
            this.cmdLogoKasuj.Name = "cmdLogoKasuj";
            this.cmdLogoKasuj.Size = new System.Drawing.Size(44, 23);
            this.cmdLogoKasuj.TabIndex = 26;
            this.cmdLogoKasuj.Text = "Kasuj";
            this.cmdLogoKasuj.UseVisualStyleBackColor = true;
            this.cmdLogoKasuj.Click += new System.EventHandler(this.cmdLogoKasuj_Click);
            // 
            // cbFakturaKopia
            // 
            this.cbFakturaKopia.AutoSize = true;
            this.cbFakturaKopia.Location = new System.Drawing.Point(23, 256);
            this.cbFakturaKopia.Name = "cbFakturaKopia";
            this.cbFakturaKopia.Size = new System.Drawing.Size(121, 17);
            this.cbFakturaKopia.TabIndex = 27;
            this.cbFakturaKopia.Text = "Drukuj kopię faktury";
            this.cbFakturaKopia.UseVisualStyleBackColor = true;
            // 
            // Ustawiania
            // 
            this.AcceptButton = this.cmdZapisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 349);
            this.ControlBox = false;
            this.Controls.Add(this.cbFakturaKopia);
            this.Controls.Add(this.cmdLogoKasuj);
            this.Controls.Add(this.cmdLogo);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTerminPlatnosci);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStawkaVAT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtWWW);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumerKontaBankowego);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNIP);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMiasto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKodPocztowy);
            this.Controls.Add(this.txtNazwaFirmy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdZapisz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ustawiania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia";
            this.Load += new System.EventHandler(this.Ustawiania_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazwaFirmy;
        private System.Windows.Forms.TextBox txtKodPocztowy;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.TextBox txtNumerKontaBankowego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStawkaVAT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTerminPlatnosci;
        private System.Windows.Forms.Button cmdZapisz;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMiasto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWWW;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Button cmdLogo;
        private System.Windows.Forms.Button cmdLogoKasuj;
        private System.Windows.Forms.CheckBox cbFakturaKopia;
    }
}