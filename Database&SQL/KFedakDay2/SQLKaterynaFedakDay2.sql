USE BootcampTraining;

SELECT 
	SUM(Distance) 'Total distance'
FROM Trip

SELECT 
	c.Name,
	MAX(MaxSpeed) 'Max speed' 
FROM CarModel m
JOIN CarBrand c 
	ON m.BrandId=c.ID
GROUP BY c.Name;


SELECT 
	c.Name,
	MAX(MaxSpeed) 'Max speed' 
FROM CarModel m
JOIN CarBrand c 
	ON m.BrandId=c.ID
WHERE m.BrandId IN (SELECT BrandId FROM CarModel GROUP BY BrandId HAVING COUNT(*)>1)
GROUP BY c.Name
ORDER BY 'Max speed' DESC

SELECT 
	b.ID,
	b.Name 
FROM CarBrand b
UNION
SELECT 
	m.ID,
	m.Name 
FROM CarModel m
ORDER BY b.ID

SELECT 
	b.Name,
	m.Name
FROM CarBrand b
JOIN CarModel m
	ON m.BrandId=b.ID
JOIN Car c 
	ON c.ModelId=m.ID
JOIN Trip t 
	ON t.CarId=c.ID
WHERE (t.StartDate IS NULL AND t.EndDate IS NULL) OR  DateDiff(HOUR, t.StartDate, t.EndDate)<1




