
USE [BootcampTraining];
GO

EXEC tSQLt.DropClass 'VasylTests';
GO
EXEC tSQLt.NewTestClass 'VasylTests';
GO

CREATE OR ALTER PROCEDURE VasylTests.[Setup]
AS
BEGIN
	EXEC tSQLt.FakeTable '[dbo].[MealsAndWeightsVasyl]'
	INSERT INTO MealsAndWeightsVasyl
	 (MealName, MealWeight)
	 VALUES	('Pasta Korea', 30),
			('Salad Poland', 20)

	EXEC tSQLt.FakeTable '[dbo].[Recipe]'
	EXEC tSQLt.FakeTable '[dbo].[Ingredient]'
	EXEC tSQLt.ApplyConstraint '[dbo].[Ingredient]','[Ingredient]'
END
GO

CREATE OR ALTER PROCEDURE VasylTests.[test 1 happy path]
AS 
BEGIN
	CREATE TABLE #Expected (MealName varchar(30), WeightAsString varchar(40))

	INSERT INTO #Expected
	VALUES('Salmon meal', '23 as string'),
		  ('Rice meal', '12 as string')

	SELECT TOP 0 * INTO #Actual FROM #Expected

	INSERT INTO #Actual EXEC [dbo].[ConverWeightsOfMealsVasyl]

	EXEC tSQLt.AssertEqualsTable #Expected, #Actual

END
GO

CREATE OR ALTER PROCEDURE VasylTests.[test 2 happy path]
AS
BEGIN
	EXEC [dbo].[AddEasyMealWithOneIngredientVasyl] 'Pasta with salmon', 10, 4, 5, 3

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

EXEC tSQLt.Run 'VasylTests'