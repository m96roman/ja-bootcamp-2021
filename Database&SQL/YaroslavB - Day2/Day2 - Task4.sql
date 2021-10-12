--SELECT * FROM Meal
--SELECT * FROM Recipe
--SELECT * FROM Ingredient	


SELECT Id, Name
FROM Ingredient
UNION
SELECT Id, Name
FROM Meal
