using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingERP.Classes
{
   public class Products:Interfaces.IProducts
    {
        public L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }

        public void m_ProductsList(DataGridView vrdgrProductList)
        {

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var ProductList_Query = StockTrackingDataContext.Products;
            vrdgrProductList.DataSource = ProductList_Query;
            vrdgrProductList.Columns[0].HeaderText = "Ürün Kodu";
            vrdgrProductList.Columns[1].HeaderText = "Ürün Adı";
            vrdgrProductList.Columns[2].HeaderText = "Ürün Tipi";
        }

        public void m_ProductAdd(string vrProductName, string vrProductType)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            StockTrackingDataContext.p_ProductAdd(vrProductName, vrProductType);
        }

        public void m_ProductUpdate(int vrProductCode, string vrProductName, string vrProductType)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            StockTrackingDataContext.p_ProductUpdate(vrProductCode,vrProductName, vrProductType);
        }

        public void m_ProductDelete(int vrProductCode,string vrProductName)
        {
            DialogResult vrResult;
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            vrResult = MessageBox.Show(vrProductName + " ürününü silmek istiyor musunuz ?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrResult == DialogResult.Yes)
            {
                var Product_CountControl = from albProductCount in StockTrackingDataContext.p_ProductStockCountControl(vrProductCode) select albProductCount.Column1;
                foreach (var productCount in Product_CountControl)
                {
                    //MessageBox.Show(productCount.ToString());
                    if (productCount.ToString() == "")
                    {
                        StockTrackingDataContext.p_ProductDel(vrProductCode);
                        MessageBox.Show("Ürün Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ürünün Depolarda Stoğu Vardır Silemezsiniz", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ürün Silme İşlemi İptal Edilmiştir", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        public void m_ProductSearch(DataGridView vrdgrProductList, string vrProductCode, string vrProductName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var ProductSearch_Query = StockTrackingDataContext.p_ProductSearch(vrProductCode,vrProductName);
            vrdgrProductList.DataSource = ProductSearch_Query;
            vrdgrProductList.Columns[0].HeaderText = "Ürün Kodu";
            vrdgrProductList.Columns[1].HeaderText = "Ürün Adı";
            vrdgrProductList.Columns[2].HeaderText = "Ürün Tipi"; ;
        }
        public void m_ProductTypes(ComboBox vrCmbProductTypes)
        {
            vrCmbProductTypes.Items.Clear();
            var ProductType_List = from albProductTypes in StockTrackingDataContext.ProductTypes where albProductTypes.ProductType1 == albProductTypes.ProductType1 select albProductTypes.ProductType1;
            foreach (string productTypes in ProductType_List)
            {
                vrCmbProductTypes.Items.Add(productTypes);
            }
        }
    }
}
