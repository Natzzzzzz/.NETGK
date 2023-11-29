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
    public partial class ScheduleManage : UserControl
    {
        public ScheduleManage()
        {
            InitializeComponent();
        }


        private void getAvailableCar()
        {
            ManageScheduleBLL scheduleBLL = new ManageScheduleBLL();
            DataTable dataTable = scheduleBLL.getAvailableCarBLL();
            dgvSchedule.DataSource = dataTable;

        }
        private void getRentalCar()
        {
            ManageScheduleBLL scheduleBLL = new ManageScheduleBLL();
            DataTable dataTable = scheduleBLL.getRentalCarBLL();
            dgvSchedule.DataSource = dataTable;

        }
        private void btnAvailable_Click(object sender, EventArgs e)
        {
            getAvailableCar();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            getRentalCar();
        }

        private void ScheduleManage_Load(object sender, EventArgs e)
        {
            getRentalCar();
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {

            int rowIndex = dgvSchedule.SelectedCells[0].RowIndex;
            String historyID = dgvSchedule.Rows[rowIndex].Cells[0].Value.ToString();
            String paymentStatus = dgvSchedule.Rows[rowIndex].Cells[12].Value.ToString();
            MessageBox.Show(paymentStatus.Equals("Chưa thanh toán") + "");
            MessageBox.Show(paymentStatus);
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
