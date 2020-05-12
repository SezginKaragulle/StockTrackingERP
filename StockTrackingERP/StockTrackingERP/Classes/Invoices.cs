using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StockTrackingERP.Classes
{
   public class Invoices:Interfaces.IInvoices
    {
        /***Invoices***/
        public L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }
        public  int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerID { get; set; }
        public double TotalAmount { get; set; }
        public string InvoiceExchange { get; set; }
        public double TotalAmountNoVat { get; set; }

        public double VatAmout { get; set; }

        public double DiscountAmount { get; set; }

        public double TLAmount { get; set; }

        public int PaymentDay { get; set; }
        public DateTime DueDate { get; set; }
        public int CurrentReceiptNo { get; set; }
        public int AccountingReceiptNo { get; set; }

        /***Invoices Details***/

        public int ProductCode { get; set; }

        public int ProductCount { get; set; }
        public double ProductTopAmount { get; set; }
        public string ProductExchange { get; set; }

        public double ProductTotalAmountNoVat { get; set; }
        public int ProductVadeRate { get; set; }
        public double ProductVatAmount { get; set; }
        public int ProductDiscountRate { get; set; }
        public double ProductDiscountAmount { get; set; }
        public double ProductTLAmount { get; set; }

        public int StoreID { get; set; }

        public double ExchangeRate { get; set; }

        /****CurrentReceipts****/
        public DateTime ReceiptDate { get; set; }
        public string ReceiptType { get; set; }
        public int CurrentCustomerID { get; set; }
        public int DocumentNo { get; set; }
        public DateTime DocumentDate { get; set; }

        public double CurrentTotalAmount { get; set; }

        public string ReceiptExchange { get; set; }
        public double CurrentTLAmount { get; set; }

        public string Explanation { get; set; }

        public int CurrentAccountingReceipt { get; set; }

        public string ApplicationCode { get; set; }

        public string ReceivableDebit { get; set; }


        /****AccountingReceipts****/

        public DateTime AccountingReceiptDate { get; set; }
        public string AccountingReceiptType { get; set; }
        public int AccountingDocumentNo { get; set; }
        public DateTime AccountingDocumentDate { get; set; }

        public double AccountingCurrentTotalAmount { get; set; }

        public string AccountingReceiptExchange { get; set; }
        public double AccountingCurrentTLAmount { get; set; }

        public string AccountingExplanation { get; set; }



        public string AccountingApplicationCode { get; set; }

        public string AccountingReceivableDebit { get; set; }


        private string vrLastQuery;

        private int vrLastCurrentReceiptRecord;

        private int vrLastAccountingReceiptRecord;
        public string m_CustomerCodeSearch(int vrCustomerCode, TextBox vrProductName)
        {
            vrProductName.Text = "";
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var CustomerSearch_Query = from albCustomerName in StockTrackingDataContext.p_CustomerSearchAction(vrCustomerCode) select albCustomerName.Column1;
            foreach (string item in CustomerSearch_Query)
            {
                //MessageBox.Show(item);
                vrLastQuery = item;
            }

            return vrLastQuery;
        }

        public void m_InvoicesCounter(TextBox vrCounterNo)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var InvoiceCounterSearch = from albInviceCount in StockTrackingDataContext.p_InvoicesNextCount("1") select albInviceCount.CountersNo;
            foreach (var item in InvoiceCounterSearch)
            {
                vrCounterNo.Text = item.ToString();
            }
        }

        public void m_InvoicesDetailsAdd(int vrInvoiceNo, int vrProductCode, int vrProductCount, double vrProductTopAmount, string vrProductExchange, double vrProductTotalAmountNoVat, int vrProductVatRate, double vrProductVatAmount, int vrProductDiscountRate, double vrProductDiscountAmount, double vrProductTLAmount, int vrStoreID, double vrExchangeRate)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            InvoicesDetail invoicesDetail = new InvoicesDetail();
            invoicesDetail.InvoiceNo = vrInvoiceNo;
            invoicesDetail.ProductCode = vrProductCode;
            invoicesDetail.ProductCount = vrProductCount;
            invoicesDetail.ProductTopAmount = decimal.Parse(vrProductTopAmount.ToString());
            invoicesDetail.ProductExchange = vrProductExchange;
            invoicesDetail.ProductTotalAmountNoVat = decimal.Parse(vrProductTotalAmountNoVat.ToString());
            invoicesDetail.ProductVatRate = vrProductVatRate;
            invoicesDetail.ProductVatAmount = decimal.Parse(vrProductVatAmount.ToString());
            invoicesDetail.ProductDiscountRate = vrProductDiscountRate;
            invoicesDetail.ProductDiscountAmount = decimal.Parse(vrProductDiscountAmount.ToString());
            invoicesDetail.ProductTLAmount = decimal.Parse(vrProductTLAmount.ToString());
            invoicesDetail.StoreID = vrStoreID;
            invoicesDetail.ExchangeRate = decimal.Parse(vrExchangeRate.ToString());
            StockTrackingDataContext.InvoicesDetails.InsertOnSubmit(invoicesDetail);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_InvoicesDetailsList(DataGridView vr_InvoicesDetailsList,int vrInvoiceNo)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var InvoicesDetailsList_Query = StockTrackingDataContext.p_InvoicesDetailsList(vrInvoiceNo);
            vr_InvoicesDetailsList.DataSource = InvoicesDetailsList_Query;
            vr_InvoicesDetailsList.Columns[0].HeaderText = "Fatura ID";
            vr_InvoicesDetailsList.Columns[1].HeaderText = "Fatura No";
            vr_InvoicesDetailsList.Columns[2].HeaderText = "Ürün Kodu";
            vr_InvoicesDetailsList.Columns[3].HeaderText = "Ürün Adı";
            vr_InvoicesDetailsList.Columns[4].HeaderText = "Ürün Sayısı";
            vr_InvoicesDetailsList.Columns[5].HeaderText = "Toplam Tutar";
            vr_InvoicesDetailsList.Columns[6].HeaderText = "Döviz";
            vr_InvoicesDetailsList.Columns[7].HeaderText = "Kdvsiz Tutar";
            vr_InvoicesDetailsList.Columns[8].HeaderText = "Kdv Oranı";
            vr_InvoicesDetailsList.Columns[9].HeaderText = "Kdv Tutarı";
            vr_InvoicesDetailsList.Columns[10].HeaderText = "İndirim Oranı";
            vr_InvoicesDetailsList.Columns[11].HeaderText = "İndirim Tutarı";
            vr_InvoicesDetailsList.Columns[12].HeaderText = "Toplam TL Tutarı";
            vr_InvoicesDetailsList.Columns[13].HeaderText = "Depo No";
            vr_InvoicesDetailsList.Columns[14].HeaderText = "Depo Adı";
            vr_InvoicesDetailsList.Columns[15].HeaderText = "Döviz Kuru";


        }

       

        public void m_InvoicesDetailsProductDel(int vrInvoiceDetailsID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var ProductDel_Query = StockTrackingDataContext.InvoicesDetails.Single(d_query => d_query.InvoiceDetailsID == vrInvoiceDetailsID);
            StockTrackingDataContext.InvoicesDetails.DeleteOnSubmit(ProductDel_Query);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_InvoiceAdd(int vrInvoiceNo, DateTime vrInvoiceDate, int vrCustomerID, double vrTotalAmount, string vrInvoiceExchange, double vrTotalAmountNoVat, double vrVatAmount, double vrDiscountAmount, double vrTLAmount, int vrPaymentDay, DateTime vrDueDate, int vrCurrentReceiptNo, int vrAccountingReceipt)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            Invoice invoice = new Invoice();
            invoice.InvoiceNo = vrInvoiceNo;
            invoice.InvoiceDate = DateTime.Parse(vrInvoiceDate.ToString());
            invoice.CustomerID = vrCustomerID;
            invoice.TotalAmount = decimal.Parse(vrTotalAmount.ToString());
            invoice.InvoiceExchange = vrInvoiceExchange;
            invoice.TotalAmountNoVat = decimal.Parse(vrTotalAmountNoVat.ToString());
            invoice.VatAmout = decimal.Parse(vrVatAmount.ToString());
            invoice.DiscountAmount = decimal.Parse(vrDiscountAmount.ToString());
            invoice.TLAmount = decimal.Parse(vrTLAmount.ToString());
            invoice.PaymentDay = vrPaymentDay;
            invoice.DueDate = DateTime.Parse(vrDueDate.ToString());
            invoice.CurrentReceiptNo = vrCurrentReceiptNo;
            invoice.AccountingReceiptNo = vrAccountingReceipt;
            StockTrackingDataContext.Invoices.InsertOnSubmit(invoice);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_InvoicesCounterUpdate(int vrInvoiceCount)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var InvoicesCounterUpdate = StockTrackingDataContext.InvoicesCounters.Single(d_InvoiceCounter => d_InvoiceCounter.CountersID == 1);
            InvoicesCounterUpdate.CountersNo = vrInvoiceCount;
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_InvoicesList(DataGridView vr_InvoicesList, DateTime vrInvoiceDate1, DateTime vrInvoiceDate2)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var InvoicesList = StockTrackingDataContext.p_InvoicesList(vrInvoiceDate1, vrInvoiceDate2);
            vr_InvoicesList.DataSource = InvoicesList;
        }

        public void m_InvoicesDetailsDelete(int vrInvoiceNo, int vrProductCode)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var InvoiceDetailsDel = StockTrackingDataContext.InvoicesDetails.Single(d_InvoiceDetailsDel => d_InvoiceDetailsDel.InvoiceNo == vrInvoiceNo && d_InvoiceDetailsDel.ProductCode == vrProductCode);
            StockTrackingDataContext.InvoicesDetails.DeleteOnSubmit(InvoiceDetailsDel);
            StockTrackingDataContext.SubmitChanges();

        }

        public void m_InvoicesDelete(int vrInvoiceNo)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var InvoiceDel = StockTrackingDataContext.Invoices.Single(d_InvoiceDel => d_InvoiceDel.InvoiceNo == vrInvoiceNo);
            StockTrackingDataContext.Invoices.DeleteOnSubmit(InvoiceDel);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_InvoicesSearchList(DataGridView vr_InvoicesList2, DateTime vrInvoiceDate1, DateTime vrInvoiceDate2, string vrInvoiceNo, string vrCustomerID, string vrCustomerName,int vrCurrentReceiptNo,int vrAccountingReceiptNo)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var InvoicesDetailsList_Query2 = StockTrackingDataContext.p_InvoicesSearchList(vrInvoiceDate1, vrInvoiceDate2, vrInvoiceNo, vrCustomerID, vrCustomerName, vrCurrentReceiptNo, vrAccountingReceiptNo);
            vr_InvoicesList2.DataSource = InvoicesDetailsList_Query2;
            vr_InvoicesList2.Columns[0].HeaderText = "Fatura No";
            vr_InvoicesList2.Columns[1].HeaderText = "Fatura Tarihi";
            vr_InvoicesList2.Columns[2].HeaderText = "Müşteri Kodu";
            vr_InvoicesList2.Columns[3].HeaderText = "Müşteri Adı";
            vr_InvoicesList2.Columns[4].HeaderText = "Toplam Tutar";
            vr_InvoicesList2.Columns[5].HeaderText = "Fatura Döviz";
            vr_InvoicesList2.Columns[6].HeaderText = "Kdv'siz Tutar";
            vr_InvoicesList2.Columns[7].HeaderText = "Kdv'li Tutar";
            vr_InvoicesList2.Columns[8].HeaderText = "İndirim Tutarı";
            vr_InvoicesList2.Columns[9].HeaderText = "TL Tutar";
            vr_InvoicesList2.Columns[10].HeaderText = "Ödeme Günü";
            vr_InvoicesList2.Columns[11].HeaderText = "Ödeme Tarihi";
            vr_InvoicesList2.Columns[12].HeaderText = "Cari Fiş No";
            vr_InvoicesList2.Columns[13].HeaderText = "Muhasebe Fiş No";
            
        }

        public void m_CurrentReceiptIntegration(DateTime vrCurrentReceiptDate, string vrCurrentReceiptType, int vrCurrentCustomerID, int vrDocumentNo, DateTime vrDocumentDate, double vrCurrentTotalAmount, string vrReceiptExchange, double vrCurrentTLAmount, string vrExplanation, int vrAccountingReceipt, string vrApplicationCode,string vrReceivableDebit)
        {
            
            //Create a currenct receipt record on selected ınvoice

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            CurrentReceipt currentReceipt = new CurrentReceipt();
            currentReceipt.ReceiptDate = vrCurrentReceiptDate;
            currentReceipt.ReceiptType = vrCurrentReceiptType;
            currentReceipt.CustomerNo = vrCurrentCustomerID;
            currentReceipt.DocumentNo = vrDocumentNo;
            currentReceipt.DocumentDate = vrDocumentDate;
            currentReceipt.TotalAmount = decimal.Parse(vrCurrentTotalAmount.ToString());
            currentReceipt.ReceiptExchange = vrReceiptExchange;
            currentReceipt.TLAmount = decimal.Parse(vrCurrentTLAmount.ToString());
            currentReceipt.Explanation = vrExplanation;
            currentReceipt.AccountingReceipt = vrAccountingReceipt;
            currentReceipt.ApplicationCode = vrApplicationCode;
            currentReceipt.ReceivableDebit = vrReceivableDebit;
            StockTrackingDataContext.CurrentReceipts.InsertOnSubmit(currentReceipt);
            StockTrackingDataContext.SubmitChanges();

            //Find the last current receipt with customerId and ApplicationCode

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var LastCurrentReceiptRecord = from vr_CurrentReceipt in StockTrackingDataContext.CurrentReceipts
                                           where vr_CurrentReceipt.CustomerNo == vrCurrentCustomerID && vr_CurrentReceipt.ApplicationCode == "S"
                                           orderby vr_CurrentReceipt.ReceiptNo descending
                                           select vr_CurrentReceipt.ReceiptNo;
            foreach (int item_LastCurrentReceipt in LastCurrentReceiptRecord)
            {
                vrLastCurrentReceiptRecord = item_LastCurrentReceipt;
            }

            //Update the CurrentReceiptNo for Invoice table

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var UpdateInvoiceCurrentReceiptNo = StockTrackingDataContext.Invoices.Single(d_CurrentReceiptUpdate => d_CurrentReceiptUpdate.InvoiceNo == vrDocumentNo);
            UpdateInvoiceCurrentReceiptNo.CurrentReceiptNo = vrLastCurrentReceiptRecord;
            StockTrackingDataContext.SubmitChanges();

            MessageBox.Show("Cari Entegrasyon İşlemi Gerçekleştirildi.", "Cari Entegrasyon", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void m_CurrentReceiptIntegrationBack(int vrCurrentReceiptNo,int vrInvoiceNo)
        {
            //Delete theCurrentReceiptRecord With CurrenctNo on CurrentReceipts table

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var CurrentReceiptDelete = StockTrackingDataContext.CurrentReceipts.Single(d_CurrentReceiptDelete => d_CurrentReceiptDelete.ReceiptNo == vrCurrentReceiptNo);
            StockTrackingDataContext.CurrentReceipts.DeleteOnSubmit(CurrentReceiptDelete);
            StockTrackingDataContext.SubmitChanges();

            //Update thre CurrentNo on Invoices table

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var CurrentReceiptUpdate = StockTrackingDataContext.Invoices.Single(d_CurrentReceiptUpdate => d_CurrentReceiptUpdate.InvoiceNo == vrInvoiceNo);
            CurrentReceiptUpdate.CurrentReceiptNo = 0;
            StockTrackingDataContext.SubmitChanges();
            MessageBox.Show("Cari Entegrasyonu Geri Alındı", "Cari Entegrasyon", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void m_CurrentReceiptsSearchList(DataGridView vr_CurrentReceiptsList, DateTime vrCurrentReceiptDate1, DateTime vrCurrentReceiptDate2,string vrCustomerID, string vrReceiptNo ,int vrCurrentReceiptNo)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var CurrentReceiptsList = StockTrackingDataContext.p_CurrentReceiptsSearchList(vrCurrentReceiptDate1, vrCurrentReceiptDate2, vrReceiptNo, vrCustomerID, vrCurrentReceiptNo);
            vr_CurrentReceiptsList.DataSource = CurrentReceiptsList;
            vr_CurrentReceiptsList.Columns[0].HeaderText = "Fiş No";
            vr_CurrentReceiptsList.Columns[1].HeaderText = "Fiş Tarihi";
            vr_CurrentReceiptsList.Columns[2].HeaderText = "Fiş Tipi";
            vr_CurrentReceiptsList.Columns[3].HeaderText = "Belge No";
            vr_CurrentReceiptsList.Columns[4].HeaderText = "Belge Tarihi";
            vr_CurrentReceiptsList.Columns[5].HeaderText = "Toplam Tutar";
            vr_CurrentReceiptsList.Columns[6].HeaderText = "Döviz";
            vr_CurrentReceiptsList.Columns[7].HeaderText = "TL Tutar";
            vr_CurrentReceiptsList.Columns[8].HeaderText = "Açıklama";
            vr_CurrentReceiptsList.Columns[9].HeaderText = "Muhasebe Fişi";
            vr_CurrentReceiptsList.Columns[10].HeaderText = "Uygulama Kodu";
            vr_CurrentReceiptsList.Columns[11].HeaderText = "Alacak/Borç";

        }

        public void m_AccountingReceiptIntegration(DateTime vrAccountingReceiptDate, string vrAccountingReceiptType,  int vrAccountingDocumentNo, DateTime vrAccountingDocumentDate, double vrAccountingCurrentTotalAmount, string vrAccountingReceiptExchange, double vrAccountingTLAmount, string vrAccountingExplanation, string vrAccountingApplicationCode, string vrAccountingReceivableDebit)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            AccountingReceipt accountingReceipt = new AccountingReceipt();
            accountingReceipt.ReceiptDate = vrAccountingReceiptDate;
            accountingReceipt.ReceiptType = vrAccountingReceiptType;
            accountingReceipt.DocumentNo = vrAccountingDocumentNo;
            accountingReceipt.DocumentDate = vrAccountingDocumentDate;
            accountingReceipt.TotalAmount = decimal.Parse(vrAccountingCurrentTotalAmount.ToString());
            accountingReceipt.ReceiptExchange = vrAccountingReceiptExchange;
            accountingReceipt.TLAmount = decimal.Parse(vrAccountingTLAmount.ToString());
            accountingReceipt.Explanation = vrAccountingExplanation;
            accountingReceipt.ApplicationCode = vrAccountingApplicationCode;
            accountingReceipt.ReceivableDebit = vrAccountingReceivableDebit;
            StockTrackingDataContext.AccountingReceipts.InsertOnSubmit(accountingReceipt);
            StockTrackingDataContext.SubmitChanges();

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var LastAccountingRecord = from vr_AccountingReceipt in StockTrackingDataContext.AccountingReceipts
                                       where vr_AccountingReceipt.ApplicationCode == "S"
                                       orderby vr_AccountingReceipt.ReceiptNo descending
                                       select vr_AccountingReceipt.ReceiptNo;

            foreach (int item_LastAccountingReceipt in LastAccountingRecord)
            {
                vrLastAccountingReceiptRecord = item_LastAccountingReceipt;
            }

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var UpdateAccountingReceiptNo = StockTrackingDataContext.Invoices.Single(d_AccountingReceiptUpdate => d_AccountingReceiptUpdate.InvoiceNo == vrAccountingDocumentNo);
            UpdateAccountingReceiptNo.AccountingReceiptNo = vrLastAccountingReceiptRecord;
            StockTrackingDataContext.SubmitChanges();
            MessageBox.Show("Muhasebe Entegrasyon İşlemi Gerçekleştirildi.", "Muhasebe Entegrasyon", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        public void m_AccountingIntegrationBack(int vrAccountingReceiptNo, int vrInvoiceNo)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var AccountingReceiptDelete = StockTrackingDataContext.AccountingReceipts.Single(d_AccountingReceiptDelete => d_AccountingReceiptDelete.ReceiptNo == vrAccountingReceiptNo);
            StockTrackingDataContext.AccountingReceipts.DeleteOnSubmit(AccountingReceiptDelete);
            StockTrackingDataContext.SubmitChanges();

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var AccountingReceiptUpdate = StockTrackingDataContext.Invoices.Single(d_AccountingReceiptUpdate => d_AccountingReceiptUpdate.InvoiceNo == vrInvoiceNo);
            AccountingReceiptUpdate.AccountingReceiptNo = 0;
            StockTrackingDataContext.SubmitChanges();
            MessageBox.Show("Muhasebe Entegrasyonu Geri Alındı", "Muhasebe Entegrasyon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void m_CurrentReceiptAdd(DateTime vrCurrentReceiptDate, string vrCurrentReceiptType, int vrCurrentCustomerID, int vrDocumentNo, DateTime vrDocumentDate, double vrCurrentTotalAmount, string vrReceiptExchange, double vrCurrentTLAmount, string vrExplanation, string vrApplicationCode, string vrReceivableDebit)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            CurrentReceipt currentReceipt = new CurrentReceipt();
            currentReceipt.ReceiptDate = vrCurrentReceiptDate;
            currentReceipt.ReceiptType = vrCurrentReceiptType;
            currentReceipt.CustomerNo = vrCurrentCustomerID;
            currentReceipt.DocumentNo = vrDocumentNo;
            currentReceipt.DocumentDate = vrDocumentDate;
            currentReceipt.TotalAmount = decimal.Parse(vrCurrentTotalAmount.ToString());
            currentReceipt.ReceiptExchange = vrReceiptExchange;
            currentReceipt.TLAmount = decimal.Parse(vrCurrentTLAmount.ToString());
            currentReceipt.Explanation = vrExplanation;
            currentReceipt.ApplicationCode = vrApplicationCode;
            currentReceipt.ReceivableDebit = vrReceivableDebit;
            StockTrackingDataContext.CurrentReceipts.InsertOnSubmit(currentReceipt);
            StockTrackingDataContext.SubmitChanges();


            m_AccountingReceiptAdd(vrCurrentReceiptDate, vrCurrentReceiptType, vrDocumentNo, vrDocumentDate, vrCurrentTotalAmount, vrReceiptExchange, vrCurrentTLAmount, vrExplanation, vrApplicationCode, vrReceivableDebit);

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var LastAccountingReceiptRecord = StockTrackingDataContext.p_CurrentAccountingNo(vrCurrentCustomerID, "M");
            vrLastAccountingReceiptRecord = LastAccountingReceiptRecord;


            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var LastCurrentReceiptRecord = StockTrackingDataContext.p_CurrentAccountingNo(vrCurrentCustomerID, "C");
            vrLastCurrentReceiptRecord = LastCurrentReceiptRecord;

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var UpdateCurrentAccounting = StockTrackingDataContext.CurrentReceipts.Single(d_CurrentReceiptUpdate =>d_CurrentReceiptUpdate.ReceiptNo == vrLastCurrentReceiptRecord);
            UpdateCurrentAccounting.AccountingReceipt = vrLastAccountingReceiptRecord;
            StockTrackingDataContext.SubmitChanges();
            MessageBox.Show("Cari Fiş Ekleme İşlemi Gerçekleştirildi.", "Cari Fiş Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        public void m_AccountingReceiptAdd(DateTime vrAccountingReceiptDate, string vrAccountingReceiptType, int vrAccountingDocumentNo, DateTime vrAccountingDocumentDate, double vrAccountingCurrentTotalAmount, string vrAccountingReceiptExchange, double vrAccountingTLAmount, string vrAccountingExplanation, string vrAccountingApplicationCode, string vrAccountingReceivableDebit)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            AccountingReceipt accountingReceipt = new AccountingReceipt();
            accountingReceipt.ReceiptDate = vrAccountingReceiptDate;
            accountingReceipt.ReceiptType = vrAccountingReceiptType;
            accountingReceipt.DocumentNo = vrAccountingDocumentNo;
            accountingReceipt.DocumentDate = vrAccountingDocumentDate;
            accountingReceipt.TotalAmount = decimal.Parse(vrAccountingCurrentTotalAmount.ToString());
            accountingReceipt.ReceiptExchange = vrAccountingReceiptExchange;
            accountingReceipt.TLAmount = decimal.Parse(vrAccountingTLAmount.ToString());
            accountingReceipt.Explanation = vrAccountingExplanation;
            accountingReceipt.ApplicationCode = vrAccountingApplicationCode;
            accountingReceipt.ReceivableDebit = vrAccountingReceivableDebit;
            StockTrackingDataContext.AccountingReceipts.InsertOnSubmit(accountingReceipt);
            StockTrackingDataContext.SubmitChanges();
        }

        public int m_TestMetot2()
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var LastCurrentReceiptRecord = StockTrackingDataContext.p_CurrentAccountingNo(5, "M");
            return LastCurrentReceiptRecord;



        }

        public void m_CurrentReceiptDel(int vrCurrentReceiptNo)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var DeleteCurrentReceipt = StockTrackingDataContext.CurrentReceipts.Single(d_DeleteCurrentReceipts => d_DeleteCurrentReceipts.ReceiptNo == vrCurrentReceiptNo);
            StockTrackingDataContext.CurrentReceipts.DeleteOnSubmit(DeleteCurrentReceipt);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_AccountingDelReceiptDel(int vrAccountingReceiptNo)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var DeleteAccountingReceipt = StockTrackingDataContext.AccountingReceipts.Single(d_DeleteAccountingReceipts => d_DeleteAccountingReceipts.ReceiptNo == vrAccountingReceiptNo);
            StockTrackingDataContext.AccountingReceipts.DeleteOnSubmit(DeleteAccountingReceipt);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_AccoutingReceiptsSearchList(DataGridView vr_AccoutingReceiptsList, DateTime vrCurrentReceiptDate1, DateTime vrCurrentReceiptDate2, string vrReceiptNo, int vrAccountingReceiptNo)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var AccoutingReceiptsList = StockTrackingDataContext.p_AccountingReceiptsSearchList(vrCurrentReceiptDate1, vrCurrentReceiptDate2, vrReceiptNo, vrAccountingReceiptNo);
            vr_AccoutingReceiptsList.DataSource = AccoutingReceiptsList;
            vr_AccoutingReceiptsList.Columns[0].HeaderText = "Fiş No";
            vr_AccoutingReceiptsList.Columns[1].HeaderText = "Fiş Tarihi";
            vr_AccoutingReceiptsList.Columns[2].HeaderText = "Fiş Tipi";
            vr_AccoutingReceiptsList.Columns[3].HeaderText = "Belge No";
            vr_AccoutingReceiptsList.Columns[4].HeaderText = "Belge Tarihi";
            vr_AccoutingReceiptsList.Columns[5].HeaderText = "Toplam Tutar";
            vr_AccoutingReceiptsList.Columns[6].HeaderText = "Döviz";
            vr_AccoutingReceiptsList.Columns[7].HeaderText = "TL Tutar";
            vr_AccoutingReceiptsList.Columns[8].HeaderText = "Açıklama";
            vr_AccoutingReceiptsList.Columns[9].HeaderText = "Uygulama Kodu";
            vr_AccoutingReceiptsList.Columns[10].HeaderText = "Alacak/Borç";
            
        }

        public double m_CurrentTopReceivableDebit(int vrCustomerID, string vrReceivableDebit)
        {
            double vrCurrentAccountingReceiptTop = 0;
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var CurrentTopReceivableDebit = from CurrentTopReceivable in StockTrackingDataContext.CurrentReceipts
                        where CurrentTopReceivable.CustomerNo == vrCustomerID && CurrentTopReceivable.ReceivableDebit == vrReceivableDebit
                        select CurrentTopReceivable.TLAmount;
            vrCurrentAccountingReceiptTop = double.Parse(CurrentTopReceivableDebit.Sum().ToString());
            return vrCurrentAccountingReceiptTop;

        }

        public double m_AccountingTopReceivableDebit(string vrReceivableDebit)
        {
            double vrAccountingReceiptTop = 0;
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var AccountingTopReceivableDebit = from AccountingTopReceivable in StockTrackingDataContext.AccountingReceipts
                                               where AccountingTopReceivable.ReceivableDebit == vrReceivableDebit
                                               select AccountingTopReceivable.TLAmount;
            vrAccountingReceiptTop = double.Parse(AccountingTopReceivableDebit.Sum().ToString());
            return vrAccountingReceiptTop;
        }

        //public double TestMetot()
        //{
        //    double testim = 0;
        //    StockTrackingDataContext = new L_StockTrackingERPDataContext();
        //    var total = from ogrenci in StockTrackingDataContext.CurrentReceipts
        //                where ogrenci.CustomerNo == 5 && ogrenci.ReceivableDebit == "Alacak"
        //                select ogrenci.TLAmount;

        //    testim = double.Parse(total.Sum().ToString());
        //    return testim;

        //}

        //public int m_TestMetot()
        //{
        //    int deger =0;
        //    StockTrackingDataContext = new L_StockTrackingERPDataContext();
        //    var Liste = from ogrenci in StockTrackingDataContext.Customers
        //                where ogrenci.Title == "test" && ogrenci.Adress == "test"
        //                orderby ogrenci.CustomerID descending
        //                select ogrenci.CustomerID;

        //    foreach (int item in Liste)
        //    {
        //        deger = item;
        //    }

        //    return deger;
        //}


    }
}
