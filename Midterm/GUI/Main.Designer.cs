using System.Drawing;
using System.Windows.Forms;

namespace Midterm
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.menu_active = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel_title = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnCar);
            this.panel1.Controls.Add(this.menu_active);
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 587);
            this.panel1.TabIndex = 0;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Location = new System.Drawing.Point(25, 149);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(176, 70);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "Quản lý khách hàng";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCar.Location = new System.Drawing.Point(24, 217);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(176, 70);
            this.btnCar.TabIndex = 7;
            this.btnCar.Text = "Quản lý ô tô";
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // menu_active
            // 
            this.menu_active.BackColor = System.Drawing.SystemColors.Control;
            this.menu_active.Location = new System.Drawing.Point(2, 82);
            this.menu_active.Name = "menu_active";
            this.menu_active.Size = new System.Drawing.Size(23, 69);
            this.menu_active.TabIndex = 6;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnSignOut.Location = new System.Drawing.Point(25, 518);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(176, 70);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.Transparent;
            this.btnReport.Location = new System.Drawing.Point(25, 353);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(176, 70);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Báo cáo thống kê";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSchedule.ForeColor = System.Drawing.Color.Transparent;
            this.btnSchedule.Location = new System.Drawing.Point(25, 284);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(176, 70);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "Quản lý lịch trình";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnOrder.Location = new System.Drawing.Point(25, 81);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(176, 70);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Quản lý đơn đặt xe";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_title.Controls.Add(this.lbl_title);
            this.panel_title.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_title.Location = new System.Drawing.Point(200, 1);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1032, 85);
            this.panel_title.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(401, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(73, 32);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Location = new System.Drawing.Point(202, 86);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1030, 500);
            this.panel_main.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 591);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnOrder;
        private Button btnReport;
        private Button btnSchedule;
        private Button btnSignOut;
        private Panel panel_title;
        private Label lbl_title;
        private Panel panel_main;
        private Panel menu_active;
        private Button btnCar;
        private Button btnCustomer;
    }
}