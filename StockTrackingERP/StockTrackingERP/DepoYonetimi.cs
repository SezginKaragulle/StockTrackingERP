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
    public partial class DepoYonetimi : Form
    {
        public Giris FrmGiris;
        public DepoYonetimi()
        {
            InitializeComponent();
        }

        public void m_StorestInformations()
        {
            if (vrStoreAddUpdateStatus == "StoreAdd")
            {
                FrmGiris.FrmUrunEkleGuncelle.txtProductName.Text = "";
                FrmGiris.FrmUrunEkleGuncelle.lblProductCode.Text = "";
                FrmGiris.FrmUrunEkleGuncelle.cmbProductType.Text = "";
                FrmGiris.FrmDepoEkleGuncelle.btnStoreAddUpdate.Text = "Ekle";
            }

            else if (vrStoreAddUpdateStatus == "StoreUpdate")
            {
                FrmGiris.FrmDepoEkleGuncelle.lblStoreID.Text = dtStoreList.CurrentRow.Cells[0].Value.ToString();
                FrmGiris.FrmDepoEkleGuncelle.txtStoreCode.Text = dtStoreList.CurrentRow.Cells[1].Value.ToString();
                FrmGiris.FrmDepoEkleGuncelle.txtStoreName.Text = dtStoreList.CurrentRow.Cells[2].Value.ToString();
                FrmGiris.FrmDepoEkleGuncelle.btnStoreAddUpdate.Text = "Güncelle";
            }
        }


        public string vrStoreAddUpdateStatus;

        private void DepoYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtStoreID.Text = "";
            txtStoreName.Text = "";
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void DepoYonetimi_KeyDown(object sender, KeyEventArgs e)
        {
            FrmGiris.FrmAnasayfa.m_ApplicationExit(e);
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vrStoreAddUpdateStatus = "StoreAdd";
            m_StorestInformations();
            FrmGiris.FrmDepoEkleGuncelle.Show();
            this.Hide();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vrStoreAddUpdateStatus = "StoreUpdate";
            m_StorestInformations();
            FrmGiris.FrmDepoEkleGuncelle.Show();
            this.Hide();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtStoreID.Text == "" & txtStoreName.Text == "")
            {
                FrmGiris.stores.m_StoresList(dtStoreList);
                txtStoreID.Text = "";
                txtStoreName.Text = "";
            }
            else
            {
                FrmGiris.stores.m_StoreSearch(dtStoreList, txtStoreID.Text, txtStoreName.Text);
                txtStoreID.Text = "";
                txtStoreName.Text = "";
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiris.stores.m_StoreDelete(int.Parse(dtStoreList.CurrentRow.Cells[0].Value.ToString()), dtStoreList.CurrentRow.Cells[2].Value.ToString());
            FrmGiris.stores.m_StoresList(dtStoreList);
            txtStoreID.Text = "";
            txtStoreName.Text = "";
        }
    }
}
