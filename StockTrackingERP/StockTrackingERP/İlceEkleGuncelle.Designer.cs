namespace StockTrackingERP
{
    partial class İlceEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İlceEkleGuncelle));
            this.btnDistrictExit = new System.Windows.Forms.Button();
            this.btnDistrictAddUpdate = new System.Windows.Forms.Button();
            this.txtCountryID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProvinceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistrictName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDistrictExit
            // 
            this.btnDistrictExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistrictExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDistrictExit.Image = ((System.Drawing.Image)(resources.GetObject("btnDistrictExit.Image")));
            this.btnDistrictExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDistrictExit.Location = new System.Drawing.Point(134, 109);
            this.btnDistrictExit.Name = "btnDistrictExit";
            this.btnDistrictExit.Size = new System.Drawing.Size(94, 30);
            this.btnDistrictExit.TabIndex = 21;
            this.btnDistrictExit.Text = "Çıkış";
            this.btnDistrictExit.UseVisualStyleBackColor = true;
            this.btnDistrictExit.Click += new System.EventHandler(this.btnDistrictExit_Click);
            // 
            // btnDistrictAddUpdate
            // 
            this.btnDistrictAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistrictAddUpdate.ForeColor = System.Drawing.Color.Teal;
            this.btnDistrictAddUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnDistrictAddUpdate.Image")));
            this.btnDistrictAddUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDistrictAddUpdate.Location = new System.Drawing.Point(17, 109);
            this.btnDistrictAddUpdate.Name = "btnDistrictAddUpdate";
            this.btnDistrictAddUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnDistrictAddUpdate.TabIndex = 20;
            this.btnDistrictAddUpdate.Text = "Ekle";
            this.btnDistrictAddUpdate.UseVisualStyleBackColor = true;
            this.btnDistrictAddUpdate.Click += new System.EventHandler(this.btnDistrictAddUpdate_Click);
            // 
            // txtCountryID
            // 
            this.txtCountryID.Location = new System.Drawing.Point(72, 77);
            this.txtCountryID.Name = "txtCountryID";
            this.txtCountryID.Size = new System.Drawing.Size(150, 20);
            this.txtCountryID.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ülke Kodu:";
            // 
            // txtProvinceID
            // 
            this.txtProvinceID.Location = new System.Drawing.Point(72, 51);
            this.txtProvinceID.Name = "txtProvinceID";
            this.txtProvinceID.Size = new System.Drawing.Size(150, 20);
            this.txtProvinceID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "İl Kodu:";
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.Location = new System.Drawing.Point(72, 25);
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(150, 20);
            this.txtDistrictName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "İlçe Adı:";
            // 
            // İlceEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(241, 152);
            this.Controls.Add(this.btnDistrictExit);
            this.Controls.Add(this.btnDistrictAddUpdate);
            this.Controls.Add(this.txtCountryID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProvinceID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDistrictName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "İlceEkleGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlçe Bilgileri";
            this.Load += new System.EventHandler(this.İlceEkleGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnDistrictExit;
        public System.Windows.Forms.Button btnDistrictAddUpdate;
        public System.Windows.Forms.TextBox txtCountryID;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtProvinceID;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDistrictName;
        public System.Windows.Forms.Label label1;
    }
}