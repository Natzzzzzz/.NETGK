using Midterm.BLL;
using Midterm.DTO;
using Midterm.GUI.CarOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Midterm.GUI.CarManage
{
    public partial class UpdateCar : Form
    {
        public String id;
        public String status;
        private double totalRental;
        private Cars car = new Cars();
        private Dictionary<string, CheckBox> checkBoxMapping = new Dictionary<string, CheckBox>();
        private Dictionary<string, double> rentalMapping = new Dictionary<string, double>
        {
            { "map", 0.0 },{ "curbsideCamera", 50.0 },{ "tireSensor", 30.0 },{ "carWindows", 100.0 },{ "USB", 20.0 },{ "trunkLid", 80.0 },{ "bluetooth", 0.0 },{ "cameraJourney", 60.0 },{ "collisionSensor", 40.0 },{ "GPS", 70.0 },{ "spareTire", 100.0 },{ "camera360", 90.0 },{ "reversingCamera", 50.0 },{ "speedWarning", 30.0 }
        };
        public UpdateCar(String carID, String carStatus)
        {
            InitializeComponent();
            ManageCarsBLL dataBLL = new ManageCarsBLL();
            this.id= carID;
            this.status= carStatus;

            // Initialize checkBoxMapping
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
            foreach (DataRow row in dataBLL.getCarsByID(carID).Rows)
            {
                tbLoaiXe.Text = row["carCategory"].ToString();
                tbTenXe.Text = row["carName"].ToString();
                tbHangXe.Text = row["carBrand"].ToString();
                if(row["carFuel"].ToString() == "Tất cả")
                {
                    rdbAll.Checked = true;
                }else if(row["carFuel"].ToString() == "Điện")
                {
                    rdbDien.Checked = true;
                }
                else if (row["carFuel"].ToString() == "Xăng")
                {
                    rdbXang.Checked = true;
                }
                else if (row["carFuel"].ToString() == "Dầu")
                {
                    rdbDau.Checked = true;
                }
                tbRental.Text = row["carRental"].ToString().Trim();
                totalRental = double.Parse(row["carRental"].ToString().Trim());
                Dictionary<string, CheckBox> checkBoxDictionary = new Dictionary<string, CheckBox>
                {
                    { "map", cb_Map },{ "curbsideCamera", cb_curbsideCamera },{ "tireSensor", cb_tireSensor },{ "carWindows", cb_carWindows },{ "USB", cb_USB },{ "trunkLid", cb_trunkLid },{ "bluetooth", cb_bluetooth },{ "cameraJourney", cb_cameraJourney },{ "collisionSensor", cb_collisionSensor },{ "GPS", cb_GPS },{ "spareTire", cb_spareTire },{ "camera360", cb_camera360 },{ "reversingCamera", cb_reversingCamera },{ "speedWarning", cb_speedWarning },
                };

                foreach (var entry in checkBoxDictionary)
                {
                    string columnName = entry.Key;
                    CheckBox checkBox = entry.Value;

                    if (row[columnName].ToString() == "Có")
                    {
                        checkBox.Checked = true;
                    }
                }
            }
            tbHangXe.ReadOnly = true;
            tbLoaiXe.ReadOnly = true;
            tbTenXe.ReadOnly = true;
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string propertyName = checkBox.Tag.ToString(); // Assume you have set the Tag property of each checkbox to the corresponding property name

            if (checkBox.Checked)
            {

                // Add to the total rental when the checkbox is checked
                if (rentalMapping.ContainsKey(propertyName))
                {
                    totalRental = rentalMapping[propertyName];
                    // Update the carRental textbox with the new total
                }
                tbRental.Text = (totalRental + double.Parse(tbRental.Text)).ToString();

            }
            else
            {

                // Subtract from the total rental when the checkbox is unchecked
                if (rentalMapping.ContainsKey(propertyName))
                {
                    totalRental = rentalMapping[propertyName];
                    // Update the carRental textbox with the new total
                }
                tbRental.Text = (double.Parse(tbRental.Text) - totalRental).ToString();

            }
            // Check if any checkbox is checked
            bool anyCheckboxChecked = checkBoxMapping.Any(pair => pair.Value.Checked);

            // Set tbRental.ReadOnly based on the checked state of any checkbox
            tbRental.ReadOnly = anyCheckboxChecked;
            // Update the carRental property of the newCar object
            car.carRental = double.Parse(tbRental.Text);


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ManageCarsBLL update = new ManageCarsBLL();
            if (tbLoaiXe.Text == "" || tbHangXe.Text == "" || tbTenXe.Text == "" || !rdbAll.Checked && !rdbDau.Checked && !rdbDien.Checked && !rdbXang.Checked)
                MessageBox.Show("Nhập thiếu thông tin, vui lòng bổ sung!!");
            else
            {
                car.carID = id;
                car.carCategory = tbLoaiXe.Text;
                car.carBrand = tbHangXe.Text;
                car.carName = tbTenXe.Text;
            }
               
            if (rdbAll.Checked)
            {
                car.carFuel = "Tất cả";
            }
            else if (rdbDau.Checked)
            {
                car.carFuel = "Dầu";
            }
            else if (rdbDien.Checked)
            {
                car.carFuel = "Điện";
            }
            else if (rdbXang.Checked)
            {
                car.carFuel = "Xăng";
            }
            car.carStatus = status;
            Dictionary<string, CheckBox> checkBoxMapping = new Dictionary<string, CheckBox>
                {
                    { "map", cb_Map },{ "curbsideCamera", cb_curbsideCamera },{ "tireSensor", cb_tireSensor },{ "carWindows", cb_carWindows },{ "USB", cb_USB },{ "trunkLid", cb_trunkLid },{ "bluetooth", cb_bluetooth },{ "cameraJourney", cb_cameraJourney },{ "collisionSensor", cb_collisionSensor },{ "GPS", cb_GPS },{ "spareTire", cb_spareTire },{ "camera360", cb_camera360 },{ "reversingCamera", cb_reversingCamera },{ "speedWarning", cb_speedWarning },
                };

            foreach (var propertyMap in checkBoxMapping)
            {
                string propertyName = propertyMap.Key;
                CheckBox checkBox = propertyMap.Value;

                if (checkBox.Checked)
                {
                    // Gán giá trị "Có" vào thuộc tính tương ứng của đối tượng newCar
                    typeof(Cars).GetProperty(propertyName)?.SetValue(car, "Có");
                }
                else
                {
                    // Gán giá trị "Không" vào thuộc tính tương ứng của đối tượng newCar nếu không được chọn
                    typeof(Cars).GetProperty(propertyName)?.SetValue(car, "Không");
                }
            }

            update.updateCarBLL(car);
            this.Close();   
        }
    }
}
