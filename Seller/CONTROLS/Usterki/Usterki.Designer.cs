namespace Seller.CONTROLS.Usterki
{
    partial class Usterki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usterki));
            this.dgvUsterki = new System.Windows.Forms.DataGridView();
            this.cmdUsterkaUsun = new System.Windows.Forms.Button();
            this.cmdUstarkaDodaj = new System.Windows.Forms.Button();
            this.cmdUsterkaPodgląd = new System.Windows.Forms.Button();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsterki)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsterki
            // 
            this.dgvUsterki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsterki.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsterki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsterki.Location = new System.Drawing.Point(12, 12);
            this.dgvUsterki.MultiSelect = false;
            this.dgvUsterki.Name = "dgvUsterki";
            this.dgvUsterki.ReadOnly = true;
            this.dgvUsterki.Size = new System.Drawing.Size(509, 310);
            this.dgvUsterki.TabIndex = 0;
            // 
            // cmdUsterkaUsun
            // 
            this.cmdUsterkaUsun.Image = ((System.Drawing.Image)(resources.GetObject("cmdUsterkaUsun.Image")));
            this.cmdUsterkaUsun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUsterkaUsun.Location = new System.Drawing.Point(185, 328);
            this.cmdUsterkaUsun.Name = "cmdUsterkaUsun";
            this.cmdUsterkaUsun.Size = new System.Drawing.Size(86, 23);
            this.cmdUsterkaUsun.TabIndex = 34;
            this.cmdUsterkaUsun.Text = "Usuń";
            this.cmdUsterkaUsun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdUsterkaUsun.UseVisualStyleBackColor = true;
            this.cmdUsterkaUsun.Click += new System.EventHandler(this.cmdUsterkaUsun_Click);
            // 
            // cmdUstarkaDodaj
            // 
            this.cmdUstarkaDodaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdUstarkaDodaj.Image")));
            this.cmdUstarkaDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUstarkaDodaj.Location = new System.Drawing.Point(93, 328);
            this.cmdUstarkaDodaj.Name = "cmdUstarkaDodaj";
            this.cmdUstarkaDodaj.Size = new System.Drawing.Size(86, 23);
            this.cmdUstarkaDodaj.TabIndex = 33;
            this.cmdUstarkaDodaj.Text = "Dodaj";
            this.cmdUstarkaDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdUstarkaDodaj.UseVisualStyleBackColor = true;
            this.cmdUstarkaDodaj.Click += new System.EventHandler(this.cmdUstarkaDodaj_Click);
            // 
            // cmdUsterkaPodgląd
            // 
            this.cmdUsterkaPodgląd.Image = ((System.Drawing.Image)(resources.GetObject("cmdUsterkaPodgląd.Image")));
            this.cmdUsterkaPodgląd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUsterkaPodgląd.Location = new System.Drawing.Point(12, 328);
            this.cmdUsterkaPodgląd.Name = "cmdUsterkaPodgląd";
            this.cmdUsterkaPodgląd.Size = new System.Drawing.Size(75, 23);
            this.cmdUsterkaPodgląd.TabIndex = 35;
            this.cmdUsterkaPodgląd.Text = "Podgląd";
            this.cmdUsterkaPodgląd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdUsterkaPodgląd.UseVisualStyleBackColor = true;
            this.cmdUsterkaPodgląd.Click += new System.EventHandler(this.cmdUsterkaPodgląd_Click);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnuluj.Image")));
            this.cmdAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 357);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(509, 23);
            this.cmdAnuluj.TabIndex = 45;
            this.cmdAnuluj.Text = "Zamknij";
            this.cmdAnuluj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // Usterki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 392);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdUsterkaUsun);
            this.Controls.Add(this.cmdUstarkaDodaj);
            this.Controls.Add(this.cmdUsterkaPodgląd);
            this.Controls.Add(this.dgvUsterki);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Usterki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista zgłoszonych usterek";
            this.Load += new System.EventHandler(this.Usterki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsterki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsterki;
        private System.Windows.Forms.Button cmdUsterkaUsun;
        private System.Windows.Forms.Button cmdUstarkaDodaj;
        private System.Windows.Forms.Button cmdUsterkaPodgląd;
        private System.Windows.Forms.Button cmdAnuluj;
    }
}