use BootcampTraining;


------------Task1 ------------------
	select 
		sum(Distance) CommonDistance
	from Trip with(nolock)


	select
		sum(TimeToCookInMins) CommonTimeToCook
	from Meal with(nolock)

-------------Task2-----------------------


	select
		mel.Name mealName,
		avg(rec.Weight) avgWeight
	from Recipe rec with(nolock)
	join Meal mel
		on rec.MealId = mel.Id
	group by mel.Name

----------------Task3-----------------------------
	select
		*
	from(
			select
				mel.Name mealName,
				avg(rec.Weight) avgWeight,
				count(rec.IngredientId) IngredientQty
			from Recipe rec with(nolock)
			join Meal mel
				on rec.MealId = mel.Id
			group by mel.Name
		) res
	where res.IngredientQty < 3
	order by res.avgWeight desc

------------Task4---------------------------------

	select Id, Name
	from Meal with(nolock)
	union 
	select Id, Name 
	from Ingredient with(nolock)
	
-----------Task5------------------------------------	


     select
		isnull(mel.Name, 'NoMealName') MealName,
		ing.Name IngredientName,
		isnull(mel.TimeToCookInMins, 0) TimeToCookInMins
	from Recipe rec with(nolock)
	join Meal mel
	on rec.MealId = mel.Id
	right join Ingredient ing
	on rec.IngredientId = ing.Id
	where  mel.TimeToCookInMins < 20 or rec.IngredientId is null

--------------------------------------------------------------------------	  

	  