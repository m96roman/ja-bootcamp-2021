USE BootcampTraining;

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
		('Onion',	1.7,	2.2,	8.8);

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
		('White something',	3,	1);

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
		(5,	10,	1.00);