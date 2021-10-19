USE BootcampTraining;

GO --Task 1

CREATE OR ALTER VIEW ComplexViewDovhanych
AS
SELECT cb.Name AS Brand, cm.Name AS Model
FROM CarBrand cb
INNER JOIN CarModel cm
ON cb.Id = cm.BrandId
WHERE cm.BrandId > 10;

GO --Task 2

CREATE OR ALTER FUNCTION [dbo].converterDovhanych(@n INT)
RETURNS VARCHAR(40)
AS
BEGIN
	DECLARE @num VARCHAR(40)
	SET @num = (SELECT CAST((@n) AS VARCHAR(40)) + ' as string')
	RETURN @num
END

GO 

SELECT [dbo].converterDovhanych(5);

GO --Task 3

CREATE OR ALTER PROCEDURE [dbo].spDovhanych_ConvertValues
AS
BEGIN
	SELECT [dbo].converterDovhanych(CarModel.BrandId) AS [Brand ID] FROM CarModel
END

GO

EXEC [dbo].spDovhanych_ConvertValues;

GO --Task 4

CREATE OR ALTER PROCEDURE [dbo].spDovhanych_Insert
	@BrandId INT, @Name VARCHAR(40), @MaxSpeed INT
AS
BEGIN 
	IF NOT EXISTS(SELECT * FROM CarBrand cb WITH (NOLOCK) WHERE cb.Id =@BrandId)
	BEGIN
		RAISERROR ('Brand Id doesnt exists', 10, 1)
		RETURN -1
	END

	BEGIN TRANSACTION

	BEGIN TRY
		INSERT INTO CarBrand(Name) VALUES (@Name);
		INSERT INTO CarModel(BrandId, Name, MaxSpeed) VALUES (@BrandId, @Name, @MaxSpeed);

		COMMIT TRANSACTION

	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0
		BEGIN
			ROLLBACK TRANSACTION
		END

	END CATCH
END

EXECUTE [dbo].spDovhanych_Insert 6, 'Test', 300;

SELECT * FROM CarBrand;