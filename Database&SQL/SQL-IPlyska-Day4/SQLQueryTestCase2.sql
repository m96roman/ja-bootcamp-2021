use BootcampTraining;

exec tSQLt.DropClass 'Test_spUnitTestClassIPlyska'​
go

exec tSQLt.NewTestClass 'Test_spUnitTestClassIPlyska'
go

exec tSQLt.DropClass 'Test_spUnitTestClassIPlyska2'​
go 

exec tSQLt.NewTestClass 'Test_spUnitTestClassIPlyska2'
go

create or alter  procedure Test_spUnitTestClassIPlyska.[Setup]​

as begin​

   exec tSQLt.FakeTable 'Meal', @Identity=1​

   exec tSQLt.FakeTable 'Recipe'​

end​
go


create or alter procedure Test_spUnitTestClassIPlyska.[test 2, happy path]

as begin​
		
	  create table #Expected1 (Id int, name nvarchar(40), TimeToCookInMins int )​
	  insert into #Expected1 (Id, name, TimeToCookInMins)​
      values(1, N'CRISPY CHEESE BITES', 20)​;

	  create table #Expected2 (MealId int, IngredientId int, Weight int )​
	  insert into #Expected2 (MealId, IngredientId, Weight)​
      values(3,4,300)​;

      exec sp_Add_IPlyska 'CRISPY CHEESE BITES', 20, 3, 4,300

	  exec tSQLt.AssertEqualsTable #Expected1, Meal

	  exec tSQLt.AssertEqualsTable #Expected2, Recipe


end
go

create or alter procedure Test_spUnitTestClassIPlyska2.[test 1, happy path]

as begin

	create table #tempTable(mealName varchar(40), ingredientName varchar(40), timeToCoo int, timeToCookChar varchar(40))

	create table #expected(mealName varchar(40), ingredientName varchar(40), timeToCoo int, timeToCookChar varchar(40))
	select top 0 * into #actual FROM #expected;​

	insert into #expected (mealName, ingredientName, timeToCoo, timeToCookChar)
	values('OMELET EGG ROLL', N'Egg', 15, '15 as string');

	insert into #tempTable exec sp_ConvertToChar_IPlyska

	insert into #actual
	select * from #tempTable with(nolock)
	where mealName = 'OMELET EGG ROLL' and ingredientName = 'Egg'

	exec tSQLt.AssertEqualsTable #expected, #actual​
end
go


exec tSQLt.Run'Test_spUnitTestClassIPlyska'

exec tSQLt.Run 'Test_spUnitTestClassIPlyska2'


