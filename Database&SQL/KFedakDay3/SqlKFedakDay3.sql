USE BootcampTraining;
SELECT * FROM ALL_CARS_Fedak
PRINT [dbo].[GetString_Fedak](98)
EXEC [dbo].[INT_TO_STRING_FEDAK]
EXEC Sorted_Procedure_FEDAK @BrandName = 'AUDI', @Name = 'A6',@MaxSpeed=220;
