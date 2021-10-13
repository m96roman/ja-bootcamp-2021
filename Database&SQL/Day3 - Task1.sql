
CREATE VIEW YaroslavB_GetHiProteinMeal AS --Gets ingridients and meals only with protein level > 30
SELECT Ingredient.Name Ingridient, Proteins, Meal.Name Meal
FROM Ingredient
INNER JOIN Recipe ON Ingredient.Id = Recipe.IngredientId
INNER JOIN Meal ON Meal.Id = Recipe.MealId
WHERE Proteins > 30;
GO