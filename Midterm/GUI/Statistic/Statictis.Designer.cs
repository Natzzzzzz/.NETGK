using System.Drawing;
using System.Windows.Forms;
namespace Midterm.GUI.Statistic
{
    partial class Statictis
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStatictis = new System.Windows.Forms.DataGridView();
            this.btnHangXe = new System.Windows.Forms.Button();
            this.btnLoaiXe = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatictis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "THỐNG KÊ THEO:";
            // 
            // dgvStatictis
            // 
            this.dgvStatictis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatictis.Location = new System.Drawing.Point(41, 102);
            this.dgvStatictis.Name = "dgvStatictis";
            this.dgvStatictis.RowTemplate.Height = 25;
            this.dgvStatictis.Size = new System.Drawing.Size(345, 374);
            this.dgvStatictis.TabIndex = 28;
            // 
            // btnHangXe
            // 
            this.btnHangXe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHangXe.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnHangXe.ForeColor = System.Drawing.Color.Transparent;
            this.btnHangXe.Location = new System.Drawing.Point(397, 29);
            this.btnHangXe.Name = "btnHangXe";
            this.btnHangXe.Size = new System.Drawing.Size(149, 42);
            this.btnHangXe.TabIndex = 27;
            this.btnHangXe.Text = "Theo hãng";
            this.btnHangXe.UseVisualStyleBackColor = false;
            this.btnHangXe.Click += new System.EventHandler(this.btnHangXe_Click);
            // 
            // btnLoaiXe
            // 
            this.btnLoaiXe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLoaiXe.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnLoaiXe.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoaiXe.Location = new System.Drawing.Point(237, 29);
            this.btnLoaiXe.Name = "btnLoaiXe";
            this.btnLoaiXe.Size = new System.Drawing.Size(149, 42);
            this.btnLoaiXe.TabIndex = 26;
            this.btnLoaiXe.Text = "Theo loại";
            this.btnLoaiXe.UseVisualStyleBackColor = false;
            this.btnLoaiXe.Click += new System.EventHandler(this.btnLoaiXe_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(732, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 29);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker2.Location = new System.Drawing.Point(732, 67);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(267, 29);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(588, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(588, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "Đến ngày:";
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.Transparent;
            this.pieChart1.Location = new System.Drawing.Point(509, 145);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(437, 294);
            this.pieChart1.TabIndex = 33;
            this.pieChart1.Text = "pieChart1";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcel.Location = new System.Drawing.Point(397, 97);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(149, 42);
            this.btnExcel.TabIndex = 34;
            this.btnExcel.Text = "Xuất file Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Statictis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvStatictis);
            this.Controls.Add(this.btnHangXe);
            this.Controls.Add(this.btnLoaiXe);
            this.Controls.Add(this.label1);
            this.Name = "Statictis";
            this.Size = new System.Drawing.Size(1030, 500);
            this.Load += new System.EventHandler(this.Statictis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatictis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private DataGridView dgvStatictis;
        private Button btnHangXe;
        private Button btnLoaiXe;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private LiveCharts.WinForms.PieChart pieChart1;
        private Button btnExcel;
    }
}
