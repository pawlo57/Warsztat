namespace Seller
{
    partial class Pz
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pz));
            this.dgvProdukty = new System.Windows.Forms.DataGridView();
            this.cmdKoniec = new System.Windows.Forms.Button();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.cmdMagazynDodaj = new System.Windows.Forms.Button();
            this.cbxMagazynI = new System.Windows.Forms.ComboBox();
            this.cbxUser = new System.Windows.Forms.TextBox();
            this.txtKontrahent = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cmdPodgląd = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.cmdKontrahent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKOntrahent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxTowar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdTowarSzukaj = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdTowarUsun = new System.Windows.Forms.Button();
            this.txtDocument = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdukty
            // 
            this.dgvProdukty.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdukty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdukty.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProdukty.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProdukty.Location = new System.Drawing.Point(12, 94);
            this.dgvProdukty.Name = "dgvProdukty";
            this.dgvProdukty.Size = new System.Drawing.Size(504, 127);
            this.dgvProdukty.TabIndex = 2;
            // 
            // cmdKoniec
            // 
            this.cmdKoniec.Image = ((System.Drawing.Image)(resources.GetObject("cmdKoniec.Image")));
            this.cmdKoniec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdKoniec.Location = new System.Drawing.Point(12, 300);
            this.cmdKoniec.Name = "cmdKoniec";
            this.cmdKoniec.Size = new System.Drawing.Size(504, 23);
            this.cmdKoniec.TabIndex = 3;
            this.cmdKoniec.Text = "Zakończ przyjęcie towaru";
            this.cmdKoniec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdKoniec.UseVisualStyleBackColor = true;
            this.cmdKoniec.Click += new System.EventHandler(this.cmdKoniec_Click);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnuluj.Image")));
            this.cmdAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 329);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(504, 23);
            this.cmdAnuluj.TabIndex = 4;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // cmdMagazynDodaj
            // 
            this.cmdMagazynDodaj.Location = new System.Drawing.Point(491, 36);
            this.cmdMagazynDodaj.Name = "cmdMagazynDodaj";
            this.cmdMagazynDodaj.Size = new System.Drawing.Size(25, 25);
            this.cmdMagazynDodaj.TabIndex = 13;
            this.cmdMagazynDodaj.Text = "+";
            this.cmdMagazynDodaj.UseVisualStyleBackColor = true;
            this.cmdMagazynDodaj.Click += new System.EventHandler(this.cmdMagazynDodaj_Click);
            // 
            // cbxMagazynI
            // 
            this.cbxMagazynI.FormattingEnabled = true;
            this.cbxMagazynI.Location = new System.Drawing.Point(333, 39);
            this.cbxMagazynI.Name = "cbxMagazynI";
            this.cbxMagazynI.Size = new System.Drawing.Size(152, 21);
            this.cbxMagazynI.TabIndex = 9;
            this.cbxMagazynI.SelectedIndexChanged += new System.EventHandler(this.cbxMagazynI_SelectedIndexChanged);
            this.cbxMagazynI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKontrahent_KeyPress);
            // 
            // cbxUser
            // 
            this.cbxUser.Location = new System.Drawing.Point(112, 39);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(146, 20);
            this.cbxUser.TabIndex = 0;
            this.cbxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKontrahent_KeyPress);
            // 
            // txtKontrahent
            // 
            this.txtKontrahent.FormattingEnabled = true;
            this.txtKontrahent.Location = new System.Drawing.Point(112, 66);
            this.txtKontrahent.Name = "txtKontrahent";
            this.txtKontrahent.Size = new System.Drawing.Size(342, 21);
            this.txtKontrahent.TabIndex = 13;
            this.txtKontrahent.SelectedIndexChanged += new System.EventHandler(this.txtKontrahent_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(333, 13);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(78, 20);
            this.dtpData.TabIndex = 0;
            // 
            // cmdPodgląd
            // 
            this.cmdPodgląd.Image = ((System.Drawing.Image)(resources.GetObject("cmdPodgląd.Image")));
            this.cmdPodgląd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPodgląd.Location = new System.Drawing.Point(409, 257);
            this.cmdPodgląd.Name = "cmdPodgląd";
            this.cmdPodgląd.Size = new System.Drawing.Size(76, 23);
            this.cmdPodgląd.TabIndex = 12;
            this.cmdPodgląd.Text = "Podgląd";
            this.cmdPodgląd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdPodgląd, "Podgląd wybranej części z listy");
            this.cmdPodgląd.UseVisualStyleBackColor = true;
            this.cmdPodgląd.Click += new System.EventHandler(this.cmdPodgląd_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(450, 13);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(66, 20);
            this.txtSuma.TabIndex = 21;
            this.txtSuma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKontrahent_KeyPress);
            // 
            // cmdKontrahent
            // 
            this.cmdKontrahent.Image = ((System.Drawing.Image)(resources.GetObject("cmdKontrahent.Image")));
            this.cmdKontrahent.Location = new System.Drawing.Point(491, 63);
            this.cmdKontrahent.Name = "cmdKontrahent";
            this.cmdKontrahent.Size = new System.Drawing.Size(25, 25);
            this.cmdKontrahent.TabIndex = 14;
            this.cmdKontrahent.UseVisualStyleBackColor = true;
            this.cmdKontrahent.Click += new System.EventHandler(this.cmdKontrahent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Typ dokumentu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Pracownik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Magazyn";
            // 
            // lblKOntrahent
            // 
            this.lblKOntrahent.AutoSize = true;
            this.lblKOntrahent.Location = new System.Drawing.Point(25, 69);
            this.lblKOntrahent.Name = "lblKOntrahent";
            this.lblKOntrahent.Size = new System.Drawing.Size(59, 13);
            this.lblKOntrahent.TabIndex = 26;
            this.lblKOntrahent.Text = "Kontrahent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Suma";
            // 
            // cbxTowar
            // 
            this.cbxTowar.FormattingEnabled = true;
            this.cbxTowar.Location = new System.Drawing.Point(68, 230);
            this.cbxTowar.Name = "cbxTowar";
            this.cbxTowar.Size = new System.Drawing.Size(417, 21);
            this.cbxTowar.TabIndex = 28;
            this.cbxTowar.SelectedIndexChanged += new System.EventHandler(this.cbxTowar_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Towar";
            // 
            // cmdTowarSzukaj
            // 
            this.cmdTowarSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdTowarSzukaj.Image")));
            this.cmdTowarSzukaj.Location = new System.Drawing.Point(491, 227);
            this.cmdTowarSzukaj.Name = "cmdTowarSzukaj";
            this.cmdTowarSzukaj.Size = new System.Drawing.Size(25, 25);
            this.cmdTowarSzukaj.TabIndex = 31;
            this.toolTip1.SetToolTip(this.cmdTowarSzukaj, "Wyszukaj z bazy części");
            this.cmdTowarSzukaj.UseVisualStyleBackColor = true;
            this.cmdTowarSzukaj.Click += new System.EventHandler(this.cmdTowarSzukaj_Click);
            // 
            // cmdTowarUsun
            // 
            this.cmdTowarUsun.Location = new System.Drawing.Point(491, 256);
            this.cmdTowarUsun.Name = "cmdTowarUsun";
            this.cmdTowarUsun.Size = new System.Drawing.Size(25, 25);
            this.cmdTowarUsun.TabIndex = 32;
            this.cmdTowarUsun.Text = "-";
            this.toolTip1.SetToolTip(this.cmdTowarUsun, "Usuń wybraną część z listy");
            this.cmdTowarUsun.UseVisualStyleBackColor = true;
            this.cmdTowarUsun.Click += new System.EventHandler(this.cmdUsun_Click);
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(112, 12);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(146, 20);
            this.txtDocument.TabIndex = 33;
            this.txtDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocument_KeyPress);
            // 
            // Pz
            // 
            this.AcceptButton = this.cmdKoniec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 364);
            this.ControlBox = false;
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.cmdTowarUsun);
            this.Controls.Add(this.cmdTowarSzukaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxTowar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdKontrahent);
            this.Controls.Add(this.lblKOntrahent);
            this.Controls.Add(this.txtKontrahent);
            this.Controls.Add(this.cmdMagazynDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxMagazynI);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdPodgląd);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdKoniec);
            this.Controls.Add(this.dgvProdukty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Przyjęcie towaru";
            this.Load += new System.EventHandler(this.Pz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdukty;
        private System.Windows.Forms.Button cmdKoniec;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.ComboBox cbxMagazynI;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button cmdPodgląd;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox cbxUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdMagazynDodaj;
        private System.Windows.Forms.ComboBox txtKontrahent;
        private System.Windows.Forms.Button cmdKontrahent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKOntrahent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxTowar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdTowarSzukaj;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdTowarUsun;
        private System.Windows.Forms.TextBox txtDocument;
    }
}