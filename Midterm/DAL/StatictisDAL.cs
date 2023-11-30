using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.InteropServices.ComTypes;
using System.Net;

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
            String sSQL = "SELECT MONTH(startDate) AS Thang, SUM(totalMoney) AS TongDoanhThu FROM History " +
                        "WHERE paymentStatus = N'Đã thanh toán' AND YEAR(startDate) = YEAR(GETDATE()) " +
                        "GROUP BY MONTH(startDate) " +
                        "ORDER BY Thang;";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable statictisRevenueByYearDAL()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT YEAR(startDate) AS Nam, SUM(totalMoney) AS TongDoanhThu FROM History " +
                        "WHERE paymentStatus = N'Đã thanh toán' " +
                        "GROUP BY YEAR(startDate) " +
                        "ORDER BY Nam;";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public String getFirstDayOfMonthDAL()
        {
            SqlConnection conn = new SqlConnection(strConn);
            {
                conn.Open();
                String sSQL = "SELECT DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) AS FirstDayOfMonth;";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null) return result.ToString();
                    else return null;
                }
            }
        }
        public String getLastDayOfMonthDAL()
        {
            SqlConnection conn = new SqlConnection(strConn);
            {
                conn.Open();
                String sSQL = "SELECT DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) + 1, 0) - 1 AS LastDayOfMonth;";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null) return result.ToString();
                    else return null;
                }
            }
        }
    }
}
