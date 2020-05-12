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
    public partial class MusterilerList : Form
    {
        public Giris FrmGiris;
        public MusterilerList()
        {
            InitializeComponent();
        }


        public string vrTransactionStatus = "";
        private int vrCurrentReceiptSearch = 0;
        private void MusterilerList_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerExit_Click(object sender, EventArgs e)
        {
            if (vrTransactionStatus == "Current")
            {
                txtProductCode.Text = "";
                txtProductName.Text = "";
                dtCustomerList.DataSource = "";
                vrTransactionStatus = "";
                FrmGiris.FrmCariHesapYonetimi.Show();
                this.Hide();
            }
            else
            {
                txtProductCode.Text = "";
                txtProductName.Text = "";
                dtCustomerList.DataSource = "";
                FrmGiris.FrmFaturaOlustur.Show();
                this.Hide();
            }
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text == "" && txtProductName.Text == "")
            {
                FrmGiris.customer.m_CustomersList(dtCustomerList);
                txtProductCode.Text = "";
                txtProductName.Text = "";
            }
            else
            {
                FrmGiris.customer.m_CustomerSearch2(dtCustomerList, txtProductCode.Text, txtProductName.Text);
                txtProductCode.Text = "";
                txtProductName.Text = "";
            }
        }

        private void btnCustomerCheck_Click(object sender, EventArgs e)
        {
            if (dtCustomerList.DataSource == "")
            {
                MessageBox.Show("İlk Olarak Müşteri Seçmelisiniz", "Müşteri Seç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (vrTransactionStatus == "Current")
                {
                    FrmGiris.FrmCariHesapYonetimi.txtCustomerCode.Text = dtCustomerList.CurrentRow.Cells[0].Value.ToString();
                    FrmGiris.FrmCariHesapYonetimi.txtCustomerName.Text = dtCustomerList.CurrentRow.Cells[1].Value.ToString();
                    txtProductCode.Text = "";
                    txtProductName.Text = "";
                    dtCustomerList.DataSource = "";
                    vrTransactionStatus = "";
                    FrmGiris.FrmCariHesapYonetimi.Show();
                    this.Hide();
                }
                else
                {
                    FrmGiris.FrmFaturaOlustur.txtCustomerCode.Text = dtCustomerList.CurrentRow.Cells[0].Value.ToString();
                    FrmGiris.FrmFaturaOlustur.txtCustomerName.Text = dtCustomerList.CurrentRow.Cells[1].Value.ToString();
                    txtProductCode.Text = "";
                    txtProductName.Text = "";
                    dtCustomerList.DataSource = "";
                    vrTransactionStatus = "";
                    FrmGiris.FrmFaturaOlustur.Show();
                    this.Hide();
                }
            }
          
        }
    }
}
