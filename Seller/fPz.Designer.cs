namespace Seller
{
    partial class fPz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPz));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.cmdKoniec = new System.Windows.Forms.Button();
            this.cbxMagazynI = new System.Windows.Forms.ComboBox();
            this.cbxDoment = new System.Windows.Forms.ComboBox();
            this.dtpDataDo = new System.Windows.Forms.DateTimePicker();
            this.cmdKontrahent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKontrahent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Typ dokumentu";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(379, 12);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(80, 20);
            this.dtpData.TabIndex = 0;
            // 
            // cbxUser
            // 
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(153, 39);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(149, 21);
            this.cbxUser.TabIndex = 0;
            this.cbxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxDoment_KeyPress);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnuluj.Image")));
            this.cmdAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 159);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(447, 23);
            this.cmdAnuluj.TabIndex = 1;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // cmdKoniec
            // 
            this.cmdKoniec.Image = ((System.Drawing.Image)(resources.GetObject("cmdKoniec.Image")));
            this.cmdKoniec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdKoniec.Location = new System.Drawing.Point(12, 130);
            this.cmdKoniec.Name = "cmdKoniec";
            this.cmdKoniec.Size = new System.Drawing.Size(447, 23);
            this.cmdKoniec.TabIndex = 0;
            this.cmdKoniec.Text = "Szukaj";
            this.cmdKoniec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdKoniec.UseVisualStyleBackColor = true;
            this.cmdKoniec.Click += new System.EventHandler(this.cmdKoniec_Click);
            // 
            // cbxMagazynI
            // 
            this.cbxMagazynI.FormattingEnabled = true;
            this.cbxMagazynI.Location = new System.Drawing.Point(153, 66);
            this.cbxMagazynI.Name = "cbxMagazynI";
            this.cbxMagazynI.Size = new System.Drawing.Size(149, 21);
            this.cbxMagazynI.TabIndex = 0;
            this.cbxMagazynI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxDoment_KeyPress);
            // 
            // cbxDoment
            // 
            this.cbxDoment.FormattingEnabled = true;
            this.cbxDoment.Location = new System.Drawing.Point(153, 12);
            this.cbxDoment.Name = "cbxDoment";
            this.cbxDoment.Size = new System.Drawing.Size(149, 21);
            this.cbxDoment.TabIndex = 0;
            this.cbxDoment.SelectedIndexChanged += new System.EventHandler(this.cbxDoment_SelectedIndexChanged);
            this.cbxDoment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxDoment_KeyPress);
            // 
            // dtpDataDo
            // 
            this.dtpDataDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDo.Location = new System.Drawing.Point(379, 39);
            this.dtpDataDo.Name = "dtpDataDo";
            this.dtpDataDo.Size = new System.Drawing.Size(80, 20);
            this.dtpDataDo.TabIndex = 0;
            // 
            // cmdKontrahent
            // 
            this.cmdKontrahent.Image = ((System.Drawing.Image)(resources.GetObject("cmdKontrahent.Image")));
            this.cmdKontrahent.Location = new System.Drawing.Point(434, 90);
            this.cmdKontrahent.Name = "cmdKontrahent";
            this.cmdKontrahent.Size = new System.Drawing.Size(25, 25);
            this.cmdKontrahent.TabIndex = 35;
            this.cmdKontrahent.UseVisualStyleBackColor = true;
            this.cmdKontrahent.Click += new System.EventHandler(this.cmdKontrahent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Pracownik wystawiający";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Kontrahent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Magazyn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Data od";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Data do";
            // 
            // txtKontrahent
            // 
            this.txtKontrahent.FormattingEnabled = true;
            this.txtKontrahent.Location = new System.Drawing.Point(153, 93);
            this.txtKontrahent.Name = "txtKontrahent";
            this.txtKontrahent.Size = new System.Drawing.Size(275, 21);
            this.txtKontrahent.TabIndex = 42;

            // 
            // fPz
            // 
            this.AcceptButton = this.cmdKoniec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 195);
            this.ControlBox = false;
            this.Controls.Add(this.txtKontrahent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxMagazynI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDoment);
            this.Controls.Add(this.cmdKontrahent);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdKoniec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fPz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dokumenty magazynowe - wyszukiwanie";
            this.Load += new System.EventHandler(this.fPz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.Button cmdKoniec;
        private System.Windows.Forms.ComboBox cbxMagazynI;
        private System.Windows.Forms.ComboBox cbxDoment;
        private System.Windows.Forms.DateTimePicker dtpDataDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdKontrahent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtKontrahent;
    }
}