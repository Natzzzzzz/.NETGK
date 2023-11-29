
using System.Drawing;
using System.Windows.Forms;
namespace Midterm.GUI.ScheduleManage
{
    partial class ScheduleManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleManage));
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(41, 102);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowTemplate.Height = 25;
            this.dgvSchedule.Size = new System.Drawing.Size(937, 366);
            this.dgvSchedule.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbSearch.Location = new System.Drawing.Point(41, 44);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(319, 31);
            this.tbSearch.TabIndex = 14;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnPayment.ForeColor = System.Drawing.Color.Transparent;
            this.btnPayment.Location = new System.Drawing.Point(812, 37);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(166, 43);
            this.btnPayment.TabIndex = 54;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click_1);
            // 
            // btnAvailable
            // 
            this.btnAvailable.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAvailable.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAvailable.ForeColor = System.Drawing.Color.Transparent;
            this.btnAvailable.Location = new System.Drawing.Point(416, 37);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(166, 43);
            this.btnAvailable.TabIndex = 55;
            this.btnAvailable.Text = "Xe còn trống";
            this.btnAvailable.UseVisualStyleBackColor = false;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // btnRental
            // 
            this.btnRental.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRental.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnRental.ForeColor = System.Drawing.Color.Transparent;
            this.btnRental.Location = new System.Drawing.Point(608, 37);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(166, 43);
            this.btnRental.TabIndex = 56;
            this.btnRental.Text = "Xe cho thuê";
            this.btnRental.UseVisualStyleBackColor = false;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // ScheduleManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbSearch);
            this.Name = "ScheduleManage";
            this.Size = new System.Drawing.Size(1030, 500);
            this.Load += new System.EventHandler(this.ScheduleManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvSchedule;
        private PictureBox pictureBox1;
        private TextBox tbSearch;
        private Button btnPayment;
        private Button btnAvailable;
        private Button btnRental;
    }
}
