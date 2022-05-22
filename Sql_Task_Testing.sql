CREATE DATABASE TestingTask

USE TestingTask

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	CategoryName NVARCHAR(50)
);


CREATE TABLE Products (
	Id INT PRIMARY KEY,
	ProductName NVARCHAR(50)
);

CREATE TABLE CategoriProducts (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Categories
VALUES
	(1, 'Fruits'),
	(2, 'Vegetables'),
	(3, 'Fish'),
	(4, 'Meat');



INSERT INTO Products
VALUES
	(1, 'Apple'),
	(2, 'Cucumber'),
	(3, 'Carp'),
	(4, 'Hen'),
	(5, 'Milk');


INSERT INTO CategoriProducts
VALUES
	(1, 1),
	(2, 2),
	(3, 3);

SELECT Prod.ProductName, Categ.CategoryName
FROM Products as Prod
LEFT JOIN CategoriProducts CategProd
	ON Prod.Id = CategProd.ProductId
LEFT JOIN Categories as Categ
	ON CategProd.CategoryId = Categ.Id;