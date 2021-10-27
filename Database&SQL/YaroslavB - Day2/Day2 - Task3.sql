--SELECT * FROM Meal
--SELECT * FROM Recipe
--SELECT * FROM Ingredient	


SELECT Name RecipeName, AVG(Weight) AvgWeight --SUM(Weight) TotalWeight - *possible should be 'SUM'
FROM Recipe
INNER JOIN Meal
ON Recipe.MealID = Meal.Id
GROUP BY Name
HAVING COUNT(IngredientId) < 3
ORDER BY 2 DESC
