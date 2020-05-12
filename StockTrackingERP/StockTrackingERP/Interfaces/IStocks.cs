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
    interface IStocks
    {

        L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }
        int ProductCode { get; set; }
        int StoreID { get; set; }
        int ProductCount { get; set; }
        void m_StocksList(DataGridView vrdgrStocksList, string vrStoreName);

        void m_StoresList(ComboBox vrcmbStores);

        void m_StoresID(string vrStoreName, Label lblStoreID);

        void m_StockActionCount(Label lbl_StockActionCount);

        string m_ProductCodeSearch(int vrProductCode, TextBox vrProductName);

        void m_StockActionDetailsList(DataGridView vrdgrStockActionDetailsList, int vrStockActionNo);

        void m_StockActionDetailsAdd(int vrStockActionNo, int vrProductCode, int vrProductCount);

        void m_StockActionDetailsUpdate(int vrProductCode, int vrProductCount);

        void m_StockActionDetailsDelete(int vrStockActionNo, int vrProductCode);
        void m_StockActionDetailsDelete(int vrStockActionNo);

        void m_StocksAddUpdate(int vrProductCode, int vrStoreID, int vrProductCount, string vrProductChangeStatus);

        void m_StockActionCounterUpdate(int vrActionCounter);

        void m_StocksListSearch(DataGridView vrdgrStocksList, string vrStockID, string vrProductCode, string vrProductName);

    }
}
