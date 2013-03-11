namespace Seller
{
    partial class FindInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindInvoice));
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.txtNumer = new System.Windows.Forms.TextBox();
            this.cbcDataWpr = new System.Windows.Forms.CheckBox();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbxKontrahent = new System.Windows.Forms.ComboBox();
            this.cmdKontrahent = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmsCarSearch = new System.Windows.Forms.Button();
            this.cbxCar = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxUser
            // 
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(17, 21);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(177, 21);
            this.cbxUser.TabIndex = 0;
            this.cbxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxUser_KeyPress);
            // 
            // txtNumer
            // 
            this.txtNumer.Location = new System.Drawing.Point(13, 21);
            this.txtNumer.Name = "txtNumer";
            this.txtNumer.Size = new System.Drawing.Size(126, 20);
            this.txtNumer.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNumer, "Wpisz fragment lub cały numer faktury/transakcji");
            this.txtNumer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumer_KeyPress);
            // 
            // cbcDataWpr
            // 
            this.cbcDataWpr.AutoSize = true;
            this.cbcDataWpr.Location = new System.Drawing.Point(25, 26);
            this.cbcDataWpr.Name = "cbcDataWpr";
            this.cbcDataWpr.Size = new System.Drawing.Size(15, 14);
            this.cbcDataWpr.TabIndex = 3;
            this.cbcDataWpr.UseVisualStyleBackColor = true;
            this.cbcDataWpr.CheckStateChanged += new System.EventHandler(this.cbcDataWpr_CheckStateChanged);
            // 
            // dtpDO
            // 
            this.dtpDO.Enabled = false;
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDO.Location = new System.Drawing.Point(262, 20);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(91, 20);
            this.dtpDO.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(232, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Do:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(78, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Od:";
            // 
            // dtpOD
            // 
            this.dtpOD.Enabled = false;
            this.dtpOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOD.Location = new System.Drawing.Point(108, 20);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(92, 20);
            this.dtpOD.TabIndex = 0;
            // 
            // cmdOk
            // 
            this.cmdOk.Image = ((System.Drawing.Image)(resources.GetObject("cmdOk.Image")));
            this.cmdOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOk.Location = new System.Drawing.Point(12, 136);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(744, 23);
            this.cmdOk.TabIndex = 0;
            this.cmdOk.Text = "Szukaj";
            this.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnuluj.Image")));
            this.cmdAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 165);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(744, 23);
            this.cmdAnuluj.TabIndex = 1;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numer zlecenia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxUser);
            this.groupBox2.Location = new System.Drawing.Point(171, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 56);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pracownik wystawiający";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDO);
            this.groupBox3.Controls.Add(this.cbcDataWpr);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dtpOD);
            this.groupBox3.Location = new System.Drawing.Point(387, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 56);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data wykonania zlecenia";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbxKontrahent);
            this.groupBox5.Controls.Add(this.cmdKontrahent);
            this.groupBox5.Location = new System.Drawing.Point(12, 74);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(276, 56);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kontrahent (właściciel pojazdu)";
            // 
            // cbxKontrahent
            // 
            this.cbxKontrahent.FormattingEnabled = true;
            this.cbxKontrahent.Location = new System.Drawing.Point(13, 20);
            this.cbxKontrahent.Name = "cbxKontrahent";
            this.cbxKontrahent.Size = new System.Drawing.Size(182, 21);
            this.cbxKontrahent.TabIndex = 0;
            this.cbxKontrahent.SelectedIndexChanged += new System.EventHandler(this.cbxKontrahent_SelectedIndexChanged);
            // 
            // cmdKontrahent
            // 
            this.cmdKontrahent.Location = new System.Drawing.Point(201, 18);
            this.cmdKontrahent.Name = "cmdKontrahent";
            this.cmdKontrahent.Size = new System.Drawing.Size(61, 23);
            this.cmdKontrahent.TabIndex = 1;
            this.cmdKontrahent.Text = "Szukaj";
            this.cmdKontrahent.UseVisualStyleBackColor = true;
            this.cmdKontrahent.Click += new System.EventHandler(this.cmdKontrahent_Click_1);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbxStatus);
            this.groupBox7.Location = new System.Drawing.Point(607, 74);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(149, 53);
            this.groupBox7.TabIndex = 38;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Typ rachunku";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(21, 19);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(112, 21);
            this.cbxStatus.TabIndex = 0;
            this.cbxStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxUser_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmsCarSearch);
            this.groupBox4.Controls.Add(this.cbxCar);
            this.groupBox4.Location = new System.Drawing.Point(294, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 53);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Samochód (przedmiot naprawy)";
            // 
            // cmsCarSearch
            // 
            this.cmsCarSearch.Image = ((System.Drawing.Image)(resources.GetObject("cmsCarSearch.Image")));
            this.cmsCarSearch.Location = new System.Drawing.Point(268, 16);
            this.cmsCarSearch.Name = "cmsCarSearch";
            this.cmsCarSearch.Size = new System.Drawing.Size(25, 25);
            this.cmsCarSearch.TabIndex = 41;
            this.cmsCarSearch.UseVisualStyleBackColor = true;
            this.cmsCarSearch.Click += new System.EventHandler(this.cmsCarSearch_Click);
            // 
            // cbxCar
            // 
            this.cbxCar.FormattingEnabled = true;
            this.cbxCar.Location = new System.Drawing.Point(16, 19);
            this.cbxCar.Name = "cbxCar";
            this.cbxCar.Size = new System.Drawing.Size(246, 21);
            this.cbxCar.TabIndex = 0;
            this.cbxCar.Text = "Wybierz lub dodaj pojazd";
            this.cbxCar.SelectedIndexChanged += new System.EventHandler(this.cbxCar_SelectedIndexChanged);
            // 
            // FindInvoice
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 201);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.cmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wyszukiwanie zleceń";
            this.Load += new System.EventHandler(this.FindInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumer;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdAnuluj;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbcDataWpr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbxKontrahent;
        private System.Windows.Forms.Button cmdKontrahent;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cmsCarSearch;
        private System.Windows.Forms.ComboBox cbxCar;
    }
}