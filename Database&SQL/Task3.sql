
-- Task 3

USE [BootcampTraining];
GO

CREATE OR ALTER PROCEDURE ConverWeightsOfMealsVasyl
AS
BEGIN
	SELECT MealName, (SELECT [dbo].[ConverterVasyl] (MealWeight) AS ConvertedIntNumber) 
	FROM [MealsAndWeightsVasyl]
END