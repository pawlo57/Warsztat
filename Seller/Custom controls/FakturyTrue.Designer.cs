namespace Seller.CONTROLS
{
    partial class FakturyTrue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FakturyTrue));
            this.dgwTransactions = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdPrintLst = new System.Windows.Forms.Button();
            this.cmdPodglad = new System.Windows.Forms.Button();
            this.cmdSzukaj = new System.Windows.Forms.Button();
            this.cmdFaktura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdRaportAll = new System.Windows.Forms.Button();
            this.cmdRaportFaktury = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdRaportKoryg = new System.Windows.Forms.Button();
            this.cmdParagony = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.dgwTransactions.TabIndex = 25;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // cmdPrintLst
            // 
            this.cmdPrintLst.Enabled = false;
            this.cmdPrintLst.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrintLst.Image")));
            this.cmdPrintLst.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrintLst.Location = new System.Drawing.Point(8, 77);
            this.cmdPrintLst.Name = "cmdPrintLst";
            this.cmdPrintLst.Size = new System.Drawing.Size(175, 23);
            this.cmdPrintLst.TabIndex = 19;
            this.cmdPrintLst.Text = "Drukuj listę";
            this.cmdPrintLst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdPrintLst, "Kliknij aby wydrukoać fakturę");
            this.cmdPrintLst.UseVisualStyleBackColor = true;
            // 
            // cmdPodglad
            // 
            this.cmdPodglad.Image = ((System.Drawing.Image)(resources.GetObject("cmdPodglad.Image")));
            this.cmdPodglad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPodglad.Location = new System.Drawing.Point(8, 19);
            this.cmdPodglad.Name = "cmdPodglad";
            this.cmdPodglad.Size = new System.Drawing.Size(175, 23);
            this.cmdPodglad.TabIndex = 20;
            this.cmdPodglad.Text = "Podgląd";
            this.cmdPodglad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdPodglad, "Kliknij aby podejrzeć pojazd");
            this.cmdPodglad.UseVisualStyleBackColor = true;
            // 
            // cmdSzukaj
            // 
            this.cmdSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdSzukaj.Image")));
            this.cmdSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSzukaj.Location = new System.Drawing.Point(7, 19);
            this.cmdSzukaj.Name = "cmdSzukaj";
            this.cmdSzukaj.Size = new System.Drawing.Size(175, 27);
            this.cmdSzukaj.TabIndex = 20;
            this.cmdSzukaj.Text = "Szukaj";
            this.cmdSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdSzukaj, "Kliknij aby wyszukać pojazd");
            this.cmdSzukaj.UseVisualStyleBackColor = true;
            // 
            // cmdFaktura
            // 
            this.cmdFaktura.Image = ((System.Drawing.Image)(resources.GetObject("cmdFaktura.Image")));
            this.cmdFaktura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdFaktura.Location = new System.Drawing.Point(8, 48);
            this.cmdFaktura.Name = "cmdFaktura";
            this.cmdFaktura.Size = new System.Drawing.Size(175, 23);
            this.cmdFaktura.TabIndex = 19;
            this.cmdFaktura.Text = "Drukuj";
            this.cmdFaktura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdFaktura, "Kliknij aby drukować");
            this.cmdFaktura.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 236);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raport miesięczny";
            // 
            // cmdRaportAll
            // 
            this.cmdRaportAll.Image = ((System.Drawing.Image)(resources.GetObject("cmdRaportAll.Image")));
            this.cmdRaportAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdRaportAll.Location = new System.Drawing.Point(7, 19);
            this.cmdRaportAll.Name = "cmdRaportAll";
            this.cmdRaportAll.Size = new System.Drawing.Size(160, 25);
            this.cmdRaportAll.TabIndex = 22;
            this.cmdRaportAll.Text = "Wszystkie";
            this.cmdRaportAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdRaportAll, "Kliknij aby wyszukać pojazd");
            this.cmdRaportAll.UseVisualStyleBackColor = true;
            // 
            // cmdRaportFaktury
            // 
            this.cmdRaportFaktury.Image = ((System.Drawing.Image)(resources.GetObject("cmdRaportFaktury.Image")));
            this.cmdRaportFaktury.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdRaportFaktury.Location = new System.Drawing.Point(7, 50);
            this.cmdRaportFaktury.Name = "cmdRaportFaktury";
            this.cmdRaportFaktury.Size = new System.Drawing.Size(160, 25);
            this.cmdRaportFaktury.TabIndex = 23;
            this.cmdRaportFaktury.Text = "Zapłacone";
            this.cmdRaportFaktury.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdRaportFaktury, "Kliknij aby wyszukać pojazd");
            this.cmdRaportFaktury.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdRaportKoryg);
            this.groupBox3.Controls.Add(this.cmdRaportAll);
            this.groupBox3.Controls.Add(this.cmdRaportFaktury);
            this.groupBox3.Location = new System.Drawing.Point(7, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 118);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Faktury";
            // 
            // cmdRaportKoryg
            // 
            this.cmdRaportKoryg.Image = ((System.Drawing.Image)(resources.GetObject("cmdRaportKoryg.Image")));
            this.cmdRaportKoryg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdRaportKoryg.Location = new System.Drawing.Point(7, 81);
            this.cmdRaportKoryg.Name = "cmdRaportKoryg";
            this.cmdRaportKoryg.Size = new System.Drawing.Size(160, 25);
            this.cmdRaportKoryg.TabIndex = 24;
            this.cmdRaportKoryg.Text = "Korygujące";
            this.cmdRaportKoryg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdRaportKoryg, "Kliknij aby wyszukać pojazd");
            this.cmdRaportKoryg.UseVisualStyleBackColor = true;
            // 
            // cmdParagony
            // 
            this.cmdParagony.Image = ((System.Drawing.Image)(resources.GetObject("cmdParagony.Image")));
            this.cmdParagony.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdParagony.Location = new System.Drawing.Point(7, 19);
            this.cmdParagony.Name = "cmdParagony";
            this.cmdParagony.Size = new System.Drawing.Size(160, 25);
            this.cmdParagony.TabIndex = 25;
            this.cmdParagony.Text = "Paragony";
            this.cmdParagony.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdParagony, "Kliknij aby wyszukać pojazd");
            this.cmdParagony.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(7, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Rachunki";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button1, "Kliknij aby wyszukać pojazd");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cmdParagony);
            this.groupBox2.Location = new System.Drawing.Point(7, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 87);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pozostałe";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdSzukaj);
            this.groupBox4.Location = new System.Drawing.Point(15, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 56);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wyszukiwanie zaawansowane";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmdPodglad);
            this.groupBox5.Controls.Add(this.cmdFaktura);
            this.groupBox5.Controls.Add(this.cmdPrintLst);
            this.groupBox5.Location = new System.Drawing.Point(15, 317);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 114);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opcje";
            // 
            // FakturyTrue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgwTransactions);
            this.Controls.Add(this.groupBox1);
            this.Name = "FakturyTrue";
            this.Size = new System.Drawing.Size(1009, 544);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTransactions;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdPrintLst;
        private System.Windows.Forms.Button cmdPodglad;
        private System.Windows.Forms.Button cmdSzukaj;
        private System.Windows.Forms.Button cmdFaktura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdRaportAll;
        private System.Windows.Forms.Button cmdRaportFaktury;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdRaportKoryg;
        private System.Windows.Forms.Button cmdParagony;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}
