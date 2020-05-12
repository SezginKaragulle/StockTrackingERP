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
    public partial class UrunEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public UrunEkleGuncelle()
        {
            InitializeComponent();
        }

        private void UrunEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnProductExit_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmUrunYonetimi.Show();
            FrmGiris.FrmUrunYonetimi.txtProductCode.Text = "";
            FrmGiris.FrmUrunYonetimi.txtProductName.Text = "";
            FrmGiris.product.m_ProductsList(FrmGiris.FrmUrunYonetimi.dtProductList);
            this.Hide();
        }

        private void btnProductAddUpdate_Click(object sender, EventArgs e)
        {
            
            
            if (txtProductName.Text == "" || cmbProductType.Text == "")
            {
                MessageBox.Show("Ürün Adı ve tipi alanlarını boş bırakmayınız", "Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (btnProductAddUpdate.Text == "Ekle")
                {
                    FrmGiris.product.ProductName = txtProductName.Text;
                    FrmGiris.product.ProductType = cmbProductType.Text;
                    FrmGiris.product.m_ProductAdd(FrmGiris.product.ProductName, FrmGiris.product.ProductType);
                    MessageBox.Show("Ürün Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductName.Text = "";
                    cmbProductType.Text = "";
                    FrmGiris.product.m_ProductTypes(cmbProductType);
                }

                else if (btnProductAddUpdate.Text == "Güncelle")
                {
                    FrmGiris.product.ProductCode = int.Parse(lblProductCode.Text);
                    FrmGiris.product.ProductName = txtProductName.Text;
                    FrmGiris.product.ProductType = cmbProductType.Text;
                    FrmGiris.product.m_ProductUpdate(int.Parse(lblProductCode.Text),FrmGiris.product.ProductName, FrmGiris.product.ProductType);
                    MessageBox.Show("Ürün Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            
        }
    }
}
