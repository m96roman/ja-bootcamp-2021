USE[BootcampTraining];
GO
CREATE OR ALTER PROCEDURE spInsertIngredient_Ivanyshyn
	@Name varchar(50),
	@Proteins decimal(3,1),
	@Fats decimal(3,1),
	@Carbonohydrates decimal(3,1),
	@MealId int,
	@Weight decimal(3,2)
AS
BEGIN
	DECLARE @ingredientId int

	BEGIN TRAN InsertTransaction
	
	BEGIN TRY

		INSERT INTO Ingredient (Name,Proteins,Carbohydrates,Fats)
		VALUES(@Name,@Proteins,@Fats,@Carbonohydrates)

		--Dont know if this will return valid output in case of paralelerism though
		SET @ingredientId=SCOPE_IDENTITY();

		INSERT INTO Recipe (IngredientId,MealId,Weight)
		VALUES(@ingredientId,@MealId,@Weight)

		COMMIT TRAN InsertTransaction
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN InsertTransaction
		SELECT ERROR_NUMBER() AS ErrorNumber  
			,ERROR_SEVERITY() AS ErrorSeverity  
			,ERROR_STATE() AS ErrorState  
			,ERROR_PROCEDURE() AS ErrorProcedure  
			,ERROR_LINE() AS ErrorLine  
			,ERROR_MESSAGE() AS ErrorMessage;  
	END CATCH
END
GO
EXEC spInsertIngredient_Ivanyshyn @Name='Chicken leg',@Proteins=1.2,@Fats=1.1,@Carbonohydrates=2.2,@MealId=1,@Weight=1.2