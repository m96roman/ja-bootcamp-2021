USE BootcampTraining

--==============================Task1===============================
CREATE OR ALTER VIEW  [MartinView] AS 
SELECT CarBrand.Name, CarModel.Name AS Model
FROM CarBrand
INNER JOIN CarModel ON CarBrand.Id = CarModel.BrandId 
WHERE CarBrand.Name = 'Toyota'

SELECT * FROM MartinView;

--==============================Task2================================
CREATE OR ALTER FUNCTION [dbo].[fn_martin_function] 
(
@InputValue AS int
)
RETURNS VARCHAR(40)
AS 
BEGIN
	DECLARE @Return VARCHAR(40)
	SET @Return =  CONCAT(CONVERT(VARCHAR(40),@InputValue), ' as string')
	RETURN @Return
END
GO

SELECT [dbo].fn_martin_function(345);

--Task3
CREATE OR ALTER PROCEDURE sp_convert_to_string_martin
AS
BEGIN
	SELECT [dbo].fn_martin_function(Trip.Distance) AS Distance FROM Trip
END;

EXECUTE sp_convert_to_string_martin;

--==============================================Task4=====================
CREATE OR ALTER PROCEDURE sp_insert_martin
	
	@CarBrandId INT = NULL,
	@Name VARCHAR(20) = NULL,
	@MaxSpeed INT = NULL

AS
BEGIN
	IF NOT EXISTS(SELECT CarBrand.Id FROM CarBrand WHERE CarBrand.Id = @CarBrandId )
	BEGIN
		RAISERROR('INCORECT INPUT DATA',11,1)
		RETURN -1;
	END

	BEGIN TRANSACTION

	BEGIN TRY

		INSERT INTO CarModel (BrandId,Name,MaxSpeed) VALUES (@CarBrandId,@Name,@MaxSpeed)

		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0
		BEGIN

			ROLLBACK TRANSACTION

		END
	END CATCH
END

EXECUTE sp_insert_martin 3,Q4,400

SELECT * From CarModel WHERE CarModel.BrandId = 3