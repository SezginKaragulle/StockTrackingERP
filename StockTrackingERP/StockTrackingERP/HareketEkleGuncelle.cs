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
    public partial class HareketEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public HareketEkleGuncelle()
        {
            InitializeComponent();
        }

        public void m_ProductActionsInformations()
        {
            FrmGiris.FrmUrunList.txtProductCode.Text = "";
            FrmGiris.FrmUrunList.txtProductName.Text = "";
            FrmGiris.FrmUrunList.dtProductList.DataSource = "";
        }
        private void HareketEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnStockActionExit_Click(object sender, EventArgs e)
        {
            txtProductCode.Text = "";
            txtProductName.Text = "";
            txtProductCount.Text = "";
            FrmGiris.FrmHareketYonetimi.Show();
            this.Hide();
        }

        private void btnStockActionAddUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text == "" & txtProductName.Text == "" || txtProductCount.Text == "")
            {
                MessageBox.Show("İlgili Alanları Boş Bırakmayınız", "Alan Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnStockActionAddUpdate.Text == "Ekle")
            {
                FrmGiris.stock.StockActionNo = int.Parse(FrmGiris.FrmHareketYonetimi.lblActionNo.Text);
                FrmGiris.stock.ProductCode = int.Parse(txtProductCode.Text);
                FrmGiris.stock.ProductCount = int.Parse(txtProductCount.Text);
                FrmGiris.stock.m_StockActionDetailsAdd(FrmGiris.stock.StockActionNo, FrmGiris.stock.ProductCode, FrmGiris.stock.ProductCount);
                MessageBox.Show("Ürün Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductCode.Text = "";
                txtProductName.Text = "";
                txtProductCount.Text = "";
                FrmGiris.FrmHareketYonetimi.Show();
                FrmGiris.stock.m_StockActionDetailsList(FrmGiris.FrmHareketYonetimi.dtStockActionList, int.Parse(FrmGiris.FrmHareketYonetimi.lblActionNo.Text));
                this.Hide();
                
            }
            else if (btnStockActionAddUpdate.Text == "Güncelle")
            {
                FrmGiris.stock.StockActionNo = int.Parse(FrmGiris.FrmHareketYonetimi.lblActionNo.Text);
                FrmGiris.stock.ProductCode = int.Parse(txtProductCode.Text);
                FrmGiris.stock.ProductCount = int.Parse(txtProductCount.Text);
                FrmGiris.stock.m_StockActionDetailsUpdate(FrmGiris.stock.ProductCode, FrmGiris.stock.ProductCount);
                MessageBox.Show("Ürün Eklendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmGiris.FrmHareketYonetimi.Show();
                FrmGiris.stock.m_StockActionDetailsList(FrmGiris.FrmHareketYonetimi.dtStockActionList, int.Parse(FrmGiris.FrmHareketYonetimi.lblActionNo.Text));
                this.Hide();

            }
           
        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            string vrProductNameValue;
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProductCode.Text == "")
                {
                    m_ProductActionsInformations();
                    FrmGiris.vrProductİnformations = "StockActions";
                    FrmGiris.FrmUrunList.Show();
                    this.Hide();
                }
                else
                {
                    vrProductNameValue = FrmGiris.stock.m_ProductCodeSearch(int.Parse(txtProductCode.Text), txtProductName);
                    if (vrProductNameValue == null)
                    {
                        m_ProductActionsInformations();
                        FrmGiris.vrProductİnformations = "StockActions";
                        FrmGiris.FrmUrunList.Show();
                        this.Hide();
                    }
                    else
                    {
                        txtProductName.Text = vrProductNameValue;
                    }
                    
                }
                
            }
        }
    }
}
