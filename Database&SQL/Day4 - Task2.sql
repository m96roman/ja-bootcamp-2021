EXECUTE tSQLt.DropClass 'Test_YaroslavB_ComplexProcedure'
GO

EXECUTE tSQLt.NewTestClass 'Test_YaroslavB_ComplexProcedure'
GO

CREATE PROCEDURE Test_YaroslavB_ComplexProcedure.[Setup]
AS
BEGIN
	EXEC tSQLt.FakeTable 'Meal', @Identity=1;
	EXEC tSQLt.FakeTable 'Ingredient', @Identity=1;

END
GO


CREATE PROCEDURE Test_YaroslavB_ComplexProcedure.[test 1. happy path]
AS
BEGIN

	CREATE TABLE #Expected (Meal nvarchar(50), TimeToCookInMins int, Ingredient nvarchar(50), Proteins int, Fats int, Carbohydrates int);
	INSERT INTO #Expected
	VALUES ('Homemade Chorizo', 35, 'Sausage', 10, 54, 26);

	EXECUTE YaroslavB_ComplexProcedure 'Homemade Chorizo', 35, 'Sausage', 10, 54, 26;
	
	SELECT TOP 0 * INTO #Actual FROM #Expected;​

	INSERT INTO #Actual
	SELECT TOP 1 Meal.Name Meal, Meal.TimeToCookInMins, Ingredient.Name Ingredient, Ingredient.Proteins, Ingredient.Fats, Ingredient.Carbohydrates
	FROM Meal, Ingredient;

	EXEC tSQLt.AssertEqualsTable #Expected, #Actual;
	
END
GO

CREATE PROCEDURE Test_YaroslavB_ComplexProcedure.[test 2. raise error if Meal.Name is NULL]
AS
BEGIN
	EXEC tSQLt.ExpectRaiserror @Productname = 'prodName';​

	EXECUTE YaroslavB_ComplexProcedure NULL, 35, 'Sausage', 10, 54, 26;

END
GO


EXEC tSQLt.Run 'Test_YaroslavB_ComplexProcedure';

GO
