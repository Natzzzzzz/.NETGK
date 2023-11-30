using Midterm.GUI.CarOrder;
using Midterm.GUI.ScheduleManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm.GUI.Staff
{
    public partial class MainStaff : Form
    {
        private CarType carType;
        private Schedule schedule;
        private String userID;
        public MainStaff(String userID)
        {
            InitializeComponent();
            this.userID = userID;
            carType = new CarType(userID);
            schedule = new Schedule();
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
            panel_main.Controls.Add(schedule);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MainStaff_Load(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnOrder.Location.Y);
            lbl_title.Text = "Quản lý đơn đặt xe";
            panel_main.Controls.Clear();
            panel_main.Controls.Add(carType);
        }
    }
}
