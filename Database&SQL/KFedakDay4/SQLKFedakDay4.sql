
EXEC tSQLt.DropClass'TestKFedak'
EXEC tSQLt.NewTestClass 'TestKFedak'
GO

CREATE PROCEDURE [TestKFedak].[test1 if equal tables]
AS
BEGIN
CREATE TABLE table1 
(
    namecar nvarchar(40), 
    speed nvarchar(40)

)
CREATE TABLE table2 
(
    namecar nvarchar(40), 
    speed nvarchar(40)
)
INSERT INTO table1
SELECT c.Name,[dbo].[GetString_Fedak](c.MaxSpeed) FROM CarModel c;
INSERT INTO table2
EXEC [dbo].[INT_TO_STRING_FEDAK];
EXEC tSQLt.AssertEqualsTable 'table1','table2'
END
GO

CREATE PROCEDURE [TestKFedak].[test2 happy path]
AS
BEGIN
CREATE TABLE #CarModelTableExpected 
(
	NameCar VARCHAR(50),
	MaxSpeed INT
)
CREATE TABLE #CarModelTableActual 
(
	NameCar VARCHAR(50),
	MaxSpeed INT
)
	INSERT INTO #CarModelTableExpected (NameCar,MaxSpeed)
	VALUES ('A6',220);
EXEC Sorted_Procedure_FEDAK @BrandName = 'AUDI', @Name = 'A6',@MaxSpeed=220;

INSERT INTO #CarModelTableActual (NameCar,MaxSpeed)
SELECT TOP 1 Name,MaxSpeed FROM CarModel ORDER BY ID DESC;
EXEC tSQLt.AssertEqualsTable #CarModelTableExpected,#CarModelTableActual
END
GO
EXEC tSQLt.Run 'TestKFedak'

