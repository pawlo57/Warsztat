namespace Seller.CONTROLS
{
    partial class Programs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programs));
            this.cmdNowy = new System.Windows.Forms.Button();
            this.cmdEdytuj = new System.Windows.Forms.Button();
            this.cmdSzukaj = new System.Windows.Forms.Button();
            this.dgwProdukty = new System.Windows.Forms.DataGridView();
            this.Kategorie = new System.Windows.Forms.GroupBox();
            this.cmdListaKat = new System.Windows.Forms.Button();
            this.cmdEdytujKat = new System.Windows.Forms.Button();
            this.cmdNowaKat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdPodglad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProdukty)).BeginInit();
            this.Kategorie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdNowy
            // 
            this.cmdNowy.Image = ((System.Drawing.Image)(resources.GetObject("cmdNowy.Image")));
            this.cmdNowy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNowy.Location = new System.Drawing.Point(13, 19);
            this.cmdNowy.Name = "cmdNowy";
            this.cmdNowy.Size = new System.Drawing.Size(149, 23);
            this.cmdNowy.TabIndex = 0;
            this.cmdNowy.Text = "Nowy";
            this.cmdNowy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdNowy, "Kliknij aby dodać  do bazy");
            this.cmdNowy.UseVisualStyleBackColor = true;
            this.cmdNowy.Click += new System.EventHandler(this.cmdNowy_Click);
            // 
            // cmdEdytuj
            // 
            this.cmdEdytuj.Image = ((System.Drawing.Image)(resources.GetObject("cmdEdytuj.Image")));
            this.cmdEdytuj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEdytuj.Location = new System.Drawing.Point(13, 48);
            this.cmdEdytuj.Name = "cmdEdytuj";
            this.cmdEdytuj.Size = new System.Drawing.Size(149, 23);
            this.cmdEdytuj.TabIndex = 1;
            this.cmdEdytuj.Text = "Edytuj";
            this.cmdEdytuj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdEdytuj, "Kliknij aby edytować");
            this.cmdEdytuj.UseVisualStyleBackColor = true;
            this.cmdEdytuj.Click += new System.EventHandler(this.cmdEdytuj_Click);
            // 
            // cmdSzukaj
            // 
            this.cmdSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdSzukaj.Image")));
            this.cmdSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSzukaj.Location = new System.Drawing.Point(13, 121);
            this.cmdSzukaj.Name = "cmdSzukaj";
            this.cmdSzukaj.Size = new System.Drawing.Size(149, 39);
            this.cmdSzukaj.TabIndex = 2;
            this.cmdSzukaj.Text = "Szukaj";
            this.cmdSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdSzukaj, "Kliknij aby wyszukać w bazie części");
            this.cmdSzukaj.UseVisualStyleBackColor = true;
            this.cmdSzukaj.Click += new System.EventHandler(this.cmdSzukaj_Click);
            // 
            // dgwProdukty
            // 
            this.dgwProdukty.AllowUserToAddRows = false;
            this.dgwProdukty.AllowUserToDeleteRows = false;
            this.dgwProdukty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwProdukty.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwProdukty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProdukty.Location = new System.Drawing.Point(214, 14);
            this.dgwProdukty.Name = "dgwProdukty";
            this.dgwProdukty.ReadOnly = true;
            this.dgwProdukty.Size = new System.Drawing.Size(778, 628);
            this.dgwProdukty.TabIndex = 3;
            // 
            // Kategorie
            // 
            this.Kategorie.Controls.Add(this.cmdListaKat);
            this.Kategorie.Controls.Add(this.cmdEdytujKat);
            this.Kategorie.Controls.Add(this.cmdNowaKat);
            this.Kategorie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Kategorie.Location = new System.Drawing.Point(13, 197);
            this.Kategorie.Name = "Kategorie";
            this.Kategorie.Size = new System.Drawing.Size(174, 150);
            this.Kategorie.TabIndex = 4;
            this.Kategorie.TabStop = false;
            this.Kategorie.Text = "Kategorie";
            // 
            // cmdListaKat
            // 
            this.cmdListaKat.Image = ((System.Drawing.Image)(resources.GetObject("cmdListaKat.Image")));
            this.cmdListaKat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdListaKat.Location = new System.Drawing.Point(13, 93);
            this.cmdListaKat.Name = "cmdListaKat";
            this.cmdListaKat.Size = new System.Drawing.Size(149, 39);
            this.cmdListaKat.TabIndex = 6;
            this.cmdListaKat.Text = "Lista kategorii";
            this.cmdListaKat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdListaKat, "Kliknij aby wyświetlić listę kategorii części");
            this.cmdListaKat.UseVisualStyleBackColor = true;
            this.cmdListaKat.Click += new System.EventHandler(this.cmdListaKat_Click);
            // 
            // cmdEdytujKat
            // 
            this.cmdEdytujKat.Image = ((System.Drawing.Image)(resources.GetObject("cmdEdytujKat.Image")));
            this.cmdEdytujKat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEdytujKat.Location = new System.Drawing.Point(13, 48);
            this.cmdEdytujKat.Name = "cmdEdytujKat";
            this.cmdEdytujKat.Size = new System.Drawing.Size(149, 23);
            this.cmdEdytujKat.TabIndex = 6;
            this.cmdEdytujKat.Text = "Edytuj";
            this.cmdEdytujKat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdEdytujKat, "Kliknij aby edytować kategorię części");
            this.cmdEdytujKat.UseVisualStyleBackColor = true;
            this.cmdEdytujKat.Click += new System.EventHandler(this.cmdEdytujKat_Click);
            // 
            // cmdNowaKat
            // 
            this.cmdNowaKat.Image = ((System.Drawing.Image)(resources.GetObject("cmdNowaKat.Image")));
            this.cmdNowaKat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNowaKat.Location = new System.Drawing.Point(13, 19);
            this.cmdNowaKat.Name = "cmdNowaKat";
            this.cmdNowaKat.Size = new System.Drawing.Size(149, 23);
            this.cmdNowaKat.TabIndex = 5;
            this.cmdNowaKat.Text = "Nowa";
            this.cmdNowaKat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdNowaKat, "Kliknij aby dodać nową kategorię części");
            this.cmdNowaKat.UseVisualStyleBackColor = true;
            this.cmdNowaKat.Click += new System.EventHandler(this.cmdNowaKat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdPodglad);
            this.groupBox1.Controls.Add(this.cmdNowy);
            this.groupBox1.Controls.Add(this.cmdEdytuj);
            this.groupBox1.Controls.Add(this.cmdSzukaj);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baza części";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // cmdPodglad
            // 
            this.cmdPodglad.Image = ((System.Drawing.Image)(resources.GetObject("cmdPodglad.Image")));
            this.cmdPodglad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPodglad.Location = new System.Drawing.Point(13, 77);
            this.cmdPodglad.Name = "cmdPodglad";
            this.cmdPodglad.Size = new System.Drawing.Size(149, 23);
            this.cmdPodglad.TabIndex = 3;
            this.cmdPodglad.Text = "Podgląd";
            this.cmdPodglad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdPodglad, "Kliknij aby edytować");
            this.cmdPodglad.UseVisualStyleBackColor = true;
            this.cmdPodglad.Click += new System.EventHandler(this.cmdPodglad_Click);
            // 
            // Programs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Kategorie);
            this.Controls.Add(this.dgwProdukty);
            this.Name = "Programs";
            this.Size = new System.Drawing.Size(1008, 658);
            this.Load += new System.EventHandler(this.Programs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProdukty)).EndInit();
            this.Kategorie.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdNowy;
        private System.Windows.Forms.Button cmdEdytuj;
        private System.Windows.Forms.Button cmdSzukaj;
        private System.Windows.Forms.DataGridView dgwProdukty;
        private System.Windows.Forms.GroupBox Kategorie;
        private System.Windows.Forms.Button cmdNowaKat;
        private System.Windows.Forms.Button cmdEdytujKat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdListaKat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdPodglad;
    }
}
