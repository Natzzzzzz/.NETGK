namespace Midterm.GUI.Staff
{
    partial class MainStaff
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu_active = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel_title = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Location = new System.Drawing.Point(202, 87);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1166, 500);
            this.panel_main.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.menu_active);
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 587);
            this.panel1.TabIndex = 2;
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
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
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
            this.panel_title.Location = new System.Drawing.Point(200, 2);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1168, 85);
            this.panel_title.TabIndex = 3;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(457, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(73, 32);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title";
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSchedule.ForeColor = System.Drawing.Color.Transparent;
            this.btnSchedule.Location = new System.Drawing.Point(24, 148);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(176, 70);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "Quản lý lịch trình";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // MainStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 591);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_title);
            this.Name = "MainStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainStaff";
            this.Load += new System.EventHandler(this.MainStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menu_active;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label lbl_title;
    }
}