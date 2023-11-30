using Midterm.BLL;
using Midterm.DAL;
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
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();

        }
        AccountBLL accountBLL = new AccountBLL();

        private void RefreshDataGridView()
        {
            DataTable dataTable = accountBLL.getAllAccountBLL();
            dgvAccount.DataSource = dataTable;
            dgvAccount.Columns[3].Width = dgvAccount.Width - dgvAccount.Columns[0].Width - dgvAccount.Columns[1].Width - dgvAccount.Columns[2].Width;

        }
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvAccount.SelectedCells[0].RowIndex;
            String accountID = dgvAccount.Rows[rowIndex].Cells[0].Value.ToString();
            Form form = new UpdateAccount(accountID);
            form.FormClosed += (s, args) => RefreshDataGridView();
            form.ShowDialog();

        }

        private void AccountManage_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnAddAccount_Click_1(object sender, EventArgs e)
        {
            Form form = new AddAccount();
            form.FormClosed += (s, args) => RefreshDataGridView();
            form.ShowDialog();
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = accountBLL.searchAccountsBLL(tbSearch.Text);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvAccount.SelectedCells[0].RowIndex;
            String accountID = dgvAccount.Rows[rowIndex].Cells[0].Value.ToString();
            accountBLL.deleteAccountsBLL(accountID);
            RefreshDataGridView();

        }
    }
}
