using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midterm.DTO;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Midterm.DAL
{
    internal class ManageHistoryDAL
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public DataTable getHistoryByCategoryDAL(String carCategory)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT A.fullName AS [Người tạo đơn], H.bookingDate AS [Ngày tạo], H.startDate AS [Ngày thuê], H.endDate AS [Ngày trả], Cu.fullName AS [Họ tên], Cu.phoneNumber AS [SĐT], Cu.address AS [Đ/c], C.carName AS [Tên Xe], C.carCategory AS [Loại], C.carBrand AS [Hãng], H.totalMoney AS [Tổng tiền], H.paymentStatus AS [Trạng thái] " +
                "FROM History H INNER JOIN Customers Cu ON H.customerID = Cu.customerID " +
                "INNER JOIN Cars C ON H.carID = C.carID " +
                "INNER JOIN Accounts A ON H.accountID = A.accountID " +
                "WHERE C.carCategory = @category;";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@category", carCategory);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getAllCarBrandDAL(String carCategory)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT DISTINCT carBrand FROM Cars WHERE carCategory=@category";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@category", carCategory);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getAllCarNameDAL(String carBrand)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT DISTINCT carName FROM Cars WHERE carBrand=@carBrand";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@carBrand", carBrand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public string GetCarIDDAL(string carCategory, string carBrand, string carName)
        {
            SqlConnection conn = new SqlConnection(strConn);
            {
                conn.Open();
                String sSQL = "SELECT carID FROM Cars WHERE carCategory = @carCategory AND carName = @carName AND carBrand = @carBrand";

                SqlCommand cmd = new SqlCommand(sSQL, conn);
                {
                    cmd.Parameters.AddWithValue("@carCategory", carCategory);
                    cmd.Parameters.AddWithValue("@carName", carName);
                    cmd.Parameters.AddWithValue("@carBrand", carBrand);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null; // or throw an exception, depending on your requirements
                    }
                }
            }
        }

        public string GetCustomerIDDAL(string fullName, string phoneNumber, string address)
        {
            SqlConnection conn = new SqlConnection(strConn);
            {
                conn.Open();
                String sSQL = "SELECT customerID FROM Customers WHERE fullName = @fullName AND phoneNumber = @phoneNumber AND address = @address";

                SqlCommand cmd = new SqlCommand(sSQL, conn);
                {
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@address", address);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null; // or throw an exception, depending on your requirements
                    }
                }
            }
        }


        public void insertHistoryDAL(History history)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "EXEC InsertHistory @bookingDate, @startDate, @endDate, @paymentStatus, @startPoint, @endPoint, @totalMoney, @accountID, @carID, @customerID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@bookingDate", history.bookingDate);
                cmd.Parameters.AddWithValue("@startDate", history.startDate);
                cmd.Parameters.AddWithValue("@endDate", history.endDate);
                cmd.Parameters.AddWithValue("@paymentStatus", history.paymentStatus);
                cmd.Parameters.AddWithValue("@startPoint", history.startPoint);
                cmd.Parameters.AddWithValue("@endPoint", history.endPoint);
                cmd.Parameters.AddWithValue("@totalMoney", history.totalMoney);
                cmd.Parameters.AddWithValue("@accountID", history.accountID);
                cmd.Parameters.AddWithValue("@carID", history.carID);
                cmd.Parameters.AddWithValue("@customerID", history.customerID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tạo đơn mới thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
            }
        }

        public DataTable isVailableCarDAL(String carID, DateTime startDate, DateTime endDate)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT * FROM History WHERE ( carID = @carID AND ((@startDate >= startDate AND @startDate < endDate) OR (@endDate > startDate AND @endDate <= endDate) OR (@startDate <= startDate AND @endDate >= endDate)));";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@carID", carID);
            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endDate", endDate);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getAllProvinceDAL()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT provinceName FROM Province";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable serachCarsDAL(String key, String category)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();
            if (key == null || key.Equals(""))
            {
                String sSQL = "SELECT H.bookingDate AS [Ngày tạo], H.startDate AS [Ngày thuê], H.endDate AS [Ngày trả], Cu.fullName AS [Họ tên], Cu.phoneNumber AS [SĐT], Cu.address AS [Đ/c], C.carName AS [Tên Xe], C.carCategory AS [Loại], C.carBrand AS [Hãng], H.totalMoney AS [Tổng tiền], H.paymentStatus AS [Trạng thái]" +
                    "FROM History H INNER JOIN Customers Cu ON H.customerID = Cu.customerID INNER JOIN Cars C ON H.carID = C.carID WHERE C.carCategory =@category; ";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@category", category);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            else
            {
                String sSQL = "SELECT DISTINCT H.bookingDate AS [Ngày tạo], H.startDate AS [Ngày thuê], H.endDate AS [Ngày trả], Cu.fullName AS [Họ tên], Cu.phoneNumber AS [SĐT], Cu.address AS [Đ/c], C.carName AS [Tên Xe], C.carCategory AS [Loại], C.carBrand AS [Hãng], H.totalMoney AS [Tổng tiền], H.paymentStatus AS [Trạng thái] " +
                            "FROM History H INNER JOIN Customers Cu ON H.customerID = Cu.customerID INNER JOIN Cars C ON H.carID = C.carID " +
                            "WHERE" +
                            "((C.carBrand LIKE '%' + @key + '%' OR C.carBrand LIKE @key + '%') AND C.carCategory = @category) " +
                            "OR ((C.carCategory LIKE '%' + @key + '%' OR C.carCategory LIKE @key + '%') AND C.carCategory = @category) " +
                            "OR ((Cu.fullName LIKE '%' + @key + '%' OR Cu.fullName LIKE '%' + @key OR Cu.fullName LIKE @key + '%') AND C.carCategory = @category) " +
                            "OR ((Cu.phoneNumber LIKE '%' + @key + '%' OR Cu.phoneNumber LIKE @key + '%') AND C.carCategory = @category)  ";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@key", key);
                cmd.Parameters.AddWithValue("@category", category);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            conn.Close();
            return dt;
        }
    }
}
