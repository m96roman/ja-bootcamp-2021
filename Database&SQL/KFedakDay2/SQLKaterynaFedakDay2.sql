SELECT SUM(Distance) AS 'Total distance'
FROM Trip

SELECT c.Name,MAX(MaxSpeed) as 'Max speed' 
FROM CarModel m
JOIN CarBrand as c on m.BrandId=c.ID
GROUP BY c.Name;


SELECT c.Name,MAX(MaxSpeed) as 'Max speed' 
FROM CarModel m
JOIN CarBrand AS c ON m.BrandId=c.ID
WHERE m.BrandId IN (SELECT BrandId FROM CarModel GROUP BY BrandId HAVING COUNT(*)>1)
GROUP BY c.Name
ORDER BY 'Max speed' DESC

SELECT ID,Name FROM CarModel
UNION 
SELECT ID,Name FROM CarBrand
ORDER BY ID ;

SELECT b.Name,m.Name, DateDiff(MINUTE, t.StartDate, t.EndDate) , t.Distance
FROM CarModel m
JOIN CarBrand AS b on m.BrandId=b.ID
JOIN Car AS c ON c.ModelId=m.ID
JOIN Trip AS t ON t.CarId=c.ID
WHERE (t.StartDate IS NULL AND t.EndDate IS NULL) OR  DateDiff(HOUR, t.StartDate, t.EndDate)<1




