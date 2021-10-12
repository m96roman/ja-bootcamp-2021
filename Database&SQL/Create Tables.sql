USE BootcampTraining;

CREATE TABLE Ingredient
(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Name VARCHAR(50) NOT NULL UNIQUE,
	Proteins DECIMAL(3,1) NOT NULL,
	Fats DECIMAL(3,1) NOT NULL,
	Carbohydrates DECIMAL(3,1) NOT NULL
);

CREATE TABLE Meal
(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Name VARCHAR(50) NOT NULL UNIQUE,
	TimeToCookInMins INT NOT NULL,
	Dificulty INT DEFAULT 1,
	CHECK(Dificulty BETWEEN 1 AND 5),
);

CREATE TABLE Recipe
(
	MealId INT NOT NULL FOREIGN KEY REFERENCES Meal(Id),
	IngredientId INT NOT NULL FOREIGN KEY REFERENCES Ingredient(Id),
	Weight DECIMAL(3,2) NOT NULL,
	CONSTRAINT IdRecipe PRIMARY KEY (MealId, IngredientId)
);