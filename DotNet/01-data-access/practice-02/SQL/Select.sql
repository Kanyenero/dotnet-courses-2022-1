USE [AttendanceLog];

SELECT *
FROM [AttendanceLog].[dbo].[Students];

SELECT *
FROM [AttendanceLog].[dbo].[Lectures];

--DELETE FROM Attendance WHERE Student_Id = 6 AND Lecture_Id = 6
--EXEC MarkAttendance @Student_Id = 5, @Lecture_Id = 5, @Mark = NULL
--GO

SELECT *
FROM [AttendanceLog].[dbo].[Attendance];

SELECT
	[Date],
	[Topic],
	[Student_Id],
	[First_Name],
	[Middle_Name],
	[Last_Name],
	[Mark]
FROM [Lectures]
	FULL JOIN 
		(SELECT * FROM [Students]
		LEFT JOIN [Attendance] 
		ON [Attendance].[Student_Id] = [Students].[Id])
		AS [Inner]
	ON [Inner].[Lecture_Id] = [Lectures].[Id]
		
