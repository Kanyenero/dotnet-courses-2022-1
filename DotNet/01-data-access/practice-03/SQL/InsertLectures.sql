USE [AttendanceLog];

DELETE FROM [Lectures];
DBCC CHECKIDENT ('[Lectures]', RESEED, 0);

--INSERT INTO [Lectures] 
--VALUES
--	('ADO.NET', '2022-03-10T12:00:00'),
--	('ADO.NET', '2022-03-10T13:30:00'),
--	('Entity FW', '2022-03-11T12:00:00'),
--	('Entity FW', '2022-03-12T13:30:00'),
--	('ASP.NET', '2022-03-13T12:00:00'),
--	('Frontend Basics', '2022-03-14T12:00:00');