CREATE DATABASE TransactionApiDb
USE TransactionApiDb

CREATE TABLE TransactionHistory(
TransactionId INT IDENTITY(1,1) PRIMARY KEY,
TransactionDate DATETIME ,
TransactionType VARCHAR(20),
FromAccount INT,
ToAccount INT,
Amount float,
TransactionStatus varchar(20)
)

SELECT * FROM TransactionHistORY

