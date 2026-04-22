CREATE TABLE Customers (CustomerID INT PRIMARY KEY, Name VARCHAR(50), City VARCHAR(50), Email VARCHAR(50));

CREATE TABLE Orders (OrderID INT PRIMARY KEY, CustomerID INT, OrderDate DATE, Amount DECIMAL(10,2),
FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID));

INSERT INTO Customers (CustomerID, Name, City, Email) 
	VALUES 
	(1, 'Alice', 'New York','alice@example.com'),
	(2, 'Bob', 'Los Angeles', 'bob@example.com'),
	(3, 'Charlie', 'Chicago', 'charlie@example.com'),
	(4, 'David', 'Miami', NULL);

INSERT INTO Orders (OrderID, CustomerID, OrderDate, Amount)
	VALUES 
	(101, 1, '2023-10-01', 500.00), 
	(102, 2, '2023-10-05', 300.00), 
	(103, 1, '2023-10-10', 700.00), 
	(104, 3, '2023-10-12', 450.00), 
	(105, 2, '2023-11-01', 200.00);

SELECT DISTINCT City FROM Customers;

SELECT Name, City FROM Customers WHERE(City='New York' OR City='Los Angeles') AND City!='Miami';
INSERT INTO Customers 
	VALUES(5, 'Eve', 'Boston','eve@g.com');

SELECT * FROM Customers;
UPDATE Customers SET City='San Francisco' WHERE Name='Alice';
SELECT * FROM Orders;
DELETE FROM Orders WHERE Amount<400 ;
SELECT COUNT(*) AS TotalCustomers FROM Customers;
SELECT * FROM Customers WHERE Name LIKE 'A%';
SELECT * FROM Orders WHERE OrderDate BETWEEN '2023-10-01' AND '2023-10-10';
SELECT c.Name, O.Amount
	FROM Customers c INNER JOIN Orders o
	ON c.CustomerID=o.CustomerID;

SELECT City FROM Customers;
SELECT City, COUNT(*) AS TotalCustomers
FROM Customers GROUP BY City;

INSERT INTO Customers VALUES(6,'Tom','Los Angeles','tom@example.com');

SELECT City, COUNT(*) AS TotalCustomers
FROM Customers GROUP BY City HAVING COUNT(*) > 1;

