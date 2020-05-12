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
    public partial class FaturaOlustur : Form
    {
        public Giris FrmGiris;
        public FaturaOlustur()
        {
            InitializeComponent();
        }

        public double vrTotalAmount;
        public double vrTotalAmountNoVat;
        public double vrVatAmount;
        public double vrDiscountAmount;
        public double vrTLAmount;
        private int vrInvoiceDetailsStockCount;
        private int vrLastInvoiceCount;
        private void FaturaOlustur_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            vrTotalAmount = double.Parse(txtTotalAmount.Text);
            vrTotalAmountNoVat = double.Parse(txtTotalAmountNoVat.Text);
            vrVatAmount = double.Parse(txtVatAmout.Text);
            vrTLAmount = double.Parse(txtTLAmount.Text);
            FrmGiris.FrmFaturaUrunEkle.txtProductCode.Text = "";
            FrmGiris.FrmFaturaUrunEkle.txtProductName.Text = "";
            FrmGiris.stock.m_StoresList(FrmGiris.FrmFaturaUrunEkle.cmbStores);
            FrmGiris.FrmFaturaUrunEkle.Show();
            this.Hide();
        }

        private void btnInvoiceBack_Click(object sender, EventArgs e)
        {
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            txtInvoiceNo.Text = "";
            datInvoiceDate.Text = DateTime.Now.ToShortDateString();
            txtPaymentDay.Text = "0";
            txtTotalAmount.Text = "0";
            cmbInvoiceExchange.Text = "";
            txtTotalAmountNoVat.Text = "0";
            txtVatAmout.Text = "0";
            txtDiscountAmount.Text = "0";
            txtTLAmount.Text = "0";
            datDueDate.Text = DateTime.Now.ToShortDateString();
            dtInvoicesDetails.DataSource = "";
            FrmGiris.FrmFaturaYonetimi.Show();
            this.Hide();
            
            
        }

        private void txtPaymentDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPaymentDay.Text == "0")
                {

                    datDueDate.Text = datInvoiceDate.Text;
                }
                else
                {
                    DateTime NextWeek = DateTime.Parse(datInvoiceDate.Value.ToShortDateString());
                    NextWeek = NextWeek.AddDays(int.Parse(txtPaymentDay.Text));
                    datDueDate.Text = NextWeek.ToShortDateString();
                    //DateTime NextWeek = DateTime.Now.AddDays(int.Parse(txtPaymentDay.Text));
                    //datDueDate.Text = NextWeek.ToShortDateString();
                }
            }
            
        }

        private void btnInvoiceCreating_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Fatura Oluşturma Kodlaması Yapılacak...");
            //FrmGiris.invoices.m_InvoicesDetailsList(dtInvoicesDetails, int.Parse(txtInvoiceNo.Text));
            //MessageBox.Show(FrmGiris.stock.m_StockCountTest(1, 1));

            

            if (txtCustomerCode.Text == "" || txtCustomerName.Text == "" || cmbInvoiceExchange.Text == "")
            {
                MessageBox.Show("Müşteri Kodu , Müşteri Adı ve Fatura Dövizi alanı boş bırakılamaz.","Fatura Oluştur",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                vrLastInvoiceCount = int.Parse(txtInvoiceNo.Text);
                FrmGiris.invoices.InvoiceNo = int.Parse(txtInvoiceNo.Text);
                FrmGiris.invoices.InvoiceDate = DateTime.Parse(datInvoiceDate.Text);
                FrmGiris.invoices.CustomerID = int.Parse(txtCustomerCode.Text);
                FrmGiris.invoices.TotalAmount = double.Parse(txtTotalAmount.Text);
                FrmGiris.invoices.InvoiceExchange = cmbInvoiceExchange.Text;
                FrmGiris.invoices.TotalAmountNoVat = double.Parse(txtTotalAmountNoVat.Text);
                FrmGiris.invoices.VatAmout = double.Parse(txtVatAmout.Text);
                FrmGiris.invoices.DiscountAmount = double.Parse(txtDiscountAmount.Text);
                FrmGiris.invoices.TLAmount = double.Parse(txtTLAmount.Text);
                FrmGiris.invoices.PaymentDay = int.Parse(txtPaymentDay.Text);
                FrmGiris.invoices.DueDate = DateTime.Parse(datDueDate.Text);
                FrmGiris.invoices.CurrentReceiptNo = 0;
                FrmGiris.invoices.AccountingReceiptNo = 0;

                vrLastInvoiceCount = vrLastInvoiceCount + 1;
                FrmGiris.invoices.m_InvoicesCounterUpdate(vrLastInvoiceCount);
                FrmGiris.invoices.m_InvoiceAdd(FrmGiris.invoices.InvoiceNo, FrmGiris.invoices.InvoiceDate,FrmGiris.invoices.CustomerID ,FrmGiris.invoices.TotalAmount, FrmGiris.invoices.InvoiceExchange, FrmGiris.invoices.TotalAmountNoVat, FrmGiris.invoices.VatAmout, FrmGiris.invoices.DiscountAmount, FrmGiris.invoices.TLAmount, FrmGiris.invoices.PaymentDay, FrmGiris.invoices.DueDate, FrmGiris.invoices.CurrentReceiptNo, FrmGiris.invoices.AccountingReceiptNo);
                MessageBox.Show(txtInvoiceNo.Text + " numaralı fatura oluşturuldu.","Fatura Oluştur");

                txtCustomerCode.Text = "";
                txtCustomerName.Text = "";
                txtInvoiceNo.Text = "";
                datInvoiceDate.Text = DateTime.Now.ToShortDateString();
                txtPaymentDay.Text = "0";
                txtTotalAmount.Text = "0";
                cmbInvoiceExchange.Text = "";
                txtTotalAmountNoVat.Text = "0";
                txtVatAmout.Text = "0";
                txtDiscountAmount.Text = "0";
                txtTLAmount.Text = "0";
                datDueDate.Text = DateTime.Now.ToShortDateString();
                dtInvoicesDetails.DataSource = "";
                FrmGiris.FrmFaturaYonetimi.m_InvoicesManagementItems();
                FrmGiris.FrmFaturaYonetimi.Show();
                this.Hide();


            }


        }

        private void txtCustomerCode_KeyDown(object sender, KeyEventArgs e)
        {
            string vrCustomerNameValue;
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomerCode.Text == "")
                {
                    FrmGiris.FrmMusterilerList.Show();
                    this.Hide();
                }

                else
                {
                    vrCustomerNameValue = FrmGiris.invoices.m_CustomerCodeSearch(int.Parse(txtCustomerCode.Text), txtCustomerName);
                    if (vrCustomerNameValue == null)
                    {
                        FrmGiris.FrmMusterilerList.Show();
                        this.Hide();
                    }
                    else
                    {
                        txtCustomerName.Text = vrCustomerNameValue;
                        vrCustomerNameValue = "";
                    }
                }
            }


        }

        private void btnProductDel_Click(object sender, EventArgs e)
        {
            vrTotalAmount = double.Parse(txtTotalAmount.Text);
            vrTotalAmountNoVat = double.Parse(txtTotalAmountNoVat.Text);
            vrVatAmount = double.Parse(txtVatAmout.Text);
            vrDiscountAmount = double.Parse(txtDiscountAmount.Text);
            vrTLAmount = double.Parse(txtTLAmount.Text);
            DialogResult vrResult;
            vrResult = MessageBox.Show(dtInvoicesDetails.CurrentRow.Cells[3].Value.ToString() + " ürününü silmek istiyor musunuz ?", "Ürün Silmek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrResult == DialogResult.Yes)
            {
                vrTotalAmount = vrTotalAmount - double.Parse(dtInvoicesDetails.CurrentRow.Cells[5].Value.ToString());
                vrTotalAmountNoVat = vrTotalAmountNoVat - double.Parse(dtInvoicesDetails.CurrentRow.Cells[7].Value.ToString());
                vrVatAmount = vrVatAmount - double.Parse(dtInvoicesDetails.CurrentRow.Cells[9].Value.ToString());
                vrDiscountAmount = vrDiscountAmount - double.Parse(dtInvoicesDetails.CurrentRow.Cells[11].Value.ToString());
                vrTLAmount = vrTLAmount - double.Parse(dtInvoicesDetails.CurrentRow.Cells[12].Value.ToString());

                txtTotalAmount.Text = vrTotalAmount.ToString();
                txtTotalAmountNoVat.Text = vrTotalAmountNoVat.ToString();
                txtVatAmout.Text = vrVatAmount.ToString();
                txtDiscountAmount.Text = vrDiscountAmount.ToString();
                txtTLAmount.Text = vrTLAmount.ToString();

                vrInvoiceDetailsStockCount = int.Parse(FrmGiris.stock.m_StockCountTest(int.Parse(dtInvoicesDetails.CurrentRow.Cells[2].Value.ToString()), int.Parse(dtInvoicesDetails.CurrentRow.Cells[13].Value.ToString())));
                vrInvoiceDetailsStockCount = vrInvoiceDetailsStockCount + int.Parse(dtInvoicesDetails.CurrentRow.Cells[4].Value.ToString());
                FrmGiris.stock.m_StocksAddUpdate(int.Parse(dtInvoicesDetails.CurrentRow.Cells[2].Value.ToString()), int.Parse(dtInvoicesDetails.CurrentRow.Cells[13].Value.ToString()), vrInvoiceDetailsStockCount, "UPDATE");

                FrmGiris.invoices.m_InvoicesDetailsProductDel(int.Parse(dtInvoicesDetails.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Ürün Silinmiştir.", "Ürün Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmGiris.invoices.m_InvoicesDetailsList(dtInvoicesDetails, int.Parse(txtInvoiceNo.Text));

            }
            else
            {
                MessageBox.Show("Silme İşlemi Gerçekleştirilmedi", "Ürün Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmGiris.invoices.m_InvoicesDetailsList(dtInvoicesDetails, int.Parse(txtInvoiceNo.Text));

            }
        }

        private void txtPaymentDay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
