using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.DTO
{
    internal class History
    {
		public string historyID { get; set; }
		public DateTime bookingDate { get; set; }
		public DateTime startDate { get; set; }
		public DateTime endDate { get; set; }
		public string paymentStatus { get; set; }
		public string startPoint { get; set; }
		public string endPoint { get; set; }
		public float totalMoney { get; set; }
		public string accountID { get; set; }
		public string carID { get; set; }
		public string customerID { get; set; }
	}
}
