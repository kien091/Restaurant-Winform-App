create database Restaurant
use Restaurant

create table Account(
	ID_Account varchar(7) primary key,
	firstName nvarchar(50),
	lastName nvarchar(50),
	dateOfBirth date,
	gender varchar(7),
	phoneNumber varchar(15),
	email varchar(50),
	password varchar(100),
	role int
)
create table Passenger(
	ID_Account varchar(7) primary key,
	Note varchar(10),
	foreign key (ID_Account) references Account(ID_Account)
)
create table Employee(
	ID_Account varchar(7) primary key,
	address nvarchar(100),
	postition varchar(30),
	salary int,
	dayStart date,
	foreign key (ID_Account) references Account(ID_Account)
)
create table iTable(
	ID_Table varchar(3) primary key,
	numSeat int,
	note varchar(50)
	ID_Booking varchar(10) foreign key
)
create table Booking(
	ID_Booking varchar(10) primary key,
	ID_Table varchar(3),
	numPerson int,
	time datetime,
	note varchar(50),
	ID_Account varchar(7) foreign key references Account(ID_Account)
)

go
create function autoID() 
returns char(7) 
as 
begin 
	declare @lastID char(7) 
	set @lastID = (select max(ID_Account) from Account) 
	if @lastID is null set @lastID = 'P000000' 
	declare @i int 
	set @i = right(@lastID,6) + 1 
	return 'P' + right('000000' + convert(varchar(10),@i),6)
end

alter table Account
add constraint DF_autoID default dbo.autoID() for ID_Account

go
create function autoID_Booking() 
returns char(10) 
as 
begin 
	declare @lastID_Booking char(10) 
	set @lastID_Booking= (select max(ID_Booking) from Booking) 
	if @lastID_Booking is null set @lastID_Booking = 'Bk00000000' 
	declare @i int 
	set @i = right(@lastID_Booking,8) + 1 
	return 'Bk' + right('00000000' + convert(varchar(10),@i),8)
end

alter table Booking
add constraint DF_autoID_Booking default dbo.autoID_Booking() for ID_Booking

select * from Booking
