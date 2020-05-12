namespace StockTrackingERP
{
    partial class DepoYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoYonetimi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtStoreList = new System.Windows.Forms.DataGridView();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.araToolStripMenuItem,
            this.geriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // dtStoreList
            // 
            this.dtStoreList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtStoreList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtStoreList.BackgroundColor = System.Drawing.Color.White;
            this.dtStoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStoreList.Location = new System.Drawing.Point(3, 74);
            this.dtStoreList.Name = "dtStoreList";
            this.dtStoreList.ReadOnly = true;
            this.dtStoreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtStoreList.Size = new System.Drawing.Size(672, 179);
            this.dtStoreList.TabIndex = 5;
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(70, 51);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(158, 20);
            this.txtStoreName.TabIndex = 20;
            // 
            // txtStoreID
            // 
            this.txtStoreID.Location = new System.Drawing.Point(70, 27);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(158, 20);
            this.txtStoreID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Depo Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Depo Kod:";
            // 
            // DepoYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 278);
            this.Controls.Add(this.txtStoreName);
            this.Controls.Add(this.txtStoreID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtStoreList);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DepoYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepoYonetimi";
            this.Load += new System.EventHandler(this.DepoYonetimi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepoYonetimi_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        public System.Windows.Forms.DataGridView dtStoreList;
        public System.Windows.Forms.TextBox txtStoreName;
        public System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}