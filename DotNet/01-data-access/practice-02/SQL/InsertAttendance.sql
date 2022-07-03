USE [AttendanceLog];

DELETE FROM [Attendance];

INSERT INTO [Attendance] 
VALUES 
	(1, 1, 5),
	(1, 2, 5),
	(1, 3, 5),
	(1, 4, 5),
	(1, 5, 5),

	(2, 1, NULL),
	(2, 2, NULL),
	(2, 3, NULL),
	(2, 4, NULL),
	(2, 5, NULL),

	(3, 1, 2),
	(3, 3, 3),
	(3, 5, 2),

	(4, 1, 5),
	(4, 2, NULL),
	(4, 4, NULL),
	(4, 5, 4);
