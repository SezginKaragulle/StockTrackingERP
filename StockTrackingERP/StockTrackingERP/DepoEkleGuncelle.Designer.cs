namespace StockTrackingERP
{
    partial class DepoEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoEkleGuncelle));
            this.btnStoreExit = new System.Windows.Forms.Button();
            this.btnStoreAddUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStoreCode = new System.Windows.Forms.TextBox();
            this.lblStoreID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStoreExit
            // 
            this.btnStoreExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnStoreExit.Image = ((System.Drawing.Image)(resources.GetObject("btnStoreExit.Image")));
            this.btnStoreExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStoreExit.Location = new System.Drawing.Point(171, 81);
            this.btnStoreExit.Name = "btnStoreExit";
            this.btnStoreExit.Size = new System.Drawing.Size(94, 30);
            this.btnStoreExit.TabIndex = 24;
            this.btnStoreExit.Text = "Çıkış";
            this.btnStoreExit.UseVisualStyleBackColor = true;
            this.btnStoreExit.Click += new System.EventHandler(this.btnStoreExit_Click);
            // 
            // btnStoreAddUpdate
            // 
            this.btnStoreAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreAddUpdate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnStoreAddUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnStoreAddUpdate.Image")));
            this.btnStoreAddUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStoreAddUpdate.Location = new System.Drawing.Point(30, 81);
            this.btnStoreAddUpdate.Name = "btnStoreAddUpdate";
            this.btnStoreAddUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnStoreAddUpdate.TabIndex = 23;
            this.btnStoreAddUpdate.Text = "Ekle";
            this.btnStoreAddUpdate.UseVisualStyleBackColor = true;
            this.btnStoreAddUpdate.Click += new System.EventHandler(this.btnStoreAddUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Depo Adı:";
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(74, 38);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(183, 20);
            this.txtStoreName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Depo Kodu:";
            // 
            // txtStoreCode
            // 
            this.txtStoreCode.Location = new System.Drawing.Point(75, 12);
            this.txtStoreCode.Name = "txtStoreCode";
            this.txtStoreCode.Size = new System.Drawing.Size(183, 20);
            this.txtStoreCode.TabIndex = 19;
            // 
            // lblStoreID
            // 
            this.lblStoreID.AutoSize = true;
            this.lblStoreID.Location = new System.Drawing.Point(265, 12);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new System.Drawing.Size(0, 13);
            this.lblStoreID.TabIndex = 25;
            // 
            // DepoEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 123);
            this.Controls.Add(this.lblStoreID);
            this.Controls.Add(this.btnStoreExit);
            this.Controls.Add(this.btnStoreAddUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStoreName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStoreCode);
            this.MaximizeBox = false;
            this.Name = "DepoEkleGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Bilgileri";
            this.Load += new System.EventHandler(this.DepoEkleGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblStoreID;
        public System.Windows.Forms.Button btnStoreExit;
        public System.Windows.Forms.Button btnStoreAddUpdate;
        public System.Windows.Forms.TextBox txtStoreName;
        public System.Windows.Forms.TextBox txtStoreCode;
    }
}