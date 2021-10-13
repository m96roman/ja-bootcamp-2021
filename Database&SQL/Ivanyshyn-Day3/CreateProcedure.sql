USE[BootcampTraining];
GO
CREATE OR ALTER PROCEDURE spGetAsInt_Ivanyshyn
AS
BEGIN
	SELECT t.IngredientName,t.MealName,dbo.GetIntAsString_Ivanyshyn(t.Weight) AS WeightAsString FROM dbo.IvanyshynIngredienMealsView AS t
END
GO
EXEC spGetAsInt_Ivanyshyn;