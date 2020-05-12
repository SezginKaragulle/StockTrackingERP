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
    public partial class CariHesapFisEkle : Form
    {
        public Giris FrmGiris;
        public CariHesapFisEkle()
        {
            InitializeComponent();
        }

        public void m_CurrentReceiptsAddItems()
        {
            lblCustomerCode.Text = "";
            lblCustomerName.Text = "";
            datReceiptDate.Text = DateTime.Now.ToShortDateString();
            cmbReceiptTypes.Text = "";
            txtDocumentNo.Text = "";
            datDocumentDate.Text = DateTime.Now.ToShortDateString();
            txtTotalAmount.Text = "";
            cmbReceiptExchange.Text = "";
            txtTLAmount.Text = "";
            txtExplanation.Text = "";
            rdbReceivable.Checked = false;
            rdbDebit.Checked = false;

        }

        private string vrReceivableDebitRecord = "";
        private void CariHesapFisEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnCurrentReceiptExit_Click(object sender, EventArgs e)
        {
            m_CurrentReceiptsAddItems();
            FrmGiris.FrmCariHesapYonetimi.Show();
            this.Hide();
        }

        private void btnCurrentReceiptAdd_Click(object sender, EventArgs e)
        {
            if (rdbReceivable.Checked == false && rdbDebit.Checked == false)
            {
                MessageBox.Show("Alacak ve Borç Seçmelisiniz.", "Cari Fiş Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmGiris.invoices.ReceiptDate = DateTime.Parse(datReceiptDate.Text);
                FrmGiris.invoices.ReceiptType = cmbReceiptTypes.Text;
                FrmGiris.invoices.CurrentCustomerID = int.Parse(lblCustomerCode.Text);
                FrmGiris.invoices.DocumentNo = int.Parse(txtDocumentNo.Text);
                FrmGiris.invoices.DocumentDate = DateTime.Parse(datDocumentDate.Text);
                FrmGiris.invoices.CurrentTotalAmount = double.Parse(txtTotalAmount.Text);
                FrmGiris.invoices.ReceiptExchange = cmbReceiptExchange.Text;
                FrmGiris.invoices.CurrentTLAmount = double.Parse(txtTLAmount.Text);
                FrmGiris.invoices.Explanation = txtExplanation.Text;
                FrmGiris.invoices.ApplicationCode = "C";
                FrmGiris.invoices.ReceivableDebit = vrReceivableDebitRecord;

                FrmGiris.invoices.m_CurrentReceiptAdd(FrmGiris.invoices.ReceiptDate, FrmGiris.invoices.ReceiptType, FrmGiris.invoices.CurrentCustomerID, FrmGiris.invoices.DocumentNo, FrmGiris.invoices.DocumentDate, FrmGiris.invoices.CurrentTotalAmount, FrmGiris.invoices.ReceiptExchange, FrmGiris.invoices.CurrentTLAmount, FrmGiris.invoices.Explanation, FrmGiris.invoices.ApplicationCode, FrmGiris.invoices.ReceivableDebit);
                m_CurrentReceiptsAddItems();
                FrmGiris.FrmCariHesapYonetimi.Show();
                this.Hide();
            }
        }

        private void rdbReceivable_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReceivable.Checked == true)
            {
                vrReceivableDebitRecord = "Alacak";
            }
        }

        private void rdbDebit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDebit.Checked == true)
            {
                vrReceivableDebitRecord = "Borç";
            }
        }
    }
}
