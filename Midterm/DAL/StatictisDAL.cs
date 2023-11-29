using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.InteropServices.ComTypes;

namespace Midterm.DAL
{
    internal class StatictisDAL
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public DataTable statictisByCategoryDAL(String startDate, String endDate)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT C.carCategory AS [Loại], COUNT(*) AS [Số lượng], SUM(H.totalMoney) AS [Doanh Thu] " +
                "FROM History H INNER JOIN Cars C ON H.carID = C.carID " +
                "WHERE H.startDate BETWEEN @startDate AND @endDate AND H.endDate BETWEEN @startDate AND @endDate " +
                "GROUP BY C.carCategory " +
                "ORDER BY [Số lượng] ASC;";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endDate", endDate);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable statictisByBrandDAL(String startDate, String endDate)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT C.carBrand AS [Hãng], COUNT(*) AS [Số lượng], SUM(H.totalMoney) AS [Doanh Thu] " +
                "FROM History H INNER JOIN Cars C ON H.carID = C.carID " +
                "WHERE H.startDate BETWEEN @startDate AND @endDate AND H.endDate BETWEEN @startDate AND @endDate " +
                "GROUP BY C.carBrand " +
                "ORDER BY [Số lượng] ASC;";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endDate", endDate);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable statictisCarByCategoryDAL()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT C.carCategory, COUNT(H.carID) AS NumberOfCars " +
                "FROM History H INNER JOIN Cars C ON H.carID = C.carID " +
                "GROUP BY C.carCategory;";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable statictisRevenueByMonthDAL()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT YEAR(startDate) AS Nam, MONTH(startDate) AS Thang, SUM(totalMoney) AS TongDoanhThu " +
                "FROM History " +
                "WHERE paymentStatus = 'Đã thanh toán' GROUP BY YEAR(startDate), MONTH(startDate) " +
                "ORDER BY Nam, Thang;";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
