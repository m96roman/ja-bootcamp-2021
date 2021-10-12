USE BootcampTraining;

CREATE TABLE Customer (
	CustomerId INT PRIMARY KEY IDENTITY(1,1),
	CustomerName VarChar(40) NOT NULL
	);

INSERT INTO Customer (CustomerName)
VALUES ('Valera'),('Ignat'),('Misha'),('Grisha'),('John');


CREATE TABLE Product (
	ProductId INT PRIMARY KEY IDENTITY(1,1),
	Name VarChar(50) NOT NULL,
	Price INT
);

INSERT INTO Product (Name, Price)
VALUES ('Laptop', 500), ('Phone', 200), ('Microwave', 150), ('SIM Card', 10);


CREATE TABLE Payment (
	Id INT PRIMARY KEY IDENTITY(1,1),
	CustomerId INT FOREIGN KEY REFERENCES Customer (CustomerId),
	Price INT NOT NULL
);

INSERT INTO Payment (CustomerId, Price)
VALUES (1,700), (3,160);

CREATE TABLE PaymentProducts (
	PaymentId INT FOREIGN KEY (PaymentId)  REFERENCES Payment (Id),
	ProductId INT FOREIGN KEY (ProductId)  REFERENCES Product (ProductId)
);

INSERT INTO PaymentProducts (PaymentId, ProductId)
VALUES (1,1), (1,2), (2,3), (2,4);


DROP TABLE PaymentProducts, Payment, Product, Customer



