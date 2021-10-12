-- 1 -------------------------
Select sum(Distance) from Trip

--2---------------------------
Select CB.NAME, MAX(CM.MaxSpeed) from CarModel as CM
Inner Join CarBrand AS CB on  cm.BrandId = CB.ID
GROUP BY CB.Name

--3---------------------------
Select CB.NAME,CB.ID, MAX(CM.MaxSpeed) as MAXSPEED from CarModel as CM
Inner Join CarBrand AS CB on  cm.BrandId = CB.ID
GROUP BY CB.Name, CB.ID
Having Count(CM.BrandId) > 1

--4----------------------------
Select ID, Name from CarBrand
Union
Select ID,Name from CarModel
Order by Name

--5----------------------------
Select CB.Name, CM.NAME, DATEDIFF(MINUTE, T.StartDate, T.EndDate) as Minutes from CarBrand  as CB
INNER Join CarModel as CM on CB.ID = CM.BrandId
INNER Join Car as C on CM.ID = C.ModelId
Right Join Trip as T on C.ID = T.CarId
Where DATEDIFF(hour, T.StartDate, T.EndDate) < 1 OR StartDate IS NULL

--select * from CarBrand
--select * from CarModel
--select * from CarModel
--select * from Trip

--select * from CarBrand
--join CarModel on CarBrand.ID = CarModel.BrandId
--join Car on CarModel.ID = Car.ModelId
--join Trip on Car.ID = CarId