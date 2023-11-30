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

namespace Midterm.GUI.ScheduleManage
{
    public partial class BillRental : Form
    {
        public String id;
        public BillRental(String historyID)
        {
            InitializeComponent();
            this.id = historyID;


        }

        private void BillRental_Load(object sender, EventArgs e)
        {
            ManageScheduleBLL manageScheduleBLL = new ManageScheduleBLL();
            foreach (DataRow row in manageScheduleBLL.getCustomerInfoBLL(id).Rows)
            {
                tbfullName.Text = row["fullName"].ToString();
            }
            foreach (DataRow row in manageScheduleBLL.getCarInfoBLL(id).Rows)
            {
                tbTenXe.Text = row["carName"].ToString();
                tbTenXe.ReadOnly = true;
                tbHangXe.Text = row["carBrand"].ToString();
                tbHangXe.ReadOnly = true;
                tbLoaiXe.Text = row["carCategory"].ToString();
                tbLoaiXe.ReadOnly = true;
                Dictionary<string, CheckBox> checkBoxDictionary = new Dictionary<string, CheckBox>
                {
                    { "map", cb_Map },{ "curbsideCamera", cb_curbsideCamera },{ "tireSensor", cb_tireSensor },{ "carWindows", cb_carWindows },{ "USB", cb_USB },{ "trunkLid", cb_trunkLid },{ "bluetooth", cb_bluetooth },{ "cameraJourney", cb_cameraJourney },{ "collisionSensor", cb_collisionSensor },{ "GPS", cb_GPS },{ "spareTire", cb_spareTire },{ "camera360", cb_camera360 },{ "reversingCamera", cb_reversingCamera },{ "speedWarning", cb_speedWarning },
                };

                foreach (var entry in checkBoxDictionary)
                {
                    string columnName = entry.Key;
                    CheckBox checkBox = entry.Value;
                    checkBox.AutoCheck = false;

                    if (row[columnName].ToString() == "Có")
                    {
                        checkBox.Checked = true;
                    }
                }
            }
            foreach (DataRow row in manageScheduleBLL.getHistoryInfoBLL(id).Rows)
            {
                dateTimePicker1.Text = row["startDate"].ToString();
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                dateTimePicker2.Text = row["endDate"].ToString();
                lbTotalMoney.Text = row["totalMoney"].ToString();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ManageScheduleBLL manageScheduleBLL = new ManageScheduleBLL();
            manageScheduleBLL.updateStatusBLL(id);
            MessageBox.Show("Thanh toán thành công!!");
            this.Close();
        }
    }
}
