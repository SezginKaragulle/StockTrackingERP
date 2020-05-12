namespace StockTrackingERP
{
    partial class FaturaUrunList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaUrunList));
            this.lblStoreID = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.btnProductExit = new System.Windows.Forms.Button();
            this.btnProductCheck = new System.Windows.Forms.Button();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStoreID
            // 
            this.lblStoreID.Location = new System.Drawing.Point(28, 13);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new System.Drawing.Size(100, 23);
            this.lblStoreID.TabIndex = 0;
            this.lblStoreID.Text = "Depo ID";
            // 
            // lblStoreName
            // 
            this.lblStoreName.Location = new System.Drawing.Point(143, 13);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(100, 23);
            this.lblStoreName.TabIndex = 1;
            this.lblStoreName.Text = "Depo Adı";
            // 
            // btnProductExit
            // 
            this.btnProductExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductExit.Image = ((System.Drawing.Image)(resources.GetObject("btnProductExit.Image")));
            this.btnProductExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductExit.Location = new System.Drawing.Point(468, 48);
            this.btnProductExit.Name = "btnProductExit";
            this.btnProductExit.Size = new System.Drawing.Size(90, 30);
            this.btnProductExit.TabIndex = 31;
            this.btnProductExit.Text = "Geri";
            this.btnProductExit.UseVisualStyleBackColor = true;
            this.btnProductExit.Click += new System.EventHandler(this.btnProductExit_Click);
            // 
            // btnProductCheck
            // 
            this.btnProductCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductCheck.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnProductCheck.Image")));
            this.btnProductCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductCheck.Location = new System.Drawing.Point(356, 48);
            this.btnProductCheck.Name = "btnProductCheck";
            this.btnProductCheck.Size = new System.Drawing.Size(90, 30);
            this.btnProductCheck.TabIndex = 30;
            this.btnProductCheck.Text = "Seç";
            this.btnProductCheck.UseVisualStyleBackColor = true;
            this.btnProductCheck.Click += new System.EventHandler(this.btnProductCheck_Click);
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSearch.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnProductSearch.Image")));
            this.btnProductSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductSearch.Location = new System.Drawing.Point(250, 47);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(90, 30);
            this.btnProductSearch.TabIndex = 29;
            this.btnProductSearch.Text = "Ara";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(80, 63);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 20);
            this.txtProductName.TabIndex = 28;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(80, 39);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(150, 20);
            this.txtProductCode.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ürün Kodu:";
            // 
            // dtProductList
            // 
            this.dtProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtProductList.BackgroundColor = System.Drawing.Color.White;
            this.dtProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProductList.Location = new System.Drawing.Point(12, 89);
            this.dtProductList.Name = "dtProductList";
            this.dtProductList.ReadOnly = true;
            this.dtProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtProductList.Size = new System.Drawing.Size(664, 217);
            this.dtProductList.TabIndex = 24;
            // 
            // FaturaUrunList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 318);
            this.Controls.Add(this.btnProductExit);
            this.Controls.Add(this.btnProductCheck);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtProductList);
            this.Controls.Add(this.lblStoreName);
            this.Controls.Add(this.lblStoreID);
            this.MaximizeBox = false;
            this.Name = "FaturaUrunList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FaturaUrunList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnProductExit;
        public System.Windows.Forms.Button btnProductCheck;
        public System.Windows.Forms.Button btnProductSearch;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dtProductList;
        public System.Windows.Forms.Label lblStoreID;
        public System.Windows.Forms.Label lblStoreName;
    }
}