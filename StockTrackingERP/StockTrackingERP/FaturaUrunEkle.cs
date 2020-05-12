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
    public partial class FaturaUrunEkle : Form
    {
        public Giris FrmGiris;
        public FaturaUrunEkle()
        {
            InitializeComponent();
        }
        public double vrProductTotalAmount;
        public double vrProductTotalVatAmount = 0;
        public double vrProductTotalDiscountAmount = 0;
        public double vrExchangeRate = 0;
        public double vrProductTotalAmountTL = 0;
        public int vrProductCount = 0;
        public int vrProductCurrentCount = 0;
        public int vrLastCount = 0; //Ürünün Güncel Stok Sayısı
        private void FaturaUrunEkle_Load(object sender, EventArgs e)
        {

        }
        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbStores.Text == "")
                {
                    MessageBox.Show("Depo Seçimi Yapmalısınız","Ürün Ekleme");
                }
                else
                {
                    FrmGiris.FrmFaturaUrunList.lblStoreName.Text = cmbStores.Text;
                    FrmGiris.FrmFaturaUrunList.lblStoreID.Text = lblStoreID.Text;
                    FrmGiris.FrmFaturaUrunList.Show();
                    this.Hide();
                }

            }
        }

        private void btnInvoiceProductExit_Click(object sender, EventArgs e)
        {
            cmbStores.Text = "";
            lblStoreID.Text = "0";
            txtProductCode.Text = "";
            txtProductName.Text = "";
            txtProductCount.Text = "";
            cmbInvoiceExchange.Text = "";
            txtProductAmount.Text = "0";
            txtProductExchangeRate.Text = "1,000";
            txtProductVat.Text = "0";
            txtProductDiscountRate.Text = "0";
            lblProductTotalAmount.Text = "0";
            lblProductTotalVatAmount.Text = "0";
            lblProductTotalDiscountAmount.Text = "0";
            lblProductTLAmount.Text = "0";
            lblProductExculindingVat.Text = "0";
            FrmGiris.invoices.m_InvoicesDetailsList(FrmGiris.FrmFaturaOlustur.dtInvoicesDetails, int.Parse(FrmGiris.FrmFaturaOlustur.txtInvoiceNo.Text));
            FrmGiris.FrmFaturaOlustur.Show();
            this.Hide();
        }

        private void btnInvoiceProductAdd_Click(object sender, EventArgs e)
        {
           
            // Toplam Tutar Verilerin Geçilmesi Testi
            //MessageBox.Show("Total Amount: " + FrmGiris.FrmFaturaOlustur.vrTotalAmount);
            //MessageBox.Show("Kdvsiz Toplam: " + FrmGiris.FrmFaturaOlustur.vrTotalAmountNoVat);
            //MessageBox.Show("kdv Toplam: " + FrmGiris.FrmFaturaOlustur.vrVatAmount);
            //MessageBox.Show("İndirim Toplam : " + FrmGiris.FrmFaturaOlustur.vrDiscountAmount);
            //MessageBox.Show("TL Toplam : " + FrmGiris.FrmFaturaOlustur.vrTLAmount);
            if (txtProductCode.Text == "" || txtProductName.Text == "" || txtProductCount.Text == "" || cmbInvoiceExchange.Text == "")
            {
                MessageBox.Show("İlgili Zorunlu Alanları Dolduralım(Ürün Kodu, Ürün Adı , Ürün Sayısı,Döviz Cinsi)", "Ürün Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                FrmGiris.invoices.InvoiceNo = int.Parse(FrmGiris.FrmFaturaOlustur.txtInvoiceNo.Text);
                FrmGiris.invoices.ProductCode = int.Parse(txtProductCode.Text);
                FrmGiris.invoices.ProductCount = int.Parse(txtProductCount.Text);
                FrmGiris.invoices.ProductTopAmount = double.Parse(lblProductTotalAmount.Text);
                FrmGiris.invoices.ProductExchange = cmbInvoiceExchange.Text;
                FrmGiris.invoices.ProductTotalAmountNoVat = double.Parse(lblProductExculindingVat.Text);
                FrmGiris.invoices.ProductVadeRate = int.Parse(txtProductVat.Text);
                FrmGiris.invoices.ProductVatAmount = double.Parse(lblProductTotalVatAmount.Text);
                FrmGiris.invoices.ProductDiscountRate = int.Parse(txtProductDiscountRate.Text);
                FrmGiris.invoices.ProductDiscountAmount = double.Parse(lblProductTotalDiscountAmount.Text);
                FrmGiris.invoices.ProductTLAmount = double.Parse(lblProductTLAmount.Text);
                FrmGiris.invoices.StoreID = int.Parse(lblStoreID.Text);
                FrmGiris.invoices.ExchangeRate = double.Parse(txtProductExchangeRate.Text);



                FrmGiris.FrmFaturaOlustur.vrTotalAmount = FrmGiris.FrmFaturaOlustur.vrTotalAmount + double.Parse(lblProductTotalAmount.Text);
                FrmGiris.FrmFaturaOlustur.vrTotalAmountNoVat = FrmGiris.FrmFaturaOlustur.vrTotalAmountNoVat + double.Parse(lblProductExculindingVat.Text);
                FrmGiris.FrmFaturaOlustur.vrVatAmount = FrmGiris.FrmFaturaOlustur.vrVatAmount + double.Parse(lblProductTotalVatAmount.Text);
                FrmGiris.FrmFaturaOlustur.vrDiscountAmount = FrmGiris.FrmFaturaOlustur.vrDiscountAmount + double.Parse(lblProductTotalDiscountAmount.Text);
                FrmGiris.FrmFaturaOlustur.vrTLAmount = FrmGiris.FrmFaturaOlustur.vrTLAmount + double.Parse(lblProductTLAmount.Text);
                vrProductCount = int.Parse(txtProductCount.Text);
                vrProductCurrentCount = int.Parse(lblProductCurrentStock.Text);
                vrLastCount = vrProductCurrentCount - vrProductCount;
                if (vrLastCount < 0)
                {
                    MessageBox.Show("Kalan Bakiye Eksi Bakiyeye Düşecek İşleme Devam Edilmeyecek Güncel Olacak Son Bakiye: " + vrLastCount.ToString(), "Stok Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    //MessageBox.Show("Kodlaması Yapılacak");
                    FrmGiris.stock.m_StocksAddUpdate(int.Parse(txtProductCode.Text), int.Parse(lblStoreID.Text),vrLastCount,"UPDATE");
                    FrmGiris.invoices.m_InvoicesDetailsAdd(FrmGiris.invoices.InvoiceNo, FrmGiris.invoices.ProductCode, FrmGiris.invoices.ProductCount, FrmGiris.invoices.ProductTopAmount, FrmGiris.invoices.ProductExchange, FrmGiris.invoices.ProductTotalAmountNoVat, FrmGiris.invoices.ProductVadeRate, FrmGiris.invoices.ProductVatAmount, FrmGiris.invoices.ProductDiscountRate, FrmGiris.invoices.ProductDiscountAmount, FrmGiris.invoices.ProductTLAmount, FrmGiris.invoices.StoreID,FrmGiris.invoices.ExchangeRate);
                    MessageBox.Show("Ürün Faturaya Eklendi.", "Fatura Ürün Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmGiris.FrmFaturaOlustur.txtTotalAmount.Text = FrmGiris.FrmFaturaOlustur.vrTotalAmount.ToString();
                    FrmGiris.FrmFaturaOlustur.txtTotalAmountNoVat.Text = FrmGiris.FrmFaturaOlustur.vrTotalAmountNoVat.ToString();
                    FrmGiris.FrmFaturaOlustur.txtVatAmout.Text = FrmGiris.FrmFaturaOlustur.vrVatAmount.ToString();
                    FrmGiris.FrmFaturaOlustur.txtDiscountAmount.Text = FrmGiris.FrmFaturaOlustur.vrDiscountAmount.ToString();
                    FrmGiris.FrmFaturaOlustur.txtTLAmount.Text = FrmGiris.FrmFaturaOlustur.vrTLAmount.ToString();
                    cmbStores.Text = "";
                    lblStoreID.Text = "0";
                    txtProductCode.Text = "";
                    txtProductName.Text = "";
                    txtProductCount.Text = "";
                    cmbInvoiceExchange.Text = "";
                    txtProductAmount.Text = "0";
                    txtProductExchangeRate.Text = "1,000";
                    txtProductVat.Text = "0";
                    txtProductDiscountRate.Text = "0";
                    lblProductTotalAmount.Text = "0";
                    lblProductTotalVatAmount.Text = "0";
                    lblProductTotalDiscountAmount.Text = "0";
                    lblProductTLAmount.Text = "0";
                    lblProductExculindingVat.Text = "0";
                    FrmGiris.invoices.m_InvoicesDetailsList(FrmGiris.FrmFaturaOlustur.dtInvoicesDetails, int.Parse(FrmGiris.FrmFaturaOlustur.txtInvoiceNo.Text));
                    FrmGiris.FrmFaturaOlustur.Show();
                    this.Hide();





                }
            }
        }

        private void txtProductAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbInvoiceExchange.Text == "")
                {
                    MessageBox.Show("Hesaplama İçin Döviz Cinsi Seçiniz", "Hesaplama", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (cmbInvoiceExchange.Text !="TL")
                    {
                        lblProductTLAmount.Text = "0";
                        vrProductTotalAmount = double.Parse(txtProductAmount.Text);
                        lblProductTotalAmount.Text = vrProductTotalAmount.ToString();
                        lblProductExculindingVat.Text = vrProductTotalAmount.ToString();
                       
                    }
                    else
                    {
                        vrProductTotalAmount = double.Parse(txtProductAmount.Text);
                        lblProductTotalAmount.Text = vrProductTotalAmount.ToString();
                        lblProductTLAmount.Text = vrProductTotalAmount.ToString();
                        lblProductExculindingVat.Text = vrProductTotalAmount.ToString();
                    }
                }
            }
        }
        private void txtProductVat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbInvoiceExchange.Text !="TL")
                {
                    vrProductTotalVatAmount = double.Parse(txtProductVat.Text);
                    vrProductTotalAmount = double.Parse(txtProductAmount.Text);
                    vrProductTotalVatAmount = vrProductTotalAmount * (vrProductTotalVatAmount / 100);
                    vrProductTotalAmount = vrProductTotalAmount + vrProductTotalVatAmount;
                    lblProductTotalAmount.Text = vrProductTotalAmount.ToString();
                    lblProductTotalVatAmount.Text = vrProductTotalVatAmount.ToString();
                }
                else
                {
                    vrProductTotalVatAmount = double.Parse(txtProductVat.Text);
                    vrProductTotalAmount = double.Parse(txtProductAmount.Text);
                    vrProductTotalVatAmount = vrProductTotalAmount * (vrProductTotalVatAmount / 100);
                    vrProductTotalAmount = vrProductTotalAmount + vrProductTotalVatAmount;
                    lblProductTotalAmount.Text = vrProductTotalAmount.ToString();
                    lblProductTotalVatAmount.Text = vrProductTotalVatAmount.ToString();
                    lblProductTLAmount.Text = lblProductTotalAmount.Text;
                }
            }
        }

        private void txtProductDiscountRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbInvoiceExchange.Text !="TL")
                {
                    vrProductTotalAmount = double.Parse(lblProductTotalAmount.Text);
                    vrProductTotalDiscountAmount = double.Parse(txtProductDiscountRate.Text);
                    vrProductTotalDiscountAmount = vrProductTotalAmount - (vrProductTotalAmount * (vrProductTotalDiscountAmount / 100));
                    lblProductTotalAmount.Text = vrProductTotalDiscountAmount.ToString();
                    vrProductTotalDiscountAmount = vrProductTotalAmount - vrProductTotalDiscountAmount;
                    lblProductTotalDiscountAmount.Text = vrProductTotalDiscountAmount.ToString();
                }
                else
                {
                    vrProductTotalAmount = double.Parse(lblProductTotalAmount.Text);
                    vrProductTotalDiscountAmount = double.Parse(txtProductDiscountRate.Text);
                    vrProductTotalDiscountAmount = vrProductTotalAmount - (vrProductTotalAmount * (vrProductTotalDiscountAmount / 100));
                    lblProductTotalAmount.Text = vrProductTotalDiscountAmount.ToString();
                    vrProductTotalDiscountAmount = vrProductTotalAmount - vrProductTotalDiscountAmount;
                    lblProductTotalDiscountAmount.Text = vrProductTotalDiscountAmount.ToString();
                    lblProductTLAmount.Text = lblProductTotalAmount.Text;
                }
            }
        }

        private void txtProductExchangeRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProductExchangeRate.Text == "")
                {
                    MessageBox.Show("Hesaplama İçin Kur Girişi Gerçekleştiriniz.", "Hesaplama", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (cmbInvoiceExchange.Text != "TL")
                    {
                        vrProductTotalAmount = double.Parse(lblProductTotalAmount.Text);
                        vrExchangeRate = double.Parse(txtProductExchangeRate.Text);
                        vrProductTotalAmountTL = vrProductTotalAmount * vrExchangeRate;
                        lblProductTLAmount.Text = vrProductTotalAmountTL.ToString();

                    }
                    else
                    {
                        vrProductTotalAmount = double.Parse(lblProductTotalAmount.Text);
                        lblProductTLAmount.Text = vrProductTotalAmount.ToString();
                    }
                }
            }
        }

        private void cmbStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmGiris.stock.m_StoresID(cmbStores.Text, lblStoreID);
        }
    }
}
