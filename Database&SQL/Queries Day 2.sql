USE BootcampTraining;

--1
-- Get total TimeToCookInMins from Meal table for all meals
SELECT SUM(TimeToCookInMins) AS TimeCook
FROM Meal;

--2
-- Get meal Name and average ingredients weight per recipe from Recipe table
SELECT m.Name, AVG(r.Weight) AS AverageWeight
FROM Meal AS m
INNER JOIN Recipe AS r
ON m.Id = r.MealId
GROUP BY Name;

--3
-- Get meal Name and average ingredients weight per recipe from Recipe table, for meals that have less than 3 ingredients
SELECT m.Name, AVG(r.Weight) AS AverageWeight
FROM Meal AS m
INNER JOIN Recipe AS r
ON m.Id = r.MealId
GROUP BY Name
HAVING COUNT(r.IngredientId) < 3

--4
-- Union Ingredient and Meal with result have two columns Id and Name
SELECT Id, Name
FROM Meal
UNION
SELECT Id, Name
FROM Ingredient

--5
-- Get an Ingredient name and Meal name where there no meals with that ingredient or time to cook les than 20 mins
SELECT i.Name AS IngredientName, m.Name
FROM Ingredient AS i
LEFT OUTER JOIN Recipe as r ON r.IngredientId = i.Id
LEFT OUTER JOIN Meal as m ON m.Id = r.MealId
WHERE m.TimeToCookInMins < 20 OR r.IngredientId IS NULL









































