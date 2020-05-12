namespace StockTrackingERP
{
    partial class FaturaUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaUrunEkle));
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbInvoiceExchange = new System.Windows.Forms.ComboBox();
            this.txtProductAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductExchangeRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductVat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductDiscountRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInvoiceProductAdd = new System.Windows.Forms.Button();
            this.btnInvoiceProductExit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProductTotalAmount = new System.Windows.Forms.Label();
            this.lblProductTotalVatAmount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProductTotalDiscountAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblProductTLAmount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblStoreID = new System.Windows.Forms.Label();
            this.cmbStores = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblProductCurrentStock = new System.Windows.Forms.Label();
            this.lblProductExculindingVat = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(79, 71);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(145, 20);
            this.txtProductName.TabIndex = 23;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(79, 47);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(145, 20);
            this.txtProductCode.TabIndex = 22;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ürün Kodu:";
            // 
            // txtProductCount
            // 
            this.txtProductCount.Location = new System.Drawing.Point(79, 95);
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.Size = new System.Drawing.Size(145, 20);
            this.txtProductCount.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Miktar:";
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
            this.cmbInvoiceExchange.Location = new System.Drawing.Point(225, 121);
            this.cmbInvoiceExchange.Name = "cmbInvoiceExchange";
            this.cmbInvoiceExchange.Size = new System.Drawing.Size(69, 21);
            this.cmbInvoiceExchange.TabIndex = 26;
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.Location = new System.Drawing.Point(79, 121);
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.Size = new System.Drawing.Size(145, 20);
            this.txtProductAmount.TabIndex = 28;
            this.txtProductAmount.Text = "0";
            this.txtProductAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductAmount_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tutar:";
            // 
            // txtProductExchangeRate
            // 
            this.txtProductExchangeRate.Location = new System.Drawing.Point(78, 195);
            this.txtProductExchangeRate.Name = "txtProductExchangeRate";
            this.txtProductExchangeRate.Size = new System.Drawing.Size(145, 20);
            this.txtProductExchangeRate.TabIndex = 30;
            this.txtProductExchangeRate.Text = "1,000";
            this.txtProductExchangeRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductExchangeRate_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kur:";
            // 
            // txtProductVat
            // 
            this.txtProductVat.Location = new System.Drawing.Point(79, 143);
            this.txtProductVat.Name = "txtProductVat";
            this.txtProductVat.Size = new System.Drawing.Size(145, 20);
            this.txtProductVat.TabIndex = 32;
            this.txtProductVat.Text = "0";
            this.txtProductVat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductVat_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Kdv Oranı:";
            // 
            // txtProductDiscountRate
            // 
            this.txtProductDiscountRate.Location = new System.Drawing.Point(78, 169);
            this.txtProductDiscountRate.Name = "txtProductDiscountRate";
            this.txtProductDiscountRate.Size = new System.Drawing.Size(145, 20);
            this.txtProductDiscountRate.TabIndex = 34;
            this.txtProductDiscountRate.Text = "0";
            this.txtProductDiscountRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductDiscountRate_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "İndirim Oranı:";
            // 
            // btnInvoiceProductAdd
            // 
            this.btnInvoiceProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceProductAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnInvoiceProductAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoiceProductAdd.Image")));
            this.btnInvoiceProductAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoiceProductAdd.Location = new System.Drawing.Point(18, 356);
            this.btnInvoiceProductAdd.Name = "btnInvoiceProductAdd";
            this.btnInvoiceProductAdd.Size = new System.Drawing.Size(94, 30);
            this.btnInvoiceProductAdd.TabIndex = 35;
            this.btnInvoiceProductAdd.Text = "Kaydet";
            this.btnInvoiceProductAdd.UseVisualStyleBackColor = true;
            this.btnInvoiceProductAdd.Click += new System.EventHandler(this.btnInvoiceProductAdd_Click);
            // 
            // btnInvoiceProductExit
            // 
            this.btnInvoiceProductExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceProductExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnInvoiceProductExit.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoiceProductExit.Image")));
            this.btnInvoiceProductExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoiceProductExit.Location = new System.Drawing.Point(225, 356);
            this.btnInvoiceProductExit.Name = "btnInvoiceProductExit";
            this.btnInvoiceProductExit.Size = new System.Drawing.Size(94, 30);
            this.btnInvoiceProductExit.TabIndex = 36;
            this.btnInvoiceProductExit.Text = "Geri";
            this.btnInvoiceProductExit.UseVisualStyleBackColor = true;
            this.btnInvoiceProductExit.Click += new System.EventHandler(this.btnInvoiceProductExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Toplam Ürünün Tutarı:";
            // 
            // lblProductTotalAmount
            // 
            this.lblProductTotalAmount.Location = new System.Drawing.Point(146, 227);
            this.lblProductTotalAmount.Name = "lblProductTotalAmount";
            this.lblProductTotalAmount.Size = new System.Drawing.Size(100, 23);
            this.lblProductTotalAmount.TabIndex = 38;
            this.lblProductTotalAmount.Text = "0";
            // 
            // lblProductTotalVatAmount
            // 
            this.lblProductTotalVatAmount.Location = new System.Drawing.Point(146, 275);
            this.lblProductTotalVatAmount.Name = "lblProductTotalVatAmount";
            this.lblProductTotalVatAmount.Size = new System.Drawing.Size(100, 23);
            this.lblProductTotalVatAmount.TabIndex = 40;
            this.lblProductTotalVatAmount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Toplam Kdv Tutarı:";
            // 
            // lblProductTotalDiscountAmount
            // 
            this.lblProductTotalDiscountAmount.Location = new System.Drawing.Point(146, 299);
            this.lblProductTotalDiscountAmount.Name = "lblProductTotalDiscountAmount";
            this.lblProductTotalDiscountAmount.Size = new System.Drawing.Size(100, 23);
            this.lblProductTotalDiscountAmount.TabIndex = 42;
            this.lblProductTotalDiscountAmount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Toplam Ürün İndirim Tutarı:";
            // 
            // lblProductTLAmount
            // 
            this.lblProductTLAmount.Location = new System.Drawing.Point(146, 322);
            this.lblProductTLAmount.Name = "lblProductTLAmount";
            this.lblProductTLAmount.Size = new System.Drawing.Size(100, 23);
            this.lblProductTLAmount.TabIndex = 44;
            this.lblProductTLAmount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Toplam Ürün TL Tutarı:";
            // 
            // lblStoreID
            // 
            this.lblStoreID.AutoSize = true;
            this.lblStoreID.Location = new System.Drawing.Point(234, 25);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new System.Drawing.Size(13, 13);
            this.lblStoreID.TabIndex = 46;
            this.lblStoreID.Text = "0";
            // 
            // cmbStores
            // 
            this.cmbStores.FormattingEnabled = true;
            this.cmbStores.Location = new System.Drawing.Point(78, 20);
            this.cmbStores.Name = "cmbStores";
            this.cmbStores.Size = new System.Drawing.Size(146, 21);
            this.cmbStores.TabIndex = 45;
            this.cmbStores.SelectedIndexChanged += new System.EventHandler(this.cmbStores_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Depo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Mevcut Stok:";
            // 
            // lblProductCurrentStock
            // 
            this.lblProductCurrentStock.AutoSize = true;
            this.lblProductCurrentStock.Location = new System.Drawing.Point(302, 100);
            this.lblProductCurrentStock.Name = "lblProductCurrentStock";
            this.lblProductCurrentStock.Size = new System.Drawing.Size(10, 13);
            this.lblProductCurrentStock.TabIndex = 49;
            this.lblProductCurrentStock.Text = "-";
            // 
            // lblProductExculindingVat
            // 
            this.lblProductExculindingVat.Location = new System.Drawing.Point(146, 251);
            this.lblProductExculindingVat.Name = "lblProductExculindingVat";
            this.lblProductExculindingVat.Size = new System.Drawing.Size(100, 23);
            this.lblProductExculindingVat.TabIndex = 51;
            this.lblProductExculindingVat.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 251);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Kdv Hariç Tutar:";
            // 
            // FaturaUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 400);
            this.Controls.Add(this.lblProductExculindingVat);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblProductCurrentStock);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblStoreID);
            this.Controls.Add(this.cmbStores);
            this.Controls.Add(this.lblProductTLAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblProductTotalDiscountAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblProductTotalVatAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblProductTotalAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnInvoiceProductExit);
            this.Controls.Add(this.btnInvoiceProductAdd);
            this.Controls.Add(this.txtProductDiscountRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProductVat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProductExchangeRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbInvoiceExchange);
            this.Controls.Add(this.txtProductCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FaturaUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Ürün Bilgisi";
            this.Load += new System.EventHandler(this.FaturaUrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtProductCount;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbInvoiceExchange;
        public System.Windows.Forms.TextBox txtProductAmount;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtProductExchangeRate;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtProductVat;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtProductDiscountRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInvoiceProductAdd;
        private System.Windows.Forms.Button btnInvoiceProductExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProductTotalAmount;
        private System.Windows.Forms.Label lblProductTotalVatAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProductTotalDiscountAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblProductTLAmount;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblStoreID;
        public System.Windows.Forms.ComboBox cmbStores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblProductCurrentStock;
        private System.Windows.Forms.Label lblProductExculindingVat;
        private System.Windows.Forms.Label label15;
    }
}