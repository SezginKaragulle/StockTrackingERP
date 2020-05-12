namespace StockTrackingERP
{
    partial class İlEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İlEkleGuncelle));
            this.label1 = new System.Windows.Forms.Label();
            this.txtProvinceCode = new System.Windows.Forms.TextBox();
            this.txtProvinceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProvinceExit = new System.Windows.Forms.Button();
            this.btnProvinceAddUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl Kodu:";
            // 
            // txtProvinceCode
            // 
            this.txtProvinceCode.Location = new System.Drawing.Point(75, 22);
            this.txtProvinceCode.Name = "txtProvinceCode";
            this.txtProvinceCode.Size = new System.Drawing.Size(150, 20);
            this.txtProvinceCode.TabIndex = 1;
            // 
            // txtProvinceName
            // 
            this.txtProvinceName.Location = new System.Drawing.Point(75, 48);
            this.txtProvinceName.Name = "txtProvinceName";
            this.txtProvinceName.Size = new System.Drawing.Size(150, 20);
            this.txtProvinceName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İl Adı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(75, 74);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(150, 20);
            this.txtCountryCode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ülke Kodu:";
            // 
            // btnProvinceExit
            // 
            this.btnProvinceExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvinceExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProvinceExit.Image = ((System.Drawing.Image)(resources.GetObject("btnProvinceExit.Image")));
            this.btnProvinceExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProvinceExit.Location = new System.Drawing.Point(137, 106);
            this.btnProvinceExit.Name = "btnProvinceExit";
            this.btnProvinceExit.Size = new System.Drawing.Size(94, 30);
            this.btnProvinceExit.TabIndex = 13;
            this.btnProvinceExit.Text = "Çıkış";
            this.btnProvinceExit.UseVisualStyleBackColor = true;
            this.btnProvinceExit.Click += new System.EventHandler(this.btnProvinceExit_Click);
            // 
            // btnProvinceAddUpdate
            // 
            this.btnProvinceAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvinceAddUpdate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProvinceAddUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnProvinceAddUpdate.Image")));
            this.btnProvinceAddUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProvinceAddUpdate.Location = new System.Drawing.Point(20, 106);
            this.btnProvinceAddUpdate.Name = "btnProvinceAddUpdate";
            this.btnProvinceAddUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnProvinceAddUpdate.TabIndex = 12;
            this.btnProvinceAddUpdate.Text = "Ekle";
            this.btnProvinceAddUpdate.UseVisualStyleBackColor = true;
            this.btnProvinceAddUpdate.Click += new System.EventHandler(this.btnProvinceAddUpdate_Click);
            // 
            // İlEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(247, 154);
            this.Controls.Add(this.btnProvinceExit);
            this.Controls.Add(this.btnProvinceAddUpdate);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProvinceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProvinceCode);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "İlEkleGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İl Bilgileri";
            this.Load += new System.EventHandler(this.İlEkleGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnProvinceExit;
        public System.Windows.Forms.Button btnProvinceAddUpdate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtProvinceCode;
        public System.Windows.Forms.TextBox txtProvinceName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCountryCode;
        public System.Windows.Forms.Label label3;
    }
}