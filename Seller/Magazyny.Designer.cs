namespace Seller
{
    partial class Magazyny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magazyny));
            this.cmdKoniec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMagazyn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdKoniec
            // 
            this.cmdKoniec.Image = ((System.Drawing.Image)(resources.GetObject("cmdKoniec.Image")));
            this.cmdKoniec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdKoniec.Location = new System.Drawing.Point(12, 159);
            this.cmdKoniec.Name = "cmdKoniec";
            this.cmdKoniec.Size = new System.Drawing.Size(290, 23);
            this.cmdKoniec.TabIndex = 3;
            this.cmdKoniec.Text = "Zamknij";
            this.cmdKoniec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdKoniec.UseVisualStyleBackColor = true;
            this.cmdKoniec.Click += new System.EventHandler(this.cmdKoniec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMagazyn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nazwa magazynu";
            // 
            // txtMagazyn
            // 
            this.txtMagazyn.Location = new System.Drawing.Point(19, 19);
            this.txtMagazyn.Name = "txtMagazyn";
            this.txtMagazyn.Size = new System.Drawing.Size(253, 20);
            this.txtMagazyn.TabIndex = 6;
            this.txtMagazyn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMagazyn_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres magazynu";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(19, 19);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(253, 20);
            this.txtAdres.TabIndex = 7;
            this.txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMagazyn_KeyPress);
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdDodaj.Image")));
            this.cmdDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdDodaj.Location = new System.Drawing.Point(12, 128);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(290, 25);
            this.cmdDodaj.TabIndex = 1;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdDodaj.UseVisualStyleBackColor = true;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // Magazyny
            // 
            this.AcceptButton = this.cmdDodaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 194);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdKoniec);
            this.Controls.Add(this.cmdDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Magazyny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Magazyny";
            this.Load += new System.EventHandler(this.Magazyny_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdKoniec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMagazyn;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button cmdDodaj;
    }
}