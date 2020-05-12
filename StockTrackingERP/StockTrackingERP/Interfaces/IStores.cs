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
    interface IStores
    {
        L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }

        int StoreID { get; set; }
        string StoreCode { get; set; }
        string StoreName { get; set; }

        void m_StoresList(DataGridView vrdgrStoresList);
        void m_StoreAdd(string vrStoreCode, string VrStoreName);
        void m_StoreUpdate(int vrStoreID, string vrStoreCode, string VrStoreName);
        void m_StoreDelete(int vrStoreID,string vrStoreName);

        void m_StoreSearch(DataGridView vrdgrStoreList, string vrStoreID, string vrStoreName);

    }
}
