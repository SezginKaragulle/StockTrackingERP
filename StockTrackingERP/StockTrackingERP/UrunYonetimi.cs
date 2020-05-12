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
    public partial class UrunYonetimi : Form
    {
        public Giris FrmGiris;
        public UrunYonetimi()
        {
            InitializeComponent();
        }

        public void m_ProductInformations()
        {
            if (vrProductAddUpdateStatus == "ProductAdd")
            {
                FrmGiris.FrmUrunEkleGuncelle.txtProductName.Text = "";
                FrmGiris.FrmUrunEkleGuncelle.lblProductCode.Text = "";
                FrmGiris.FrmUrunEkleGuncelle.cmbProductType.Text = "";
                FrmGiris.FrmUrunEkleGuncelle.btnProductAddUpdate.Text = "Ekle";
            }

            else if (vrProductAddUpdateStatus == "ProductUpdate")
            {
                FrmGiris.FrmUrunEkleGuncelle.lblProductCode.Text = dtProductList.CurrentRow.Cells[0].Value.ToString();
                FrmGiris.FrmUrunEkleGuncelle.txtProductName.Text = dtProductList.CurrentRow.Cells[1].Value.ToString();
                FrmGiris.FrmUrunEkleGuncelle.cmbProductType.Text = dtProductList.CurrentRow.Cells[2].Value.ToString();
                FrmGiris.FrmUrunEkleGuncelle.btnProductAddUpdate.Text = "Güncelle";
            }
        }


        public string vrProductAddUpdateStatus;
        private void UrunYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtProductCode.Text = "";
            txtProductName.Text = "";
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void UrunYonetimi_KeyDown(object sender, KeyEventArgs e)
        {
            FrmGiris.FrmAnasayfa.m_ApplicationExit(e);
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vrProductAddUpdateStatus = "ProductAdd";
            m_ProductInformations();
            FrmGiris.FrmUrunEkleGuncelle.Show();
            FrmGiris.product.m_ProductTypes(FrmGiris.FrmUrunEkleGuncelle.cmbProductType);
            this.Hide();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vrProductAddUpdateStatus = "ProductUpdate";
            m_ProductInformations();
            FrmGiris.FrmUrunEkleGuncelle.Show();
            FrmGiris.product.m_ProductTypes(FrmGiris.FrmUrunEkleGuncelle.cmbProductType);
            this.Hide();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text == ""  & txtProductName.Text =="")
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

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiris.product.m_ProductDelete(int.Parse(dtProductList.CurrentRow.Cells[0].Value.ToString()), dtProductList.CurrentRow.Cells[1].Value.ToString());
            FrmGiris.product.m_ProductsList(dtProductList);
        }
    }
}
