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
    public partial class UrunTipEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public UrunTipEkleGuncelle()
        {
            InitializeComponent();
        }

        private void UrunTipEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnProductTypeExit_Click(object sender, EventArgs e)
        {
            txtProductTypeName.Text = "";
            FrmGiris.FrmGenelKodBilgileri.Show();
            FrmGiris.FrmGenelKodBilgileri.dtGeneralCodeİnformations.DataSource = "";
            FrmGiris.FrmGenelKodBilgileri.cmbCodeİnformations.Text = "";
            FrmGiris.FrmGenelKodBilgileri.txtCodeID.Text = "";
            FrmGiris.FrmGenelKodBilgileri.txtCodeName.Text = "";
            this.Hide();
        }

        private void btnProductTypeAddUpdate_Click(object sender, EventArgs e)
        {
            if (btnProductTypeAddUpdate.Text == "Ekle")
            {
                FrmGiris.system.m_ProductTypeAdd(txtProductTypeName.Text);
                MessageBox.Show("Ürün Tipi Eklenmiştir.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductTypeName.Text = "";
                lblProductTypeID.Text = "";
            }

            else if (btnProductTypeAddUpdate.Text == "Güncelle")
            {
                FrmGiris.system.m_ProductTypeUpdate(int.Parse(lblProductTypeID.Text), txtProductTypeName.Text);
                MessageBox.Show("Ürün Tipi Güncellenmiştir.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
