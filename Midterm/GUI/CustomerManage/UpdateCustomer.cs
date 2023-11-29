using Midterm.BLL;
using Midterm.DTO;
using Midterm.GUI.CarOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm.GUI.CustomerManage
{
    public partial class UpdateCustomer : Form
    {
        private string id;
        public UpdateCustomer(String accountID)
        {
            InitializeComponent();
            ManageCustomersBLL customer = new ManageCustomersBLL();
            this.id = accountID;
            foreach (DataRow row in customer.getCustomersByIDBLL(accountID).Rows)
            {
                tbFullName.Text = row["fullName"].ToString();
                tbPhoneNumber.Text = row["phoneNumber"].ToString();
                tbAddress.Text = row["address"].ToString();
            }
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.fullName = tbFullName.Text;
            customer.phoneNumber = tbPhoneNumber.Text;
            customer.address = tbAddress.Text;
            ManageCustomersBLL manageCustomersBLL = new ManageCustomersBLL();
            manageCustomersBLL.updateCustomersBLL(customer);
            this.Close();
        }
    }
}
