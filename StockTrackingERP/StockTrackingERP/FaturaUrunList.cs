using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingERP
{
    public partial class FaturaUrunList : Form
    {
        public Giris FrmGiris;
        public FaturaUrunList()
        {
            InitializeComponent();
        }

        private void FaturaUrunList_Load(object sender, EventArgs e)
        {

        }

        private void btnProductExit_Click(object sender, EventArgs e)
        {
            lblStoreID.Text = "";
            lblStoreName.Text = "";
            dtProductList.DataSource = "";
            FrmGiris.FrmFaturaUrunEkle.Show();
            this.Hide();
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text == "" && txtProductName.Text == "")
            {
                
                FrmGiris.stock.m_StocksList(dtProductList, lblStoreName.Text);
            }
            else
            {
                FrmGiris.stock.m_StocksListSearch(dtProductList, lblStoreID.Text, txtProductCode.Text, txtProductName.Text);
                txtProductCode.Text = "";
                txtProductName.Text = "";
            }
            
        }

        private void btnProductCheck_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmFaturaUrunEkle.txtProductCode.Text = dtProductList.CurrentRow.Cells[1].Value.ToString();
            FrmGiris.FrmFaturaUrunEkle.txtProductName.Text = dtProductList.CurrentRow.Cells[2].Value.ToString();
            FrmGiris.FrmFaturaUrunEkle.lblProductCurrentStock.Text = dtProductList.CurrentRow.Cells[3].Value.ToString();
            lblStoreID.Text = "";
            lblStoreName.Text = "";
            txtProductCode.Text = "";
            FrmGiris.FrmFaturaUrunEkle.Show();
            this.Hide();
        }
    }
}
