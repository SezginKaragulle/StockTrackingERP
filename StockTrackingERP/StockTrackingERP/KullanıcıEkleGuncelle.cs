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
    public partial class KullanıcıEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public KullanıcıEkleGuncelle()
        {
            InitializeComponent();
        }

        public int vrUserID;
        //public void m_UserInformations()
        //{
        //    if (FrmGiris.FrmSistemYonetimi.vrUserAddUpdateStatus == "UserAdd")
        //    {
        //        txtUserCode.Text = "";
        //        txtUserPassword.Text = "";
        //        txtNameSurname.Text = "";
        //        txtEMail.Text = "";
        //        txtTelephone.Text = "";
        //        btnUserAddUpdate.Text = "Ekle";

        //    }
        //    else if (FrmGiris.FrmSistemYonetimi.vrUserAddUpdateStatus == "UserUpdate")
        //    {
        //        vrUserID = int.Parse(FrmGiris.FrmSistemYonetimi.dtUsersList.CurrentRow.Cells[0].Value.ToString());
        //        txtUserCode.Text = FrmGiris.FrmSistemYonetimi.dtUsersList.CurrentRow.Cells[1].Value.ToString();
        //        txtNameSurname.Text = FrmGiris.FrmSistemYonetimi.dtUsersList.CurrentRow.Cells[2].Value.ToString();
        //        txtEMail.Text = txtUserCode.Text = FrmGiris.FrmSistemYonetimi.dtUsersList.CurrentRow.Cells[3].Value.ToString();
        //        txtTelephone.Text = txtUserCode.Text = FrmGiris.FrmSistemYonetimi.dtUsersList.CurrentRow.Cells[4].Value.ToString();
        //        btnUserAddUpdate.Text = "Güncelle";
        //    }
        //}
        private void KullanıcıEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnUserExit_Click(object sender, EventArgs e)
        {
            txtUserCode.Text = "";
            txtUserPassword.Text = "";
            txtNameSurname.Text = "";
            txtEMail.Text = "";
            txtTelephone.Text = "";
            FrmGiris.FrmSistemYonetimi.Show();
            FrmGiris.FrmSistemYonetimi.txtUserCode.Text = "";
            FrmGiris.FrmSistemYonetimi.txtNameSurName.Text = "";
            FrmGiris.system.m_UserList(FrmGiris.FrmSistemYonetimi.dtUsersList);
            this.Hide();

            
            
           
        }

        private void btnUserAddUpdate_Click(object sender, EventArgs e)
        {
            FrmGiris.system.UserCode = txtUserCode.Text;
            FrmGiris.system.UserPassword = txtUserPassword.Text;
            FrmGiris.system.NameSurName = txtNameSurname.Text;
            FrmGiris.system.EMail = txtEMail.Text;
            FrmGiris.system.Telephone = txtTelephone.Text;

            if (txtUserCode.Text == "" || txtNameSurname.Text == "")
            {
                MessageBox.Show("Kullanıcı Kodu ve Adı Soyadı alanlarını boş bırakmayınız", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (btnUserAddUpdate.Text == "Ekle")
                {
                    FrmGiris.system.m_UserAdd(FrmGiris.system.UserCode, FrmGiris.system.UserPassword, FrmGiris.system.NameSurName, FrmGiris.system.EMail, FrmGiris.system.Telephone);
                    MessageBox.Show("Kullanıcı Eklendi", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserCode.Text = "";
                    txtUserPassword.Text = "";
                    txtNameSurname.Text = "";
                    txtEMail.Text = "";
                    txtTelephone.Text = "";
                }
                else if (btnUserAddUpdate.Text == "Güncelle")
                {
                    FrmGiris.system.m_UserUpdate(vrUserID, FrmGiris.system.UserCode, FrmGiris.system.UserPassword, FrmGiris.system.NameSurName, FrmGiris.system.EMail, FrmGiris.system.Telephone);
                    MessageBox.Show("Kullanıcı Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }
    }
}
