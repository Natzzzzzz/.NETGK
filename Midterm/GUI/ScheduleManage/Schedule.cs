using Midterm.BLL;
using Midterm.GUI.CarManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm.GUI.ScheduleManage
{
    public partial class Schedule : UserControl
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void RefreshDataGridView()
        {
            ManageScheduleBLL scheduleBLL = new ManageScheduleBLL();
            DataTable dataTable = scheduleBLL.getAvailableCarBLL();
            dgvSchedule.DataSource = dataTable;
            for (int i = 0; i < dgvSchedule.Columns.Count; i++)
            {
                dgvSchedule.Columns[i].Width = dgvSchedule.Width / dgvSchedule.Columns.Count;
            }
        }

        private void getRentalCar()
        {
            ManageScheduleBLL scheduleBLL = new ManageScheduleBLL();
            DataTable dataTable = scheduleBLL.getRentalCarBLL();
            dgvSchedule.DataSource = dataTable;

            foreach (DataGridViewColumn column in dgvSchedule.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                column.FillWeight = 1;
            }

        }
        private void btnAvailable_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            getRentalCar();
        }

        private void ScheduleManage_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            if(dgvSchedule.ColumnCount == 6)
            {
                MessageBox.Show("Vui lòng chọn xe đã thuê để thực hiện thanh toán!!");
                return;
            }
            int rowIndex = dgvSchedule.SelectedCells[0].RowIndex;
            String historyID = dgvSchedule.Rows[rowIndex].Cells[0].Value.ToString();
            String paymentStatus = dgvSchedule.Rows[rowIndex].Cells[12].Value.ToString();
            if (paymentStatus.Equals("Chưa thanh toán"))
            {
                Form form = new BillRental(historyID);
                form.FormClosed += (s, args) => getRentalCar();
                form.ShowDialog();
            }
            if(String.Compare(paymentStatus, "Đã thanh toán", StringComparison.OrdinalIgnoreCase) == 0)
            {
                MessageBox.Show("Khách hàng đã thanh toán!!");
                return;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageScheduleBLL manageScheduleBLL = new ManageScheduleBLL();
            dgvSchedule.DataSource = manageScheduleBLL.searchCustomersBLL(tbSearch.Text);

        }
    }
}
