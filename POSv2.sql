use master;
GO
drop database POS;
GO
create database POS;
GO
use POS;
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
	status bit,
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
(N'N??c ng?t', 1),
(N'Trà', 1),
(N'Tráng mi?ng', 1)

INSERT INTO Item (name, description, price, status, category_id) VALUES
(N'Cà phê ?en', N'Cà phê ?en th?t s?', 25000, 1, 1),
(N'Cà phê s?a', N'Cà phê s?a th?t s?', 30000, 1, 1),
(N'Coca Cola', N'N??c ng?t có ga v? coca cola', 20000, 1, 2),
(N'Pepsi', N'N??c ng?t có ga v? pepsi', 18000, 1, 2),
(N'Trà ?ào', N'Trà ?ào th?t s?', 20000, 1, 3),
(N'Trà xanh', N'Trà xanh t??i', 20000, 1, 3),
(N'Bánh flan', N'Bánh flan tr?ng ???ng', 15000, 1, 4),
(N'Chè b?t l?c', N'Chè b?t l?c h?t sen', 25000, 1, 4)

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
('employe01', '123',N'Nguy?n V?n An', '1990-01-01', N'Nhân viên quán', 2, 1),
('employe02', '123',N'Tr?n Th? Bích', '1988-12-31', N'Nhân viên quán', 2, 1),
('manager01', '123',N'Lê Qu?c C??ng', '1995-06-10', N'Qu?n tr? viên h? th?ng', 1, 1)

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
('?ang ch?'),
('?ã thanh toán'),
('Hu? ??n hàng')

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