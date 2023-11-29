using System.Drawing;
using System.Windows.Forms;

namespace Midterm.GUI.CarManage
{
    partial class CarManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarManage));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnSedan = new System.Windows.Forms.Button();
            this.btnHatchback = new System.Windows.Forms.Button();
            this.btnCUV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMPV = new System.Windows.Forms.Button();
            this.btnBanTai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(482, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại xe";
            // 
            // btnMini
            // 
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.Location = new System.Drawing.Point(189, 86);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(118, 122);
            this.btnMini.TabIndex = 6;
            this.btnMini.Text = "4 chỗ (Mini)";
            this.btnMini.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnSedan
            // 
            this.btnSedan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSedan.BackgroundImage")));
            this.btnSedan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSedan.Location = new System.Drawing.Point(367, 86);
            this.btnSedan.Name = "btnSedan";
            this.btnSedan.Size = new System.Drawing.Size(118, 122);
            this.btnSedan.TabIndex = 7;
            this.btnSedan.Text = "4 chỗ (Sedan)";
            this.btnSedan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSedan.UseVisualStyleBackColor = true;
            this.btnSedan.Click += new System.EventHandler(this.btnSedan_Click);
            // 
            // btnHatchback
            // 
            this.btnHatchback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHatchback.BackgroundImage")));
            this.btnHatchback.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHatchback.Location = new System.Drawing.Point(551, 86);
            this.btnHatchback.Name = "btnHatchback";
            this.btnHatchback.Size = new System.Drawing.Size(118, 122);
            this.btnHatchback.TabIndex = 8;
            this.btnHatchback.Text = "4 chỗ (Hatchback)";
            this.btnHatchback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHatchback.UseVisualStyleBackColor = true;
            this.btnHatchback.Click += new System.EventHandler(this.btnHatchback_Click);
            // 
            // btnCUV
            // 
            this.btnCUV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCUV.BackgroundImage")));
            this.btnCUV.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCUV.Location = new System.Drawing.Point(730, 86);
            this.btnCUV.Name = "btnCUV";
            this.btnCUV.Size = new System.Drawing.Size(118, 122);
            this.btnCUV.TabIndex = 9;
            this.btnCUV.Text = "5 chỗ (CUV gầm cao)";
            this.btnCUV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCUV.UseVisualStyleBackColor = true;
            this.btnCUV.Click += new System.EventHandler(this.btnCUV_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(189, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 122);
            this.button1.TabIndex = 10;
            this.button1.Text = "7 chỗ (SUV gầm cao)";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMPV
            // 
            this.btnMPV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMPV.BackgroundImage")));
            this.btnMPV.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPV.Location = new System.Drawing.Point(367, 264);
            this.btnMPV.Name = "btnMPV";
            this.btnMPV.Size = new System.Drawing.Size(118, 122);
            this.btnMPV.TabIndex = 11;
            this.btnMPV.Text = "7 chỗ (MPV gầm thấp)";
            this.btnMPV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMPV.UseVisualStyleBackColor = true;
            this.btnMPV.Click += new System.EventHandler(this.btnMPV_Click);
            // 
            // btnBanTai
            // 
            this.btnBanTai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBanTai.BackgroundImage")));
            this.btnBanTai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanTai.Location = new System.Drawing.Point(551, 264);
            this.btnBanTai.Name = "btnBanTai";
            this.btnBanTai.Size = new System.Drawing.Size(118, 122);
            this.btnBanTai.TabIndex = 12;
            this.btnBanTai.Text = "Bán tải";
            this.btnBanTai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBanTai.UseVisualStyleBackColor = true;
            this.btnBanTai.Click += new System.EventHandler(this.btnBanTai_Click);
            // 
            // CarType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBanTai);
            this.Controls.Add(this.btnMPV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCUV);
            this.Controls.Add(this.btnHatchback);
            this.Controls.Add(this.btnSedan);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.label1);
            this.Name = "CarType";
            this.Size = new System.Drawing.Size(1030, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnMini;
        private Button btnSedan;
        private Button btnHatchback;
        private Button btnCUV;
        private Button button1;
        private Button btnMPV;
        private Button btnBanTai;
    }
}
