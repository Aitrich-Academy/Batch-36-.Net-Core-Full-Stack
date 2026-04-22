CREATE DATABASE LibraryManagementDB;
USE LibraryManagementDB;
--TABLES
CREATE TABLE Books(BookID INT identity(1,1) PRIMARY KEY, Title VARCHAR(100), Author VARCHAR(50), Price DECIMAL(18,0), Quantity INT);
CREATE TABLE Members(MemberID INT identity(1,1) PRIMARY KEY, Name VARCHAR(100), Email VARCHAR(100));
CREATE TABLE Borrow(BorrowID INT identity(1,1) PRIMARY KEY,MemberID INT, BookID INT, BorrowDate DateTime,
	FOREIGN KEY(MemberID) REFERENCES Members(MemberID),
	FOREIGN KEY(BookID) REFERENCES Books(BookID));

--Values Insersion
INSERT INTO Books(Title, Author,Price,Quantity)
VALUES
	('2 States', 'Chetan Bhagat',250.00,10),
	('The Alchemist', 'Paulo Coehlo',300.75,25),
	('ABC','TSHNSMMK',150.50,15),
	('XYZ','AJFJSD',275,20),
	('PQR','WEFEFKAFIWE',400,40),
	('Half Girlfriend', 'Chetan Bhagat',750.00,30);



INSERT INTO Members(Name,Email)
VALUES
	('Neena Prasad', 'neena@gmail.com'),
	('Rajeev Chandran', 'rajeev@gmail.com'),
	('George Jacob', 'g_jacob@gmail.com'),
	('Shiyas Muhammed', 'shiyas@gmail.com'),
	('Jeenu Jebin', 'jeenu@gmail.com');

INSERT INTO Borrow(MemberID, BookID, BorrowDate)
VALUES
	(1,1,'2026-03-25'),
	(1,2,'2026-03-25'),
	(2,3,'2026-03-25'),
	(2,1,'2026-03-25'),
	(2,5,'2026-04-20'),
	(3,4,'2026-03-30'),
	(4,3,'2026-04-12'),
	(5,5,'2026-04-02'),
	(5,6,'2026-03-30');

SELECT * FROM Books;
--#1
SELECT * FROM Books WHERE price>600;
--#2
SELECT SUM(Quantity) AS Total_Books FROM Books;
--#3
SELECT m.MemberID, m.Name AS MemberName,
		b.BorrowDate 
	FROM Members m INNER JOIN Borrow b
	ON m.MemberID=b.MemberID;
--#4
SELECT Title, Author,Price FROM Books
	WHERE Price=(SELECT MAX(PRICE) AS MaxPrice FROM Books);
--#5
SELECT B.title, COUNT(bw.BorrowID) AS Counts
	FROM Books b LEFT JOIN Borrow bw
	ON b.BookID=bw.BookID
	GROUP BY b.Title;
--Stored Procedure
EXEC sp_UpdatePriceOfBook 1,500;
--Insertion into books after Trigger creation
INSERT INTO Borrow(MemberID, BookID, BorrowDate)
VALUES
	(5,6,'2026-03-25');
		
SELECT * FROM Books WHERE BookID=6;

