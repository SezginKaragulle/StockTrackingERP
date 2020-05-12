namespace StockTrackingERP
{
    partial class KullanıcıEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıEkleGuncelle));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUserAddUpdate = new System.Windows.Forms.Button();
            this.btnUserExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Kodu:";
            // 
            // txtUserCode
            // 
            this.txtUserCode.Location = new System.Drawing.Point(79, 14);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(152, 20);
            this.txtUserCode.TabIndex = 1;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(79, 38);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(152, 20);
            this.txtUserPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(79, 63);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(152, 20);
            this.txtNameSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adı ve Soyadı:";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(79, 89);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(152, 20);
            this.txtEMail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-Mail:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(79, 116);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(152, 20);
            this.txtTelephone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon:";
            // 
            // btnUserAddUpdate
            // 
            this.btnUserAddUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnUserAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAddUpdate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUserAddUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAddUpdate.Image")));
            this.btnUserAddUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserAddUpdate.Location = new System.Drawing.Point(7, 153);
            this.btnUserAddUpdate.Name = "btnUserAddUpdate";
            this.btnUserAddUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnUserAddUpdate.TabIndex = 10;
            this.btnUserAddUpdate.Text = "Ekle";
            this.btnUserAddUpdate.UseVisualStyleBackColor = true;
            this.btnUserAddUpdate.Click += new System.EventHandler(this.btnUserAddUpdate_Click);
            // 
            // btnUserExit
            // 
            this.btnUserExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnUserExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUserExit.Image = ((System.Drawing.Image)(resources.GetObject("btnUserExit.Image")));
            this.btnUserExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserExit.Location = new System.Drawing.Point(132, 153);
            this.btnUserExit.Name = "btnUserExit";
            this.btnUserExit.Size = new System.Drawing.Size(94, 30);
            this.btnUserExit.TabIndex = 11;
            this.btnUserExit.Text = "Çıkış";
            this.btnUserExit.UseVisualStyleBackColor = true;
            this.btnUserExit.Click += new System.EventHandler(this.btnUserExit_Click);
            // 
            // KullanıcıEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 199);
            this.Controls.Add(this.btnUserExit);
            this.Controls.Add(this.btnUserAddUpdate);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserCode);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "KullanıcıEkleGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Bilgileri";
            this.Load += new System.EventHandler(this.KullanıcıEkleGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtUserCode;
        public System.Windows.Forms.TextBox txtUserPassword;
        public System.Windows.Forms.TextBox txtNameSurname;
        public System.Windows.Forms.TextBox txtEMail;
        public System.Windows.Forms.TextBox txtTelephone;
        public System.Windows.Forms.Button btnUserAddUpdate;
        public System.Windows.Forms.Button btnUserExit;
    }
}