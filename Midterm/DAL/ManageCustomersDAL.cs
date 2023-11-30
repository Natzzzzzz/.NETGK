using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Midterm.DTO;
using System.Windows.Forms;

namespace Midterm.DAL
{
	internal class ManageCustomersDAL
	{
		String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public DataTable getAllCustomerDAL()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT customerID AS [ID], fullName AS [Họ và tên], phoneNumber AS [Số điện thoại], address AS [Địa chỉ] FROM Customers ";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getCustomersByIDBLL(string id)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT * FROM Customers WHERE customerID = @id";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void insertCustomersDAL(Customers customer)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "EXEC InsertCustomers @fullName, @phoneNumber, @address";
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
                MessageBox.Show("asdasdas");
            }
        }

        public void updateCustomersDAL(Customers customers)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                string sSQL = "UPDATE Customers SET fullName = @fullName, phoneNumber = @phoneNumber, address = @address WHERE customerID = @customerID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@customerID", customers.customerID);
                cmd.Parameters.AddWithValue("@fullName", customers.fullName);
                cmd.Parameters.AddWithValue("@phoneNumber", customers.phoneNumber);
                cmd.Parameters.AddWithValue("@address", customers.address);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                // Log the exception details to a log file or another logging mechanism.
            }
        }
        public DataTable searchCustomersDAL(String key)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();
            if (key == null || key.Equals(""))
            {
                String sSQL = "select customerID AS [ID], fullName AS [Họ và tên], phoneNumber AS [Số điện thoại], address AS [Địa chỉ] from Customers";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            else
            {
                string sSQL = "SELECT DISTINCT customerID AS [ID], fullName AS [Họ và tên], phoneNumber AS [Số điện thoại], address AS [Địa chỉ] FROM Customers " +
                    "WHERE fullName LIKE '%' + @key + '%' OR fullName LIKE @key + '%' OR phoneNumber LIKE '%' + @key + '%' OR phoneNumber LIKE @key + '%'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@key", key);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            conn.Close();
            return dt;
        }
        public void deleteCustomersDAL(String id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "delete from Customers where customerID = @id";
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
