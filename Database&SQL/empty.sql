USE BootcampTraining
CREATE VIEW view_CarBrandWithModel_Shyptur AS
SELECT CarBrand.Name, CarModel.Name AS NameModel, CarModel.MaxSpeed
FROM CarBrand 
  INNER JOIN CarModel
   ON CarBrand.Id = CarModel.BrandId --TASK 1

   
CREATE OR ALTER FUNCTION SpeedToString_SHYPTUR
   (@locParam int)
   RETURNS varchar(40)
   AS
   BEGIN
		DECLARE @return varchar(40)
		SELECT @return = CAST(@locParam AS varchar(40))
		set @return= (SELECT CONCAT(@return,'_as string'))

	RETURN @return;
	END -- TASK 2



CREATE OR ALTER PROCEDURE 	GetNewTable_Shyptur
AS
BEGIN
 SELECT Name, NameModel, [dbo].SpeedToString_SHYPTUR(view_CarBrandWithModel_Shyptur.MaxSpeed) AS MaxSpeedString From view_CarBrandWithModel_Shyptur
END

EXECUTE GetNewTable_Shyptur --TASK 3

CREATE  OR ALTER PROCEDURE 	StoredProcedure_Shyptur
	@NameBrand varchar(40),
	@NameModel varchar(40),
	@MaxSpeed INT
AS
BEGIN 
	IF EXISTS(SELECT * FROM CarBrand WHERE CarBrand.Name=@NameBrand)
	BEGIN
		RAISERROR('Car brand EXIST',11,1)
		RETURN -1
	END
	BEGIN TRANSACTION
	BEGIN TRY 
		DECLARE @id int
		
		INSERT INTO CarBrand(Name) VALUES (@NameBrand)
		set @id= (select id from CarBrand WHERE Name=@NameBrand)
		INSERT INTO CarModel(BrandId,Name,MaxSpeed) VALUES (@id, @NameModel,@MaxSpeed)

		COMMIT TRANSACTION
     END TRY
	 BEGIN CATCH
		IF @@TRANCOUNT > 0
			BEGIN
				ROLLBACK TRANSACTION
			END

	END CATCH
END	

EXECUTE StoredProcedure_Shyptur 'Ferrari1','f40',300

select * from view_CarBrandWithModel_Shyptur
SELECT * FROM CarBrand


