USE [BootcampTraining];

INSERT INTO Ingredient (Name, Proteins, Fats, Carbohydrates)
values
('Egg', 42, 27, 12),
('Bacon', 34, 47, 15),
('Onion', 0, 2, 5),
('Milk', 17, 36, 23),
('Cheese', 22, 62, 14),
('Apple', 0, 5, 75),
('Fish', 38, 34, 28)
go

INSERT INTO Meal (Name, TimeToCookInMins)
values
('OMELET EGG ROLL', 15),
('CRISPY CHEESE BITES', 10),
('BACON WRAPPED MINI OMELET', 30),
('PARMESAN FISH STICKS', 25),
('EGG IN AN ONION', 7)
go


INSERT INTO Recipe (MealId, IngredientId, Weight)
values
(1, 1, 200),
(1, 4, 70),
(2, 5, 300),
(2, 6, 30),
(2, 3, 10),
(3, 2, 250),
(3, 1, 200),
(3, 4, 150),
(3, 5, 70),
(4, 5, 400),
(4, 7, 250),
(4, 3, 20),
(5, 1, 350),
(5, 3, 170)
go