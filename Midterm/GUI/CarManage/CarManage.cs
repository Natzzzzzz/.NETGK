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

namespace Midterm.GUI.CarManage
{
    public partial class CarManage : UserControl
    {
        public CarManage()
        {
            InitializeComponent();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            Form form = new CarDetail("mini");
            form.ShowDialog();
        }

        private void btnSedan_Click(object sender, EventArgs e)
        {
            Form form = new CarDetail("sedan");
            form.ShowDialog();

        }

        private void btnHatchback_Click(object sender, EventArgs e)
        {
            Form form = new CarDetail("hatchback");
            form.ShowDialog();
        }

        private void btnCUV_Click(object sender, EventArgs e)
        {
            Form form = new CarDetail("CUV");
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new CarDetail("SUV");
            form.ShowDialog();
        }

        private void btnMPV_Click(object sender, EventArgs e)
        {
            Form form = new CarDetail("MPV");
            form.ShowDialog();
        }

        private void btnBanTai_Click(object sender, EventArgs e)
        {
            Form form = new CarDetail("bantai");
            form.ShowDialog();
        }
    }
}
