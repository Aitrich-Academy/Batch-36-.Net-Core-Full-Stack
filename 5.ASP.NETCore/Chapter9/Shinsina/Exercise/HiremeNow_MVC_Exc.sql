CREATE DATABASE  HireMeNow_MVC_Exc;
USE HireMeNow_MVC_Exc;

CREATE TABLE Users
(
    UserId UNIQUEIDENTIFIER PRIMARY KEY,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(150) UNIQUE NOT NULL,
    PhoneNumber NVARCHAR(20),
    Password NVARCHAR(100) NOT NULL,
    UserRole NVARCHAR(50),
    CreatedDate DATETIME DEFAULT GETDATE()
);
CREATE TABLE Jobs
(
    JobId UNIQUEIDENTIFIER PRIMARY KEY,
    JobTitle NVARCHAR(200),
    Description NVARCHAR(MAX),
    CompanyName NVARCHAR(200),
    Location NVARCHAR(200),
    Salary DECIMAL(18,2),
    PostedDate DATETIME DEFAULT GETDATE()
);
CREATE TABLE JobApplications
(
    ApplicationId UNIQUEIDENTIFIER PRIMARY KEY,

    UserId UNIQUEIDENTIFIER NOT NULL,

    JobId UNIQUEIDENTIFIER NOT NULL,

    AppliedDate DATETIME DEFAULT GETDATE(),

    FOREIGN KEY(UserId)
    REFERENCES Users(UserId),

    FOREIGN KEY(JobId)
    REFERENCES Jobs(JobId)
);
CREATE TABLE SavedJobs
(
    SavedJobId UNIQUEIDENTIFIER PRIMARY KEY,
    UserId UNIQUEIDENTIFIER NOT NULL,
    JobId UNIQUEIDENTIFIER NOT NULL,
    SavedDate DATETIME NOT NULL,

    CONSTRAINT FK_SavedJobs_Users
    FOREIGN KEY(UserId)
    REFERENCES Users(UserId),

    CONSTRAINT FK_SavedJobs_Jobs
    FOREIGN KEY(JobId)
    REFERENCES Jobs(JobId)
);
INSERT INTO Jobs
(
    JobId,
    JobTitle,
    Description,
    CompanyName,
    Location,
    Salary,
    PostedDate
)
VALUES
(
    NEWID(),
    'Dotnet Developer',
    'Develop and maintain ASP.NET Core MVC applications',
    'Aitrich Technologies',
    'Kochi',
    30000,
    GETDATE()
),

(
    NEWID(),
    'Java Developer',
    'Develop enterprise Java applications',
    'Infosys',
    'Bangalore',
    45000,
    GETDATE()
),

(
    NEWID(),
    'Angular Developer',
    'Build responsive web applications using Angular',
    'TCS',
    'Chennai',
    40000,
    GETDATE()
),

(
    NEWID(),
    'Full Stack Developer',
    'Work with ASP.NET Core, Angular and SQL Server',
    'Wipro',
    'Hyderabad',
    50000,
    GETDATE()
),

(
    NEWID(),
    'Software Engineer',
    'Develop and test software modules',
    'Cognizant',
    'Pune',
    35000,
    GETDATE()
);
SELECT * FROM Users;
SELECT * FROM Jobs;
SELECT * FROM JobApplications;