
--1-------------------------------------
CREATE VIEW CarViewNestor AS
SELECT CarBrand.ID as CarViewId, CarBrand.Name as CarViewName
FROM CarBrand

select* from CarViewNestor
join CarModel on CarViewId= CarModel.BrandId 
join Car on car.ModelId = CarModel.ID

--2-------------------------------------
go
CREATE FUNCTION ConvertToStringNestor
(@integer int )
RETURNS VARCHAR (40)
AS 
BEGIN
DECLARE @Return VARCHAR (40)
SELECT @return = 
case @integer
when @integer then concat(CONVERT(varchar(10),@integer),' as string')
END
RETURN @return
end
go

select dbo.ConvertToStringNestor(30) 

--3-------------------------------------
go
CREATE PROCEDURE dbo.SelectAllCarsIdNestor
AS
Begin
Select dbo.ConvertToStringNestor(CarModel.ID) as AsString from CarModel
end
go

EXEC dbo.SelectAllCarsIdNestor

--4--------------------------------------
go 
CREATE OR ALTER PROCEDURE dbo.TaskNestor @Brand VARCHAR(30), @Model Varchar(30)
AS
BEGIN TRANSACTION
BEGIN TRY
INSERT INTO CarModel (Name)
values (@Brand)
END TRY
BEGIN CATCH
SELECT ERROR_NUMBER() AS ERRORNUMBER
INSERT INTO CarBrand(Name)
values (@Brand)
END CATCH
COMMIT TRAN
GO;

SELECT * FROM CarBrand

EXEC dbo.TaskNestor @Brand = 'KTHGJHFGH', @Model = 'DSFS'