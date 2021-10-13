
-- Task 2

USE [BootcampTraining];
GO

CREATE OR ALTER FUNCTION [ConverterVasyl]
	(@number INT)
RETURNS VARCHAR(30)
AS
BEGIN
	RETURN CONCAT(CONVERT(varchar(10), @number), ' as string')
END