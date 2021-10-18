------Just Try Testing--------------
--DROP TABLE IF EXISTS Tbl_NestorTest
 
--CREATE TABLE Tbl_NestorTest
--(Id INT , FruitName VARCHAR(100))
 
 
--INSERT INTO Tbl_NestorTest 
--VALUES (1,'Tomato') ,  (2,'Avocado'),  (3 , 'Plum')

--GO
--CREATE OR ALTER FUNCTION GetProductName (@Nm INT)
--RETURNS VARCHAR(100)
--BEGIN
--DECLARE @RetVal AS VARCHAR(100)
--SELECT  @RetVal = CASE @Nm  WHEN 1 THEN (select Tbl_NestorTest.FruitName as x FROM Tbl_NestorTest where Tbl_NestorTest.Id = @Nm)
--when 2 then '2'
--when 3 then '3'
--when 4 then '4'
--when 5 then '5'
--END
--RETURN  @RetVal
--END
--GO

--select dbo.GetProductName(1)


--GO  
--CREATE SCHEMA Func_ProductTest  
--    AUTHORIZATION [dbo];  
--GO  

--GO
--CREATE OR ALTER PROCEDURE Func_ProductTest.[Test product function]
--AS
--DECLARE @Expected AS VARCHAR(100)
--DECLARE @Actual AS VARCHAR(100)
--SELECT @Actual = dbo.GetProductName(1)
--EXEC tSQLt.AssertEquals @Expected,@Actual
--SET @Expected='Tomato'
--SELECT @Actual = dbo.GetProductName(2)
--EXEC tSQLt.AssertEquals @Expected,@Actual
--SET @Expected='Banana'
--SELECT @Actual = dbo.GetProductName(3)
--EXEC tSQLt.AssertEquals @Expected,@Actual
--SET @Expected='Not Found'
--SELECT @Actual = dbo.GetProductName(4)
--EXEC tSQLt.AssertEquals @Expected,@Actual
--GO
--EXEC tSQLt.Run 'Func_ProductTest.[Test product function]'

--GO
--CREATE OR ALTER FUNCTION IfIsNull(@Bool varchar(20))
--RETURNS VARCHAR(10)
--BEGIN
--DECLARE @RetVal AS VARCHAR(100)
--SELECT  @RetVal = CASE @Bool WHEN null THEN 'no name'
--WHEN 3 THEN 'Banana'
--END
--RETURN  @RetVal
--END
--GO


---------------------------------------------

--EXEC tSQLt.NewTestClass'NewTestClass'
--GO
--CREATE OR ALTER PROCEDURE Func_ProductTest.[Test product function]
--AS
--DECLARE @Expected AS VARCHAR(100)='Carrot'
--DECLARE @Actual AS VARCHAR(100)
--SELECT @Actual = dbo.GetProductName(1)
--EXEC tSQLt.AssertEquals @Expected,@Actual
--SET @Expected='Tomato'
--SELECT @Actual = dbo.GetProductName(2)
--EXEC tSQLt.AssertEquals @Expected,@Actual
--SET @Expected='Banana'
--SELECT @Actual = dbo.GetProductName(3)
--EXEC tSQLt.AssertEquals @Expected,@Actual
--SET @Expected='Not Found'
--SELECT @Actual = dbo.GetProductName(4)
--EXEC tSQLt.AssertEquals @Expected,@Actual
--GO
--EXEC tSQLt.Run 'Func_ProductTest.[Test product function]'


--------------TEST 1----------------------

EXEC tSQLt.DropClass 'CarTestNestor'
GO

EXEC tSQLt.NewTestClass 'CarTestNestor'
GO

CREATE PROCEDURE CarTestNestor.[Setup]
AS
BEGIN
EXEC tSQLt.FakeTable 'CarModel' 
INSERT INTO CarModel(Id, BrandId,Name, MaxSpeed)
VALUES 
	(1, 1, 'dfsdfs',555)
END
GO

GO
CREATE OR ALTER PROCEDURE CarTestNestor.[test 1. raise error if CarModel.ID is null]
AS
BEGIN
CREATE TABLE #Expected (Asstring VARCHAR(30))
SELECT TOP 0 * INTO #Actual FROM #Expected
INSERT INTO #Expected (Asstring)
VALUES ('1 as string')
INSERT #Actual EXEC SelectAllCarsIdNestor
EXEC tSQLt.AssertEqualsTable #Expected, #Actual
END
GO
EXEC tSQLt.Run 'CarTestNestor'
GO

--TEST 2----------------

go 
CREATE OR ALTER PROCEDURE dbo.TaskNestor  @Model Varchar(30)
AS
DECLARE @Brand VARCHAR(30)
BEGIN TRANSACTION
	BEGIN TRY 
		INSERT INTO CarModel (Name)
		values (@Model)
	END TRY
	BEGIN CATCH
		SELECT ERROR_NUMBER() AS ERRORNUMBER
		
		INSERT INTO CarBrand(Name)
		values (@Model)
	END CATCH
COMMIT TRAN
GO;

SELECT * FROM CarBrand
EXEC dbo.TaskNestor  @Model = 'DSFS'



--------------------------------------------------------
EXEC tSQLt.DropClass 'CarTestNestor2'
GO
EXEC tSQLt.NewTestClass 'CarTestNestor2'
GO

CREATE PROCEDURE CarTestNestor2.[Setup]
AS
BEGIN
	EXEC tSQLt.FakeTable 'CarBrand', @Identity = 1
END
GO

GO
CREATE OR ALTER PROCEDURE CarTestNestor2.[test 1. raise error if CarModel.ID is null]
AS
BEGIN

CREATE TABLE #Expected (ID INT, Name VARCHAR(30))
INSERT INTO #Expected (ID, Name)
VALUES (1, 'xxx1')




CREATE TABLE #Temp (ID INT)
INSERT INTO #Temp EXEC dbo.TaskNestor 'xxx1'

SELECT * INTO #Actual FROM CarBrand

SELECT * FROM #Actual
SELECT * FROM #Expected


EXEC tSQLt.AssertEqualsTable #Expected, #Actual
END
GO

EXEC tSQLt.Run 'CarTestNestor2'
GO

