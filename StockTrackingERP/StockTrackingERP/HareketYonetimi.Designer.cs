namespace StockTrackingERP
{
    partial class HareketYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HareketYonetimi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtStockActionList = new System.Windows.Forms.DataGridView();
            this.lblActionNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAllStockActionAdd = new System.Windows.Forms.Button();
            this.lbl_StoreName = new System.Windows.Forms.Label();
            this.lbl_StockID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStockActionList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.geriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
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
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("geriToolStripMenuItem.Image")));
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.geriToolStripMenuItem.Text = "Geri";
            this.geriToolStripMenuItem.Click += new System.EventHandler(this.geriToolStripMenuItem_Click);
            // 
            // dtStockActionList
            // 
            this.dtStockActionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtStockActionList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtStockActionList.BackgroundColor = System.Drawing.Color.White;
            this.dtStockActionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStockActionList.Location = new System.Drawing.Point(2, 32);
            this.dtStockActionList.Name = "dtStockActionList";
            this.dtStockActionList.ReadOnly = true;
            this.dtStockActionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtStockActionList.Size = new System.Drawing.Size(672, 179);
            this.dtStockActionList.TabIndex = 9;
            // 
            // lblActionNo
            // 
            this.lblActionNo.AutoSize = true;
            this.lblActionNo.Enabled = false;
            this.lblActionNo.Location = new System.Drawing.Point(84, 264);
            this.lblActionNo.Name = "lblActionNo";
            this.lblActionNo.Size = new System.Drawing.Size(13, 13);
            this.lblActionNo.TabIndex = 24;
            this.lblActionNo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(9, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Hareket Kodu:";
            // 
            // btnAllStockActionAdd
            // 
            this.btnAllStockActionAdd.Location = new System.Drawing.Point(12, 316);
            this.btnAllStockActionAdd.Name = "btnAllStockActionAdd";
            this.btnAllStockActionAdd.Size = new System.Drawing.Size(102, 24);
            this.btnAllStockActionAdd.TabIndex = 22;
            this.btnAllStockActionAdd.Text = "Kaydet";
            this.btnAllStockActionAdd.UseVisualStyleBackColor = true;
            this.btnAllStockActionAdd.Click += new System.EventHandler(this.btnAllStockActionAdd_Click);
            // 
            // lbl_StoreName
            // 
            this.lbl_StoreName.AutoSize = true;
            this.lbl_StoreName.Enabled = false;
            this.lbl_StoreName.Location = new System.Drawing.Point(69, 242);
            this.lbl_StoreName.Name = "lbl_StoreName";
            this.lbl_StoreName.Size = new System.Drawing.Size(10, 13);
            this.lbl_StoreName.TabIndex = 21;
            this.lbl_StoreName.Text = "-";
            // 
            // lbl_StockID
            // 
            this.lbl_StockID.AutoSize = true;
            this.lbl_StockID.Enabled = false;
            this.lbl_StockID.Location = new System.Drawing.Point(69, 223);
            this.lbl_StockID.Name = "lbl_StockID";
            this.lbl_StockID.Size = new System.Drawing.Size(10, 13);
            this.lbl_StockID.TabIndex = 20;
            this.lbl_StockID.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(9, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Depo Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(9, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Depo No:";
            // 
            // HareketYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 352);
            this.Controls.Add(this.lblActionNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAllStockActionAdd);
            this.Controls.Add(this.lbl_StoreName);
            this.Controls.Add(this.lbl_StockID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtStockActionList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HareketYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hareket Yönetimi";
            this.Load += new System.EventHandler(this.HareketYonetimi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStockActionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        public System.Windows.Forms.DataGridView dtStockActionList;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        public System.Windows.Forms.Label lblActionNo;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnAllStockActionAdd;
        public System.Windows.Forms.Label lbl_StoreName;
        public System.Windows.Forms.Label lbl_StockID;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}