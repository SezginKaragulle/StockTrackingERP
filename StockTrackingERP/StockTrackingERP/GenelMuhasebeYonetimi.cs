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
    public partial class GenelMuhasebeYonetimi : Form
    {
        public Giris FrmGiris;
        public GenelMuhasebeYonetimi()
        {
            InitializeComponent();
        }
        public void m_AccoutingAccountManagementItems()
        {
            DateTime dt_Yil = new DateTime(DateTime.Now.Year, 1, 1);
            datReceiptDate1.Text = dt_Yil.ToShortDateString();
            datReceiptDate2.Text = DateTime.Now.ToShortDateString();
            rdbAccountingAllReceipts.Checked = true;
            rdbAccountingReceivableReceipts.Checked = false;
            rdbAccountingDebtReceipts.Checked = false;
            dtAccountingReceiptList.DataSource = "";
            txtAccountingReceiptNo.Text = "";
            lblAccountingDebit.Text = "0";
            lblAccountingReceivable.Text = "0";


        }

        private int vrAccountingReceiptSearch = 0;
        private double vrAccountingTopReceivable = 0;
        private double vrAccountingTopDebit = 0;
        private void GenelMuhasebeYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_AccoutingAccountManagementItems();
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void rdbAccountingAllReceipts_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAccountingAllReceipts.Checked == true)
            {
                vrAccountingReceiptSearch = 0;
            }
        }

        private void rdbAccountingReceivableReceipts_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAccountingReceivableReceipts.Checked == true)
            {
                vrAccountingReceiptSearch = 1;
            }
        }

        private void rdbAccountingDebtReceipts_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAccountingDebtReceipts.Checked == true)
            {
                vrAccountingReceiptSearch = 2;
            }
        }

        private void btnAccountingReceipts_Click(object sender, EventArgs e)
        {
            
            FrmGiris.invoices.m_AccoutingReceiptsSearchList(dtAccountingReceiptList, DateTime.Parse(datReceiptDate1.Text), DateTime.Parse(datReceiptDate2.Text), txtAccountingReceiptNo.Text, vrAccountingReceiptSearch);
            vrAccountingTopReceivable = FrmGiris.invoices.m_AccountingTopReceivableDebit("Alacak");
            vrAccountingTopDebit = FrmGiris.invoices.m_AccountingTopReceivableDebit("Borç");
            lblAccountingReceivable.Text = vrAccountingTopReceivable.ToString();
            lblAccountingDebit.Text = vrAccountingTopDebit.ToString();


        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmMuhasebeFisEkle.m_AccoutingManagementAddItems();
            FrmGiris.FrmMuhasebeFisEkle.Show();
            this.Hide();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtAccountingReceiptList.CurrentRow.Cells[9].Value.ToString() == "S" || dtAccountingReceiptList.CurrentRow.Cells[9].Value.ToString() == "C")
            {
                MessageBox.Show("Muhasebeden Girilmeyen Fişler Silinemez.", "Muhasebe Fiş Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult vrAccountingReceiptDel;
                vrAccountingReceiptDel = MessageBox.Show(dtAccountingReceiptList.CurrentRow.Cells[0].Value.ToString() + " numaralı fişi silmek istiyor musunuz ?", "Muhasebe Fiş Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrAccountingReceiptDel == DialogResult.Yes)
                {
                    FrmGiris.invoices.m_AccountingDelReceiptDel(int.Parse(dtAccountingReceiptList.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("Muhase Fişi Silinmiştir.", "Muhasebe Fiş Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmGiris.invoices.m_AccoutingReceiptsSearchList(dtAccountingReceiptList, DateTime.Parse(datReceiptDate1.Text), DateTime.Parse(datReceiptDate2.Text), txtAccountingReceiptNo.Text, vrAccountingReceiptSearch);
                }
                else
                {
                    MessageBox.Show("Muhase Fişi Silme İşlemi Gerçekleştirilmedi.", "Muhasebe Fiş Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmGiris.invoices.m_AccoutingReceiptsSearchList(dtAccountingReceiptList, DateTime.Parse(datReceiptDate1.Text), DateTime.Parse(datReceiptDate2.Text), txtAccountingReceiptNo.Text, vrAccountingReceiptSearch);
                }
            }
        }
    }
}
