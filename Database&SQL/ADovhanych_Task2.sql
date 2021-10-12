USE BootcampTraining;

ALTER TABLE CarModel ALTER COLUMN Name VarChar(50) NOT NULL;

SELECT SUM(Distance) AS DistanceSum  FROM Trip;

SELECT cb.Name AS Model, MAX(cm.MaxSpeed) AS MaxSpeed
FROM CarBrand cb JOIN CarModel cm 
ON cb.Id = cm.BrandId
GROUP BY cb.Name;

SELECT cb.Name AS Model, MAX(cm.MaxSpeed) AS MaxSpeed
FROM CarBrand cb JOIN CarModel cm 
ON cb.Id = cm.BrandId
GROUP BY cb.Name
HAVING COUNT(*) > 1
ORDER BY MAX(cm.MaxSpeed) DESC;

SELECT Id, Name FROM CarBrand
UNION ALL
SELECT Id, Name FROM CarModel

DELETE FROM Trip WHERE CarId = 103;

SELECT cb.Name AS Car, cm.Name AS Model
From CarBrand cb
INNER JOIN CarModel cm ON cb.Id = cm.BrandId
INNER JOIN Car c ON cm.Id = c.ModellId
LEFT JOIN Trip t ON t.CarId = c.Id
WHERE c.Id NOT IN(SELECT tr.CarId FROM Trip tr)
OR DATEDIFF(HOUR, t.StartDate, t.EndDate)<10