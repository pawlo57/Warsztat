namespace Seller.CONTROLS
{
    partial class Magaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magaz));
            this.dgwMagazyn = new System.Windows.Forms.DataGridView();
            this.cmdSzukaj = new System.Windows.Forms.Button();
            this.cmdWZ = new System.Windows.Forms.Button();
            this.cmdPz = new System.Windows.Forms.Button();
            this.cmdMagazyny = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdPodgladPzWz = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdEdycjaMagazynu = new System.Windows.Forms.Button();
            this.cmdNowyMagazyn = new System.Windows.Forms.Button();
            this.cmdMagazynSzukaj = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdMagazynPodglad = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMagazyn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMagazyn
            // 
            this.dgwMagazyn.AllowUserToAddRows = false;
            this.dgwMagazyn.AllowUserToDeleteRows = false;
            this.dgwMagazyn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMagazyn.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwMagazyn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwMagazyn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMagazyn.Location = new System.Drawing.Point(218, 14);
            this.dgwMagazyn.MultiSelect = false;
            this.dgwMagazyn.Name = "dgwMagazyn";
            this.dgwMagazyn.ReadOnly = true;
            this.dgwMagazyn.Size = new System.Drawing.Size(775, 518);
            this.dgwMagazyn.TabIndex = 16;
            // 
            // cmdSzukaj
            // 
            this.cmdSzukaj.ForeColor = System.Drawing.Color.Black;
            this.cmdSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdSzukaj.Image")));
            this.cmdSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSzukaj.Location = new System.Drawing.Point(14, 114);
            this.cmdSzukaj.Name = "cmdSzukaj";
            this.cmdSzukaj.Size = new System.Drawing.Size(162, 41);
            this.cmdSzukaj.TabIndex = 15;
            this.cmdSzukaj.Text = "Szukaj";
            this.cmdSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdSzukaj, "Kliknij aby wyszukać dokumenty PZ lub WZ");
            this.cmdSzukaj.UseVisualStyleBackColor = true;
            this.cmdSzukaj.Click += new System.EventHandler(this.cmdSzukaj_Click);
            // 
            // cmdWZ
            // 
            this.cmdWZ.ForeColor = System.Drawing.Color.Black;
            this.cmdWZ.Location = new System.Drawing.Point(14, 48);
            this.cmdWZ.Name = "cmdWZ";
            this.cmdWZ.Size = new System.Drawing.Size(162, 23);
            this.cmdWZ.TabIndex = 14;
            this.cmdWZ.Text = "Wydanie towaru";
            this.toolTip1.SetToolTip(this.cmdWZ, "Kliknij aby wykonąć wydanie towaru z magazynu");
            this.cmdWZ.UseVisualStyleBackColor = true;
            this.cmdWZ.Click += new System.EventHandler(this.cmdWZ_Click);
            // 
            // cmdPz
            // 
            this.cmdPz.ForeColor = System.Drawing.Color.Black;
            this.cmdPz.Location = new System.Drawing.Point(15, 19);
            this.cmdPz.Name = "cmdPz";
            this.cmdPz.Size = new System.Drawing.Size(162, 23);
            this.cmdPz.TabIndex = 13;
            this.cmdPz.Text = "Przyjęcie towaru";
            this.toolTip1.SetToolTip(this.cmdPz, "Kliknij aby wykonąć przyjęcie magazynowe");
            this.cmdPz.UseVisualStyleBackColor = true;
            this.cmdPz.Click += new System.EventHandler(this.cmdPz_Click);
            // 
            // cmdMagazyny
            // 
            this.cmdMagazyny.ForeColor = System.Drawing.Color.Black;
            this.cmdMagazyny.Image = ((System.Drawing.Image)(resources.GetObject("cmdMagazyny.Image")));
            this.cmdMagazyny.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdMagazyny.Location = new System.Drawing.Point(11, 19);
            this.cmdMagazyny.Name = "cmdMagazyny";
            this.cmdMagazyny.Size = new System.Drawing.Size(165, 23);
            this.cmdMagazyny.TabIndex = 17;
            this.cmdMagazyny.Text = "Lista";
            this.cmdMagazyny.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdMagazyny, "Kliknij aby zobaczyć listę magazynów");
            this.cmdMagazyny.UseVisualStyleBackColor = true;
            this.cmdMagazyny.Click += new System.EventHandler(this.cmdMagazyny_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdPodgladPzWz);
            this.groupBox1.Controls.Add(this.cmdPz);
            this.groupBox1.Controls.Add(this.cmdWZ);
            this.groupBox1.Controls.Add(this.cmdSzukaj);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 172);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacje magazynowe";
            // 
            // cmdPodgladPzWz
            // 
            this.cmdPodgladPzWz.ForeColor = System.Drawing.Color.Black;
            this.cmdPodgladPzWz.Location = new System.Drawing.Point(14, 77);
            this.cmdPodgladPzWz.Name = "cmdPodgladPzWz";
            this.cmdPodgladPzWz.Size = new System.Drawing.Size(162, 23);
            this.cmdPodgladPzWz.TabIndex = 16;
            this.cmdPodgladPzWz.Text = "Podgląd";
            this.toolTip1.SetToolTip(this.cmdPodgladPzWz, "Kliknij aby zobaczyć szczególy");
            this.cmdPodgladPzWz.UseVisualStyleBackColor = true;
            this.cmdPodgladPzWz.Click += new System.EventHandler(this.cmdPodgladPzWz_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdEdycjaMagazynu);
            this.groupBox2.Controls.Add(this.cmdNowyMagazyn);
            this.groupBox2.Controls.Add(this.cmdMagazyny);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 114);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baza magazynów";
            // 
            // cmdEdycjaMagazynu
            // 
            this.cmdEdycjaMagazynu.ForeColor = System.Drawing.Color.Black;
            this.cmdEdycjaMagazynu.Image = ((System.Drawing.Image)(resources.GetObject("cmdEdycjaMagazynu.Image")));
            this.cmdEdycjaMagazynu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEdycjaMagazynu.Location = new System.Drawing.Point(11, 77);
            this.cmdEdycjaMagazynu.Name = "cmdEdycjaMagazynu";
            this.cmdEdycjaMagazynu.Size = new System.Drawing.Size(165, 23);
            this.cmdEdycjaMagazynu.TabIndex = 19;
            this.cmdEdycjaMagazynu.Text = "Edycja";
            this.cmdEdycjaMagazynu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdEdycjaMagazynu, "Kliknij aby edytować magazyn");
            this.cmdEdycjaMagazynu.UseVisualStyleBackColor = true;
            this.cmdEdycjaMagazynu.Click += new System.EventHandler(this.cmdEdycjaMagazynu_Click);
            // 
            // cmdNowyMagazyn
            // 
            this.cmdNowyMagazyn.ForeColor = System.Drawing.Color.Black;
            this.cmdNowyMagazyn.Image = ((System.Drawing.Image)(resources.GetObject("cmdNowyMagazyn.Image")));
            this.cmdNowyMagazyn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNowyMagazyn.Location = new System.Drawing.Point(11, 48);
            this.cmdNowyMagazyn.Name = "cmdNowyMagazyn";
            this.cmdNowyMagazyn.Size = new System.Drawing.Size(165, 23);
            this.cmdNowyMagazyn.TabIndex = 18;
            this.cmdNowyMagazyn.Text = "Nowy";
            this.cmdNowyMagazyn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdNowyMagazyn, "Kliknij aby dodać nowy magazyn");
            this.cmdNowyMagazyn.UseVisualStyleBackColor = true;
            this.cmdNowyMagazyn.Click += new System.EventHandler(this.cmdNowyMagazyn_Click);
            // 
            // cmdMagazynSzukaj
            // 
            this.cmdMagazynSzukaj.ForeColor = System.Drawing.Color.Black;
            this.cmdMagazynSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdMagazynSzukaj.Image")));
            this.cmdMagazynSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdMagazynSzukaj.Location = new System.Drawing.Point(14, 23);
            this.cmdMagazynSzukaj.Name = "cmdMagazynSzukaj";
            this.cmdMagazynSzukaj.Size = new System.Drawing.Size(162, 41);
            this.cmdMagazynSzukaj.TabIndex = 17;
            this.cmdMagazynSzukaj.Text = "Wyszukaj towar";
            this.cmdMagazynSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdMagazynSzukaj, "Kliknij aby wyszukać towar znajdujący się na magazynie");
            this.cmdMagazynSzukaj.UseVisualStyleBackColor = true;
            this.cmdMagazynSzukaj.Click += new System.EventHandler(this.cmdMagazynSzukaj_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdMagazynPodglad);
            this.groupBox3.Controls.Add(this.cmdMagazynSzukaj);
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(12, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 105);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Magazyn";
            // 
            // cmdMagazynPodglad
            // 
            this.cmdMagazynPodglad.ForeColor = System.Drawing.Color.Black;
            this.cmdMagazynPodglad.Location = new System.Drawing.Point(14, 70);
            this.cmdMagazynPodglad.Name = "cmdMagazynPodglad";
            this.cmdMagazynPodglad.Size = new System.Drawing.Size(162, 23);
            this.cmdMagazynPodglad.TabIndex = 17;
            this.cmdMagazynPodglad.Text = "Podgląd";
            this.toolTip1.SetToolTip(this.cmdMagazynPodglad, "Kliknij aby zobaczyć szczególy");
            this.cmdMagazynPodglad.UseVisualStyleBackColor = true;
            this.cmdMagazynPodglad.Click += new System.EventHandler(this.cmdMagazynPodglad_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Magaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwMagazyn);
            this.Name = "Magaz";
            this.Size = new System.Drawing.Size(1006, 547);
            this.Load += new System.EventHandler(this.Magaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMagazyn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMagazyn;
        private System.Windows.Forms.Button cmdSzukaj;
        private System.Windows.Forms.Button cmdWZ;
        private System.Windows.Forms.Button cmdPz;
        private System.Windows.Forms.Button cmdMagazyny;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdEdycjaMagazynu;
        private System.Windows.Forms.Button cmdNowyMagazyn;
        private System.Windows.Forms.Button cmdPodgladPzWz;
        private System.Windows.Forms.Button cmdMagazynSzukaj;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdMagazynPodglad;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
