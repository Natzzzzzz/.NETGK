using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midterm.DAL;
using Midterm.DTO;

namespace Midterm.BLL
{
	internal class ManageCustomersBLL
	{
        ManageCustomersDAL manageCustomerDAL = new ManageCustomersDAL();

        public DataTable getAllCustomerBLL()
        {
           return manageCustomerDAL.getAllCustomerDAL();
        }
        public void insertCustomersBLL(Customers customer)
        {
            manageCustomerDAL.insertCustomersDAL(customer);
        }
        public void deleteCustomersBLL(String id)
        {
            manageCustomerDAL.deleteCustomersDAL(id);
        }
        public void updateCustomersBLL(Customers customer)
        {
            manageCustomerDAL.updateCustomersDAL(customer);
        }
        public DataTable getCustomersByIDBLL(String id)
        {
            return manageCustomerDAL.getCustomersByIDBLL(id);
        }
        public DataTable searchCustomersBLL(String key)
        {
            ManageCustomersDAL search = new ManageCustomersDAL();
            return search.searchCustomersDAL(key);
        }
    }
}
