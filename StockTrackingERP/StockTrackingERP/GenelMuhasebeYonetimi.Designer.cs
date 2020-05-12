namespace StockTrackingERP
{
    partial class GenelMuhasebeYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenelMuhasebeYonetimi));
            this.dtAccountingReceiptList = new System.Windows.Forms.DataGridView();
            this.txtAccountingReceiptNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datReceiptDate2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.datReceiptDate1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbAccountingDebtReceipts = new System.Windows.Forms.RadioButton();
            this.rdbAccountingReceivableReceipts = new System.Windows.Forms.RadioButton();
            this.rdbAccountingAllReceipts = new System.Windows.Forms.RadioButton();
            this.btnAccountingReceipts = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAccountingDebit = new System.Windows.Forms.Label();
            this.lblAccountingReceivable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtAccountingReceiptList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtAccountingReceiptList
            // 
            this.dtAccountingReceiptList.BackgroundColor = System.Drawing.Color.White;
            this.dtAccountingReceiptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAccountingReceiptList.Location = new System.Drawing.Point(7, 85);
            this.dtAccountingReceiptList.Name = "dtAccountingReceiptList";
            this.dtAccountingReceiptList.ReadOnly = true;
            this.dtAccountingReceiptList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAccountingReceiptList.Size = new System.Drawing.Size(672, 179);
            this.dtAccountingReceiptList.TabIndex = 13;
            // 
            // txtAccountingReceiptNo
            // 
            this.txtAccountingReceiptNo.Location = new System.Drawing.Point(403, 30);
            this.txtAccountingReceiptNo.Name = "txtAccountingReceiptNo";
            this.txtAccountingReceiptNo.Size = new System.Drawing.Size(121, 20);
            this.txtAccountingReceiptNo.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fiş No:";
            // 
            // datReceiptDate2
            // 
            this.datReceiptDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datReceiptDate2.Location = new System.Drawing.Point(219, 30);
            this.datReceiptDate2.Name = "datReceiptDate2";
            this.datReceiptDate2.Size = new System.Drawing.Size(140, 20);
            this.datReceiptDate2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "-";
            // 
            // datReceiptDate1
            // 
            this.datReceiptDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datReceiptDate1.Location = new System.Drawing.Point(60, 30);
            this.datReceiptDate1.Name = "datReceiptDate1";
            this.datReceiptDate1.Size = new System.Drawing.Size(140, 20);
            this.datReceiptDate1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fiş Tarihi:";
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
            this.menuStrip1.TabIndex = 25;
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
            // rdbAccountingDebtReceipts
            // 
            this.rdbAccountingDebtReceipts.AutoSize = true;
            this.rdbAccountingDebtReceipts.Location = new System.Drawing.Point(552, 61);
            this.rdbAccountingDebtReceipts.Name = "rdbAccountingDebtReceipts";
            this.rdbAccountingDebtReceipts.Size = new System.Drawing.Size(47, 17);
            this.rdbAccountingDebtReceipts.TabIndex = 28;
            this.rdbAccountingDebtReceipts.TabStop = true;
            this.rdbAccountingDebtReceipts.Text = "Borç";
            this.rdbAccountingDebtReceipts.UseVisualStyleBackColor = true;
            this.rdbAccountingDebtReceipts.CheckedChanged += new System.EventHandler(this.rdbAccountingDebtReceipts_CheckedChanged);
            // 
            // rdbAccountingReceivableReceipts
            // 
            this.rdbAccountingReceivableReceipts.AutoSize = true;
            this.rdbAccountingReceivableReceipts.Location = new System.Drawing.Point(552, 45);
            this.rdbAccountingReceivableReceipts.Name = "rdbAccountingReceivableReceipts";
            this.rdbAccountingReceivableReceipts.Size = new System.Drawing.Size(58, 17);
            this.rdbAccountingReceivableReceipts.TabIndex = 27;
            this.rdbAccountingReceivableReceipts.TabStop = true;
            this.rdbAccountingReceivableReceipts.Text = "Alacak";
            this.rdbAccountingReceivableReceipts.UseVisualStyleBackColor = true;
            this.rdbAccountingReceivableReceipts.CheckedChanged += new System.EventHandler(this.rdbAccountingReceivableReceipts_CheckedChanged);
            // 
            // rdbAccountingAllReceipts
            // 
            this.rdbAccountingAllReceipts.AutoSize = true;
            this.rdbAccountingAllReceipts.Checked = true;
            this.rdbAccountingAllReceipts.Location = new System.Drawing.Point(552, 26);
            this.rdbAccountingAllReceipts.Name = "rdbAccountingAllReceipts";
            this.rdbAccountingAllReceipts.Size = new System.Drawing.Size(52, 17);
            this.rdbAccountingAllReceipts.TabIndex = 26;
            this.rdbAccountingAllReceipts.TabStop = true;
            this.rdbAccountingAllReceipts.Text = "Tümü";
            this.rdbAccountingAllReceipts.UseVisualStyleBackColor = true;
            this.rdbAccountingAllReceipts.CheckedChanged += new System.EventHandler(this.rdbAccountingAllReceipts_CheckedChanged);
            // 
            // btnAccountingReceipts
            // 
            this.btnAccountingReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountingReceipts.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAccountingReceipts.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountingReceipts.Image")));
            this.btnAccountingReceipts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccountingReceipts.Location = new System.Drawing.Point(8, 54);
            this.btnAccountingReceipts.Name = "btnAccountingReceipts";
            this.btnAccountingReceipts.Size = new System.Drawing.Size(108, 30);
            this.btnAccountingReceipts.TabIndex = 29;
            this.btnAccountingReceipts.Text = "Fişleri Listele";
            this.btnAccountingReceipts.UseVisualStyleBackColor = true;
            this.btnAccountingReceipts.Click += new System.EventHandler(this.btnAccountingReceipts_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "TL";
            // 
            // lblAccountingDebit
            // 
            this.lblAccountingDebit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountingDebit.Location = new System.Drawing.Point(456, 66);
            this.lblAccountingDebit.Name = "lblAccountingDebit";
            this.lblAccountingDebit.Size = new System.Drawing.Size(49, 16);
            this.lblAccountingDebit.TabIndex = 33;
            this.lblAccountingDebit.Text = "0";
            // 
            // lblAccountingReceivable
            // 
            this.lblAccountingReceivable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountingReceivable.Location = new System.Drawing.Point(304, 66);
            this.lblAccountingReceivable.Name = "lblAccountingReceivable";
            this.lblAccountingReceivable.Size = new System.Drawing.Size(51, 16);
            this.lblAccountingReceivable.TabIndex = 32;
            this.lblAccountingReceivable.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Toplam Borç:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Toplam Alacak:";
            // 
            // GenelMuhasebeYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 324);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAccountingDebit);
            this.Controls.Add(this.lblAccountingReceivable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAccountingReceipts);
            this.Controls.Add(this.rdbAccountingDebtReceipts);
            this.Controls.Add(this.rdbAccountingReceivableReceipts);
            this.Controls.Add(this.rdbAccountingAllReceipts);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtAccountingReceiptNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datReceiptDate2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datReceiptDate1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtAccountingReceiptList);
            this.MaximizeBox = false;
            this.Name = "GenelMuhasebeYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenelMuhasebeYonetimi";
            this.Load += new System.EventHandler(this.GenelMuhasebeYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtAccountingReceiptList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtAccountingReceiptList;
        private System.Windows.Forms.TextBox txtAccountingReceiptNo;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker datReceiptDate2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker datReceiptDate1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        public System.Windows.Forms.RadioButton rdbAccountingDebtReceipts;
        public System.Windows.Forms.RadioButton rdbAccountingReceivableReceipts;
        public System.Windows.Forms.RadioButton rdbAccountingAllReceipts;
        public System.Windows.Forms.Button btnAccountingReceipts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAccountingDebit;
        private System.Windows.Forms.Label lblAccountingReceivable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}