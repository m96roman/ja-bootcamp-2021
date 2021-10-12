USE [BootcampTraining];

--Get total TimToCookInMins from Meal table for all meals
SELECT SUM(m.TimeToCookInMins) as TimeTotal FROM Meal as m

--Get meal Name and average infredients weight per recipe from recipe table
SELECT m.Name,Avg(r.Weight) as AverageIngredientWeight FROM Meal m
INNER JOIN Recipe as r ON m.Id=r.MealId
GROUP BY m.Name

--Get meal Name and average ingredients weight from recipe table, for meals that have less than 3 ingredients
SELECT m.Name,Avg(r.Weight) as AverageIngredientWeight FROM Meal m
INNER JOIN Recipe as r ON m.Id=r.MealId
GROUP BY m.Name
HAVING COUNT(r.IngredientId)<=3
ORDER BY COUNT(r.IngredientId)

--Union Ingredient and Meal with result have two columns Id and Name
SELECT m.Id,m.Name FROM Meal as m
UNION
SELECT i.Id,i.Name FROM Ingredient as i

--Get an ingredient name and Meal name where there no meals with that ingredients or time to cook less that 20 mins

SELECT i.Name AS IngredientName, ISNULL(m.Name,'There are no meals with this ingredient') AS MealName FROM Ingredient as i
LEFT JOIN Recipe as r ON r.IngredientId=i.Id
LEFT JOIN Meal as m ON r.MealId=m.Id
WHERE m.TimeToCookInMins<20 OR r.IngredientId IS NULL
