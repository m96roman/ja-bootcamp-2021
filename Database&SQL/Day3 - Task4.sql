CREATE OR ALTER PROCEDURE YaroslavB_ComplexProcedure
@MealName nvarchar(50),
@TimeToCookInMin int,
@IngridientName nvarchar(50),
@Proteins int,
@Fats int,
@Carbohydrates int

AS
BEGIN
	BEGIN TRANSACTION

	BEGIN TRY
		INSERT INTO Meal (Name, TimeToCookInMins)
		VALUES (@MealName, @TimeToCookInMin)
		
		INSERT INTO Ingredient (Name, Proteins, Fats, Carbohydrates)
		VALUES (@IngridientName, @Proteins, @Fats, @Carbohydrates)

		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0
		BEGIN
			ROLLBACK TRANSACTION
		END
	END CATCH

	IF @@TRANCOUNT > 0
		BEGIN
			COMMIT TRANSACTION
		END

END
GO