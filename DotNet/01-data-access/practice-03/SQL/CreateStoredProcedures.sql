USE [AttendanceLog];

DROP PROCEDURE MarkAttendance;

GO
CREATE PROCEDURE MarkAttendance (@Student_Id INT, @Lecture_Id INT, @Mark INT = NULL)
AS
BEGIN
	INSERT INTO [Attendance]
	VALUES (@Student_Id, @Lecture_Id, @Mark)
	SELECT @@ROWCOUNT
END

