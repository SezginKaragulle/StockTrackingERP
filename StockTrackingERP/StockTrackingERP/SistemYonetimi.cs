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
    public partial class SistemYonetimi : Form
    {
        public Giris FrmGiris;
        public SistemYonetimi()
        {
            InitializeComponent();
        }

        public void m_UserInformations()
        {
            if (FrmGiris.FrmSistemYonetimi.vrUserAddUpdateStatus == "UserAdd")
            {
               FrmGiris.FrmKullanıcıEkleGuncelle.txtUserCode.Text = "";
               FrmGiris.FrmKullanıcıEkleGuncelle.txtUserPassword.Text = "";
               FrmGiris.FrmKullanıcıEkleGuncelle.txtNameSurname.Text = "";
               FrmGiris.FrmKullanıcıEkleGuncelle.txtEMail.Text = "";
               FrmGiris.FrmKullanıcıEkleGuncelle.txtTelephone.Text = "";
               FrmGiris.FrmKullanıcıEkleGuncelle.btnUserAddUpdate.Text = "Ekle";

            }
            else if (FrmGiris.FrmSistemYonetimi.vrUserAddUpdateStatus == "UserUpdate")
            {
                FrmGiris.FrmKullanıcıEkleGuncelle.vrUserID = int.Parse(FrmGiris.FrmSistemYonetimi.dtUsersList.CurrentRow.Cells[0].Value.ToString());
                FrmGiris.FrmKullanıcıEkleGuncelle.txtUserCode.Text = FrmGiris.FrmSistemYonetimi.dtUsersList.CurrentRow.Cells[1].Value.ToString();
                FrmGiris.FrmKullanıcıEkleGuncelle.txtNameSurname.Text = FrmGiris.FrmSistemYonetimi.dtUsersList.CurrentRow.Cells[2].Value.ToString();
                FrmGiris.FrmKullanıcıEkleGuncelle.txtEMail.Text = txtUserCode.Text = FrmGiris.FrmSistemYonetimi.dtUsersList.CurrentRow.Cells[3].Value.ToString();
                FrmGiris.FrmKullanıcıEkleGuncelle.txtTelephone.Text = txtUserCode.Text = FrmGiris.FrmSistemYonetimi.dtUsersList.CurrentRow.Cells[4].Value.ToString();
                FrmGiris.FrmKullanıcıEkleGuncelle.btnUserAddUpdate.Text = "Güncelle";
            }
        }

        public string vrUserAddUpdateStatus;

        private void SistemYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtUserCode.Text = "";
            txtNameSurName.Text = "";
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vrUserAddUpdateStatus = "UserAdd";
            FrmGiris.FrmKullanıcıEkleGuncelle.Show();
            m_UserInformations();
            this.Hide();
        }

        private void SistemYonetimi_KeyDown(object sender, KeyEventArgs e)
        {
            FrmGiris.FrmAnasayfa.m_ApplicationExit(e);
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vrUserAddUpdateStatus = "UserUpdate";
            FrmGiris.FrmKullanıcıEkleGuncelle.Show();
            //FrmGiris.FrmKullanıcıEkleGuncelle.m_UserInformations();
            m_UserInformations();
            this.Hide();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult vrResult;
            vrResult = MessageBox.Show(dtUsersList.CurrentRow.Cells[1].Value.ToString() + " Kullanıcısını Silmek İstiyor Musunuz ?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrResult == DialogResult.Yes)
            {
                FrmGiris.system.m_UserDelete(int.Parse(dtUsersList.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Kullanıcı Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmGiris.system.m_UserList(dtUsersList);
            }
            else
            {
                MessageBox.Show("Kullanıcı Silme İşlemi Gerçekleştirilmedi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmGiris.system.m_UserList(dtUsersList);
            }
        }

        private void genelKodBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmGenelKodBilgileri.Show();
            FrmGiris.FrmGenelKodBilgileri.cmbCodeİnformations.Text = "";
            FrmGiris.FrmGenelKodBilgileri.txtCodeID.Text = "";
            FrmGiris.FrmGenelKodBilgileri.txtCodeName.Text = "";
            this.Hide();

        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtUserCode.Text != "" || txtNameSurName.Text !="")
            {
                FrmGiris.system.m_UserSearch(dtUsersList, txtUserCode.Text, txtNameSurName.Text);
                txtUserCode.Text = "";
                txtNameSurName.Text = "";
            }
            else if (txtUserCode.Text == "" && txtNameSurName.Text == "")
            {
                FrmGiris.system.m_UserList(dtUsersList);
            }

        }
    }
}
