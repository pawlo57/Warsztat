namespace Seller.CONTROLS.Samochody
{
    partial class BadaniaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadaniaFrm));
            this.cmdMonth = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSzukaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDo = new System.Windows.Forms.DateTimePicker();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdMonth
            // 
            this.cmdMonth.Location = new System.Drawing.Point(12, 12);
            this.cmdMonth.Name = "cmdMonth";
            this.cmdMonth.Size = new System.Drawing.Size(383, 23);
            this.cmdMonth.TabIndex = 0;
            this.cmdMonth.Text = "Pokaż pojazdy, których termin badania technicznego wypada w tym miesiącu";
            this.cmdMonth.UseVisualStyleBackColor = true;
            this.cmdMonth.Click += new System.EventHandler(this.cmdMonth_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdSzukaj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDataOd);
            this.groupBox1.Controls.Add(this.dtpDataDo);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "lub wybierz okres, na który przypada badanie techniczne samochodu";
            // 
            // cmdSzukaj
            // 
            this.cmdSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdSzukaj.Image")));
            this.cmdSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSzukaj.Location = new System.Drawing.Point(111, 76);
            this.cmdSzukaj.Name = "cmdSzukaj";
            this.cmdSzukaj.Size = new System.Drawing.Size(160, 23);
            this.cmdSzukaj.TabIndex = 23;
            this.cmdSzukaj.Text = "Szukaj";
            this.cmdSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSzukaj.UseVisualStyleBackColor = true;
            this.cmdSzukaj.Click += new System.EventHandler(this.cmdSzukaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Od:";
            // 
            // dtpDataOd
            // 
            this.dtpDataOd.Location = new System.Drawing.Point(106, 24);
            this.dtpDataOd.Name = "dtpDataOd";
            this.dtpDataOd.Size = new System.Drawing.Size(200, 20);
            this.dtpDataOd.TabIndex = 2;
            // 
            // dtpDataDo
            // 
            this.dtpDataDo.Location = new System.Drawing.Point(106, 50);
            this.dtpDataDo.Name = "dtpDataDo";
            this.dtpDataDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDataDo.TabIndex = 3;
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnuluj.Image")));
            this.cmdAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 154);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(383, 23);
            this.cmdAnuluj.TabIndex = 69;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // BadaniaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 191);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BadaniaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Badania techniczne - wyszukiwanie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataOd;
        private System.Windows.Forms.DateTimePicker dtpDataDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.Button cmdSzukaj;
    }
}