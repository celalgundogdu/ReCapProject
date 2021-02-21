Create Table Cars(
	CarId int primary key identity(1,1),
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
    Descriptions nvarchar(25),
	foreign key (BrandId) references Brands(BrandId),
	foreign key (ColorId) references Colors(ColorId)
)

Create Table Colors(
	ColorId int primary key identity(1,1),
	ColorName nvarchar(25)
)

Create Table Brands(
	BrandId int primary key identity(1,1),
	BrandName nvarchar(25)
)

Create Table Users(
    UserId int primary key identity(1,1),
    FirstName nvarchar(25),
    LastName nvarchar(25),
    Email nvarchar(50),
    Password nvarchar(25)
)

Create Table Customers(
    CustomerId int primary key identity(1,1),
    UserId int, 
    CompanyName nvarchar(50),
    foreign key (UserId) references Users(UserId)
)

Create Table Rentals(
    RentalId int primary key identity(1,1),
    CarId int,
    CustomerId int,
    RentDate datetime,
    ReturnDate datetime,
    foreign key (CarId) references Cars(CarId),
    foreign key (CustomerId) references Customers(CustomerId)
)

Insert into Cars(BrandId, ColorId, ModelYear, DailyPrice, Descriptions)
values
	('3', '1', '2015', '150', 'Megane Otomatik 90.000km'),
	('3', '3', '2017', '250', 'A3 Otomatik 50.000km'),
	('1', '2', '2020', '350', 'Caddy Manuel 20.000km'),
	('2', '1', '2015', '150', 'Yaris Manuel 70.000km'),
	('4', '3', '2016', '200', 'Leon Otomatik 100.000km');

Insert into Brands(BrandName)
values
	('Volkswagen'),
	('Toyota'),
	('Renault'),
	('Seat');

Insert into Colors(ColorName)
values
	('Siyah'),
	('Gri'),
	('Beyaz');

Select * from Cars
Select * from Brands
Select * from Colors
