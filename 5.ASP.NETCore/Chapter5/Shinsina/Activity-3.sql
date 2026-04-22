CREATE DATABASE Customers;
CREATE TABLE Customers (CustomerID INT PRIMARY KEY,Name VARCHAR(50),City VARCHAR(50),Email VARCHAR(50));
CREATE TABLE Orders (OrderID INT PRIMARY KEY,CustomerID INT,OrderDate DATE,Amount DECIMAL(10,2),FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID));
INSERT INTO Customers (CustomerID, Name, City, Email) VALUES (1, 'Alice','New York','alice@example.com'),
(2, 'Bob', 'Los Angeles', 'bob@example.com'),
(3, 'Charlie','Chicago', 'charlie@example.com'),
(4,'David', 'Miami', NULL);
INSERT INTO Orders (OrderID, CustomerID, OrderDate, Amount) VALUES (101, 1, '2023-10-01', 500.00),
(102, 2, '2023-10-05', 300.00), (103, 1, '2023-10-10', 700.00),
(104, 3, '2023-10-12', 450.00), (105, 2,'2023-11-01', 200.00);

--2
SELECT DISTINCT City FROM Customers;
--3
SELECT * FROM Customers WHERE City IN ('New York', 'Los Angeles')AND City <> 'Miami';
--4
INSERT INTO Customers (CustomerID, Name, City, Email) VALUES (5, 'Eve', 'Boston', 'eve@example.com');
--5
UPDATE Customers SET City = 'San Francisco'WHERE Name = 'Alice';
--6
DELETE FROM Orders WHERE Amount < 400;
--7
SELECT COUNT(*) AS TotalCustomers FROM Customers;
--8
SELECT * FROM Customers WHERE Name LIKE 'A%';
--9
SELECT * FROM Orders WHERE OrderDate BETWEEN '2023-10-01' AND '2023-10-10';
--10
SELECT c.Name, o.Amount FROM Customers c INNER JOIN Orders o ON c.CustomerID = o.CustomerID;
--11
SELECT City FROM Customers UNION SELECT City FROM Customers;
--12
SELECT City, COUNT(*) AS TotalCustomers FROM Customers GROUP BY City;
--13
SELECT City, COUNT(*) AS TotalCustomers FROM Customers GROUP BY City HAVING COUNT(*) > 1;
--14
SELECT DISTINCT c.*FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID;
--15
SELECT DISTINCT c.*FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID WHERE o.Amount > 500;
--16
SELECT *FROM Customers WHERE Email IS NULL;
--17
SELECT Name, City,
CASE
    WHEN City = 'New York' THEN 'East'
    WHEN City = 'Los Angeles' THEN 'West'
    WHEN City = 'Chicago' THEN 'Central'
    ELSE 'Other'
END AS Region
FROM Customers;
--19
CREATE TABLE NY_Customers (
CustomerID INT,
Name VARCHAR(50),
City VARCHAR(50),
Email VARCHAR(50)
);

INSERT INTO NY_Customers
SELECT *
FROM Customers
WHERE City = 'New York';
