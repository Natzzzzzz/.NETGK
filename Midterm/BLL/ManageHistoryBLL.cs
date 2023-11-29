using Midterm.DAL;
using Midterm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.BLL
{
    internal class ManageHistoryBLL
    {
        ManageHistoryDAL manageHistoryDAL = new ManageHistoryDAL();

        public DataTable getHistoryByCategoryBLL(String carCategory)
        {
            return manageHistoryDAL.getHistoryByCategoryDAL(carCategory);
        }

        public DataTable getAllCarBrandBLL(String carCategory)
        {
            return manageHistoryDAL.getAllCarBrandDAL(carCategory);
        }
        public DataTable getAllCarNameBLL(String carCategory)
        {
            return manageHistoryDAL.getAllCarNameDAL(carCategory);
        }
        public String getCarIDBLL(String carCategory, String carBrand, String carName)
        {
            return manageHistoryDAL.GetCarIDDAL(carCategory, carBrand, carName);
        }
        public String getCustomerIDBLL(String fullName, String phoneNumber, String address)
        {
            return manageHistoryDAL.GetCustomerIDDAL(fullName, phoneNumber, address);
        }
        public void insertHistoryBLL(History history)
        {
            manageHistoryDAL.insertHistoryDAL(history);
        }
        public DataTable searchCarsBLL(String key, String category)
        {
            return manageHistoryDAL.serachCarsDAL(key,category);
        }

        public DataTable isAvaibleCarBLL(String carID, DateTime startDate, DateTime endDate)
        {
            return manageHistoryDAL.isVailableCarDAL(carID, startDate, endDate);
        }

        public DataTable getAllProvinceBLL()
        {
            return manageHistoryDAL.getAllProvinceDAL();
        }


    }
}
