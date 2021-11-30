--Task1
CREATE VIEW [ProductsViktoriyaView] AS 
SELECT name, price
FROM Product
WHERE price > 50 AND price <100;


--Task2
CREATE OR ALTER FUNCTION [dbo].[PriceGoesUpViktoriya](@Price int)  
RETURNS int   
AS 
BEGIN  
    DECLARE @ret int;  
    IF (@Price > 100) SET @ret = @Price *1.1;
    IF (@Price < 100) SET @ret = @Price *1.3;
    RETURN @ret;  
END
GO

SELECT [dbo].PriceGoesUpViktoriya(50);
SELECT [dbo].PriceGoesUpViktoriya(110);


--Task3
CREATE OR ALTER PROCEDURE dbo.sp_ToCharViktoriya 
AS
BEGIN
SELECT CAST([dbo].PriceGoesUpViktoriya (product.Price) AS varchar(40)) AS Result
FROM Product
END

EXECUTE dbo.sp_ToCharViktoriya


--Task4
CREATE TABLE WishProducts(price int NOT NULL, name varchar(40));
CREATE TABLE WishProducts2(price int NOT NULL, count int NOT NULL);

CREATE OR ALTER PROCEDURE dbo.InsertToTablesViktoriya (@par1 int, @par2 varchar(40), @par3 int, @par4 int)
AS
BEGIN
   BEGIN TRANSACTION
	BEGIN TRY
       INSERT INTO  WishProducts VALUES ( @par1, @par2)
       INSERT INTO  WishProducts2 VALUES ( @par3, @par4)	
       SELECT * FROM WishProducts
       SELECT * FROM WishProducts2
    COMMIT TRANSACTION
    END TRY

    BEGIN CATCH
	 ROLLBACK TRANSACTION
    END CATCH
END

EXECUTE dbo.InsertToTablesViktoriya 38, 'tomatoes', 35, 8
EXECUTE dbo.InsertToTablesViktoriya 5, 'Potato', 'jjj', 1
EXECUTE dbo.InsertToTablesViktoriya 25, 'cucumber', 28, 10
