use BootcampTraining;

exec tSQLt.DropClass 'Test_spUnitTestClassIPlyska'​
go

exec tSQLt.NewTestClass 'Test_spUnitTestClassIPlyska'
go

create procedure Test_spUnitTestClassIPlyska.[test 1, happy path]

as begin

	create table #tempTable(mealName nvarchar(40), ingredientName nvarchar(40), timeToCoo int, timeToCookChar nvarchar(40))

	create table #expected(mealName nvarchar(40), ingredientName nvarchar(40), timeToCoo int, timeToCookChar nvarchar(40))
	select top 0 * into #actual FROM #expected;​

	insert into #expected (mealName, ingredientName, timeToCoo, timeToCookChar)
	values(N'OMELET EGG ROLL', N'Egg', 15, N'15 as string');

	insert into #tempTable exec sp_ConvertToChar_IPlyska

	insert into #actual
	select * from #tempTable
	where mealName = 'OMELET EGG ROLL' and ingredientName = 'Egg'

	 exec tSQLt.AssertEqualsTable #expected, #actual​
end
go

exec tSQLt.Run 'Test_spUnitTestClassIPlyska.[test 1, happy path]'
go
 
