using Midterm.BLL;
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
    public partial class CustomerManage : UserControl
    {
        private ManageCustomersBLL newManageCustomersBLL = new ManageCustomersBLL();

        public CustomerManage()
        {
            InitializeComponent();
        }
        private void RefreshDataGridView()
        {
            ManageCustomersBLL manageCustomersBLL = new ManageCustomersBLL();
            DataTable dataTable = manageCustomersBLL.getAllCustomerBLL();
            dgvCustomers.DataSource = dataTable;
            dgvCustomers.Columns[3].Width = dgvCustomers.Width - dgvCustomers.Columns[0].Width - dgvCustomers.Columns[1].Width - dgvCustomers.Columns[2].Width;

        }
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvCustomers.SelectedCells[0].RowIndex;
            String accountID = dgvCustomers.Rows[rowIndex].Cells[0].Value.ToString();
            Form form = new UpdateCustomer(accountID);
            form.ShowDialog();
            form.FormClosed += (s, args) => RefreshDataGridView();

        }

        private void CustomerManage_Load(object sender, EventArgs e)
		{
            RefreshDataGridView();
        }

        private void btnAddCustomer_Click_1(object sender, EventArgs e)
        {
            Form form = new Customer();
            form.FormClosed += (s, args) => RefreshDataGridView();
            form.ShowDialog();
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = newManageCustomersBLL.searchCustomersBLL(tbSearch.Text);
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvCustomers.SelectedCells[0].RowIndex;
            String accountID = dgvCustomers.Rows[rowIndex].Cells[0].Value.ToString();
            newManageCustomersBLL.deleteCustomersBLL(accountID);
            RefreshDataGridView();

        }
    }
}
