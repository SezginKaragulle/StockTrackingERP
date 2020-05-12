namespace StockTrackingERP
{
    partial class MuhasebeFisEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuhasebeFisEkle));
            this.btnCurrentReceiptExit = new System.Windows.Forms.Button();
            this.btnCurrentReceiptAdd = new System.Windows.Forms.Button();
            this.rdbDebit = new System.Windows.Forms.RadioButton();
            this.rdbReceivable = new System.Windows.Forms.RadioButton();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTLAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbReceiptExchange = new System.Windows.Forms.ComboBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datDocumentDate = new System.Windows.Forms.DateTimePicker();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbReceiptTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCurrentReceiptExit
            // 
            this.btnCurrentReceiptExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnCurrentReceiptExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentReceiptExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCurrentReceiptExit.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrentReceiptExit.Image")));
            this.btnCurrentReceiptExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurrentReceiptExit.Location = new System.Drawing.Point(161, 267);
            this.btnCurrentReceiptExit.Name = "btnCurrentReceiptExit";
            this.btnCurrentReceiptExit.Size = new System.Drawing.Size(94, 30);
            this.btnCurrentReceiptExit.TabIndex = 54;
            this.btnCurrentReceiptExit.Text = "Çıkış";
            this.btnCurrentReceiptExit.UseVisualStyleBackColor = true;
            this.btnCurrentReceiptExit.Click += new System.EventHandler(this.btnCurrentReceiptExit_Click);
            // 
            // btnCurrentReceiptAdd
            // 
            this.btnCurrentReceiptAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnCurrentReceiptAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentReceiptAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCurrentReceiptAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrentReceiptAdd.Image")));
            this.btnCurrentReceiptAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurrentReceiptAdd.Location = new System.Drawing.Point(20, 267);
            this.btnCurrentReceiptAdd.Name = "btnCurrentReceiptAdd";
            this.btnCurrentReceiptAdd.Size = new System.Drawing.Size(94, 30);
            this.btnCurrentReceiptAdd.TabIndex = 53;
            this.btnCurrentReceiptAdd.Text = "Ekle";
            this.btnCurrentReceiptAdd.UseVisualStyleBackColor = true;
            this.btnCurrentReceiptAdd.Click += new System.EventHandler(this.btnCurrentReceiptAdd_Click);
            // 
            // rdbDebit
            // 
            this.rdbDebit.AutoSize = true;
            this.rdbDebit.Location = new System.Drawing.Point(183, 231);
            this.rdbDebit.Name = "rdbDebit";
            this.rdbDebit.Size = new System.Drawing.Size(47, 17);
            this.rdbDebit.TabIndex = 52;
            this.rdbDebit.TabStop = true;
            this.rdbDebit.Text = "Borç";
            this.rdbDebit.UseVisualStyleBackColor = true;
            this.rdbDebit.CheckedChanged += new System.EventHandler(this.rdbDebit_CheckedChanged);
            // 
            // rdbReceivable
            // 
            this.rdbReceivable.AutoSize = true;
            this.rdbReceivable.Location = new System.Drawing.Point(49, 231);
            this.rdbReceivable.Name = "rdbReceivable";
            this.rdbReceivable.Size = new System.Drawing.Size(58, 17);
            this.rdbReceivable.TabIndex = 51;
            this.rdbReceivable.TabStop = true;
            this.rdbReceivable.Text = "Alacak";
            this.rdbReceivable.UseVisualStyleBackColor = true;
            this.rdbReceivable.CheckedChanged += new System.EventHandler(this.rdbReceivable_CheckedChanged);
            // 
            // txtExplanation
            // 
            this.txtExplanation.Location = new System.Drawing.Point(87, 195);
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(140, 20);
            this.txtExplanation.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Açıklama:";
            // 
            // txtTLAmount
            // 
            this.txtTLAmount.Location = new System.Drawing.Point(87, 168);
            this.txtTLAmount.Name = "txtTLAmount";
            this.txtTLAmount.Size = new System.Drawing.Size(140, 20);
            this.txtTLAmount.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "TL Tutar:";
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
            this.cmbReceiptExchange.Location = new System.Drawing.Point(233, 139);
            this.cmbReceiptExchange.Name = "cmbReceiptExchange";
            this.cmbReceiptExchange.Size = new System.Drawing.Size(69, 21);
            this.cmbReceiptExchange.TabIndex = 46;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(87, 139);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(140, 20);
            this.txtTotalAmount.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Toplam Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Belge Tarihi:";
            // 
            // datDocumentDate
            // 
            this.datDocumentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDocumentDate.Location = new System.Drawing.Point(87, 109);
            this.datDocumentDate.Name = "datDocumentDate";
            this.datDocumentDate.Size = new System.Drawing.Size(140, 20);
            this.datDocumentDate.TabIndex = 42;
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(87, 81);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.Size = new System.Drawing.Size(140, 20);
            this.txtDocumentNo.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Belge Numarası:";
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
            "Ödeme",
            "Muhasebe Fişi",
            "Banka Dekontu"});
            this.cmbReceiptTypes.Location = new System.Drawing.Point(87, 51);
            this.cmbReceiptTypes.Name = "cmbReceiptTypes";
            this.cmbReceiptTypes.Size = new System.Drawing.Size(140, 21);
            this.cmbReceiptTypes.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fiş Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Fiş Tarihi:";
            // 
            // datReceiptDate
            // 
            this.datReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datReceiptDate.Location = new System.Drawing.Point(87, 23);
            this.datReceiptDate.Name = "datReceiptDate";
            this.datReceiptDate.Size = new System.Drawing.Size(140, 20);
            this.datReceiptDate.TabIndex = 36;
            // 
            // MuhasebeFisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(313, 306);
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
            this.Name = "MuhasebeFisEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhasebe Fişi";
            this.Load += new System.EventHandler(this.MuhasebeFisEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCurrentReceiptExit;
        public System.Windows.Forms.Button btnCurrentReceiptAdd;
        public System.Windows.Forms.RadioButton rdbDebit;
        public System.Windows.Forms.RadioButton rdbReceivable;
        public System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtTLAmount;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmbReceiptExchange;
        public System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker datDocumentDate;
        public System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbReceiptTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker datReceiptDate;
    }
}