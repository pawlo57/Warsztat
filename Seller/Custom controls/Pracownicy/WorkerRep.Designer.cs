namespace Seller.CONTROLS.Pracownicy
{
    partial class WorkerRep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerRep));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmsWorkerSearch = new System.Windows.Forms.Button();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDATA_DO = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDATA_OD = new System.Windows.Forms.DateTimePicker();
            this.cmdDay = new System.Windows.Forms.Button();
            this.cmdMonth = new System.Windows.Forms.Button();
            this.cmdAnuluj = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmsWorkerSearch);
            this.groupBox5.Controls.Add(this.cbxWorker);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 53);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pracownik";
            // 
            // cmsWorkerSearch
            // 
            this.cmsWorkerSearch.Image = ((System.Drawing.Image)(resources.GetObject("cmsWorkerSearch.Image")));
            this.cmsWorkerSearch.Location = new System.Drawing.Point(264, 16);
            this.cmsWorkerSearch.Name = "cmsWorkerSearch";
            this.cmsWorkerSearch.Size = new System.Drawing.Size(25, 25);
            this.cmsWorkerSearch.TabIndex = 41;
            this.cmsWorkerSearch.UseVisualStyleBackColor = true;
            this.cmsWorkerSearch.Click += new System.EventHandler(this.cmsWorkerSearch_Click);
            // 
            // cbxWorker
            // 
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(16, 19);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(242, 21);
            this.cbxWorker.TabIndex = 37;
            this.cbxWorker.Text = "Wszyscy";
            this.cbxWorker.SelectedIndexChanged += new System.EventHandler(this.cbxWorker_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmdDay);
            this.groupBox1.Controls.Add(this.cmdMonth);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 217);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raporty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpDATA_DO);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpDATA_OD);
            this.groupBox2.Location = new System.Drawing.Point(16, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Szukaj wedlug daty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Do:";
            // 
            // dtpDATA_DO
            // 
            this.dtpDATA_DO.Location = new System.Drawing.Point(78, 60);
            this.dtpDATA_DO.Name = "dtpDATA_DO";
            this.dtpDATA_DO.Size = new System.Drawing.Size(146, 20);
            this.dtpDATA_DO.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Od:";
            // 
            // dtpDATA_OD
            // 
            this.dtpDATA_OD.Location = new System.Drawing.Point(78, 34);
            this.dtpDATA_OD.Name = "dtpDATA_OD";
            this.dtpDATA_OD.Size = new System.Drawing.Size(146, 20);
            this.dtpDATA_OD.TabIndex = 2;
            // 
            // cmdDay
            // 
            this.cmdDay.Location = new System.Drawing.Point(16, 48);
            this.cmdDay.Name = "cmdDay";
            this.cmdDay.Size = new System.Drawing.Size(273, 23);
            this.cmdDay.TabIndex = 1;
            this.cmdDay.Text = "Pokaż raport dzienny";
            this.cmdDay.UseVisualStyleBackColor = true;
            this.cmdDay.Click += new System.EventHandler(this.cmdDay_Click);
            // 
            // cmdMonth
            // 
            this.cmdMonth.Location = new System.Drawing.Point(16, 19);
            this.cmdMonth.Name = "cmdMonth";
            this.cmdMonth.Size = new System.Drawing.Size(273, 23);
            this.cmdMonth.TabIndex = 0;
            this.cmdMonth.Text = "Pokaż raport miesięczny";
            this.cmdMonth.UseVisualStyleBackColor = true;
            this.cmdMonth.Click += new System.EventHandler(this.cmdMonth_Click);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnuluj.Image")));
            this.cmdAnuluj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 294);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(304, 23);
            this.cmdAnuluj.TabIndex = 27;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // WorkerRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 330);
            this.Controls.Add(this.cmdAnuluj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WorkerRep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Raport szczegółowy czasu pracy";
          
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button cmsWorkerSearch;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdMonth;
        private System.Windows.Forms.Button cmdDay;
        private System.Windows.Forms.DateTimePicker dtpDATA_OD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDATA_DO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAnuluj;
    }
}