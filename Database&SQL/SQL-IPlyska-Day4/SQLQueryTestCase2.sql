use BootcampTraining;

exec tSQLt.DropClass 'Test_spUnitTestClassIPlyska'​
go

exec tSQLt.NewTestClass 'Test_spUnitTestClassIPlyska'
go

create procedure Test_spUnitTestClassIPlyska.[Setup]​

as begin​

   exec tSQLt.FakeTable 'MealFake', @Identity=1​

   exec tSQLt.FakeTable 'RecipeFake'​

   

end​
go


create procedure Test_spUnitTestClassIPlyska.[test 2, happy path]

as begin​
		
	  create table #Expected (Id int, name nvarchar(40), timeToCook int )​
	  --insert into #Expected (Id, name, timeToCook)​
   --   values(1, N'CRISPY CHEESE BITES', 20)​

	  create table #Expected2 (MealId int, IngrId int, Weight int )​
	  --insert into #Expected (Id, name, timeToCook)​
   --   values(1, N'CRISPY CHEESE BITES', 20)​

       insert into #Expected exec sp_Add_IPlyska(1, N'CRISPY CHEESE BITES', 20)

end

select * from Meal

select * from Recipe
