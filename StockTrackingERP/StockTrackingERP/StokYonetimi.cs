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
    public partial class StokYonetimi : Form
    {
        public Giris FrmGiris;
        public StokYonetimi()
        {
            InitializeComponent();
        }
        public int vr_StockActionCount;
        public bool vr_StockActionStatus = false;
        
        public void m_SearchStockActionİnformations(Label vrlblStockCount,string vrStoreID,string vrStoreName)
        {
            //int vrTop;
            //int dgr;
            FrmGiris.stock.m_StockActionCount(vrlblStockCount);
            FrmGiris.FrmHareketYonetimi.lbl_StockID.Text = vrStoreID;
            FrmGiris.FrmHareketYonetimi.lbl_StoreName.Text = vrStoreName;
            FrmGiris.FrmHareketYonetimi.dtStockActionList.DataSource = "";

            
        }

        private void StokYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void cmbStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmGiris.stock.m_StoresID(cmbStores.Text, lblStoreID);
            FrmGiris.stock.m_StocksList(dtStockList, cmbStores.Text);
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStoreID.Text = "0";
            cmbStores.Text = "";
            dtStockList.DataSource = "";
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void StokYonetimi_KeyDown(object sender, KeyEventArgs e)
        {
            FrmGiris.FrmAnasayfa.m_ApplicationExit(e);
        }

        private void hareketGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbStores.Text == "")
            {
                MessageBox.Show("Hareket Girişi İçin Depo Seçmelisiniz.", "Hareket Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                m_SearchStockActionİnformations(FrmGiris.FrmHareketYonetimi.lblActionNo, lblStoreID.Text, cmbStores.Text);
                FrmGiris.FrmHareketYonetimi.Show();
                this.Hide();
            }
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbStores.Text == "")
            {
                MessageBox.Show("Depo Seçimi Yapmalısınız","Arama",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (txtProductCode.Text == "" && txtProductName.Text == "")
                {
                    FrmGiris.stock.m_StocksList(dtStockList, cmbStores.Text);
                    txtProductCode.Text = "";
                    txtProductName.Text = "";
                }
                else
                {
                    FrmGiris.stock.m_StocksListSearch(dtStockList, lblStoreID.Text, txtProductCode.Text, txtProductName.Text);
                    txtProductCode.Text = "";
                    txtProductName.Text = "";
                }
            }
        }
    }
}
