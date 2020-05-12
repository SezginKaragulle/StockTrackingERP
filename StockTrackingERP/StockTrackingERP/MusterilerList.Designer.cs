namespace StockTrackingERP
{
    partial class MusterilerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusterilerList));
            this.dtCustomerList = new System.Windows.Forms.DataGridView();
            this.btnCustomerExit = new System.Windows.Forms.Button();
            this.btnCustomerCheck = new System.Windows.Forms.Button();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCustomerList
            // 
            this.dtCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCustomerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.dtCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCustomerList.Location = new System.Drawing.Point(2, 63);
            this.dtCustomerList.Name = "dtCustomerList";
            this.dtCustomerList.ReadOnly = true;
            this.dtCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCustomerList.Size = new System.Drawing.Size(672, 179);
            this.dtCustomerList.TabIndex = 6;
            // 
            // btnCustomerExit
            // 
            this.btnCustomerExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCustomerExit.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerExit.Image")));
            this.btnCustomerExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerExit.Location = new System.Drawing.Point(479, 21);
            this.btnCustomerExit.Name = "btnCustomerExit";
            this.btnCustomerExit.Size = new System.Drawing.Size(94, 30);
            this.btnCustomerExit.TabIndex = 30;
            this.btnCustomerExit.Text = "Geri";
            this.btnCustomerExit.UseVisualStyleBackColor = true;
            this.btnCustomerExit.Click += new System.EventHandler(this.btnCustomerExit_Click);
            // 
            // btnCustomerCheck
            // 
            this.btnCustomerCheck.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnCustomerCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerCheck.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCustomerCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerCheck.Image")));
            this.btnCustomerCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerCheck.Location = new System.Drawing.Point(359, 21);
            this.btnCustomerCheck.Name = "btnCustomerCheck";
            this.btnCustomerCheck.Size = new System.Drawing.Size(94, 30);
            this.btnCustomerCheck.TabIndex = 29;
            this.btnCustomerCheck.Text = "Seç";
            this.btnCustomerCheck.UseVisualStyleBackColor = true;
            this.btnCustomerCheck.Click += new System.EventHandler(this.btnCustomerCheck_Click);
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSearch.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCustomerSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerSearch.Image")));
            this.btnCustomerSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerSearch.Location = new System.Drawing.Point(246, 21);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(94, 30);
            this.btnCustomerSearch.TabIndex = 28;
            this.btnCustomerSearch.Text = "Ara";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(80, 37);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(158, 20);
            this.txtProductName.TabIndex = 27;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(80, 13);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(158, 20);
            this.txtProductCode.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Müşteri Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Müşteri Kodu:";
            // 
            // MusterilerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 245);
            this.Controls.Add(this.btnCustomerExit);
            this.Controls.Add(this.btnCustomerCheck);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtCustomerList);
            this.MaximizeBox = false;
            this.Name = "MusterilerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.MusterilerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtCustomerList;
        public System.Windows.Forms.Button btnCustomerExit;
        public System.Windows.Forms.Button btnCustomerCheck;
        public System.Windows.Forms.Button btnCustomerSearch;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}