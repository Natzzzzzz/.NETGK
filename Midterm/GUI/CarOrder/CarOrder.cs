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

namespace Midterm.GUI.CarOrder
{
    public partial class CarOrder : Form
    {
        private String category;
        public CarOrder(String carCategory)
        {
            InitializeComponent();
            this.category = carCategory;
        }
        private void RefreshDataGridView()
        {
            ManageHistoryBLL manageHistoryBLL = new ManageHistoryBLL();
            DataTable dataTable = manageHistoryBLL.getHistoryByCategoryBLL(category);
            dgvCarOrder.DataSource = dataTable;
        }
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            Form form = new Car(category);
            form.ShowDialog();
            form.FormClosed += (s, args) => RefreshDataGridView();

        }

        private void CarOrder_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageHistoryBLL manageHistoryBLL = new ManageHistoryBLL();
            dgvCarOrder.DataSource = manageHistoryBLL.searchCarsBLL(tbSearch.Text, category);
        }
    }
}
