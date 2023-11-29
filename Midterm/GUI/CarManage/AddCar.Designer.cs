using System.Drawing;
using System.Windows.Forms;
namespace Midterm.GUI.CarManage
{
    partial class AddCar
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
            this.tbHangXe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLoaiXe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRental = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.rdbDien = new System.Windows.Forms.RadioButton();
            this.rdbDau = new System.Windows.Forms.RadioButton();
            this.rdbXang = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Map = new System.Windows.Forms.CheckBox();
            this.cb_curbsideCamera = new System.Windows.Forms.CheckBox();
            this.cb_tireSensor = new System.Windows.Forms.CheckBox();
            this.cb_carWindows = new System.Windows.Forms.CheckBox();
            this.cb_USB = new System.Windows.Forms.CheckBox();
            this.cb_trunkLid = new System.Windows.Forms.CheckBox();
            this.cb_bluetooth = new System.Windows.Forms.CheckBox();
            this.cb_speedWarning = new System.Windows.Forms.CheckBox();
            this.cb_reversingCamera = new System.Windows.Forms.CheckBox();
            this.cb_camera360 = new System.Windows.Forms.CheckBox();
            this.cb_spareTire = new System.Windows.Forms.CheckBox();
            this.cb_GPS = new System.Windows.Forms.CheckBox();
            this.cb_collisionSensor = new System.Windows.Forms.CheckBox();
            this.cb_cameraJourney = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHangXe
            // 
            this.tbHangXe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbHangXe.Location = new System.Drawing.Point(171, 135);
            this.tbHangXe.Name = "tbHangXe";
            this.tbHangXe.Size = new System.Drawing.Size(301, 29);
            this.tbHangXe.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hãng xe: ";
            // 
            // tbTenXe
            // 
            this.tbTenXe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTenXe.Location = new System.Drawing.Point(171, 85);
            this.tbTenXe.Name = "tbTenXe";
            this.tbTenXe.Size = new System.Drawing.Size(301, 29);
            this.tbTenXe.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên xe: ";
            // 
            // tbLoaiXe
            // 
            this.tbLoaiXe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbLoaiXe.Location = new System.Drawing.Point(171, 33);
            this.tbLoaiXe.Name = "tbLoaiXe";
            this.tbLoaiXe.Size = new System.Drawing.Size(301, 29);
            this.tbLoaiXe.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Loại xe: ";
            // 
            // tbRental
            // 
            this.tbRental.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbRental.Location = new System.Drawing.Point(377, 296);
            this.tbRental.Name = "tbRental";
            this.tbRental.Size = new System.Drawing.Size(301, 29);
            this.tbRental.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(233, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Giá tiền thuê:";
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAddCar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCar.Location = new System.Drawing.Point(397, 344);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(194, 43);
            this.btnAddCar.TabIndex = 26;
            this.btnAddCar.Text = "Thêm xe";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // rdbDien
            // 
            this.rdbDien.AutoSize = true;
            this.rdbDien.Location = new System.Drawing.Point(133, 73);
            this.rdbDien.Name = "rdbDien";
            this.rdbDien.Size = new System.Drawing.Size(47, 17);
            this.rdbDien.TabIndex = 39;
            this.rdbDien.TabStop = true;
            this.rdbDien.Text = "Điện";
            this.rdbDien.UseVisualStyleBackColor = true;
            // 
            // rdbDau
            // 
            this.rdbDau.AutoSize = true;
            this.rdbDau.Location = new System.Drawing.Point(8, 73);
            this.rdbDau.Name = "rdbDau";
            this.rdbDau.Size = new System.Drawing.Size(77, 17);
            this.rdbDau.TabIndex = 38;
            this.rdbDau.TabStop = true;
            this.rdbDau.Text = "Dầu Diesel";
            this.rdbDau.UseVisualStyleBackColor = true;
            // 
            // rdbXang
            // 
            this.rdbXang.AutoSize = true;
            this.rdbXang.Location = new System.Drawing.Point(133, 19);
            this.rdbXang.Name = "rdbXang";
            this.rdbXang.Size = new System.Drawing.Size(50, 17);
            this.rdbXang.TabIndex = 37;
            this.rdbXang.TabStop = true;
            this.rdbXang.Text = "Xăng";
            this.rdbXang.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(8, 19);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(56, 17);
            this.rdbAll.TabIndex = 36;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "Tất cả";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(26, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "Nhiên liệu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(517, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tính năng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbXang);
            this.groupBox1.Controls.Add(this.rdbDau);
            this.groupBox1.Controls.Add(this.rdbDien);
            this.groupBox1.Controls.Add(this.rdbAll);
            this.groupBox1.Location = new System.Drawing.Point(171, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // cb_Map
            // 
            this.cb_Map.AutoSize = true;
            this.cb_Map.Location = new System.Drawing.Point(639, 30);
            this.cb_Map.Name = "cb_Map";
            this.cb_Map.Size = new System.Drawing.Size(61, 17);
            this.cb_Map.TabIndex = 41;
            this.cb_Map.Text = "Bản đồ";
            this.cb_Map.UseVisualStyleBackColor = true;
            // 
            // cb_curbsideCamera
            // 
            this.cb_curbsideCamera.AutoSize = true;
            this.cb_curbsideCamera.Location = new System.Drawing.Point(639, 60);
            this.cb_curbsideCamera.Name = "cb_curbsideCamera";
            this.cb_curbsideCamera.Size = new System.Drawing.Size(94, 17);
            this.cb_curbsideCamera.TabIndex = 42;
            this.cb_curbsideCamera.Text = "Camera cập lề";
            this.cb_curbsideCamera.UseVisualStyleBackColor = true;
            // 
            // cb_tireSensor
            // 
            this.cb_tireSensor.AutoSize = true;
            this.cb_tireSensor.Location = new System.Drawing.Point(639, 90);
            this.cb_tireSensor.Name = "cb_tireSensor";
            this.cb_tireSensor.Size = new System.Drawing.Size(87, 17);
            this.cb_tireSensor.TabIndex = 43;
            this.cb_tireSensor.Text = "Cảm biến lốp";
            this.cb_tireSensor.UseVisualStyleBackColor = true;
            // 
            // cb_carWindows
            // 
            this.cb_carWindows.AutoSize = true;
            this.cb_carWindows.Location = new System.Drawing.Point(639, 120);
            this.cb_carWindows.Name = "cb_carWindows";
            this.cb_carWindows.Size = new System.Drawing.Size(76, 17);
            this.cb_carWindows.TabIndex = 44;
            this.cb_carWindows.Text = "Cửa sổ trời";
            this.cb_carWindows.UseVisualStyleBackColor = true;
            // 
            // cb_USB
            // 
            this.cb_USB.AutoSize = true;
            this.cb_USB.Location = new System.Drawing.Point(639, 150);
            this.cb_USB.Name = "cb_USB";
            this.cb_USB.Size = new System.Drawing.Size(93, 17);
            this.cb_USB.TabIndex = 44;
            this.cb_USB.Text = "Khe cắm USB";
            this.cb_USB.UseVisualStyleBackColor = true;
            // 
            // cb_trunkLid
            // 
            this.cb_trunkLid.AutoSize = true;
            this.cb_trunkLid.Location = new System.Drawing.Point(639, 180);
            this.cb_trunkLid.Name = "cb_trunkLid";
            this.cb_trunkLid.Size = new System.Drawing.Size(125, 17);
            this.cb_trunkLid.TabIndex = 45;
            this.cb_trunkLid.Text = "Nắp thùng xe bán tải";
            this.cb_trunkLid.UseVisualStyleBackColor = true;
            // 
            // cb_bluetooth
            // 
            this.cb_bluetooth.AutoSize = true;
            this.cb_bluetooth.Location = new System.Drawing.Point(639, 210);
            this.cb_bluetooth.Name = "cb_bluetooth";
            this.cb_bluetooth.Size = new System.Drawing.Size(71, 17);
            this.cb_bluetooth.TabIndex = 46;
            this.cb_bluetooth.Text = "Bluetooth";
            this.cb_bluetooth.UseVisualStyleBackColor = true;
            // 
            // cb_speedWarning
            // 
            this.cb_speedWarning.AutoSize = true;
            this.cb_speedWarning.Location = new System.Drawing.Point(792, 210);
            this.cb_speedWarning.Name = "cb_speedWarning";
            this.cb_speedWarning.Size = new System.Drawing.Size(106, 17);
            this.cb_speedWarning.TabIndex = 53;
            this.cb_speedWarning.Text = "Cảnh báo tốc độ";
            this.cb_speedWarning.UseVisualStyleBackColor = true;
            // 
            // cb_reversingCamera
            // 
            this.cb_reversingCamera.AutoSize = true;
            this.cb_reversingCamera.Location = new System.Drawing.Point(792, 180);
            this.cb_reversingCamera.Name = "cb_reversingCamera";
            this.cb_reversingCamera.Size = new System.Drawing.Size(75, 17);
            this.cb_reversingCamera.TabIndex = 52;
            this.cb_reversingCamera.Text = "Camera lùi";
            this.cb_reversingCamera.UseVisualStyleBackColor = true;
            // 
            // cb_camera360
            // 
            this.cb_camera360.AutoSize = true;
            this.cb_camera360.Location = new System.Drawing.Point(792, 150);
            this.cb_camera360.Name = "cb_camera360";
            this.cb_camera360.Size = new System.Drawing.Size(83, 17);
            this.cb_camera360.TabIndex = 50;
            this.cb_camera360.Text = "Camera 360";
            this.cb_camera360.UseVisualStyleBackColor = true;
            // 
            // cb_spareTire
            // 
            this.cb_spareTire.AutoSize = true;
            this.cb_spareTire.Location = new System.Drawing.Point(792, 120);
            this.cb_spareTire.Name = "cb_spareTire";
            this.cb_spareTire.Size = new System.Drawing.Size(92, 17);
            this.cb_spareTire.TabIndex = 51;
            this.cb_spareTire.Text = "Lốp dự phòng";
            this.cb_spareTire.UseVisualStyleBackColor = true;
            // 
            // cb_GPS
            // 
            this.cb_GPS.AutoSize = true;
            this.cb_GPS.Location = new System.Drawing.Point(792, 90);
            this.cb_GPS.Name = "cb_GPS";
            this.cb_GPS.Size = new System.Drawing.Size(84, 17);
            this.cb_GPS.TabIndex = 49;
            this.cb_GPS.Text = "Định vị GPS";
            this.cb_GPS.UseVisualStyleBackColor = true;
            // 
            // cb_collisionSensor
            // 
            this.cb_collisionSensor.AutoSize = true;
            this.cb_collisionSensor.Location = new System.Drawing.Point(792, 60);
            this.cb_collisionSensor.Name = "cb_collisionSensor";
            this.cb_collisionSensor.Size = new System.Drawing.Size(114, 17);
            this.cb_collisionSensor.TabIndex = 48;
            this.cb_collisionSensor.Text = "Cảm biến va chạm";
            this.cb_collisionSensor.UseVisualStyleBackColor = true;
            // 
            // cb_cameraJourney
            // 
            this.cb_cameraJourney.AutoSize = true;
            this.cb_cameraJourney.Location = new System.Drawing.Point(792, 30);
            this.cb_cameraJourney.Name = "cb_cameraJourney";
            this.cb_cameraJourney.Size = new System.Drawing.Size(112, 17);
            this.cb_cameraJourney.TabIndex = 47;
            this.cb_cameraJourney.Text = "Camera hành trình";
            this.cb_cameraJourney.UseVisualStyleBackColor = true;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 399);
            this.Controls.Add(this.cb_speedWarning);
            this.Controls.Add(this.cb_reversingCamera);
            this.Controls.Add(this.cb_camera360);
            this.Controls.Add(this.cb_spareTire);
            this.Controls.Add(this.cb_GPS);
            this.Controls.Add(this.cb_collisionSensor);
            this.Controls.Add(this.cb_cameraJourney);
            this.Controls.Add(this.cb_bluetooth);
            this.Controls.Add(this.cb_trunkLid);
            this.Controls.Add(this.cb_USB);
            this.Controls.Add(this.cb_carWindows);
            this.Controls.Add(this.cb_tireSensor);
            this.Controls.Add(this.cb_curbsideCamera);
            this.Controls.Add(this.cb_Map);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.tbRental);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHangXe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTenXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLoaiXe);
            this.Controls.Add(this.label1);
            this.Name = "AddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add car";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbHangXe;
        private Label label5;
        private TextBox tbTenXe;
        private Label label2;
        private TextBox tbLoaiXe;
        private Label label1;
        private TextBox tbRental;
        private Label label6;
        private Button btnAddCar;
        private RadioButton rdbDien;
        private RadioButton rdbDau;
        private RadioButton rdbXang;
        private RadioButton rdbAll;
        private Label label10;
        private Label label11;
        private GroupBox groupBox1;
        private CheckBox cb_Map;
        private CheckBox cb_curbsideCamera;
        private CheckBox cb_tireSensor;
        private CheckBox cb_carWindows;
        private CheckBox cb_USB;
        private CheckBox cb_trunkLid;
        private CheckBox cb_bluetooth;
        private CheckBox cb_speedWarning;
        private CheckBox cb_reversingCamera;
        private CheckBox cb_camera360;
        private CheckBox cb_spareTire;
        private CheckBox cb_GPS;
        private CheckBox cb_collisionSensor;
        private CheckBox cb_cameraJourney;
    }
}