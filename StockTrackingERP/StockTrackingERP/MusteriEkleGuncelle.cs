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
    public partial class MusteriEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public MusteriEkleGuncelle()
        {
            InitializeComponent();
        }

        private void MusteriEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerExit_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmMusteriYonetimi.Show();
            FrmGiris.customer.m_CustomersList(FrmGiris.FrmMusteriYonetimi.dtCustomerList);
            FrmGiris.FrmMusteriYonetimi.txtCustomerID.Text = "";
            FrmGiris.FrmMusteriYonetimi.txtCustomerTitle.Text = "";
            FrmGiris.FrmMusteriYonetimi.txtTaxNumber.Text = "";
            this.Hide();
        }

        private void cmbCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            FrmGiris.customer.m_CountriesID(cmbCountry.Text, lblCountryID);
            FrmGiris.customer.m_Provinces(cmbProvince, int.Parse(lblCountryID.Text));
        }

        private void cmbProvince_SelectedValueChanged(object sender, EventArgs e)
        {
            FrmGiris.customer.m_ProvincesID(cmbProvince.Text, lblProvinceID);
            FrmGiris.customer.m_Districts(cmbDistrict, int.Parse(lblProvinceID.Text));
        }

        private void btnCustomerAddUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerTitle.Text == "" || txtTaxNumber.Text == "")
            {
                MessageBox.Show("Firma Adı ve Vergi Numarası alanlarını boş geçemeyiz.", "Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbCountry.Text == "" || cmbProvince.Text == "")
            {
                MessageBox.Show("Ülke Bilgisi ve İl Bilgisi alanlarını boş geçemeyiz.", "Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (btnCustomerAddUpdate.Text == "Ekle")
                {
                    
                    FrmGiris.customer.Title = txtCustomerTitle.Text;
                    FrmGiris.customer.TaxAdministration = txtTaxAdministration.Text;
                    FrmGiris.customer.TaxNumber = int.Parse(txtTaxNumber.Text);
                    FrmGiris.customer.Country = cmbCountry.Text;
                    FrmGiris.customer.Province = cmbProvince.Text;
                    FrmGiris.customer.District = cmbDistrict.Text;
                    FrmGiris.customer.Adress = txtAdress.Text;
                    FrmGiris.customer.Telephone = txtTelephone.Text;
                    FrmGiris.customer.Email = txtEmail.Text;
                    FrmGiris.customer.m_CustomerAdd(FrmGiris.customer.Title, FrmGiris.customer.TaxAdministration, FrmGiris.customer.TaxNumber, FrmGiris.customer.Country, FrmGiris.customer.Province, FrmGiris.customer.District, FrmGiris.customer.Adress, FrmGiris.customer.Telephone, FrmGiris.customer.Email);
                    MessageBox.Show("Müşteri Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblCustomerID.Text = "";
                    txtCustomerTitle.Text = "";
                    txtTaxAdministration.Text = "";
                    txtTaxNumber.Text = "";
                    cmbCountry.Text = "";
                    lblCountryID.Text = "0";
                    cmbProvince.Text = "";
                    lblProvinceID.Text = "0";
                    cmbDistrict.Text = "";
                    txtAdress.Text = "";
                    txtTelephone.Text = "";
                    txtEmail.Text = "";
                    FrmGiris.customer.m_Countries(cmbCountry);

                }
                else if (btnCustomerAddUpdate.Text == "Güncelle")
                {
                    FrmGiris.customer.CustomerID = int.Parse(lblCustomerID.Text);
                    FrmGiris.customer.Title = txtCustomerTitle.Text;
                    FrmGiris.customer.TaxAdministration = txtTaxAdministration.Text;
                    FrmGiris.customer.TaxNumber = int.Parse(txtTaxNumber.Text);
                    FrmGiris.customer.Country = cmbCountry.Text;
                    FrmGiris.customer.Province = cmbProvince.Text;
                    FrmGiris.customer.District = cmbDistrict.Text;
                    FrmGiris.customer.Adress = txtAdress.Text;
                    FrmGiris.customer.Telephone = txtTelephone.Text;
                    FrmGiris.customer.Email = txtEmail.Text;
                    FrmGiris.customer.m_CustomerUpdate(FrmGiris.customer.CustomerID, FrmGiris.customer.Title, FrmGiris.customer.TaxAdministration, FrmGiris.customer.TaxNumber, FrmGiris.customer.Country, FrmGiris.customer.Province, FrmGiris.customer.District, FrmGiris.customer.Adress, FrmGiris.customer.Telephone, FrmGiris.customer.Email);
                    MessageBox.Show("Müşteri Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmGiris.customer.m_Countries(cmbCountry);
                }
            }
            

        }

        private void txtTaxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
