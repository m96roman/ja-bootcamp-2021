USE [BootcampTraining];
GO
EXEC tSQLt.DropClass 'IvanyshynTests'
GO
EXEC tSQLt.NewTestClass 'IvanyshynTests'
GO

CREATE  PROCEDURE IvanyshynTests.[Setup]
AS
BEGIN
	EXEC tSQLt.FakeTable '[dbo].[IvanyshynIngredientMealsView]'
	INSERT INTO IvanyshynIngredientMealsView
	 (IngredientId,	IngredientName,	Proteins,	Fats,	Carbohydrates,	Weight,	MealId,	MealName,	Difficulty)
	 VALUES	(0,'Ingredient1',0,0,0,1,0,'Meal1',0),
			(0,'Ingredient2',0,0,0,2,0,'Meal2',0)

	EXEC tSQLt.FakeTable '[dbo].[Recipe]'
	EXEC tSQLt.FakeTable '[dbo].[Ingredient]'
	EXEC tSQLt.ApplyConstraint '[dbo].[Ingredient]','[UQ__Ingredie__737584F6005A33AC]'
END
GO

CREATE PROCEDURE IvanyshynTests.[test1.happy path]
AS 
BEGIN
	CREATE TABLE #Expected (IngredientName varchar(30),MealName varchar(30),WeightAsString varchar(40))

	INSERT INTO #Expected
	VALUES('Ingredient1','Meal1','1 as string'),('Ingredient2','Meal2','2 as string')

	SELECT TOP 0 * INTO #Actual FROM #Expected
	
	INSERT INTO #Actual EXEC [dbo].[spGetAsInt_Ivanyshyn]

	EXEC tSQLt.AssertEqualsTable #Expected, #Actual
	
END
GO

CREATE PROCEDURE IvanyshynTests.[test2.happy path for insert function]
AS
BEGIN
	EXEC [dbo].[spInsertIngredient_Ivanyshyn] 'Ingredient1',1,1,1,1,1

	DECLARE  @rC int;
	DECLARE @expectedrC int;
	SET @expectedrC=1;

	DECLARE @iC  int;
	DECLARE @expectediC int;
	SET @expectediC=1;

	SET @rc=(SELECT COUNT(*) FROM Recipe);
	SET @ic=(SELECT COUNT(*) FROM Ingredient);

	EXEC tSQLt.AssertEquals @rc, @expectedrC
	EXEC tSQLt.AssertEquals @iC, @expectediC
END
GO
--CREATE OR ALTER PROCEDURE [IvanyshynTests].[]

EXEC tSQLt.Run 'IvanyshynTests'