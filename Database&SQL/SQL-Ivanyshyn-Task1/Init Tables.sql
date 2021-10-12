USE BootcampTraining;

CREATE TABLE Ingredient
(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Name VARCHAR(50) NOT NULL UNIQUE,
	Proteins DECIMAL(3,1) NOT NULL,
	Fats DECIMAL(3,1) NOT NULL,
	Carbohydrates DECIMAL(3,1) NOT NULL
);
GO

CREATE TABLE Meal
(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Name VARCHAR(50) NOT NULL UNIQUE,
	TimeToCookInMins INT NOT NULL,
	Dificulty INT DEFAULT 1,
	CHECK(Dificulty BETWEEN 1 AND 5),
);
GO

CREATE TABLE Recipe
(
	MealId INT NOT NULL FOREIGN KEY REFERENCES Meal(Id),
	IngredientId INT NOT NULL FOREIGN KEY REFERENCES Ingredient(Id),
	Weight DECIMAL(3,2) NOT NULL,
	CONSTRAINT IdRecipe PRIMARY KEY (MealId, IngredientId)
);
GO

INSERT INTO Ingredient (Name,Proteins,Fats,Carbohydrates)
VALUES ('Cucumber',	4.0,1.6,14.0),
		('Cabbage',1.0,0.1,2.0),
		('Chesse dor blue',21.0,29.0,2.0),
		('Sausage common',	14.0,	31.0,	1.7),
		('Mayo',	1.5,	75.0,	1.2),
		('Potato',	2.0,	0.7,	17.0),
		('Pepper',	2.0,	0.5,	9.0),
		('Carrot',	1.2,	0.2,	10.0),
		('Tomato',	0.8,	0.3,	4.2),
		('Onion',	1.7,	2.2,	8.8)
GO

INSERT INTO Meal (Name,TimeToCookInMins,Difficulty)
VALUES ('Onion soup',	12,1),
		('Meat with wheat',	10,	5),
		('Sausages in flavour',	30,	4),
		('Rusty creadcrumds',	10,	3),
		('Small pizza',	20,	2),
		('Rotten meat',	10,	1),
		('Potato with sausage',	2,	2),
		('Mayo wit mayo',	1,	1),
		('Yellow something',	2,	1),
		('White something',	3,	1)
GO

INSERT INTO Recipe (MealId,IngredientId,Weight)
VALUES (1,	6,	0.50),
		(1,	7,	0.10),
		(1,	10,	0.20),
		(2,	2	,5.50),
		(2,	3,	2.20),
		(2,	4,	4.40),
		(3,	2,	4.50),
		(3,	3,	2.20),
		(3,	4,	4.40),
		(3,	7,	6.60),
		(4,	3,	4.50),
		(4,	5,	6.00),
		(4,	9,	1.20),
		(5,	1,	2.00),
		(5,	2,	3.00),
		(5,	10,	1.00)
