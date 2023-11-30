using Midterm.DAL;
using Midterm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Midterm.BLL
{
    internal class AccountBLL
    {
        AccountDAL manageAccountDAL = new AccountDAL();

        public DataTable getAllAccountBLL()
        {
            return manageAccountDAL.getAllAccountsDAL();
        }
        public void insertAccountsBLL(Accounts account)
        {
            if (account.fullName == "" || account.address == "" || account.phoneNumber == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            manageAccountDAL.insertAccountsDAL(account);
        }
        public void deleteAccountsBLL(String id)
        {
            manageAccountDAL.deleteAccountsDAL(id);
        }
        public void updateAccountsBLL(Accounts account)
        {
            if (account.fullName == "" || account.address == "" || account.phoneNumber == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            manageAccountDAL.updateAccountsDAL(account);
        }
        public DataTable getAccountsByIDBLL(String id)
        {
            return manageAccountDAL.getAccountsByIDBLL(id);
        }
        public DataTable searchAccountsBLL(String key)
        {
            return manageAccountDAL.searchAccountsDAL(key);
        }
    }
}
