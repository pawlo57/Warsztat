namespace Seller.CONTROLS
{
    partial class Customers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.dgwCustomers = new System.Windows.Forms.DataGridView();
            this.cmdSzukaj = new System.Windows.Forms.Button();
            this.cmdNowy = new System.Windows.Forms.Button();
            this.cmdEdytuj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.AllowUserToAddRows = false;
            this.dgwCustomers.AllowUserToDeleteRows = false;
            this.dgwCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwCustomers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.Location = new System.Drawing.Point(216, 14);
            this.dgwCustomers.Name = "dgwCustomers";
            this.dgwCustomers.ReadOnly = true;
            this.dgwCustomers.Size = new System.Drawing.Size(775, 518);
            this.dgwCustomers.TabIndex = 12;
            // 
            // cmdSzukaj
            // 
            this.cmdSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("cmdSzukaj.Image")));
            this.cmdSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSzukaj.Location = new System.Drawing.Point(22, 98);
            this.cmdSzukaj.Name = "cmdSzukaj";
            this.cmdSzukaj.Size = new System.Drawing.Size(142, 36);
            this.cmdSzukaj.TabIndex = 11;
            this.cmdSzukaj.Text = "Szukaj";
            this.cmdSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdSzukaj, "Kilknij aby wyszukać kontrahentów");
            this.cmdSzukaj.UseVisualStyleBackColor = true;
            this.cmdSzukaj.Click += new System.EventHandler(this.cmdSzukaj_Click);
            // 
            // cmdNowy
            // 
            this.cmdNowy.Image = ((System.Drawing.Image)(resources.GetObject("cmdNowy.Image")));
            this.cmdNowy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNowy.Location = new System.Drawing.Point(20, 19);
            this.cmdNowy.Name = "cmdNowy";
            this.cmdNowy.Size = new System.Drawing.Size(144, 23);
            this.cmdNowy.TabIndex = 9;
            this.cmdNowy.Text = "Nowy";
            this.cmdNowy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdNowy, "Kliknij aby dodać nowego klienta lub dostawcę");
            this.cmdNowy.UseVisualStyleBackColor = true;
            this.cmdNowy.Click += new System.EventHandler(this.cmdNowy_Click);
            // 
            // cmdEdytuj
            // 
            this.cmdEdytuj.Image = ((System.Drawing.Image)(resources.GetObject("cmdEdytuj.Image")));
            this.cmdEdytuj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEdytuj.Location = new System.Drawing.Point(20, 48);
            this.cmdEdytuj.Name = "cmdEdytuj";
            this.cmdEdytuj.Size = new System.Drawing.Size(144, 23);
            this.cmdEdytuj.TabIndex = 10;
            this.cmdEdytuj.Text = "Edytuj";
            this.cmdEdytuj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdEdytuj, "Kliknij aby edytować kontrahenta");
            this.cmdEdytuj.UseVisualStyleBackColor = true;
            this.cmdEdytuj.Click += new System.EventHandler(this.cmdEdytuj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdNowy);
            this.groupBox1.Controls.Add(this.cmdEdytuj);
            this.groupBox1.Controls.Add(this.cmdSzukaj);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 153);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontrahenci";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwCustomers);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(1006, 547);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomers;
        private System.Windows.Forms.Button cmdSzukaj;
        private System.Windows.Forms.Button cmdEdytuj;
        private System.Windows.Forms.Button cmdNowy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
