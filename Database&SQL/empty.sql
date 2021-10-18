USE BootcampTraining;

EXEC tSQLt.DropClass 'Test_Shyptur'
GO
EXEC tSQLt.NewTestClass 'Test_Shyptur'
GO

CREATE OR ALTER PROCEDURE Test_Shyptur.[Setup]
AS
BEGIN
	EXEC tSQLt.FakeTable 'CarBrand', @Identity = 1
	EXEC tSQLt.FakeTable 'CarModel', @Identity = 1
END
GO

CREATE OR ALTER PROCEDURE Test_Shyptur.[test 2. happy path]
AS
BEGIN
	SELECT * INTO #CARBRAND FROM CarBrand
	INSERT INTO #CARBRAND VALUES('Ford1')
	
	SELECT * INTO #CarModel FROM CarModel
	INSERT INTO #CarModel VALUES(1,'modeltest',220)

	EXECUTE StoredProcedure_Shyptur 'Ford1','modeltest',220

	EXEC tSQLt.AssertEqualsTable #CARBRAND, CarBrand
	EXEC tSQLt.AssertEqualsTable #CarModel, CarModel

END
GO

EXEC tSQLt.Run 'Test_Shyptur'
GO



USE BootcampTraining;
EXEC tSQLt.DropClass 'Test_Shyptur1'
GO


EXEC tSQLt.NewTestClass 'Test_Shyptur1'
GO

CREATE OR ALTER PROCEDURE Test_Shyptur1.[Setup]
AS
BEGIN
	EXEC tSQLt.FakeTable 'CarBrand' ,@identity=1
	EXEC tSQLt.FakeTable 'CarModel', @identity=1
	INSERT INTO CarBrand(Name) VALUES('BMW')
	DECLARE @ID INT
	SET @ID= (SELECT Id FROM CarBrand WHERE Name='BMW')
	INSERT INTO CarModel(BrandId,Name,MaxSpeed) VALUES (@ID,'M5',300)
END
GO

CREATE OR ALTER PROCEDURE Test_Shyptur1.[test 2. Its ok ]
AS
BEGIN
	CREATE TABLE  #TABLEtest(Name varchar(40), NameModel varchar(40), MaxSpeedString varchar(40))
	INSERT INTO  #TABLEtest VALUES('BMW','M5','300_as string')
	
	CREATE  TABLE #TABLEtest1 
	(
	Name varchar(40), NameModel varchar(40),MaxSpeedString varchar(40)
	)
	INSERT INTO #TABLEtest1  EXECUTE GetNewTable_Shyptur
				
	EXEC tSQLt.AssertEqualsTable #TABLEtest, #TABLEtest1
END
GO

EXEC tSQLt.Run 'Test_Shyptur1'

