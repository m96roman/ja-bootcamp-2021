USE BootcampTraining;
GO
CREATE OR ALTER PROCEDURE INT_TO_STRING_FEDAK
AS
BEGIN
	SELECT c.Name,[dbo].[GetString_Fedak](c.MaxSpeed) 'Result' FROM CarModel c;
END