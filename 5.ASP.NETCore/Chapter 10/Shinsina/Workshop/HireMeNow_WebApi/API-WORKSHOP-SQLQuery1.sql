CREATE DATABASE HireMeNow_WebAp;
GO

USE HireMeNow_WebAp;
GO

----------------------------------------------------
-- SystemUser
----------------------------------------------------
CREATE TABLE SystemUser
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    UserName NVARCHAR(100),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100),
    Phone NVARCHAR(20) NOT NULL,
    Email NVARCHAR(200) NOT NULL,
    Role INT
);

----------------------------------------------------
-- AuthUser (TPT Inheritance)
----------------------------------------------------
CREATE TABLE AuthUser
(
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Password NVARCHAR(MAX),
    ConnectionId NVARCHAR(200),
    OnlineStatus BIT DEFAULT 0,

    CONSTRAINT FK_AuthUser_SystemUser
    FOREIGN KEY(Id)
    REFERENCES SystemUser(Id)
);

----------------------------------------------------
-- Industry
----------------------------------------------------
CREATE TABLE Industry
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name NVARCHAR(150) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL
);

----------------------------------------------------
-- Location
----------------------------------------------------
CREATE TABLE Location
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name NVARCHAR(150) NOT NULL,
    Discription NVARCHAR(MAX) NOT NULL
);

----------------------------------------------------
-- JobCategory
----------------------------------------------------
CREATE TABLE JobCategory
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name NVARCHAR(150),
    Description NVARCHAR(MAX)
);

----------------------------------------------------
-- Company
----------------------------------------------------
CREATE TABLE JobProviderCompany
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    LegalName NVARCHAR(200) NOT NULL,
    Summary NVARCHAR(MAX) NOT NULL,
    IndustryId UNIQUEIDENTIFIER NOT NULL,
    Email NVARCHAR(200) NOT NULL,
    Phone BIGINT NOT NULL,
    Address NVARCHAR(MAX) NOT NULL,
    Website NVARCHAR(300) NOT NULL,
    Location UNIQUEIDENTIFIER NOT NULL,

    FOREIGN KEY(IndustryId)
    REFERENCES Industry(Id),

    FOREIGN KEY(Location)
    REFERENCES Location(Id)
);

----------------------------------------------------
-- CompanyUser
----------------------------------------------------
CREATE TABLE CompanyUser
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100),
    Role INT NOT NULL,
    UserName NVARCHAR(100),
    Email NVARCHAR(200) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,

    Company UNIQUEIDENTIFIER,

    FOREIGN KEY(Company)
    REFERENCES JobProviderCompany(Id)
);

----------------------------------------------------
-- JobSeeker
----------------------------------------------------
CREATE TABLE JobSeeker
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    UserName NVARCHAR(100),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100),
    Phone NVARCHAR(20) NOT NULL,
    Email NVARCHAR(200) NOT NULL,
    Image VARBINARY(MAX),
    Role INT NOT NULL
);

----------------------------------------------------
-- Resume
----------------------------------------------------
CREATE TABLE Resume
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Title NVARCHAR(200),
    [File] VARBINARY(MAX)
);

----------------------------------------------------
-- JobSeekerProfile
----------------------------------------------------
CREATE TABLE JobSeekerProfile
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    ResumeId UNIQUEIDENTIFIER,
    JobSeekerId UNIQUEIDENTIFIER NOT NULL,
    ProfileName NVARCHAR(200),
    ProfileSummary NVARCHAR(MAX),

    FOREIGN KEY(ResumeId)
    REFERENCES Resume(Id),

    FOREIGN KEY(JobSeekerId)
    REFERENCES JobSeeker(Id)
);

----------------------------------------------------
-- Skill
----------------------------------------------------
CREATE TABLE Skill
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name NVARCHAR(200) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL
);


----------------------------------------------------
-- Qualification
----------------------------------------------------
CREATE TABLE Qualification
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name NVARCHAR(200) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,

    JobSeekerProfileId UNIQUEIDENTIFIER,
    JobPostId UNIQUEIDENTIFIER
);

----------------------------------------------------
-- WorkExperience
----------------------------------------------------
CREATE TABLE WorkExperience
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    JobSeekerProfileId UNIQUEIDENTIFIER NOT NULL,
    JobTitle NVARCHAR(200) NOT NULL,
    CompanyName NVARCHAR(200) NOT NULL,
    Summary NVARCHAR(MAX) NOT NULL,
    ServiceStart DATETIME2,
    ServiceEnd DATETIME2,

    FOREIGN KEY(JobSeekerProfileId)
    REFERENCES JobSeekerProfile(Id)
);

----------------------------------------------------
-- JobPost
----------------------------------------------------
CREATE TABLE JobPost
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),

    JobTitle NVARCHAR(200) NOT NULL,
    JobSummary NVARCHAR(MAX) NOT NULL,

    LocationId UNIQUEIDENTIFIER NOT NULL,
    CompanyId UNIQUEIDENTIFIER NOT NULL,
    CategoryId UNIQUEIDENTIFIER NOT NULL,
    IndustryId UNIQUEIDENTIFIER NOT NULL,
    PostedBy UNIQUEIDENTIFIER NOT NULL,

    PostedDate DATETIME2 NOT NULL,

    FOREIGN KEY(LocationId)
    REFERENCES Location(Id),

    FOREIGN KEY(CompanyId)
    REFERENCES JobProviderCompany(Id),

    FOREIGN KEY(CategoryId)
    REFERENCES JobCategory(Id),

    FOREIGN KEY(IndustryId)
    REFERENCES Industry(Id),

    FOREIGN KEY(PostedBy)
    REFERENCES CompanyUser(Id)
);

----------------------------------------------------
-- Add remaining FK
----------------------------------------------------
ALTER TABLE Qualification
ADD CONSTRAINT FK_Qualification_JobPost
FOREIGN KEY(JobPostId)
REFERENCES JobPost(Id);

ALTER TABLE Qualification
ADD CONSTRAINT FK_Qualification_Profile
FOREIGN KEY(JobSeekerProfileId)
REFERENCES JobSeekerProfile(Id);

----------------------------------------------------
-- JobResponsibility
----------------------------------------------------
CREATE TABLE JobResponsibility
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name NVARCHAR(200),
    Description NVARCHAR(MAX),

    JobPost UNIQUEIDENTIFIER NOT NULL,

    FOREIGN KEY(JobPost)
    REFERENCES JobPost(Id)
);

----------------------------------------------------
-- SavedJob
----------------------------------------------------
CREATE TABLE SavedJob
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Job UNIQUEIDENTIFIER NOT NULL,
    SavedBy UNIQUEIDENTIFIER NOT NULL,
    DateSaved DATETIME2,

    FOREIGN KEY(Job)
    REFERENCES JobPost(Id),

    FOREIGN KEY(SavedBy)
    REFERENCES JobSeeker(Id)
);

----------------------------------------------------
-- JobApplication
----------------------------------------------------
CREATE TABLE JobApplication
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),

    JobPost_id UNIQUEIDENTIFIER NOT NULL,
    Applicant UNIQUEIDENTIFIER NOT NULL,
    Resume_id UNIQUEIDENTIFIER NOT NULL,

    CoverLetter NVARCHAR(MAX),
    Datesubmitted DATETIME2,

    Status INT,

    FOREIGN KEY(JobPost_id)
    REFERENCES JobPost(Id),

    FOREIGN KEY(Applicant)
    REFERENCES JobSeeker(Id),

    FOREIGN KEY(Resume_id)
    REFERENCES Resume(Id)
);

----------------------------------------------------
-- Interview
----------------------------------------------------
CREATE TABLE Interview
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),

    JobId UNIQUEIDENTIFIER,
    Interviewee UNIQUEIDENTIFIER,
    ApplicationId UNIQUEIDENTIFIER,

    Date DATETIME2,
    Status INT,

    SheduledBy UNIQUEIDENTIFIER,
    CompanyId UNIQUEIDENTIFIER NOT NULL,

    FOREIGN KEY(JobId)
    REFERENCES JobPost(Id),

    FOREIGN KEY(Interviewee)
    REFERENCES JobSeeker(Id),

    FOREIGN KEY(ApplicationId)
    REFERENCES JobApplication(Id),

    FOREIGN KEY(SheduledBy)
    REFERENCES CompanyUser(Id),

    FOREIGN KEY(CompanyId)
    REFERENCES JobProviderCompany(Id)
);

----------------------------------------------------
-- MessageGroup
----------------------------------------------------
CREATE TABLE MessageGroup
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name NVARCHAR(200),
    NewCount INT,
    IsNewMessages BIT,
    Members NVARCHAR(MAX)
);

----------------------------------------------------
-- GroupMember
----------------------------------------------------
CREATE TABLE GroupMember
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name NVARCHAR(200),
    ToUserId UNIQUEIDENTIFIER,
    Email NVARCHAR(200),
    MessageGroupId UNIQUEIDENTIFIER,

    FOREIGN KEY(MessageGroupId)
    REFERENCES MessageGroup(Id)
);

----------------------------------------------------
-- Message
----------------------------------------------------
CREATE TABLE Message
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),

    FromUserId UNIQUEIDENTIFIER,
    ToUserId UNIQUEIDENTIFIER,

    MessageGroupId UNIQUEIDENTIFIER,

    [From] NVARCHAR(200),
    [To] NVARCHAR(200),

    Content NVARCHAR(MAX) NOT NULL,

    SentDate DATETIME2,

    ToGroup NVARCHAR(200),

    Status INT,

    FOREIGN KEY(MessageGroupId)
    REFERENCES MessageGroup(Id)
);

----------------------------------------------------
-- SignUpRequest
----------------------------------------------------
CREATE TABLE SignUpRequest
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    UserName NVARCHAR(100),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100),
    Phone NVARCHAR(20),
    Email NVARCHAR(200),
    Status INT
);

----------------------------------------------------
-- Role
----------------------------------------------------
CREATE TABLE Role
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name NVARCHAR(100),
    Description NVARCHAR(MAX)
);

----------------------------------------------------
-- JobSeekerProfileSkill
----------------------------------------------------
CREATE TABLE JobSeekerProfileSkill
(
    JobSeekerProfileId UNIQUEIDENTIFIER NOT NULL,
    SkillId UNIQUEIDENTIFIER NOT NULL,

    PRIMARY KEY(JobSeekerProfileId,SkillId),

    FOREIGN KEY(JobSeekerProfileId)
    REFERENCES JobSeekerProfile(Id),

    FOREIGN KEY(SkillId)
    REFERENCES Skill(Id)
);

ALTER TABLE JobSeekerProfileSkill
ADD Id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID();

ALTER TABLE JobSeekerProfileSkill
ADD CreatedDate DATETIME NULL;

----------------------------------------------------
----------------------------------------------------


/*==========================================================
PART 1 : MASTER TABLES
==========================================================*/

DECLARE @SystemUserId UNIQUEIDENTIFIER = NEWID();
DECLARE @IndustryId UNIQUEIDENTIFIER = NEWID();
DECLARE @LocationId UNIQUEIDENTIFIER = NEWID();
DECLARE @CategoryId UNIQUEIDENTIFIER = NEWID();
DECLARE @CompanyId UNIQUEIDENTIFIER = NEWID();
DECLARE @CompanyUserId UNIQUEIDENTIFIER = NEWID();
DECLARE @JobSeekerId UNIQUEIDENTIFIER = NEWID();
DECLARE @ResumeId UNIQUEIDENTIFIER = NEWID();
DECLARE @ProfileId UNIQUEIDENTIFIER = NEWID();
DECLARE @SkillId UNIQUEIDENTIFIER = NEWID();
DECLARE @JobPostId UNIQUEIDENTIFIER = NEWID();
DECLARE @QualificationId UNIQUEIDENTIFIER = NEWID();
DECLARE @ExperienceId UNIQUEIDENTIFIER = NEWID();
DECLARE @ResponsibilityId UNIQUEIDENTIFIER = NEWID();
DECLARE @SavedJobId UNIQUEIDENTIFIER = NEWID();
DECLARE @ApplicationId UNIQUEIDENTIFIER = NEWID();
DECLARE @InterviewId UNIQUEIDENTIFIER = NEWID();
DECLARE @MessageId UNIQUEIDENTIFIER = NEWID();

----------------------------------------------------------
-- System User
----------------------------------------------------------

INSERT INTO SystemUser
(Id,UserName,FirstName,LastName,Phone,Email,Role)
VALUES
(
@SystemUserId,
'admin01',
'David',
'Wilson',
'9876543210',
'david@hiremenow.com',
1
);

----------------------------------------------------------
-- Auth User
----------------------------------------------------------

INSERT INTO AuthUser
(Id,Password,ConnectionId,OnlineStatus)
VALUES
(
@SystemUserId,
'Admin@123',
NULL,
1
);

----------------------------------------------------------
-- Industry
----------------------------------------------------------

INSERT INTO Industry
(Id,Name,Description)
VALUES
(
@IndustryId,
'Software Development',
'Information Technology Industry'
);

----------------------------------------------------------
-- Location
----------------------------------------------------------

INSERT INTO Location
(Id,Name,Discription)
VALUES
(
@LocationId,
'Bangalore',
'Karnataka'
);

----------------------------------------------------------
-- Job Category
----------------------------------------------------------

INSERT INTO JobCategory
(Id,Name,Description)
VALUES
(
@CategoryId,
'Full Stack Development',
'Software Engineering Jobs'
);

----------------------------------------------------------
-- Company
----------------------------------------------------------

INSERT INTO JobProviderCompany
(
Id,
LegalName,
Summary,
IndustryId,
Email,
Phone,
Address,
Website,
Location
)
VALUES
(
@CompanyId,
'TechNova Solutions Pvt Ltd',
'Software Development and Cloud Services',
@IndustryId,
'contact@technova.com',
9988776655,
'Electronic City, Bangalore',
'https://www.technova.com',
@LocationId
);

----------------------------------------------------------
-- Company User
----------------------------------------------------------

INSERT INTO CompanyUser
(
Id,
FirstName,
LastName,
Role,
UserName,
Email,
Phone,
Company
)
VALUES
(
@CompanyUserId,
'Michael',
'Brown',
1,
'michael',
'michael@technova.com',
'9988776644',
@CompanyId
);

----------------------------------------------------------
-- Job Seeker
----------------------------------------------------------

INSERT INTO JobSeeker
(
Id,
UserName,
FirstName,
LastName,
Phone,
Email,
Image,
Role
)
VALUES
(
@JobSeekerId,
'sarah',
'Sarah',
'Thomas',
'9876501234',
'sarah@gmail.com',
NULL,
2
);

----------------------------------------------------------
-- Resume
----------------------------------------------------------

INSERT INTO Resume
(
Id,
Title,
[File]
)
VALUES
(
@ResumeId,
'Senior Dot Net Developer Resume',
NULL
);

----------------------------------------------------------
-- Job Seeker Profile
----------------------------------------------------------

INSERT INTO JobSeekerProfile
(
Id,
ResumeId,
JobSeekerId,
ProfileName,
ProfileSummary
)
VALUES
(
@ProfileId,
@ResumeId,
@JobSeekerId,
'.NET Full Stack Developer',
'Experienced ASP.NET Core developer with knowledge of SQL Server and Web API.'
);

----------------------------------------------------------
-- Skill
----------------------------------------------------------

INSERT INTO Skill
(
Id,
Name,
Description
)
VALUES
(
@SkillId,
'ASP.NET Core',
'Backend Web Development'
);

----------------------------------------------------------
-- Job Post
----------------------------------------------------------

INSERT INTO JobPost
(
Id,
JobTitle,
JobSummary,
LocationId,
CompanyId,
CategoryId,
IndustryId,
PostedBy,
PostedDate
)
VALUES
(
@JobPostId,
'Senior .NET Developer',
'Looking for an experienced ASP.NET Core Developer with SQL Server knowledge.',
@LocationId,
@CompanyId,
@CategoryId,
@IndustryId,
@CompanyUserId,
GETDATE()
);

/*==========================================================
PART 2 : QUALIFICATION, EXPERIENCE, JOB ACTIVITY
Run after Part 1 in the SAME execution window
==========================================================*/



----------------------------------------------------------
-- Qualification
----------------------------------------------------------
INSERT INTO Qualification
(
    Id,
    Name,
    Description,
    JobSeekerProfileId,
    JobPostId
)
VALUES
(
    @QualificationId,
    'Master of Computer Applications',
    'Completed MCA from Bangalore University',
    @ProfileId,
    @JobPostId
);

----------------------------------------------------------
-- Work Experience
----------------------------------------------------------
INSERT INTO WorkExperience
(
    Id,
    JobSeekerProfileId,
    JobTitle,
    CompanyName,
    Summary,
    ServiceStart,
    ServiceEnd
)
VALUES
(
    @ExperienceId,
    @ProfileId,
    'Software Engineer',
    'Innovatech Systems',
    'Worked on ASP.NET Core applications and REST APIs.',
    '2023-01-01',
    '2025-06-30'
);

----------------------------------------------------------
-- Job Responsibility
----------------------------------------------------------
INSERT INTO JobResponsibility
(
    Id,
    Name,
    Description,
    JobPost
)
VALUES
(
    @ResponsibilityId,
    'API Development',
    'Develop and maintain RESTful APIs using ASP.NET Core.',
    @JobPostId
);

----------------------------------------------------------
-- Saved Job
----------------------------------------------------------
INSERT INTO SavedJob
(
    Id,
    Job,
    SavedBy,
    DateSaved
)
VALUES
(
    @SavedJobId,
    @JobPostId,
    @JobSeekerId,
    GETDATE()
);

----------------------------------------------------------
-- Job Application
----------------------------------------------------------
INSERT INTO JobApplication
(
    Id,
    JobPost_id,
    Applicant,
    Resume_id,
    CoverLetter,
    Datesubmitted,
    Status
)
VALUES
(
    @ApplicationId,
    @JobPostId,
    @JobSeekerId,
    @ResumeId,
    'I am excited to apply for this Senior .NET Developer position.',
    GETDATE(),
    1
);

----------------------------------------------------------
-- Interview
----------------------------------------------------------
INSERT INTO Interview
(
    Id,
    JobId,
    Interviewee,
    ApplicationId,
    Date,
    Status,
    SheduledBy,
    CompanyId
)
VALUES
(
    @InterviewId,
    @JobPostId,
    @JobSeekerId,
    @ApplicationId,
    DATEADD(DAY, 5, GETDATE()),
    0,
    @CompanyUserId,
    @CompanyId
);
------------------------------------------------------------
-- Message Group
------------------------------------------------------------

DECLARE @GroupId UNIQUEIDENTIFIER = NEWID();

INSERT INTO MessageGroup
(
    Id,
    Name,
    NewCount,
    IsNewMessages,
    Members
)
VALUES
(
    @GroupId,
    'TechNova Discussion',
    0,
    0,
    'Michael Brown, Sarah Thomas'
);

------------------------------------------------------------
-- Group Member
------------------------------------------------------------

DECLARE @GroupMemberId UNIQUEIDENTIFIER = NEWID();

INSERT INTO GroupMember
(
    Id,
    Name,
    ToUserId,
    Email,
    MessageGroupId
)
VALUES
(
    @GroupMemberId,
    'Sarah Thomas',
    @JobSeekerId,
    'sarah@gmail.com',
    @GroupId
);

------------------------------------------------------------
-- Message
------------------------------------------------------------



INSERT INTO Message
(
    Id,
    FromUserId,
    ToUserId,
    MessageGroupId,
    [From],
    [To],
    Content,
    SentDate,
    ToGroup,
    Status
)
VALUES
(
    @MessageId,
    @CompanyUserId,
    @JobSeekerId,
    @GroupId,
    'Michael Brown',
    'Sarah Thomas',
    'Congratulations! Your interview has been scheduled.',
    GETDATE(),
    'TechNova Discussion',
    1
);

------------------------------------------------------------
-- SignUpRequest
------------------------------------------------------------

DECLARE @RequestId UNIQUEIDENTIFIER = NEWID();

INSERT INTO SignUpRequest
(
    Id,
    UserName,
    FirstName,
    LastName,
    Phone,
    Email,
    Status
)
VALUES
(
    @RequestId,
    'johnsmith',
    'John',
    'Smith',
    '9123456789',
    'johnsmith@gmail.com',
    0
);

------------------------------------------------------------
-- Role
------------------------------------------------------------

INSERT INTO Role
(
    Id,
    Name,
    Description
)
VALUES
(NEWID(),'Administrator','System Administrator'),
(NEWID(),'Company','Company User'),
(NEWID(),'Job Seeker','Candidate');

------------------------------------------------------------
-- JobSeekerProfileSkill
------------------------------------------------------------

INSERT INTO JobSeekerProfileSkill
(
    JobSeekerProfileId,
    SkillId,
    CreatedDate
)
VALUES
(
    @ProfileId,
    @SkillId,
    GETDATE()
);

PRINT 'All sample records inserted successfully.';