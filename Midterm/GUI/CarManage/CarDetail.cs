using Midterm.BLL;
using Midterm.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm.GUI.CarManage
{
    public partial class CarDetail : Form
    {
        ManageCarsBLL listBLL = new ManageCarsBLL();
        System.Data.DataTable list;
        private string category;
        private string id;
        public CarDetail(String carCategory)
        {
            InitializeComponent();
            this.category = carCategory;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Form form = new AddCar(category);
            form.FormClosed += (s, args) => RefreshDataGridView();
            form.ShowDialog();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvCar.SelectedCells[0].RowIndex;
            String carID = dgvCar.Rows[rowIndex].Cells[0].Value.ToString();
            String carStatus = dgvCar.Rows[rowIndex].Cells[5].Value.ToString();

            Form form = new UpdateCar(carID,carStatus);
            form.FormClosed += (s, args) => RefreshDataGridView();
            form.ShowDialog();
        }

        private void CarDetail_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvCar.SelectedCells[0].RowIndex;
            String carID = dgvCar.Rows[rowIndex].Cells[0].Value.ToString();
            ManageCarsBLL manageCarsBLL = new ManageCarsBLL();
            manageCarsBLL.deleteCarBLL(carID);

            RefreshDataGridView();

        }
        private void RefreshDataGridView()
        {
            ManageCarsBLL manageCarsBLL = new ManageCarsBLL();
            DataTable dataTable = manageCarsBLL.getCarsByCategory(category);
            dgvCar.DataSource = dataTable;
            dgvCar.Columns[0].Width = dgvCar.Width/6;
            dgvCar.Columns[1].Width = dgvCar.Width/6;
            dgvCar.Columns[2].Width = dgvCar.Width/6;
            dgvCar.Columns[3].Width = dgvCar.Width/6;
            dgvCar.Columns[4].Width = dgvCar.Width/6;
            dgvCar.Columns[5].Width = dgvCar.Width/6;
        }
        private void picBox_Click(object sender, EventArgs e)
        {
            ManageCarsBLL search = new ManageCarsBLL();
            dgvCar.DataSource = search.searchCarsBrandBLL(tbSearch.Text, category);
            dgvCar.Columns[0].Width = dgvCar.Width / 6;
            dgvCar.Columns[1].Width = dgvCar.Width / 6;
            dgvCar.Columns[2].Width = dgvCar.Width / 6;
            dgvCar.Columns[3].Width = dgvCar.Width / 6;
            dgvCar.Columns[4].Width = dgvCar.Width / 6;
            dgvCar.Columns[5].Width = dgvCar.Width / 6;
        }
    }
}
