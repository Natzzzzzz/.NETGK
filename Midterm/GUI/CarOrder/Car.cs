using Midterm.BLL;
using Midterm.DAL;
using Midterm.DTO;
using Midterm.GUI.CustomerManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Midterm.GUI.CarOrder
{
    public partial class Car : Form
    {
        public String id;
        public String status;
        private double totalRental;
        private double totalRentalTotal;
        private Cars car = new Cars();
        private Dictionary<string, CheckBox> checkBoxMapping = new Dictionary<string, CheckBox>();
        private Dictionary<string, double> rentalMapping = new Dictionary<string, double>
        {
            { "map", 0.0 },{ "curbsideCamera", 50.0 },{ "tireSensor", 30.0 },{ "carWindows", 100.0 },{ "USB", 20.0 },{ "trunkLid", 80.0 },{ "bluetooth", 0.0 },{ "cameraJourney", 60.0 },{ "collisionSensor", 40.0 },{ "GPS", 70.0 },{ "spareTire", 100.0 },{ "camera360", 90.0 },{ "reversingCamera", 50.0 },{ "speedWarning", 30.0 }
        };
        public string category;
        public string userID;
        public Car(String carCategory, string userID)
        {
            InitializeComponent();
            this.category = carCategory;
            this.userID = userID;
            tbLoaiXe.Text = carCategory;
            tbTotalMoney.ReadOnly = true;

            ManageHistoryBLL historyBLL = new ManageHistoryBLL();

          
            ManageHistoryBLL storeBLL = new ManageHistoryBLL();
            DataTable dt = storeBLL.getAllCarBrandBLL(carCategory);

            if (dt.Rows.Count > 0)
            {
                cbBrand.DisplayMember = "carBrand";
                cbBrand.ValueMember = "carBrand";
                cbBrand.DataSource = dt;
            }
            else cbBrand.DataSource = null;

            
            

            checkBoxMapping.Add("map", cb_Map);
            checkBoxMapping.Add("curbsideCamera", cb_curbsideCamera);
            checkBoxMapping.Add("tireSensor", cb_tireSensor);
            checkBoxMapping.Add("carWindows", cb_carWindows);
            checkBoxMapping.Add("USB", cb_USB);
            checkBoxMapping.Add("trunkLid", cb_trunkLid);
            checkBoxMapping.Add("bluetooth", cb_bluetooth);
            checkBoxMapping.Add("cameraJourney", cb_cameraJourney);
            checkBoxMapping.Add("collisionSensor", cb_collisionSensor);
            checkBoxMapping.Add("GPS", cb_GPS);
            checkBoxMapping.Add("spareTire", cb_spareTire);
            checkBoxMapping.Add("camera360", cb_camera360);
            checkBoxMapping.Add("reversingCamera", cb_reversingCamera);
            checkBoxMapping.Add("speedWarning", cb_speedWarning);

            // Set Tag property for each checkbox
            foreach (var kvp in checkBoxMapping)
            {
                kvp.Value.Tag = kvp.Key;
                kvp.Value.CheckedChanged += CheckBox_CheckedChanged;
            }
            tbLoaiXe.ReadOnly = true;
            tbTotalMoney.ReadOnly = true;
            rdbAll.AutoCheck = false;
            rdbDau.AutoCheck = false;
            rdbDien.AutoCheck = false;
            rdbXang.AutoCheck = false;
        }
        private void Car_Load(object sender, EventArgs e)
        {
            ManageHistoryBLL history = new ManageHistoryBLL();

            DataTable dt2 = history.getAllProvinceBLL();

            if (dt2.Rows.Count > 0)
            {
                DataTable dtCopy = dt2.Copy();

                cbStartPoint.DisplayMember = "provinceName";
                cbStartPoint.ValueMember = "provinceName";
                cbStartPoint.DataSource = dt2;

                cbEndPoint.DisplayMember = "provinceName";
                cbEndPoint.ValueMember = "provinceName";
                cbEndPoint.DataSource = dtCopy;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManageHistoryBLL historyBLL = new ManageHistoryBLL();
            History history = new History();
            

            //Add History
            history.bookingDate = DateTime.Now;
            history.startDate = dateTimePicker1.Value;
            history.endDate = dateTimePicker2.Value;
            history.paymentStatus = "Chưa thanh toán";
            history.startPoint = cbStartPoint.Text;
            history.endPoint = cbEndPoint.Text;
            history.totalMoney = float.Parse(tbTotalMoney.Text);
            history.accountID = userID;
            if (historyBLL.getCustomerIDBLL(tbFullName.Text, tbPhoneNumber.Text, tbAddress.Text) == null)
            {
                Customers customer = new Customers();
                customer.fullName = tbFullName.Text;
                customer.phoneNumber = tbPhoneNumber.Text;
                customer.address = tbAddress.Text;
                ManageCustomersBLL manageCustomersBLL = new ManageCustomersBLL();
                manageCustomersBLL.insertCustomersBLL(customer);
                history.customerID = historyBLL.getCustomerIDBLL(tbFullName.Text, tbPhoneNumber.Text, tbAddress.Text);
            }else
            {
                history.customerID = historyBLL.getCustomerIDBLL(tbFullName.Text, tbPhoneNumber.Text, tbAddress.Text);
            }
            String id = historyBLL.getCarIDBLL(tbLoaiXe.Text, cbBrand.Text, cbName.Text);
            history.carID = id;
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Ngày thuê không được vượt qua ngày trả");
                return;
            }
            else
            {
                if (historyBLL.isAvaibleCarBLL(id, dateTimePicker1.Value, dateTimePicker2.Value).Rows.Count == 0)
                {
                    ManageHistoryBLL manageHistoryBLL = new ManageHistoryBLL();
                    manageHistoryBLL.insertHistoryBLL(history);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xe đã được thuê trong khoảng thời gian đó!");
                    return;
                }
            }


            //Update status car
            ManageCarsBLL manageCarsBLL = new ManageCarsBLL();
            Cars car = new Cars();
            car.carID = historyBLL.getCarIDBLL(tbLoaiXe.Text, cbBrand.Text, cbName.Text);
            car.carStatus = "Cho thuê";

            manageCarsBLL.updateStatusCarBLL(car);

            
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string propertyName = checkBox.Tag.ToString();

            if (checkBox.Checked)
            {

                if (rentalMapping.ContainsKey(propertyName))
                {
                    totalRental = rentalMapping[propertyName];
                }
                tbTotalMoney.Text = (totalRental * (dateTimePicker2.Value.Subtract(dateTimePicker1.Value).Days + 1) + double.Parse(tbTotalMoney.Text)).ToString();

            }
            else
            {

                if (rentalMapping.ContainsKey(propertyName))
                {
                    totalRental = rentalMapping[propertyName];
                }
                tbTotalMoney.Text = (double.Parse(tbTotalMoney.Text) - (totalRental * (dateTimePicker2.Value.Subtract(dateTimePicker1.Value).Days + 1))).ToString();

            }
            totalRentalTotal = double.Parse(tbTotalMoney.Text);


        }
        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageHistoryBLL name = new ManageHistoryBLL();
            string carBrand = cbBrand.Text;

            if (!string.IsNullOrEmpty(carBrand))
            {
                DataTable dt = name.getAllCarNameBLL(carBrand);

                if (dt.Rows.Count > 0)
                {
                    cbName.DisplayMember = "carName";
                    cbName.ValueMember = "carName";
                    cbName.DataSource = dt;
                }
                else cbName.DataSource = null;
            }
            else { }


        }
        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {

            ManageHistoryBLL historyBLL = new ManageHistoryBLL();
            ManageCarsBLL dataBLL = new ManageCarsBLL();
            Cars car = new Cars();
            car.carID = historyBLL.getCarIDBLL(tbLoaiXe.Text, cbBrand.Text, cbName.Text);
            foreach (DataRow row in dataBLL.getCarsByID(car.carID).Rows)
            {
                if (row["carFuel"].ToString() == "Tất cả"){rdbAll.Checked = true;}
                else if (row["carFuel"].ToString() == "Điện"){rdbDien.Checked = true;}
                else if (row["carFuel"].ToString() == "Xăng"){rdbXang.Checked = true;}
                else if (row["carFuel"].ToString() == "Dầu"){rdbDau.Checked = true;}
                tbTotalMoney.Text = row["carRental"].ToString().Trim();

                Dictionary<string, CheckBox> checkBoxDictionary = new Dictionary<string, CheckBox>{{ "map", cb_Map },{ "curbsideCamera", cb_curbsideCamera },{ "tireSensor", cb_tireSensor },{ "carWindows", cb_carWindows },{ "USB", cb_USB },{ "trunkLid", cb_trunkLid },{ "bluetooth", cb_bluetooth },{ "cameraJourney", cb_cameraJourney },{ "collisionSensor", cb_collisionSensor },{ "GPS", cb_GPS },{ "spareTire", cb_spareTire },{ "camera360", cb_camera360 },{ "reversingCamera", cb_reversingCamera },{ "speedWarning", cb_speedWarning },};
                foreach (var entry in checkBoxDictionary)
                {
                    string columnName = entry.Key;
                    CheckBox checkBox = entry.Value;

                    if (row[columnName].ToString() == "Có")
                    {
                        checkBox.Checked = true;
                    }else if (row[columnName].ToString() == "Không")
                    {
                        checkBox.Checked = false;
                    }
                }
                totalRental = double.Parse(row["carRental"].ToString().Trim());

                tbTotalMoney.Text = totalRental+"";


            }
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            totalRentalTotal = double.Parse(tbTotalMoney.Text);

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker2.Value.Subtract(dateTimePicker1.Value).Days < 0)
            {
                MessageBox.Show("Vui lòng chọn ngày trả phù hợp");
                return;     
            }
            ManageHistoryBLL historyBLL = new ManageHistoryBLL();
            ManageCarsBLL dataBLL = new ManageCarsBLL();
            foreach (DataRow row in dataBLL.getCarsByID(historyBLL.getCarIDBLL(tbLoaiXe.Text, cbBrand.Text, cbName.Text)).Rows)
            {
                totalRental = double.Parse(row["carRental"].ToString().Trim());
            }
            tbTotalMoney.Text = (totalRentalTotal * (dateTimePicker2.Value.Subtract(dateTimePicker1.Value).Days+1)).ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Subtract(dateTimePicker2.Value).Days > 0)
            {
                MessageBox.Show("Vui lòng chọn ngày thuê phù hợp");
                return;
            }
            ManageHistoryBLL historyBLL = new ManageHistoryBLL();
            ManageCarsBLL dataBLL = new ManageCarsBLL();
            foreach (DataRow row in dataBLL.getCarsByID(historyBLL.getCarIDBLL(tbLoaiXe.Text, cbBrand.Text, cbName.Text)).Rows)
            {
                totalRental = double.Parse(row["carRental"].ToString().Trim());
            }
            tbTotalMoney.Text = (totalRentalTotal * (dateTimePicker2.Value.Subtract(dateTimePicker1.Value).Days + 1)).ToString();
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
