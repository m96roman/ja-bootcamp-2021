--SELECT * FROM Meal
--SELECT * FROM Recipe
--SELECT * FROM Ingredient	


SELECT Ingredient.Name IngridientName, Meal.Name MealName
FROM Ingredient
LEFT JOIN Recipe ON Ingredient.Id = Recipe.IngredientId
LEFT JOIN Meal ON Recipe.MealId = Meal.Id
WHERE IngredientId IS NULL OR TimeToCookInMins < 20
