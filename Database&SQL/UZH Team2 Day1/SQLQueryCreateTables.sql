use BootcampTraining;

GO
create table Ingredient
(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	Proteins int not null,
	Fats int not null,
	Carbohydrates int not null,
	status bit default(1) not null,
	date datetime default(getdate())
)

GO

create table Meal
(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	TimeToCookInMins​ int not null,
	status bit default(1) not null,
	date datetime default(getdate())

)

Go
create table Recipe
(
	MealId int  FOREIGN KEY REFERENCES Meal(Id),
	IngredientId int FOREIGN KEY REFERENCES Ingredient(Id),
	Weight int not null,
	status bit default(1) not null,
	date datetime default(getdate())

)

