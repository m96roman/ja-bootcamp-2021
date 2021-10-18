CREATE OR ALTER FUNCTION YaroslavB_IntToString(@value INT)
	RETURNS varchar(40)
AS
BEGIN
	DECLARE @return varchar(40)
	SET @return = LTRIM(STR(@value)) + ' as string'
	RETURN @return
END
