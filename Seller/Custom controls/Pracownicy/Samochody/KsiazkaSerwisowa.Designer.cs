namespace Seller.CONTROLS.Samochody
{
    partial class KsiazkaSerwisowa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KsiazkaSerwisowa));
            this.txtSilnik = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.txtRejestracja = new System.Windows.Forms.TextBox();
            this.txtRokProdukcji = new System.Windows.Forms.TextBox();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.txtPojemnosc = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrzeglad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKontrahent = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdUslugi = new System.Windows.Forms.Button();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSilnik
            // 
            this.txtSilnik.Location = new System.Drawing.Point(390, 77);
            this.txtSilnik.MaxLength = 100;
            this.txtSilnik.Name = "txtSilnik";
            this.txtSilnik.Size = new System.Drawing.Size(140, 20);
            this.txtSilnik.TabIndex = 44;
            this.txtSilnik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(390, 51);
            this.txtVin.MaxLength = 100;
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(140, 20);
            this.txtVin.TabIndex = 44;
            this.txtVin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // txtRejestracja
            // 
            this.txtRejestracja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRejestracja.Location = new System.Drawing.Point(390, 19);
            this.txtRejestracja.MaxLength = 100;
            this.txtRejestracja.Name = "txtRejestracja";
            this.txtRejestracja.Size = new System.Drawing.Size(140, 26);
            this.txtRejestracja.TabIndex = 44;
            this.txtRejestracja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // txtRokProdukcji
            // 
            this.txtRokProdukcji.Location = new System.Drawing.Point(83, 97);
            this.txtRokProdukcji.MaxLength = 4;
            this.txtRokProdukcji.Name = "txtRokProdukcji";
            this.txtRokProdukcji.Size = new System.Drawing.Size(144, 20);
            this.txtRokProdukcji.TabIndex = 44;
            this.txtRokProdukcji.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // txtTyp
            // 
            this.txtTyp.Location = new System.Drawing.Point(390, 100);
            this.txtTyp.MaxLength = 100;
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(140, 20);
            this.txtTyp.TabIndex = 44;
            this.txtTyp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // txtPojemnosc
            // 
            this.txtPojemnosc.Location = new System.Drawing.Point(83, 71);
            this.txtPojemnosc.MaxLength = 100;
            this.txtPojemnosc.Name = "txtPojemnosc";
            this.txtPojemnosc.Size = new System.Drawing.Size(144, 20);
            this.txtPojemnosc.TabIndex = 44;
            this.txtPojemnosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(83, 45);
            this.txtModel.MaxLength = 100;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(144, 20);
            this.txtModel.TabIndex = 44;
            this.txtModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(83, 19);
            this.txtMarka.MaxLength = 100;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(144, 20);
            this.txtMarka.TabIndex = 44;
            this.txtMarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Controls.Add(this.txtPrzeglad);
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.txtKontrahent);
            this.groupBox10.Controls.Add(this.txtOpis);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Controls.Add(this.txtTyp);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.txtSilnik);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.txtVin);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Controls.Add(this.txtRokProdukcji);
            this.groupBox10.Controls.Add(this.txtRejestracja);
            this.groupBox10.Controls.Add(this.txtPojemnosc);
            this.groupBox10.Controls.Add(this.txtModel);
            this.groupBox10.Controls.Add(this.txtMarka);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Location = new System.Drawing.Point(12, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(555, 183);
            this.groupBox10.TabIndex = 63;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Dane pojazdu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Badanie techniczne";
            // 
            // txtPrzeglad
            // 
            this.txtPrzeglad.Location = new System.Drawing.Point(390, 126);
            this.txtPrzeglad.MaxLength = 4;
            this.txtPrzeglad.Name = "txtPrzeglad";
            this.txtPrzeglad.Size = new System.Drawing.Size(140, 20);
            this.txtPrzeglad.TabIndex = 52;
            this.txtPrzeglad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrzeglad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontrahent (włąściciel)";
            // 
            // txtKontrahent
            // 
            this.txtKontrahent.Location = new System.Drawing.Point(357, 152);
            this.txtKontrahent.MaxLength = 4;
            this.txtKontrahent.Name = "txtKontrahent";
            this.txtKontrahent.Size = new System.Drawing.Size(173, 20);
            this.txtKontrahent.TabIndex = 50;
            this.txtKontrahent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(83, 123);
            this.txtOpis.MaxLength = 200;
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(144, 49);
            this.txtOpis.TabIndex = 44;
            this.txtOpis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Typ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Kod silnika";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "VIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Numer rejestracyjny";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Rok produkcji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka";
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 201);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(555, 244);
            this.dgvMain.TabIndex = 64;
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnuluj.Image")));
            this.cmdAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnuluj.Location = new System.Drawing.Point(373, 451);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(194, 23);
            this.cmdAnuluj.TabIndex = 68;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrint.Image")));
            this.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrint.Location = new System.Drawing.Point(12, 451);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(149, 23);
            this.cmdPrint.TabIndex = 69;
            this.cmdPrint.Text = "Drukuj";
            this.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdUslugi
            // 
            this.cmdUslugi.Image = ((System.Drawing.Image)(resources.GetObject("cmdUslugi.Image")));
            this.cmdUslugi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUslugi.Location = new System.Drawing.Point(167, 451);
            this.cmdUslugi.Name = "cmdUslugi";
            this.cmdUslugi.Size = new System.Drawing.Size(200, 23);
            this.cmdUslugi.TabIndex = 70;
            this.cmdUslugi.Text = "Podgląd";
            this.cmdUslugi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdUslugi.UseVisualStyleBackColor = true;
            this.cmdUslugi.Click += new System.EventHandler(this.cmdUslugi_Click);
            // 
            // KsiazkaSerwisowa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 486);
            this.Controls.Add(this.cmdUslugi);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KsiazkaSerwisowa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KsiazkaSerwisowa";
            this.Load += new System.EventHandler(this.KsiazkaSerwisowa_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSilnik;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.TextBox txtRejestracja;
        private System.Windows.Forms.TextBox txtRokProdukcji;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.TextBox txtPojemnosc;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKontrahent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TextBox txtPrzeglad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Button cmdUslugi;
    }
}