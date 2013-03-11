namespace Seller
{
    partial class UslugaDEF
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
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cmdKioniec = new System.Windows.Forms.Button();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrutto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNetto = new System.Windows.Forms.TextBox();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.txtNumer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbConst = new System.Windows.Forms.RadioButton();
            this.rdbVar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxVar = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(91, 142);
            this.txtOpis.MaxLength = 1000;
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(310, 68);
            this.txtOpis.TabIndex = 0;
            this.txtOpis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpis_KeyPress);
            // 
            // cmdKioniec
            // 
            this.cmdKioniec.Location = new System.Drawing.Point(12, 228);
            this.cmdKioniec.Name = "cmdKioniec";
            this.cmdKioniec.Size = new System.Drawing.Size(389, 23);
            this.cmdKioniec.TabIndex = 0;
            this.cmdKioniec.UseVisualStyleBackColor = true;
            this.cmdKioniec.Click += new System.EventHandler(this.cmdKioniec_Click);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 257);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(389, 23);
            this.cmdAnuluj.TabIndex = 1;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(161, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "%";
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(91, 90);
            this.txtVAT.MaxLength = 2;
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(63, 20);
            this.txtVAT.TabIndex = 0;
            this.txtVAT.TextChanged += new System.EventHandler(this.txtNetto_TextChanged);
            this.txtVAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVAT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(161, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "zł";
            // 
            // txtBrutto
            // 
            this.txtBrutto.Location = new System.Drawing.Point(91, 116);
            this.txtBrutto.MaxLength = 100;
            this.txtBrutto.Name = "txtBrutto";
            this.txtBrutto.Size = new System.Drawing.Size(63, 20);
            this.txtBrutto.TabIndex = 0;
            this.txtBrutto.TextChanged += new System.EventHandler(this.txtNetto_TextChanged);
            this.txtBrutto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(160, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "zł";
            // 
            // txtNetto
            // 
            this.txtNetto.Location = new System.Drawing.Point(91, 64);
            this.txtNetto.MaxLength = 100;
            this.txtNetto.Name = "txtNetto";
            this.txtNetto.Size = new System.Drawing.Size(63, 20);
            this.txtNetto.TabIndex = 1;
            this.txtNetto.TextChanged += new System.EventHandler(this.txtNetto_TextChanged);
            this.txtNetto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetto_KeyPress);
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(91, 38);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(310, 20);
            this.txtNazwa.TabIndex = 0;
            this.txtNazwa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNazwa_KeyPress);
            // 
            // txtNumer
            // 
            this.txtNumer.Location = new System.Drawing.Point(91, 12);
            this.txtNumer.Name = "txtNumer";
            this.txtNumer.Size = new System.Drawing.Size(127, 20);
            this.txtNumer.TabIndex = 0;
            this.txtNumer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Numer/kod";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nazwa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cena netto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "VAT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Cena brutto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Opis";
            // 
            // rdbConst
            // 
            this.rdbConst.AutoSize = true;
            this.rdbConst.Checked = true;
            this.rdbConst.Location = new System.Drawing.Point(21, 20);
            this.rdbConst.Name = "rdbConst";
            this.rdbConst.Size = new System.Drawing.Size(83, 17);
            this.rdbConst.TabIndex = 28;
            this.rdbConst.TabStop = true;
            this.rdbConst.Text = "Stała kwota";
            this.rdbConst.UseVisualStyleBackColor = true;
            this.rdbConst.CheckedChanged += new System.EventHandler(this.rdbConst_CheckedChanged);
            // 
            // rdbVar
            // 
            this.rdbVar.AutoSize = true;
            this.rdbVar.Location = new System.Drawing.Point(21, 43);
            this.rdbVar.Name = "rdbVar";
            this.rdbVar.Size = new System.Drawing.Size(64, 17);
            this.rdbVar.TabIndex = 29;
            this.rdbVar.Text = "Cena za";
            this.rdbVar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxVar);
            this.groupBox1.Controls.Add(this.rdbConst);
            this.groupBox1.Controls.Add(this.rdbVar);
            this.groupBox1.Location = new System.Drawing.Point(182, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 78);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Czas";
            // 
            // cbxVar
            // 
            this.cbxVar.Enabled = false;
            this.cbxVar.FormattingEnabled = true;
            this.cbxVar.Location = new System.Drawing.Point(91, 42);
            this.cbxVar.Name = "cbxVar";
            this.cbxVar.Size = new System.Drawing.Size(106, 21);
            this.cbxVar.TabIndex = 30;
            this.cbxVar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxVar_KeyPress);
            // 
            // UslugaDEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 296);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBrutto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNetto);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumer);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdKioniec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UslugaDEF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UslugaDEF";
            this.Load += new System.EventHandler(this.UslugaDEF_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button cmdKioniec;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtBrutto;
        private System.Windows.Forms.TextBox txtNetto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtNumer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbConst;
        private System.Windows.Forms.RadioButton rdbVar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxVar;
    }
}