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
    interface IProducts
    {
        L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }

        int ProductCode { get; set; }
        string ProductName { get; set; }
        string ProductType { get; set; }

        void m_ProductsList(DataGridView vrdgrProductList);
        void m_ProductAdd(string vrProductName, string vrProductType);
        void m_ProductUpdate(int vrProductCode, string vrProductName, string vrProductType);
        void m_ProductDelete(int vrProductCode, string vrProductName);

        void m_ProductSearch(DataGridView vrdgrProductList, string vrProductCode, string vrProductName);

        void m_ProductTypes(ComboBox vrCmbProductTypes);
    }
}
