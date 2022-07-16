USE master

ALTER DATABASE [AttendanceLog] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
IF(db_id(N'AttendanceLog')) IS NOT NULL DROP DATABASE [AttendanceLog];

CREATE DATABASE AttendanceLog;

GO
USE AttendanceLog;

DROP TABLE IF EXISTS [dbo].[Students]
--CREATE TABLE [Students]
--(
--	[Id] INT IDENTITY(1, 1),
--	[First_Name] VARCHAR(50) NOT NULL,
--	[Middle_Name] VARCHAR(50) NULL,
--	[Last_Name] VARCHAR(50) NOT NULL,
--	[UQ_Passport_Series_and_Number] VARCHAR(10) UNIQUE,

--	PRIMARY KEY([Id])
--)

DROP TABLE IF EXISTS [dbo].[Lectures]
GO

--CREATE TABLE [Lectures]
--(
--	[Id] INT IDENTITY(1, 1),
--    [Topic] VARCHAR(50) NOT NULL,
--    [Date] SMALLDATETIME NOT NULL,

--	PRIMARY KEY([Id])
--)

DROP TABLE IF EXISTS [dbo].[Attendance]
GO

--CREATE TABLE [Attendance]
--(
--	[Student_Id] INT NOT NULL,
--	[Lecture_Id] INT NOT NULL,
--    [Mark] INT CHECK([Mark] >= 2 AND [Mark] <= 5) NULL,

--	PRIMARY KEY(Student_Id, Lecture_Id),

--	CONSTRAINT [FK_student]
--		FOREIGN KEY ([Student_Id]) 
--		REFERENCES [Students]([Id])
--		ON DELETE CASCADE,

--	CONSTRAINT [FK_lecture]
--		FOREIGN KEY ([Lecture_Id]) 
--		REFERENCES [Lectures]([Id])
--		ON DELETE CASCADE
--)

