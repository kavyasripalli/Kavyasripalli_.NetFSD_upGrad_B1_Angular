--Assignment_1

create database SQL_Assignment_3

use SQL_Assignment_3

CREATE TABLE Departments (
DepartmentID INT PRIMARY KEY,
DepartmentName VARCHAR(100),
Location VARCHAR(100)
);

CREATE TABLE Teachers (
TeacherID INT PRIMARY KEY,
TeacherName VARCHAR(100),
Email VARCHAR(100),
DepartmentID INT,
HireDate DATE,
    
FOREIGN KEY (DepartmentID)
REFERENCES Departments(DepartmentID)
);

CREATE TABLE Students (
StudentID INT PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
DateOfBirth DATE,
Gender CHAR(1),
DepartmentID INT,
AdmissionDate DATE,

FOREIGN KEY (DepartmentID)
REFERENCES Departments(DepartmentID)
);

CREATE TABLE Courses (
CourseID INT PRIMARY KEY,
CourseName VARCHAR(100),
Credits INT,
DepartmentID INT,
TeacherID INT,

FOREIGN KEY (DepartmentID)
REFERENCES Departments(DepartmentID),

FOREIGN KEY (TeacherID)
REFERENCES Teachers(TeacherID)
);

CREATE TABLE Enrollments (
EnrollmentID INT PRIMARY KEY,
StudentID INT,
CourseID INT,
EnrollmentDate DATE,

FOREIGN KEY (StudentID)
REFERENCES Students(StudentID),

FOREIGN KEY (CourseID)
REFERENCES Courses(CourseID)
);

CREATE TABLE Exams (
ExamID INT PRIMARY KEY,
CourseID INT,
ExamDate DATE,
ExamType VARCHAR(50),

FOREIGN KEY (CourseID)
REFERENCES Courses(CourseID)
);

CREATE TABLE Marks (
MarkID INT PRIMARY KEY,
StudentID INT,
ExamID INT,
MarksObtained INT,

FOREIGN KEY (StudentID)
REFERENCES Students(StudentID),

FOREIGN KEY (ExamID)
REFERENCES Exams(ExamID)
);

--Assignment_2

ALTER TABLE Departments
ADD CONSTRAINT UQ_DepartmentName
UNIQUE (DepartmentName);

ALTER TABLE Students
ADD CONSTRAINT CHK_Gender
CHECK (Gender IN ('M','F'));

ALTER TABLE Courses
ADD CONSTRAINT CHK_Credits
CHECK (Credits BETWEEN 1 AND 5);

ALTER TABLE Marks
ADD CONSTRAINT CHK_Marks
CHECK (MarksObtained BETWEEN 0 AND 100);

ALTER TABLE Teachers
ADD CONSTRAINT UQ_TeacherEmail
UNIQUE (Email);

ALTER TABLE Enrollments
ADD CONSTRAINT DF_EnrollmentDate
DEFAULT GETDATE() FOR EnrollmentDate;

--Assignment_3

ALTER TABLE Students
ADD PhoneNumber VARCHAR(15);

ALTER TABLE Teachers
ADD Salary INT;

ALTER TABLE Teachers
ALTER COLUMN Salary DECIMAL(10,2);

ALTER TABLE Teachers
ADD CONSTRAINT CHK_Salary
CHECK (Salary > 20000);

ALTER TABLE Students
DROP COLUMN PhoneNumber;

EXEC sp_rename 'Teachers.TeacherName', 'FullName', 'COLUMN';

--Assignment_4

INSERT INTO Departments VALUES (1,'Computer Science','Hyderabad');
INSERT INTO Departments VALUES (2,'Mechanical','Vijayawada');
INSERT INTO Departments VALUES (3,'Electronics','Guntur');
INSERT INTO Departments VALUES (4,'Civil','Visakhapatnam');
INSERT INTO Departments VALUES (5,'Information Technology','Warangal');

INSERT INTO Teachers VALUES (1,'Ravi Kumar','ravi@gmail.com',1,'2021-06-10',50000);
INSERT INTO Teachers VALUES (2,'Suresh Reddy','suresh@gmail.com',2,'2020-03-15',55000);
INSERT INTO Teachers VALUES (3,'Lakshmi Devi','lakshmi@gmail.com',3,'2019-01-20',60000);
INSERT INTO Teachers VALUES (4,'Anil Kumar','anil@gmail.com',1,'2022-07-11',45000);
INSERT INTO Teachers VALUES (5,'Prasad Rao','prasad@gmail.com',4,'2018-02-12',70000);
INSERT INTO Teachers VALUES (6,'Mahesh Babu','mahesh@gmail.com',5,'2021-05-30',52000);
INSERT INTO Teachers VALUES (7,'Rajesh Naidu','rajesh@gmail.com',2,'2023-01-10',42000);
INSERT INTO Teachers VALUES (8,'Sridevi','sridevi@gmail.com',3,'2020-09-18',48000);
INSERT INTO Teachers VALUES (9,'Harish Kumar','harish@gmail.com',4,'2019-11-05',65000);
INSERT INTO Teachers VALUES (10,'Sunitha','sunitha@gmail.com',5,'2022-04-25',46000);

INSERT INTO Students VALUES (101,'Kavya','Sri','2005-04-10','F',1,'2023-06-01');
INSERT INTO Students VALUES (102,'Sai','Kiran','2004-09-15','M',2,'2022-06-01');
INSERT INTO Students VALUES (103,'Rohit','Reddy','2005-02-11','M',1,'2023-06-01');
INSERT INTO Students VALUES (104,'Anusha','Devi','2006-01-08','F',3,'2023-06-01');
INSERT INTO Students VALUES (105,'Vamsi','Krishna','2004-07-19','M',4,'2022-06-01');
INSERT INTO Students VALUES (106,'Sravani','Rao','2005-10-23','F',1,'2023-06-01');
INSERT INTO Students VALUES (107,'Praneeth','Kumar','2004-03-14','M',2,'2022-06-01');
INSERT INTO Students VALUES (108,'Deepika','Reddy','2005-06-30','F',3,'2023-06-01');
INSERT INTO Students VALUES (109,'Tarun','Naidu','2004-12-01','M',4,'2022-06-01');
INSERT INTO Students VALUES (110,'Naveen','Rao','2005-05-21','M',5,'2023-06-01');
INSERT INTO Students VALUES (111,'Divya','Sri','2006-02-17','F',1,'2023-06-01');
INSERT INTO Students VALUES (112,'Harika','Reddy','2005-09-05','F',2,'2023-06-01');
INSERT INTO Students VALUES (113,'Ajay','Kumar','2004-11-22','M',3,'2022-06-01');
INSERT INTO Students VALUES (114,'Manoj','Naidu','2005-08-12','M',4,'2023-06-01');
INSERT INTO Students VALUES (115,'Sneha','Rao','2006-03-09','F',5,'2023-06-01');
INSERT INTO Students VALUES (116,'Chaitanya','Reddy','2004-04-18','M',1,'2022-06-01');
INSERT INTO Students VALUES (117,'Pooja','Devi','2005-07-25','F',2,'2023-06-01');
INSERT INTO Students VALUES (118,'Arjun','Kumar','2004-10-30','M',3,'2022-06-01');
INSERT INTO Students VALUES (119,'Keerthi','Sri','2005-12-05','F',4,'2023-06-01');
INSERT INTO Students VALUES (120,'Rahul','Reddy','2004-01-14','M',5,'2022-06-01');

INSERT INTO Courses VALUES (201,'Database Systems',4,1,1);
INSERT INTO Courses VALUES (202,'Thermodynamics',3,2,2);
INSERT INTO Courses VALUES (203,'Digital Electronics',4,3,3);
INSERT INTO Courses VALUES (204,'Structural Engineering',3,4,5);
INSERT INTO Courses VALUES (205,'Web Development',5,5,6);
INSERT INTO Courses VALUES (206,'Data Structures',4,1,4);
INSERT INTO Courses VALUES (207,'Machine Design',3,2,7);
INSERT INTO Courses VALUES (208,'Microprocessors',4,3,8);
INSERT INTO Courses VALUES (209,'Surveying',2,4,9);
INSERT INTO Courses VALUES (210,'Software Engineering',4,5,10);

INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (1,101,201);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (2,102,202);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (3,103,201);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (4,104,203);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (5,105,204);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (6,106,206);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (7,107,207);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (8,108,208);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (9,109,209);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (10,110,210);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (11,111,201);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (12,112,202);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (13,113,203);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (14,114,204);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (15,115,205);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (16,116,206);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (17,117,207);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (18,118,208);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (19,119,209);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (20,120,210);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (21,101,206);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (22,102,207);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (23,103,208);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (24,104,209);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (25,105,210);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (26,106,201);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (27,107,202);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (28,108,203);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (29,109,204);
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES (30,110,205);

INSERT INTO Exams VALUES (1,201,'2025-03-01','Midterm');
INSERT INTO Exams VALUES (2,202,'2025-03-02','Midterm');
INSERT INTO Exams VALUES (3,203,'2025-03-03','Final');
INSERT INTO Exams VALUES (4,204,'2025-03-04','Final');
INSERT INTO Exams VALUES (5,205,'2025-03-05','Midterm');

INSERT INTO Marks VALUES (1,101,1,85);
INSERT INTO Marks VALUES (2,102,2,78);
INSERT INTO Marks VALUES (3,103,1,90);
INSERT INTO Marks VALUES (4,104,3,70);
INSERT INTO Marks VALUES (5,105,4,88);
INSERT INTO Marks VALUES (6,106,1,76);
INSERT INTO Marks VALUES (7,107,2,82);
INSERT INTO Marks VALUES (8,108,3,91);
INSERT INTO Marks VALUES (9,109,4,67);
INSERT INTO Marks VALUES (10,110,5,89);
INSERT INTO Marks VALUES (11,111,1,73);
INSERT INTO Marks VALUES (12,112,2,80);
INSERT INTO Marks VALUES (13,113,3,84);
INSERT INTO Marks VALUES (14,114,4,79);
INSERT INTO Marks VALUES (15,115,5,92);
INSERT INTO Marks VALUES (16,116,1,77);
INSERT INTO Marks VALUES (17,117,2,81);
INSERT INTO Marks VALUES (18,118,3,69);
INSERT INTO Marks VALUES (19,119,4,86);
INSERT INTO Marks VALUES (20,120,5,75);
INSERT INTO Marks VALUES (21,101,5,88);
INSERT INTO Marks VALUES (22,102,1,79);
INSERT INTO Marks VALUES (23,103,2,83);
INSERT INTO Marks VALUES (24,104,3,74);
INSERT INTO Marks VALUES (25,105,4,91);
INSERT INTO Marks VALUES (26,106,5,72);
INSERT INTO Marks VALUES (27,107,1,85);
INSERT INTO Marks VALUES (28,108,2,87);
INSERT INTO Marks VALUES (29,109,3,68);
INSERT INTO Marks VALUES (30,110,4,90);

--Assignment_5

SELECT * FROM Students
WHERE DepartmentID = (
SELECT DepartmentID 
FROM Departments 
WHERE DepartmentName = 'Computer Science'
);

SELECT * FROM Teachers
WHERE HireDate > '2022-12-31';

SELECT * FROM Students
WHERE FirstName LIKE 'A%';

SELECT * FROM Courses
WHERE Credits > 3;

SELECT * FROM Students
WHERE DateOfBirth BETWEEN '2005-01-01' AND '2008-12-31';

SELECT * FROM Students
WHERE DepartmentID <> (
SELECT DepartmentID 
FROM Departments 
WHERE DepartmentName = 'Mechanical'
);

SELECT * FROM Teachers
WHERE Salary BETWEEN 40000 AND 70000;

SELECT * FROM Courses
WHERE TeacherID <> 3;

--Assignment_6

SELECT DepartmentID, COUNT(StudentID) AS TotalStudents FROM Students
GROUP BY DepartmentID;

SELECT ExamID, AVG(MarksObtained) AS AverageMarks FROM Marks
GROUP BY ExamID;

SELECT CourseID, COUNT(StudentID) AS TotalStudents FROM Enrollments
GROUP BY CourseID;

SELECT ExamID, MAX(MarksObtained) AS MaxMarks FROM Marks
GROUP BY ExamID;

SELECT E.CourseID, MIN(M.MarksObtained) AS MinMarks FROM Marks M
JOIN Exams E ON M.ExamID = E.ExamID
GROUP BY E.CourseID;

SELECT DepartmentID, COUNT(StudentID) AS TotalStudents FROM Students
GROUP BY DepartmentID
HAVING COUNT(StudentID) > 5;

--Assignment_7

SELECT S.StudentID, S.FirstName, S.LastName, D.DepartmentName FROM Students S
JOIN Departments D ON S.DepartmentID = D.DepartmentID;

SELECT C.CourseName, T.FullName FROM Courses C
JOIN Teachers T ON C.TeacherID = T.TeacherID;

SELECT S.FirstName, S.LastName, C.CourseName FROM Students S
JOIN Enrollments E ON S.StudentID = E.StudentID
JOIN Courses C ON E.CourseID = C.CourseID;

SELECT S.FirstName, S.LastName, E.ExamType, M.MarksObtained FROM Students S
JOIN Marks M ON S.StudentID = M.StudentID
JOIN Exams E ON M.ExamID = E.ExamID;

SELECT C.CourseName, T.FullName FROM Courses C
LEFT JOIN Teachers T ON C.TeacherID = T.TeacherID;

SELECT T.FullName FROM Teachers T
LEFT JOIN Courses C ON T.TeacherID = C.TeacherID
WHERE C.CourseID IS NULL;

--Assignment_8

SELECT StudentID, MarksObtained FROM Marks
WHERE MarksObtained > (SELECT AVG(MarksObtained) FROM Marks);

SELECT * FROM Courses
WHERE Credits = (SELECT MAX(Credits) FROM Courses);

SELECT StudentID FROM Enrollments
GROUP BY StudentID
HAVING COUNT(CourseID) > 2;

SELECT * FROM Teachers
WHERE DepartmentID = (SELECT DepartmentID FROM Teachers WHERE FullName = 'John');

SELECT StudentID, ExamID, MarksObtained FROM Marks
WHERE MarksObtained = (SELECT MAX(MarksObtained) FROM Marks);

SELECT DepartmentID FROM Students
GROUP BY DepartmentID
HAVING COUNT(StudentID) = (SELECT MAX(StudentCount)
FROM (SELECT COUNT(StudentID) AS StudentCount FROM Students
GROUP BY DepartmentID) AS DeptCount);

--Assignment_9

GO
CREATE VIEW StudentDeptView AS
SELECT 
S.StudentID,
S.FirstName + ' ' + S.LastName AS StudentName,
D.DepartmentName
FROM Students S
JOIN Departments D
ON S.DepartmentID = D.DepartmentID;

CREATE VIEW StudentCourseView AS
SELECT 
S.FirstName + ' ' + S.LastName AS StudentName,
C.CourseName,
E.EnrollmentDate
FROM Students S
JOIN Enrollments E
ON S.StudentID = E.StudentID
JOIN Courses C
ON E.CourseID = C.CourseID;

CREATE VIEW ExamResultView AS
SELECT 
S.FirstName + ' ' + S.LastName AS StudentName,
C.CourseName,
E.ExamType,
M.MarksObtained
FROM Students S
JOIN Marks M
ON S.StudentID = M.StudentID
JOIN Exams E
ON M.ExamID = E.ExamID
JOIN Courses C
ON E.CourseID = C.CourseID;

SELECT * FROM StudentDeptView;

SELECT * FROM StudentCourseView;

SELECT * FROM ExamResultView;

UPDATE Students
SET FirstName = 'Kavya', LastName = 'Sri'
WHERE StudentID = 101;

DROP VIEW StudentDeptView;

DROP VIEW StudentCourseView;

DROP VIEW ExamResultView;

--Assignment_10

CREATE INDEX IDX_Student_LastName ON Students(LastName);

CREATE INDEX IDX_Teacher_Email ON Teachers(Email);

CREATE INDEX IDX_Enrollments_Student_Course ON Enrollments(StudentID, CourseID);

CREATE UNIQUE INDEX IDX_Department_Name ON Departments(DepartmentName);

DROP INDEX IDX_Student_LastName ON Students;