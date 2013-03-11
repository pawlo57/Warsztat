namespace Seller
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.cmdNowy = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(17, 23);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(404, 20);
            this.txtFirma.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtFirma, "Wpisz tutaj nazwę firmy");
            this.txtFirma.Click += new System.EventHandler(this.txt_Click);
            this.txtFirma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirma_KeyPress);
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(17, 20);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(164, 20);
            this.txtImie.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtImie, "Wpisz imię właściciela firmy lub osoby fizycznej");
            this.txtImie.Click += new System.EventHandler(this.txt_Click);
            this.txtImie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImie_KeyPress);
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(14, 20);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(202, 20);
            this.txtNazwisko.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNazwisko, "Wpisz nazwisko właściciela firmy lub osoby fizycznej");
            this.txtNazwisko.Click += new System.EventHandler(this.txt_Click);
            this.txtNazwisko.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNazwisko_KeyPress);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(17, 19);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(404, 20);
            this.txtAdres.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtAdres, "Wpisz adres firmy lub osoby fizycznej");
            this.txtAdres.Click += new System.EventHandler(this.txt_Click);
            this.txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdres_KeyPress);
            // 
            // txtNIP
            // 
            this.txtNIP.Location = new System.Drawing.Point(19, 21);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(98, 20);
            this.txtNIP.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNIP, "Wpisz numer NIP firmy lub osoby fizycznej");
            this.txtNIP.Click += new System.EventHandler(this.txt_Click);
            this.txtNIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIP_KeyPress);
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(19, 21);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(98, 20);
            this.txtPesel.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtPesel, "Wpisz numer PESEL włąsciciela firmy lub osoby fizycznej");
            this.txtPesel.Click += new System.EventHandler(this.txt_Click);
            this.txtPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIP_KeyPress);
            // 
            // cmdNowy
            // 
            this.cmdNowy.Image = ((System.Drawing.Image)(resources.GetObject("cmdNowy.Image")));
            this.cmdNowy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNowy.Location = new System.Drawing.Point(12, 327);
            this.cmdNowy.Name = "cmdNowy";
            this.cmdNowy.Size = new System.Drawing.Size(438, 23);
            this.cmdNowy.TabIndex = 0;
            this.cmdNowy.Text = "Dodaj";
            this.cmdNowy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdNowy.UseVisualStyleBackColor = true;
            this.cmdNowy.Click += new System.EventHandler(this.cmdNowy_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancel.Image")));
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.Location = new System.Drawing.Point(12, 356);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(438, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Anuluj";
            this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFirma);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nazwa firmy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImie);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 56);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imię";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNazwisko);
            this.groupBox3.Location = new System.Drawing.Point(217, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 56);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nazwisko";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAdres);
            this.groupBox4.Location = new System.Drawing.Point(12, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 61);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adres";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNIP);
            this.groupBox5.Location = new System.Drawing.Point(12, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 56);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "NIP";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPesel);
            this.groupBox6.Location = new System.Drawing.Point(154, 203);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(136, 56);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "PESEL";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtBank);
            this.groupBox7.Location = new System.Drawing.Point(12, 265);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(438, 56);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Numer konta";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(17, 21);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(404, 20);
            this.txtBank.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtBank, "Wpisz numer konta firmy");
            this.txtBank.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(18, 21);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(109, 20);
            this.txtTelefon.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtTelefon, "Wpisz numer PESEL włąsciciela firmy lub osoby fizycznej");
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtTelefon);
            this.groupBox8.Location = new System.Drawing.Point(305, 203);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(145, 56);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Numer Telefonu";
            // 
            // Customer
            // 
            this.AcceptButton = this.cmdNowy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 392);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdNowy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button cmdNowy;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtTelefon;
    }
}