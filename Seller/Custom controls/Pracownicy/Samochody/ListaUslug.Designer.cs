namespace Seller.CONTROLS.Samochody
{
    partial class ListaUslug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUslug));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.cmdUslugiPodglad = new System.Windows.Forms.Button();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 12);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(535, 396);
            this.dgvMain.TabIndex = 0;
            // 
            // cmdUslugiPodglad
            // 
            this.cmdUslugiPodglad.Image = ((System.Drawing.Image)(resources.GetObject("cmdUslugiPodglad.Image")));
            this.cmdUslugiPodglad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUslugiPodglad.Location = new System.Drawing.Point(347, 414);
            this.cmdUslugiPodglad.Name = "cmdUslugiPodglad";
            this.cmdUslugiPodglad.Size = new System.Drawing.Size(200, 23);
            this.cmdUslugiPodglad.TabIndex = 33;
            this.cmdUslugiPodglad.Text = "Podgląd";
            this.cmdUslugiPodglad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdUslugiPodglad.UseVisualStyleBackColor = true;
            this.cmdUslugiPodglad.Click += new System.EventHandler(this.cmdUslugiPodglad_Click);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnuluj.Image")));
            this.cmdAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 443);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(535, 23);
            this.cmdAnuluj.TabIndex = 34;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrint.Image")));
            this.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrint.Location = new System.Drawing.Point(12, 414);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(329, 23);
            this.cmdPrint.TabIndex = 35;
            this.cmdPrint.Text = "Drukuj";
            this.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // ListaUslug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 478);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdUslugiPodglad);
            this.Controls.Add(this.dgvMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListaUslug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListaUslug";
            this.Load += new System.EventHandler(this.ListaUslug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button cmdUslugiPodglad;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.Button cmdPrint;
    }
}