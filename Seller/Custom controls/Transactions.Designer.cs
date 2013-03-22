namespace Seller.CONTROLS
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.dgwTransactions = new System.Windows.Forms.DataGridView();
            this.cmdSzukaj = new System.Windows.Forms.Button();
            this.cmdPodglad = new System.Windows.Forms.Button();
            this.cmdNowy = new System.Windows.Forms.Button();
            this.cmdKoryguj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwTransactions
            // 
            this.dgwTransactions.AllowUserToAddRows = false;
            this.dgwTransactions.AllowUserToDeleteRows = false;
            this.dgwTransactions.AllowUserToOrderColumns = true;
            this.dgwTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwTransactions.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwTransactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTransactions.Location = new System.Drawing.Point(218, 14);
            this.dgwTransactions.Name = "dgwTransactions";
            this.dgwTransactions.ReadOnly = true;
            this.dgwTransactions.Size = new System.Drawing.Size(775, 518);
            this.dgwTransactions.TabIndex = 16;
            // 
            // cmdSzukaj
            // 
            this.cmdSzukaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdSzukaj.ForeColor = System.Drawing.Color.Black;
            this.cmdSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdSzukaj.Image")));
            this.cmdSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSzukaj.Location = new System.Drawing.Point(14, 165);
            this.cmdSzukaj.Name = "cmdSzukaj";
            this.cmdSzukaj.Size = new System.Drawing.Size(159, 39);
            this.cmdSzukaj.TabIndex = 15;
            this.cmdSzukaj.Text = "Szukaj";
            this.cmdSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdSzukaj, "Kliknij aby wyszukać w bazie zleceń");
            this.cmdSzukaj.UseVisualStyleBackColor = true;
            this.cmdSzukaj.Click += new System.EventHandler(this.cmdSzukaj_Click);
            // 
            // cmdPodglad
            // 
            this.cmdPodglad.ForeColor = System.Drawing.Color.Black;
            this.cmdPodglad.Image = ((System.Drawing.Image)(resources.GetObject("cmdPodglad.Image")));
            this.cmdPodglad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPodglad.Location = new System.Drawing.Point(14, 48);
            this.cmdPodglad.Name = "cmdPodglad";
            this.cmdPodglad.Size = new System.Drawing.Size(159, 23);
            this.cmdPodglad.TabIndex = 14;
            this.cmdPodglad.Text = "Podgląd";
            this.cmdPodglad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdPodglad, "Kliknij aby zobaczyć szczególy zlecenia");
            this.cmdPodglad.UseVisualStyleBackColor = true;
            this.cmdPodglad.Click += new System.EventHandler(this.cmdPodglad_Click);
            // 
            // cmdNowy
            // 
            this.cmdNowy.ForeColor = System.Drawing.Color.Black;
            this.cmdNowy.Image = ((System.Drawing.Image)(resources.GetObject("cmdNowy.Image")));
            this.cmdNowy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNowy.Location = new System.Drawing.Point(14, 19);
            this.cmdNowy.Name = "cmdNowy";
            this.cmdNowy.Size = new System.Drawing.Size(159, 23);
            this.cmdNowy.TabIndex = 13;
            this.cmdNowy.Text = "Nowy";
            this.cmdNowy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdNowy, "Kliknij aby dodać nowe zlecenie");
            this.cmdNowy.UseVisualStyleBackColor = true;
            this.cmdNowy.Click += new System.EventHandler(this.cmdNowy_Click);
            // 
            // cmdKoryguj
            // 
            this.cmdKoryguj.ForeColor = System.Drawing.Color.Black;
            this.cmdKoryguj.Image = ((System.Drawing.Image)(resources.GetObject("cmdKoryguj.Image")));
            this.cmdKoryguj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdKoryguj.Location = new System.Drawing.Point(14, 77);
            this.cmdKoryguj.Name = "cmdKoryguj";
            this.cmdKoryguj.Size = new System.Drawing.Size(159, 23);
            this.cmdKoryguj.TabIndex = 17;
            this.cmdKoryguj.Text = "Edycja";
            this.cmdKoryguj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdKoryguj, "Kliknij aby edytować zlecenie");
            this.cmdKoryguj.UseVisualStyleBackColor = true;
            this.cmdKoryguj.Click += new System.EventHandler(this.cmdKoryguj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdPrint);
            this.groupBox1.Controls.Add(this.cmdNowy);
            this.groupBox1.Controls.Add(this.cmdKoryguj);
            this.groupBox1.Controls.Add(this.cmdSzukaj);
            this.groupBox1.Controls.Add(this.cmdPodglad);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 224);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zlecenia/naprawy";
            // 
            // cmdPrint
            // 
            this.cmdPrint.ForeColor = System.Drawing.Color.Black;
            this.cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrint.Image")));
            this.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrint.Location = new System.Drawing.Point(14, 106);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(159, 23);
            this.cmdPrint.TabIndex = 18;
            this.cmdPrint.Text = "Drukuj";
            this.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdPrint, "Kliknij aby drukować zlecenie");
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwTransactions);
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(1006, 547);
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTransactions;
        private System.Windows.Forms.Button cmdSzukaj;
        private System.Windows.Forms.Button cmdPodglad;
        private System.Windows.Forms.Button cmdNowy;
        private System.Windows.Forms.Button cmdKoryguj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdPrint;
    }
}
