return;


-----------------Task1--------------------------------
create view IPlyskaView as

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

	
----------------------Task2---------------------------------------------
	alter function func_ConvertToString_IPlyska(@input int)

	returns varchar(40)

		begin
			return concat(@input, ' as string')
		end

 
-------------------------------------------------------------
  create procedure sp_ConvertToChar_IPlysk
  as begin
              select
				*,
				dbo.func_ConvertToString_IPlyska(TimeToCookInMins) CharTimeToCook
			  from IPlyskaView
			  
  return 1;
  end
-----------------------------------------------------
  create procedure sp_Add_IPlyska 'Test', 20, 100, 30, 40
  @Name nvarchar(20),
  @time int,
  @mealId int,
  @ingId int,
  @weight int

  as begin
			begin transaction
				begin try

					insert into Meal(Name, TimeToCookInMins)
					values(@Name, @time)

					insert into Recipe(MealId, IngredientId, Weight)
					values(@mealId, @ingId, @weight)

				end try
				begin catch
					if (@@TRANCOUNT > 0)
						begin
							rollback transaction 
						end

						declare @ErrMesage nvarchar(max),
						@ErrSevr nvarchar(max)
						 
						 --set @ErrMesage = ERROR_SEVERITY()
						 --set @ErrSevr = ERROR_MESSAGE()
						
						select @ErrMesage = ERROR_SEVERITY(), @ErrSevr = ERROR_MESSAGE()
						--RAISEERROR(@ErrMesage, @ErrSevr,1)

				end catch

  end

-----------------------------------------------------------------------------

  select * from Meal
  select * from [dbo].[Recipe]

  select * from IPlyskaView

  select dbo.func_ConvertToString_IPlyska(10)
