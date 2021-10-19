
-- Task 4

USE [BootcampTraining];
GO

CREATE OR ALTER PROCEDURE AddEasyMealWithOneIngredientVasyl
	@MealName VARCHAR(50),
	@TimeToCookInMins INT,
	@Dificulty INT,
	@IngredirntId INT, 
	@MealWeight DECIMAL(3,2)
AS
BEGIN
	DECLARE @LastInsertedIndexMealTable INT

	BEGIN TRAN

	BEGIN TRY
		INSERT INTO [dbo].[Meal] (Name, TimeToCookInMins, Difficulty)
		VALUES (@MealName, @TimeToCookInMins, @Dificulty);
		INSERT INTO [dbo].[Recipe] (MealId, IngredientId, Weight)
		VALUES ((SELECT IDENT_CURRENT('[dbo].[Meal]')), @IngredirntId, @MealWeight);

		COMMIT TRAN
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0
		BEGIN
			ROLLBACK TRAN
		END

		--Raise an error with the details of the exception
		DECLARE @ErrMsg NVARCHAR(4000), @ErrSeverity INT
		SELECT @ErrMsg = ERROR_MESSAGE(), @ErrSeverity = ERROR_SEVERITY()

		RAISERROR(@ErrMsg, @ErrSeverity, 1)

	END CATCH
END