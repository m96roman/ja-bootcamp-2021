USE BootcampTraining;

EXEC tSQLt.DropClass 'Test_spDovhanych'
GO

EXEC tSQLt.NewTestClass 'Test_spDovhanych'
GO

CREATE OR ALTER PROCEDURE Test_spDovhanych.[Setup]
AS
BEGIN 
	EXEC tSQLt.FakeTable 'CarModel', @identity=1
END
GO

CREATE OR ALTER  PROCEDURE Test_spDovhanych.[test 1, happy path]
AS
BEGIN
	CREATE TABLE #CarModelExpected (BrandId INT, Name VARCHAR(50), MaxSpeed INT)
	INSERT INTO #CarModelExpected (BrandId, Name,MaxSpeed)
	VALUES
		(10, 'Test Name', 111)
	
	EXEC dbo.spDovhanych_Insert 10, 'Test Name', 111

	EXEC tSQLt.AssertEqualsTable #CarModelExpected, CarModel
END
Go

EXEC tSQLt.Run 'Test_spDovhanych'