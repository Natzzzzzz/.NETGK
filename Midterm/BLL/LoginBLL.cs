using Midterm.DAL;
using Midterm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.BLL
{
    internal class LoginBLL
    {
        LoginDAL loginDAL = new LoginDAL();
        public string checkLoginDataBLL(Accounts tk)
        {
            if (tk.username == "" || tk.username == "Username")
            {
                return "Vui lòng nhập tên tài khoản";
            }
            else if (tk.password == "" || tk.password == "Password")
            {
                return "Vui lòng nhập mật khẩu";
            }
            return loginDAL.checkLoginDataDAL(tk);
        }

        public String getIdByUsernameBLL(String name)
        {
            return loginDAL.getIdByUsernameDAL(name);
        }
    }
}
