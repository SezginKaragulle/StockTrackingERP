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
    public partial class MuhasebeFisEkle : Form
    {
        public Giris FrmGiris;
        public MuhasebeFisEkle()
        {
            InitializeComponent();
        }

        public void m_AccoutingManagementAddItems()
        {
            
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

        private string vrAccountingRecevivaleDebit = "";
        private void MuhasebeFisEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnCurrentReceiptExit_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmMuhasebeFisEkle.m_AccoutingManagementAddItems();
            FrmGiris.FrmGenelMuhasebeYonetimi.Show();
            this.Hide();
        }

        private void rdbReceivable_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReceivable.Checked == true)
            {
                vrAccountingRecevivaleDebit = "Alacak";
            }
        }

        private void rdbDebit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDebit.Checked == true)
            {
                vrAccountingRecevivaleDebit = "Borç";
            }
        }

        private void btnCurrentReceiptAdd_Click(object sender, EventArgs e)
        {
            if (rdbReceivable.Checked == false && rdbDebit.Checked == false)
            {
                MessageBox.Show("Alacak ve Borç seçmelisiniz", "Muhasebe Fiş Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmGiris.invoices.AccountingReceiptDate = DateTime.Parse(datReceiptDate.Text);
                FrmGiris.invoices.AccountingReceiptType = cmbReceiptTypes.Text;
                FrmGiris.invoices.AccountingDocumentNo = int.Parse(txtDocumentNo.Text);
                FrmGiris.invoices.AccountingDocumentDate = DateTime.Parse(datDocumentDate.Text);
                FrmGiris.invoices.AccountingCurrentTotalAmount = double.Parse(txtTotalAmount.Text);
                FrmGiris.invoices.AccountingReceiptExchange = cmbReceiptExchange.Text;
                FrmGiris.invoices.AccountingCurrentTLAmount = double.Parse(txtTLAmount.Text);
                FrmGiris.invoices.AccountingExplanation = txtExplanation.Text;
                FrmGiris.invoices.AccountingApplicationCode = "M";
                FrmGiris.invoices.AccountingReceivableDebit = vrAccountingRecevivaleDebit;

                FrmGiris.invoices.m_AccountingReceiptAdd(FrmGiris.invoices.AccountingReceiptDate, FrmGiris.invoices.AccountingReceiptType, FrmGiris.invoices.AccountingDocumentNo, FrmGiris.invoices.AccountingDocumentDate, FrmGiris.invoices.AccountingCurrentTotalAmount, FrmGiris.invoices.AccountingReceiptExchange, FrmGiris.invoices.AccountingCurrentTLAmount, FrmGiris.invoices.AccountingExplanation, FrmGiris.invoices.AccountingApplicationCode, FrmGiris.invoices.AccountingReceivableDebit);
                MessageBox.Show("Muhasebe Fişi Eklendi","Muhasebe Fişi Ekle",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FrmGiris.FrmMuhasebeFisEkle.m_AccoutingManagementAddItems();
                FrmGiris.FrmGenelMuhasebeYonetimi.Show();
                this.Hide();
            }
        }
    }
}
