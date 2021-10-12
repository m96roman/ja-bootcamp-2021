USE BootcampTraining;
   SELECT sum(distance) AS SumDistance 
   FROM Trip; --Task1

   SELECT CarBrand.Name,  MAX(MaxSpeed)
   FROM CarBrand 
   INNER JOIN CarModel
   ON CarBrand.Id = CarModel.BrandId
 GROUP BY CarBrand.Name
 ORDER BY MAX(MaxSpeed) DESC;  --Task2
   
  SELECT CarBrand.Name, MAX(MaxSpeed) AS MaxSpeed
  FROM CarBrand  
  INNER JOIN CarModel ON CarBrand.Id = CarModel.BrandId  
  GROUP BY CarBrand.Name
   HAVING COUNT(*)>1
  ORDER BY MAX(MaxSpeed) DESC;  --Task3

  SELECT Id,Name FROM CarBrand 
  UNION ALL 
  SELECT BrandId, CarModel.Name from CarModel; --task4
 
   SELECT CarBrand.Name, CarModel.Name , Car.Id
   FROM CarBrand
   INNER JOIN CarModel ON CarBrand.Id = CarModel.BrandId 
   INNER JOIN Car ON CarModel.Id = Car.ModellId
   LEFT JOIN Trip ON Trip.CarId = Car.Id
   WHERE Trip.Id IS NULL OR DATEDIFF(HOUR,Trip.EndDate,Trip.StartDate)<1 -- task 5

   