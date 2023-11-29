using System.Drawing;
using System.Windows.Forms;
namespace Midterm.GUI.ScheduleManage
{
    partial class BillRental
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
            this.tbfullName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.btnPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbHangXe
            // 
            this.tbHangXe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbHangXe.Location = new System.Drawing.Point(159, 166);
            this.tbHangXe.Name = "tbHangXe";
            this.tbHangXe.Size = new System.Drawing.Size(301, 29);
            this.tbHangXe.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(14, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hãng xe: ";
            // 
            // tbTenXe
            // 
            this.tbTenXe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTenXe.Location = new System.Drawing.Point(159, 116);
            this.tbTenXe.Name = "tbTenXe";
            this.tbTenXe.Size = new System.Drawing.Size(301, 29);
            this.tbTenXe.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên xe: ";
            // 
            // tbLoaiXe
            // 
            this.tbLoaiXe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbLoaiXe.Location = new System.Drawing.Point(159, 64);
            this.tbLoaiXe.Name = "tbLoaiXe";
            this.tbLoaiXe.Size = new System.Drawing.Size(301, 29);
            this.tbLoaiXe.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Loại xe: ";
            // 
            // tbfullName
            // 
            this.tbfullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbfullName.Location = new System.Drawing.Point(159, 19);
            this.tbfullName.Name = "tbfullName";
            this.tbfullName.Size = new System.Drawing.Size(301, 29);
            this.tbfullName.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(14, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tên khách hàng: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(15, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "Tính năng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tổng thanh toán:";
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbTotalMoney.ForeColor = System.Drawing.Color.Red;
            this.lbTotalMoney.Location = new System.Drawing.Point(205, 536);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(131, 28);
            this.lbTotalMoney.TabIndex = 38;
            this.lbTotalMoney.Text = "10.000.000đ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(18, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "Ngày trả:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker2.Location = new System.Drawing.Point(160, 476);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(301, 29);
            this.dateTimePicker2.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 51;
            this.label7.Text = "Ngày thuê:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 426);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 29);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // cb_speedWarning
            // 
            this.cb_speedWarning.AutoSize = true;
            this.cb_speedWarning.Location = new System.Drawing.Point(313, 397);
            this.cb_speedWarning.Name = "cb_speedWarning";
            this.cb_speedWarning.Size = new System.Drawing.Size(106, 17);
            this.cb_speedWarning.TabIndex = 93;
            this.cb_speedWarning.Text = "Cảnh báo tốc độ";
            this.cb_speedWarning.UseVisualStyleBackColor = true;
            // 
            // cb_reversingCamera
            // 
            this.cb_reversingCamera.AutoSize = true;
            this.cb_reversingCamera.Location = new System.Drawing.Point(313, 367);
            this.cb_reversingCamera.Name = "cb_reversingCamera";
            this.cb_reversingCamera.Size = new System.Drawing.Size(75, 17);
            this.cb_reversingCamera.TabIndex = 92;
            this.cb_reversingCamera.Text = "Camera lùi";
            this.cb_reversingCamera.UseVisualStyleBackColor = true;
            // 
            // cb_camera360
            // 
            this.cb_camera360.AutoSize = true;
            this.cb_camera360.Location = new System.Drawing.Point(313, 337);
            this.cb_camera360.Name = "cb_camera360";
            this.cb_camera360.Size = new System.Drawing.Size(83, 17);
            this.cb_camera360.TabIndex = 90;
            this.cb_camera360.Text = "Camera 360";
            this.cb_camera360.UseVisualStyleBackColor = true;
            // 
            // cb_spareTire
            // 
            this.cb_spareTire.AutoSize = true;
            this.cb_spareTire.Location = new System.Drawing.Point(313, 307);
            this.cb_spareTire.Name = "cb_spareTire";
            this.cb_spareTire.Size = new System.Drawing.Size(92, 17);
            this.cb_spareTire.TabIndex = 91;
            this.cb_spareTire.Text = "Lốp dự phòng";
            this.cb_spareTire.UseVisualStyleBackColor = true;
            // 
            // cb_GPS
            // 
            this.cb_GPS.AutoSize = true;
            this.cb_GPS.Location = new System.Drawing.Point(313, 277);
            this.cb_GPS.Name = "cb_GPS";
            this.cb_GPS.Size = new System.Drawing.Size(84, 17);
            this.cb_GPS.TabIndex = 89;
            this.cb_GPS.Text = "Định vị GPS";
            this.cb_GPS.UseVisualStyleBackColor = true;
            // 
            // cb_collisionSensor
            // 
            this.cb_collisionSensor.AutoSize = true;
            this.cb_collisionSensor.Location = new System.Drawing.Point(313, 247);
            this.cb_collisionSensor.Name = "cb_collisionSensor";
            this.cb_collisionSensor.Size = new System.Drawing.Size(114, 17);
            this.cb_collisionSensor.TabIndex = 88;
            this.cb_collisionSensor.Text = "Cảm biến va chạm";
            this.cb_collisionSensor.UseVisualStyleBackColor = true;
            // 
            // cb_cameraJourney
            // 
            this.cb_cameraJourney.AutoSize = true;
            this.cb_cameraJourney.Location = new System.Drawing.Point(313, 217);
            this.cb_cameraJourney.Name = "cb_cameraJourney";
            this.cb_cameraJourney.Size = new System.Drawing.Size(112, 17);
            this.cb_cameraJourney.TabIndex = 87;
            this.cb_cameraJourney.Text = "Camera hành trình";
            this.cb_cameraJourney.UseVisualStyleBackColor = true;
            // 
            // cb_bluetooth
            // 
            this.cb_bluetooth.AutoSize = true;
            this.cb_bluetooth.Location = new System.Drawing.Point(160, 397);
            this.cb_bluetooth.Name = "cb_bluetooth";
            this.cb_bluetooth.Size = new System.Drawing.Size(71, 17);
            this.cb_bluetooth.TabIndex = 86;
            this.cb_bluetooth.Text = "Bluetooth";
            this.cb_bluetooth.UseVisualStyleBackColor = true;
            // 
            // cb_trunkLid
            // 
            this.cb_trunkLid.AutoSize = true;
            this.cb_trunkLid.Location = new System.Drawing.Point(160, 367);
            this.cb_trunkLid.Name = "cb_trunkLid";
            this.cb_trunkLid.Size = new System.Drawing.Size(125, 17);
            this.cb_trunkLid.TabIndex = 85;
            this.cb_trunkLid.Text = "Nắp thùng xe bán tải";
            this.cb_trunkLid.UseVisualStyleBackColor = true;
            // 
            // cb_USB
            // 
            this.cb_USB.AutoSize = true;
            this.cb_USB.Location = new System.Drawing.Point(160, 337);
            this.cb_USB.Name = "cb_USB";
            this.cb_USB.Size = new System.Drawing.Size(93, 17);
            this.cb_USB.TabIndex = 84;
            this.cb_USB.Text = "Khe cắm USB";
            this.cb_USB.UseVisualStyleBackColor = true;
            // 
            // cb_carWindows
            // 
            this.cb_carWindows.AutoSize = true;
            this.cb_carWindows.Location = new System.Drawing.Point(160, 307);
            this.cb_carWindows.Name = "cb_carWindows";
            this.cb_carWindows.Size = new System.Drawing.Size(76, 17);
            this.cb_carWindows.TabIndex = 83;
            this.cb_carWindows.Text = "Cửa sổ trời";
            this.cb_carWindows.UseVisualStyleBackColor = true;
            // 
            // cb_tireSensor
            // 
            this.cb_tireSensor.AutoSize = true;
            this.cb_tireSensor.Location = new System.Drawing.Point(160, 277);
            this.cb_tireSensor.Name = "cb_tireSensor";
            this.cb_tireSensor.Size = new System.Drawing.Size(87, 17);
            this.cb_tireSensor.TabIndex = 82;
            this.cb_tireSensor.Text = "Cảm biến lốp";
            this.cb_tireSensor.UseVisualStyleBackColor = true;
            // 
            // cb_curbsideCamera
            // 
            this.cb_curbsideCamera.AutoSize = true;
            this.cb_curbsideCamera.Location = new System.Drawing.Point(160, 247);
            this.cb_curbsideCamera.Name = "cb_curbsideCamera";
            this.cb_curbsideCamera.Size = new System.Drawing.Size(94, 17);
            this.cb_curbsideCamera.TabIndex = 81;
            this.cb_curbsideCamera.Text = "Camera cập lề";
            this.cb_curbsideCamera.UseVisualStyleBackColor = true;
            // 
            // cb_Map
            // 
            this.cb_Map.AutoSize = true;
            this.cb_Map.Location = new System.Drawing.Point(160, 217);
            this.cb_Map.Name = "cb_Map";
            this.cb_Map.Size = new System.Drawing.Size(61, 17);
            this.cb_Map.TabIndex = 80;
            this.cb_Map.Text = "Bản đồ";
            this.cb_Map.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnPayment.ForeColor = System.Drawing.Color.Transparent;
            this.btnPayment.Location = new System.Drawing.Point(145, 591);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(166, 43);
            this.btnPayment.TabIndex = 94;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // BillRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 646);
            this.Controls.Add(this.btnPayment);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbfullName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbHangXe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTenXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLoaiXe);
            this.Controls.Add(this.label1);
            this.Name = "BillRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillRental";
            this.Load += new System.EventHandler(this.BillRental_Load);
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
        private TextBox tbfullName;
        private Label label9;
        private Label label11;
        private Label label3;
        private Label lbTotalMoney;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private DateTimePicker dateTimePicker1;
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
        private Button btnPayment;
    }
}