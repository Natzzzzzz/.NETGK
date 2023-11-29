using System.Drawing;
using System.Windows.Forms;

namespace Midterm.GUI
{
    partial class Login
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
			this.tbTenXe = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbLoaiXe = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbTenXe
			// 
			this.tbTenXe.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbTenXe.Location = new System.Drawing.Point(174, 201);
			this.tbTenXe.Name = "tbTenXe";
			this.tbTenXe.Size = new System.Drawing.Size(399, 34);
			this.tbTenXe.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(39, 204);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 28);
			this.label2.TabIndex = 20;
			this.label2.Text = "Mật khẩu";
			// 
			// tbLoaiXe
			// 
			this.tbLoaiXe.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbLoaiXe.Location = new System.Drawing.Point(174, 137);
			this.tbLoaiXe.Name = "tbLoaiXe";
			this.tbLoaiXe.Size = new System.Drawing.Size(399, 34);
			this.tbLoaiXe.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(39, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 28);
			this.label1.TabIndex = 18;
			this.label1.Text = "Tài khoản";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(213, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(230, 54);
			this.label3.TabIndex = 22;
			this.label3.Text = "Đăng nhập";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.button1.Location = new System.Drawing.Point(237, 284);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(137, 43);
			this.button1.TabIndex = 23;
			this.button1.Text = "Đăng nhập";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(599, 356);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbTenXe);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbLoaiXe);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private TextBox tbTenXe;
        private Label label2;
        private TextBox tbLoaiXe;
        private Label label1;
        private Label label3;
        private Button button1;
    }
}