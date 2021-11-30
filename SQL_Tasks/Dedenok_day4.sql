Use BootcampTraining;

--Task1
EXEC tSQLt.DropClass 'TestWishProductsDedenok';
GO

EXEC tSQLt.NewTestClass 'testWishProductsDedenok';
GO

CREATE OR ALTER PROCEDURE TestWishProductsDedenok.[Setup]
AS
BEGIN
    EXEC tSQLt.FakeTable 'WishProducts'
	EXEC tSQLt.FakeTable 'WishProducts2'
END;
GO

CREATE OR ALTER PROCEDURE TestWishProductsDedenok.[test happy path]
AS
BEGIN
	CREATE TABLE #expectedWishList (price int, name varchar(40))
	INSERT INTO #expectedWishList(price, name)
    VALUES (35, 'bananas')

	EXEC dbo.InsertToTablesViktoriya 35, 'bananas', 35, 1
		
	SELECT * FROM WishProducts
    SELECT * FROM #expectedWishList

    EXEC tSQLt.AssertEqualsTable #expectedWishList, WishProducts

END;
GO

EXEC tSQLt.Run 'TestWishProductsDedenok'
GO

--Task2
EXEC tSQLt.DropClass 'TestPriceToCharDedenok';
GO

EXEC tSQLt.NewTestClass 'TestPriceToCharDedenok';
GO

CREATE OR ALTER PROCEDURE TestPriceToCharDedenok.[Setup]
AS
BEGIN
    EXEC tSQLt.FakeTable 'Product',  @IDENTITY = 1 
	INSERT INTO Product(Price) VALUES ('55')		
END;
GO

CREATE OR ALTER PROCEDURE TestPriceToCharDedenok.[test happy path]
AS
BEGIN
	CREATE TABLE #expectedToChar (price varchar(40))
	INSERT INTO #expectedToChar (price)
    VALUES ('71')
	
	CREATE TABLE #actualToChar (price varchar(40))

	INSERT INTO #actualToChar(price) EXEC [dbo].sp_ToCharViktoriya

	SELECT * FROM #actualToChar
	SELECT * FROM #expectedToChar
	EXEC tSQLt.AssertEqualsTable  #expectedToChar, #actualToChar
	
END;
GO

EXEC tSQLt.Run 'TestPriceToCharDedenok'
GO
