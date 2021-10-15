USE BootcampTraining;

EXEC tSQLt.DropClass 'Test_spDovhanychConvert'
GO

EXEC tSQLt.NewTestClass 'Test_spDovhanychConvert'
GO

CREATE OR ALTER PROCEDURE Test_spDovhanychConvert.[Setup]
AS
BEGIN 
	EXEC tSQLt.FakeTable 'CarModel', @identity=1
	INSERT INTO CarModel(BrandId) VALUES ('10 as string')
END
GO

CREATE OR ALTER  PROCEDURE Test_spDovhanychConvert.[test 1, happy path]
AS
BEGIN
	CREATE TABLE #BrandIdExpected (BrandId VARCHAR(50))
	INSERT INTO #BrandIdExpected (BrandId)
	VALUES ('10 as string')
	
	EXEC [dbo].spDovhanych_ConvertValues(10)

	EXEC tSQLt.AssertEqualsTable #BrandIdExpected, CarModel
	
END
Go

EXEC tSQLt.Run 'Test_spDovhanychConvert'