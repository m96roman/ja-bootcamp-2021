USE BootcampTraining;

CREATE TABLE CarBrand(
ID INT NOT NULL Primary key IDENTITY(1,1),
Name VARCHAR(50) NOT NULL
);

CREATE TABLE CarModel(
ID INT NOT NULL  Primary key IDENTITY(1,1),
BrandId INT FOREIGN KEY REFERENCES CarBrand(ID),
Name VARCHAR(50) NOT NULL,
MaxSpeed INT NOT NULL
);

CREATE TABLE Car(
ID INT NOT NULL Primary key IDENTITY(1,1),
ModelId INT FOREIGN KEY REFERENCES CarModel(ID)
);

CREATE TABLE Trip(
ID INT NOT NULL Primary key IDENTITY(1,1),
CarId INT FOREIGN KEY REFERENCES Car(ID),
Distance INT NOT NULL CHECK (DISTANCE>0),
StartDate DATETIME NOT NULL,
EndDate DATETIME NOT NULL
);

ALTER TABLE CarModel ADD CONSTRAINT check_max_speed CHECK (MaxSpeed > 0 AND MaxSpeed<=220);
ALTER TABLE Trip DROP CONSTRAINT DISTANCE;
ALTER TABLE Trip ADD CONSTRAINT DISTANCE CHECK  (Distance >= 0);
alter table Trip
alter column StartDate DATETIME null
alter table Trip
alter column EndDate DATETIME null

DELETE FROM Trip;
DBCC CHECKIDENT ('Trip', RESEED, 0)
GO

DELETE FROM Car;
DBCC CHECKIDENT ('Car', RESEED, 0)
GO

INSERT INTO CarBrand(Name)
VALUES ('Chevrolet'),('Nissan'),('BMW'),('Fiat'),('Honda'),('Opel'),('Peugeaut'),('Renault'),('Subaru');

INSERT INTO CarModel (BrandId, Name, MaxSpeed)
VALUES (1, 'C40', 180),(2,'XC90',200),(3,'MK765',150),(4,'LP89',220),(5,'DSR',120),(6,'Recharg65',195);

INSERT INTO CarModel (BrandId,Name,MaxSpeed)
VALUES (7,' chevelle malibu',220),(4,'ds-21 pallas',185),(13,'504',120),(9,'2002',220),(10,'124b',120),(2,'rx2 coupe',155),(8,'maxima',190),(8,'Q50',200),
(7,'impala',195),(1,'144ea',165),(15,'subaru',145),(11,'civic cvcc',160),(12,'1900',125),(14,'12tl',120),(14,'5 gtl',175),(9,'320i',220);

INSERT INTO Car (ModelId)
VALUES (2),(3),(1),(4),(5);

INSERT INTO Car (ModelId)
VALUES (6),(7),(8),(9),(10),(11),(12),(13),(14),(15),(9),(16),(17),(20),(18),(12),(22),(7);

INSERT INTO Trip(CarId,Distance,StartDate,EndDate)
VALUES (1,145,'01-01-2012 23:59:59','03-01-2012 23:59:59'),(3,0,NULL,NULL),(5,1,'01-01-2012 12:00:00',NULL),(2,2454,'10-10-2018 09:45:00',''),(4,5000,'08-03-2020 14:00:00','10-04-2020 12:00:00');

INSERT INTO Trip(CarId,Distance,StartDate,EndDate)
VALUES (7,3500,'01-01-2012 12:00:00','02-22-2012 15:23:00'),(22,10500,'10-12-2019 20:00:00','02-23-2020 11:15:00'),(18,2400,'08-04-2021 09:00:00','09-20-2021 23:35:00'),
(15,200,'08-20-2019 20:00:00','08-21-2019 18:00:00'),(12,0,NULL,NULL),(20,5650,'04-22-2005 10:00:00','09-10-2005 11:35:00'),(9,1250,'05-12-2013 12:00:00','09-18-2013 09:35:45'),
(14,250,'10-10-2019 13:23:09','11-10-2019 15:35:00'),(10,15000,'10-20-2015 10:00:00','10-20-2016 18:00:00');

SELECT * FROM CarBrand;
SELECT * FROM CarModel;
SELECT * FROM Car;
SELECT * FROM Trip;
