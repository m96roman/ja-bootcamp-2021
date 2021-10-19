 CREATE OR ALTER FUNCTION GetString_Fedak (@n AS INT)  
 RETURNS VARCHAR(40) AS
    BEGIN
		RETURN (SELECT CONVERT(varchar(40),@n)) + ' as string'
  END;
