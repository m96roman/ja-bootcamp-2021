CREATE OR ALTER VIEW ALL_CARS_Fedak AS
SELECT 
	b.Name AS 'Brand',
	m.Name AS 'Model',
	m.MaxSpeed
FROM Car c
JOIN CarModel m
	ON c.ModelId=m.ID
JOIN CarBrand b
	ON b.ID=m.BrandId




