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
    public partial class CariHesapYonetimi : Form
    {
        public Giris FrmGiris;
        public CariHesapYonetimi()
        {
            InitializeComponent();
        }

        public void m_CurrentAccountManagementItems()
        {
            DateTime dt_Yil = new DateTime(DateTime.Now.Year, 1, 1);
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            datReceiptDate1.Text = dt_Yil.ToShortDateString();
            datReceiptDate2.Text = DateTime.Now.ToShortDateString();
            rdbCurrentAllReceipts.Checked = true;
            rdbCurrentReceivableReceipts.Checked = false;
            rdbCurrentDebtReceipts.Checked = false;
            dtCurrentAccountReceiptList.DataSource = "";
            txtCurrentReceiptNo.Text = "";
            lblCurrentDebit.Text = "0";
            lblCurrentReceivable.Text = "0";
            
        
        }
        private int vrCurrentReceiptSearch = 0;
        private double vrCurrentTopReceivable = 0;
        private double vrCurrentTopDebit = 0;
        private void CariHesapYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_CurrentAccountManagementItems();
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void btnCurrentReceipts_Click(object sender, EventArgs e)
        {
            if (txtCustomerCode.Text == "" ||txtCustomerName.Text == "")
            {
                MessageBox.Show("Müşteri Seçimi Yapmalısınız","Müşteri Liste",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                FrmGiris.invoices.m_CurrentReceiptsSearchList(dtCurrentAccountReceiptList, DateTime.Parse(datReceiptDate1.Text), DateTime.Parse(datReceiptDate2.Text), txtCustomerCode.Text, txtCurrentReceiptNo.Text, vrCurrentReceiptSearch);
                vrCurrentTopReceivable = FrmGiris.invoices.m_CurrentTopReceivableDebit(int.Parse(txtCustomerCode.Text), "Alacak");
                vrCurrentTopDebit = FrmGiris.invoices.m_CurrentTopReceivableDebit(int.Parse(txtCustomerCode.Text), "Borç");
                //vrCurrentTopReceivable = FrmGiris.invoices.TestMetot();
                lblCurrentReceivable.Text = vrCurrentTopReceivable.ToString();
                lblCurrentDebit.Text = vrCurrentTopDebit.ToString();
            }
        }

        private void txtCustomerCode_KeyDown(object sender, KeyEventArgs e)
        {
            string vrCustomerNameValue;
            if (e.KeyCode == Keys.Enter)
            {
                FrmGiris.FrmMusterilerList.vrTransactionStatus = "Current";
                FrmGiris.FrmMusterilerList.Show();
                this.Hide();

            }
        }

        private void rdbCurrentAllReceipts_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCurrentAllReceipts.Checked == true)
            {
                vrCurrentReceiptSearch = 0;
            }
        }

        private void rdbCurrentReceivableReceipts_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCurrentReceivableReceipts.Checked == true)
            {
                vrCurrentReceiptSearch = 1;
            }
        }

        private void rdbCurrentDebtReceipts_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCurrentDebtReceipts.Checked == true)
            {
                vrCurrentReceiptSearch = 2;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCustomerCode.Text == "" || txtCustomerName.Text == "")
            {
                MessageBox.Show("Müşteri Seçimi Yapmalısınız", "Müşteri Liste", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if (dtCurrentAccountReceiptList.CurrentRow.Cells[10].Value.ToString() == "S")
            {
                MessageBox.Show("Satış uygulamasından gelen bir fiş olduğundan silinemez.","Cari Fiş Sil",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                DialogResult vrResultCurrentReceipt;
                vrResultCurrentReceipt = MessageBox.Show(dtCurrentAccountReceiptList.CurrentRow.Cells[0].Value.ToString() + " numaralı fişi silmek istiyor musunuz ?","Cari Fiş Silme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (vrResultCurrentReceipt == DialogResult.Yes)
                {
                    FrmGiris.invoices.m_AccountingDelReceiptDel(int.Parse(dtCurrentAccountReceiptList.CurrentRow.Cells[9].Value.ToString()));
                    FrmGiris.invoices.m_CurrentReceiptDel(int.Parse(dtCurrentAccountReceiptList.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("Cari Fiş Silindi", "Cari Fiş Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cari Fiş Silme İşlemi Gerçekleştirilmedi", "Cari Fiş Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmGiris.invoices.m_CurrentReceiptsSearchList(dtCurrentAccountReceiptList, DateTime.Parse(datReceiptDate1.Text), DateTime.Parse(datReceiptDate2.Text), txtCustomerCode.Text, txtCurrentReceiptNo.Text, vrCurrentReceiptSearch);
                }
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCustomerCode.Text == "" || txtCustomerName.Text == "")
            {
                MessageBox.Show("Müşteri Seçimi Yapmalısınız.", "Cari Kayıt Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmGiris.FrmCariHesapFisEkle.lblCustomerCode.Text = txtCustomerCode.Text;
                FrmGiris.FrmCariHesapFisEkle.lblCustomerName.Text = txtCustomerName.Text;
                FrmGiris.FrmCariHesapFisEkle.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
