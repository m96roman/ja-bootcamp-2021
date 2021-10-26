DROP DATABASE IF EXISTS sql_exchange_rates;
CREATE DATABASE sql_exchange_rates; 
USE sql_exchange_rates;

CREATE TABLE Currency (
  Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
  IsoCode nvarchar(40) NOT NULL, 
  IsoNumber int NOT NULL, 
  Description nvarchar(40) NOT NULL,
) 

CREATE TABLE ExchangeRates(
  Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
  CurrencyId int NOT NULL FOREIGN KEY REFERENCES Currency(Id),
  RateToUsd decimal(5,3) NOT NULL,
  RowInsert DateTime NOT NULL,
) 
 
INSERT INTO Currency VALUES
	('EUR',978,'Euro'),
	('GBP',826,'Pound sterling'),
	('CAD',124,'Canadian dollar'),
	('JPY',392,'Japanese yen'),
	('AUD',036,'Australian dollar');

INSERT INTO ExchangeRates VALUES
	(1,0.86,getdate()),
	(2,0.73,getdate()),
	(3,1.23,getdate()),
	(4,113.75,getdate()),
	(5,1.33,getdate());
	INSERT INTO ExchangeRates VALUES (4, 113.75 , getdate());