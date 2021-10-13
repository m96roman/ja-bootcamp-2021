USE BootcampTraining;
GO
CREATE OR ALTER PROCEDURE Sorted_Procedure_FEDAK
	@BrandName VARCHAR(40),
	@Name VARCHAR(40),
	@MaxSpeed INT
AS
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO CarBrand(Name)
			VALUES(@BrandName)
			INSERT INTO CarModel(BrandId,Name,MaxSpeed)
			VALUES (SCOPE_IDENTITY(),@Name,@MaxSpeed)
	COMMIT TRANSACTION
		END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			BEGIN
				ROLLBACK TRANSACTION
			END
		DECLARE @ErrorMessage NVARCHAR(4000),@ErrorSeverity int,@ErrorState int, @ErrorProcedure VARCHAR(40)
		SELECT 
			@ErrorMessage = ERROR_MESSAGE(),  
			@ErrorSeverity = ERROR_SEVERITY(),  
			@ErrorState = ERROR_STATE(),
			@ErrorProcedure=ERROR_PROCEDURE() 
		RAISERROR(@ErrorMessage,@ErrorSeverity,@ErrorState,@ErrorProcedure)
	END CATCH
END
