CREATE DATABASE AccountsApiDb
USE AccountsApiDb

CREATE TABLE Account(
AccountId INT IDENTITY(5000,1) PRIMARY KEY,
CustomerId INT,
AccountType VARCHAR(20),
Balance FLOAT

)

CREATE TABLE AccountStatus(

StatusId INT IDENTITY(1,1) PRIMARY KEY,
AccountId INT,
AccountCreationStatus VARCHAR(20),
)

CREATE TABLE AccountStatement(
TransactionId INT IDENTITY(1,1) PRIMARY KEY,
AccountId INT,
TransactionDate DATE,
Descriptions VARCHAR(100),
ValueDate DATE,
Amount FLOAT,
TransactionType VARCHAR(20),
TransactionStatus VARCHAR(20),
ClosingBalance FLOAT,

)

SELECT * FROM Account
SELECT * FROM AccountStatus
SELECT * FROM AccountStatement



