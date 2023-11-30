using System.Drawing;
using System.Windows.Forms;

namespace Midterm.GUI.CarOrder
{
    partial class Car
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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.tbTotalMoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLoaiXe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_speedWarning = new System.Windows.Forms.CheckBox();
            this.cb_reversingCamera = new System.Windows.Forms.CheckBox();
            this.cb_camera360 = new System.Windows.Forms.CheckBox();
            this.cb_spareTire = new System.Windows.Forms.CheckBox();
            this.cb_GPS = new System.Windows.Forms.CheckBox();
            this.cb_collisionSensor = new System.Windows.Forms.CheckBox();
            this.cb_cameraJourney = new System.Windows.Forms.CheckBox();
            this.cb_bluetooth = new System.Windows.Forms.CheckBox();
            this.cb_trunkLid = new System.Windows.Forms.CheckBox();
            this.cb_USB = new System.Windows.Forms.CheckBox();
            this.cb_carWindows = new System.Windows.Forms.CheckBox();
            this.cb_tireSensor = new System.Windows.Forms.CheckBox();
            this.cb_curbsideCamera = new System.Windows.Forms.CheckBox();
            this.cb_Map = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbXang = new System.Windows.Forms.RadioButton();
            this.rdbDau = new System.Windows.Forms.RadioButton();
            this.rdbDien = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbStartPoint = new System.Windows.Forms.ComboBox();
            this.cbEndPoint = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(497, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 21);
            this.label10.TabIndex = 61;
            this.label10.Text = "Nhiên liệu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(497, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 59;
            this.label11.Text = "Tính năng:";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbAddress.Location = new System.Drawing.Point(167, 320);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(301, 29);
            this.tbAddress.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(23, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Địa chỉ:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPhoneNumber.Location = new System.Drawing.Point(167, 260);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(301, 29);
            this.tbPhoneNumber.TabIndex = 56;
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(23, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Số điện thoại: ";
            // 
            // tbFullName
            // 
            this.tbFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbFullName.Location = new System.Drawing.Point(167, 200);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(301, 29);
            this.tbFullName.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(23, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 21);
            this.label9.TabIndex = 53;
            this.label9.Text = "Tên khách hàng: ";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewOrder.Location = new System.Drawing.Point(401, 568);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(194, 43);
            this.btnNewOrder.TabIndex = 52;
            this.btnNewOrder.Text = "Tạo đơn mới";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbTotalMoney
            // 
            this.tbTotalMoney.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTotalMoney.Location = new System.Drawing.Point(440, 512);
            this.tbTotalMoney.Name = "tbTotalMoney";
            this.tbTotalMoney.Size = new System.Drawing.Size(301, 29);
            this.tbTotalMoney.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(296, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 50;
            this.label6.Text = "Giá tiền thuê:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(497, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Ngày trả:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker2.Location = new System.Drawing.Point(648, 381);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(301, 29);
            this.dateTimePicker2.TabIndex = 48;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Ngày thuê:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 380);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 29);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(23, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Hãng xe: ";
            // 
            // tbLoaiXe
            // 
            this.tbLoaiXe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbLoaiXe.Location = new System.Drawing.Point(167, 20);
            this.tbLoaiXe.Name = "tbLoaiXe";
            this.tbLoaiXe.Size = new System.Drawing.Size(301, 29);
            this.tbLoaiXe.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Loại xe: ";
            // 
            // cb_speedWarning
            // 
            this.cb_speedWarning.AutoSize = true;
            this.cb_speedWarning.Location = new System.Drawing.Point(801, 197);
            this.cb_speedWarning.Name = "cb_speedWarning";
            this.cb_speedWarning.Size = new System.Drawing.Size(106, 17);
            this.cb_speedWarning.TabIndex = 79;
            this.cb_speedWarning.Text = "Cảnh báo tốc độ";
            this.cb_speedWarning.UseVisualStyleBackColor = true;
            // 
            // cb_reversingCamera
            // 
            this.cb_reversingCamera.AutoSize = true;
            this.cb_reversingCamera.Location = new System.Drawing.Point(801, 167);
            this.cb_reversingCamera.Name = "cb_reversingCamera";
            this.cb_reversingCamera.Size = new System.Drawing.Size(75, 17);
            this.cb_reversingCamera.TabIndex = 78;
            this.cb_reversingCamera.Text = "Camera lùi";
            this.cb_reversingCamera.UseVisualStyleBackColor = true;
            // 
            // cb_camera360
            // 
            this.cb_camera360.AutoSize = true;
            this.cb_camera360.Location = new System.Drawing.Point(801, 137);
            this.cb_camera360.Name = "cb_camera360";
            this.cb_camera360.Size = new System.Drawing.Size(83, 17);
            this.cb_camera360.TabIndex = 76;
            this.cb_camera360.Text = "Camera 360";
            this.cb_camera360.UseVisualStyleBackColor = true;
            // 
            // cb_spareTire
            // 
            this.cb_spareTire.AutoSize = true;
            this.cb_spareTire.Location = new System.Drawing.Point(801, 107);
            this.cb_spareTire.Name = "cb_spareTire";
            this.cb_spareTire.Size = new System.Drawing.Size(92, 17);
            this.cb_spareTire.TabIndex = 77;
            this.cb_spareTire.Text = "Lốp dự phòng";
            this.cb_spareTire.UseVisualStyleBackColor = true;
            // 
            // cb_GPS
            // 
            this.cb_GPS.AutoSize = true;
            this.cb_GPS.Location = new System.Drawing.Point(801, 77);
            this.cb_GPS.Name = "cb_GPS";
            this.cb_GPS.Size = new System.Drawing.Size(84, 17);
            this.cb_GPS.TabIndex = 75;
            this.cb_GPS.Text = "Định vị GPS";
            this.cb_GPS.UseVisualStyleBackColor = true;
            // 
            // cb_collisionSensor
            // 
            this.cb_collisionSensor.AutoSize = true;
            this.cb_collisionSensor.Location = new System.Drawing.Point(801, 47);
            this.cb_collisionSensor.Name = "cb_collisionSensor";
            this.cb_collisionSensor.Size = new System.Drawing.Size(114, 17);
            this.cb_collisionSensor.TabIndex = 74;
            this.cb_collisionSensor.Text = "Cảm biến va chạm";
            this.cb_collisionSensor.UseVisualStyleBackColor = true;
            // 
            // cb_cameraJourney
            // 
            this.cb_cameraJourney.AutoSize = true;
            this.cb_cameraJourney.Location = new System.Drawing.Point(801, 17);
            this.cb_cameraJourney.Name = "cb_cameraJourney";
            this.cb_cameraJourney.Size = new System.Drawing.Size(112, 17);
            this.cb_cameraJourney.TabIndex = 73;
            this.cb_cameraJourney.Text = "Camera hành trình";
            this.cb_cameraJourney.UseVisualStyleBackColor = true;
            // 
            // cb_bluetooth
            // 
            this.cb_bluetooth.AutoSize = true;
            this.cb_bluetooth.Location = new System.Drawing.Point(648, 197);
            this.cb_bluetooth.Name = "cb_bluetooth";
            this.cb_bluetooth.Size = new System.Drawing.Size(71, 17);
            this.cb_bluetooth.TabIndex = 72;
            this.cb_bluetooth.Text = "Bluetooth";
            this.cb_bluetooth.UseVisualStyleBackColor = true;
            // 
            // cb_trunkLid
            // 
            this.cb_trunkLid.AutoSize = true;
            this.cb_trunkLid.Location = new System.Drawing.Point(648, 167);
            this.cb_trunkLid.Name = "cb_trunkLid";
            this.cb_trunkLid.Size = new System.Drawing.Size(125, 17);
            this.cb_trunkLid.TabIndex = 71;
            this.cb_trunkLid.Text = "Nắp thùng xe bán tải";
            this.cb_trunkLid.UseVisualStyleBackColor = true;
            // 
            // cb_USB
            // 
            this.cb_USB.AutoSize = true;
            this.cb_USB.Location = new System.Drawing.Point(648, 137);
            this.cb_USB.Name = "cb_USB";
            this.cb_USB.Size = new System.Drawing.Size(93, 17);
            this.cb_USB.TabIndex = 69;
            this.cb_USB.Text = "Khe cắm USB";
            this.cb_USB.UseVisualStyleBackColor = true;
            // 
            // cb_carWindows
            // 
            this.cb_carWindows.AutoSize = true;
            this.cb_carWindows.Location = new System.Drawing.Point(648, 107);
            this.cb_carWindows.Name = "cb_carWindows";
            this.cb_carWindows.Size = new System.Drawing.Size(76, 17);
            this.cb_carWindows.TabIndex = 70;
            this.cb_carWindows.Text = "Cửa sổ trời";
            this.cb_carWindows.UseVisualStyleBackColor = true;
            // 
            // cb_tireSensor
            // 
            this.cb_tireSensor.AutoSize = true;
            this.cb_tireSensor.Location = new System.Drawing.Point(648, 77);
            this.cb_tireSensor.Name = "cb_tireSensor";
            this.cb_tireSensor.Size = new System.Drawing.Size(87, 17);
            this.cb_tireSensor.TabIndex = 68;
            this.cb_tireSensor.Text = "Cảm biến lốp";
            this.cb_tireSensor.UseVisualStyleBackColor = true;
            // 
            // cb_curbsideCamera
            // 
            this.cb_curbsideCamera.AutoSize = true;
            this.cb_curbsideCamera.Location = new System.Drawing.Point(648, 47);
            this.cb_curbsideCamera.Name = "cb_curbsideCamera";
            this.cb_curbsideCamera.Size = new System.Drawing.Size(94, 17);
            this.cb_curbsideCamera.TabIndex = 67;
            this.cb_curbsideCamera.Text = "Camera cập lề";
            this.cb_curbsideCamera.UseVisualStyleBackColor = true;
            // 
            // cb_Map
            // 
            this.cb_Map.AutoSize = true;
            this.cb_Map.Location = new System.Drawing.Point(648, 17);
            this.cb_Map.Name = "cb_Map";
            this.cb_Map.Size = new System.Drawing.Size(61, 17);
            this.cb_Map.TabIndex = 66;
            this.cb_Map.Text = "Bản đồ";
            this.cb_Map.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbXang);
            this.groupBox1.Controls.Add(this.rdbDau);
            this.groupBox1.Controls.Add(this.rdbDien);
            this.groupBox1.Controls.Add(this.rdbAll);
            this.groupBox1.Location = new System.Drawing.Point(651, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 97);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            // 
            // rdbXang
            // 
            this.rdbXang.AutoSize = true;
            this.rdbXang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbXang.Location = new System.Drawing.Point(133, 19);
            this.rdbXang.Name = "rdbXang";
            this.rdbXang.Size = new System.Drawing.Size(50, 17);
            this.rdbXang.TabIndex = 37;
            this.rdbXang.TabStop = true;
            this.rdbXang.Text = "Xăng";
            this.rdbXang.UseVisualStyleBackColor = true;
            // 
            // rdbDau
            // 
            this.rdbDau.AutoSize = true;
            this.rdbDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbDau.Location = new System.Drawing.Point(6, 57);
            this.rdbDau.Name = "rdbDau";
            this.rdbDau.Size = new System.Drawing.Size(77, 17);
            this.rdbDau.TabIndex = 38;
            this.rdbDau.TabStop = true;
            this.rdbDau.Text = "Dầu Diesel";
            this.rdbDau.UseVisualStyleBackColor = true;
            // 
            // rdbDien
            // 
            this.rdbDien.AutoSize = true;
            this.rdbDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbDien.Location = new System.Drawing.Point(136, 57);
            this.rdbDien.Name = "rdbDien";
            this.rdbDien.Size = new System.Drawing.Size(47, 17);
            this.rdbDien.TabIndex = 39;
            this.rdbDien.TabStop = true;
            this.rdbDien.Text = "Điện";
            this.rdbDien.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbAll.Location = new System.Drawing.Point(8, 19);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(56, 17);
            this.rdbAll.TabIndex = 36;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "Tất cả";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 81;
            this.label2.Text = "Tên xe: ";
            // 
            // cbBrand
            // 
            this.cbBrand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(167, 72);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(301, 29);
            this.cbBrand.TabIndex = 82;
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.cbBrand_SelectedIndexChanged);
            // 
            // cbName
            // 
            this.cbName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(167, 137);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(301, 29);
            this.cbName.TabIndex = 83;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(23, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 84;
            this.label12.Text = "Điểm đi:";
            // 
            // cbStartPoint
            // 
            this.cbStartPoint.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbStartPoint.FormattingEnabled = true;
            this.cbStartPoint.Location = new System.Drawing.Point(167, 444);
            this.cbStartPoint.Name = "cbStartPoint";
            this.cbStartPoint.Size = new System.Drawing.Size(301, 29);
            this.cbStartPoint.TabIndex = 85;
            // 
            // cbEndPoint
            // 
            this.cbEndPoint.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbEndPoint.FormattingEnabled = true;
            this.cbEndPoint.Location = new System.Drawing.Point(639, 444);
            this.cbEndPoint.Name = "cbEndPoint";
            this.cbEndPoint.Size = new System.Drawing.Size(301, 29);
            this.cbEndPoint.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(497, 447);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 21);
            this.label13.TabIndex = 86;
            this.label13.Text = "Điểm đến:";
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 627);
            this.Controls.Add(this.cbEndPoint);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbStartPoint);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.tbTotalMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLoaiXe);
            this.Controls.Add(this.label1);
            this.Name = "Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCar";
            this.Load += new System.EventHandler(this.Car_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label10;
        private Label label11;
        private TextBox tbAddress;
        private Label label7;
        private TextBox tbPhoneNumber;
        private Label label8;
        private TextBox tbFullName;
        private Label label9;
        private Button btnNewOrder;
        private TextBox tbTotalMoney;
        private Label label6;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox tbLoaiXe;
        private Label label1;
        private CheckBox cb_speedWarning;
        private CheckBox cb_reversingCamera;
        private CheckBox cb_camera360;
        private CheckBox cb_spareTire;
        private CheckBox cb_GPS;
        private CheckBox cb_collisionSensor;
        private CheckBox cb_cameraJourney;
        private CheckBox cb_bluetooth;
        private CheckBox cb_trunkLid;
        private CheckBox cb_USB;
        private CheckBox cb_carWindows;
        private CheckBox cb_tireSensor;
        private CheckBox cb_curbsideCamera;
        private CheckBox cb_Map;
        private GroupBox groupBox1;
        private RadioButton rdbXang;
        private RadioButton rdbDau;
        private RadioButton rdbDien;
        private RadioButton rdbAll;
        private Label label2;
        private ComboBox cbBrand;
        private ComboBox cbName;
        private Label label12;
        private ComboBox cbStartPoint;
        private ComboBox cbEndPoint;
        private Label label13;
    }
}