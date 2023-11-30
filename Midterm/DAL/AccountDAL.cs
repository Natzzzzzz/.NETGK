using Midterm.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Midterm.DAL
{
    internal class AccountDAL
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public DataTable getAllAccountsDAL()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT accountID AS [ID], fullName AS [Họ và tên], phoneNumber AS [Số điện thoại], address AS [Địa chỉ], username AS [Tài khoản], password AS [Mật khẩu], role AS [Vai trò] FROM Accounts ";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getAccountsByIDBLL(string id)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT * FROM Accounts WHERE accountID = @id";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void insertAccountsDAL(Accounts customer)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "EXEC InsertStaff @fullName, @phoneNumber, @address";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@fullName", customer.fullName);
                cmd.Parameters.AddWithValue("@phoneNumber", customer.phoneNumber);
                cmd.Parameters.AddWithValue("@address", customer.address);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Khách hàng đã được thêm");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
            }
        }

        public void updateAccountsDAL(Accounts accounts)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                string sSQL = "UPDATE Accounts SET fullName = @fullName, phoneNumber = @phoneNumber, address = @address WHERE accountID = @accountID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@accountID", accounts.accountID);
                cmd.Parameters.AddWithValue("@fullName", accounts.fullName);
                cmd.Parameters.AddWithValue("@phoneNumber", accounts.phoneNumber);
                cmd.Parameters.AddWithValue("@address", accounts.address);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        public DataTable searchAccountsDAL(String key)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();
            if (key == null || key.Equals(""))
            {
                String sSQL = "SELECT accountID AS [ID], fullName AS [Họ và tên], phoneNumber AS [Số điện thoại], address AS [Địa chỉ], username AS [Tài khoản], password AS [Mật khẩu], role AS [Vai trò] FROM Accounts ";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            else
            {
                string sSQL = "SELECT DISTINCT accountID AS [ID], fullName AS [Họ và tên], phoneNumber AS [Số điện thoại], address AS [Địa chỉ], username AS [Tài khoản], password AS [Mật khẩu], role AS [Vai trò] FROM Accounts " +
                    "WHERE fullName LIKE '%' + @key + '%' OR fullName LIKE @key + '%' OR phoneNumber LIKE '%' + @key + '%' OR phoneNumber LIKE @key + '%'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@key", key);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            conn.Close();
            return dt;
        }
        public void deleteAccountsDAL(String id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "delete from Accounts where accountID = @id";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa dữ liệu thành công");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
