EXECUTE tSQLt.DropClass 'Test_YaroslavB_ProteinsMore20'

EXEC tSQLt.NewTestClass 'Test_YaroslavB_ProteinsMore20'

GO

CREATE PROCEDURE Test_YaroslavB_ProteinsMore20.[Setup]
AS
BEGIN
	EXEC tSQLt.FakeTable 'Ingredient', @Identity=1
	INSERT INTO Ingredient (Name, Proteins, Fats, Carbohydrates)
	values
	('Water', 99, 99, 99)
END

GO

CREATE PROCEDURE Test_YaroslavB_ProteinsMore20.[test 1. happy path]
AS
BEGIN
	CREATE TABLE #ProteinsMore20Expected (Ingridient nvarchar(50),ProteinsInGrams varchar(40));

	SELECT TOP 0 * INTO #ProteinsMore20Actual FROM #ProteinsMore20Expected;

	INSERT INTO #ProteinsMore20Expected (Ingridient, ProteinsInGrams) 
	VALUES ('Water', '99 as string');

	INSERT #ProteinsMore20Actual EXEC YaroslavB_ProteinsMore20

	EXEC tSQLt.AssertEqualsTable #ProteinsMore20Expected, #ProteinsMore20Actual;

END

GO


EXEC tSQLt.Run 'Test_YaroslavB_ProteinsMore20';

GO


