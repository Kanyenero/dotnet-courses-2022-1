USE AttendanceLog
GO

SELECT * FROM Students
GO

SELECT * FROM Lectures
GO

SELECT * FROM Attendances
GO

SELECT
	l.LectureID,
	l.[Date],
	l.Course,
	l.Topic,
	sa.StudentID,
	sa.UQ_Login,
	sa.FirstName,
	sa.LastName,
	sa.Mark
FROM 
	Lectures AS l
FULL JOIN 
   (SELECT 
		s.StudentID,
		s.UQ_Login,
		s.FirstName,
		s.LastName,
		a.LectureID,
		a.Mark
	FROM 
		Students AS s
	LEFT JOIN 
		Attendances AS a ON a.StudentID = s.StudentID) AS sa
	ON sa.LectureID = l.LectureID
GO	

SELECT
	a.LectureID,
	l.[Date],
	l.Course,
	l.Topic,
	a.StudentID,
	s.UQ_Login,
	s.FirstName,
	s.LastName,
	a.Mark
FROM 
	Lectures AS l
JOIN
	Attendances AS a ON l.LectureID = a.LectureID
JOIN
	Students As s ON s.StudentID = a.StudentID
WHERE
	a.LectureID = 1 AND a.StudentID = 1
GO
