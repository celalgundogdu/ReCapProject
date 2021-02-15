Create Table Cars(
	CarId int primary key identity(1,1),
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
    Descriptions nvarchar(25)
	foreign key (BrandId) references Colors(ColorId),
	foreign key (ColorId) references Brands(BrandId)
)

Create Table Colors(
	ColorId int primary key identity(1,1),
	ColorName nvarchar(25)
)

Create Table Brands(
	BrandId int primary key identity(1,1),
	BrandName nvarchar(25)
)

Insert into Cars(BrandId, ColorId, ModelYear, DailyPrice, Descriptions)
values
	('3', '1', '2015', '150', 'Megane'),
	('3', '3', '2017', '250', 'A3'),
	('1', '2', '2020', '350', 'Caddy'),
	('2', '1', '2015', '150', 'Yaris'),
	('4', '3', '2016', '200', 'Leon');

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
