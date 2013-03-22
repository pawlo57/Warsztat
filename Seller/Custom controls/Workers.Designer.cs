namespace Seller.CONTROLS
{
    partial class Workers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workers));
            this.dgwWorkers = new System.Windows.Forms.DataGridView();
            this.cmdSzukaj = new System.Windows.Forms.Button();
            this.cmdEdytuj = new System.Windows.Forms.Button();
            this.cmdNowy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdPrint = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdRapDet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdCzasPracy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorkers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwWorkers
            // 
            this.dgwWorkers.AllowUserToAddRows = false;
            this.dgwWorkers.AllowUserToDeleteRows = false;
            this.dgwWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwWorkers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwWorkers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwWorkers.Location = new System.Drawing.Point(216, 14);
            this.dgwWorkers.Name = "dgwWorkers";
            this.dgwWorkers.ReadOnly = true;
            this.dgwWorkers.Size = new System.Drawing.Size(775, 518);
            this.dgwWorkers.TabIndex = 8;
            // 
            // cmdSzukaj
            // 
            this.cmdSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdSzukaj.Image")));
            this.cmdSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSzukaj.Location = new System.Drawing.Point(11, 88);
            this.cmdSzukaj.Name = "cmdSzukaj";
            this.cmdSzukaj.Size = new System.Drawing.Size(168, 35);
            this.cmdSzukaj.TabIndex = 7;
            this.cmdSzukaj.Text = "Szukaj";
            this.cmdSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdSzukaj, "Kliknij aby wyszukać pracowników");
            this.cmdSzukaj.UseVisualStyleBackColor = true;
            this.cmdSzukaj.Click += new System.EventHandler(this.cmdSzukaj_Click);
            // 
            // cmdEdytuj
            // 
            this.cmdEdytuj.Image = ((System.Drawing.Image)(resources.GetObject("cmdEdytuj.Image")));
            this.cmdEdytuj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEdytuj.Location = new System.Drawing.Point(11, 48);
            this.cmdEdytuj.Name = "cmdEdytuj";
            this.cmdEdytuj.Size = new System.Drawing.Size(168, 23);
            this.cmdEdytuj.TabIndex = 6;
            this.cmdEdytuj.Text = "Edytuj";
            this.cmdEdytuj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdEdytuj, "Kliknij aby edytować pracownika");
            this.cmdEdytuj.UseVisualStyleBackColor = true;
            this.cmdEdytuj.Click += new System.EventHandler(this.cmdEdytuj_Click);
            // 
            // cmdNowy
            // 
            this.cmdNowy.Image = ((System.Drawing.Image)(resources.GetObject("cmdNowy.Image")));
            this.cmdNowy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNowy.Location = new System.Drawing.Point(11, 19);
            this.cmdNowy.Name = "cmdNowy";
            this.cmdNowy.Size = new System.Drawing.Size(168, 23);
            this.cmdNowy.TabIndex = 5;
            this.cmdNowy.Text = "Nowy";
            this.cmdNowy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdNowy, "Kliknij aby dodać nowego pracownika");
            this.cmdNowy.UseVisualStyleBackColor = true;
            this.cmdNowy.Click += new System.EventHandler(this.cmdNowy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdNowy);
            this.groupBox1.Controls.Add(this.cmdEdytuj);
            this.groupBox1.Controls.Add(this.cmdSzukaj);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 138);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pracownicy";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // cmdPrint
            // 
            this.cmdPrint.ForeColor = System.Drawing.Color.Black;
            this.cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrint.Image")));
            this.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrint.Location = new System.Drawing.Point(11, 110);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(168, 23);
            this.cmdPrint.TabIndex = 19;
            this.cmdPrint.Text = "Drukuj listę";
            this.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdPrint, "Kliknij aby wydrukować listę");
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdPrint);
            this.groupBox2.Controls.Add(this.cmdRapDet);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cmdCzasPracy);
            this.groupBox2.Location = new System.Drawing.Point(10, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 152);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Czas pracy";
            // 
            // cmdRapDet
            // 
            this.cmdRapDet.Location = new System.Drawing.Point(11, 81);
            this.cmdRapDet.Name = "cmdRapDet";
            this.cmdRapDet.Size = new System.Drawing.Size(168, 23);
            this.cmdRapDet.TabIndex = 2;
            this.cmdRapDet.Text = "Raport szczegółowy";
            this.toolTip1.SetToolTip(this.cmdRapDet, "Kliknij aby wyświetlić szczegółowy raport czasu pracy pracowników");
            this.cmdRapDet.UseVisualStyleBackColor = true;
            this.cmdRapDet.Click += new System.EventHandler(this.cmdRapDet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Raport dzienny";
            this.toolTip1.SetToolTip(this.button1, "Kliknij aby wyświetlić dzienny raport czasu pracy wszystkich pracowników");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCzasPracy
            // 
            this.cmdCzasPracy.Location = new System.Drawing.Point(11, 23);
            this.cmdCzasPracy.Name = "cmdCzasPracy";
            this.cmdCzasPracy.Size = new System.Drawing.Size(168, 23);
            this.cmdCzasPracy.TabIndex = 0;
            this.cmdCzasPracy.Text = "Raport miesięczny";
            this.toolTip1.SetToolTip(this.cmdCzasPracy, "Kliknij aby wyświetlić miesięczny raport czasu pracy wszystkich pracowników");
            this.cmdCzasPracy.UseVisualStyleBackColor = true;
            this.cmdCzasPracy.Click += new System.EventHandler(this.cmdCzasPracy_Click);
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwWorkers);
            this.Name = "Workers";
            this.Size = new System.Drawing.Size(1006, 547);
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorkers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwWorkers;
        private System.Windows.Forms.Button cmdSzukaj;
        private System.Windows.Forms.Button cmdEdytuj;
        private System.Windows.Forms.Button cmdNowy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdCzasPracy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdRapDet;
        private System.Windows.Forms.Button cmdPrint;
    }
}
