
--Task 1

USE [BootcampTraining];
GO

CREATE OR ALTER VIEW [MealsAndWeightsVasyl] AS
SELECT m.Name AS MealName, SUM(r.Weight) AS MealWeight
FROM Meal AS m
INNER JOIN Recipe AS r
ON m.Id= r.MealId
GROUP BY m.Name;