namespace StockTrackingERP
{
    partial class SistemYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemYonetimi));
            this.dtUsersList = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genelKodBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSurName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsersList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtUsersList
            // 
            this.dtUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtUsersList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtUsersList.BackgroundColor = System.Drawing.Color.White;
            this.dtUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUsersList.Location = new System.Drawing.Point(2, 66);
            this.dtUsersList.Name = "dtUsersList";
            this.dtUsersList.ReadOnly = true;
            this.dtUsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtUsersList.Size = new System.Drawing.Size(762, 179);
            this.dtUsersList.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelKodBilgileriToolStripMenuItem,
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.araToolStripMenuItem,
            this.geriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genelKodBilgileriToolStripMenuItem
            // 
            this.genelKodBilgileriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("genelKodBilgileriToolStripMenuItem.Image")));
            this.genelKodBilgileriToolStripMenuItem.Name = "genelKodBilgileriToolStripMenuItem";
            this.genelKodBilgileriToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.genelKodBilgileriToolStripMenuItem.Text = "Genel Kod Bilgileri";
            this.genelKodBilgileriToolStripMenuItem.Click += new System.EventHandler(this.genelKodBilgileriToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ekleToolStripMenuItem.Image")));
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("güncelleToolStripMenuItem.Image")));
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("silToolStripMenuItem.Image")));
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("araToolStripMenuItem.Image")));
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.araToolStripMenuItem.Text = "Ara";
            this.araToolStripMenuItem.Click += new System.EventHandler(this.araToolStripMenuItem_Click);
            // 
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("geriToolStripMenuItem.Image")));
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.geriToolStripMenuItem.Text = "Geri";
            this.geriToolStripMenuItem.Click += new System.EventHandler(this.geriToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Kodu:";
            // 
            // txtUserCode
            // 
            this.txtUserCode.Location = new System.Drawing.Point(86, 40);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(100, 20);
            this.txtUserCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ad Soyad:";
            // 
            // txtNameSurName
            // 
            this.txtNameSurName.Location = new System.Drawing.Point(249, 39);
            this.txtNameSurName.Name = "txtNameSurName";
            this.txtNameSurName.Size = new System.Drawing.Size(100, 20);
            this.txtNameSurName.TabIndex = 8;
            // 
            // SistemYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 251);
            this.Controls.Add(this.txtNameSurName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtUsersList);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SistemYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Yönetimi";
            this.Load += new System.EventHandler(this.SistemYonetimi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SistemYonetimi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtUsersList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtUsersList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genelKodBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUserCode;
        public System.Windows.Forms.TextBox txtNameSurName;
    }
}