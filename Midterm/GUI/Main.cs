using Midterm.BLL;
using Midterm.GUI;
using Midterm.GUI.CustomerManage;
using Midterm.GUI.CarOrder;
using Midterm.GUI.CarManage;
using Midterm.GUI.ScheduleManage;
using Midterm.GUI.Statistic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
namespace Midterm
{
    public partial class Main : Form
    {
        private CarType carType;
        private CustomerManage customerManage;
        private CarManage carManage;
        private ScheduleManage scheduleManage;
        private Statictis statictis;
        public Main()
        {

            InitializeComponent();
            carType = new CarType();
            customerManage = new CustomerManage();
            carManage = new CarManage();
            scheduleManage = new ScheduleManage();
            statictis = new Statictis();

        }
        private void Main_Load(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            lbl_title.Text = "Quản lý đơn đặt xe";
            btnOrder.Select();
            panel_main.Controls.Add(carType);

        }
        private void btnCar_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnCar.Location.Y);
            lbl_title.Text = "Quản lý ô tô";
            panel_main.Controls.Clear();
            panel_main.Controls.Add(carManage);
        }



        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnCustomer.Location.Y);
            lbl_title.Text = "Quản lý khách hàng";
            panel_main.Controls.Clear();
            panel_main.Controls.Add(customerManage);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnOrder.Location.Y);
            lbl_title.Text = "Quản lý đơn đặt xe";
            panel_main.Controls.Clear();
            panel_main.Controls.Add(carType);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnSchedule.Location.Y);
            lbl_title.Text = "Quản lý lịch trình";
            panel_main.Controls.Clear();
            panel_main.Controls.Add(scheduleManage);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnReport.Location.Y);
            lbl_title.Text = "Báo cáo thống kê";
            panel_main.Controls.Clear();
            panel_main.Controls.Add(statictis);

        }


    }
}