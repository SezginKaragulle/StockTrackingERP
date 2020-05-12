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
    interface ISystem
    {

         L_StockTrackingERPDataContext StockTrackingDataContext { get; set; }
         int UserID { get; set; }
         string UserCode { get; set; }

         string UserPassword { get; set; }

         string NameSurName { get; set; }

         string EMail { get; set; }

         string Telephone { get; set; }

        void m_Login(string vrUserCode, string vrUserPassword, Form OldForm, Form NewForm);

        void m_UserList(DataGridView vrdgrUserList);

        void m_UserAdd(string vrUserCode, string vrUserPassword, string vrNameSurName, string vrEMail, string vrTelephone);

        void m_UserUpdate(int vrUserID, string vrUserCode, string vrUserPassword, string vrNameSurName, string vrEMail, string vrTelephone);

        void m_UserDelete(int vrUserID);

        void m_UserSearch(DataGridView vrdgrUserList,string vrUserCode,string vrNameSurName);

        void m_CountryList(DataGridView vrdgrCountriesList);

        void m_CountryAdd(string vrCountryName);

        void m_CountryUpdate(int vrCountryID, string vrCountryName);

        void m_CountryDel(int vrCountryID);

        void m_ProvinceList(DataGridView vrdgrProvincesList);

        void m_ProvinceAdd(string vrProvinceCode, string vrProvinceName, int vrCountryID);

        void m_ProvinceUpdate(int vrProvinceID, string vrProvinceCode, string vrProvinceName, int vrCountryID);

        void m_ProvinceDel(int vrProvinceID);

        void m_DistrictList(DataGridView vrdgrDistrictsList);

        void m_DistrictAdd(string vrDistrictName, int vrProvinceID, int vrCountryID);

        void m_DistrictUpdate(int vrDistrictID, string vrDistrictName, int vrProvinceID, int vrCountryID);

        void m_DistrictDel(int vrDistrictID);

        void m_GeneralCodeİnformations(DataGridView vrdgrGeneralCodeİnfomationsList, string vrSearchName, string vrGeneralCodeID,string vrGeneralCodeName);

        void m_ProductTypesList(DataGridView vrdgrProductTypesList);

        void m_ProductTypeAdd(string vrProductTypeName);

        void m_ProductTypeUpdate(int vrProductTypeID, string vrProductTypeName);

        void m_ProductTypeDel(int vrProductTypeID);

    }
}
