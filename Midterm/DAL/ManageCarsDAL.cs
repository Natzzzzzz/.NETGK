using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midterm.DTO;
using Midterm.GUI.CarOrder;

namespace Midterm.DAL
{
	internal class ManageCarsDAL
	{
		String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
		
        public DataTable getCarsByCategory(string category)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT carID AS [ID Xe], carName AS [Tên xe], carCategory AS [Loại xe], carBrand AS [Hãng xe], carFuel AS [Nhiên liệu], carRental AS [Giá thuê / ngày] FROM Cars WHERE carCategory = @category";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@category", category);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getCarsByID(String id)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT * FROM Cars WHERE carID = @id";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void insertCarDAL(Cars car)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "EXEC InsertCar @carName,@carCategory,@carBrand,@carFuel,@carStatus,@carRental,@map,@curbsideCamera,@tireSensor,@carWindows,@USB,@trunkLid,@bluetooth,@cameraJourney,@collisionSensor,@GPS,@spareTire,@camera360,@reversingCamera,@speedWarning";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@carName", car.carName);
                cmd.Parameters.AddWithValue("@carCategory", car.carCategory);
                cmd.Parameters.AddWithValue("@carBrand", car.carBrand);
                cmd.Parameters.AddWithValue("@carFuel", car.carFuel);
                cmd.Parameters.AddWithValue("@carStatus", car.carStatus);
                cmd.Parameters.AddWithValue("@carRental", car.carRental);
                cmd.Parameters.AddWithValue("@map", car.map);
                cmd.Parameters.AddWithValue("@curbsideCamera", car.curbsideCamera);
                cmd.Parameters.AddWithValue("@tireSensor", car.tireSensor);
                cmd.Parameters.AddWithValue("@carWindows", car.carWindows);
                cmd.Parameters.AddWithValue("@USB", car.USB);
                cmd.Parameters.AddWithValue("@trunkLid", car.trunkLid);
                cmd.Parameters.AddWithValue("@bluetooth", car.bluetooth);
                cmd.Parameters.AddWithValue("@cameraJourney", car.cameraJourney);
                cmd.Parameters.AddWithValue("@collisionSensor", car.collisionSensor);
                cmd.Parameters.AddWithValue("@GPS", car.GPS);
                cmd.Parameters.AddWithValue("@spareTire", car.spareTire);
                cmd.Parameters.AddWithValue("@camera360", car.camera360);
                cmd.Parameters.AddWithValue("@reversingCamera", car.reversingCamera);
                cmd.Parameters.AddWithValue("@speedWarning", car.speedWarning);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xe đã được thêm");

            }
            catch(Exception ex)
            {
                MessageBox.Show("asdasdas");
            }
        }

        public void updateCarDAL(Cars car)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "update Cars set carName=@name, carCategory=@category, carBrand=@brand, carFuel=@fuel, carStatus=@status,carRental = @carRental, map=@map, curbsideCamera=@curbsideCamera, tireSensor=@tireSensor" +
                    ", carWindows=@carWindows, USB=@USB, trunkLid=@trunkLid, bluetooth=@bluetooth,  cameraJourney=@cameraJourney, collisionSensor=@collisionSensor, GPS=@GPS, spareTire=@spareTire," +
                    "camera360=@camera360, reversingCamera=@reversingCamera,  speedWarning=@speedWarning where carID=@id";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@id", car.carID);
                cmd.Parameters.AddWithValue("@name", car.carName);
                cmd.Parameters.AddWithValue("@category", car.carCategory);
                cmd.Parameters.AddWithValue("@brand", car.carBrand);
                cmd.Parameters.AddWithValue("@fuel", car.carFuel);
                cmd.Parameters.AddWithValue("@status", car.carStatus);
                cmd.Parameters.AddWithValue("@carRental", car.carRental);
                cmd.Parameters.AddWithValue("@map", car.map);
                cmd.Parameters.AddWithValue("@curbsideCamera", car.curbsideCamera);
                cmd.Parameters.AddWithValue("@tireSensor", car.tireSensor);
                cmd.Parameters.AddWithValue("@carWindows", car.carWindows);
                cmd.Parameters.AddWithValue("@USB", car.USB);
                cmd.Parameters.AddWithValue("@trunkLid", car.trunkLid);
                cmd.Parameters.AddWithValue("@bluetooth", car.bluetooth);
                cmd.Parameters.AddWithValue("@cameraJourney", car.cameraJourney);
                cmd.Parameters.AddWithValue("@collisionSensor", car.collisionSensor);
                cmd.Parameters.AddWithValue("@GPS", car.GPS);
                cmd.Parameters.AddWithValue("@spareTire", car.spareTire);
                cmd.Parameters.AddWithValue("@camera360", car.camera360);
                cmd.Parameters.AddWithValue("@reversingCamera", car.reversingCamera);
                cmd.Parameters.AddWithValue("@speedWarning", car.speedWarning);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
            }
        }
        public void updateStatusCarDAL(Cars car)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "update Cars set carStatus= @status where carID=@id";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@id", car.carID);
                cmd.Parameters.AddWithValue("@status", car.carStatus);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
            }
        }
        public void deleteCarsDAL(String id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "delete from Cars where carID = @id";
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


        public DataTable serachCarsBrandDAL(String key, String category)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();
            if (key == null || key.Equals(""))
            {
                String sSQL = "SELECT carID AS [ID Xe], carName AS [Tên xe], carCategory AS [Loại xe], carBrand AS [Hãng xe], carFuel AS [Nhiên liệu] FROM Cars WHERE carCategory = @category";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@category", category);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            else
            {
                string sSQL = "SELECT DISTINCT * FROM Cars WHERE " +
                    "((carBrand LIKE '%' + @key + '%' OR carBrand LIKE @key + '%') AND carCategory = @category) " +
                    "OR ((carCategory LIKE '%' + @key + '%' OR carCategory LIKE @key + '%') AND carCategory = @category)";
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
