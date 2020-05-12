using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingERP.Classes
{
   public  class System:Interfaces.ISystem
    {
        public L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }
        public  int UserID { get; set; }
        public  string UserCode { get; set; }

        public  string UserPassword { get; set; }

        public  string NameSurName { get; set; }

        public  string EMail { get; set; }

        public  string Telephone { get; set; }

        public  void m_Login(string vrUserCode, string vrUserPassword,Form OldForm,Form NewForm)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var login_query = from tblUser in StockTrackingDataContext.p_Users(vrUserCode, vrUserPassword) select tblUser.Column1;
            foreach (var item in login_query)
            {
                if (item.ToString() == "")
                {
                    MessageBox.Show("Kullanıcı veya Şifre Bilgisi Hatalıdır.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı Girişi Gerçekleştirilmiştir");
                    NewForm.Show();
                    OldForm.Hide();
                    
                }
            }
        }

        public void m_UserList(DataGridView vrdgrUserList)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var UserList_Query = StockTrackingDataContext.p_UsersList();
            vrdgrUserList.DataSource = UserList_Query;
            vrdgrUserList.Columns[0].HeaderText = "Kullanıcı ID";
            vrdgrUserList.Columns[1].HeaderText = "Kullanıcı Kodu";
            vrdgrUserList.Columns[2].HeaderText = "Adı ve Soyadı";
            vrdgrUserList.Columns[3].HeaderText = "E-Mail";
            vrdgrUserList.Columns[4].HeaderText = "Telefon";
        }

        public void m_UserAdd(string vrUserCode, string vrUserPassword, string vrNameSurName, string vrEMail, string vrTelephone)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            User user = new User();
            user.UserCode = vrUserCode;
            user.UserPassword = vrUserPassword;
            user.NameSurName = vrNameSurName;
            user.EMail = vrEMail;
            user.Telephone = vrTelephone;
            StockTrackingDataContext.Users.InsertOnSubmit(user);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_UserUpdate(int vrUserID, string vrUserCode, string vrUserPassword, string vrNameSurName, string vrEMail, string vrTelephone)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var User_Update = StockTrackingDataContext.Users.Single(usr_update => usr_update.UserID == vrUserID);
            if (vrUserPassword == "")
            {
                User_Update.UserCode = vrUserCode;
                User_Update.NameSurName = vrNameSurName;
                User_Update.EMail = vrEMail;
                User_Update.Telephone = vrTelephone;
                StockTrackingDataContext.SubmitChanges();
            }
            else
            {
                User_Update.UserCode = vrUserCode;
                User_Update.UserPassword = vrUserPassword;
                User_Update.NameSurName = vrNameSurName;
                User_Update.EMail = vrEMail;
                User_Update.Telephone = vrTelephone;
                StockTrackingDataContext.SubmitChanges();
            }
        }

        public void m_UserDelete(int vrUserID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var User_Delete = StockTrackingDataContext.Users.Single(usr_delete => usr_delete.UserID == vrUserID);
            StockTrackingDataContext.Users.DeleteOnSubmit(User_Delete);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_UserSearch(DataGridView vrdgrUserList, string vrUserCode, string vrNameSurName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var UserList_Query = StockTrackingDataContext.p_UserSearch(vrUserCode, vrNameSurName);
            vrdgrUserList.DataSource = UserList_Query;
            vrdgrUserList.Columns[0].HeaderText = "Kullanıcı ID";
            vrdgrUserList.Columns[1].HeaderText = "Kullanıcı Kodu";
            vrdgrUserList.Columns[2].HeaderText = "Adı ve Soyadı";
            vrdgrUserList.Columns[3].HeaderText = "E-Mail";
            vrdgrUserList.Columns[4].HeaderText = "Telefon";
        }

        public void m_CountryList(DataGridView vrdgrCountriesList)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var CountryList_Query = StockTrackingDataContext.Countries;
            vrdgrCountriesList.DataSource = CountryList_Query;
            vrdgrCountriesList.Columns[0].HeaderText = "Ülke ID";
            vrdgrCountriesList.Columns[1].HeaderText = "Ülke Adı";

        }

        public void m_CountryAdd(string vrCountryName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            Country country = new Country();
            country.CountryName = vrCountryName;
            StockTrackingDataContext.Countries.InsertOnSubmit(country);
            StockTrackingDataContext.SubmitChanges();
            
        }

        public void m_CountryUpdate(int vrCountryID, string vrCountryName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var Country_Update = StockTrackingDataContext.Countries.Single(coun_update => coun_update.CountryID == vrCountryID);
            Country_Update.CountryName = vrCountryName;
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_CountryDel(int vrCountryID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var Country_Delete = StockTrackingDataContext.Countries.Single(coun_delete => coun_delete.CountryID == vrCountryID);
            StockTrackingDataContext.Countries.DeleteOnSubmit(Country_Delete);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_ProvinceList(DataGridView vrdgrProvincesList)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var ProvinceList_Query = StockTrackingDataContext.v_Provinces;
            vrdgrProvincesList.DataSource = ProvinceList_Query;
            vrdgrProvincesList.Columns[0].HeaderText = "İl ID";
            vrdgrProvincesList.Columns[1].HeaderText = "İl Kodu";
            vrdgrProvincesList.Columns[2].HeaderText = "İl Adı";
            vrdgrProvincesList.Columns[3].HeaderText = "Ülke Kodu";
            vrdgrProvincesList.Columns[4].HeaderText = "Ülke Adı";

        }

        public void m_ProvinceAdd(string vrProvinceCode, string vrProvinceName, int vrCountryID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            Province province = new Province();
            province.ProvinceCode = vrProvinceCode;
            province.ProvinceName = vrProvinceName;
            province.CountryID = vrCountryID;
            StockTrackingDataContext.Provinces.InsertOnSubmit(province);
            StockTrackingDataContext.SubmitChanges();

        }

        public void m_ProvinceUpdate(int vrProvinceID, string vrProvinceCode, string vrProvinceName, int vrCountryID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var Province_Update = StockTrackingDataContext.Provinces.Single(prov_update => prov_update.ProvinceID == vrProvinceID);
            Province_Update.ProvinceCode = vrProvinceCode;
            Province_Update.ProvinceName = vrProvinceName;
            Province_Update.CountryID = vrCountryID;
            StockTrackingDataContext.SubmitChanges();

        }

        public void m_ProvinceDel(int vrProvinceID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var Province_Delete = StockTrackingDataContext.Provinces.Single(prov_delete => prov_delete.ProvinceID == vrProvinceID);
            StockTrackingDataContext.Provinces.DeleteOnSubmit(Province_Delete);
            StockTrackingDataContext.SubmitChanges();

        }

        public void m_DistrictList(DataGridView vrdgrDistrictsList)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var DistrictList_Query = StockTrackingDataContext.v_Districts;
            vrdgrDistrictsList.DataSource = DistrictList_Query;
            vrdgrDistrictsList.Columns[0].HeaderText = "İlçe ID";
            vrdgrDistrictsList.Columns[1].HeaderText = "İlçe Adı";
            vrdgrDistrictsList.Columns[2].HeaderText = "İl  Kodu";
            vrdgrDistrictsList.Columns[3].HeaderText = "İl Adı";
            vrdgrDistrictsList.Columns[4].HeaderText = "Ülke Kodu";
            vrdgrDistrictsList.Columns[5].HeaderText = "Ülke Adı";

        }

        public void m_DistrictAdd(string vrDistrictName, int vrProvinceID, int vrCountryID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            District district = new District();
            district.DistrictName = vrDistrictName;
            district.ProvinceID = vrProvinceID;
            district.CountryID = vrCountryID;
            StockTrackingDataContext.Districts.InsertOnSubmit(district);
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_DistrictUpdate(int vrDistrictID, string vrDistrictName, int vrProvinceID, int vrCountryID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var District_Update = StockTrackingDataContext.Districts.Single(dist_update => dist_update.DistrictID == vrDistrictID);
            District_Update.DistrictName = vrDistrictName;
            District_Update.ProvinceID = vrProvinceID;
            District_Update.CountryID = vrCountryID;
            StockTrackingDataContext.SubmitChanges();

        }

        public void m_DistrictDel(int vrDistrictID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var District_Delete = StockTrackingDataContext.Districts.Single(dist_update => dist_update.DistrictID == vrDistrictID);
            StockTrackingDataContext.Districts.DeleteOnSubmit(District_Delete);
            StockTrackingDataContext.SubmitChanges();

        }

        public void m_GeneralCodeİnformations(DataGridView vrdgrGeneralCodeİnfomationsList, string vrSearchName, string vrGeneralCodeID, string vrGeneralCodeName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            if (vrSearchName == "İlçeler")
            {
                var GeneralCodeİnformations_Query2 = StockTrackingDataContext.p_GeneralCodeInformationSearch2(vrGeneralCodeID, vrGeneralCodeName);
                vrdgrGeneralCodeİnfomationsList.DataSource = GeneralCodeİnformations_Query2;
                vrdgrGeneralCodeİnfomationsList.Columns[0].HeaderText = "İlçe ID";
                vrdgrGeneralCodeİnfomationsList.Columns[1].HeaderText = "İlçe Adı";
                vrdgrGeneralCodeİnfomationsList.Columns[2].HeaderText = "İl  Kodu";
                vrdgrGeneralCodeİnfomationsList.Columns[3].HeaderText = "İl Adı";
                vrdgrGeneralCodeİnfomationsList.Columns[4].HeaderText = "Ülke Kodu";
                vrdgrGeneralCodeİnfomationsList.Columns[5].HeaderText = "Ülke Adı";
            }
            else if (vrSearchName == "Ürün Tipi")
            {
                var GeneralCodeİnformations_Query3 = StockTrackingDataContext.p_GeneralCodeInformationSearch3(vrGeneralCodeID, vrGeneralCodeName);
                vrdgrGeneralCodeİnfomationsList.DataSource = GeneralCodeİnformations_Query3;
                vrdgrGeneralCodeİnfomationsList.Columns[0].HeaderText = "Ürün Tip ID";
                vrdgrGeneralCodeİnfomationsList.Columns[1].HeaderText = "Ürün Tip Adı";
            }
            else
            {
                var GeneralCodeİnformations_Query = StockTrackingDataContext.p_GeneralCodeInformationSearch(vrSearchName, vrGeneralCodeID, vrGeneralCodeName);
                vrdgrGeneralCodeİnfomationsList.DataSource = GeneralCodeİnformations_Query;
                if (vrSearchName == "Ülkeler")
                {
                    vrdgrGeneralCodeİnfomationsList.Columns[0].HeaderText = "Ülke ID";
                    vrdgrGeneralCodeİnfomationsList.Columns[1].HeaderText = "Ülke Adı";
                }
                else if (vrSearchName == "İller")
                {
                    vrdgrGeneralCodeİnfomationsList.Columns[0].HeaderText = "İl ID";
                    vrdgrGeneralCodeİnfomationsList.Columns[1].HeaderText = "İl Kodu";
                    vrdgrGeneralCodeİnfomationsList.Columns[2].HeaderText = "İl Adı";
                    vrdgrGeneralCodeİnfomationsList.Columns[3].HeaderText = "Ülke Kodu";
                    vrdgrGeneralCodeİnfomationsList.Columns[4].HeaderText = "Ülke Adı";
                }
            }



        }

        public void m_ProductTypesList(DataGridView vrdgrProductTypesList)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var ProductTypesList_Query = StockTrackingDataContext.ProductTypes;
            vrdgrProductTypesList.DataSource = ProductTypesList_Query;
            vrdgrProductTypesList.Columns[0].HeaderText = "Ürün Tip ID";
            vrdgrProductTypesList.Columns[1].HeaderText = "Ürün Tip Adı";
            
        }

        public void m_ProductTypeAdd(string vrProductTypeName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            ProductType productType = new ProductType();
            productType.ProductType1 = vrProductTypeName;
            StockTrackingDataContext.ProductTypes.InsertOnSubmit(productType);
            StockTrackingDataContext.SubmitChanges();

        }

        public void m_ProductTypeUpdate(int vrProductTypeID, string vrProductTypeName)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var ProductType_Update = StockTrackingDataContext.ProductTypes.Single(protyp_update => protyp_update.ProductTypeID == vrProductTypeID);
            ProductType_Update.ProductType1 = vrProductTypeName;
            StockTrackingDataContext.SubmitChanges();
        }

        public void m_ProductTypeDel(int vrProductTypeID)
        {
            StockTrackingDataContext = new L_StockTrackingERPDataContext();
            var ProductType_Delete = StockTrackingDataContext.ProductTypes.Single(protyp_delete => protyp_delete.ProductTypeID == vrProductTypeID);
            StockTrackingDataContext.ProductTypes.DeleteOnSubmit(ProductType_Delete);
            StockTrackingDataContext.SubmitChanges();
        }
    }
}
