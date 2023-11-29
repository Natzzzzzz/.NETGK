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
    internal class ManageScheduleBLL
    {
        ManageScheduleDAL manageScheduleDAL = new ManageScheduleDAL();

        public DataTable getAvailableCarBLL()
        {
            return manageScheduleDAL.getAvailableCarDAL();
        }

        public DataTable getRentalCarBLL()
        {
            return manageScheduleDAL.getRentalCarDAL();
        }

        public DataTable getCarInfoBLL(String id)
        {
            return manageScheduleDAL.getCarInfoDAL(id);
        }
        public DataTable getCustomerInfoBLL(String id)
        {
            return manageScheduleDAL.getCustomerInfoDAL(id);
        }
        public DataTable getHistoryInfoBLL(String id)
        {
            return manageScheduleDAL.getHistoryInfoDAL(id);
        }

        public void updateStatusBLL(String id)
        {
            manageScheduleDAL.updateStatusDAL(id);
        }

        public DataTable searchCustomersBLL(String id)
        {
            return manageScheduleDAL.searchCustomersDAL(id);
        }

    }
}
