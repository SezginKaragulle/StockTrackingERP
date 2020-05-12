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
    public partial class HareketYonetimi : Form
    {
        public Giris FrmGiris;
        public HareketYonetimi()
        {
            InitializeComponent();
        }

        public string vr_StockActionValue;
        public int vrStockCount;
        public string vrProductCount;
        private int vrProductSumCount;
        private int vrLastProductCount;
        private int vrLastActionCountry;
        private int vrTopActionCountry;

        public void m_StockActionsInformations()
        {
            if (vr_StockActionValue == "StockActionAdd")
            {
                FrmGiris.FrmHareketEkleGuncelle.txtProductCode.Text = "";
                FrmGiris.FrmHareketEkleGuncelle.txtProductName.Text = "";
                FrmGiris.FrmHareketEkleGuncelle.txtProductCount.Text = "";
                FrmGiris.FrmHareketEkleGuncelle.txtProductCode.Enabled = true;
                FrmGiris.FrmHareketEkleGuncelle.btnStockActionAddUpdate.Text = "Ekle";           
                    
            }
            else if (vr_StockActionValue == "StockActionUpdate")
            {
                FrmGiris.FrmHareketEkleGuncelle.txtProductCode.Text = dtStockActionList.CurrentRow.Cells[1].Value.ToString();
                FrmGiris.FrmHareketEkleGuncelle.txtProductName.Text = dtStockActionList.CurrentRow.Cells[2].Value.ToString();
                FrmGiris.FrmHareketEkleGuncelle.txtProductCount.Text = dtStockActionList.CurrentRow.Cells[3].Value.ToString();
                FrmGiris.FrmHareketEkleGuncelle.txtProductCode.Enabled = false;
                FrmGiris.FrmHareketEkleGuncelle.btnStockActionAddUpdate.Text = "Güncelle";
            }
        }

        public void m_ProductStockActions()
        {
            for (int i = 0; i < dtStockActionList.Rows.Count - 1; i++)
            {

                vrProductCount = FrmGiris.stock.m_StockCountTest(int.Parse(dtStockActionList.Rows[i].Cells[1].Value.ToString()), int.Parse(lbl_StockID.Text));
                if (vrProductCount == "")
                {
                    FrmGiris.stock.m_StocksAddUpdate(int.Parse(dtStockActionList.Rows[i].Cells[1].Value.ToString()), int.Parse(lbl_StockID.Text), int.Parse(dtStockActionList.Rows[i].Cells[3].Value.ToString()), "ADD");
                }
                else
                {
                    vrLastProductCount = int.Parse(vrProductCount);
                    vrProductSumCount = vrLastProductCount + int.Parse(dtStockActionList.Rows[i].Cells[3].Value.ToString());
                    FrmGiris.stock.m_StocksAddUpdate(int.Parse(dtStockActionList.Rows[i].Cells[1].Value.ToString()), int.Parse(lbl_StockID.Text), vrProductSumCount, "UPDATE");
                }
                //MessageBox.Show(dtStockActionList.Rows[i].Cells[1].Value.ToString());
                //MessageBox.Show(dtStockActionList.Rows[i].Cells[2].Value.ToString());
            }
            vrLastActionCountry = int.Parse(lblActionNo.Text);
            vrTopActionCountry = vrLastActionCountry + 1;
            FrmGiris.stock.m_StockActionCounterUpdate(vrTopActionCountry);
            MessageBox.Show("Ürün Hareket İşlemi Gerçekleştirildi.", "Hareket Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmGiris.FrmStokYonetimi.Show();
            FrmGiris.stock.m_StoresList(FrmGiris.FrmStokYonetimi.cmbStores);
            FrmGiris.FrmStokYonetimi.cmbStores.Text = "";
            FrmGiris.FrmStokYonetimi.dtStockList.DataSource = "";
            FrmGiris.FrmStokYonetimi.lblStoreID.Text = "0";
            FrmGiris.FrmStokYonetimi.txtProductCode.Text = "";
            FrmGiris.FrmStokYonetimi.txtProductName.Text = "";
            this.Hide();
        }

        private void HareketYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void btnAllStockActionAdd_Click(object sender, EventArgs e)
        {
            if (dtStockActionList.DataSource == "")
            {
                MessageBox.Show("Ürün Girişi Yapılmadan Kaydetme İşlemi Yapılamaz.", "Alan Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                m_ProductStockActions();
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vr_StockActionValue = "StockActionAdd";
            m_StockActionsInformations();
            FrmGiris.FrmHareketEkleGuncelle.Show();
            this.Hide();
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult vrResult;
            if (dtStockActionList.DataSource == "")
            {
                
                FrmGiris.FrmStokYonetimi.Show();
                FrmGiris.stock.m_StoresList(FrmGiris.FrmStokYonetimi.cmbStores);
                FrmGiris.FrmStokYonetimi.cmbStores.Text = "";
                FrmGiris.FrmStokYonetimi.dtStockList.DataSource = "";
                FrmGiris.FrmStokYonetimi.lblStoreID.Text = "0";
                this.Hide();
            }
            else if (dtStockActionList.DataSource !="")
            {
                vrResult = MessageBox.Show("Hareketleri Kaydetmek İstiyor musunuz ?", "Kaydetme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrResult == DialogResult.Yes)
                {
                    m_ProductStockActions();
                }
                else
                {
                    MessageBox.Show("Ürünlerin Hareketlerinin Kaydetme İşlemi Gerçekleştirilmedi.", "Kaydetme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmGiris.stock.m_StockActionDetailsDelete(int.Parse(lblActionNo.Text));
                    FrmGiris.FrmStokYonetimi.Show();
                    FrmGiris.stock.m_StoresList(FrmGiris.FrmStokYonetimi.cmbStores);
                    FrmGiris.FrmStokYonetimi.cmbStores.Text = "";
                    FrmGiris.FrmStokYonetimi.dtStockList.DataSource = "";
                    FrmGiris.FrmStokYonetimi.lblStoreID.Text = "0";
                    this.Hide();

                }

            }

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtStockActionList.Rows.Count == 0)
            {
                MessageBox.Show("Ürün Seçiniz.", "Alan Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                vr_StockActionValue = "StockActionUpdate";
                m_StockActionsInformations();
                FrmGiris.FrmHareketEkleGuncelle.Show();
                this.Hide();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult vrResult;
            if (dtStockActionList.DataSource == "")
            {
                MessageBox.Show("Ürün Seçiniz.", "Alan Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                vrResult = MessageBox.Show(dtStockActionList.CurrentRow.Cells[2].Value.ToString() + " ürünün hareketini silmek istiyor musunuz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrResult == DialogResult.Yes)
                {
                    FrmGiris.stock.m_StockActionDetailsDelete(int.Parse(dtStockActionList.CurrentRow.Cells[0].Value.ToString()), int.Parse(dtStockActionList.CurrentRow.Cells[1].Value.ToString()));
                    MessageBox.Show("Ürün  Silinmiştir.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vrStockCount = FrmGiris.stock.m_StockCount(int.Parse(lblActionNo.Text));
                    if (vrStockCount == 0)
                    {
                        dtStockActionList.DataSource = "";
                    }
                    else if (vrStockCount>0)
                    {
                        FrmGiris.stock.m_StockActionDetailsList(dtStockActionList, int.Parse(lblActionNo.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Ürün  Silme İşlemi Gerçekleştirilmemiştir.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmGiris.stock.m_StockActionDetailsList(dtStockActionList, int.Parse(lblActionNo.Text));
                }
            }
        }
    }
}
