CREATE DATABASE Tour;
CREATE TABLE Customers (customer_id INT PRIMARY KEY, name VARCHAR(50), city VARCHAR(50));
CREATE TABLE Bookings (booking_id INT PRIMARY KEY, customer_id INT, tour_name VARCHAR(50), FOREIGN KEY(customer_id) REFERENCES Customers(Customer_id));

INSERT INTO Customers(name,city) VALUES
('Alice','Kochi'),
('Bob', 'Chennai'),
('Charlie', 'Delhi');

INSERT INTO Bookings VALUES
(101, 1, 'Kerala Backwaters'),
(102, 2, 'Golden Triangle'),
(103, 2, 'Goa Beaches');

SELECT c.customer_id,c.name, c.city, b.tour_name 
	FROM Customers C LEFT JOIN Bookings B
	ON c.customer_id=b.customer_id; 

CREATE DATABASE Library;
CREATE TABLE Members (member_id INT PRIMARY KEY, name VARCHAR(50));

INSERT INTO Members VALUES
(1, 'George'),
(2, 'Hannah'),
(3, 'Ian');

CREATE TABLE BorrowedBooks (book_id INT PRIMARY KEY, member_id INT, title VARCHAR(50));

INSERT INTO BorrowedBooks VALUES
(301, 1, 'SQL Basics'),
(302, 2, 'Data Structures');

INSERT INTO BorrowedBooks(book_id, title) VALUES
(303, 'Datastructure');


SELECT b.book_id, b.title, b.member_id, m.name
	FROM BorrowedBooks b LEFT JOIN Members m
	ON b.member_id=m.member_id;


CREATE DATABASE University;
CREATE TABLE Students (student_id INT PRIMARY KEY, name VARCHAR(50));
CREATE TABLE Enrollments (enrollment_id INT PRIMARY KEY, student_id INT, course_name VARCHAR(50));
INSERT INTO Students VALUES
(1, 'Jack'),
(2, 'Kelly'),
(3, 'Liam');

INSERT INTO Enrollments VALUES
(401, 1, 'Database Systems'),
(402, 2, 'Operating Systems');

SELECT s.student_id, s.name, e.enrollment_id, e.course_name
	FROM Students s LEFT JOIN Enrollments e
	ON s.student_id=e.student_id;



CREATE DATABASE Hotel_Reservation;
CREATE TABLE Guests (guest_id INT PRIMARY KEY, name VARCHAR(50));
CREATE TABLE Reservations (reservation_id INT PRIMARY KEY, guest_id INT, room_number INT);
INSERT INTO Guests VALUES
(1, 'Maya'),
(2, 'Nikhil'),
(3, 'Olivia');
INSERT INTO Reservations VALUES
(501, 1, 101),
(502, 2, 202);

SELECT g.guest_id, g.name, r.reservation_id, r.room_number
	FROM Guests g FULL OUTER JOIN Reservations r
	ON g.guest_id=r.guest_id;
