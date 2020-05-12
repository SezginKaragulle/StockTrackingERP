using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingERP.Classes
{
   public class Customers:Interfaces.ICustomers
    {
        public L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }
        public int CustomerID { get; set; }
        public string Title { get; set; }
        public string TaxAdministration { get; set; }
        public int TaxNumber { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public void m_CustomersList(DataGridView vrdgrCustomerList)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var d_Query = StockTrackingDataContext.Customers;
            vrdgrCustomerList.DataSource = d_Query;
            vrdgrCustomerList.Columns[0].HeaderText = "Müşteri Kodu";
            vrdgrCustomerList.Columns[1].HeaderText = "Müşteri Adı";
            vrdgrCustomerList.Columns[2].HeaderText = "Vergi Dairesi";
            vrdgrCustomerList.Columns[3].HeaderText = "Vergi No";
            vrdgrCustomerList.Columns[4].HeaderText = "Ülke";
            vrdgrCustomerList.Columns[5].HeaderText = "İl";
            vrdgrCustomerList.Columns[6].HeaderText = "İlçe";
            vrdgrCustomerList.Columns[7].HeaderText = "Adres";
            vrdgrCustomerList.Columns[8].HeaderText = "Telefon";
            vrdgrCustomerList.Columns[9].HeaderText = "Email";
        }

        public void m_CustomerAdd(string vrTitle,string vrTaxAdministration, int vrTaxNumber, string vrCountry, string vrProvince, string vrDistrict, string vrAdress, string vrTelephone, string vrEmail)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            Customer Cus = new Customer();
            Cus.Title = vrTitle;
            Cus.TaxAdministration = vrTaxAdministration;
            Cus.TaxNumber = vrTaxNumber;
            Cus.Country = vrCountry;
            Cus.Province = vrProvince;
            Cus.District = vrDistrict;
            Cus.Adress = vrAdress;
            Cus.Telephone = vrTelephone;
            Cus.Email = vrEmail;
            StockTrackingDataContext.Customers.InsertOnSubmit(Cus);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_CustomerUpdate(int vrCustomerID, string vrTitle, string vrTaxAdministration, int vrTaxNumber, string vrCountry, string vrProvince, string vrDistrict, string vrAdress, string vrTelephone, string vrEmail)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var myquery = StockTrackingDataContext.Customers.Single(d_myquery => d_myquery.CustomerID == vrCustomerID);
            myquery.Title = vrTitle;
            myquery.TaxAdministration = vrTaxAdministration;
            myquery.TaxNumber = vrTaxNumber;
            myquery.Country = vrCountry;
            myquery.Province = vrProvince;
            myquery.District = vrDistrict;
            myquery.Adress = vrAdress;
            myquery.Telephone = vrTelephone;
            myquery.Email = vrEmail;
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_CustomerDelete(int vrCustomerID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var myquery = StockTrackingDataContext.Customers.Single(d_myquery => d_myquery.CustomerID == vrCustomerID);
            StockTrackingDataContext.Customers.DeleteOnSubmit(myquery);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_Countries(ComboBox vrCmbCountries)
        {
            vrCmbCountries.Items.Clear();
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var Countries_List = from albCountries in StockTrackingDataContext.Countries where albCountries.CountryName == albCountries.CountryName  select albCountries.CountryName;
            foreach (string countries in Countries_List)
            {
                vrCmbCountries.Items.Add(countries);
            }
        }

        public void m_CountriesID(string vrCountryName,Label vrlblID)
        {

            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var CountriesID_List = from albCountriesID in StockTrackingDataContext.Countries where albCountriesID.CountryName == vrCountryName select albCountriesID.CountryID;
            foreach (int countriesID in CountriesID_List)
            {
                vrlblID.Text = countriesID.ToString();
            }   
        }

        public void m_Provinces(ComboBox vrCmbProvinces, int vrCountryID)
        {
            vrCmbProvinces.Items.Clear();
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var Provinces_List = from albProvinces in StockTrackingDataContext.Provinces where albProvinces.CountryID == vrCountryID select albProvinces.ProvinceName;
            foreach (string provinces in Provinces_List)
            {
                vrCmbProvinces.Items.Add(provinces);
            }
        }

        public void m_ProvincesID(string vrProvinceName, Label vrlblProvinceID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var ProvincesID_List = from albProvincesID in StockTrackingDataContext.Provinces where albProvincesID.ProvinceName == vrProvinceName select albProvincesID.ProvinceID;
            foreach (int provincesID in ProvincesID_List)
            {
                vrlblProvinceID.Text = provincesID.ToString();
            }
        }

        public void m_Districts(ComboBox vrCmbDistricts,int vrProvinceID)
        {
            vrCmbDistricts.Items.Clear();
            var Districts_List = from albDistricts in StockTrackingDataContext.Districts where albDistricts.ProvinceID == vrProvinceID select albDistricts.DistrictName;
            foreach (string Districts in Districts_List)
            {
                vrCmbDistricts.Items.Add(Districts);
            }
        }

        public void m_CustomerSearch(DataGridView vrdgrCustomerList, string vrCustomerID, string vrCustomerTitle, string vrCustomerTaxNumber)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var Customer_Search = StockTrackingDataContext.p_CustomerSearch(vrCustomerID, vrCustomerTitle, vrCustomerTaxNumber);
            vrdgrCustomerList.DataSource = Customer_Search;
            vrdgrCustomerList.Columns[0].HeaderText = "Müşteri Kodu";
            vrdgrCustomerList.Columns[1].HeaderText = "Müşteri Adı";
            vrdgrCustomerList.Columns[2].HeaderText = "Vergi Dairesi";
            vrdgrCustomerList.Columns[3].HeaderText = "Vergi No";
            vrdgrCustomerList.Columns[4].HeaderText = "Ülke";
            vrdgrCustomerList.Columns[5].HeaderText = "İl";
            vrdgrCustomerList.Columns[6].HeaderText = "İlçe";
            vrdgrCustomerList.Columns[7].HeaderText = "Adres";
            vrdgrCustomerList.Columns[8].HeaderText = "Telefon";
            vrdgrCustomerList.Columns[9].HeaderText = "Email";

        }

        public void m_CustomerSearch2(DataGridView vrdgrCustomerList, string vrCustomerID, string vrCustomerName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var CustomerSearch2_Query = StockTrackingDataContext.p_CustomerSearch2(vrCustomerID, vrCustomerName);
            vrdgrCustomerList.DataSource = CustomerSearch2_Query;
            vrdgrCustomerList.Columns[0].HeaderText = "Müşteri Kodu";
            vrdgrCustomerList.Columns[1].HeaderText = "Müşteri Adı";
            vrdgrCustomerList.Columns[2].HeaderText = "Vergi Dairesi";
            vrdgrCustomerList.Columns[3].HeaderText = "Vergi No";
            vrdgrCustomerList.Columns[4].HeaderText = "Ülke";
            vrdgrCustomerList.Columns[5].HeaderText = "İl";
            vrdgrCustomerList.Columns[6].HeaderText = "İlçe";
            vrdgrCustomerList.Columns[7].HeaderText = "Adres";
            vrdgrCustomerList.Columns[8].HeaderText = "Telefon";
            vrdgrCustomerList.Columns[9].HeaderText = "Email";
        }
    }
}
