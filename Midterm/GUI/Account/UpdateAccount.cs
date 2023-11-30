using Midterm.BLL;
using Midterm.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm.GUI.Account
{
    public partial class UpdateAccount : Form
    {
        private string id;
        public UpdateAccount(String accountID)
        {
            InitializeComponent();
            AccountBLL account = new AccountBLL();
            this.id = accountID;
            foreach (DataRow row in account.getAccountsByIDBLL(accountID).Rows)
            {
                tbFullName.Text = row["fullName"].ToString();
                tbPhoneNumber.Text = row["phoneNumber"].ToString();
                tbAddress.Text = row["address"].ToString();
            }
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Accounts account = new Accounts();
            account.accountID = this.id;
            account.fullName = tbFullName.Text;
            account.phoneNumber = tbPhoneNumber.Text;
            account.address = tbAddress.Text;
            AccountBLL manageAccountsBLL = new AccountBLL();
            manageAccountsBLL.updateAccountsBLL(account);
            this.Close();
        }
    }
}
