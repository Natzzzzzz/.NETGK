namespace Midterm.GUI.CarManage
{
    partial class CarDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarDetail));
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCar
            // 
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Location = new System.Drawing.Point(21, 116);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.RowTemplate.Height = 25;
            this.dgvCar.Size = new System.Drawing.Size(937, 369);
            this.dgvCar.TabIndex = 25;
            // 
            // btnEditCar
            // 
            this.btnEditCar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditCar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnEditCar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditCar.Location = new System.Drawing.Point(809, 44);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(149, 42);
            this.btnEditCar.TabIndex = 24;
            this.btnEditCar.Text = "Sửa";
            this.btnEditCar.UseVisualStyleBackColor = false;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteCar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCar.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteCar.Location = new System.Drawing.Point(649, 44);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(149, 42);
            this.btnDeleteCar.TabIndex = 23;
            this.btnDeleteCar.Text = "Xóa";
            this.btnDeleteCar.UseVisualStyleBackColor = false;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAddCar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCar.Location = new System.Drawing.Point(486, 44);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(149, 42);
            this.btnAddCar.TabIndex = 22;
            this.btnAddCar.Text = "Thêm";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(296, 55);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(40, 23);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 21;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbSearch.Location = new System.Drawing.Point(21, 51);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(319, 31);
            this.tbSearch.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(17, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 21);
            this.label11.TabIndex = 34;
            this.label11.Text = "Tìm kiếm theo tên:";
            // 
            // CarDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 513);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.tbSearch);
            this.Name = "CarDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarDetail";
            this.Load += new System.EventHandler(this.CarDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label11;
    }
}