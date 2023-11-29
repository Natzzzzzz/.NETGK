drop database if exists ProjectCSharpMidterm
go
create database ProjectCSharpMidterm
go
use ProjectCSharpMidterm
go

CREATE TABLE Cars
(
    carID NVARCHAR(10) PRIMARY KEY,
    carName NVARCHAR(500),
    carCategory NVARCHAR(500),
    carBrand NVARCHAR(500),
    carFuel NVARCHAR(500),
    carStatus NVARCHAR(500),
	carRental FLOAT,
    map NVARCHAR(500),
    curbsideCamera NVARCHAR(500),
    tireSensor NVARCHAR(500),
    carWindows NVARCHAR(500),
    USB NVARCHAR(500),
    trunkLid NVARCHAR(500),
    bluetooth NVARCHAR(500),
    cameraJourney NVARCHAR(500),
    collisionSensor NVARCHAR(500),
    GPS NVARCHAR(500),
    spareTire NVARCHAR(500),
    camera360 NVARCHAR(500),
    reversingCamera NVARCHAR(500),
    speedWarning NVARCHAR(500)
);

go
CREATE PROCEDURE InsertCar
    @carName NVARCHAR(500),
    @carCategory NVARCHAR(500),
    @carBrand NVARCHAR(500),
    @carFuel NVARCHAR(500),
    @carStatus NVARCHAR(500),
	@carRental FLOAT,
    @map NVARCHAR(500),
    @curbsideCamera NVARCHAR(500),
    @tireSensor NVARCHAR(500),
    @carWindows NVARCHAR(500),
    @USB NVARCHAR(500),
    @trunkLid NVARCHAR(500),
    @bluetooth NVARCHAR(500),
    @cameraJourney NVARCHAR(500),
    @collisionSensor NVARCHAR(500),
    @GPS NVARCHAR(500),
    @spareTire NVARCHAR(500),
    @camera360 NVARCHAR(500),
    @reversingCamera NVARCHAR(500),
    @speedWarning NVARCHAR(500)
AS
BEGIN
    DECLARE @newCarID NVARCHAR(10);

    -- Tìm giá trị lớn nhất của carID hiện tại
    SELECT @newCarID = ISNULL(MAX(CAST(SUBSTRING(carID, 2, LEN(carID) - 1) AS INT)), 0) + 1
    FROM Cars;

    -- Tạo giá trị mới cho carID
    SET @newCarID = 'C' + RIGHT('0000' + CAST(@newCarID AS NVARCHAR(5)), 5);

    -- Thêm dữ liệu mới vào bảng Cars
    INSERT INTO Cars (
		carID, carName, carCategory, carBrand, carFuel, carStatus, carRental, map, curbsideCamera, tireSensor, carWindows, USB, trunkLid, bluetooth, cameraJourney, collisionSensor, GPS, spareTire, camera360, reversingCamera, speedWarning
	)
	VALUES (@newCarID, @carName, @carCategory, @carBrand, @carFuel, @carStatus, @carRental, @map, @curbsideCamera, @tireSensor, @carWindows, @USB, @trunkLid, @bluetooth, @cameraJourney, @collisionSensor, @GPS, @spareTire, @camera360, @reversingCamera, @speedWarning);

END;
GO

EXEC InsertCar 'Mini Cooper1', 'Mini', 'Mini', N'Xăng', N'Trống', 340, 'Có', 'Không', 'Không', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'Mini Cooper2', 'Mini', 'Mini', N'Xăng', N'Trống', 340, 'Có', 'Không', 'Không', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'Mini Cooper3', 'Mini', 'Mini', N'Xăng', N'Trống', 370, 'Có', 'Không', 'Không', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'Sedan1', 'Sedan', 'BrandA', N'Xăng', N'Trống', 340, 'Có', 'Không', 'Có', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có';
EXEC InsertCar 'Sedan2', 'Sedan', 'BrandB', N'Dầu', 'Cho thuê', 340, 'Có', 'Không', 'Không', 'Có', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không';
EXEC InsertCar 'Sedan3', 'Sedan', 'BrandC', N'Xăng', N'Trống', 370, 'Có', 'Không', 'Không', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'Hatchback1', 'Hatchback', 'BrandX', N'Điện', N'Trống', 340, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không';
EXEC InsertCar 'Hatchback2', 'Hatchback', 'BrandY', N'Điện', N'Không', 340, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không';
EXEC InsertCar 'Hatchback3', 'Hatchback', 'BrandZ', N'Điện', 'Cho thuê', 370, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không';
EXEC InsertCar 'CUV1', 'CUV', 'BrandP', N'Xăng', 'Cho thuê', 340, 'Có', 'Có', 'Có', 'Có', 'Có', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có';
EXEC InsertCar 'CUV2', 'CUV', 'BrandQ', N'Dầu', 'Cho thuê', 340, 'Có', 'Có', 'Không', 'Có', 'Có', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có';
EXEC InsertCar 'CUV3', 'CUV', 'BrandR', N'Xăng', 'Có', 370, 'Có', 'Có', 'Không', 'Có', 'Có', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có';
EXEC InsertCar 'SUV1', 'SUV', 'BrandS', N'Điện', 'Có', 340, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'SUV2', 'SUV', 'BrandT', N'Điện', 'Không', 340, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'SUV3', 'SUV', 'BrandU', N'Điện', 'Có', 370, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'MPV1', 'MPV', 'BrandV', N'Xăng', 'Có', 340, 'Có', 'Không', 'Có', 'Có', 'Không', 'Có', 'Có', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'MPV2', 'MPV', 'BrandW', N'Dầu', 'Không', 340, 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không';
delete from Cars
delete from History

GO

create table Accounts
(
	accountID nvarchar(10) primary key,
	fullName nvarchar(500,
	phoneNumber nvarchar(500),
	address nvarchar(500),
	username nvarchar(500),
	password nvarchar(500),
	role nvarchar(500)
)
GO
CREATE PROCEDURE InsertStaff
    @fullName NVARCHAR(500),
    @phoneNumber NVARCHAR(500),
    @address NVARCHAR(500)
AS
BEGIN
    DECLARE @newStaffID NVARCHAR(10);
    DECLARE @newUsername NVARCHAR(50);
    DECLARE @newPassword NVARCHAR(50);

    SELECT @newStaffID = ISNULL(MAX(CAST(SUBSTRING(accountID, 2, LEN(accountID) - 1) AS INT)), 0) + 1
    FROM Accounts;

    SET @newUsername = 'staff' + RIGHT('00' + CAST(@newStaffID AS NVARCHAR(5)), 2);
    SET @newPassword = @newUsername;
    SET @newStaffID = 'S' + RIGHT('0000' + CAST(@newStaffID AS NVARCHAR(5)), 5);

    INSERT INTO Accounts (
        accountID, fullName, phoneNumber, address, username, password, role
    )
    VALUES (@newStaffID, @fullName, @phoneNumber, @address, @newUsername, @newPassword, 'staff');

END;

drop procedure dbo.InsertStaff
delete from Accounts

INSERT INTO Accounts (accountID, fullName, phoneNumber, address, username, password, role) VALUES 
('A00001', 'Admin User', '123456789', 'Admin Address', 'admin_user', 'admin_password', 'admin');

EXEC InsertStaff N'Staff User 1', '987654322', 'Staff Address 1';
EXEC InsertStaff N'Staff User 2', '987654322', 'Staff Address 2';
EXEC InsertStaff N'Staff User 3', '987654323', 'Staff Address 3';
EXEC InsertStaff N'Staff User 4', '987654324', 'Staff Address 4';

GO
create table Customers
(
	customerID nvarchar(10) primary key,
	fullName nvarchar(500),
	phoneNumber nvarchar(500),
	address nvarchar(500)
)

go
CREATE PROCEDURE InsertCustomers
    @fullName NVARCHAR(500),
    @phoneNumber NVARCHAR(500),
    @address NVARCHAR(500)
AS
BEGIN
    DECLARE @newCustomersID NVARCHAR(10);

    -- Tìm giá trị lớn nhất của accountID hiện tại
    SELECT @newCustomersID = ISNULL(MAX(CAST(SUBSTRING(customerID, 3, LEN(customerID) - 1) AS INT)), 0) + 1
    FROM Customers;

    -- Tạo giá trị mới cho customerID
    SET @newCustomersID = 'Cs' + RIGHT('0000' + CAST(@newCustomersID AS NVARCHAR(5)), 5);

    -- Thêm dữ liệu mới vào bảng Customers
    INSERT INTO Customers (
        customerID, fullName, phoneNumber, address
    )
    VALUES (@newCustomersID, @fullName, @phoneNumber, @address);

END;
DROP PROCEDURE dbo.InsertCustomers

GO
EXEC InsertCustomers N'Nguyễn Văn A', '02146241567', N'187A Lê Văn Lương, Xã Phước Kiển, Huyện Nhà Bè, TP. Hồ Chí Minh';
EXEC InsertCustomers N'Trần Thị B', '03654897521', N'42B Lê Thánh Tôn, Quận 1, TP. Hồ Chí Minh';
EXEC InsertCustomers N'Lê Văn C', '09874563214', N'15C Nguyễn Huệ, Quận 3, TP. Hồ Chí Minh';
EXEC InsertCustomers N'Phạm Thị D', '01234567890', N'99 Đinh Công Tráng, Quận 10, TP. Hồ Chí Minh';
EXEC InsertCustomers N'Trương Văn E', '09876543210', N'77 Lý Thường Kiệt, Quận 5, TP. Hồ Chí Minh';
EXEC InsertCustomers N'Đỗ Thị F', '03698521470', N'23 Nguyễn Du, Quận 1, TP. Hồ Chí Minh';
EXEC InsertCustomers N'Võ Văn G', '01234567891', N'55 Cách Mạng Tháng Tám, Quận 3, TP. Hồ Chí Minh';
EXEC InsertCustomers N'Hoàng Văn H', '09876543211', N'123 Bùi Thị Xuân, Quận 1, TP. Hồ Chí Minh';
EXEC InsertCustomers N'Ngô Thị I', '03698521472', N'321 Lê Lai, Quận 4, TP. Hồ Chí Minh';
EXEC InsertCustomers N'Lý Văn K', '01234567892', N'88 Nguyễn Trãi, Quận 5, TP. Hồ Chí Minh';

delete from Customers

GO
create table History
(
	historyID nvarchar(10) primary key,
	bookingDate datetime,
	startDate datetime,
	endDate datetime,
	paymentStatus nvarchar(500),
	totalMoney float,
	startPoint nvarchar(500),
	endPoint nvarchar(500),
	accountID nvarchar(10),
	carID nvarchar(10),
	customerID nvarchar(10),
	foreign key(accountID) references Accounts(accountID),
	foreign key(carID) references Cars(carID)
)
drop table History
go
CREATE PROCEDURE InsertHistory
    @bookingDate DATETIME,
    @startDate DATETIME,
    @endDate DATETIME,
    @paymentStatus NVARCHAR(500),
	@startPoint NVARCHAR(500),
	@endPoint NVARCHAR(500),
    @totalMoney FLOAT,
    @accountID NVARCHAR(10),
    @carID NVARCHAR(10),
    @customerID NVARCHAR(10)
AS
BEGIN
    DECLARE @newHistoryID NVARCHAR(10);

    SELECT @newHistoryID = ISNULL(MAX(CAST(SUBSTRING(historyID, 2, LEN(historyID) - 1) AS INT)), 0) + 1
    FROM History;
    SET @newHistoryID = 'H' + RIGHT('0000' + CAST(@newHistoryID AS NVARCHAR(5)), 5);

    INSERT INTO History (
        historyID, bookingDate, startDate, endDate, paymentStatus, startPoint, endPoint, totalMoney, accountID, carID, customerID
    )
    VALUES (@newHistoryID, @bookingDate, @startDate, @endDate, @paymentStatus, @startPoint, @endPoint, @totalMoney, @accountID, @carID, @customerID);

END;

drop procedure InsertHistory

EXEC InsertHistory '2023-12-01 08:00:00', '2023-12-05 12:00:00', '2023-12-10 18:00:00', 'Chưa thanh toán', 'An Giang', 'An Giang', 500.00, 'A00001', 'C00001', 'Cs00001';
EXEC InsertHistory '2023-12-02 10:00:00', '2023-12-11 14:00:00', '2023-12-15 20:00:00', 'Đã thanh toán', 'An Giang', 'An Giang', 750.50, 'S00002', 'C00001', 'Cs00002';
EXEC InsertHistory '2023-12-05 12:00:00', '2023-12-15 16:00:00', '2023-12-20 22:00:00', 'Chưa thanh toán', 'An Giang', 'An Giang', 600.75, 'S00003', 'C00003', 'Cs00003';
EXEC InsertHistory '2023-12-01 08:00:00', '2023-12-05 12:00:00', '2023-12-10 18:00:00', 'Đã thanh toán', 'An Giang', 'An Giang', 500.00, 'A00001', 'C00006', 'Cs00001';
EXEC InsertHistory '2023-12-02 10:00:00', '2023-12-11 14:00:00', '2023-12-15 20:00:00', 'Chưa thanh toán', 'An Giang', 'An Giang', 750.50, 'S00002', 'C00001', 'Cs00002';
EXEC InsertHistory '2023-12-05 12:00:00', '2023-12-15 16:00:00', '2023-12-20 22:00:00', 'Đã thanh toán', 'An Giang', 'An Giang', 600.75, 'S00003', 'C00003', 'Cs00003';
EXEC InsertHistory '2023-12-05 12:00:00', '2023-12-15 16:00:00', '2023-12-20 22:00:00', 'Chưa thanh toán', 'An Giang', 'An Giang', 600.75, 'S00003', 'C00005', 'Cs00003';
EXEC InsertHistory '2023-12-05 12:00:00', '2023-12-15 16:00:00', '2023-12-20 22:00:00', 'Đã thanh toán', 'An Giang', 'An Giang', 600.75, 'S00003', 'C00009', 'Cs00003';
delete from History

create table Schedule 
(
	scheduleID nvarchar(10) primary key,
	carID nvarchar(10),
	customerID nvarchar(10),
	historyID nvarchar(10),
	startDate datetime,
	endDate datetime,
	startPoint nvarchar(500),
	endPoint nvarchar(500),
	foreign key(carID) references Cars(carID),
	foreign key(customerID) references Customers(customerID),
)

Create table Province(
    provinceID int identity,
    provinceName nvarchar(500) unique,
	primary key(ProvinceID)
)
go
CREATE PROCEDURE InsertSchedule
    @carID NVARCHAR(10),
    @customerID NVARCHAR(10),
    @historyID NVARCHAR(10),
    @startDate DATETIME,
    @endDate DATETIME,
    @startPoint NVARCHAR(500),
    @endPoint NVARCHAR(500)
AS
BEGIN
    DECLARE @NewScheduleID NVARCHAR(10);

    -- Tìm giá trị lớn nhất hiện tại trong bảng Schedule
    SELECT @NewScheduleID = ISNULL(MAX(CAST(SUBSTRING(scheduleID, 2, LEN(scheduleID)) AS INT)), 0) + 1
    FROM Schedule;

    -- Định dạng lại scheduleID với độ dài 5 ký tự và thêm 'H' vào đầu
    SET @NewScheduleID = 'S' + RIGHT('0000' + CAST(@NewScheduleID AS NVARCHAR(5)), 5);

    -- Thêm bản ghi mới vào bảng Schedule với scheduleID được tạo
    INSERT INTO Schedule (scheduleID, carID, customerID, historyID, startDate, endDate, startPoint, endPoint)
    VALUES (@NewScheduleID, @carID, @customerID, @historyID, @startDate, @endDate, @startPoint, @endPoint);
END;
GO
EXEC InsertSchedule 'C00004', 'Cs00013', 'H00009', '2023-12-10 00:57:32.000', '2023-12-19 00:57:32.000', 'An Giang', 'An Giang'
delete from Schedule
drop procedure dbo.InsertSchedule
drop table Schedule
insert into Province(provinceName) values
(N'An Giang'),
(N'Bà Rịa-Vũng Tàu'),
(N'Bạc Liêu'),
(N'Bắc Kạn'),
(N'Bắc Giang'),
(N'Bắc Ninh'),
(N'Bến Tre'),
(N'Bình Dương'),
(N'Bình Định'),
(N'Bình Phước'),
(N'Bình Thuận'),
(N'Cà Mau'),
(N'Cao Bằng'),
(N'Cần Thơ'),
(N'Đà Nẵng'),
(N'Đắk Lắk'),
(N'Đắk Nông'),
(N'Điện Biên'),
(N'Đồng Nai'),
(N'Đồng Tháp'),
(N'Gia Lai'),
(N'Hà Giang'),
(N'Hà Nam'),
(N'Hà Nội'),
(N'Hà Tây'),
(N'Hà Tĩnh'),
(N'Hải Dương'),
(N'Hải Phòng'),
(N'Hòa Bình'),
(N'Hồ Chí Minh'),
(N'Hậu Giang'),
(N'Hưng Yên'),
(N'Khánh Hòa'),
(N'Kiên Giang'),
(N'Kon Tum'),
(N'Lai Châu'),
(N'Lào Cai'),
(N'Lạng Sơn'),
(N'Lâm Đồng'),
(N'Long An'),
(N'Nam Định'),
(N'Nghệ An'),
(N'Ninh Bình'),
(N'Ninh Thuận'),
(N'Phú Thọ'),
(N'Phú Yên'),
(N'Quảng Bình'),
(N'Quảng Nam'),
(N'Quảng Ngãi'),
(N'Quảng Ninh'),
(N'Quảng Trị'),
(N'Sóc Trăng'),
(N'Sơn La'),
(N'Tây Ninh'),
(N'Thái Bình'),
(N'Thái Nguyên'),
(N'Thanh Hóa'),
(N'Thừa Thiên – Huế'),
(N'Tiền Giang'),
(N'Trà Vinh'),
(N'Tuyên Quang'),
(N'Vĩnh Long'),
(N'Vĩnh Phúc'),
(N'Yên Bái')