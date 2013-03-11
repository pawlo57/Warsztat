namespace Seller
{
    partial class FindWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindWorker));
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.cmdNowy = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dddNumerKonta = new System.Windows.Forms.GroupBox();
            this.txtNumerKonta = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.dddNumerKonta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(18, 19);
            this.txtImie.MaxLength = 200;
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(153, 20);
            this.txtImie.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtImie, "Wpisz imię pracownika");
            this.txtImie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImie_KeyPress);
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(17, 19);
            this.txtNazwisko.MaxLength = 200;
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(153, 20);
            this.txtNazwisko.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNazwisko, "Wpisz nazwisko pracownika");
            this.txtNazwisko.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImie_KeyPress);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(18, 19);
            this.txtAdres.MaxLength = 200;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(347, 20);
            this.txtAdres.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtAdres, "Wpisz adres pracownika");
            this.txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdres_KeyPress);
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(18, 19);
            this.txtPesel.MaxLength = 200;
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(153, 20);
            this.txtPesel.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtPesel, "Wpisz pesel pracownika");
            this.txtPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesel_KeyPress);
            // 
            // txtNIP
            // 
            this.txtNIP.Location = new System.Drawing.Point(17, 19);
            this.txtNIP.MaxLength = 200;
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(153, 20);
            this.txtNIP.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNIP, "Wpisz nip pracownika");
            this.txtNIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIP_KeyPress);
            // 
            // cmdNowy
            // 
            this.cmdNowy.Image = ((System.Drawing.Image)(resources.GetObject("cmdNowy.Image")));
            this.cmdNowy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNowy.Location = new System.Drawing.Point(12, 278);
            this.cmdNowy.Name = "cmdNowy";
            this.cmdNowy.Size = new System.Drawing.Size(382, 23);
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
            this.cmdCancel.Location = new System.Drawing.Point(12, 307);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(382, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Anuluj";
            this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "(*) - opcjonalny wpis w przypadku osoby fizycznej";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImie);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 52);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imię";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNazwisko);
            this.groupBox3.Location = new System.Drawing.Point(207, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 52);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nazwisko";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAdres);
            this.groupBox4.Location = new System.Drawing.Point(12, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 52);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adres";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPesel);
            this.groupBox5.Location = new System.Drawing.Point(12, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(187, 52);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PESEL";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtNIP);
            this.groupBox6.Location = new System.Drawing.Point(207, 128);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(187, 52);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "NIP (*)";
            // 
            // dddNumerKonta
            // 
            this.dddNumerKonta.Controls.Add(this.txtNumerKonta);
            this.dddNumerKonta.Location = new System.Drawing.Point(12, 186);
            this.dddNumerKonta.Name = "dddNumerKonta";
            this.dddNumerKonta.Size = new System.Drawing.Size(382, 52);
            this.dddNumerKonta.TabIndex = 11;
            this.dddNumerKonta.TabStop = false;
            this.dddNumerKonta.Text = "Numer konta bankowego (*)";
            // 
            // txtNumerKonta
            // 
            this.txtNumerKonta.Location = new System.Drawing.Point(18, 19);
            this.txtNumerKonta.MaxLength = 200;
            this.txtNumerKonta.Name = "txtNumerKonta";
            this.txtNumerKonta.Size = new System.Drawing.Size(347, 20);
            this.txtNumerKonta.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNumerKonta, "Wpisz numer konta pracownika");
            // 
            // FindWorker
            // 
            this.AcceptButton = this.cmdNowy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 343);
            this.ControlBox = false;
            this.Controls.Add(this.dddNumerKonta);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdNowy);
            this.Controls.Add(this.cmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FindWorker";
            this.Load += new System.EventHandler(this.FindWorker_Load);
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
            this.dddNumerKonta.ResumeLayout(false);
            this.dddNumerKonta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.Button cmdNowy;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox dddNumerKonta;
        private System.Windows.Forms.TextBox txtNumerKonta;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}