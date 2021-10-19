USE[BootcampTraining];
GO
CREATE OR ALTER VIEW IvanyshynIngredienMealsView AS
SELECT r.IngredientId, i.Name as IngredientName, i.Proteins, i.Fats, i.Carbohydrates,r.Weight, r.MealId, m.Name as MealName, m.Difficulty
FROM Recipe as r
INNER JOIN Ingredient as i ON i.Id=r.IngredientId
INNER JOIN Meal as m ON m.Id=r.MealId