namespace StockTrackingERP
{
    partial class CariHesapYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariHesapYonetimi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datReceiptDate1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datReceiptDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtCurrentAccountReceiptList = new System.Windows.Forms.DataGridView();
            this.rdbCurrentAllReceipts = new System.Windows.Forms.RadioButton();
            this.rdbCurrentReceivableReceipts = new System.Windows.Forms.RadioButton();
            this.rdbCurrentDebtReceipts = new System.Windows.Forms.RadioButton();
            this.btnCurrentReceipts = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentReceiptNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCurrentReceivable = new System.Windows.Forms.Label();
            this.lblCurrentDebit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCurrentAccountReceiptList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.geriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ekleToolStripMenuItem.Image")));
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("silToolStripMenuItem.Image")));
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("geriToolStripMenuItem.Image")));
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.geriToolStripMenuItem.Text = "Geri";
            this.geriToolStripMenuItem.Click += new System.EventHandler(this.geriToolStripMenuItem_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(78, 53);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(140, 20);
            this.txtCustomerName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Müşteri Adı:";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(78, 27);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(140, 20);
            this.txtCustomerCode.TabIndex = 5;
            this.txtCustomerCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müşteri Kodu:";
            // 
            // datReceiptDate1
            // 
            this.datReceiptDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datReceiptDate1.Location = new System.Drawing.Point(78, 79);
            this.datReceiptDate1.Name = "datReceiptDate1";
            this.datReceiptDate1.Size = new System.Drawing.Size(140, 20);
            this.datReceiptDate1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fiş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "-";
            // 
            // datReceiptDate2
            // 
            this.datReceiptDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datReceiptDate2.Location = new System.Drawing.Point(237, 79);
            this.datReceiptDate2.Name = "datReceiptDate2";
            this.datReceiptDate2.Size = new System.Drawing.Size(140, 20);
            this.datReceiptDate2.TabIndex = 11;
            // 
            // dtCurrentAccountReceiptList
            // 
            this.dtCurrentAccountReceiptList.BackgroundColor = System.Drawing.Color.White;
            this.dtCurrentAccountReceiptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCurrentAccountReceiptList.Location = new System.Drawing.Point(10, 105);
            this.dtCurrentAccountReceiptList.Name = "dtCurrentAccountReceiptList";
            this.dtCurrentAccountReceiptList.ReadOnly = true;
            this.dtCurrentAccountReceiptList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCurrentAccountReceiptList.Size = new System.Drawing.Size(672, 179);
            this.dtCurrentAccountReceiptList.TabIndex = 12;
            // 
            // rdbCurrentAllReceipts
            // 
            this.rdbCurrentAllReceipts.AutoSize = true;
            this.rdbCurrentAllReceipts.Checked = true;
            this.rdbCurrentAllReceipts.Location = new System.Drawing.Point(573, 26);
            this.rdbCurrentAllReceipts.Name = "rdbCurrentAllReceipts";
            this.rdbCurrentAllReceipts.Size = new System.Drawing.Size(52, 17);
            this.rdbCurrentAllReceipts.TabIndex = 13;
            this.rdbCurrentAllReceipts.TabStop = true;
            this.rdbCurrentAllReceipts.Text = "Tümü";
            this.rdbCurrentAllReceipts.UseVisualStyleBackColor = true;
            this.rdbCurrentAllReceipts.CheckedChanged += new System.EventHandler(this.rdbCurrentAllReceipts_CheckedChanged);
            // 
            // rdbCurrentReceivableReceipts
            // 
            this.rdbCurrentReceivableReceipts.AutoSize = true;
            this.rdbCurrentReceivableReceipts.Location = new System.Drawing.Point(573, 49);
            this.rdbCurrentReceivableReceipts.Name = "rdbCurrentReceivableReceipts";
            this.rdbCurrentReceivableReceipts.Size = new System.Drawing.Size(58, 17);
            this.rdbCurrentReceivableReceipts.TabIndex = 14;
            this.rdbCurrentReceivableReceipts.TabStop = true;
            this.rdbCurrentReceivableReceipts.Text = "Alacak";
            this.rdbCurrentReceivableReceipts.UseVisualStyleBackColor = true;
            this.rdbCurrentReceivableReceipts.CheckedChanged += new System.EventHandler(this.rdbCurrentReceivableReceipts_CheckedChanged);
            // 
            // rdbCurrentDebtReceipts
            // 
            this.rdbCurrentDebtReceipts.AutoSize = true;
            this.rdbCurrentDebtReceipts.Location = new System.Drawing.Point(573, 68);
            this.rdbCurrentDebtReceipts.Name = "rdbCurrentDebtReceipts";
            this.rdbCurrentDebtReceipts.Size = new System.Drawing.Size(47, 17);
            this.rdbCurrentDebtReceipts.TabIndex = 15;
            this.rdbCurrentDebtReceipts.TabStop = true;
            this.rdbCurrentDebtReceipts.Text = "Borç";
            this.rdbCurrentDebtReceipts.UseVisualStyleBackColor = true;
            this.rdbCurrentDebtReceipts.CheckedChanged += new System.EventHandler(this.rdbCurrentDebtReceipts_CheckedChanged);
            // 
            // btnCurrentReceipts
            // 
            this.btnCurrentReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentReceipts.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCurrentReceipts.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrentReceipts.Image")));
            this.btnCurrentReceipts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurrentReceipts.Location = new System.Drawing.Point(223, 26);
            this.btnCurrentReceipts.Name = "btnCurrentReceipts";
            this.btnCurrentReceipts.Size = new System.Drawing.Size(112, 30);
            this.btnCurrentReceipts.TabIndex = 16;
            this.btnCurrentReceipts.Text = "Fişleri Listele";
            this.btnCurrentReceipts.UseVisualStyleBackColor = true;
            this.btnCurrentReceipts.Click += new System.EventHandler(this.btnCurrentReceipts_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fiş No:";
            // 
            // txtCurrentReceiptNo
            // 
            this.txtCurrentReceiptNo.Location = new System.Drawing.Point(421, 79);
            this.txtCurrentReceiptNo.Name = "txtCurrentReceiptNo";
            this.txtCurrentReceiptNo.Size = new System.Drawing.Size(121, 20);
            this.txtCurrentReceiptNo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Toplam Alacak:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Toplam Borç:";
            // 
            // lblCurrentReceivable
            // 
            this.lblCurrentReceivable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentReceivable.Location = new System.Drawing.Point(427, 33);
            this.lblCurrentReceivable.Name = "lblCurrentReceivable";
            this.lblCurrentReceivable.Size = new System.Drawing.Size(106, 16);
            this.lblCurrentReceivable.TabIndex = 21;
            this.lblCurrentReceivable.Text = "0";
            // 
            // lblCurrentDebit
            // 
            this.lblCurrentDebit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentDebit.Location = new System.Drawing.Point(427, 49);
            this.lblCurrentDebit.Name = "lblCurrentDebit";
            this.lblCurrentDebit.Size = new System.Drawing.Size(106, 16);
            this.lblCurrentDebit.TabIndex = 22;
            this.lblCurrentDebit.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "TL";
            // 
            // CariHesapYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 324);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCurrentDebit);
            this.Controls.Add(this.lblCurrentReceivable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCurrentReceiptNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCurrentReceipts);
            this.Controls.Add(this.rdbCurrentDebtReceipts);
            this.Controls.Add(this.rdbCurrentReceivableReceipts);
            this.Controls.Add(this.rdbCurrentAllReceipts);
            this.Controls.Add(this.dtCurrentAccountReceiptList);
            this.Controls.Add(this.datReceiptDate2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datReceiptDate1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CariHesapYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CariHesapYonetimi";
            this.Load += new System.EventHandler(this.CariHesapYonetimi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCurrentAccountReceiptList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCustomerCode;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker datReceiptDate1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker datReceiptDate2;
        public System.Windows.Forms.DataGridView dtCurrentAccountReceiptList;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton rdbCurrentAllReceipts;
        public System.Windows.Forms.RadioButton rdbCurrentReceivableReceipts;
        public System.Windows.Forms.RadioButton rdbCurrentDebtReceipts;
        public System.Windows.Forms.Button btnCurrentReceipts;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentReceiptNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCurrentReceivable;
        private System.Windows.Forms.Label lblCurrentDebit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}