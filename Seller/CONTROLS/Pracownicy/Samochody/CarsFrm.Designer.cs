namespace Seller.CONTROLS.Samochody
{
    partial class CarsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsFrm));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDataW = new System.Windows.Forms.Label();
            this.dtpDataW = new System.Windows.Forms.DateTimePicker();
            this.lblDataP = new System.Windows.Forms.Label();
            this.dtpDataP = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRejestracja = new System.Windows.Forms.TextBox();
            this.lblBadanie = new System.Windows.Forms.Label();
            this.dtpBadanie = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSilnik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRokProdukcji = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPojemnosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdKontrahentDodaj = new System.Windows.Forms.Button();
            this.cmdKontrahent = new System.Windows.Forms.Button();
            this.cbxKontrahent = new System.Windows.Forms.ComboBox();
            this.cmdKoniec = new System.Windows.Forms.Button();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDataW);
            this.groupBox4.Controls.Add(this.dtpDataW);
            this.groupBox4.Controls.Add(this.lblDataP);
            this.groupBox4.Controls.Add(this.dtpDataP);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtOpis);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtRejestracja);
            this.groupBox4.Controls.Add(this.lblBadanie);
            this.groupBox4.Controls.Add(this.dtpBadanie);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtSilnik);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtRokProdukcji);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtTyp);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtVin);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtPojemnosc);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtModel);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtMarka);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cmdKontrahentDodaj);
            this.groupBox4.Controls.Add(this.cmdKontrahent);
            this.groupBox4.Controls.Add(this.cbxKontrahent);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 319);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dane pojazdu";
            // 
            // lblDataW
            // 
            this.lblDataW.AutoSize = true;
            this.lblDataW.Location = new System.Drawing.Point(49, 208);
            this.lblDataW.Name = "lblDataW";
            this.lblDataW.Size = new System.Drawing.Size(72, 13);
            this.lblDataW.TabIndex = 62;
            this.lblDataW.Text = "Data wydania";
            // 
            // dtpDataW
            // 
            this.dtpDataW.Location = new System.Drawing.Point(127, 202);
            this.dtpDataW.Name = "dtpDataW";
            this.dtpDataW.Size = new System.Drawing.Size(144, 20);
            this.dtpDataW.TabIndex = 61;
            this.dtpDataW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxPaliwo_KeyPress);
            // 
            // lblDataP
            // 
            this.lblDataP.AutoSize = true;
            this.lblDataP.Location = new System.Drawing.Point(47, 182);
            this.lblDataP.Name = "lblDataP";
            this.lblDataP.Size = new System.Drawing.Size(74, 13);
            this.lblDataP.TabIndex = 58;
            this.lblDataP.Text = "Data przyjęcia";
            // 
            // dtpDataP
            // 
            this.dtpDataP.Location = new System.Drawing.Point(127, 176);
            this.dtpDataP.Name = "dtpDataP";
            this.dtpDataP.Size = new System.Drawing.Size(144, 20);
            this.dtpDataP.TabIndex = 57;
            this.dtpDataP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxPaliwo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(9, 261);
            this.txtOpis.MaxLength = 200;
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(467, 44);
            this.txtOpis.TabIndex = 10;
            this.txtOpis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPojemnosc_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Numer rejestracyjny (*)";
            // 
            // txtRejestracja
            // 
            this.txtRejestracja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRejestracja.Location = new System.Drawing.Point(290, 225);
            this.txtRejestracja.MaxLength = 100;
            this.txtRejestracja.Name = "txtRejestracja";
            this.txtRejestracja.Size = new System.Drawing.Size(142, 26);
            this.txtRejestracja.TabIndex = 9;
            this.txtRejestracja.Click += new System.EventHandler(this.txtMarka_Click);
            this.txtRejestracja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRejestracja_KeyPress);
            // 
            // lblBadanie
            // 
            this.lblBadanie.AutoSize = true;
            this.lblBadanie.Location = new System.Drawing.Point(20, 156);
            this.lblBadanie.Name = "lblBadanie";
            this.lblBadanie.Size = new System.Drawing.Size(101, 13);
            this.lblBadanie.TabIndex = 52;
            this.lblBadanie.Text = "Badanie techniczne";
            // 
            // dtpBadanie
            // 
            this.dtpBadanie.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dtpBadanie.Location = new System.Drawing.Point(127, 150);
            this.dtpBadanie.Name = "dtpBadanie";
            this.dtpBadanie.Size = new System.Drawing.Size(144, 20);
            this.dtpBadanie.TabIndex = 8;
            this.dtpBadanie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxPaliwo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Kod silnika";
            // 
            // txtSilnik
            // 
            this.txtSilnik.Location = new System.Drawing.Point(127, 124);
            this.txtSilnik.MaxLength = 100;
            this.txtSilnik.Name = "txtSilnik";
            this.txtSilnik.Size = new System.Drawing.Size(144, 20);
            this.txtSilnik.TabIndex = 7;
            this.txtSilnik.Click += new System.EventHandler(this.txtMarka_Click);
            this.txtSilnik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPojemnosc_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Rok produkcji (*)";
            // 
            // txtRokProdukcji
            // 
            this.txtRokProdukcji.Location = new System.Drawing.Point(127, 98);
            this.txtRokProdukcji.MaxLength = 4;
            this.txtRokProdukcji.Name = "txtRokProdukcji";
            this.txtRokProdukcji.Size = new System.Drawing.Size(144, 20);
            this.txtRokProdukcji.TabIndex = 5;
            this.txtRokProdukcji.Click += new System.EventHandler(this.txtMarka_Click);
            this.txtRokProdukcji.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRokProdukcji_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Typ";
            // 
            // txtTyp
            // 
            this.txtTyp.Location = new System.Drawing.Point(332, 98);
            this.txtTyp.MaxLength = 100;
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(144, 20);
            this.txtTyp.TabIndex = 6;
            this.txtTyp.Click += new System.EventHandler(this.txtMarka_Click);
            this.txtTyp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPojemnosc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "VIN";
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(332, 72);
            this.txtVin.MaxLength = 100;
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(144, 20);
            this.txtVin.TabIndex = 4;
            this.txtVin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRejestracja_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Pojemność silnika (*)";
            // 
            // txtPojemnosc
            // 
            this.txtPojemnosc.Location = new System.Drawing.Point(127, 72);
            this.txtPojemnosc.MaxLength = 100;
            this.txtPojemnosc.Name = "txtPojemnosc";
            this.txtPojemnosc.Size = new System.Drawing.Size(144, 20);
            this.txtPojemnosc.TabIndex = 3;
            this.txtPojemnosc.Click += new System.EventHandler(this.txtMarka_Click);
            this.txtPojemnosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPojemnosc_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Model (*)";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(332, 47);
            this.txtModel.MaxLength = 100;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(144, 20);
            this.txtModel.TabIndex = 2;
            this.txtModel.Click += new System.EventHandler(this.txtMarka_Click);
            this.txtModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPojemnosc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Marka (*)";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(127, 46);
            this.txtMarka.MaxLength = 100;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(144, 20);
            this.txtMarka.TabIndex = 1;
            this.txtMarka.Click += new System.EventHandler(this.txtMarka_Click);
            this.txtMarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Kontrahent (właściciel)";
            // 
            // cmdKontrahentDodaj
            // 
            this.cmdKontrahentDodaj.Location = new System.Drawing.Point(420, 16);
            this.cmdKontrahentDodaj.Name = "cmdKontrahentDodaj";
            this.cmdKontrahentDodaj.Size = new System.Drawing.Size(25, 25);
            this.cmdKontrahentDodaj.TabIndex = 42;
            this.cmdKontrahentDodaj.Text = "+";
            this.cmdKontrahentDodaj.UseVisualStyleBackColor = true;
            this.cmdKontrahentDodaj.Click += new System.EventHandler(this.cmdKontrahentDodaj_Click);
            // 
            // cmdKontrahent
            // 
            this.cmdKontrahent.Image = ((System.Drawing.Image)(resources.GetObject("cmdKontrahent.Image")));
            this.cmdKontrahent.Location = new System.Drawing.Point(451, 16);
            this.cmdKontrahent.Name = "cmdKontrahent";
            this.cmdKontrahent.Size = new System.Drawing.Size(25, 25);
            this.cmdKontrahent.TabIndex = 41;
            this.cmdKontrahent.UseVisualStyleBackColor = true;
            this.cmdKontrahent.Click += new System.EventHandler(this.cmdKontrahent_Click);
            // 
            // cbxKontrahent
            // 
            this.cbxKontrahent.FormattingEnabled = true;
            this.cbxKontrahent.Location = new System.Drawing.Point(127, 19);
            this.cbxKontrahent.Name = "cbxKontrahent";
            this.cbxKontrahent.Size = new System.Drawing.Size(287, 21);
            this.cbxKontrahent.TabIndex = 0;
            this.cbxKontrahent.SelectedIndexChanged += new System.EventHandler(this.cbxKontrahent_SelectedIndexChanged);
            this.cbxKontrahent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxKontrahent_KeyPress);
            // 
            // cmdKoniec
            // 
            this.cmdKoniec.Location = new System.Drawing.Point(12, 337);
            this.cmdKoniec.Name = "cmdKoniec";
            this.cmdKoniec.Size = new System.Drawing.Size(485, 23);
            this.cmdKoniec.TabIndex = 0;
            this.cmdKoniec.Text = "button1";
            this.cmdKoniec.UseVisualStyleBackColor = true;
            this.cmdKoniec.Click += new System.EventHandler(this.cmdKoniec_Click);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 366);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(485, 23);
            this.cmdAnuluj.TabIndex = 1;
            this.cmdAnuluj.Text = "button2";
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // CarsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 401);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdKoniec);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CarsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CarsFrm";
            this.Load += new System.EventHandler(this.CarsFrm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cmdKontrahentDodaj;
        private System.Windows.Forms.Button cmdKontrahent;
        private System.Windows.Forms.ComboBox cbxKontrahent;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPojemnosc;
        private System.Windows.Forms.TextBox txtRejestracja;
        private System.Windows.Forms.TextBox txtRokProdukcji;
        private System.Windows.Forms.TextBox txtSilnik;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button cmdKoniec;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.DateTimePicker dtpBadanie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBadanie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDataP;
        private System.Windows.Forms.DateTimePicker dtpDataP;
        private System.Windows.Forms.Label lblDataW;
        private System.Windows.Forms.DateTimePicker dtpDataW;
    }
}