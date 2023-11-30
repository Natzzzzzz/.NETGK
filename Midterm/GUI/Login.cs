using Midterm.BLL;
using Midterm.DTO;
using Midterm.GUI.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Midterm.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            Accounts accounts = new Accounts();
            accounts.username = tbUserName.Text;
            accounts.password = tbPassword.Text;

            LoginBLL loginBLL = new LoginBLL();

            if (loginBLL.checkLoginDataBLL(accounts) == "Vui lòng nhập tên tài khoản")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            else if (loginBLL.checkLoginDataBLL(accounts) == "Vui lòng nhập mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            else if (loginBLL.checkLoginDataBLL(accounts) == "Thông tin đăng nhập không chính xác!")
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
                return;
            }
            else
            {
                if (loginBLL.getIdByUsernameBLL(accounts.username).ToString().Contains('A'))
                {
                    Main newMain = new Main(loginBLL.getIdByUsernameBLL(accounts.username).ToString());
                    this.Hide();
                    newMain.FormClosed += NewMain_FormClosed;
                    newMain.ShowDialog();
                }else if (loginBLL.getIdByUsernameBLL(accounts.username).ToString().Contains('S'))
                {
                    MainStaff newMainStaff = new MainStaff(loginBLL.getIdByUsernameBLL(accounts.username).ToString());
                    this.Hide();
                    newMainStaff.FormClosed += NewMain_FormClosed;
                    newMainStaff.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                }
            }
        }
        private void NewMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }
    }
}
