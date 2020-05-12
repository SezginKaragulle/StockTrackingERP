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
    public partial class FaturaYonetimi : Form
    {
        public Giris FrmGiris;
        public FaturaYonetimi()
        {
            InitializeComponent();
        }

        private int vrUpdateProductCount;
        private int vrCurrentReceiptNo = 0;
        private int vrAccountingReceiptNo = 0;
        public void m_InvoicesManagementItems()
        {
            DateTime dt_Yil = new DateTime(DateTime.Now.Year, 1, 1);
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            txtInvoiceNo.Text = "";
            dtInvoiceDate1.Text = dt_Yil.ToShortDateString();
            dtInvoiceDate2.Text = DateTime.Now.ToShortDateString();
            rdbCurrentIntegrationAll.Checked = true;
            rdbCurrentIntegrationYes.Checked = false;
            rdbCurrentIntegrationNo.Checked = false;
            rdbAccountingAll.Checked = true;
            rdbAccountingYes.Checked = false;
            rdbAccountingNo.Checked = false;
            dtİnvoiceList.DataSource = "";
            dtİnvoicesDetails.DataSource = "";

        }
        private void FaturaYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_InvoicesManagementItems();
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void faturaOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            txtInvoiceNo.Text = "";
            dtInvoiceDate1.Text = DateTime.Now.ToShortDateString();
            dtInvoiceDate2.Text = DateTime.Now.ToShortDateString();
            rdbCurrentIntegrationAll.Checked = true;
            rdbCurrentIntegrationYes.Checked = false;
            rdbCurrentIntegrationNo.Checked = false;
            rdbAccountingAll.Checked = true;
            rdbAccountingYes.Checked = false;
            rdbAccountingNo.Checked = false;
            dtİnvoiceList.DataSource = "";
            dtİnvoicesDetails.DataSource = "";
            FrmGiris.invoices.m_InvoicesCounter(FrmGiris.FrmFaturaOlustur.txtInvoiceNo);
            FrmGiris.FrmFaturaOlustur.Show();
            this.Hide();
        }

        private void FaturaYonetimi_KeyDown(object sender, KeyEventArgs e)
        {
            FrmGiris.FrmAnasayfa.m_ApplicationExit(e);
        }

        private void btnInvoicesDetails_Click(object sender, EventArgs e)
        {
            
        }

        private void faturaİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(dtİnvoiceList.CurrentRow.Cells[12].Value.ToString()) > 0 || int.Parse(dtİnvoiceList.CurrentRow.Cells[13].Value.ToString()) > 0)
            {
                MessageBox.Show("Cari ve Muhasebe entegrasyonu vardır. İptal Edilemez.", "Fatura İptali", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.Parse(dtİnvoiceList.CurrentRow.Cells[12].Value.ToString()) == 0 && int.Parse(dtİnvoiceList.CurrentRow.Cells[13].Value.ToString()) == 0)
            {
                DialogResult vrResult;
                vrResult = MessageBox.Show(dtİnvoiceList.CurrentRow.Cells[0].Value.ToString() + " numaralı faturayı iptal etmek istiyor musunuz ?", "Fatura İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrResult == DialogResult.Yes)
                {
                    //MessageBox.Show("Kodlaması Yapılacak");
                    for (int i = 0; i < dtİnvoicesDetails.Rows.Count - 1; i++)
                    {
                        //MessageBox.Show("Ürün Kodu:" + dtİnvoicesDetails.Rows[i].Cells[2].Value.ToString() + " Ürün Sayısı: " + dtİnvoicesDetails.Rows[i].Cells[4].Value.ToString() + " Depo ID: " + dtİnvoicesDetails.Rows[i].Cells[13].Value.ToString());
                        vrUpdateProductCount = int.Parse(FrmGiris.stock.m_StockCountTest(int.Parse(dtİnvoicesDetails.Rows[i].Cells[2].Value.ToString()), int.Parse(dtİnvoicesDetails.Rows[i].Cells[13].Value.ToString())));
                        vrUpdateProductCount = vrUpdateProductCount + int.Parse(dtİnvoicesDetails.Rows[i].Cells[4].Value.ToString());
                        FrmGiris.stock.m_StocksAddUpdate(int.Parse(dtİnvoicesDetails.Rows[i].Cells[2].Value.ToString()), int.Parse(dtİnvoicesDetails.Rows[i].Cells[13].Value.ToString()), vrUpdateProductCount, "UPDATE");
                        FrmGiris.invoices.m_InvoicesDetailsDelete(int.Parse(dtİnvoicesDetails.Rows[i].Cells[1].Value.ToString()), int.Parse(dtİnvoicesDetails.Rows[i].Cells[2].Value.ToString()));
                    }
                    
                    FrmGiris.invoices.m_InvoicesDelete(int.Parse(dtİnvoiceList.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("Fatura İptal Edildi", "Fatura İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_InvoicesManagementItems();
                }
                else
                {
                    MessageBox.Show("Fatura İptal İşlemi Gerçekleştirilmedi", "Fatura İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_InvoicesManagementItems();
                    FrmGiris.invoices.m_InvoicesSearchList(dtİnvoiceList, DateTime.Parse(dtInvoiceDate1.Text), DateTime.Parse(dtInvoiceDate2.Text), txtInvoiceNo.Text, txtCustomerCode.Text, txtCustomerName.Text, vrCurrentReceiptNo, vrAccountingReceiptNo);
                }


            }





        }

        private void btnInvoicesList_Click(object sender, EventArgs e)
        {
            //DateTime dt_Yil = new DateTime(DateTime.Now.Year, 1, 1);
            //MessageBox.Show(dt_Yil.ToString());
            //FrmGiris.invoices.m_InvoicesList(dtİnvoiceList, DateTime.Parse(dtInvoiceDate1.Text), DateTime.Parse(dtInvoiceDate2.Text));
            FrmGiris.invoices.m_InvoicesSearchList(dtİnvoiceList, DateTime.Parse(dtInvoiceDate1.Text), DateTime.Parse(dtInvoiceDate2.Text), txtInvoiceNo.Text, txtCustomerCode.Text, txtCustomerName.Text, vrCurrentReceiptNo, vrAccountingReceiptNo);


        }

        private void dtİnvoiceList_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dtİnvoiceList.CurrentRow.Cells[0].Value.ToString());
            FrmGiris.invoices.m_InvoicesDetailsList(dtİnvoicesDetails, int.Parse(dtİnvoiceList.CurrentRow.Cells[0].Value.ToString()));
        }

        private void rdbCurrentIntegrationAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCurrentIntegrationAll.Checked == true)
            {
                vrCurrentReceiptNo = 0;
            }
        }

        private void rdbCurrentIntegrationYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCurrentIntegrationYes.Checked == true)
            {
                vrCurrentReceiptNo = 1;
            }
        }

        private void rdbCurrentIntegrationNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCurrentIntegrationNo.Checked == true)
            {
                vrCurrentReceiptNo = 2;
            }
        }

        private void rdbAccountingAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAccountingAll.Checked == true)
            {
                vrAccountingReceiptNo = 0;

            }
        }

        private void rdbAccountingYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAccountingYes.Checked == true)
            {
                vrAccountingReceiptNo = 1;
            }
        }

        private void rdbAccountingNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAccountingNo.Checked == true)
            {
                vrAccountingReceiptNo = 0;
            }
        }

        private void cariEntegrasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (int.Parse(dtİnvoiceList.CurrentRow.Cells[12].Value.ToString()) <= 0)
            {
                FrmGiris.invoices.ReceiptDate = DateTime.Parse(dtİnvoiceList.CurrentRow.Cells[1].Value.ToString());
                FrmGiris.invoices.ReceiptType = "Fatura";
                FrmGiris.invoices.CurrentCustomerID = int.Parse(dtİnvoiceList.CurrentRow.Cells[2].Value.ToString());
                FrmGiris.invoices.DocumentNo = int.Parse(dtİnvoiceList.CurrentRow.Cells[0].Value.ToString());
                FrmGiris.invoices.DocumentDate = DateTime.Parse(dtİnvoiceList.CurrentRow.Cells[1].Value.ToString());
                FrmGiris.invoices.CurrentTotalAmount = double.Parse(dtİnvoiceList.CurrentRow.Cells[4].Value.ToString());
                FrmGiris.invoices.ReceiptExchange = dtİnvoiceList.CurrentRow.Cells[5].Value.ToString();
                FrmGiris.invoices.CurrentTLAmount = double.Parse(dtİnvoiceList.CurrentRow.Cells[9].Value.ToString());
                FrmGiris.invoices.Explanation = dtİnvoiceList.CurrentRow.Cells[3].Value.ToString() + " firmasının faturası";
                FrmGiris.invoices.CurrentAccountingReceipt = 0;
                FrmGiris.invoices.ApplicationCode = "S";
                FrmGiris.invoices.ReceivableDebit = "Alacak";

                FrmGiris.invoices.m_CurrentReceiptIntegration(FrmGiris.invoices.ReceiptDate, FrmGiris.invoices.ReceiptType, FrmGiris.invoices.CurrentCustomerID, FrmGiris.invoices.DocumentNo, FrmGiris.invoices.DocumentDate, FrmGiris.invoices.CurrentTotalAmount, FrmGiris.invoices.ReceiptExchange, FrmGiris.invoices.CurrentTLAmount, FrmGiris.invoices.Explanation, FrmGiris.invoices.CurrentAccountingReceipt, FrmGiris.invoices.ApplicationCode, FrmGiris.invoices.ReceivableDebit);
                FrmGiris.invoices.m_InvoicesSearchList(dtİnvoiceList, DateTime.Parse(dtInvoiceDate1.Text), DateTime.Parse(dtInvoiceDate2.Text), txtInvoiceNo.Text, txtCustomerCode.Text, txtCustomerName.Text, vrCurrentReceiptNo, vrAccountingReceiptNo);

            }
            else if (int.Parse(dtİnvoiceList.CurrentRow.Cells[12].Value.ToString()) > 0)
            {
                DialogResult vrResultCurrentReceipt;
                vrResultCurrentReceipt = MessageBox.Show(dtİnvoicesDetails.CurrentRow.Cells[0].Value.ToString() + " numaralı faturanın entegrasyonunu geri almak istiyor musunuz ?","Cari Entegrasyon",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (vrResultCurrentReceipt == DialogResult.Yes)
                {
                    FrmGiris.invoices.CurrentReceiptNo = int.Parse(dtİnvoiceList.CurrentRow.Cells[12].Value.ToString());
                    FrmGiris.invoices.InvoiceNo = int.Parse(dtİnvoiceList.CurrentRow.Cells[0].Value.ToString());
                    FrmGiris.invoices.m_CurrentReceiptIntegrationBack(FrmGiris.invoices.CurrentReceiptNo, FrmGiris.invoices.InvoiceNo);
                    FrmGiris.invoices.m_InvoicesSearchList(dtİnvoiceList, DateTime.Parse(dtInvoiceDate1.Text), DateTime.Parse(dtInvoiceDate2.Text), txtInvoiceNo.Text, txtCustomerCode.Text, txtCustomerName.Text, vrCurrentReceiptNo, vrAccountingReceiptNo);
                }
                else
                {
                    MessageBox.Show("Cari Entegrasyon Geri Alma İşlemi Gerçekleşmedi.", "Cari Entegrasyon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmGiris.invoices.m_InvoicesSearchList(dtİnvoiceList, DateTime.Parse(dtInvoiceDate1.Text), DateTime.Parse(dtInvoiceDate2.Text), txtInvoiceNo.Text, txtCustomerCode.Text, txtCustomerName.Text, vrCurrentReceiptNo, vrAccountingReceiptNo);
                }
            }
            //FrmGiris.invoices.m_TestMetot();


        }

        private void muhasebeEntegrasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(dtİnvoiceList.CurrentRow.Cells[12].Value.ToString()) <=0)
            {
                MessageBox.Show("Cari Entegrasyon Yapılmadan Muhasebe Yapılamaz","Muhasebe Entegrasyon",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (int.Parse(dtİnvoiceList.CurrentRow.Cells[13].Value.ToString()) <= 0)
                {
                    FrmGiris.invoices.AccountingReceiptDate = DateTime.Parse(dtİnvoiceList.CurrentRow.Cells[1].Value.ToString());
                    FrmGiris.invoices.AccountingReceiptType = "Fatura";
                    FrmGiris.invoices.AccountingDocumentNo = int.Parse(dtİnvoiceList.CurrentRow.Cells[0].Value.ToString());
                    FrmGiris.invoices.AccountingDocumentDate = DateTime.Parse(dtİnvoiceList.CurrentRow.Cells[1].Value.ToString());
                    FrmGiris.invoices.AccountingCurrentTotalAmount = double.Parse(dtİnvoiceList.CurrentRow.Cells[4].Value.ToString());
                    FrmGiris.invoices.AccountingReceiptExchange = dtİnvoiceList.CurrentRow.Cells[5].Value.ToString();
                    FrmGiris.invoices.AccountingCurrentTLAmount = double.Parse(dtİnvoiceList.CurrentRow.Cells[9].Value.ToString());
                    FrmGiris.invoices.AccountingExplanation = dtİnvoiceList.CurrentRow.Cells[3].Value.ToString() + " firmasının faturası";
                    FrmGiris.invoices.AccountingApplicationCode = "S";
                    FrmGiris.invoices.AccountingReceivableDebit = "Alacak";

                    FrmGiris.invoices.m_AccountingReceiptIntegration(FrmGiris.invoices.AccountingReceiptDate, FrmGiris.invoices.AccountingReceiptType, FrmGiris.invoices.AccountingDocumentNo, FrmGiris.invoices.AccountingDocumentDate, FrmGiris.invoices.AccountingCurrentTotalAmount, FrmGiris.invoices.AccountingReceiptExchange, FrmGiris.invoices.AccountingCurrentTLAmount, FrmGiris.invoices.AccountingExplanation, FrmGiris.invoices.AccountingApplicationCode, FrmGiris.invoices.AccountingReceivableDebit);
                    FrmGiris.invoices.m_InvoicesSearchList(dtİnvoiceList, DateTime.Parse(dtInvoiceDate1.Text), DateTime.Parse(dtInvoiceDate2.Text), txtInvoiceNo.Text, txtCustomerCode.Text, txtCustomerName.Text, vrCurrentReceiptNo, vrAccountingReceiptNo);

                }

                else if (int.Parse(dtİnvoiceList.CurrentRow.Cells[13].Value.ToString()) > 0)
                {
                    DialogResult vrResultAccountingReceipt;
                    vrResultAccountingReceipt = MessageBox.Show(dtİnvoicesDetails.CurrentRow.Cells[0].Value.ToString() + " numaralı faturanın entegrasyonunu geri almak istiyor musunuz ?", "Cari Entegrasyon", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vrResultAccountingReceipt == DialogResult.Yes)
                    {
                        FrmGiris.invoices.AccountingReceiptNo = int.Parse(dtİnvoiceList.CurrentRow.Cells[13].Value.ToString());
                        FrmGiris.invoices.InvoiceNo = int.Parse(dtİnvoiceList.CurrentRow.Cells[0].Value.ToString());
                        FrmGiris.invoices.m_AccountingIntegrationBack(FrmGiris.invoices.AccountingReceiptNo, FrmGiris.invoices.InvoiceNo);
                        FrmGiris.invoices.m_InvoicesSearchList(dtİnvoiceList, DateTime.Parse(dtInvoiceDate1.Text), DateTime.Parse(dtInvoiceDate2.Text), txtInvoiceNo.Text, txtCustomerCode.Text, txtCustomerName.Text, vrCurrentReceiptNo, vrAccountingReceiptNo);
                    }
                    else
                    {
                        MessageBox.Show("Muhasebe Entegrasyon Geri Alma İşlemi Gerçekleşmedi.", "Muhasebe Entegrasyon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmGiris.invoices.m_InvoicesSearchList(dtİnvoiceList, DateTime.Parse(dtInvoiceDate1.Text), DateTime.Parse(dtInvoiceDate2.Text), txtInvoiceNo.Text, txtCustomerCode.Text, txtCustomerName.Text, vrCurrentReceiptNo, vrAccountingReceiptNo);
                    }
                }
            }
        }
    }
}
