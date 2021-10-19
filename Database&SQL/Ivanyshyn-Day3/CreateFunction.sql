USE[BootcampTraining];
GO
CREATE OR ALTER FUNCTION dbo.GetIntAsString_Ivanyshyn(@number AS int)
RETURNS varchar(40)
AS
BEGIN
	DECLARE @res varchar(40);
	SET @res=CAST(@number AS varchar(16))+' as string'
	
	RETURN @res;
END;
