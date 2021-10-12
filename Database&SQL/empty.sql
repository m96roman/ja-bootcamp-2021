USE BootcampTraining;

CREATE TABLE CarBrand(
Id int IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50) NOT NULL
);

CREATE TABLE CarModel(
Id INT IDENTITY(1,1) NOT NULL,
BrandId INT,
Name VARCHAR(50),
MaxSpeed INT
PRIMARY KEY(id),
FOREIGN KEY(BrandId) REFERENCES CarBrand(Id)
);

CREATE TABLE Car(
Id int IDENTITY(1,1) PRIMARY KEY,
ModelId INT,
FOREIGN KEY (ModelId) REFERENCES CarModel(Id)
);

CREATE TABLE Trip (
Id INT NOT NULL IDENTITY,
CarId INT NOT NULL,
Distance INT,
StartDate DATETIME,
EndDate DATETIME,
PRIMARY KEY(Id),
FOREIGN KEY(CarId) REFERENCES Car(ID),
);

INSERT INTO CarModel(BrandId,Name,MaxSpeed) VALUES
(1,'Fiesta', 230),
(1,'Focus', 250),
(1,'Puma', 220),
(2,'X3', 255),
(2,'X5', 260),
(2,'X6', 270),
(3,'A4', 250),
(3,'A6', 265),
(3,'A8', 320),
(5,'Encore', 230),
(5,'Envision', 250),
(5,'Electra', 245),
(4,'Continental', 310),
(4,'SUV', 260),
(4,'Bentayaga', 280),
(6,'s60', 266),
(6,'XC60', 257),
(6,'XC90', 275),
(7,'Passat', 260),
(7,'Golf', 250),
(7,'Polo', 270),
(8,'Camry',220),
(8,'Supra',230),
(8,'Corola',260),
(8,'Rav4',220),
(9,'Model 3',320),
(9,'Model s',349),
(9,'Model x',430),
(9,'Model y',260),
(10,'Swift', 190),
(10,'Vitara',237),
(10,'Jimny',341),
(10,'Baleno',180),
(11,'Forester',213),
(11,'OutBack',211),
(11,'WRX',189),
(11,'Legacy',123),
(12,'Tailor',170),
(12,'Fortwo',156),
(12,'Cabrio',123),
(12,'EQ Fortwo',189),
(13,'94 Sonett',210),
(13,'Sport',199),
(13,'9-2X',207),
(13,'9-4X',211),
( 14, 'Phantom', 211),
( 14, 'Ghost', 241),
( 14, 'Wraith', 230),
( 14, 'Cullinan', 220),
( 15, 'R1T', 230),
( 15, 'R1S', 200),
( 16, 'Macan', 311),
( 16, 'Cayenne', 240),
( 16, '911', 293),
( 16, 'Panamera', 281),
( 16, 'Cayenne Coupe', 275),
( 16, 'Taycan', 290),
( 17, 'Leaf', 180),
( 17, 'Micra', 180),
( 17, 'Juke', 180),
( 17, 'Pathfinder', 150),
( 18, 'Mirage G4', 190),
( 18, 'ASX Model', 200),
( 18, 'Pajero', 190),
( 18, 'Xpander', 170),
( 19, 'E320', 280),
( 19, 'AMG GT', 400),
( 19, 'GLS', 320),
( 19, 'GLE', 250),
( 20, 'CX-5', 230),
( 20, 'CX-8', 190),
( 20, 'Bongo', 210),
( 20, 'CX-3', 220);

DECLARE @cnt INT = 54;
WHILE @cnt < 130
BEGIN
DECLARE @FromDate DATETIME2(0)
DECLARE @ToDate DATETIME2(0)

SET @FromDate = '2015-01-01 08:22:13';
SET @ToDate = '2021-11-12 17:56:31';

DECLARE @Seconds INT = DATEDIFF(SECOND, @FromDate, @ToDate);
DECLARE @Random INT = ROUND(((@Seconds-1) * RAND()), 0);

DECLARE @ENDTRIP DATETIME2(0);
DECLARE @STARTTRIP DATETIME2(0);

SET @STARTTRIP = DATEADD(SECOND, @Random, @FromDate);
SET @ENDTRIP = DATEADD(SECOND, @Random, @STARTTRIP);

 INSERT INTO Trip(CarId,Distance,StartDate,EndDate) VALUES (@cnt,FLOOR(RAND()*1200+250),@STARTTRIP,@ENDTRIP);
SET @cnt = @cnt + 1;
END;


