USE [AttendanceLog];

DELETE FROM [Students];
DBCC CHECKIDENT ('[Students]', RESEED, 0);

--INSERT INTO [Students] 
--VALUES 
--	('Ivan', 'Ivanovich', 'Ivanov', '6114683532'), 
--	('Anton', 'Antonovich', 'Antonov', '6114948301'), 
--	('Alexey', 'Alexeevich', 'Alexeev', '6114856304'), 
--	('Vitaly', 'Vitalievich', 'Vitaliev', '6114123956'), 
--	('Maxim', 'Maximovich', 'Maximov', '6114234925'),
--	('Alexander', NULL, 'Alexandrov', '6114490368');
