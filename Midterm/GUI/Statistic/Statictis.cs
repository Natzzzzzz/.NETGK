using LiveCharts;
using LiveCharts.Wpf;
using Midterm.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm.GUI.Statistic
{
    public partial class Statictis : UserControl
    {
        public Statictis()
        {
            InitializeComponent();
        }
        StatictisBLL statictis = new StatictisBLL();

        private void btnLoaiXe_Click(object sender, EventArgs e)
        {
            statictisByCategory();
        }
        Func<ChartPoint, string> labelPoint = chartpoint =>
        {
            return string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        };

        private void Statictis_Load(object sender, EventArgs e)
        {
            statictisByCategory();
            SeriesCollection series = new SeriesCollection();

            foreach (DataRow row in statictis.statictisCarByCategory().Rows)
            {
                int numberOfCars = Convert.ToInt32(row["NumberOfCars"]);
                series.Add(new PieSeries() { Title = row["carCategory"].ToString(), Values = new ChartValues<int> { numberOfCars }, DataLabels = true, LabelPoint = labelPoint });
            }
            pieChart1.Series = series;
            pieChart1.LegendLocation = LegendLocation.Bottom;
            pieChart1.BackColor = Color.Transparent;
        }

        public void statictisByCategory()
        {
            DataTable dataTable = statictis.statictisByCategoryBLL(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            dgvStatictis.DataSource = dataTable;
        }

        private void btnHangXe_Click(object sender, EventArgs e)
        {
            DataTable dataTable = statictis.statictisByBrandBLL(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            dgvStatictis.DataSource = dataTable;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            DataTable dataTable = (DataTable)dgvStatictis.DataSource;

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                xlWorksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
                xlWorksheet.Range[xlWorksheet.Cells[1, i + 1], xlWorksheet.Cells[1, i + 1]].ColumnWidth = 15;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    xlWorksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
                }
            }

            if (dataTable.Rows.Count > 0)
            {
                int lastRow = xlWorksheet.UsedRange.Rows.Count + 1;
                int lastCol = xlWorksheet.UsedRange.Columns.Count;
                int col = 2;
                if (col <= lastCol && lastRow > 1)
                {
                    xlWorksheet.Range[xlWorksheet.Cells[1, col], xlWorksheet.Cells[lastRow, col]].ColumnWidth = 20;
                }
            }

            xlWorkbook.SaveAs("D:\\Download\\Revenue.xlsx");
            xlWorkbook.Close();
            xlApp.Quit();
            MessageBox.Show("In thành công");
        }
    }
}
