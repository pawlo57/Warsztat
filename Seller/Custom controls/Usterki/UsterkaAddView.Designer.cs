namespace Seller.CONTROLS.Usterki
{
    partial class UsterkaAddView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsterkaAddView));
            this.txtUsterka = new System.Windows.Forms.TextBox();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.cmdUstarkaDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsterka
            // 
            this.txtUsterka.Location = new System.Drawing.Point(12, 12);
            this.txtUsterka.Multiline = true;
            this.txtUsterka.Name = "txtUsterka";
            this.txtUsterka.Size = new System.Drawing.Size(455, 64);
            this.txtUsterka.TabIndex = 0;
            this.txtUsterka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsterka_KeyPress);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnuluj.Image")));
            this.cmdAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnuluj.Location = new System.Drawing.Point(246, 82);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(221, 23);
            this.cmdAnuluj.TabIndex = 47;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // cmdUstarkaDodaj
            // 
            this.cmdUstarkaDodaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdUstarkaDodaj.Image")));
            this.cmdUstarkaDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUstarkaDodaj.Location = new System.Drawing.Point(12, 82);
            this.cmdUstarkaDodaj.Name = "cmdUstarkaDodaj";
            this.cmdUstarkaDodaj.Size = new System.Drawing.Size(221, 23);
            this.cmdUstarkaDodaj.TabIndex = 46;
            this.cmdUstarkaDodaj.Text = "Dodaj";
            this.cmdUstarkaDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdUstarkaDodaj.UseVisualStyleBackColor = true;
            this.cmdUstarkaDodaj.Click += new System.EventHandler(this.cmdUstarkaDodaj_Click);
            // 
            // UsterkaAddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 118);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdUstarkaDodaj);
            this.Controls.Add(this.txtUsterka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UsterkaAddView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UsterkaAddView";
            this.Load += new System.EventHandler(this.UsterkaAddView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsterka;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.Button cmdUstarkaDodaj;
    }
}