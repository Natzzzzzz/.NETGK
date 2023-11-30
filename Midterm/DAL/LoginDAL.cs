using Midterm.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.DAL
{
    internal class LoginDAL
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public string checkLoginDataDAL(Accounts tk)
        {
            string userName = null;
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "select * from Accounts where username = @userName and password = @userPassword";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@userName", tk.username);
            cmd.Parameters.AddWithValue("@userPassword", tk.password);
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userName = reader.GetString(5);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                reader.Close();
                conn.Close();
                return "Thông tin đăng nhập không chính xác!";
            }
            return userName;
        }

        public String getIdByUsernameDAL(String name)
        {
            String userID = "";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "select * from Accounts where username = '" + name + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                userID = row["accountID"].ToString();
            }
            return userID;
        }
    }
}
