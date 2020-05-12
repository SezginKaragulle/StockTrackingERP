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
    public partial class GenelKodBilgileri : Form
    {
        public Giris FrmGiris;
        public GenelKodBilgileri()
        {
            InitializeComponent();
        }


        public void m_GeneralCodeInformations()
        {
            if (cmbCodeİnformations.Text == "Ülkeler")
            {
                if (vrGeneralCodeAddUpdateStatus == "GeneralAdd")
                {
                    FrmGiris.FrmUlkeEkleGuncelle.txtCountryName.Text = "";
                    FrmGiris.FrmUlkeEkleGuncelle.btnCountryAddUpdate.Text = "Ekle";

                }
                else if (vrGeneralCodeAddUpdateStatus == "GeneralUpdate")
                {
                    FrmGiris.FrmUlkeEkleGuncelle.txtCountryName.Text = dtGeneralCodeİnformations.CurrentRow.Cells[1].Value.ToString();
                    FrmGiris.FrmUlkeEkleGuncelle.btnCountryAddUpdate.Text = "Güncelle";
                }
            }

            else if (cmbCodeİnformations.Text == "İller")
            {
                if (vrGeneralCodeAddUpdateStatus == "GeneralAdd")
                {
                    FrmGiris.FrmİlEkleGuncelle.txtProvinceCode.Text = "";
                    FrmGiris.FrmİlEkleGuncelle.txtProvinceName.Text = "";
                    FrmGiris.FrmİlEkleGuncelle.txtCountryCode.Text = "";
                    FrmGiris.FrmİlEkleGuncelle.btnProvinceAddUpdate.Text = "Ekle";

                }
                else if (vrGeneralCodeAddUpdateStatus == "GeneralUpdate")
                {
                    FrmGiris.FrmİlEkleGuncelle.txtProvinceCode.Text = dtGeneralCodeİnformations.CurrentRow.Cells[1].Value.ToString();
                    FrmGiris.FrmİlEkleGuncelle.txtProvinceName.Text = dtGeneralCodeİnformations.CurrentRow.Cells[2].Value.ToString();
                    FrmGiris.FrmİlEkleGuncelle.txtCountryCode.Text = dtGeneralCodeİnformations.CurrentRow.Cells[3].Value.ToString();
                    FrmGiris.FrmİlEkleGuncelle.btnProvinceAddUpdate.Text = "Güncelle";
                }
            }

            else if (cmbCodeİnformations.Text == "İlçeler")
            {
                if (vrGeneralCodeAddUpdateStatus == "GeneralAdd")
                {
                    FrmGiris.FrmİlceEkleGuncelle.txtDistrictName.Text = "";
                    FrmGiris.FrmİlceEkleGuncelle.txtProvinceID.Text = "";
                    FrmGiris.FrmİlceEkleGuncelle.txtCountryID.Text = "";
                    FrmGiris.FrmİlceEkleGuncelle.btnDistrictAddUpdate.Text = "Ekle";
                    

                }
                else if (vrGeneralCodeAddUpdateStatus == "GeneralUpdate")
                {
                    FrmGiris.FrmİlceEkleGuncelle.txtDistrictName.Text = dtGeneralCodeİnformations.CurrentRow.Cells[1].Value.ToString();
                    FrmGiris.FrmİlceEkleGuncelle.txtProvinceID.Text = dtGeneralCodeİnformations.CurrentRow.Cells[2].Value.ToString();
                    FrmGiris.FrmİlceEkleGuncelle.txtCountryID.Text = dtGeneralCodeİnformations.CurrentRow.Cells[4].Value.ToString();
                    FrmGiris.FrmİlceEkleGuncelle.btnDistrictAddUpdate.Text = "Güncelle";

                }
            }
            else if (cmbCodeİnformations.Text == "Ürün Tipi")
            {
                if (vrGeneralCodeAddUpdateStatus == "GeneralAdd")
                {
                    FrmGiris.FrmUrunTipEkleGuncelle.lblProductTypeID.Text = "";
                    FrmGiris.FrmUrunTipEkleGuncelle.txtProductTypeName.Text = "";                  
                    FrmGiris.FrmUrunTipEkleGuncelle.btnProductTypeAddUpdate.Text = "Ekle";


                }
                else if (vrGeneralCodeAddUpdateStatus == "GeneralUpdate")
                {
                    FrmGiris.FrmUrunTipEkleGuncelle.lblProductTypeID.Text = dtGeneralCodeİnformations.CurrentRow.Cells[0].Value.ToString();
                    FrmGiris.FrmUrunTipEkleGuncelle.txtProductTypeName.Text = dtGeneralCodeİnformations.CurrentRow.Cells[1].Value.ToString();
                    FrmGiris.FrmUrunTipEkleGuncelle.btnProductTypeAddUpdate.Text = "Güncelle";

                }
            }


        }

        public string vrGeneralCodeAddUpdateStatus;
        private void GenelKodBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmSistemYonetimi.Show();
            FrmGiris.FrmSistemYonetimi.txtUserCode.Text = "";
            FrmGiris.FrmSistemYonetimi.txtNameSurName.Text = "";
            FrmGiris.system.m_UserList(FrmGiris.FrmSistemYonetimi.dtUsersList);
            this.Hide();
        }

        private void cmbCodeİnformations_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCodeİnformations.Text == "Ülkeler")
            {
                dtGeneralCodeİnformations.DataSource = "";
                FrmGiris.system.m_CountryList(dtGeneralCodeİnformations);
            }
            else if (cmbCodeİnformations.Text == "İller")
            {
                dtGeneralCodeİnformations.DataSource = "";
                FrmGiris.system.m_ProvinceList(dtGeneralCodeİnformations);
            }
            else if (cmbCodeİnformations.Text == "İlçeler")
            {
                dtGeneralCodeİnformations.DataSource = "";
                FrmGiris.system.m_DistrictList(dtGeneralCodeİnformations);
            }
            else if (cmbCodeİnformations.Text == "Ürün Tipi")
            {
                dtGeneralCodeİnformations.DataSource = "";
                FrmGiris.system.m_ProductTypesList(dtGeneralCodeİnformations);
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vrGeneralCodeAddUpdateStatus = "GeneralAdd";
            if (cmbCodeİnformations.Text == "")
            {
                MessageBox.Show("Genel Kod Bilgisi Seçiniz.","Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (cmbCodeİnformations.Text == "Ülkeler")
                {
                    m_GeneralCodeInformations();
                    FrmGiris.FrmUlkeEkleGuncelle.Show();
                    this.Hide();
                }

                else if (cmbCodeİnformations.Text == "İller")
                {
                    m_GeneralCodeInformations();
                    FrmGiris.FrmİlEkleGuncelle.Show();
                    this.Hide();
                }

                else if (cmbCodeİnformations.Text == "İlçeler")
                {
                    m_GeneralCodeInformations();
                    FrmGiris.FrmİlceEkleGuncelle.Show();
                    this.Hide();
                }

                else if (cmbCodeİnformations.Text == "Ürün Tipi")
                {
                    m_GeneralCodeInformations();
                    FrmGiris.FrmUrunTipEkleGuncelle.Show();
                    this.Hide();
                }
            }
            
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vrGeneralCodeAddUpdateStatus = "GeneralUpdate";
            if (cmbCodeİnformations.Text == "")
            {
                MessageBox.Show("Genel Kod Bilgisi Seçiniz.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cmbCodeİnformations.Text == "Ülkeler")
                {
                    m_GeneralCodeInformations();
                    FrmGiris.FrmUlkeEkleGuncelle.Show();
                    this.Hide();
                }

                else if (cmbCodeİnformations.Text == "İller")
                {
                    m_GeneralCodeInformations();
                    FrmGiris.FrmİlEkleGuncelle.Show();
                    this.Hide();
                }

                else if (cmbCodeİnformations.Text == "İlçeler")
                {
                    m_GeneralCodeInformations();
                    FrmGiris.FrmİlceEkleGuncelle.Show();
                    this.Hide();
                }

                else if (cmbCodeİnformations.Text == "Ürün Tipi")
                {
                    m_GeneralCodeInformations();
                    FrmGiris.FrmUrunTipEkleGuncelle.Show();
                    this.Hide();
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult vrResult;
            if (cmbCodeİnformations.Text == "")
            {
                MessageBox.Show("Genel Kod Bilgisi Seçiniz.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cmbCodeİnformations.Text == "Ülkeler")
                {
                    vrResult = MessageBox.Show(dtGeneralCodeİnformations.CurrentRow.Cells[1].Value.ToString() + " ülkesini silmek istiyor musunuz ?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vrResult == DialogResult.Yes)
                    {
                        FrmGiris.system.m_CountryDel(int.Parse(dtGeneralCodeİnformations.CurrentRow.Cells[0].Value.ToString()));
                        MessageBox.Show("Ülke Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtGeneralCodeİnformations.DataSource = "";
                        cmbCodeİnformations.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ülke Silme İşlemi Gerçekleştirilmedi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else if (cmbCodeİnformations.Text == "İller")
                {
                    vrResult = MessageBox.Show(dtGeneralCodeİnformations.CurrentRow.Cells[2].Value.ToString() + " il bilgisini silmek istiyor musunuz ?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vrResult == DialogResult.Yes)
                    {
                        FrmGiris.system.m_ProvinceDel(int.Parse(dtGeneralCodeİnformations.CurrentRow.Cells[0].Value.ToString()));
                        MessageBox.Show("İl Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtGeneralCodeİnformations.DataSource = "";
                        cmbCodeİnformations.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("İl Silme İşlemi Gerçekleştirilmedi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else if (cmbCodeİnformations.Text == "İlçeler")
                {
                    vrResult = MessageBox.Show(dtGeneralCodeİnformations.CurrentRow.Cells[1].Value.ToString() + " ilçe bilgisini silmek istiyor musunuz ?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vrResult == DialogResult.Yes)
                    {
                        FrmGiris.system.m_DistrictDel(int.Parse(dtGeneralCodeİnformations.CurrentRow.Cells[0].Value.ToString()));
                        MessageBox.Show("İlçe Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtGeneralCodeİnformations.DataSource = "";
                        cmbCodeİnformations.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("İl Silme İşlemi Gerçekleştirilmedi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else if (cmbCodeİnformations.Text == "Ürün Tipi")
                {
                    vrResult = MessageBox.Show(dtGeneralCodeİnformations.CurrentRow.Cells[1].Value.ToString() + " ürün tipi bilgisini silmek istiyor musunuz ?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vrResult == DialogResult.Yes)
                    {
                        FrmGiris.system.m_ProductTypeDel(int.Parse(dtGeneralCodeİnformations.CurrentRow.Cells[0].Value.ToString()));
                        MessageBox.Show("Ürün Tipi Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtGeneralCodeİnformations.DataSource = "";
                        cmbCodeİnformations.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ürün Tipi Silme İşlemi Gerçekleştirilmedi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void cmbCodeİnformations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbCodeİnformations.Text == "")
            {
                MessageBox.Show("Arama İçin Kod Grubu Seçmelisiniz", "Arama", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtCodeID.Text == "" && txtCodeName.Text == "")
                {
                    if (cmbCodeİnformations.Text == "Ülkeler")
                    {
                        dtGeneralCodeİnformations.DataSource = "";
                        FrmGiris.system.m_CountryList(dtGeneralCodeİnformations);
                    }
                    else if (cmbCodeİnformations.Text == "İller")
                    {
                        dtGeneralCodeİnformations.DataSource = "";
                        FrmGiris.system.m_ProvinceList(dtGeneralCodeİnformations);
                    }
                    else if (cmbCodeİnformations.Text == "İlçeler")
                    {
                        dtGeneralCodeİnformations.DataSource = "";
                        FrmGiris.system.m_DistrictList(dtGeneralCodeİnformations);
                    }
                    else if (cmbCodeİnformations.Text == "Ürün Tipi")
                    {
                        dtGeneralCodeİnformations.DataSource = "";
                        FrmGiris.system.m_ProductTypesList(dtGeneralCodeİnformations);
                    }
                }
                else if (txtCodeID.Text != "" || txtCodeName.Text != "")
                {
                   
                    dtGeneralCodeİnformations.DataSource = "";
                    FrmGiris.system.m_GeneralCodeİnformations(dtGeneralCodeİnformations, cmbCodeİnformations.Text.Trim(), txtCodeID.Text, txtCodeName.Text);
                    txtCodeID.Text = "";
                    txtCodeName.Text = "";
                }
            }
        }
    }
}
