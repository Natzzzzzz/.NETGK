using Midterm.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.BLL
{
    internal class StatictisBLL
    {
        StatictisDAL statictisDAL = new StatictisDAL();
        public DataTable statictisByBrandBLL(String startDate, String endDate)
        {
            return statictisDAL.statictisByBrandDAL(startDate, endDate);
        }
        public DataTable statictisByCategoryBLL(String startDate, String endDate)
        {
            return statictisDAL.statictisByCategoryDAL(startDate,endDate);
        }
        public DataTable statictisCarByCategory()
        {
            return statictisDAL.statictisCarByCategoryDAL();
        }

        public DataTable statictisRevenueByMonthBLL()
        {
            return statictisDAL.statictisRevenueByMonthDAL();
        }

        public DataTable statictisRevenueByYearBLL()
        {
            return statictisDAL.statictisRevenueByYearDAL();
        }

        public String getFirstDateOfMonthBLL()
        {
            return statictisDAL.getFirstDayOfMonthDAL();
        }

        public String getLastDateOfMonthBLL()
        {
            return statictisDAL.getLastDayOfMonthDAL();
        }
    }
}
