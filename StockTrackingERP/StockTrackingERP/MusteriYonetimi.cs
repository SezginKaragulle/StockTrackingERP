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
    public partial class MusteriYonetimi : Form
    {
        public Giris FrmGiris;
        public MusteriYonetimi()
        {
            InitializeComponent();
        }

        public string vr_CustValue;

        public void m_CustomerInformations()
        {
            if (vr_CustValue == "CustomerAdd")
            {
                FrmGiris.FrmMusteriEkleGuncelle.txtCustomerTitle.Text = "";
                FrmGiris.FrmMusteriEkleGuncelle.lblCustomerID.Text = "";
                FrmGiris.FrmMusteriEkleGuncelle.txtTaxAdministration.Text = "";
                FrmGiris.FrmMusteriEkleGuncelle.txtTaxNumber.Text = "";
                FrmGiris.FrmMusteriEkleGuncelle.cmbCountry.Text = "";
                FrmGiris.FrmMusteriEkleGuncelle.lblCountryID.Text = "0";
                FrmGiris.FrmMusteriEkleGuncelle.cmbProvince.Text = "";
                FrmGiris.FrmMusteriEkleGuncelle.lblProvinceID.Text = "0";
                FrmGiris.FrmMusteriEkleGuncelle.cmbDistrict.Text = "";
                FrmGiris.FrmMusteriEkleGuncelle.txtAdress.Text = "";
                FrmGiris.FrmMusteriEkleGuncelle.txtTelephone.Text = "";
                FrmGiris.FrmMusteriEkleGuncelle.txtEmail.Text = "";
                FrmGiris.FrmMusteriEkleGuncelle.btnCustomerAddUpdate.Text = "Ekle";
            }

            else if (vr_CustValue == "CustomerUpdate")
            {
                FrmGiris.FrmMusteriEkleGuncelle.lblCustomerID.Text = dtCustomerList.CurrentRow.Cells[0].Value.ToString();
                FrmGiris.FrmMusteriEkleGuncelle.txtCustomerTitle.Text = dtCustomerList.CurrentRow.Cells[1].Value.ToString();
                FrmGiris.FrmMusteriEkleGuncelle.txtTaxAdministration.Text = dtCustomerList.CurrentRow.Cells[2].Value.ToString();
                FrmGiris.FrmMusteriEkleGuncelle.txtTaxNumber.Text = dtCustomerList.CurrentRow.Cells[3].Value.ToString();
                FrmGiris.FrmMusteriEkleGuncelle.cmbCountry.Text = dtCustomerList.CurrentRow.Cells[4].Value.ToString();
                FrmGiris.FrmMusteriEkleGuncelle.cmbProvince.Text = dtCustomerList.CurrentRow.Cells[5].Value.ToString();
                FrmGiris.FrmMusteriEkleGuncelle.cmbDistrict.Text = dtCustomerList.CurrentRow.Cells[6].Value.ToString();
                FrmGiris.FrmMusteriEkleGuncelle.txtAdress.Text = dtCustomerList.CurrentRow.Cells[7].Value.ToString();
                FrmGiris.FrmMusteriEkleGuncelle.txtTelephone.Text = dtCustomerList.CurrentRow.Cells[8].Value.ToString(); ;
                FrmGiris.FrmMusteriEkleGuncelle.txtEmail.Text = dtCustomerList.CurrentRow.Cells[9].Value.ToString();
                FrmGiris.FrmMusteriEkleGuncelle.btnCustomerAddUpdate.Text = "Güncelle";
            }
        }
        private void MusteriYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            txtCustomerTitle.Text = "";
            txtTaxNumber.Text = "";
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "" & txtCustomerTitle.Text == "" & txtTaxNumber.Text == "")
            {
                FrmGiris.customer.m_CustomersList(dtCustomerList);
                txtCustomerID.Text = "";
                txtCustomerTitle.Text = "";
                txtTaxNumber.Text = "";
            }
            else
            {
                FrmGiris.customer.m_CustomerSearch(dtCustomerList, txtCustomerID.Text, txtCustomerTitle.Text, txtTaxNumber.Text);
                txtCustomerID.Text = "";
                txtCustomerTitle.Text = "";
                txtTaxNumber.Text = "";
            }
        }

        private void MusteriYonetimi_KeyDown(object sender, KeyEventArgs e)
        {
            FrmGiris.FrmAnasayfa.m_ApplicationExit(e);
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vr_CustValue = "CustomerAdd";
            m_CustomerInformations();
            FrmGiris.FrmMusteriEkleGuncelle.Show();
            FrmGiris.customer.m_Countries(FrmGiris.FrmMusteriEkleGuncelle.cmbCountry);
            this.Hide();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vr_CustValue = "CustomerUpdate";
            m_CustomerInformations();
            FrmGiris.FrmMusteriEkleGuncelle.Show();
            FrmGiris.customer.m_Countries(FrmGiris.FrmMusteriEkleGuncelle.cmbCountry);
            this.Hide();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult vrResult;
            vrResult = MessageBox.Show(dtCustomerList.CurrentRow.Cells[1].Value.ToString() + " Müşterisini Silmek İstiyor Musunuz ?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrResult == DialogResult.Yes)
            {
                FrmGiris.customer.m_CustomerDelete(int.Parse(dtCustomerList.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Müşteri Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmGiris.customer.m_CustomersList(dtCustomerList);
                txtCustomerID.Text = "";
                txtCustomerTitle.Text = "";
                txtTaxNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Müşteri Silme İşlemi Gerçekleştirilmedi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmGiris.customer.m_CustomersList(dtCustomerList);
                txtCustomerID.Text = "";
                txtCustomerTitle.Text = "";
                txtTaxNumber.Text = "";
            }
        }
    }
}
