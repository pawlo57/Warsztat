namespace Seller.CONTROLS
{
    partial class Faktury
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faktury));
            this.dgwTransactions = new System.Windows.Forms.DataGridView();
            this.cmdSzukaj = new System.Windows.Forms.Button();
            this.cmdFaktura = new System.Windows.Forms.Button();
            this.cmdNowy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdEdycja = new System.Windows.Forms.Button();
            this.cmdPrintLst = new System.Windows.Forms.Button();
            this.cmdPodglad = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdListaNapraw = new System.Windows.Forms.Button();
            this.cmdBadaniaSzukaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwTransactions
            // 
            this.dgwTransactions.AllowUserToAddRows = false;
            this.dgwTransactions.AllowUserToDeleteRows = false;
            this.dgwTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwTransactions.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwTransactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTransactions.Location = new System.Drawing.Point(219, 13);
            this.dgwTransactions.Name = "dgwTransactions";
            this.dgwTransactions.ReadOnly = true;
            this.dgwTransactions.Size = new System.Drawing.Size(775, 518);
            this.dgwTransactions.TabIndex = 21;
            // 
            // cmdSzukaj
            // 
            this.cmdSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdSzukaj.Image")));
            this.cmdSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSzukaj.Location = new System.Drawing.Point(14, 186);
            this.cmdSzukaj.Name = "cmdSzukaj";
            this.cmdSzukaj.Size = new System.Drawing.Size(160, 39);
            this.cmdSzukaj.TabIndex = 20;
            this.cmdSzukaj.Text = "Szukaj";
            this.cmdSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdSzukaj, "Kliknij aby wyszukać pojazd");
            this.cmdSzukaj.UseVisualStyleBackColor = true;
            this.cmdSzukaj.Click += new System.EventHandler(this.cmdSzukaj_Click);
            // 
            // cmdFaktura
            // 
            this.cmdFaktura.Image = ((System.Drawing.Image)(resources.GetObject("cmdFaktura.Image")));
            this.cmdFaktura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdFaktura.Location = new System.Drawing.Point(14, 48);
            this.cmdFaktura.Name = "cmdFaktura";
            this.cmdFaktura.Size = new System.Drawing.Size(160, 23);
            this.cmdFaktura.TabIndex = 19;
            this.cmdFaktura.Text = "Drukuj";
            this.cmdFaktura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdFaktura, "Kliknij aby drukować");
            this.cmdFaktura.UseVisualStyleBackColor = true;
            this.cmdFaktura.Click += new System.EventHandler(this.cmdFaktura_Click);
            // 
            // cmdNowy
            // 
            this.cmdNowy.Image = ((System.Drawing.Image)(resources.GetObject("cmdNowy.Image")));
            this.cmdNowy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNowy.Location = new System.Drawing.Point(14, 19);
            this.cmdNowy.Name = "cmdNowy";
            this.cmdNowy.Size = new System.Drawing.Size(160, 23);
            this.cmdNowy.TabIndex = 18;
            this.cmdNowy.Text = "Dodaj";
            this.cmdNowy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdNowy, "Kliknij aby dodać nowy pojazd");
            this.cmdNowy.UseVisualStyleBackColor = true;
            this.cmdNowy.Click += new System.EventHandler(this.cmdNowy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdEdycja);
            this.groupBox1.Controls.Add(this.cmdPrintLst);
            this.groupBox1.Controls.Add(this.cmdPodglad);
            this.groupBox1.Controls.Add(this.cmdNowy);
            this.groupBox1.Controls.Add(this.cmdSzukaj);
            this.groupBox1.Controls.Add(this.cmdFaktura);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 237);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baza pojazdów";
            // 
            // cmdEdycja
            // 
            this.cmdEdycja.Image = ((System.Drawing.Image)(resources.GetObject("cmdEdycja.Image")));
            this.cmdEdycja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEdycja.Location = new System.Drawing.Point(14, 135);
            this.cmdEdycja.Name = "cmdEdycja";
            this.cmdEdycja.Size = new System.Drawing.Size(160, 23);
            this.cmdEdycja.TabIndex = 21;
            this.cmdEdycja.Text = "Edycja";
            this.cmdEdycja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdEdycja, "Kliknij aby edytować pojazd");
            this.cmdEdycja.UseVisualStyleBackColor = true;
            this.cmdEdycja.Click += new System.EventHandler(this.cmdEdycja_Click);
            // 
            // cmdPrintLst
            // 
            this.cmdPrintLst.Enabled = false;
            this.cmdPrintLst.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrintLst.Image")));
            this.cmdPrintLst.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrintLst.Location = new System.Drawing.Point(14, 77);
            this.cmdPrintLst.Name = "cmdPrintLst";
            this.cmdPrintLst.Size = new System.Drawing.Size(160, 23);
            this.cmdPrintLst.TabIndex = 19;
            this.cmdPrintLst.Text = "Drukuj listę";
            this.cmdPrintLst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdPrintLst, "Kliknij aby wydrukoać fakturę");
            this.cmdPrintLst.UseVisualStyleBackColor = true;
            this.cmdPrintLst.Visible = false;
            //this.cmdPrintLst.Click += new System.EventHandler(this.cmdPrintLst_Click);
            // 
            // cmdPodglad
            // 
            this.cmdPodglad.Image = ((System.Drawing.Image)(resources.GetObject("cmdPodglad.Image")));
            this.cmdPodglad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPodglad.Location = new System.Drawing.Point(14, 106);
            this.cmdPodglad.Name = "cmdPodglad";
            this.cmdPodglad.Size = new System.Drawing.Size(160, 23);
            this.cmdPodglad.TabIndex = 20;
            this.cmdPodglad.Text = "Podgląd";
            this.cmdPodglad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdPodglad, "Kliknij aby podejrzeć pojazd");
            this.cmdPodglad.UseVisualStyleBackColor = true;
            this.cmdPodglad.Click += new System.EventHandler(this.cmdPodglad_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // cmdListaNapraw
            // 
            this.cmdListaNapraw.Image = ((System.Drawing.Image)(resources.GetObject("cmdListaNapraw.Image")));
            this.cmdListaNapraw.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdListaNapraw.Location = new System.Drawing.Point(14, 19);
            this.cmdListaNapraw.Name = "cmdListaNapraw";
            this.cmdListaNapraw.Size = new System.Drawing.Size(160, 23);
            this.cmdListaNapraw.TabIndex = 22;
            this.cmdListaNapraw.Text = "Książka serwisowa";
            this.cmdListaNapraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdListaNapraw, "Kliknij aby otworzyć książkę serwisową pojazdu");
            this.cmdListaNapraw.UseVisualStyleBackColor = true;
            this.cmdListaNapraw.Click += new System.EventHandler(this.cmdListaNapraw_Click);
            // 
            // cmdBadaniaSzukaj
            // 
            this.cmdBadaniaSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdBadaniaSzukaj.Image")));
            this.cmdBadaniaSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdBadaniaSzukaj.Location = new System.Drawing.Point(14, 48);
            this.cmdBadaniaSzukaj.Name = "cmdBadaniaSzukaj";
            this.cmdBadaniaSzukaj.Size = new System.Drawing.Size(160, 23);
            this.cmdBadaniaSzukaj.TabIndex = 22;
            this.cmdBadaniaSzukaj.Text = "Badania techniczne";
            this.cmdBadaniaSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdBadaniaSzukaj, "Kliknij aby wyszukać pojazdy z zadanym okresem badań technicznych");
            this.cmdBadaniaSzukaj.UseVisualStyleBackColor = true;
            this.cmdBadaniaSzukaj.Click += new System.EventHandler(this.cmdBadaniaSzukaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdBadaniaSzukaj);
            this.groupBox2.Controls.Add(this.cmdListaNapraw);
            this.groupBox2.Location = new System.Drawing.Point(15, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 85);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcje";
            // 
            // Faktury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwTransactions);
            this.Name = "Faktury";
            this.Size = new System.Drawing.Size(1009, 544);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTransactions;
        private System.Windows.Forms.Button cmdSzukaj;
        private System.Windows.Forms.Button cmdFaktura;
        private System.Windows.Forms.Button cmdNowy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdPodglad;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdEdycja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdPrintLst;
        private System.Windows.Forms.Button cmdListaNapraw;
        private System.Windows.Forms.Button cmdBadaniaSzukaj;
    }
}
