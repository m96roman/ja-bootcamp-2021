
-- run created view in Task 1
SELECT * FROM [MealsAndWeightsVasyl];

-- run function created in Task 2
SELECT [dbo].[ConverterVasyl] (20) AS ConvertedIntNumber;

-- run procedure created Task 3
EXECUTE ConverWeightsOfMealsVasyl;

-- run procedure created Task 4
EXECUTE AddEasyMealWithOneIngredientVasyl 'Nut Cream', 10, 1, 14, 3.5
