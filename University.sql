CREATE DATABASE University
GO
USE University
CREATE TABLE Students (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(50) NOT NULL
)
INSERT INTO Students (Name) VALUES (N'Harry Potter')
INSERT INTO Students (Name) VALUES (N'Ron Weasley')
INSERT INTO Students (Name) VALUES (N'Hermione Granger')
