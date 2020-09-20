create database NightSightsDb

use NightSightsDb

DROP TABLE IF EXISTS Customer;
CREATE TABLE Customer(
    Id INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(40),
    LastName NVARCHAR(40),
    MiddleName NVARCHAR(40),
    Email NVARCHAR(80),
    Password NVARCHAR(40)
);

INSERT INTO Customer(FirstName, MiddleName, LastName, Email, Password)
    VALUES('Cody', 'Thomas', 'Chester', 'NightSights@outlook.com', 'password');

SELECT * FROM Customer;

DROP TABLE IF EXISTS Product;
CREATE TABLE Product(
    Id INT PRIMARY KEY IDENTITY,
    Coffee NVARCHAR(40),
    Description NVARCHAR(400),
    RoastType NVARCHAR(120),
    Price INT,
    CustomerId INT FOREIGN KEY REFERENCES Customer(Id)
);

INSERT INTO Product(Coffee, Description, RoastType, Price, CustomerId)
    VALUES('Single Orgin Columbia', 'Full description of the coffee and tasting notes', 'Espresso Roast', 19.99, 1);

SELECT * FROM Product;

DROP TABLE IF EXISTS Cart;
CREATE TABLE Cart(
    Id INT PRIMARY KEY IDENTITY,
	CustomerId INT FOREIGN KEY REFERENCES Customer(Id),
    ProductId INT FOREIGN KEY REFERENCES Product(Id),
	Description NVARCHAR(400),
);

INSERT INTO Cart(CustomerId, ProductId, Description)
    VALUES(1, 1, 'The contents of the cart with the total price');

SELECT * FROM Cart;
