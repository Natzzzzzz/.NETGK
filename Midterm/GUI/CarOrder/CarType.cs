using Midterm.GUI.CarManage;
using Midterm.GUI.CarOrder;
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
    public partial class CarType : UserControl
    {
        private string userID;

        public CarType(string userIDLogin)
        {
            InitializeComponent();
            this.userID = userIDLogin;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            Form form = new CarOrder("Mini", userID);
            form.ShowDialog();
        }

        private void btnSedan_Click(object sender, EventArgs e)
        {
            Form form = new CarOrder("Sedan", userID);
            form.ShowDialog();

        }

        private void btnHatchback_Click(object sender, EventArgs e)
        {
            Form form = new CarOrder("Hatchback", userID);
            form.ShowDialog();
        }

        private void btnCUV_Click(object sender, EventArgs e)
        {
            Form form = new CarOrder("CUV", userID);
            form.ShowDialog();
        }

        private void btnSUV_Click(object sender, EventArgs e)
        {
            Form form = new CarOrder("SUV", userID);
            form.ShowDialog();
        }

        private void btnMPV_Click(object sender, EventArgs e)
        {
            Form form = new CarOrder("MPV", userID);
            form.ShowDialog();
        }

        private void btnBanTai_Click(object sender, EventArgs e)
        {
            Form form = new CarOrder("Bán tải", userID);
            form.ShowDialog();
        }
    }
}
