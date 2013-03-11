namespace Seller.CONTROLS.UslugiCtrl
{
    partial class UslugaPrc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UslugaPrc));
            this.cmdPracownikDodaj = new System.Windows.Forms.Button();
            this.cmdPracownikSearch = new System.Windows.Forms.Button();
            this.cbxPracownik = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCzas = new System.Windows.Forms.TextBox();
            this.cmdUslugaDodaj = new System.Windows.Forms.Button();
            this.cmdUslugaFind = new System.Windows.Forms.Button();
            this.cbxUslugi = new System.Windows.Forms.ComboBox();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.cmdKioniec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVar = new System.Windows.Forms.TextBox();
            this.txtKOszt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdPracownikDodaj
            // 
            this.cmdPracownikDodaj.Location = new System.Drawing.Point(435, 36);
            this.cmdPracownikDodaj.Name = "cmdPracownikDodaj";
            this.cmdPracownikDodaj.Size = new System.Drawing.Size(25, 25);
            this.cmdPracownikDodaj.TabIndex = 37;
            this.cmdPracownikDodaj.Text = "+";
            this.cmdPracownikDodaj.UseVisualStyleBackColor = true;
            this.cmdPracownikDodaj.Click += new System.EventHandler(this.cmdPracownikDodaj_Click);
            // 
            // cmdPracownikSearch
            // 
            this.cmdPracownikSearch.Image = ((System.Drawing.Image)(resources.GetObject("cmdPracownikSearch.Image")));
            this.cmdPracownikSearch.Location = new System.Drawing.Point(466, 36);
            this.cmdPracownikSearch.Name = "cmdPracownikSearch";
            this.cmdPracownikSearch.Size = new System.Drawing.Size(25, 25);
            this.cmdPracownikSearch.TabIndex = 35;
            this.cmdPracownikSearch.UseVisualStyleBackColor = true;
            this.cmdPracownikSearch.Click += new System.EventHandler(this.cmdPracownikSearch_Click);
            // 
            // cbxPracownik
            // 
            this.cbxPracownik.DisplayMember = "Wyszukaj lub dodaj";
            this.cbxPracownik.FormattingEnabled = true;
            this.cbxPracownik.Location = new System.Drawing.Point(241, 39);
            this.cbxPracownik.Name = "cbxPracownik";
            this.cbxPracownik.Size = new System.Drawing.Size(188, 21);
            this.cbxPracownik.TabIndex = 0;
            this.cbxPracownik.Text = "Wyszukaj lub dodaj";
            this.cbxPracownik.SelectedIndexChanged += new System.EventHandler(this.cbxPracownik_SelectedIndexChanged);
            this.cbxPracownik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxUslugi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(238, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "jednostka";
            // 
            // txtCzas
            // 
            this.txtCzas.Location = new System.Drawing.Point(152, 66);
            this.txtCzas.MaxLength = 100;
            this.txtCzas.Name = "txtCzas";
            this.txtCzas.Size = new System.Drawing.Size(63, 20);
            this.txtCzas.TabIndex = 0;
            this.txtCzas.TextChanged += new System.EventHandler(this.txtCzas_TextChanged);
            this.txtCzas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCzas_KeyPress);
            // 
            // cmdUslugaDodaj
            // 
            this.cmdUslugaDodaj.Location = new System.Drawing.Point(435, 9);
            this.cmdUslugaDodaj.Name = "cmdUslugaDodaj";
            this.cmdUslugaDodaj.Size = new System.Drawing.Size(25, 25);
            this.cmdUslugaDodaj.TabIndex = 39;
            this.cmdUslugaDodaj.Text = "+";
            this.cmdUslugaDodaj.UseVisualStyleBackColor = true;
            this.cmdUslugaDodaj.Click += new System.EventHandler(this.cmdUslugaDodaj_Click);
            // 
            // cmdUslugaFind
            // 
            this.cmdUslugaFind.Image = ((System.Drawing.Image)(resources.GetObject("cmdUslugaFind.Image")));
            this.cmdUslugaFind.Location = new System.Drawing.Point(466, 9);
            this.cmdUslugaFind.Name = "cmdUslugaFind";
            this.cmdUslugaFind.Size = new System.Drawing.Size(25, 25);
            this.cmdUslugaFind.TabIndex = 38;
            this.cmdUslugaFind.UseVisualStyleBackColor = true;
            this.cmdUslugaFind.Click += new System.EventHandler(this.cmdUslugaFind_Click);
            // 
            // cbxUslugi
            // 
            this.cbxUslugi.FormattingEnabled = true;
            this.cbxUslugi.Location = new System.Drawing.Point(126, 12);
            this.cbxUslugi.Name = "cbxUslugi";
            this.cbxUslugi.Size = new System.Drawing.Size(303, 21);
            this.cbxUslugi.TabIndex = 0;
            this.cbxUslugi.Text = "Wyszukaj lub dodaj";
            this.cbxUslugi.SelectedIndexChanged += new System.EventHandler(this.cbxUslugi_SelectedIndexChanged);
            this.cbxUslugi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxUslugi_KeyPress);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Location = new System.Drawing.Point(22, 158);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(469, 23);
            this.cmdAnuluj.TabIndex = 1;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // cmdKioniec
            // 
            this.cmdKioniec.Location = new System.Drawing.Point(22, 129);
            this.cmdKioniec.Name = "cmdKioniec";
            this.cmdKioniec.Size = new System.Drawing.Size(469, 23);
            this.cmdKioniec.TabIndex = 0;
            this.cmdKioniec.UseVisualStyleBackColor = true;
            this.cmdKioniec.Click += new System.EventHandler(this.cmdKioniec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Usługa/naprawa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Pracownik/mechanik (wykonawca naprawy)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Czas wykonania naprawy";
            // 
            // txtVar
            // 
            this.txtVar.Location = new System.Drawing.Point(297, 66);
            this.txtVar.Name = "txtVar";
            this.txtVar.Size = new System.Drawing.Size(90, 20);
            this.txtVar.TabIndex = 42;
            this.txtVar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVar_KeyPress);
            // 
            // txtKOszt
            // 
            this.txtKOszt.Location = new System.Drawing.Point(152, 92);
            this.txtKOszt.Name = "txtKOszt";
            this.txtKOszt.Size = new System.Drawing.Size(139, 20);
            this.txtKOszt.TabIndex = 44;
            this.txtKOszt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(19, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Całkowity koszt usługi";
            // 
            // UslugaPrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 197);
            this.Controls.Add(this.txtKOszt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdPracownikSearch);
            this.Controls.Add(this.txtCzas);
            this.Controls.Add(this.cmdPracownikDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdUslugaFind);
            this.Controls.Add(this.cbxPracownik);
            this.Controls.Add(this.cmdUslugaDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cbxUslugi);
            this.Controls.Add(this.cmdKioniec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UslugaPrc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UslugaPrc";
            this.Load += new System.EventHandler(this.UslugaPrc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPracownikDodaj;
        private System.Windows.Forms.Button cmdPracownikSearch;
        private System.Windows.Forms.ComboBox cbxPracownik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCzas;
        private System.Windows.Forms.ComboBox cbxUslugi;
        private System.Windows.Forms.Button cmdUslugaDodaj;
        private System.Windows.Forms.Button cmdUslugaFind;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.Button cmdKioniec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVar;
        private System.Windows.Forms.TextBox txtKOszt;
        private System.Windows.Forms.Label label5;
    }
}