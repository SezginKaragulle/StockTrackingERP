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
    public partial class Anasayfa : Form
    {
        public Giris FrmGiris;
        public Anasayfa()
        {
            InitializeComponent();
        }

        Classes.System system = new Classes.System();
        public void m_ApplicationExit(KeyEventArgs e)
        {
            DialogResult vrResult;   
            if (e.KeyCode == Keys.Escape)
            {
                vrResult = MessageBox.Show("Programdan Çıkış Yapmak İstiyor Musunuz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Programdan Çıkış İşlemi Gerçekleştirilmedi", "Çıkış", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnSystemManagement_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmSistemYonetimi.Show();
            FrmGiris.FrmSistemYonetimi.txtUserCode.Text = "";
            FrmGiris.FrmSistemYonetimi.txtNameSurName.Text = "";
            system.m_UserList(FrmGiris.FrmSistemYonetimi.dtUsersList);
            this.Hide();
        }

        private void Anasayfa_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Anasayfa_KeyDown(object sender, KeyEventArgs e)
        {
            m_ApplicationExit(e);
         
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmMusteriYonetimi.Show();
            FrmGiris.customer.m_CustomersList(FrmGiris.FrmMusteriYonetimi.dtCustomerList);
            FrmGiris.FrmMusteriYonetimi.txtCustomerID.Text = "";
            FrmGiris.FrmMusteriYonetimi.txtCustomerTitle.Text = "";
            FrmGiris.FrmMusteriYonetimi.txtTaxNumber.Text = "";
            this.Hide();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmUrunYonetimi.Show();
            FrmGiris.FrmUrunYonetimi.txtProductCode.Text = "";
            FrmGiris.FrmUrunYonetimi.txtProductName.Text = "";
            FrmGiris.product.m_ProductsList(FrmGiris.FrmUrunYonetimi.dtProductList);
            this.Hide();
        }

        private void btnStoreManagement_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmDepoYonetimi.Show();
            FrmGiris.FrmDepoYonetimi.txtStoreID.Text = "";
            FrmGiris.FrmDepoYonetimi.txtStoreName.Text = "";
            FrmGiris.stores.m_StoresList(FrmGiris.FrmDepoYonetimi.dtStoreList);
            this.Hide();
        }

        private void btnStockManagement_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmStokYonetimi.Show();
            FrmGiris.stock.m_StoresList(FrmGiris.FrmStokYonetimi.cmbStores);
            FrmGiris.FrmStokYonetimi.cmbStores.Text = "";
            FrmGiris.FrmStokYonetimi.dtStockList.DataSource = "";
            FrmGiris.FrmStokYonetimi.lblStoreID.Text = "0";
            FrmGiris.FrmStokYonetimi.txtProductCode.Text = "";
            FrmGiris.FrmStokYonetimi.txtProductName.Text = "";
            this.Hide();
        }

        private void btnInvoiceManagement_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmFaturaYonetimi.m_InvoicesManagementItems();
            FrmGiris.FrmFaturaYonetimi.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCurrentAccountManagement_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmCariHesapYonetimi.m_CurrentAccountManagementItems();
            FrmGiris.FrmCariHesapYonetimi.Show();
            this.Hide();
        }

        private void btnGeneralAccounting_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmGenelMuhasebeYonetimi.m_AccoutingAccountManagementItems();
            FrmGiris.FrmGenelMuhasebeYonetimi.Show();
            this.Hide();
        }
    }
}
