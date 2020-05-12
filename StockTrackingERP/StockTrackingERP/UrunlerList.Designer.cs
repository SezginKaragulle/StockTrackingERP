namespace StockTrackingERP
{
    partial class UrunlerList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunlerList));
            this.dtProductList = new System.Windows.Forms.DataGridView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.btnProductCheck = new System.Windows.Forms.Button();
            this.btnProductExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtProductList
            // 
            this.dtProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtProductList.BackgroundColor = System.Drawing.Color.White;
            this.dtProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProductList.Location = new System.Drawing.Point(4, 57);
            this.dtProductList.Name = "dtProductList";
            this.dtProductList.ReadOnly = true;
            this.dtProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtProductList.Size = new System.Drawing.Size(672, 179);
            this.dtProductList.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(72, 31);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(158, 20);
            this.txtProductName.TabIndex = 20;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(72, 7);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(158, 20);
            this.txtProductCode.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ürün Kodu:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSearch.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnProductSearch.Image")));
            this.btnProductSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductSearch.Location = new System.Drawing.Point(242, 15);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(94, 30);
            this.btnProductSearch.TabIndex = 21;
            this.btnProductSearch.Text = "Ara";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // btnProductCheck
            // 
            this.btnProductCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductCheck.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnProductCheck.Image")));
            this.btnProductCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductCheck.Location = new System.Drawing.Point(352, 15);
            this.btnProductCheck.Name = "btnProductCheck";
            this.btnProductCheck.Size = new System.Drawing.Size(94, 30);
            this.btnProductCheck.TabIndex = 22;
            this.btnProductCheck.Text = "Seç";
            this.btnProductCheck.UseVisualStyleBackColor = true;
            this.btnProductCheck.Click += new System.EventHandler(this.btnProductCheck_Click);
            // 
            // btnProductExit
            // 
            this.btnProductExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProductExit.Image = ((System.Drawing.Image)(resources.GetObject("btnProductExit.Image")));
            this.btnProductExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductExit.Location = new System.Drawing.Point(463, 15);
            this.btnProductExit.Name = "btnProductExit";
            this.btnProductExit.Size = new System.Drawing.Size(94, 30);
            this.btnProductExit.TabIndex = 23;
            this.btnProductExit.Text = "Geri";
            this.btnProductExit.UseVisualStyleBackColor = true;
            this.btnProductExit.Click += new System.EventHandler(this.btnProductExit_Click);
            // 
            // UrunlerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 245);
            this.Controls.Add(this.btnProductExit);
            this.Controls.Add(this.btnProductCheck);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtProductList);
            this.MaximizeBox = false;
            this.Name = "UrunlerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.UrunlerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtProductList;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button btnProductSearch;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnProductCheck;
        public System.Windows.Forms.Button btnProductExit;
    }
}