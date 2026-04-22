CREATE DATABASE JobPortal;

CREATE TABLE Candidates (candidate_id INT IDENTITY(1,1) PRIMARY KEY,name VARCHAR(50),city VARCHAR(50));

INSERT INTO Candidates (name, city) VALUES('Arjun', 'Kochi'),('Meera', 'Chenna'),('Rahul', 'Delhi');

CREATE TABLE Jobs (
job_id INT IDENTITY(1,1) PRIMARY KEY,
title VARCHAR(50),
company VARCHAR(50)
);
INSERT INTO Jobs (title, company) VALUES
('Software Engineer', 'Infosys'),
('Data Analyst', 'TCS'),
('HR Manager', 'Wipro');
CREATE TABLE Applications (
application_id INT IDENTITY(1,1) PRIMARY KEY,
candidate_id INT,
job_id INT,
status VARCHAR(20),
FOREIGN KEY (candidate_id) REFERENCES Candidates(candidate_id),
FOREIGN KEY (job_id) REFERENCES Jobs(job_id)
);
INSERT INTO Applications (candidate_id, job_id, status) VALUES
(1, 1, 'Pending'),
(2, 2, 'Selected'),
(2, 3, 'Rejected'),
(3, 1,'Pending');

SELECT 
    application_id,
    status,
    dbo.fn_GetStatusCode(status) AS StatusCode
FROM Applications;

SELECT 
    candidate_id,
    name,
    dbo.fn_GetApplicationCount(candidate_id) AS TotalApplications
FROM Candidates;

SELECT * 
FROM dbo.fn_GetJobsByCompany('Infosys');

SELECT * 
FROM dbo.fn_GetCandidatesByStatus('Selected');