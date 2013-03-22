namespace Seller.CONTROLS
{
    partial class Uslugi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uslugi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdView = new System.Windows.Forms.Button();
            this.cmdNowy = new System.Windows.Forms.Button();
            this.cmdEdytuj = new System.Windows.Forms.Button();
            this.cmdSzukaj = new System.Windows.Forms.Button();
            this.dgwUslugi = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUslugi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdView);
            this.groupBox1.Controls.Add(this.cmdNowy);
            this.groupBox1.Controls.Add(this.cmdEdytuj);
            this.groupBox1.Controls.Add(this.cmdSzukaj);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 177);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baza usług/napraw";
            // 
            // cmdView
            // 
            this.cmdView.Image = ((System.Drawing.Image)(resources.GetObject("cmdView.Image")));
            this.cmdView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdView.Location = new System.Drawing.Point(11, 77);
            this.cmdView.Name = "cmdView";
            this.cmdView.Size = new System.Drawing.Size(168, 23);
            this.cmdView.TabIndex = 8;
            this.cmdView.Text = "Podgląd";
            this.cmdView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdView, "Kliknij aby zobaczyć szczegóły wybranej usługi/naprawy");
            this.cmdView.UseVisualStyleBackColor = true;
            this.cmdView.Click += new System.EventHandler(this.cmdView_Click);
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
            this.toolTip1.SetToolTip(this.cmdNowy, "Kliknij aby dodać nową usługę/naprawę");
            this.cmdNowy.UseVisualStyleBackColor = true;
            this.cmdNowy.Click += new System.EventHandler(this.cmdNowy_Click);
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
            this.toolTip1.SetToolTip(this.cmdEdytuj, "Kliknij aby edytować wybraną usługę/naprawę");
            this.cmdEdytuj.UseVisualStyleBackColor = true;
            this.cmdEdytuj.Click += new System.EventHandler(this.cmdEdytuj_Click);
            // 
            // cmdSzukaj
            // 
            this.cmdSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdSzukaj.Image")));
            this.cmdSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSzukaj.Location = new System.Drawing.Point(11, 127);
            this.cmdSzukaj.Name = "cmdSzukaj";
            this.cmdSzukaj.Size = new System.Drawing.Size(168, 35);
            this.cmdSzukaj.TabIndex = 7;
            this.cmdSzukaj.Text = "Szukaj";
            this.cmdSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdSzukaj, "Kliknij aby wyszukać w bazie usług/napraw");
            this.cmdSzukaj.UseVisualStyleBackColor = true;
            this.cmdSzukaj.Click += new System.EventHandler(this.cmdSzukaj_Click);
            // 
            // dgwUslugi
            // 
            this.dgwUslugi.AllowUserToAddRows = false;
            this.dgwUslugi.AllowUserToDeleteRows = false;
            this.dgwUslugi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwUslugi.BackgroundColor = System.Drawing.Color.White;
            this.dgwUslugi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwUslugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUslugi.Location = new System.Drawing.Point(219, 14);
            this.dgwUslugi.MultiSelect = false;
            this.dgwUslugi.Name = "dgwUslugi";
            this.dgwUslugi.ReadOnly = true;
            this.dgwUslugi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwUslugi.Size = new System.Drawing.Size(775, 518);
            this.dgwUslugi.TabIndex = 11;
            // 
            // Uslugi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwUslugi);
            this.Name = "Uslugi";
            this.Size = new System.Drawing.Size(1007, 547);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUslugi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdNowy;
        private System.Windows.Forms.Button cmdEdytuj;
        private System.Windows.Forms.Button cmdSzukaj;
        private System.Windows.Forms.DataGridView dgwUslugi;
        private System.Windows.Forms.Button cmdView;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
