namespace Seller
{
    partial class Uzytkownicy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uzytkownicy));
            this.dgvUzytkownicy = new System.Windows.Forms.DataGridView();
            this.cmdNowy = new System.Windows.Forms.Button();
            this.cmdEdycja = new System.Windows.Forms.Button();
            this.cmdPodglad = new System.Windows.Forms.Button();
            this.cmdKoniec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUzytkownicy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUzytkownicy
            // 
            this.dgvUzytkownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUzytkownicy.Location = new System.Drawing.Point(12, 12);
            this.dgvUzytkownicy.Name = "dgvUzytkownicy";
            this.dgvUzytkownicy.Size = new System.Drawing.Size(664, 255);
            this.dgvUzytkownicy.TabIndex = 0;
            // 
            // cmdNowy
            // 
            this.cmdNowy.Image = ((System.Drawing.Image)(resources.GetObject("cmdNowy.Image")));
            this.cmdNowy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNowy.Location = new System.Drawing.Point(12, 273);
            this.cmdNowy.Name = "cmdNowy";
            this.cmdNowy.Size = new System.Drawing.Size(216, 23);
            this.cmdNowy.TabIndex = 1;
            this.cmdNowy.Text = "Nowy";
            this.cmdNowy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdNowy.UseVisualStyleBackColor = true;
            this.cmdNowy.Click += new System.EventHandler(this.cmdNowy_Click);
            // 
            // cmdEdycja
            // 
            this.cmdEdycja.Image = ((System.Drawing.Image)(resources.GetObject("cmdEdycja.Image")));
            this.cmdEdycja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEdycja.Location = new System.Drawing.Point(234, 273);
            this.cmdEdycja.Name = "cmdEdycja";
            this.cmdEdycja.Size = new System.Drawing.Size(216, 23);
            this.cmdEdycja.TabIndex = 2;
            this.cmdEdycja.Text = "Edycja";
            this.cmdEdycja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdEdycja.UseVisualStyleBackColor = true;
            this.cmdEdycja.Click += new System.EventHandler(this.cmdEdycja_Click);
            // 
            // cmdPodglad
            // 
            this.cmdPodglad.Image = ((System.Drawing.Image)(resources.GetObject("cmdPodglad.Image")));
            this.cmdPodglad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPodglad.Location = new System.Drawing.Point(460, 273);
            this.cmdPodglad.Name = "cmdPodglad";
            this.cmdPodglad.Size = new System.Drawing.Size(216, 23);
            this.cmdPodglad.TabIndex = 3;
            this.cmdPodglad.Text = "Podgląd";
            this.cmdPodglad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdPodglad.UseVisualStyleBackColor = true;
            this.cmdPodglad.Click += new System.EventHandler(this.cmdPodglad_Click);
            // 
            // cmdKoniec
            // 
            this.cmdKoniec.Image = ((System.Drawing.Image)(resources.GetObject("cmdKoniec.Image")));
            this.cmdKoniec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdKoniec.Location = new System.Drawing.Point(120, 299);
            this.cmdKoniec.Name = "cmdKoniec";
            this.cmdKoniec.Size = new System.Drawing.Size(450, 23);
            this.cmdKoniec.TabIndex = 4;
            this.cmdKoniec.Text = "Zamknij";
            this.cmdKoniec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdKoniec.UseVisualStyleBackColor = true;
            this.cmdKoniec.Click += new System.EventHandler(this.cmdKoniec_Click);
            // 
            // Uzytkownicy
            // 
            this.AcceptButton = this.cmdKoniec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 328);
            this.ControlBox = false;
            this.Controls.Add(this.cmdKoniec);
            this.Controls.Add(this.cmdPodglad);
            this.Controls.Add(this.cmdEdycja);
            this.Controls.Add(this.cmdNowy);
            this.Controls.Add(this.dgvUzytkownicy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Uzytkownicy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Baza użytkowników";
            this.Load += new System.EventHandler(this.Uzytkownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUzytkownicy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUzytkownicy;
        private System.Windows.Forms.Button cmdNowy;
        private System.Windows.Forms.Button cmdEdycja;
        private System.Windows.Forms.Button cmdPodglad;
        private System.Windows.Forms.Button cmdKoniec;
    }
}