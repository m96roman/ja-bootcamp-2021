--SELECT * FROM Meal
--SELECT * FROM Recipe
--SELECT * FROM Ingredient	


SELECT Name RecipeName, SUM(Weight) TotalWeight
FROM Recipe
INNER JOIN Meal
ON Recipe.MealID = Meal.Id
GROUP BY Name

