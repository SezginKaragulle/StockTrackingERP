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
    interface ICustomers
    {

        L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }
        int CustomerID { get; set; }
        string Title { get; set; }
        string TaxAdministration { get; set; }
        int TaxNumber { get; set; }
        string Country { get; set; }
        string Province { get; set; }
        string District { get; set; }
        string Adress { get; set; }
        string Telephone { get; set; }
        string Email { get; set; }

        void m_CustomersList(DataGridView vrdgrCustomerList);
        void m_CustomerAdd(string vrTitle, string vrTaxAdministration, int vrTaxNumber, string vrCountry, string vrProvince, string vrDistrict, string vrAdress, string vrTelephone, string vrEmail);
        void m_CustomerUpdate(int vrCustomerID, string vrTitle, string vrTaxAdministration, int vrTaxNumber, string vrCountry, string vrProvince, string vrDistrict, string vrAdress, string vrTelephone, string vrEmail);
        void m_CustomerDelete(int vrCustomerID);

        void m_Countries(ComboBox vrCmbCountries);

        void m_CountriesID(string vrCountryName, Label vrlblID);

        void m_Provinces(ComboBox vrCmbProvinces, int vrCountryID);

        void m_ProvincesID(string vrProvinceName, Label vrlblProvinceID);

        void m_Districts(ComboBox vrCmbDistricts, int vrProvinceID);

        void m_CustomerSearch(DataGridView vrdgrCustomerList, string vrCustomerID, string vrCustomerTitle, string vrCustomerTaxNumber);
        void m_CustomerSearch2(DataGridView vrdgrCustomerList, string vrCustomerID, string vrCustomerName);


    }
}
