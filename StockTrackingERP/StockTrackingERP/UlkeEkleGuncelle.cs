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
    public partial class UlkeEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public UlkeEkleGuncelle()
        {
            InitializeComponent();
        }

        private void UlkeEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnCountryExit_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmGenelKodBilgileri.Show();
            txtCountryName.Text = "";
            FrmGiris.FrmGenelKodBilgileri.dtGeneralCodeİnformations.DataSource = "";
            FrmGiris.FrmGenelKodBilgileri.cmbCodeİnformations.Text = "";
            FrmGiris.FrmGenelKodBilgileri.txtCodeID.Text = "";
            FrmGiris.FrmGenelKodBilgileri.txtCodeName.Text = "";
            this.Hide();
            
        }

        private void btnCountryAddUpdate_Click(object sender, EventArgs e)
        {
            if (btnCountryAddUpdate.Text == "Ekle")
            {
                FrmGiris.system.m_CountryAdd(txtCountryName.Text);
                MessageBox.Show("Ülke Bilgisi Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCountryName.Text = "";
            }
            else if (btnCountryAddUpdate.Text == "Güncelle")
            {
                FrmGiris.system.m_CountryUpdate(int.Parse(FrmGiris.FrmGenelKodBilgileri.dtGeneralCodeİnformations.CurrentRow.Cells[0].Value.ToString()), txtCountryName.Text);
                MessageBox.Show("Ülke Bilgisi Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
