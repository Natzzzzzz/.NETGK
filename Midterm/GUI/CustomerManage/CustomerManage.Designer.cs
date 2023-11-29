using System.Drawing;
using System.Windows.Forms;
namespace Midterm.GUI.CustomerManage
{
    partial class CustomerManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManage));
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditCustomer.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnEditCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditCustomer.Location = new System.Drawing.Point(835, 40);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(149, 42);
            this.btnEditCustomer.TabIndex = 11;
            this.btnEditCustomer.Text = "Sửa";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(675, 40);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(149, 42);
            this.btnDeleteCustomer.TabIndex = 10;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.Location = new System.Drawing.Point(512, 40);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(149, 42);
            this.btnAddCustomer.TabIndex = 9;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click_1);
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(322, 51);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(40, 23);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 8;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbSearch.Location = new System.Drawing.Point(47, 47);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(319, 31);
            this.tbSearch.TabIndex = 7;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.Location = new System.Drawing.Point(47, 112);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.Size = new System.Drawing.Size(937, 369);
            this.dgvCustomers.TabIndex = 13;
            // 
            // CustomerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.tbSearch);
            this.Name = "CustomerManage";
            this.Size = new System.Drawing.Size(1030, 500);
            this.Load += new System.EventHandler(this.CustomerManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEditCustomer;
        private Button btnDeleteCustomer;
        private Button btnAddCustomer;
        private PictureBox picBox;
        private TextBox tbSearch;
        private DataGridView dgvCustomers;
    }
}
