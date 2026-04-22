--DATABASE
CREATE DATABASE University;
--LOGIN & PASSWORD
CREATE LOGIN testuser WITH PASSWORD = 'Test@123';
CREATE USER testuser FOR LOGIN testuser;
--UNIVERSITY
CREATE TABLE University (UID INT IDENTITY(1,1) PRIMARY KEY,Name VARCHAR(20),Chancellor VARCHAR(20));
--DEAN
CREATE TABLE Dean (DeanID INT IDENTITY(1,1) PRIMARY KEY,Name VARCHAR(20),DateOfBirth DATETIME);
--COLLEGE
CREATE TABLE College (
    CID INT IDENTITY(1,1) PRIMARY KEY,
    University INT,
    Dean INT,
    Name VARCHAR(20),
    FOREIGN KEY (University) REFERENCES University(UID),
    FOREIGN KEY (Dean) REFERENCES Dean(DeanID)
);
--DEPARTMENT
CREATE TABLE Department (
    DID INT IDENTITY(1,1) PRIMARY KEY,
    College INT,
    Name VARCHAR(20),
    FOREIGN KEY (College) REFERENCES College(CID)
);
--PROFESSOR
CREATE TABLE Professor (
    PID INT IDENTITY(1,1) PRIMARY KEY,
    Department INT,
    Name VARCHAR(20),
    FOREIGN KEY (Department) REFERENCES Department(DID)
);
--COURSE
CREATE TABLE Course (
    CourseID INT IDENTITY(1,1) PRIMARY KEY,
    Department INT,
    Name VARCHAR(20),
    FOREIGN KEY (Department) REFERENCES Department(DID)
);
--SUBJECT
CREATE TABLE Subject (
    SubjectID INT IDENTITY(1,1) PRIMARY KEY,
    Course INT,
    Professor INT,
    Name VARCHAR(20),
    FOREIGN KEY (Course) REFERENCES Course(CourseID),
    FOREIGN KEY (Professor) REFERENCES Professor(PID)
);
--STUDENT
CREATE TABLE Student (
    StudentID INT IDENTITY(1,1) PRIMARY KEY,
    Department INT,
    Name VARCHAR(20),
    DateofEnrollment SMALLDATETIME,
    TelephoneNumber VARCHAR(20),
    FOREIGN KEY (Department) REFERENCES Department(DID)
);
--STUDENT-REGISTRATION
CREATE TABLE Student_Registration (
    Student INT,
    Subject INT,
    FOREIGN KEY (Student) REFERENCES Student(StudentID),
    FOREIGN KEY (Subject) REFERENCES Subject(SubjectID)
);
--UNIVERSITY VALUES
INSERT INTO University (Name, Chancellor) VALUES
('ABC University', 'Dr. Rao'),
('XYZ University', 'Dr. Mehta'),
('Global University', 'Dr. Khan'),
('National University', 'Dr. Iyer');
--DEAN VALUES
INSERT INTO Dean (Name, DateOfBirth) VALUES
('Renuka Sharma', '1975-05-10'),
('Amit Verma', '1970-03-15'),
('Suresh Nair', '1968-07-22'),
('Latha Menon', '1978-11-30');
--COLLEGE VALUES
INSERT INTO College (University, Dean, Name) VALUES
(1, 1, 'Engineering College'),
(2, 2, 'Science College'),
(3, 3, 'Arts College'),
(4, 4, 'Medical College');

--DEPARTMENT VALUES
INSERT INTO Department (College, Name) VALUES
(1, 'MCA'),
(1, 'Computer Science'),
(2, 'Physics'),
(3, 'Commerce');
--PROFESSOR VALUES
INSERT INTO Professor (Department, Name) VALUES
(1, 'George Peter'),
(2, 'Anil Kumar'),
(3, 'Ravi Shankar'),
(4, 'Meena Das');
--COURSE VALUES
INSERT INTO Course (Department, Name) VALUES
(1, 'MCA Course'),
(2, 'BSc Computer Science'),
(3, 'BSc Physics'),
(4, 'BCom');
--SUBJECT
INSERT INTO Subject (Course, Professor, Name) VALUES
(3, 1, 'DBMS'),
(4, 2, 'Programming'),
(5, 3, 'Quantum Physics'),
(6, 4, 'Accounting');
--delete
DELETE FROM Subject WHERE SubjectID=13;
--STUDENT
INSERT INTO Student (Department, Name, DateofEnrollment, TelephoneNumber) VALUES
(1, 'Kumar Varma', '2022-06-01', '1234567890'),
(2, 'Rahul Nair', '2021-07-15', '9876543210'),
(3, 'Sneha Pillai', '2023-01-10', '9123456780'),
(4, 'Arjun Das', '2022-09-20', '9988776655');
--STUDENTREGISTRATION VALUES
INSERT INTO Student_Registration (Student, Subject) VALUES
(1,1002),
(2,1003),
(3,1004),
(5,1005);
SELECT CourseID FROM Course;
SELECT PID FROM Professor;

--Q5
CREATE VIEW Student_Course_View AS
SELECT S.Name AS StudentName, C.Name AS CourseName
FROM Student S
JOIN Student_Registration SR ON S.StudentID = SR.Student
JOIN Subject Sub ON SR.Subject = Sub.SubjectID
JOIN Course C ON Sub.Course = C.CourseID;

--Q6
UPDATE Dean
SET Name = 'Renuka Mukerjee'
WHERE Name = 'Renuka Sharma';
--Q7
UPDATE Student
SET TelephoneNumber = '8105874639'
WHERE Name = 'Kumar Varma';
--Q8.1
SELECT S.Name AS Student, Col.Name AS College, C.Name AS Course, P.Name AS Professor
FROM  Student S
JOIN Department D ON S.Department = D.DID
JOIN College Col ON D.College = Col.CID
JOIN Course C ON D.DID = C.Department
JOIN Subject Sub ON C.CourseID = Sub.Course
JOIN Professor P ON Sub.Professor = P.PID;
SELECT S.Name, D.Name AS Department
FROM Student S
JOIN Department D ON S.Department = D.DID;
--Q8.2
SELECT P.Name
FROM Professor P
JOIN Department D ON P.Department = D.DID
WHERE D.Name = 'MCA';
--Q8.3
SELECT  C.Name
FROM Course C
JOIN Subject S ON C.CourseID = S.Course
JOIN Professor P ON S.Professor = P.PID
WHERE P.Name = 'George Peter';
--Q8.4
SELECT D.Name AS Department, COUNT(S.StudentID) AS TotalStudents
FROM Student S
JOIN Department D ON S.Department = D.DID
GROUP BY D.Name;
--Q8.5
SELECT Name
FROM College
ORDER BY Name DESC;
--Q8.6
SELECT Sub.Name
FROM Subject Sub
JOIN Course C ON Sub.Course = C.CourseID
WHERE C.Name = 'Computer Science';
--Q8.7
SELECT COUNT(DISTINCT C.CourseID) AS TotalCourses
FROM Course C
JOIN Subject S ON C.CourseID = S.Course
WHERE S.Name LIKE '%Computer%';
--Q8.8
SELECT Sub.Name AS Subject, P.Name AS Professor, COUNT(*) AS Total
FROM Subject Sub
JOIN Professor P ON Sub.Professor = P.PID
GROUP BY Sub.Name, P.Name;
SELECT * FROM Student;
SELECT * FROM Course;
SELECT * FROM Subject;
SELECT * FROM Student_Registration;
SELECT * FROM Professor;
 DELETE FROM Student_Registration WHERE ID=1; 

--STORED PROCEDURE
EXEC sp_InsertStudent 1, 'Sana', '2024-01-10', '9998887776';
EXEC sp_UpdateStudent 1, 'Kumar Varma Updated', '8105874639';
EXEC sp_DeleteStudent 4;
--Q2
EXEC sp_CSStudents;

--SCALAR FUNCTION
SELECT dbo.fn_GetNextStudentID();
SELECT dbo.fn_CollegeCode(CID), Name FROM College;

--TABLE FUNCTION
SELECT * FROM fn_CollegeDetails();
SELECT * FROM fn_CambridgeColleges();