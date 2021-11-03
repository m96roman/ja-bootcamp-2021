CREATE TABLE CarBrand(
    ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Name varchar(50) NOT NULL
);

CREATE TABLE CarModel(
    ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    BrandId int FOREIGN KEY REFERENCES CarBrand(ID),
	Name varchar(50) NOT NULL,
	MaxSpeed int NOT NULL
);

CREATE TABLE Car(
	ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	ModelId int FOREIGN KEY REFERENCES CarModel(ID)
);

CREATE TABLE Trip(
	ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	CarId int FOREIGN KEY REFERENCES Car(ID),
	Distance int NOT NULL,
	StartDate DateTime,
	EndDate DateTime
);

INSERT INTO CarBrand
VALUES ('Volvo'),('Mazda'),('Lexus'),('Citroen'),('Skoda'),('VW')


SELECT * From CarBrand
Join CarModel on BrandId = CarBrand.ID
Join Car on ModelId = CarModel.ID
Join Trip on CarId = Car.ID

select * from Trip

INSERT INTO Trip
VALUES (1, 0, null, null)