namespace StockTrackingERP
{
    partial class CariHesapFisEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariHesapFisEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.datReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbReceiptTypes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datDocumentDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.cmbReceiptExchange = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTLAmount = new System.Windows.Forms.TextBox();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbReceivable = new System.Windows.Forms.RadioButton();
            this.rdbDebit = new System.Windows.Forms.RadioButton();
            this.btnCurrentReceiptExit = new System.Windows.Forms.Button();
            this.btnCurrentReceiptAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Adı:";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.Location = new System.Drawing.Point(114, 24);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerCode.TabIndex = 2;
            this.lblCustomerCode.Text = "label3";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(114, 45);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "label3";
            // 
            // datReceiptDate
            // 
            this.datReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datReceiptDate.Location = new System.Drawing.Point(113, 68);
            this.datReceiptDate.Name = "datReceiptDate";
            this.datReceiptDate.Size = new System.Drawing.Size(140, 20);
            this.datReceiptDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fiş Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fiş Tipi:";
            // 
            // cmbReceiptTypes
            // 
            this.cmbReceiptTypes.FormattingEnabled = true;
            this.cmbReceiptTypes.Items.AddRange(new object[] {
            "Fatura",
            "Havale",
            "Dekont",
            "Çek",
            "Senet",
            "Virman",
            "Ödeme"});
            this.cmbReceiptTypes.Location = new System.Drawing.Point(113, 96);
            this.cmbReceiptTypes.Name = "cmbReceiptTypes";
            this.cmbReceiptTypes.Size = new System.Drawing.Size(140, 21);
            this.cmbReceiptTypes.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Belge Numarası:";
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(113, 126);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.Size = new System.Drawing.Size(140, 20);
            this.txtDocumentNo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Belge Tarihi:";
            // 
            // datDocumentDate
            // 
            this.datDocumentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDocumentDate.Location = new System.Drawing.Point(113, 154);
            this.datDocumentDate.Name = "datDocumentDate";
            this.datDocumentDate.Size = new System.Drawing.Size(140, 20);
            this.datDocumentDate.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Toplam Tutar:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(113, 184);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(140, 20);
            this.txtTotalAmount.TabIndex = 17;
            // 
            // cmbReceiptExchange
            // 
            this.cmbReceiptExchange.FormattingEnabled = true;
            this.cmbReceiptExchange.Items.AddRange(new object[] {
            "TL",
            "EUR",
            "USD",
            "GBP",
            "CHF",
            "JPY",
            "CNY"});
            this.cmbReceiptExchange.Location = new System.Drawing.Point(259, 184);
            this.cmbReceiptExchange.Name = "cmbReceiptExchange";
            this.cmbReceiptExchange.Size = new System.Drawing.Size(69, 21);
            this.cmbReceiptExchange.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "TL Tutar:";
            // 
            // txtTLAmount
            // 
            this.txtTLAmount.Location = new System.Drawing.Point(113, 213);
            this.txtTLAmount.Name = "txtTLAmount";
            this.txtTLAmount.Size = new System.Drawing.Size(140, 20);
            this.txtTLAmount.TabIndex = 29;
            // 
            // txtExplanation
            // 
            this.txtExplanation.Location = new System.Drawing.Point(113, 240);
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(140, 20);
            this.txtExplanation.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Açıklama:";
            // 
            // rdbReceivable
            // 
            this.rdbReceivable.AutoSize = true;
            this.rdbReceivable.Location = new System.Drawing.Point(75, 276);
            this.rdbReceivable.Name = "rdbReceivable";
            this.rdbReceivable.Size = new System.Drawing.Size(58, 17);
            this.rdbReceivable.TabIndex = 32;
            this.rdbReceivable.TabStop = true;
            this.rdbReceivable.Text = "Alacak";
            this.rdbReceivable.UseVisualStyleBackColor = true;
            this.rdbReceivable.CheckedChanged += new System.EventHandler(this.rdbReceivable_CheckedChanged);
            // 
            // rdbDebit
            // 
            this.rdbDebit.AutoSize = true;
            this.rdbDebit.Location = new System.Drawing.Point(209, 276);
            this.rdbDebit.Name = "rdbDebit";
            this.rdbDebit.Size = new System.Drawing.Size(47, 17);
            this.rdbDebit.TabIndex = 33;
            this.rdbDebit.TabStop = true;
            this.rdbDebit.Text = "Borç";
            this.rdbDebit.UseVisualStyleBackColor = true;
            this.rdbDebit.CheckedChanged += new System.EventHandler(this.rdbDebit_CheckedChanged);
            // 
            // btnCurrentReceiptExit
            // 
            this.btnCurrentReceiptExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentReceiptExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCurrentReceiptExit.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrentReceiptExit.Image")));
            this.btnCurrentReceiptExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurrentReceiptExit.Location = new System.Drawing.Point(187, 312);
            this.btnCurrentReceiptExit.Name = "btnCurrentReceiptExit";
            this.btnCurrentReceiptExit.Size = new System.Drawing.Size(94, 30);
            this.btnCurrentReceiptExit.TabIndex = 35;
            this.btnCurrentReceiptExit.Text = "Çıkış";
            this.btnCurrentReceiptExit.UseVisualStyleBackColor = true;
            this.btnCurrentReceiptExit.Click += new System.EventHandler(this.btnCurrentReceiptExit_Click);
            // 
            // btnCurrentReceiptAdd
            // 
            this.btnCurrentReceiptAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentReceiptAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCurrentReceiptAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrentReceiptAdd.Image")));
            this.btnCurrentReceiptAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurrentReceiptAdd.Location = new System.Drawing.Point(46, 312);
            this.btnCurrentReceiptAdd.Name = "btnCurrentReceiptAdd";
            this.btnCurrentReceiptAdd.Size = new System.Drawing.Size(94, 30);
            this.btnCurrentReceiptAdd.TabIndex = 34;
            this.btnCurrentReceiptAdd.Text = "Ekle";
            this.btnCurrentReceiptAdd.UseVisualStyleBackColor = true;
            this.btnCurrentReceiptAdd.Click += new System.EventHandler(this.btnCurrentReceiptAdd_Click);
            // 
            // CariHesapFisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 355);
            this.Controls.Add(this.btnCurrentReceiptExit);
            this.Controls.Add(this.btnCurrentReceiptAdd);
            this.Controls.Add(this.rdbDebit);
            this.Controls.Add(this.rdbReceivable);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTLAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbReceiptExchange);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datDocumentDate);
            this.Controls.Add(this.txtDocumentNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbReceiptTypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datReceiptDate);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CariHesapFisEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CariHesapFisEkle";
            this.Load += new System.EventHandler(this.CariHesapFisEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblCustomerCode;
        public System.Windows.Forms.Label lblCustomerName;
        public System.Windows.Forms.DateTimePicker datReceiptDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker datDocumentDate;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTotalAmount;
        public System.Windows.Forms.ComboBox cmbReceiptExchange;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtTLAmount;
        public System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnCurrentReceiptExit;
        public System.Windows.Forms.Button btnCurrentReceiptAdd;
        public System.Windows.Forms.ComboBox cmbReceiptTypes;
        public System.Windows.Forms.RadioButton rdbReceivable;
        public System.Windows.Forms.RadioButton rdbDebit;
    }
}