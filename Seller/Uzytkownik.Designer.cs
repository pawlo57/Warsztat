namespace Seller
{
    partial class Uzytkownik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uzytkownik));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPowtorzHaslo = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstPriv = new System.Windows.Forms.CheckedListBox();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtImie);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imię";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(15, 19);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(145, 20);
            this.txtImie.TabIndex = 0;
            this.txtImie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImie_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNazwisko);
            this.groupBox2.Location = new System.Drawing.Point(193, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(18, 19);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(159, 20);
            this.txtNazwisko.TabIndex = 0;
            this.txtNazwisko.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNazwisko_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHaslo);
            this.groupBox3.Location = new System.Drawing.Point(12, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 53);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hasło";
            // 
            // txtHaslo
            // 
            this.txtHaslo.Location = new System.Drawing.Point(15, 19);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.PasswordChar = '*';
            this.txtHaslo.Size = new System.Drawing.Size(145, 20);
            this.txtHaslo.TabIndex = 0;
            this.txtHaslo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPowtorzHaslo);
            this.groupBox4.Location = new System.Drawing.Point(193, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 53);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Powtórz hasło";
            // 
            // txtPowtorzHaslo
            // 
            this.txtPowtorzHaslo.Location = new System.Drawing.Point(18, 19);
            this.txtPowtorzHaslo.Name = "txtPowtorzHaslo";
            this.txtPowtorzHaslo.PasswordChar = '*';
            this.txtPowtorzHaslo.Size = new System.Drawing.Size(159, 20);
            this.txtPowtorzHaslo.TabIndex = 0;
            this.txtPowtorzHaslo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstPriv);
            this.groupBox5.Location = new System.Drawing.Point(12, 192);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 158);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Uprawnienia";
            // 
            // lstPriv
            // 
            this.lstPriv.FormattingEnabled = true;
            this.lstPriv.Items.AddRange(new object[] {
            "Produkty",
            "Magazyn",
            "Usługi",
            "Pracownicy",
            "Kontrahenci",
            "Baza danych oraz ustawienia programu",
            "Zlecenia",
            "Baza pojazdów"});
            this.lstPriv.Location = new System.Drawing.Point(15, 19);
            this.lstPriv.Name = "lstPriv";
            this.lstPriv.Size = new System.Drawing.Size(343, 124);
            this.lstPriv.TabIndex = 0;
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdDodaj.Image")));
            this.cmdDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdDodaj.Location = new System.Drawing.Point(12, 356);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(375, 23);
            this.cmdDodaj.TabIndex = 6;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdDodaj.UseVisualStyleBackColor = true;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnuluj.Image")));
            this.cmdAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 385);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(375, 23);
            this.cmdAnuluj.TabIndex = 7;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtLogin);
            this.groupBox6.Location = new System.Drawing.Point(12, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(175, 53);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nazwa użytkownika";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(15, 19);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(145, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox1);
            this.groupBox7.Location = new System.Drawing.Point(193, 15);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(194, 53);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aktywny",
            "Nieaktywny"});
            this.comboBox1.Location = new System.Drawing.Point(18, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // Uzytkownik
            // 
            this.AcceptButton = this.cmdDodaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 422);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Uzytkownik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Użytkownik";
            this.Load += new System.EventHandler(this.Uzytkownik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPowtorzHaslo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox lstPriv;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}