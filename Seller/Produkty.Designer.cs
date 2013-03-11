namespace Seller
{
    partial class Produkty
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
            this.dgvProdukty = new System.Windows.Forms.DataGridView();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.cmdUsun = new System.Windows.Forms.Button();
            this.cmdWprowadz = new System.Windows.Forms.Button();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdukty
            // 
            this.dgvProdukty.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvProdukty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukty.Location = new System.Drawing.Point(12, 12);
            this.dgvProdukty.Name = "dgvProdukty";
            this.dgvProdukty.Size = new System.Drawing.Size(478, 270);
            this.dgvProdukty.TabIndex = 0;
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.Location = new System.Drawing.Point(12, 288);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(236, 23);
            this.cmdDodaj.TabIndex = 1;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = true;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // cmdUsun
            // 
            this.cmdUsun.Location = new System.Drawing.Point(255, 288);
            this.cmdUsun.Name = "cmdUsun";
            this.cmdUsun.Size = new System.Drawing.Size(236, 23);
            this.cmdUsun.TabIndex = 2;
            this.cmdUsun.Text = "Usuń";
            this.cmdUsun.UseVisualStyleBackColor = true;
            this.cmdUsun.Click += new System.EventHandler(this.cmdUsun_Click);
            // 
            // cmdWprowadz
            // 
            this.cmdWprowadz.Location = new System.Drawing.Point(12, 317);
            this.cmdWprowadz.Name = "cmdWprowadz";
            this.cmdWprowadz.Size = new System.Drawing.Size(478, 23);
            this.cmdWprowadz.TabIndex = 3;
            this.cmdWprowadz.Text = "Wprowadź";
            this.cmdWprowadz.UseVisualStyleBackColor = true;
            this.cmdWprowadz.Click += new System.EventHandler(this.cmdWprowadz_Click);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 346);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(478, 23);
            this.cmdAnuluj.TabIndex = 4;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // Produkty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 386);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdWprowadz);
            this.Controls.Add(this.cmdUsun);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.dgvProdukty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Produkty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista produktów";
            this.Load += new System.EventHandler(this.Produkty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdukty;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.Button cmdUsun;
        private System.Windows.Forms.Button cmdWprowadz;
        private System.Windows.Forms.Button cmdAnuluj;
    }
}