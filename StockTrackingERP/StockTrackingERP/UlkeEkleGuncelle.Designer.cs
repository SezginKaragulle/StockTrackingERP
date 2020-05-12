namespace StockTrackingERP
{
    partial class UlkeEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UlkeEkleGuncelle));
            this.btnCountryExit = new System.Windows.Forms.Button();
            this.btnCountryAddUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCountryExit
            // 
            this.btnCountryExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountryExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCountryExit.Image = ((System.Drawing.Image)(resources.GetObject("btnCountryExit.Image")));
            this.btnCountryExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCountryExit.Location = new System.Drawing.Point(152, 44);
            this.btnCountryExit.Name = "btnCountryExit";
            this.btnCountryExit.Size = new System.Drawing.Size(94, 30);
            this.btnCountryExit.TabIndex = 13;
            this.btnCountryExit.Text = "Çıkış";
            this.btnCountryExit.UseVisualStyleBackColor = true;
            this.btnCountryExit.Click += new System.EventHandler(this.btnCountryExit_Click);
            // 
            // btnCountryAddUpdate
            // 
            this.btnCountryAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountryAddUpdate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCountryAddUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnCountryAddUpdate.Image")));
            this.btnCountryAddUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCountryAddUpdate.Location = new System.Drawing.Point(35, 44);
            this.btnCountryAddUpdate.Name = "btnCountryAddUpdate";
            this.btnCountryAddUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnCountryAddUpdate.TabIndex = 12;
            this.btnCountryAddUpdate.Text = "Ekle";
            this.btnCountryAddUpdate.UseVisualStyleBackColor = true;
            this.btnCountryAddUpdate.Click += new System.EventHandler(this.btnCountryAddUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ülke Adı:";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(65, 7);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(178, 20);
            this.txtCountryName.TabIndex = 15;
            // 
            // UlkeEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 78);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCountryExit);
            this.Controls.Add(this.btnCountryAddUpdate);
            this.MaximizeBox = false;
            this.Name = "UlkeEkleGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ülke Bilgileri";
            this.Load += new System.EventHandler(this.UlkeEkleGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCountryExit;
        public System.Windows.Forms.Button btnCountryAddUpdate;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCountryName;
    }
}