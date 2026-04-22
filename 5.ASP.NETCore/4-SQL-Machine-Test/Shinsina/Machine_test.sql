--DATABASE
CREATE DATABASE LibraryDB;
--TABLE BOOKS
CREATE TABLE Books(BookID INT  PRIMARY KEY,Title VARCHAR(50),
   Author VARCHAR(50),Price DECIMAL(10,2),Quantity INT); 
--TABLE MEMBERS
CREATE TABLE Members(Memberid INT PRIMARY KEY,Name VARCHAR(50),Email VARCHAR(50));
--TABLE BORROW
CREATE TABLE Borrow(BorrowID INT PRIMARY KEY,MemberID INT,BookID INT,BorrowDate DATE,
FOREIGN KEY(MemberID) REFERENCES Members(MemberID),FOREIGN KEY (BookID)REFERENCES Books(BookID));

--INSERT VALUES INTO BOOKS
INSERT INTO Books VALUES
(1,'C# Programming','Robert Brown',1000,3),
(2,'Advanced SQL','David Miller',500,7),
(3,'ASP.NET Core','Nancy',800,10),
(4,'DB Design','James',1365,6),
(5,'GIT','Charls',900,4);
--INSERT VALUES INTO MEMBERS
INSERT INTO Members VALUES
(001,'Shinsi','shinsi@gmail.com'),
(002,'Salaah','salaah@gmail.com'),
(003,'Saahin','saahin@gmail.com'),
(004,'Shehsin','shehsin@gmail.com'),
(005,'Neethu','neethu@gmail.com');
--INSERT INTO BORROW
INSERT INTO Borrow VALUES
(1,001,2,'2026-03-01'),
(2,004,3,'2026-03-10'),
(3,002,1,'2026-03-05'),
(4,004,4,'2026-03-01'),
(5,003,2,'2026-03-06');
--Queries
--Q1
SELECT * FROM Books WHERE Price>600;
--Q2
SELECT SUM(Quantity) AS TotaIBooks FROM Books;
--Q3
SELECT DISTINCT M.MemberID,M.Name,B.BorrowDate FROM Members M JOIN Borrow B ON M.Memberid=B.MemberID;
--Q4
SELECT TOP 1 * FROM Books ORDER BY Price DESC;
--Q5
SELECT B.Title,COUNT(BR.BorrowID) AS TotalBorrow FROM Books B LEFT JOIN Borrow BR ON B.BookID=BR.BookID GROUP BY B.Title;
--Stored Procedure
EXEC UpdateBookPrice 1,205;
--Trigger
SELECT * FROM Books WHERE BookID=2;

INSERT INTO Borrow(BorrowID,MemberID,BookID,BorrowDate) VALUES(8,002,2,GETDATE());
SELECT * FROM Borrow;
SELECT * FROM Books;
SELECT * FROM Members;