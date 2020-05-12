namespace StockTrackingERP
{
    partial class UrunTipEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunTipEkleGuncelle));
            this.txtProductTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductTypeExit = new System.Windows.Forms.Button();
            this.btnProductTypeAddUpdate = new System.Windows.Forms.Button();
            this.lblProductTypeID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProductTypeName
            // 
            this.txtProductTypeName.Location = new System.Drawing.Point(80, 6);
            this.txtProductTypeName.Name = "txtProductTypeName";
            this.txtProductTypeName.Size = new System.Drawing.Size(178, 20);
            this.txtProductTypeName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ürün Tipi:";
            // 
            // btnProductTypeExit
            // 
            this.btnProductTypeExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductTypeExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductTypeExit.Image = ((System.Drawing.Image)(resources.GetObject("btnProductTypeExit.Image")));
            this.btnProductTypeExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductTypeExit.Location = new System.Drawing.Point(222, 43);
            this.btnProductTypeExit.Name = "btnProductTypeExit";
            this.btnProductTypeExit.Size = new System.Drawing.Size(94, 30);
            this.btnProductTypeExit.TabIndex = 17;
            this.btnProductTypeExit.Text = "Çıkış";
            this.btnProductTypeExit.UseVisualStyleBackColor = true;
            this.btnProductTypeExit.Click += new System.EventHandler(this.btnProductTypeExit_Click);
            // 
            // btnProductTypeAddUpdate
            // 
            this.btnProductTypeAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductTypeAddUpdate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductTypeAddUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnProductTypeAddUpdate.Image")));
            this.btnProductTypeAddUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductTypeAddUpdate.Location = new System.Drawing.Point(50, 43);
            this.btnProductTypeAddUpdate.Name = "btnProductTypeAddUpdate";
            this.btnProductTypeAddUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnProductTypeAddUpdate.TabIndex = 16;
            this.btnProductTypeAddUpdate.Text = "Ekle";
            this.btnProductTypeAddUpdate.UseVisualStyleBackColor = true;
            this.btnProductTypeAddUpdate.Click += new System.EventHandler(this.btnProductTypeAddUpdate_Click);
            // 
            // lblProductTypeID
            // 
            this.lblProductTypeID.AutoSize = true;
            this.lblProductTypeID.Location = new System.Drawing.Point(265, 9);
            this.lblProductTypeID.Name = "lblProductTypeID";
            this.lblProductTypeID.Size = new System.Drawing.Size(0, 13);
            this.lblProductTypeID.TabIndex = 20;
            // 
            // UrunTipEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 78);
            this.Controls.Add(this.lblProductTypeID);
            this.Controls.Add(this.txtProductTypeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProductTypeExit);
            this.Controls.Add(this.btnProductTypeAddUpdate);
            this.MaximizeBox = false;
            this.Name = "UrunTipEkleGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Tip Bilgileri";
            this.Load += new System.EventHandler(this.UrunTipEkleGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtProductTypeName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnProductTypeExit;
        public System.Windows.Forms.Button btnProductTypeAddUpdate;
        public System.Windows.Forms.Label lblProductTypeID;
    }
}