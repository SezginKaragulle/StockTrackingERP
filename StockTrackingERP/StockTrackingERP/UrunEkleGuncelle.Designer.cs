namespace StockTrackingERP
{
    partial class UrunEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkleGuncelle));
            this.btnProductExit = new System.Windows.Forms.Button();
            this.btnProductAddUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnProductExit
            // 
            this.btnProductExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductExit.Image = ((System.Drawing.Image)(resources.GetObject("btnProductExit.Image")));
            this.btnProductExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductExit.Location = new System.Drawing.Point(157, 98);
            this.btnProductExit.Name = "btnProductExit";
            this.btnProductExit.Size = new System.Drawing.Size(94, 30);
            this.btnProductExit.TabIndex = 18;
            this.btnProductExit.Text = "Çıkış";
            this.btnProductExit.UseVisualStyleBackColor = true;
            this.btnProductExit.Click += new System.EventHandler(this.btnProductExit_Click);
            // 
            // btnProductAddUpdate
            // 
            this.btnProductAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductAddUpdate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductAddUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnProductAddUpdate.Image")));
            this.btnProductAddUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductAddUpdate.Location = new System.Drawing.Point(16, 98);
            this.btnProductAddUpdate.Name = "btnProductAddUpdate";
            this.btnProductAddUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnProductAddUpdate.TabIndex = 17;
            this.btnProductAddUpdate.Text = "Ekle";
            this.btnProductAddUpdate.UseVisualStyleBackColor = true;
            this.btnProductAddUpdate.Click += new System.EventHandler(this.btnProductAddUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ürün Tipi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(70, 23);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(183, 20);
            this.txtProductName.TabIndex = 13;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(260, 26);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(0, 13);
            this.lblProductCode.TabIndex = 19;
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(70, 52);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(183, 21);
            this.cmbProductType.TabIndex = 20;
            // 
            // UrunEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 144);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.btnProductExit);
            this.Controls.Add(this.btnProductAddUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductName);
            this.MaximizeBox = false;
            this.Name = "UrunEkleGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Bilgileri";
            this.Load += new System.EventHandler(this.UrunEkleGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.Button btnProductExit;
        public System.Windows.Forms.Button btnProductAddUpdate;
        public System.Windows.Forms.Label lblProductCode;
        public System.Windows.Forms.ComboBox cmbProductType;
    }
}