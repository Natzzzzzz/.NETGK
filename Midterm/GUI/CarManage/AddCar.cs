using Midterm.BLL;
using Midterm.DAL;
using Midterm.DTO;
using Midterm.GUI.CarOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm.GUI.CarManage
{
    public partial class AddCar : Form
    {
        private Cars newCar = new Cars();
        private Dictionary<string, CheckBox> checkBoxMapping = new Dictionary<string, CheckBox>();
        private Dictionary<string, double> rentalMapping = new Dictionary<string, double>
        {{ "map", 0.0 },{ "curbsideCamera", 50.0 },{ "tireSensor", 30.0 },{ "carWindows", 100.0 },{ "USB", 20.0 },{ "trunkLid", 80.0 },{ "bluetooth", 0.0 },{ "cameraJourney", 60.0 },{ "collisionSensor", 40.0 },{ "GPS", 70.0 },{ "spareTire", 100.0 },{ "camera360", 90.0 },{ "reversingCamera", 50.0 },{ "speedWarning", 30.0 }};

        private double totalRental = 0.0;

        public AddCar(String category)
        {
            InitializeComponent();
            tbRental.Text = "0.0";
            tbLoaiXe.Text = category;
            tbLoaiXe.ReadOnly = true;
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
        }


        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string propertyName = checkBox.Tag.ToString();

            if (checkBox.Checked)
            {
                if (rentalMapping.ContainsKey(propertyName)){totalRental = rentalMapping[propertyName];}
                tbRental.Text = (totalRental + double.Parse(tbRental.Text)).ToString();
            }
            else
            {
                if (rentalMapping.ContainsKey(propertyName)){totalRental = rentalMapping[propertyName];}
                tbRental.Text = (double.Parse(tbRental.Text) - totalRental).ToString();
            }
            bool anyCheckboxChecked = checkBoxMapping.Any(pair => pair.Value.Checked);

            tbRental.ReadOnly = anyCheckboxChecked;
            newCar.carRental = double.Parse(tbRental.Text);

            
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {

            newCar.carName = tbTenXe.Text;
            newCar.carCategory = tbLoaiXe.Text;
            newCar.carBrand = tbHangXe.Text;
            newCar.carStatus = "Trống";
            if (rdbAll.Checked)
            {
                newCar.carFuel = "Tất cả";
            }
            else if (rdbDau.Checked)
            {
                newCar.carFuel = "Dầu";
            }
            else if (rdbDien.Checked)
            {
                newCar.carFuel = "Điện";
            }
            else if (rdbXang.Checked)
            {
                newCar.carFuel = "Xăng";
            }
            Dictionary<string, CheckBox> checkBoxMapping = new Dictionary<string, CheckBox>
            {
                { "map", cb_Map },
                { "curbsideCamera", cb_curbsideCamera },
                { "tireSensor", cb_tireSensor },
                { "carWindows", cb_carWindows },
                { "USB", cb_USB },
                { "trunkLid", cb_trunkLid },
                { "bluetooth", cb_bluetooth },
                { "cameraJourney", cb_cameraJourney },
                { "collisionSensor", cb_collisionSensor },
                { "GPS", cb_GPS },
                { "spareTire", cb_spareTire },
                { "camera360", cb_camera360 },
                { "reversingCamera", cb_reversingCamera },
                { "speedWarning", cb_speedWarning },
            };
            foreach (var propertyMap in checkBoxMapping)
            {
                string propertyName = propertyMap.Key;
                CheckBox checkBox = propertyMap.Value;
                if (checkBox.Checked){typeof(Cars).GetProperty(propertyName)?.SetValue(newCar, "Có");}
                else{typeof(Cars).GetProperty(propertyName)?.SetValue(newCar, "Không");}
            }

            ManageCarsBLL manageCarsBLL = new ManageCarsBLL();
            manageCarsBLL.insertCarBLL(newCar);
            this.Close();
        }
    }
}
