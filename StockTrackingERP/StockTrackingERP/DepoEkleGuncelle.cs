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
    public partial class DepoEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public DepoEkleGuncelle()
        {
            InitializeComponent();
        }

        private void DepoEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnStoreExit_Click(object sender, EventArgs e)
        {
            txtStoreCode.Text = "";
            lblStoreID.Text = "";
            txtStoreName.Text = "";
            FrmGiris.FrmDepoYonetimi.Show();
            FrmGiris.stores.m_StoresList(FrmGiris.FrmDepoYonetimi.dtStoreList);
            FrmGiris.FrmDepoYonetimi.txtStoreID.Text = "";
            FrmGiris.FrmDepoYonetimi.txtStoreName.Text = "";
        }

        private void btnStoreAddUpdate_Click(object sender, EventArgs e)
        {
            if (btnStoreAddUpdate.Text == "Ekle")
            {
                FrmGiris.stores.m_StoreAdd(txtStoreCode.Text, txtStoreName.Text);
                MessageBox.Show("Depo Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStoreCode.Text = "";
                txtStoreName.Text = "";
            }
            else if (btnStoreAddUpdate.Text == "Güncelle")
            {
                FrmGiris.stores.m_StoreUpdate(int.Parse(lblStoreID.Text),txtStoreCode.Text, txtStoreName.Text);
                MessageBox.Show("Depo Güncelle.", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
