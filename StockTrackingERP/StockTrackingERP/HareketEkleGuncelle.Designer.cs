namespace StockTrackingERP
{
    partial class HareketEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HareketEkleGuncelle));
            this.btnStockActionExit = new System.Windows.Forms.Button();
            this.btnStockActionAddUpdate = new System.Windows.Forms.Button();
            this.txtProductCount = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStockActionExit
            // 
            this.btnStockActionExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockActionExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnStockActionExit.Image = ((System.Drawing.Image)(resources.GetObject("btnStockActionExit.Image")));
            this.btnStockActionExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStockActionExit.Location = new System.Drawing.Point(163, 100);
            this.btnStockActionExit.Name = "btnStockActionExit";
            this.btnStockActionExit.Size = new System.Drawing.Size(94, 30);
            this.btnStockActionExit.TabIndex = 22;
            this.btnStockActionExit.Text = "Çıkış";
            this.btnStockActionExit.UseVisualStyleBackColor = true;
            this.btnStockActionExit.Click += new System.EventHandler(this.btnStockActionExit_Click);
            // 
            // btnStockActionAddUpdate
            // 
            this.btnStockActionAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockActionAddUpdate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnStockActionAddUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnStockActionAddUpdate.Image")));
            this.btnStockActionAddUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStockActionAddUpdate.Location = new System.Drawing.Point(22, 100);
            this.btnStockActionAddUpdate.Name = "btnStockActionAddUpdate";
            this.btnStockActionAddUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnStockActionAddUpdate.TabIndex = 21;
            this.btnStockActionAddUpdate.Text = "Ekle";
            this.btnStockActionAddUpdate.UseVisualStyleBackColor = true;
            this.btnStockActionAddUpdate.Click += new System.EventHandler(this.btnStockActionAddUpdate_Click);
            // 
            // txtProductCount
            // 
            this.txtProductCount.Location = new System.Drawing.Point(83, 62);
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.Size = new System.Drawing.Size(145, 20);
            this.txtProductCount.TabIndex = 20;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(83, 36);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(145, 20);
            this.txtProductName.TabIndex = 19;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(83, 12);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(145, 20);
            this.txtProductCode.TabIndex = 18;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Adet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ürün Kodu:";
            // 
            // HareketEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(301, 142);
            this.Controls.Add(this.btnStockActionExit);
            this.Controls.Add(this.btnStockActionAddUpdate);
            this.Controls.Add(this.txtProductCount);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "HareketEkleGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hareket Bilgileri";
            this.Load += new System.EventHandler(this.HareketEkleGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnStockActionExit;
        public System.Windows.Forms.Button btnStockActionAddUpdate;
        public System.Windows.Forms.TextBox txtProductCount;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}