USE BootcampTraining;

--1
SELECT SUM(Trip.Distance) AS Result FROM Trip; 

--2
SELECT CarBrand.Name, MAX(CarModel.MaxSpeed) AS Result
FROM CarBrand 
INNER JOIN CarModel ON CarBrand.Id = CarModel.BrandId
GROUP BY CarBrand.Name;

--3
SELECT CarBrand.Name, MAX(CarModel.MaxSpeed) AS Result
FROM CarBrand 
INNER JOIN CarModel ON CarBrand.Id = CarModel.BrandId
GROUP BY CarBrand.Name
HAVING COUNT(CarModel.BrandId) > 1;

--4
SELECT CarBrand.Id,CarBrand.Name from CarBrand UNION ALL SELECT CarModel.Id,CarModel.Name FROM CarModel;

--5
SELECT CarBrand.Name, CarModel.Name 
FROM CarBrand
INNER JOIN CarModel ON CarBrand.Id = CarModel.BrandId
INNER JOIN Car ON CarModel.Id = Car.ModellId
FULL OUTER JOIN Trip ON Trip.CarId = Car.Id
WHERE Car.Id NOT IN(Select Trip.CarId from TRIP) OR (DATEDIFF(HOUR,Trip.EndDate,Trip.StartDate) >1);
