namespace Seller
{
    partial class Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            this.cbxTowary = new System.Windows.Forms.ComboBox();
            this.cmdTowaryUsun = new System.Windows.Forms.Button();
            this.cmdTowaryDodaj = new System.Windows.Forms.Button();
            this.cmdTowaryPodgląd = new System.Windows.Forms.Button();
            this.cmdZamknij = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTowary
            // 
            this.cbxTowary.FormattingEnabled = true;
            this.cbxTowary.Location = new System.Drawing.Point(14, 440);
            this.cbxTowary.Name = "cbxTowary";
            this.cbxTowary.Size = new System.Drawing.Size(354, 21);
            this.cbxTowary.TabIndex = 37;
            this.cbxTowary.SelectedIndexChanged += new System.EventHandler(this.cbxTowary_SelectedIndexChanged);
            // 
            // cmdTowaryUsun
            // 
            this.cmdTowaryUsun.Image = ((System.Drawing.Image)(resources.GetObject("cmdTowaryUsun.Image")));
            this.cmdTowaryUsun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdTowaryUsun.Location = new System.Drawing.Point(547, 438);
            this.cmdTowaryUsun.Name = "cmdTowaryUsun";
            this.cmdTowaryUsun.Size = new System.Drawing.Size(86, 23);
            this.cmdTowaryUsun.TabIndex = 35;
            this.cmdTowaryUsun.Text = "Usuń";
            this.cmdTowaryUsun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdTowaryUsun.UseVisualStyleBackColor = true;
            this.cmdTowaryUsun.Click += new System.EventHandler(this.cmdTowaryUsun_Click);
            // 
            // cmdTowaryDodaj
            // 
            this.cmdTowaryDodaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdTowaryDodaj.Image")));
            this.cmdTowaryDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdTowaryDodaj.Location = new System.Drawing.Point(455, 438);
            this.cmdTowaryDodaj.Name = "cmdTowaryDodaj";
            this.cmdTowaryDodaj.Size = new System.Drawing.Size(86, 23);
            this.cmdTowaryDodaj.TabIndex = 34;
            this.cmdTowaryDodaj.Text = "Dodaj";
            this.cmdTowaryDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdTowaryDodaj.UseVisualStyleBackColor = true;
            this.cmdTowaryDodaj.Click += new System.EventHandler(this.cmdTowaryDodaj_Click);
            // 
            // cmdTowaryPodgląd
            // 
            this.cmdTowaryPodgląd.Image = ((System.Drawing.Image)(resources.GetObject("cmdTowaryPodgląd.Image")));
            this.cmdTowaryPodgląd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdTowaryPodgląd.Location = new System.Drawing.Point(374, 438);
            this.cmdTowaryPodgląd.Name = "cmdTowaryPodgląd";
            this.cmdTowaryPodgląd.Size = new System.Drawing.Size(75, 23);
            this.cmdTowaryPodgląd.TabIndex = 36;
            this.cmdTowaryPodgląd.Text = "Podgląd";
            this.cmdTowaryPodgląd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdTowaryPodgląd.UseVisualStyleBackColor = true;
            this.cmdTowaryPodgląd.Click += new System.EventHandler(this.cmdTowaryPodgląd_Click);
            // 
            // cmdZamknij
            // 
            this.cmdZamknij.Location = new System.Drawing.Point(14, 467);
            this.cmdZamknij.Name = "cmdZamknij";
            this.cmdZamknij.Size = new System.Drawing.Size(618, 23);
            this.cmdZamknij.TabIndex = 38;
            this.cmdZamknij.Text = "Zamknij";
            this.cmdZamknij.UseVisualStyleBackColor = true;
            this.cmdZamknij.Click += new System.EventHandler(this.cmdZamknij_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(14, 12);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(619, 420);
            this.dgvLista.TabIndex = 39;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 498);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.cmdZamknij);
            this.Controls.Add(this.cbxTowary);
            this.Controls.Add(this.cmdTowaryUsun);
            this.Controls.Add(this.cmdTowaryDodaj);
            this.Controls.Add(this.cmdTowaryPodgląd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTowary;
        private System.Windows.Forms.Button cmdTowaryUsun;
        private System.Windows.Forms.Button cmdTowaryDodaj;
        private System.Windows.Forms.Button cmdTowaryPodgląd;
        private System.Windows.Forms.Button cmdZamknij;
        private System.Windows.Forms.DataGridView dgvLista;
    }
}