using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Midterm.DTO;
using System.Windows.Forms;

namespace Midterm.DAL
{
    internal class ManageScheduleDAL
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public DataTable getAvailableCarDAL()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT carID AS [ID Xe], carName AS [Tên xe], carCategory AS [Loại xe], carBrand AS [Hãng xe], carFuel AS [Nhiên liệu], carStatus AS [Trạng thái] FROM Cars WHERE carStatus = @carStatus";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@carStatus", "Trống");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getRentalCarDAL()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT H.historyID AS [ID], C.carName AS [Tên xe], C.carCategory AS [Loại xe], C.carBrand AS [Hãng xe], C.carStatus AS [Trạng thái], Cu.fullName AS [Khách thuê], Cu.phoneNumber AS [SĐT], H.startDate AS [Ngày thuê], H.endDate AS [Ngày trả], H.startPoint AS [Điểm đi], H.endPoint AS [Điểm đến], H.totalMoney AS [Tổng tiền thuê], H.paymentStatus AS [Trạng thái thanh toán] FROM Cars C INNER JOIN History H ON C.carID = H.carID INNER JOIN Customers Cu ON H.customerID = Cu.customerID WHERE C.carStatus = @carStatus";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@carStatus", "Cho thuê");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getCarInfoDAL(String id)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT C.* FROM Cars C INNER JOIN History H ON C.carID = H.carID WHERE H.historyID = @historyID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@historyID", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getCustomerInfoDAL(String id)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT Cu.* FROM Customers Cu INNER JOIN History H ON Cu.customerID = H.customerID WHERE H.historyID = @historyID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@historyID", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getHistoryInfoDAL(String id)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT * FROM History WHERE historyID = @historyID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@historyID", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void updateStatusDAL(String id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "update History set paymentStatus = @status where historyID=@id";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", "    ");
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        public DataTable searchCustomersDAL(String key)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();
            if (key == null || key.Equals(""))
            {
                String sSQL = "SELECT H.historyID AS [ID], C.carName AS [Tên xe], C.carCategory AS [Loại xe], C.carBrand AS [Hãng xe], C.carStatus AS [Trạng thái], Cu.fullName AS [Khách thuê], Cu.phoneNumber AS [SĐT], H.startDate AS [Ngày thuê], H.endDate AS [Ngày trả], H.startPoint AS [Điểm đi], H.endPoint AS [Điểm đến], H.totalMoney AS [Tổng tiền thuê], H.paymentStatus AS [Trạng thái thanh toán] FROM Cars C INNER JOIN History H ON C.carID = H.carID INNER JOIN Customers Cu ON H.customerID = Cu.customerID WHERE C.carStatus = @carStatus";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@carStatus", "Cho thuê");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            else
            {
                string sSQL = "SELECT DISTINCT H.historyID AS [ID], C.carName AS [Tên xe], C.carCategory AS [Loại xe], C.carBrand AS [Hãng xe], C.carStatus AS [Trạng thái], Cu.fullName AS [Khách thuê], Cu.phoneNumber AS [SĐT], H.startDate AS [Ngày thuê], H.endDate AS [Ngày trả], H.startPoint AS [Điểm đi], H.endPoint AS [Điểm đến], H.totalMoney AS [Tổng tiền thuê], H.paymentStatus AS [Trạng thái thanh toán] FROM Cars C INNER JOIN History H ON C.carID = H.carID INNER JOIN Customers Cu ON H.customerID = Cu.customerID " +
                    "WHERE ((fullName LIKE '%' + @key + '%' OR fullName LIKE @key + '%') AND C.carStatus = @carStatus) " +
                    "OR ((phoneNumber LIKE '%' + @key + '%' OR phoneNumber LIKE @key + '%') AND C.carStatus = @carStatus)";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@key", key);
                cmd.Parameters.AddWithValue("@carStatus", "Cho thuê");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            conn.Close();
            return dt;
        }
    }
}
