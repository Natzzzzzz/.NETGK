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
        private String userID;
        public CarOrder(String carCategory, String userID)
        {
            InitializeComponent();
            this.category = carCategory;
            this.userID = userID;
        }
        private void RefreshDataGridView()
        {
            ManageHistoryBLL manageHistoryBLL = new ManageHistoryBLL();
            DataTable dataTable = manageHistoryBLL.getHistoryByCategoryBLL(category);
            dgvCarOrder.DataSource = dataTable;
            foreach (DataGridViewColumn column in dgvCarOrder.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                column.FillWeight = 1;
            }
        }
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            Form form = new Car(category, userID);
            form.FormClosed += (s, args) => RefreshDataGridView();

            form.ShowDialog();

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
