using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StockTrackingERP.Classes
{
   public class Stocks:Interfaces.IStocks
    {
        public L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }
        public int ProductCode { get; set; }
        public int StoreID { get; set; }
        public int ProductCount { get; set; }
        public int StockActionNo { get; set; }

        private string vrLastQuery;

        private string VrProductSumCount;



        public void m_StocksList(DataGridView vrdgrStocksList, string vrStoreName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StockList_Query = StockTrackingDataContext.StockList(vrStoreName);
            vrdgrStocksList.DataSource = StockList_Query;
            vrdgrStocksList.Columns[0].HeaderText = "Stok No";
            vrdgrStocksList.Columns[1].HeaderText = "Ürün No";
            vrdgrStocksList.Columns[2].HeaderText = "Ürün Adı";
            vrdgrStocksList.Columns[3].HeaderText = "Ürün Sayısı";
        }

        public void m_StoresList(ComboBox vrcmbStores)
        {
            vrcmbStores.Items.Clear();
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var Stores_List = from albStores in StockTrackingDataContext.Stores where albStores.StoreName == albStores.StoreName select albStores.StoreName;
            foreach (var stores in Stores_List)
            {
                vrcmbStores.Items.Add(stores);
            }
        }

        public void m_StoresID(string vrStoreName, Label lblStoreID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StoreID = from albStoreID in StockTrackingDataContext.Stores where albStoreID.StoreName == vrStoreName select albStoreID.StoreID;
            foreach (int storeid in StoreID)
            {
                lblStoreID.Text = storeid.ToString();

            }
        }

        public void m_StockActionCount(Label lbl_StockActionCount)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StockCount_Query = from albStockCount in StockTrackingDataContext.StockActionCounters where albStockCount.StockActionCounter1 == albStockCount.StockActionCounter1 select albStockCount.ActionCounter;
            foreach (int stockcount in StockCount_Query)
            {
                lbl_StockActionCount.Text = stockcount.ToString();
            }
        }

        public string m_ProductCodeSearch(int vrProductCode, TextBox vrProductName)
        {
            vrProductName.Text = "";
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var ProductSearch_Query = from albStockCount in StockTrackingDataContext.p_ProductSearchAction(vrProductCode) select albStockCount.Column1;
            foreach (string item in ProductSearch_Query)
            {
                //MessageBox.Show(item);
                vrLastQuery = item;
            }

            return vrLastQuery;

        }

        public void m_StockActionDetailsList(DataGridView vrdgrStockActionDetailsList, int vrStockActionNo)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StockActionsDetails_Query = StockTrackingDataContext.StockActionDetailList(vrStockActionNo);
            vrdgrStockActionDetailsList.DataSource = StockActionsDetails_Query;
        }

        public void m_StockActionDetailsAdd(int vrStockActionNo, int vrProductCode, int vrProductCount)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            StockActionDetail ActionDetail = new StockActionDetail();
            ActionDetail.StockAction = vrStockActionNo;
            ActionDetail.ProductCode = vrProductCode;
            ActionDetail.ProductCount = vrProductCount;
            StockTrackingDataContext.StockActionDetails.InsertOnSubmit(ActionDetail);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_StockActionDetailsUpdate(int vrProductCode,int vrProductCount)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StockActionDetailsUpdate_Query = StockTrackingDataContext.StockActionDetails.Single(stckdetails => stckdetails.ProductCode == vrProductCode);
            StockActionDetailsUpdate_Query.ProductCount = vrProductCount;
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_StockActionDetailsDelete(int vrStockActionNo, int vrProductCode)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StockActionDetailsDelete_Query = StockTrackingDataContext.StockActionDetails.Single(stckdetails => stckdetails.StockAction == vrStockActionNo & stckdetails.ProductCode == vrProductCode);
            StockTrackingDataContext.StockActionDetails.DeleteOnSubmit(StockActionDetailsDelete_Query);
            StockTrackingDataContext.SubmitChanges();
        }

        //public void m_StockTest1(int vrStockNo)
        //{
        //    StockTrackingDataContext = new L_StockTrackingERPDataContext();
        //    var Stores_List = (from albStores in StockTrackingDataContext.StockActionDetails where albStores.StockAction == albStores.StockAction select albStores).Count();
        //    MessageBox.Show(Stores_List.ToString());
        //}
        public int m_StockCount(int vrStockNo/*,int vrStockCount*/)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            int Stores_List = (from albStores in StockTrackingDataContext.StockActionDetails where albStores.StockAction == albStores.StockAction select albStores).Count();
            return Stores_List;
        }

        public int m_StockCount(int vrProductCode,int vrStoreID)
        {
            //StockTrackingDataContext = new L_StockTrackingERPDataContext();
            //var Stores_List = from albStores in StockTrackingDataContext.Stocks where (r=>r.)
            //return Stores_List.ToString();
            return vrProductCode;
            
        }

        public string m_StockCountTest(int vrProductCode, int vrStoreID)
        {
            
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var ProductSearch_Query = from albStockCount in StockTrackingDataContext.p_ProductCountSum(vrProductCode, vrStoreID) select albStockCount.Column1;
            foreach (var item in ProductSearch_Query)
            {
                //MessageBox.Show(item);
                VrProductSumCount = item.ToString();
            }

            return VrProductSumCount;
            //StockTrackingDataContext = new L_StockTrackingERPDataContext();
            //var Stores_List = from albStores in StockTrackingDataContext.Stocks where (r=>r.)
            //return Stores_List.ToString();


        }

        public void m_StockActionDetailsDelete(int vrStockActionNo)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StockActionDetailsDelete_Query = StockTrackingDataContext.p_StockDetailsDelete(vrStockActionNo);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_StocksAddUpdate(int vrProductCode, int vrStoreID, int vrProductCount, string vrProductChangeStatus)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StockAddUpdate_Query = StockTrackingDataContext.p_StocksAddUpdate(vrProductCode, vrStoreID, vrProductCount, vrProductChangeStatus);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_StockActionCounterUpdate(int vrActionCounter)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StockActionCounterUpdate_Query = StockTrackingDataContext.StockActionCounters.Single(ActCount => ActCount.StockActionCounter1 == 1);
            StockActionCounterUpdate_Query.ActionCounter = vrActionCounter;
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_StocksListSearch(DataGridView vrdgrStocksList, string vrStockID, string vrProductCode, string vrProductName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StockList_Query = StockTrackingDataContext.StockListSearch(vrStockID, vrProductCode, vrProductName);
            vrdgrStocksList.DataSource = StockList_Query;
            vrdgrStocksList.Columns[0].HeaderText = "Stok No";
            vrdgrStocksList.Columns[1].HeaderText = "Ürün No";
            vrdgrStocksList.Columns[2].HeaderText = "Ürün Adı";
            vrdgrStocksList.Columns[3].HeaderText = "Ürün Sayısı";
        }

        //public string m_ProductCodeSearch2(int vrProductCode, TextBox vrProductName)
        //{     
        //    vrProductName.Text = "";
        //    StockTrackingDataContext = new L_StockTrackingERPDataContext();
        //    var ProductSearch_Query = from albStockCount in StockTrackingDataContext.p_ProductSearchAction(vrProductCode) select albStockCount.Column1;
        //    foreach (string item in ProductSearch_Query)
        //    {
        //        //MessageBox.Show(item);
        //        vrLastQuery = item;
        //    }
        //    return vrLastQuery;
        //}

    }
}
