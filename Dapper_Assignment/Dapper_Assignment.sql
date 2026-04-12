CREATE DATABASE BookDB;
GO

USE BookDB;

CREATE TABLE Books (
    BookId INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100),
    Price DECIMAL(10,2),
    Author NVARCHAR(100),
    Publisher NVARCHAR(100),
    Language NVARCHAR(50),
    PublishDate DATE
);

INSERT INTO Books (Title, Price, Author, Publisher, Language, PublishDate)
VALUES
('C# Basics', 500, 'John', 'ABC Pub', 'English', '2022-01-01'),
('Java Guide', 600, 'David', 'XYZ Pub', 'English', '2021-05-10'),
('Python Intro', 450, 'Sara', 'Tech Pub', 'English', '2023-03-15'),
('Telugu Kadhalu', 300, 'Ravi', 'Telugu Pub', 'Telugu', '2020-07-20');