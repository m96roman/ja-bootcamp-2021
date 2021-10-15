-- 1 -------------------------
SELECT SUM(Distance) FROM Trip

--2---------------------------
SELECT CB.Name, MAX(CM.MaxSpeed) FROM CarModel AS CM
INNER JOIN CarBrand AS CB ON  cm.BrandId = CB.ID
GROUP BY CB.Name

--3---------------------------
SELECT CB.NAME,CB.ID, MAX(CM.MaxSpeed) AS MAXSPEED FROM CarModel AS CM
INNER JOIN CarBrand AS CB ON  cm.BrandId = CB.ID
GROUP BY CB.Name, CB.ID
HAVING COUNT(CM.BrandId) > 1

--4----------------------------
SELECT ID, Name FROM CarBrand
UNION
SELECT ID,Name FROM CarModel
ORDER BY Name

--5----------------------------
SELECT CB.Name, CM.NAME, DATEDIFF(MINUTE, T.StartDate, T.EndDate) AS Minutes, t.ID AS TripId FROM CarBrand  AS CB
INNER JOIN CarModel AS CM ON CB.ID = CM.BrandId
INNER Join Car AS C ON CM.ID = C.ModelId
LEFT JOIN Trip AS T ON C.ID = T.CarId
WHERE DATEDIFF(HOUR, T.StartDate, T.EndDate) < 1 OR T.ID IS NULL

--select * from CarBrand
--select * from CarModel
--select * from CarModel
--select * from Trip

--select * from CarBrand
--join CarModel on CarBrand.ID = CarModel.BrandId
--join Car on CarModel.ID = Car.ModelId
--join Trip on Car.ID = CarId