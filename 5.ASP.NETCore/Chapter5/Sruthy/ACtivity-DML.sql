CREATE DATABASE LibraryDB
CREATE TABLE Authors(AuthorID INT IDENTITY(1,1) PRIMARY KEY, FirstName VARCHAR(50), LastName VARCHAR(50));
CREATE TABLE Books(BookID INT IDENTITY(1,1) PRIMARY KEY, Title VARCHAR(100), Genre VARCHAR(50), AuthorID INT FOREIGN KEY(AuthorID) REFERENCES Authors(AuthorID));
INSERT INTO Authors(FirstName,LastName) VALUES('Arundhati','Roy'),('Ruskin','Bond'),('Chetan','Bhagat');
SELECT * FROM Authors;
INSERT INTO Books(Title,Genre,AuthorID) VALUES('The god of small things','Fiction',1),('Room on te Roof', 'Young Adult',2),('The White Tiger','Drama',3),('Revolution 2020', 'Drama',3),('Delhi is Not Far', 'Fiction', 2);
SELECT * FROM Books;
UPDATE Books SET Genre='Drama' WHERE Title='Revolution 2020';
DELETE FROM BookS WHERE Title='The White Tiger';
DELETE FROM Authors;
TRUNCATE TABLE Books;
