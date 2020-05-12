using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace StockTrackingERP.Interfaces
{
    interface IInvoices
    {

        /***Invoices***/
        L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }
        int InvoiceNo { get; set; }
        DateTime InvoiceDate { get; set; }
        int CustomerID { get; set; }
        double TotalAmount { get; set; }
        string InvoiceExchange { get; set; }
       
        double TotalAmountNoVat { get; set; }

        double VatAmout { get; set; }

        double DiscountAmount { get; set; }

        double TLAmount { get; set; }

        int PaymentDay { get; set; }
        DateTime DueDate { get; set; }
        int CurrentReceiptNo { get; set; }
        int AccountingReceiptNo { get; set; }

        /***Invoices Details***/

        int ProductCode { get; set; }

        int ProductCount { get; set; }
        double ProductTopAmount { get; set; }
        string ProductExchange { get; set; }
        double ProductTotalAmountNoVat { get; set; }
        int ProductVadeRate { get; set; }
        double ProductVatAmount { get; set; }
        int ProductDiscountRate { get; set; }
        double ProductDiscountAmount { get; set; }
        double ProductTLAmount { get; set; }
        double ExchangeRate { get; set; }


        /****CurrentReceipts****/
         DateTime ReceiptDate { get; set; }
         string ReceiptType { get; set; }
         int CurrentCustomerID { get; set; }
         int DocumentNo { get; set; }
         DateTime DocumentDate { get; set; }

         double CurrentTotalAmount { get; set; }

         string ReceiptExchange { get; set; }
         double CurrentTLAmount { get; set; }

         string Explanation { get; set; }

         int CurrentAccountingReceipt { get; set; }

         string ApplicationCode { get; set; }

         string ReceivableDebit { get; set; }

        /****AccountingReceipts****/

        DateTime AccountingReceiptDate { get; set; }
        string AccountingReceiptType { get; set; }
        int AccountingDocumentNo { get; set; }
        DateTime AccountingDocumentDate { get; set; }

        double AccountingCurrentTotalAmount { get; set; }

        string AccountingReceiptExchange { get; set; }
        double AccountingCurrentTLAmount { get; set; }

        string AccountingExplanation { get; set; }



        string AccountingApplicationCode { get; set; }

        string AccountingReceivableDebit { get; set; }


        string m_CustomerCodeSearch(int vrCustomerCode, TextBox vrProductName);

        void m_InvoicesCounter(TextBox vrCounterNo);

        void m_InvoicesDetailsAdd(int vrInvoiceNo,int vrProductCode,int vrProductCount,double vrProductTopAmount,string vrProductExchange,double vrProductTotalAmountNoVat, int vrProductVatRate,double vrProductVatAmount,int vrProductDiscountRate, double vrProductDiscountAmount,double vrProductTLAmount,int vrStoreID, double vrExchangeRate);

        void m_InvoicesDetailsList(DataGridView vr_InvoicesDetailsList, int vrInvoiceNo);

        void m_InvoicesDetailsProductDel(int vrInvoiceDetailsID);

        void m_InvoiceAdd(int vrInvoiceNo, DateTime vrInvoiceDate,int vrCustomerID ,double vrTotalAmount, string vrInvoiceExchange, double vrTotalAmountNoVat, double vrVatAmount, double vrDiscountAmount, double vrTLAmount, int vrPaymentDay, DateTime vrDueDate, int vrCurrentReceiptNo, int vrAccountingReceipt);

        void m_InvoicesCounterUpdate(int vrInvoiceCount);

        void m_InvoicesList(DataGridView vr_InvoicesList, DateTime vrInvoiceDate1,DateTime vrInvoiceDate2);

        void m_InvoicesDetailsDelete(int vrInvoiceNo, int vrProductCode);

        void m_InvoicesDelete(int vrInvoiceNo);

        void m_InvoicesSearchList(DataGridView vr_InvoicesList, DateTime vrInvoiceDate1, DateTime vrInvoiceDate2,string vrInvoiceNo,string vrCustomerID,string vrCustomerName, int vrCurrentReceiptNo, int vrAccountingReceiptNo);

        void m_CurrentReceiptIntegration(DateTime vrCurrentReceiptDate, string vrCurrentReceiptType, int vrCurrentCustomerID, int vrDocumentNo, DateTime vrDocumentDate, double vrCurrentTotalAmount, string vrReceiptExchange, double vrCurrentTLAmount, string vrExplanation, int vrAccountingReceipt, string vrApplicationCode,string vrReceivableDebit);

        void m_CurrentReceiptIntegrationBack(int vrCurrentReceiptNo, int vrInvoiceNo);

        void m_CurrentReceiptsSearchList(DataGridView vr_CurrentReceiptsList, DateTime vrCurrentReceiptDate1, DateTime vrCurrentReceiptDate2, string vrCustomerID, string vrReceiptNo, int vrCurrentReceiptNo);

        void m_AccountingReceiptIntegration(DateTime vrAccountingReceiptDate, string vrAccountingReceiptType, int vrAccountingDocumentNo, DateTime vrAccountingDocumentDate, double vrAccountingCurrentTotalAmount, string vrAccountingReceiptExchange, double vrAccountingTLAmount, string vrAccountingExplanation, string vrAccountingApplicationCode, string vrAccountingReceivableDebit);

        void m_AccountingIntegrationBack(int vrAccountingReceiptNo, int vrInvoiceNo);

        void m_CurrentReceiptAdd(DateTime vrCurrentReceiptDate, string vrCurrentReceiptType, int vrCurrentCustomerID, int vrDocumentNo, DateTime vrDocumentDate, double vrCurrentTotalAmount, string vrReceiptExchange, double vrCurrentTLAmount, string vrExplanation, string vrApplicationCode, string vrReceivableDebit);

        void m_AccountingReceiptAdd(DateTime vrAccountingReceiptDate, string vrAccountingReceiptType, int vrAccountingDocumentNo, DateTime vrAccountingDocumentDate, double vrAccountingCurrentTotalAmount, string vrAccountingReceiptExchange, double vrAccountingTLAmount, string vrAccountingExplanation, string vrAccountingApplicationCode, string vrAccountingReceivableDebit);

        void m_CurrentReceiptDel(int vrCurrentReceiptNo);

        void m_AccountingDelReceiptDel(int vrAccountingReceiptNo);

        void m_AccoutingReceiptsSearchList(DataGridView vr_AccoutingReceiptsList, DateTime vrCurrentReceiptDate1, DateTime vrCurrentReceiptDate2,  string vrReceiptNo, int vrAccountingReceiptNo);

        double m_CurrentTopReceivableDebit(int vrCustomerID, string vrReceivableDebit);

        double m_AccountingTopReceivableDebit(string vrReceivableDebit);
    }
}
