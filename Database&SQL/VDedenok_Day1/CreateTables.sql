Use BootcampTraining

CREATE TABLE Customer (
ID INT NOT NULL PRIMARY KEY
IDENTITY(1,1),
Name varchar(50),
);

CREATE TABLE Product (
ID INT NOT NULL PRIMARY KEY IDENTITY(10,1), 
Name varchar(50),
Price INT NOT NULL
);

CREATE TABLE Payment (
ID INT NOT NULL PRIMARY KEY IDENTITY(20,1), 
CustomerID INT NOT NULL FOREIGN KEY REFERENCES Customer(ID), 
Price INT NOT NULL
);

CREATE TABLE PaymentProduct (
ProductID INT NOT NULL FOREIGN KEY REFERENCES Product(ID), 
PaymentID INT NOT NULL FOREIGN KEY REFERENCES Payment(ID), 
);

INSERT INTO Customer (name)
VALUES ('Anna'), ('Vita'),('Alina'), ('Mykola'), ('Oksan'), ('Vadim'), ('Nikita'), ('Marina'), ('Ihor'), ('Oleh'), ('Serhiy');

INSERT INTO Product (name, price)
VALUES ('milk', 33),  ('bread', 24), ('apples', 18), ('bananas', 36), ('carrot', 17), ('cheese', 190), ('meat', 150 ), ('salt', 12), ('butter', 55), ('jogurt', 23);

INSERT INTO Payment (customerid, price)
VALUES (1, 100), (2, 125), (3, 45), (4, 465), (5, 122), (6, 265), (7, 101), (8, 95);

INSERT INTO PaymentProduct (ProductID, PaymentID)
VALUES (10, 20), (11, 25), (12, 27), (13, 23), (14, 22), (15, 27);




