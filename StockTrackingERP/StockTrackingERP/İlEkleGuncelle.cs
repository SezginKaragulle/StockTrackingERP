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
    public partial class İlEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public İlEkleGuncelle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void İlEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnProvinceExit_Click(object sender, EventArgs e)
        {
            txtProvinceCode.Text = "";
            txtProvinceName.Text = "";
            txtCountryCode.Text = "";
            FrmGiris.FrmGenelKodBilgileri.Show();
            FrmGiris.FrmGenelKodBilgileri.dtGeneralCodeİnformations.DataSource = "";
            FrmGiris.FrmGenelKodBilgileri.cmbCodeİnformations.Text = "";
            FrmGiris.FrmGenelKodBilgileri.txtCodeID.Text = "";
            FrmGiris.FrmGenelKodBilgileri.txtCodeName.Text = "";
            this.Hide();
        }

        private void btnProvinceAddUpdate_Click(object sender, EventArgs e)
        {
            
            if (btnProvinceAddUpdate.Text == "Ekle")
            {
                if (txtProvinceCode.Text == "" || txtProvinceName.Text == "" || txtCountryCode.Text == "")
                {
                    MessageBox.Show("Boş Alanları Doldurmanız Gerekmektedir.", "Alan Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FrmGiris.system.m_ProvinceAdd(txtProvinceCode.Text, txtProvinceName.Text, int.Parse(txtCountryCode.Text));
                    MessageBox.Show("İl Bilgisi Eklenmiştir", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProvinceCode.Text = "";
                    txtProvinceName.Text = "";
                    txtCountryCode.Text = "";
                }
                
            }

            else if (btnProvinceAddUpdate.Text == "Güncelle")
            {
                FrmGiris.system.m_ProvinceUpdate(int.Parse(FrmGiris.FrmGenelKodBilgileri.dtGeneralCodeİnformations.CurrentRow.Cells[0].Value.ToString()), txtProvinceCode.Text, txtProvinceName.Text, int.Parse(txtCountryCode.Text));
                MessageBox.Show("İl Bilgisi Güncellenmiştir", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
