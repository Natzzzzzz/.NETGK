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

namespace Midterm.GUI.CustomerManage
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.fullName = tbFullName.Text;
            customer.phoneNumber = tbPhoneNumber.Text;
            customer.address = tbAddress.Text;

            ManageCustomersBLL manageCustomersBLL = new ManageCustomersBLL();
            manageCustomersBLL.insertCustomersBLL(customer);
            this.Close();
        }
    }
}
