RAISERROR('Creating POS database....',0,1)
SET NOCOUNT ON
GO

USE [master];
GO

DROP DATABASE IF EXISTS POS
GO

CREATE DATABASE POS
GO

USE POS;
GO

create table Category (
	ID int identity(1,1) primary key,
	name nvarchar(100),
	status bit
)

create table Item (
	ID int identity(1,1) primary key,
	name nvarchar(100),
	description nvarchar(255),
	price decimal(10,3),
	status BIT DEFAULT 1,
	category_id int
)

create table Schedule (
	ID int identity(1,1) primary key,
	time_start int,
	time_end int, 
	date nvarchar(50),
	status bit
)

create table Role (
	ID int identity(1,1) primary key,
	role_name nvarchar(50)
)

create table Account(
	ID int identity(1,1) primary key,
	username nvarchar(30),
	password nvarchar(30),
	fullname nvarchar(500),
	date_of_birth datetime,
	description nvarchar(500),
	salary int,
	hourly_wage int,
	role_id int,
	status bit
)

create table AccountSchedule (
	account_id int,
	schedule_id int,
	primary key(account_id, schedule_id)
)

create table Status (
	ID int identity(1,1) primary key,
	status nvarchar(50)
)

create table Orders(
	ID int identity(1,1) primary key,
	employee_id int, 
	status_id int,
	total_money decimal(10),
	date datetime
)

create table OrderDetails(
	ID int identity(1,1) primary key,
	order_id int, 
	item_id int,
	quantity int,
	note nvarchar(100)

)

alter table Item 
	add foreign key (category_id) references Category(ID)
alter table Account 
	add foreign key (role_id) references Role(ID)
alter table AccountSchedule 
	add foreign key (account_id) references Account(ID),
		foreign key (schedule_id) references Schedule(ID)
alter table Orders
	add foreign key (employee_id) references Account(ID),
		foreign key (status_id) references Status(ID)
alter table OrderDetails 
	add foreign key (order_id) references Orders(ID),
		foreign key (item_id) references Item(ID)

INSERT INTO Category (name, status) VALUES
(N'Cà phê', 1),
(N'Nước ngọt', 1),
(N'Trà', 1),
(N'Tráng miệng', 1)

INSERT INTO Item (name, description, price, status, category_id) VALUES
(N'Cà phê đen', N'Cà phê đen thật sự', 25000, 1, 1),
(N'Cà phê sữa', N'Cà phê sữa thật sự', 30000, 1, 1),
(N'Coca Cola', N'Nước ngọt có ga vị coca cola', 20000, 1, 2),
(N'Pepsi', N'Nước ngọt có ga vị pepsi', 18000, 1, 2),
(N'Trà đào', N'Trà đào thật sự', 20000, 1, 3),
(N'Trà xanh', N'Trà xanh tươi', 20000, 1, 3),
(N'Bánh flan', N'Bánh flan trứng đường', 15000, 1, 4),
(N'Chè bột lọc', N'Chè bột lọc hạt sen', 25000, 1, 4)

INSERT INTO Schedule (time_start, time_end, date, status) VALUES
(8, 21, 'Monday', 1),
(8, 21, 'Tuesday', 1),
(8, 21, 'Wednesday', 1),
(8, 21, 'Thursday', 1),
(8, 21, 'Friday', 1),
(8, 21, 'Saturday', 1),
(8, 22, 'Sunday', 1)

INSERT INTO Role (role_name) VALUES
('Manager'),
('Employee')

INSERT INTO Account (username, password, fullname, date_of_birth, description, role_id, status) VALUES
('employe01', '123',N'Nguyễn Văn An', '1990-01-01', N'Nhân viên quán', 2, 1),
('employe02', '123',N'Trần Thị Bích', '1988-12-31', N'Nhân viên quán', 2, 1),
('manager01', '123',N'Lê Quốc Cường', '1995-06-10', N'Quản trị viên hệ thống', 1, 1)

INSERT INTO AccountSchedule (account_id, schedule_id) VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(2, 1),
(2, 2),
(2, 3),
(2, 4),
(3, 1),
(3, 2),
(3, 3),
(3, 4)

INSERT INTO Status (status) VALUES
('Đang chờ'),
('Đã thanh toán'),
('Hủy đơn hàng')

INSERT INTO Orders (employee_id, status_id, total_money, date) VALUES
(1, 1, 50000, '2023-06-10 09:30:00'),
(1, 2, 60000, '2023-06-10 14:15:00'),
(1, 1, 30000, '2023-06-11 10:45:00'),
(1, 3, 25000, '2023-06-11 18:20:00')

INSERT INTO OrderDetails (order_id, item_id, quantity, note) VALUES
(1, 1, 2, N''),
(2, 2, 2, N''),
(2, 4, 1, N''),
(3, 5, 1, N''),
(3, 6, 1, N''),
(4, 1, 1, N''),
(4, 7, 2, N'')

SET NOCOUNT OFF
raiserror('The POS database in now ready for use.',0,1)
GO