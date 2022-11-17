CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Name varchar(20)
);

INSERT INTO Products 
VALUES
	(1, 'Desk'),
	(2, 'Apple'),
	(3, 'Mouse');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name varchar(20)
);

INSERT INTO Categories
VALUES
	(1, 'Furniture'),
	(2, 'Brand'),
	(3, 'Food');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(2, 2),
	(2, 3);

SELECT product.Name, category.Name
FROM Products product
LEFT JOIN ProductCategories productCategories
	ON product.Id = productCategories.ProductId
LEFT JOIN Categories category
	ON productCategories.CategoryId = category.Id
ORDER BY product.Name;;