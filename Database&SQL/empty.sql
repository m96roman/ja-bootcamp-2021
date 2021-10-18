USE BootcampTraining

EXEC tSQLt.DropClass 'Test_spMartin_Procedure';
GO

EXEC tSQLt.NewTestClass 'Test_spMartin_Procedure';
GO

CREATE OR ALTER PROCEDURE Test_spMartin_Procedure.[Setup]
AS
BEGIN
	EXEC tSQLt.FakeTable'CarModel' , @Identity =1;
	EXEC tSQLt.FakeTable 'Trip',@Identity =1;
	INSERT INTO Trip(Distance)
	VALUES 
	(1234);
END
GO

CREATE OR ALTER PROCEDURE Test_spMartin_Procedure.[test 1. raise error if not exist @BrandID]
AS
BEGIN 
	EXEC  sp_insert_martin 1,Q4,400;
END
GO

CREATE OR ALTER PROCEDURE Test_spMartin_Procedure.[test 2. correct select error]
AS
BEGIN 
	CREATE TABLE #Actual (Distance VARCHAR(40))
	INSERT INTO #Actual  EXEC sp_convert_to_string_martin;
	
	CREATE TABLE #A (Distance VARCHAR(40))
	INSERT INTO #A 
	SELECT CONCAT(CONVERT(VARCHAR(40),Trip.Distance), ' as string')  
	FROM Trip ;

	EXEC tSQLt.AssertEqualsTable #Actual , #A;
END
GO

CREATE OR ALTER PROCEDURE Test_spMartin_Procedure.[test 3. happy path]
AS
BEGIN
	SELECT TOP 0 * INTO #MartinProcedureExpected FROM CarModel;

	SELECT TOP 0 * INTO #Expected FROM CarModel;
	INSERT INTO #Expected
	VALUES (1,'Q4',400),(2,'Supra',120);

	EXEC sp_insert_martin 1,Q4,400;
	EXEC sp_insert_martin 2,'Supra',120;

	EXEC tSQLt.AssertEqualsTable #Expected , CarModel;

END
GO

EXECUTE tSQLt.Run 'Test_spMartin_Procedure';
GO


