using Midterm.DAL;
using Midterm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.BLL
{
	internal class ManageCarsBLL
	{
        ManageCarsDAL manageCarsDAL = new ManageCarsDAL();

        public DataTable getCarsByCategory(String category)
        {
            ManageCarsDAL manageCarsDAL = new ManageCarsDAL();
            return manageCarsDAL.getCarsByCategory(category);
        }
        public DataTable getCarsByID(String id)
        {
            ManageCarsDAL manageCarsDAL = new ManageCarsDAL();
            return manageCarsDAL.getCarsByID(id);
        }
        public void insertCarBLL(Cars car)
        {
            manageCarsDAL.insertCarDAL(car);
        }
        public void updateCarBLL(Cars car)
        {
            ManageCarsDAL data = new ManageCarsDAL();
            data.updateCarDAL(car);
        }
        public void updateStatusCarBLL(Cars car)
        {
            ManageCarsDAL data = new ManageCarsDAL();
            data.updateStatusCarDAL(car);
        }
        public void deleteCarBLL(String id)
        {
            ManageCarsDAL data = new ManageCarsDAL();
            data.deleteCarsDAL(id);
        }
        public DataTable searchCarsBrandBLL(String key, String category)
        {
            ManageCarsDAL search = new ManageCarsDAL();
            return search.serachCarsBrandDAL(key, category);
        }
    }
}
