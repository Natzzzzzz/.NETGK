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
EXEC InsertCar 'Mini Cooper1', 'Mini', 'Mini', N'Xăng', N'Cho thuê', 340, 'Có', 'Không', 'Không', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'Mini Cooper2', 'Mini', 'Mini', N'Xăng', N'Cho thuê', 340, 'Có', 'Không', 'Không', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'Mini Cooper3', 'Mini', 'Mini', N'Xăng', N'Cho thuê', 370, 'Có', 'Không', 'Không', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'Sedan1', 'Sedan', 'BrandA', N'Xăng', N'Cho thuê', 340, 'Có', 'Không', 'Có', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có';
EXEC InsertCar 'Sedan2', 'Sedan', 'BrandB', N'Dầu', 'Cho thuê', 340, 'Có', 'Không', 'Không', 'Có', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không';
EXEC InsertCar 'Sedan3', 'Sedan', 'BrandC', N'Xăng', N'Cho thuê', 370, 'Có', 'Không', 'Không', 'Có', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'Hatchback1', 'Hatchback', 'BrandX', N'Điện', N'Cho thuê', 340, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không';
EXEC InsertCar 'Hatchback2', 'Hatchback', 'BrandY', N'Điện', N'Cho thuê', 340, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không';
EXEC InsertCar 'Hatchback3', 'Hatchback', 'BrandZ', N'Điện', 'Cho thuê', 370, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không';
EXEC InsertCar 'CUV1', 'CUV', 'BrandP', N'Xăng', 'Cho thuê', 340, 'Có', 'Có', 'Có', 'Có', 'Có', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có';
EXEC InsertCar 'CUV2', 'CUV', 'BrandQ', N'Dầu', 'Cho thuê', 340, 'Có', 'Có', 'Không', 'Có', 'Có', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có';
EXEC InsertCar 'CUV3', 'CUV', 'BrandR', N'Xăng', 'Cho thuê', 370, 'Có', 'Có', 'Không', 'Có', 'Có', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có';
EXEC InsertCar 'SUV1', 'SUV', 'BrandS', N'Điện', 'Cho thuê', 340, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'SUV2', 'SUV', 'BrandT', N'Điện', 'Cho thuê', 340, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'SUV3', 'SUV', 'BrandU', N'Điện', 'Cho thuê', 370, 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'MPV1', 'MPV', 'BrandV', N'Xăng', 'Cho thuê', 340, 'Có', 'Không', 'Có', 'Có', 'Không', 'Có', 'Có', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'Bán tải 1', 'Bán tải', 'Bán tải A', N'Dầu', 'Cho thuê', 340, 'Có', 'Không', 'Có', 'Có', 'Không', 'Có', 'Có', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';
EXEC InsertCar 'Bán tải 2', 'Bán tải', 'Bán tải B', N'Dầu', 'Cho thuê', 340, 'Có', 'Không', 'Có', 'Có', 'Không', 'Có', 'Có', 'Có', 'Không', 'Có', 'Không', 'Có', 'Không', 'Không';

GO
DECLARE @Counter INT = 1;

WHILE @Counter <= 30
BEGIN
    DECLARE @CarName NVARCHAR(255) = N'Mini Cooper' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarCategory NVARCHAR(255) = N'Mini';
    DECLARE @CarBrand NVARCHAR(255) = N'Mini Brand ' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarFuel NVARCHAR(255) = N'Xăng';
    DECLARE @CarStatus NVARCHAR(255) = N'Trống';
    DECLARE @CarRental FLOAT = 30.0;
    DECLARE @Map NVARCHAR(255) = N'Không';
    DECLARE @CurbsideCamera NVARCHAR(255) = N'Không';
    DECLARE @TireSensor NVARCHAR(255) = N'Không';
    DECLARE @CarWindows NVARCHAR(255) = N'Không';
    DECLARE @USB NVARCHAR(255) = N'Không';
    DECLARE @TrunkLid NVARCHAR(255) = N'Không';
    DECLARE @Bluetooth NVARCHAR(255) = N'Không';
    DECLARE @CameraJourney NVARCHAR(255) = N'Không';
    DECLARE @CollisionSensor NVARCHAR(255) = N'Không';
    DECLARE @GPS NVARCHAR(255) = N'Không';
    DECLARE @SpareTire NVARCHAR(255) = N'Không';
    DECLARE @Camera360 NVARCHAR(255) = N'Không';
    DECLARE @ReversingCamera NVARCHAR(255) = N'Không';
    DECLARE @SpeedWarning NVARCHAR(255) = N'Không';

    EXEC InsertCar @CarName, @CarCategory, @CarBrand, @CarFuel, @CarStatus, @CarRental, @Map, @CurbsideCamera, @TireSensor, @CarWindows, @USB, @TrunkLid, @Bluetooth, @CameraJourney, @CollisionSensor, @GPS, @SpareTire, @Camera360, @ReversingCamera, @SpeedWarning;

    SET @Counter = @Counter + 1;
END;
GO
DECLARE @Counter INT = 1;

SET @Counter = 1;

WHILE @Counter <= 10
BEGIN
    DECLARE @CarName NVARCHAR(255) = N'Sedan' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarCategory NVARCHAR(255) = N'Sedan';
    DECLARE @CarBrand NVARCHAR(255) = N'Sedan Brand' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarFuel NVARCHAR(255) = N'Xăng';
    DECLARE @CarStatus NVARCHAR(255) = N'Trống';
    DECLARE @CarRental FLOAT = 340.0;
    DECLARE @Map NVARCHAR(255) = N'Không';
    DECLARE @CurbsideCamera NVARCHAR(255) = N'Không';
    DECLARE @TireSensor NVARCHAR(255) = N'Không';
    DECLARE @CarWindows NVARCHAR(255) = N'Không';
    DECLARE @USB NVARCHAR(255) = N'Không';
    DECLARE @TrunkLid NVARCHAR(255) = N'Không';
    DECLARE @Bluetooth NVARCHAR(255) = N'Không';
    DECLARE @CameraJourney NVARCHAR(255) = N'Không';
    DECLARE @CollisionSensor NVARCHAR(255) = N'Không';
    DECLARE @GPS NVARCHAR(255) = N'Không';
    DECLARE @SpareTire NVARCHAR(255) = N'Không';
    DECLARE @Camera360 NVARCHAR(255) = N'Không';
    DECLARE @ReversingCamera NVARCHAR(255) = N'Không';
    DECLARE @SpeedWarning NVARCHAR(255) = N'Không';

    EXEC InsertCar @CarName, @CarCategory, @CarBrand, @CarFuel, @CarStatus, @CarRental, @Map, @CurbsideCamera, @TireSensor, @CarWindows, @USB, @TrunkLid, @Bluetooth, @CameraJourney, @CollisionSensor, @GPS, @SpareTire, @Camera360, @ReversingCamera, @SpeedWarning;

    SET @Counter = @Counter + 1;
END;
GO
DECLARE @Counter INT = 1;

WHILE @Counter <= 30
BEGIN
    DECLARE @CarName NVARCHAR(255) = N'Hatchback' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarCategory NVARCHAR(255) = N'Hatchback';
    DECLARE @CarBrand NVARCHAR(255) = N'Hatchback Brand' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarFuel NVARCHAR(255) = N'Điện';
    DECLARE @CarStatus NVARCHAR(255) = N'Trống';
    DECLARE @CarRental FLOAT = 340.0;
    DECLARE @Map NVARCHAR(255) = N'Không';
    DECLARE @CurbsideCamera NVARCHAR(255) = N'Không';
    DECLARE @TireSensor NVARCHAR(255) = N'Không';
    DECLARE @CarWindows NVARCHAR(255) = N'Không';
    DECLARE @USB NVARCHAR(255) = N'Không';
    DECLARE @TrunkLid NVARCHAR(255) = N'Không';
    DECLARE @Bluetooth NVARCHAR(255) = N'Không';
    DECLARE @CameraJourney NVARCHAR(255) = N'Không';
    DECLARE @CollisionSensor NVARCHAR(255) = N'Không';
    DECLARE @GPS NVARCHAR(255) = N'Không';
    DECLARE @SpareTire NVARCHAR(255) = N'Không';
    DECLARE @Camera360 NVARCHAR(255) = N'Không';
    DECLARE @ReversingCamera NVARCHAR(255) = N'Không';
    DECLARE @SpeedWarning NVARCHAR(255) = N'Không';

    EXEC InsertCar @CarName, @CarCategory, @CarBrand, @CarFuel, @CarStatus, @CarRental, @Map, @CurbsideCamera, @TireSensor, @CarWindows, @USB, @TrunkLid, @Bluetooth, @CameraJourney, @CollisionSensor, @GPS, @SpareTire, @Camera360, @ReversingCamera, @SpeedWarning;

    SET @Counter = @Counter + 1;
END;
GO
DECLARE @Counter INT = 1;

WHILE @Counter <= 30
BEGIN
    DECLARE @CarName NVARCHAR(255) = N'SUV' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarCategory NVARCHAR(255) = N'SUV';
    DECLARE @CarBrand NVARCHAR(255) = N'SUV Brand' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarFuel NVARCHAR(255) = N'Xăng';
    DECLARE @CarStatus NVARCHAR(255) = N'Trống';
    DECLARE @CarRental FLOAT = 300.0;
    DECLARE @Map NVARCHAR(255) = N'Có';
    DECLARE @CurbsideCamera NVARCHAR(255) = N'Không';
    DECLARE @TireSensor NVARCHAR(255) = N'Không';
    DECLARE @CarWindows NVARCHAR(255) = N'Có';
    DECLARE @USB NVARCHAR(255) = N'Không';
    DECLARE @TrunkLid NVARCHAR(255) = N'Không';
    DECLARE @Bluetooth NVARCHAR(255) = N'Không';
    DECLARE @CameraJourney NVARCHAR(255) = N'Không';
    DECLARE @CollisionSensor NVARCHAR(255) = N'Không';
    DECLARE @GPS NVARCHAR(255) = N'Không';
    DECLARE @SpareTire NVARCHAR(255) = N'Không';
    DECLARE @Camera360 NVARCHAR(255) = N'Không';
    DECLARE @ReversingCamera NVARCHAR(255) = N'Không';
    DECLARE @SpeedWarning NVARCHAR(255) = N'Không';

    EXEC InsertCar @CarName, @CarCategory, @CarBrand, @CarFuel, @CarStatus, @CarRental, @Map, @CurbsideCamera, @TireSensor, @CarWindows, @USB, @TrunkLid, @Bluetooth, @CameraJourney, @CollisionSensor, @GPS, @SpareTire, @Camera360, @ReversingCamera, @SpeedWarning;

    SET @Counter = @Counter + 1;
END;
GO
DECLARE @Counter INT = 1;

WHILE @Counter <= 30
BEGIN
    DECLARE @CarName NVARCHAR(255) = N'CUV ' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarCategory NVARCHAR(255) = N'CUV';
    DECLARE @CarBrand NVARCHAR(255) = N'CUV Brand' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarFuel NVARCHAR(255) = N'Tất cả';
    DECLARE @CarStatus NVARCHAR(255) = N'Trống';
    DECLARE @CarRental FLOAT = 340.0;
    DECLARE @Map NVARCHAR(255) = N'Không';
    DECLARE @CurbsideCamera NVARCHAR(255) = N'Không';
    DECLARE @TireSensor NVARCHAR(255) = N'Không';
    DECLARE @CarWindows NVARCHAR(255) = N'Không';
    DECLARE @USB NVARCHAR(255) = N'Không';
    DECLARE @TrunkLid NVARCHAR(255) = N'Không';
    DECLARE @Bluetooth NVARCHAR(255) = N'Không';
    DECLARE @CameraJourney NVARCHAR(255) = N'Không';
    DECLARE @CollisionSensor NVARCHAR(255) = N'Không';
    DECLARE @GPS NVARCHAR(255) = N'Không';
    DECLARE @SpareTire NVARCHAR(255) = N'Không';
    DECLARE @Camera360 NVARCHAR(255) = N'Không';
    DECLARE @ReversingCamera NVARCHAR(255) = N'Không';
    DECLARE @SpeedWarning NVARCHAR(255) = N'Không';

    EXEC InsertCar @CarName, @CarCategory, @CarBrand, @CarFuel, @CarStatus, @CarRental, @Map, @CurbsideCamera, @TireSensor, @CarWindows, @USB, @TrunkLid, @Bluetooth, @CameraJourney, @CollisionSensor, @GPS, @SpareTire, @Camera360, @ReversingCamera, @SpeedWarning;

    SET @Counter = @Counter + 1;
END;
GO
DECLARE @Counter INT = 1;

WHILE @Counter <= 30
BEGIN
    DECLARE @CarName NVARCHAR(255) = N'MPV ' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarCategory NVARCHAR(255) = N'MPV';
    DECLARE @CarBrand NVARCHAR(255) = N'MPV Brand' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarFuel NVARCHAR(255) = N'Dầu';
    DECLARE @CarStatus NVARCHAR(255) = N'Trống';
    DECLARE @CarRental FLOAT = 340.0;
    DECLARE @Map NVARCHAR(255) = N'Không';
    DECLARE @CurbsideCamera NVARCHAR(255) = N'Không';
    DECLARE @TireSensor NVARCHAR(255) = N'Không';
    DECLARE @CarWindows NVARCHAR(255) = N'Không';
    DECLARE @USB NVARCHAR(255) = N'Không';
    DECLARE @TrunkLid NVARCHAR(255) = N'Không';
    DECLARE @Bluetooth NVARCHAR(255) = N'Không';
    DECLARE @CameraJourney NVARCHAR(255) = N'Không';
    DECLARE @CollisionSensor NVARCHAR(255) = N'Không';
    DECLARE @GPS NVARCHAR(255) = N'Không';
    DECLARE @SpareTire NVARCHAR(255) = N'Không';
    DECLARE @Camera360 NVARCHAR(255) = N'Không';
    DECLARE @ReversingCamera NVARCHAR(255) = N'Không';
    DECLARE @SpeedWarning NVARCHAR(255) = N'Không';

    EXEC InsertCar @CarName, @CarCategory, @CarBrand, @CarFuel, @CarStatus, @CarRental, @Map, @CurbsideCamera, @TireSensor, @CarWindows, @USB, @TrunkLid, @Bluetooth, @CameraJourney, @CollisionSensor, @GPS, @SpareTire, @Camera360, @ReversingCamera, @SpeedWarning;

    SET @Counter = @Counter + 1;
END;

GO
DECLARE @Counter INT = 1;

WHILE @Counter <= 30
BEGIN
    DECLARE @CarName NVARCHAR(255) = N'Bán tải ' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarCategory NVARCHAR(255) = N'Bán tải';
    DECLARE @CarBrand NVARCHAR(255) = N'Bản tải ' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @CarFuel NVARCHAR(255) = N'Dầu';
    DECLARE @CarStatus NVARCHAR(255) = N'Trống';
    DECLARE @CarRental FLOAT = 340.0;
    DECLARE @Map NVARCHAR(255) = N'Không';
    DECLARE @CurbsideCamera NVARCHAR(255) = N'Không';
    DECLARE @TireSensor NVARCHAR(255) = N'Không';
    DECLARE @CarWindows NVARCHAR(255) = N'Không';
    DECLARE @USB NVARCHAR(255) = N'Không';
    DECLARE @TrunkLid NVARCHAR(255) = N'Không';
    DECLARE @Bluetooth NVARCHAR(255) = N'Không';
    DECLARE @CameraJourney NVARCHAR(255) = N'Không';
    DECLARE @CollisionSensor NVARCHAR(255) = N'Không';
    DECLARE @GPS NVARCHAR(255) = N'Không';
    DECLARE @SpareTire NVARCHAR(255) = N'Không';
    DECLARE @Camera360 NVARCHAR(255) = N'Không';
    DECLARE @ReversingCamera NVARCHAR(255) = N'Không';
    DECLARE @SpeedWarning NVARCHAR(255) = N'Không';

    EXEC InsertCar @CarName, @CarCategory, @CarBrand, @CarFuel, @CarStatus, @CarRental, @Map, @CurbsideCamera, @TireSensor, @CarWindows, @USB, @TrunkLid, @Bluetooth, @CameraJourney, @CollisionSensor, @GPS, @SpareTire, @Camera360, @ReversingCamera, @SpeedWarning;

    SET @Counter = @Counter + 1;
END;



GO
create table Accounts
(
	accountID nvarchar(10) primary key,
	fullName nvarchar(500),
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

GO
INSERT INTO Accounts (accountID, fullName, phoneNumber, address, username, password, role) VALUES 
('A00001', 'Admin User', '123456789', 'Admin Address', 'admin', 'admin', 'admin');
GO
EXEC InsertStaff N'Staff User 1', '987654322', 'Staff Address 1';
EXEC InsertStaff N'Staff User 2', '987654322', 'Staff Address 2';
EXEC InsertStaff N'Staff User 3', '987654323', 'Staff Address 3';
EXEC InsertStaff N'Staff User 4', '987654324', 'Staff Address 4';
GO
DECLARE @Counter INT = 1;

WHILE @Counter <= 20
BEGIN
    DECLARE @StaffName NVARCHAR(255) = 'Staff User ' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @PhoneNumber NVARCHAR(10) = '98765432' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @Address NVARCHAR(255) = 'Staff Address ' + CAST(@Counter AS NVARCHAR(2));

    EXEC InsertStaff @StaffName, @PhoneNumber, @Address;

    SET @Counter = @Counter + 1;
END;
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
GO
DECLARE @Counter INT = 1;
WHILE @Counter <= 50
BEGIN
    DECLARE @CustomerName NVARCHAR(255) = N'Khách Hàng ' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @PhoneNumber NVARCHAR(10) = '0369852147' + CAST(@Counter AS NVARCHAR(2));
    DECLARE @Address NVARCHAR(255) = N'Địa Chỉ ' + CAST(@Counter AS NVARCHAR(2)) + N', TP. Hồ Chí Minh';

    EXEC InsertCustomers @CustomerName, @PhoneNumber, @Address;

    SET @Counter = @Counter + 1;
END;


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

Go
-- Năm 2023

EXEC InsertHistory '2023-01-01 12:00:00', '2023-01-10 16:00:00', '2023-01-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 300.75, 'S00001', 'C00081', 'Cs00002';
EXEC InsertHistory '2023-01-05 12:00:00', '2023-01-10 16:00:00', '2023-01-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 300.75, 'S00001', 'C00089', 'Cs00002';
EXEC InsertHistory '2023-12-01 08:00:00', '2023-12-05 12:00:00', '2023-12-10 18:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 500.00, 'A00001', 'C00082', 'Cs00001';
EXEC InsertHistory '2023-12-02 10:00:00', '2023-12-11 14:00:00', '2023-12-15 20:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 750.50, 'S00002', 'C00083', 'Cs00002';
EXEC InsertHistory '2023-12-05 12:00:00', '2023-12-15 16:00:00', '2023-12-20 22:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 600.75, 'S00003', 'C00003', 'Cs00003';
EXEC InsertHistory '2023-12-01 08:00:00', '2023-12-05 12:00:00', '2023-12-10 18:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 500.00, 'A00001', 'C00006', 'Cs00001';
EXEC InsertHistory '2023-12-02 10:00:00', '2023-12-11 14:00:00', '2023-12-15 20:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 750.50, 'S00002', 'C00001', 'Cs00002';
EXEC InsertHistory '2023-12-05 12:00:00', '2023-12-15 16:00:00', '2023-12-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 600.75, 'S00003', 'C00003', 'Cs00003';
EXEC InsertHistory '2023-12-05 12:00:00', '2023-12-15 16:00:00', '2023-12-20 22:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 600.75, 'S00003', 'C00005', 'Cs00003';
EXEC InsertHistory '2023-12-05 12:00:00', '2023-12-15 16:00:00', '2023-12-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 600.75, 'S00003', 'C00009', 'Cs00003';
EXEC InsertHistory '2023-01-05 12:00:00', '2023-01-10 16:00:00', '2023-01-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 300.75, 'S00003', 'C00180', 'Cs00002';
EXEC InsertHistory '2023-01-01 12:00:00', '2023-01-10 16:00:00', '2023-01-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 300.75, 'S00003', 'C00049', 'Cs00002';
EXEC InsertHistory '2023-02-05 12:00:00', '2023-02-10 16:00:00', '2023-02-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 400.50, 'S00002', 'C00150', 'Cs00003';
EXEC InsertHistory '2023-03-01 08:00:00', '2023-03-05 12:00:00', '2023-03-10 18:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 500.00, 'A00001', 'C00126', 'Cs00001';
EXEC InsertHistory '2023-04-02 10:00:00', '2023-04-11 14:00:00', '2023-04-15 20:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 600.75, 'S00002', 'C00001', 'Cs00002';
EXEC InsertHistory '2023-05-05 12:00:00', '2023-05-15 16:00:00', '2023-05-20 22:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 700.25, 'S00003', 'C00003', 'Cs00003';
EXEC InsertHistory '2023-06-01 12:00:00', '2023-06-10 16:00:00', '2023-06-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 300.75, 'S00005', 'C00009', 'Cs00002';
EXEC InsertHistory '2023-07-05 12:00:00', '2023-07-10 16:00:00', '2023-07-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 400.50, 'S00002', 'C00160', 'Cs00003';
EXEC InsertHistory '2023-08-01 08:00:00', '2023-08-05 12:00:00', '2023-08-10 18:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 500.00, 'A00001', 'C00162', 'Cs00001';
EXEC InsertHistory '2023-09-02 10:00:00', '2023-09-11 14:00:00', '2023-09-15 20:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 600.75, 'S00002', 'C00001', 'Cs00002';
EXEC InsertHistory '2023-10-05 12:00:00', '2023-10-15 16:00:00', '2023-10-20 22:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 700.25, 'S00003', 'C00003', 'Cs00003';
EXEC InsertHistory '2023-01-01 12:00:00', '2023-01-10 16:00:00', '2023-01-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 300.75, 'S00003', 'C00031', 'Cs00002';
EXEC InsertHistory '2023-02-05 12:00:00', '2023-02-10 16:00:00', '2023-02-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 400.50, 'S00002', 'C00032', 'Cs00003';
EXEC InsertHistory '2023-03-01 08:00:00', '2023-03-05 12:00:00', '2023-03-10 18:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 500.00, 'A00001', 'C00018', 'Cs00001';
EXEC InsertHistory '2023-04-02 10:00:00', '2023-04-11 14:00:00', '2023-04-15 20:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 600.75, 'S00002', 'C00017', 'Cs00002';
EXEC InsertHistory '2023-05-05 12:00:00', '2023-05-15 16:00:00', '2023-05-20 22:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 700.25, 'S00003', 'C00016', 'Cs00003';
EXEC InsertHistory '2023-06-01 08:00:00', '2023-06-05 12:00:00', '2023-06-10 18:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 800.00, 'A00001', 'C00015', 'Cs00001';
EXEC InsertHistory '2023-07-02 10:00:00', '2023-07-11 14:00:00', '2023-07-15 20:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 900.50, 'S00003', 'C00014', 'Cs00002';
EXEC InsertHistory '2023-08-05 12:00:00', '2023-08-15 16:00:00', '2023-08-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 1000.75, 'S00007', 'C00013', 'Cs00003';
EXEC InsertHistory '2023-09-01 08:00:00', '2023-09-05 12:00:00', '2023-09-10 18:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 1100.00, 'A00002', 'C00012', 'Cs00001';
GO
-- Năm 2022
EXEC InsertHistory '2022-11-01 08:00:00', '2022-11-05 12:00:00', '2022-11-10 18:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 800.50, 'A00001', 'C00002', 'Cs00001';
EXEC InsertHistory '2022-12-02 10:00:00', '2022-12-11 14:00:00', '2022-12-15 20:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 900.75, 'S00002', 'C00003', 'Cs00002';
EXEC InsertHistory '2022-01-05 12:00:00', '2022-01-15 16:00:00', '2022-01-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 1000.25, 'S00003', 'C00004', 'Cs00003';
EXEC InsertHistory '2022-02-01 08:00:00', '2022-02-05 12:00:00', '2022-02-10 18:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 1100.75, 'S00003', 'C00005', 'Cs00003';
EXEC InsertHistory '2022-03-02 10:00:00', '2022-03-11 14:00:00', '2022-03-15 20:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 1200.25, 'S00003', 'C00006', 'Cs00003';
EXEC InsertHistory '2022-06-01 08:00:00', '2022-06-05 12:00:00', '2022-06-10 18:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 800.50, 'A00001', 'C00007', 'Cs00001';
EXEC InsertHistory '2022-07-02 10:00:00', '2022-07-11 14:00:00', '2022-07-15 20:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 900.75, 'S00002', 'C00008', 'Cs00002';
EXEC InsertHistory '2022-08-05 12:00:00', '2022-08-15 16:00:00', '2022-08-20 22:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 1000.25, 'S00003', 'C00009', 'Cs00003';
EXEC InsertHistory '2022-09-01 08:00:00', '2022-09-05 12:00:00', '2022-09-10 18:00:00', N'Đã thanh toán', 'An Giang', 'An Giang', 1100.75, 'S00003', 'C00010', 'Cs00003';
EXEC InsertHistory '2022-10-02 10:00:00', '2022-10-11 14:00:00', '2022-10-15 20:00:00', N'Chưa thanh toán', 'An Giang', 'An Giang', 1200.25, 'S00003', 'C00011', 'Cs00003';



Go
Create table Province(
    provinceID int identity,
    provinceName nvarchar(500) unique,
	primary key(ProvinceID)
)
go
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