using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingERP.Classes
{
   public class Stores:Interfaces.IStores
    {
        public L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }
        public int StoreID { get; set; }
        public string StoreCode { get; set; }
        public string StoreName { get; set; }

        public void m_StoresList(DataGridView vrdgrStoresList)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StoresList_Query = StockTrackingDataContext.Stores;
            vrdgrStoresList.DataSource = StoresList_Query;
            vrdgrStoresList.Columns[0].HeaderText = "Depo No";
            vrdgrStoresList.Columns[1].HeaderText = "Depo Kodu";
            vrdgrStoresList.Columns[2].HeaderText = "Depo Adı";

        }

        public void m_StoreAdd(string vrStoreCode, string VrStoreName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            StockTrackingDataContext.p_StoreAdd(vrStoreCode, VrStoreName);
        }

        public void m_StoreUpdate(int vrStoreID, string vrStoreCode, string VrStoreName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            StockTrackingDataContext.p_StoreUpdate(vrStoreID, vrStoreCode, VrStoreName);
        }

        public void m_StoreDelete(int vrStoreID,string vrStoreName)
        {
            DialogResult vrResult;
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            vrResult = MessageBox.Show(vrStoreName + " deposunu silmek istiyor musunuz ?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrResult == DialogResult.Yes)
            {
                var Store_CountControl = from albStoreCount in StockTrackingDataContext.p_StoreStockCountControl(vrStoreID) select albStoreCount.Column1;
                foreach (var storeCount in Store_CountControl)
                {
                    //MessageBox.Show(productCount.ToString());
                    if (storeCount.ToString() == "")
                    {
                        StockTrackingDataContext.p_StoreDelete(vrStoreID);
                        MessageBox.Show("Depo Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("İlgili Deponun Stokları Vardır Silinemez", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Depo Silme İşlemi İptal Edilmiştir", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void m_StoreSearch(DataGridView vrdgrStoreList, string vrStoreID, string vrStoreName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var StoresSearch_Query = StockTrackingDataContext.p_StoreSearch(vrStoreID, vrStoreName);
            vrdgrStoreList.DataSource = StoresSearch_Query;
            vrdgrStoreList.Columns[0].HeaderText = "Depo No";
            vrdgrStoreList.Columns[1].HeaderText = "Depo Kodu";
            vrdgrStoreList.Columns[2].HeaderText = "Depo Adı";
        }
    }
}
