CREATE DATABASE HireMeNowDB;
USE HireMeNowDB;
CREATE TABLE Users(
    Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100) NOT NULL UNIQUE,
    Gender VARCHAR(20),
    Location VARCHAR(100),
    Phone VARCHAR(20),
    Password VARCHAR(100),
    Role VARCHAR(50),
    About VARCHAR(255),
    Designation VARCHAR(100),
    CompanyId UNIQUEIDENTIFIER,
    Status VARCHAR(20),
    Image VARCHAR(255)
);
CREATE TABLE Experiences(
    Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    UserId UNIQUEIDENTIFIER NOT NULL,
    JobTitle VARCHAR(100),
    Company VARCHAR(100),
    Duration VARCHAR(50),
    Year VARCHAR(20),
    CONSTRAINT fk_users_id FOREIGN KEY (UserId) REFERENCES Users(Id)
);
INSERT INTO Users 
(Id, FirstName, LastName, Email, Gender, Location, Phone, Password, Role, About, Designation, CompanyId, Status, Image)
VALUES 
('9b80c5d4-5de6-4f16-acd5-26f7d392b8b9', 'Soudha', 'AM', 'soudha@gmail.com', 'Female', 'Thrissur', NULL, '123', 'Jobprovider', NULL, NULL, NULL, 'Active', NULL),

('6fa50404-3754-4062-a4b0-ca333468e69a', 'Yadhu', 'Krishna', 'yadhu@gmail.com', NULL, 'Thrissur', NULL, '123', 'Jobseeker', NULL, NULL, NULL, 'Active', NULL);
INSERT INTO Experiences (UserId, JobTitle, Company, Duration, Year) 
VALUES 
('6fa50404-3754-4062-a4b0-ca333468e69a', 'Dotnet Developer', 'Aitrich Technologies', '2 years', '2021-2023'),

('6fa50404-3754-4062-a4b0-ca333468e69a', 'Dotnet Developer', 'TCS', '2 years', '2019-2021');

SELECT * FROM Users;
SELECT * FROM Experiences;
SELECT u.FirstName,u.Email,e.JobTitle,e.Company FROM Users u JOIN Experiences e ON u.Id = e.UserId;
UPDATE Users SET Location = 'Kochi' WHERE FirstName = 'Yadhu';


DELETE FROM Experiences WHERE Company = 'TCS';
CREATE LOGIN test WITH PASSWORD = 'Test@1234';
CREATE USER test FOR LOGIN test;
INSERT INTO Users 
(Id,FirstName, LastName, Email, Gender, Location, Phone, Password, Role, About,Designation, CompanyId, Status, Image)
VALUES
('9b80c5d4-5de6-4f16-acd5-26f7d392b8b9','Soudha','AM','soudha.aitrich@gmail.com','Female','Thrissur',NULL,'123','Jobprovider',NULL,NULL,NULL,'Active',NULL);

INSERT INTO Users 
VALUES
('6fa50404-3754-4062-a4b0-ca333468e69a','yadhu','krishna','yadhu.aitrich@gmail.com',NULL,'Thrissur',NULL,'123','Jobseeker',NULL,NULL,NULL,'Active',NULL);

INSERT INTO Users 
VALUES
('08569e5d-b488-4c09-a7d1-e60fe4e5a512','shini','parameswaran','shini.aitrich@gmail.com',NULL,'Thrissur',NULL,'123','CompanyMember',NULL,NULL,'ab5f391e-d83e-4eae-87cd-bca23175cf22','Active',NULL);
UPDATE Users 
SET Phone='8085499250',
    Location='Kochi',
    About='Experienced .NET developer'
WHERE Email='yadhu@gmail.com';


UPDATE Users 
SET CompanyId='ab5f391e-d83e-4eae-87cd-bca23175cf22'
WHERE Email='soudha@gmail.com';

SELECT * FROM Users WHERE Role='Jobseeker';

SELECT * FROM Users WHERE Role='Jobprovider';

SELECT * FROM Users WHERE Role='Jobseeker' AND Email='yadhu@gmail.com';

