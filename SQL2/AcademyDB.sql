CREATE DATABASE AcademyDB
USE AcademyDB

CREATE TABLE Students (
Id int IDENTITY primary key,
FirstName NVARCHAR(40),
LastName NVARCHAR(40),
DataOfBirth DATE,
Username NVARCHAR(40),
Password NVARCHAR(40),
EnrollmentDate DATE
)

CREATE PROCEDURE StudentsData 
@Name NVARCHAR(40),
@Surname NVARCHAR(40),
@DateOfBirth DATE,
@EnrollmentDate DATE
AS
BEGIN 
INSERT INTO Students (FirstName, LastName, DataOfBirth, EnrollmentDate)
VALUES (@Name , @Surname, @DateOfBirth, @EnrollmentDate)
END 

EXEC StudentsData
@Name = 'Sema',
@Surname = 'Qurbanova',
@DateOfBirth = '2004-12-06',
@EnrollmentDate = '2024-09-30'



CREATE TABLE Departments (
Id int identity primary key,
DepartmentName nvarchar(40)
)


CREATE TABLE Instructors(
Id int IDENTITY primary key,
FirstName NVARCHAR(40),
LastName NVARCHAR(40),
HireDate DATE,
DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
Username NVARCHAR(30),
Password NVARCHAR(30),
PIN NVARCHAR(7)
)


CREATE TABLE Groups (
Id int IDENTITY primary key,
GroupName NVARCHAR(40),
DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
StartDate DATE,
EndDate DATE 
)
INSERT INTO Groups(GroupName,StartDate) 
Values ('AB205' , '2024-09-30'),
('AF104' , '2024-09-29')



CREATE TABLE Enrollments(
Id int IDENTITY primary key,
StudentId INT FOREIGN KEY REFERENCES Students(Id),
GroupId INT FOREIGN KEY REFERENCES Groups(Id)
)

INSERT INTO Enrollments (StudentId, GroupId)
VALUES (8,4), (9,3), (10,2)

CREATE TABLE Classes(
Id INT IDENTITY PRIMARY KEY,
GroupId INT FOREIGN KEY REFERENCES Groups(Id),
InstructorId INT FOREIGN KEY REFERENCES Instructors(Id),
Schedule NVARCHAR(50),
RoomName NVARCHAR(40)
)

INSERT INTO Classes(GroupId,Schedule,RoomName)
VALUES (4,'Monday 14:00-20:00', 'Room A101'),
(5, 'Wednesday 14:00-20:00', 'Room B202')
DROP TABLE Classes

SELECT * FROM  Students
SELECT * FROM  Groups
SELECT * FROM  Enrollments
SELECT * FROM  Classes


CREATE FUNCTION ClassSchedule()
RETURNS TABLE 
AS
RETURN
(
SELECT  Students.Id as StudentId,
Students.FirstName as SudentName,
Students.LastName as StudentSurname,
Groups.GroupName ,
Classes.Schedule ,
Classes.RoomName
FROM Students
INNER JOIN Enrollments ON Students.Id = Enrollments.StudentId
INNER JOIN Groups ON Enrollments.GroupId = Groups.Id
INNER JOIN Classes ON Groups.Id = Classes.GroupId
)

SELECT * FROM ClassSchedule() 
DROP FUNCTION ClassSchedule