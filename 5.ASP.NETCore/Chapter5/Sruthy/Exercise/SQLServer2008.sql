
--Exercise SQLSERVER2008
CREATE LOGIN university_user
WITH PASSWORD = 'pass123';

CREATE USER university_user
FOR LOGIN university_user;

CREATE TABLE University(UID INT PRIMARY KEY, Name VARCHAR(20),Chancellor VARCHAR(20)); 

CREATE TABLE Dean(DeanID INT PRIMARY KEY, Name VARCHAR(20),DateOfBirth DateTime);

CREATE TABLE College(CID INT PRIMARY KEY,UID INT,DeanID INT, Name VARCHAR(20) 
	CONSTRAINT FK_Uni FOREIGN KEY (UID) REFERENCES University(UID), 
	CONSTRAINT FK_Dean FOREIGN KEY (DeanID) REFERENCES Dean(DeanID)); 

CREATE TABLE Department(DID INT PRIMARY KEY,CID INT, Name VARCHAR(20) 
	CONSTRAINT FK_Clg FOREIGN KEY (CID) REFERENCES College(CID)); 

CREATE TABLE Professor(PID INT PRIMARY KEY,DID INT, Name VARCHAR(20) 
	CONSTRAINT FK_Dpt FOREIGN KEY (DID) REFERENCES Department(DID)); 

CREATE TABLE Course(CourseID INT PRIMARY KEY,DID INT, Name VARCHAR(20) 
	CONSTRAINT FK_Dpt1 FOREIGN KEY (DID) REFERENCES Department(DID)); 

CREATE TABLE Subject(SubjectID INT PRIMARY KEY,CourseID INT, PID INT, Name VARCHAR(20) 
	CONSTRAINT FK_Crs FOREIGN KEY (CourseID) REFERENCES Course(CourseID), 
	CONSTRAINT FK_Pro FOREIGN KEY (PID) REFERENCES Professor(PID)); 

CREATE TABLE Student(StudentID INT PRIMARY KEY,DID INT, Name VARCHAR(20), DateofEnrollment smalldatetime, TelephoneNumber varchar(20) 
	CONSTRAINT FK_Dpt2 FOREIGN KEY (DID) REFERENCES Department(DID)); 

CREATE TABLE Student_Registration(StudentID INT, SubjectID INT 
	CONSTRAINT FK_Stu FOREIGN KEY (StudentID) REFERENCES Student(StudentID), 
	CONSTRAINT FK_Sub FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID));

CREATE VIEW vw_StudentCourses AS
SELECT 
    s.StudentID,
    s.Name AS StudentName,
    c.CourseID,
    c.Name AS CourseName
FROM Student s
JOIN Student_Registration sr ON s.StudentID = sr.StudentID
JOIN Subject sub ON sr.SubjectID = sub.SubjectID
JOIN Course c ON sub.CourseID = c.CourseID;

SELECT * FROM vw_StudentCourses;

SELECT 
    s.Name AS Student,
    c.Name AS Course,
    p.Name AS Professor,
    clg.Name AS College
FROM Student s
JOIN Department d ON s.DID = d.DID
JOIN College clg ON d.CID = clg.CID
JOIN Course c ON d.DID = c.DID
JOIN Professor p ON d.DID = p.DID;

SELECT DISTINCT p.Name AS ProfessorName
FROM Professor p
JOIN Department d ON p.DID = d.DID
JOIN Course c ON d.DID = c.DID
WHERE c.Name = 'MCA';


SELECT * 
FROM Subject 
WHERE PID = (
    SELECT PID 
    FROM Professor 
    WHERE Name = 'George Peter' 
);

SELECT DISTINCT c.Name AS CourseName
FROM Professor p
JOIN Subject s ON p.PID = s.PID
JOIN Course c ON s.CourseID = c.CourseID
WHERE p.Name = 'George Peter';

SELECT d.Name AS DepartmentName,
        s.Name AS StudentName
    FROM 
        Department d JOIN Student s
        ON s.DID=d.DID
        ORDER BY d.Name;

SELECT * FROM College ORDER BY Name DESC; 

SELECT s.Name AS Subject , c.Name 
FROM
    Subject s JOIN Course c
    ON s.CourseID=c.CourseID
    WHERE c.Name='B.Tech Computer Science';

SELECT COUNT(c.CourseID) AS Total_Course
    FROM Course c JOIN Subject s
    ON s.CourseID=c.CourseID
    WHERE s.Name LIKE '%Computer%';

SELECT * FROM Course;
SELECT * FROM Subject;

SELECT p.Name AS Professor_Name,
        s.Name AS Subject 
    FROM Professor p JOIN Subject s
    ON p.PID=s.PID
    ORDER BY s.Name;
--Column 'Professor.Name' is invalid in the select list because it is not contained in either an aggregate function or the GROUP BY clause.
SELECT 
    s.Name AS SubjectName,
    STRING_AGG(p.Name, ', ') AS Professors
FROM Subject s
JOIN Professor p ON s.PID = p.PID
GROUP BY s.Name;



--Exercise TSQL
EXEC sp_InsertStudent 8, 1, 'Nowfal', '2024-04-01', '8153625845';

-- Update
EXEC sp_UpdateStudent 8, 'Abdul Nowfal';

-- Delete
EXEC sp_DeleteStudent 8;

EXEC sp_GetStudentOfCS;

-- HOW DID YOU GIVE AUTO INCREMENT FOR ALREADY EXISTING TABLE?

SELECT * FROM fn_ListDeanUniversity();

CREATE SEQUENCE CollegeSeq
START WITH 1
INCREMENT BY 1;

SELECT fn_GenerateCollegeCode,Name FROM College;

ALTER TABLE College ALTER COLUMN CID VARCHAR(10);
INSERT INTO College (UID, DeanID, Name)
VALUES (1, 1, 'Engineering');

SELECT * FROM fn_ListCollegeCambridge();

