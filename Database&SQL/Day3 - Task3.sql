CREATE OR ALTER PROCEDURE YaroslavB_ProteinsMore20
AS
BEGIN
	SELECT Name Ingridient, dbo.YaroslavB_IntToString(Proteins) ProteinsInGrams
	FROM Ingredient
	WHERE Proteins > 20
END