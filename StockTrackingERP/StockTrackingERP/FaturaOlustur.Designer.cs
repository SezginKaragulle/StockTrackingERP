namespace StockTrackingERP
{
    partial class FaturaOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaOlustur));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.dtInvoicesDetails = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.cmbInvoiceExchange = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalAmountNoVat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVatAmout = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTLAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPaymentDay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.datDueDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnInvoiceCreating = new System.Windows.Forms.Button();
            this.btnInvoiceBack = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoicesDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Kodu:";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(84, 10);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(140, 20);
            this.txtCustomerCode.TabIndex = 1;
            this.txtCustomerCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Adı:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(84, 36);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(140, 20);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fatura Numarası:";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Location = new System.Drawing.Point(335, 9);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(140, 20);
            this.txtInvoiceNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fatura Tarihi:";
            // 
            // datInvoiceDate
            // 
            this.datInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datInvoiceDate.Location = new System.Drawing.Point(335, 34);
            this.datInvoiceDate.Name = "datInvoiceDate";
            this.datInvoiceDate.Size = new System.Drawing.Size(140, 20);
            this.datInvoiceDate.TabIndex = 7;
            // 
            // dtInvoicesDetails
            // 
            this.dtInvoicesDetails.BackgroundColor = System.Drawing.Color.White;
            this.dtInvoicesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInvoicesDetails.Location = new System.Drawing.Point(12, 374);
            this.dtInvoicesDetails.Name = "dtInvoicesDetails";
            this.dtInvoicesDetails.ReadOnly = true;
            this.dtInvoicesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtInvoicesDetails.Size = new System.Drawing.Size(637, 179);
            this.dtInvoicesDetails.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Toplam Tutar:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(102, 187);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(140, 20);
            this.txtTotalAmount.TabIndex = 10;
            this.txtTotalAmount.Text = "0";
            // 
            // cmbInvoiceExchange
            // 
            this.cmbInvoiceExchange.FormattingEnabled = true;
            this.cmbInvoiceExchange.Items.AddRange(new object[] {
            "TL",
            "EUR",
            "USD",
            "GBP",
            "CHF",
            "JPY",
            "CNY"});
            this.cmbInvoiceExchange.Location = new System.Drawing.Point(248, 187);
            this.cmbInvoiceExchange.Name = "cmbInvoiceExchange";
            this.cmbInvoiceExchange.Size = new System.Drawing.Size(69, 21);
            this.cmbInvoiceExchange.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kdvsiz Tutar:";
            // 
            // txtTotalAmountNoVat
            // 
            this.txtTotalAmountNoVat.Enabled = false;
            this.txtTotalAmountNoVat.Location = new System.Drawing.Point(102, 214);
            this.txtTotalAmountNoVat.Name = "txtTotalAmountNoVat";
            this.txtTotalAmountNoVat.Size = new System.Drawing.Size(140, 20);
            this.txtTotalAmountNoVat.TabIndex = 15;
            this.txtTotalAmountNoVat.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kdv Tutarı:";
            // 
            // txtVatAmout
            // 
            this.txtVatAmout.Enabled = false;
            this.txtVatAmout.Location = new System.Drawing.Point(102, 242);
            this.txtVatAmout.Name = "txtVatAmout";
            this.txtVatAmout.Size = new System.Drawing.Size(140, 20);
            this.txtVatAmout.TabIndex = 19;
            this.txtVatAmout.Text = "0";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Enabled = false;
            this.txtDiscountAmount.Location = new System.Drawing.Point(102, 268);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(140, 20);
            this.txtDiscountAmount.TabIndex = 21;
            this.txtDiscountAmount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "İndirim Tutarı:";
            // 
            // txtTLAmount
            // 
            this.txtTLAmount.Enabled = false;
            this.txtTLAmount.Location = new System.Drawing.Point(102, 293);
            this.txtTLAmount.Name = "txtTLAmount";
            this.txtTLAmount.Size = new System.Drawing.Size(140, 20);
            this.txtTLAmount.TabIndex = 23;
            this.txtTLAmount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "TL Tutarı:";
            // 
            // txtPaymentDay
            // 
            this.txtPaymentDay.Location = new System.Drawing.Point(335, 58);
            this.txtPaymentDay.Name = "txtPaymentDay";
            this.txtPaymentDay.Size = new System.Drawing.Size(140, 20);
            this.txtPaymentDay.TabIndex = 25;
            this.txtPaymentDay.Text = "0";
            this.txtPaymentDay.TextChanged += new System.EventHandler(this.txtPaymentDay_TextChanged);
            this.txtPaymentDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaymentDay_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ödeme Günü:";
            // 
            // datDueDate
            // 
            this.datDueDate.Enabled = false;
            this.datDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDueDate.Location = new System.Drawing.Point(102, 319);
            this.datDueDate.Name = "datDueDate";
            this.datDueDate.Size = new System.Drawing.Size(140, 20);
            this.datDueDate.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Son Ödeme Tarihi:";
            // 
            // btnInvoiceCreating
            // 
            this.btnInvoiceCreating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceCreating.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnInvoiceCreating.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoiceCreating.Image")));
            this.btnInvoiceCreating.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoiceCreating.Location = new System.Drawing.Point(19, 84);
            this.btnInvoiceCreating.Name = "btnInvoiceCreating";
            this.btnInvoiceCreating.Size = new System.Drawing.Size(124, 30);
            this.btnInvoiceCreating.TabIndex = 28;
            this.btnInvoiceCreating.Text = "Faturayı Oluştur";
            this.btnInvoiceCreating.UseVisualStyleBackColor = true;
            this.btnInvoiceCreating.Click += new System.EventHandler(this.btnInvoiceCreating_Click);
            // 
            // btnInvoiceBack
            // 
            this.btnInvoiceBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceBack.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnInvoiceBack.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoiceBack.Image")));
            this.btnInvoiceBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoiceBack.Location = new System.Drawing.Point(19, 122);
            this.btnInvoiceBack.Name = "btnInvoiceBack";
            this.btnInvoiceBack.Size = new System.Drawing.Size(124, 30);
            this.btnInvoiceBack.TabIndex = 29;
            this.btnInvoiceBack.Text = "Geri";
            this.btnInvoiceBack.UseVisualStyleBackColor = true;
            this.btnInvoiceBack.Click += new System.EventHandler(this.btnInvoiceBack_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnProductAdd.Image")));
            this.btnProductAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductAdd.Location = new System.Drawing.Point(19, 12);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(124, 30);
            this.btnProductAdd.TabIndex = 30;
            this.btnProductAdd.Text = "Ürün Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnProductDel
            // 
            this.btnProductDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDel.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductDel.Image = ((System.Drawing.Image)(resources.GetObject("btnProductDel.Image")));
            this.btnProductDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductDel.Location = new System.Drawing.Point(19, 48);
            this.btnProductDel.Name = "btnProductDel";
            this.btnProductDel.Size = new System.Drawing.Size(124, 30);
            this.btnProductDel.TabIndex = 31;
            this.btnProductDel.Text = "Ürün Sil";
            this.btnProductDel.UseVisualStyleBackColor = true;
            this.btnProductDel.Click += new System.EventHandler(this.btnProductDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProductAdd);
            this.groupBox1.Controls.Add(this.btnInvoiceBack);
            this.groupBox1.Controls.Add(this.btnProductDel);
            this.groupBox1.Controls.Add(this.btnInvoiceCreating);
            this.groupBox1.Location = new System.Drawing.Point(501, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 169);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // FaturaOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datDueDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPaymentDay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTLAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVatAmout);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalAmountNoVat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbInvoiceExchange);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtInvoicesDetails);
            this.Controls.Add(this.datInvoiceDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FaturaOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"";
            this.Load += new System.EventHandler(this.FaturaOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoicesDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dtInvoicesDetails;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCustomerCode;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtInvoiceNo;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker datInvoiceDate;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTotalAmount;
        public System.Windows.Forms.ComboBox cmbInvoiceExchange;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTotalAmountNoVat;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtVatAmout;
        public System.Windows.Forms.TextBox txtDiscountAmount;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtTLAmount;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtPaymentDay;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.DateTimePicker datDueDate;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btnInvoiceCreating;
        public System.Windows.Forms.Button btnInvoiceBack;
        public System.Windows.Forms.Button btnProductAdd;
        public System.Windows.Forms.Button btnProductDel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}