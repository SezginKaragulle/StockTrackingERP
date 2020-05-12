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
    public partial class İlceEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public İlceEkleGuncelle()
        {
            InitializeComponent();
        }

        private void İlceEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnDistrictExit_Click(object sender, EventArgs e)
        {
            txtDistrictName.Text = "";
            txtProvinceID.Text = "";
            txtCountryID.Text = "";
            FrmGiris.FrmGenelKodBilgileri.Show();
            FrmGiris.FrmGenelKodBilgileri.dtGeneralCodeİnformations.DataSource = "";
            FrmGiris.FrmGenelKodBilgileri.cmbCodeİnformations.Text = "";
            FrmGiris.FrmGenelKodBilgileri.txtCodeID.Text = "";
            FrmGiris.FrmGenelKodBilgileri.txtCodeName.Text = "";
            this.Hide();
        }

        private void btnDistrictAddUpdate_Click(object sender, EventArgs e)
        {
            if (btnDistrictAddUpdate.Text == "Ekle")
            {
                if (txtDistrictName.Text == "" || txtProvinceID.Text == "" || txtCountryID.Text == "")
                {
                    MessageBox.Show("Boş Alanları Doldurmanız Gerekmektedir.", "Alan Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FrmGiris.system.m_DistrictAdd(txtDistrictName.Text, int.Parse(txtProvinceID.Text), int.Parse(txtCountryID.Text));
                    MessageBox.Show("İlçe Bilgisi Eklenmiştir", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDistrictName.Text = "";
                    txtProvinceID.Text = "";
                    txtCountryID.Text = "";
                }

            }

            else if (btnDistrictAddUpdate.Text == "Güncelle")
            {
                FrmGiris.system.m_DistrictUpdate(int.Parse(FrmGiris.FrmGenelKodBilgileri.dtGeneralCodeİnformations.CurrentRow.Cells[0].Value.ToString()),txtDistrictName.Text,int.Parse(txtProvinceID.Text),int.Parse(txtCountryID.Text));
                MessageBox.Show("İlçe Bilgisi Güncellenmiştir", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
