CREATE TABLE Customers(
	CustomersID INT IDENTITY(1, 1) NOT NULL,
	FirstName NVARCHAR(200) NOT NULL,
	LastName NVARCHAR(200) NOT NULL,
	CardNumber INT NOT NULL, --before 'not null' one could place a check for number size 'CHECK (CardNumber >=99999999)'
	CONSTRAINT PK_Customers PRIMARY KEY (CustomersID)
);

CREATE TABLE Products(
	ProductsID INT IDENTITY(1, 1) NOT NULL,
	Name NVARCHAR(200) NOT NULL,
	Price NUMERIC(10,2) NOT NULL,
	CONSTRAINT PK_ProductsID PRIMARY KEY (ProductsID)
);

CREATE TABLE Orders (
	OrdersID INT NOT NULL,
	ProductsID INT NOT NULL,
	CustomersID INT NOT NULL,
	CONSTRAINT PK_Orders PRIMARY KEY (CustomersID, ProductsID),
	CONSTRAINT FK_Orders_Customers_CustomersID FOREIGN KEY (CustomersID)
		REFERENCES Customers (CustomersID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_Orders_Products_ProductsID FOREIGN KEY (ProductsID)
		REFERENCES Products (ProductsID) ON DELETE CASCADE ON UPDATE CASCADE
);

INSERT INTO Products (Name, Price) VALUES 
		('Tablet', 100),
		('Radio', 45),
		('Alarm Clock', 20);

INSERT INTO Customers (FirstName, LastName, CardNumber) VALUES
		('Daniel', 'Aasa', 88888888),
		('Mike', 'Hale', 99999999),
		('John', 'Smith', 12345678);

INSERT INTO Orders (OrdersID, ProductsID, CustomersID) VALUES
		(1, 1, 1),
		(2, 2, 2),
		(3, 3, 3);

INSERT INTO Products (Name, Price) VALUES
		('iPhone', 200);

INSERT INTO Customers (FirstName, LastName, CardNumber) VALUES
		('Tina', 'Smith', 0000000)

INSERT INTO Orders (OrdersID, ProductsID, CustomersID) VALUES
		(4, 4, 4);

SELECT Customers.FirstName, Customers.LastName, Orders.OrdersID
FROM Customers
	left JOIN Orders ON Customers.CustomersID = Orders.CustomersID
	--right JOIN Products ON Orders.ProductsID = Products.ProductsID;
WHERE Customers.FirstName = 'Tina' AND Customers.LastName = 'Smith';

SELECT SUM(Price) as iPhonesum
FROM Products
	FULL JOIN Orders ON Products.ProductsID = Orders.ProductsID
WHERE Products.Name = 'iPhone';

UPDATE Products
SET Price = 250
WHERE Name = 'iPhone';