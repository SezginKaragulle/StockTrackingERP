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
    public partial class UrunlerList : Form
    {
        public Giris FrmGiris;
        public UrunlerList()
        {
            InitializeComponent();
        }

        private void UrunlerList_Load(object sender, EventArgs e)
        {

        }

        private void btnProductExit_Click(object sender, EventArgs e)
        {
            if (FrmGiris.vrProductİnformations == "StockActions")
            {
                txtProductCode.Text = "";
                txtProductName.Text = "";
                dtProductList.DataSource = "";
                FrmGiris.FrmHareketEkleGuncelle.Show();
                FrmGiris.FrmHareketEkleGuncelle.txtProductCode.Text = "";
                FrmGiris.FrmHareketEkleGuncelle.txtProductName.Text = "";
                this.Hide();
            }
            else if (FrmGiris.vrProductİnformations == "InvoicesActions")
            {
                txtProductCode.Text = "";
                txtProductName.Text = "";
                dtProductList.DataSource = "";
                FrmGiris.FrmFaturaUrunEkle.Show();
                FrmGiris.FrmFaturaUrunEkle.txtProductCode.Text = "";
                FrmGiris.FrmFaturaUrunEkle.txtProductName.Text = "";
                this.Hide();
            }
        }

        private void btnProductCheck_Click(object sender, EventArgs e)
        {
            if (dtProductList.Rows.Count == 0)
            {
                MessageBox.Show("Ürün Seçmelisiniz.", "Ürün Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FrmGiris.vrProductİnformations == "StockActions")
            {
                FrmGiris.FrmHareketEkleGuncelle.txtProductCode.Text = dtProductList.CurrentRow.Cells[0].Value.ToString();
                FrmGiris.FrmHareketEkleGuncelle.txtProductName.Text = dtProductList.CurrentRow.Cells[1].Value.ToString();
                txtProductCode.Text = "";
                txtProductName.Text = "";
                dtProductList.DataSource = "";
                FrmGiris.FrmHareketEkleGuncelle.Show();
                this.Hide();
            }
            else if (FrmGiris.vrProductİnformations == "InvoicesActions")
            {
                FrmGiris.FrmFaturaUrunEkle.txtProductCode.Text = dtProductList.CurrentRow.Cells[0].Value.ToString();
                FrmGiris.FrmFaturaUrunEkle.txtProductName.Text = dtProductList.CurrentRow.Cells[1].Value.ToString();
                txtProductCode.Text = "";
                txtProductName.Text = "";
                dtProductList.DataSource = "";
                FrmGiris.FrmFaturaUrunEkle.Show();
                this.Hide();
            }
            
            //else
            //{
            //    FrmGiris.FrmHareketEkleGuncelle.txtProductCode.Text = dtProductList.CurrentRow.Cells[0].Value.ToString();
            //    FrmGiris.FrmHareketEkleGuncelle.txtProductName.Text = dtProductList.CurrentRow.Cells[1].Value.ToString();
            //    txtProductCode.Text = "";
            //    txtProductName.Text = "";
            //    dtProductList.DataSource = "";
            //    FrmGiris.FrmHareketEkleGuncelle.Show();
            //    this.Hide();
                
            //}
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text == "" & txtProductName.Text == "")
            {
                FrmGiris.product.m_ProductsList(dtProductList);
                
            }
            else
            {
                FrmGiris.product.m_ProductSearch(dtProductList, txtProductCode.Text, txtProductName.Text);
                txtProductCode.Text = "";
                txtProductName.Text = "";
            }
        }
    }
}
