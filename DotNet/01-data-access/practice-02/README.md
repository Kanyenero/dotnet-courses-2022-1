## Задание

Разработать консольное приложение, позволяющее отмечать посещение студентов на паре и оценку.

Функциональность.
1. AttendanceLog.exe -init (инициализировать базу данных)  
    Создать:  
    - таблицу студентов (Students {FirstName, LastName, Passport})
    - таблицу лекций (Lecture {Date, Topic})
    - таблицу посещаемости (Attendance {LectureDate, LectureTopic, StudentFirstName, StudentLastName, Mark})
    - хранимую процедуру, отмечающую определенного студента на лекции  
      MarkAttendance @StudentName, @LectureDate, @Mark

2. AttendanceLog.exe -lecture &lt;DATE&gt; &lt;TOPIC&gt; (добавить лекцию в таблицу лекций (по дате))  
3. AttendanceLog.exe -student &lt;FIRSTNAME&gt; &lt;LASTNAME&gt; &lt;PASSPORT&gt; (добавить студента в таблицу студентов)  
4. AttendanceLog.exe -attend &lt;STUDENT_NAME&gt; &lt;DATE&gt; &lt;MARK&gt; (добавить запись о посещении студента в таблице посещаемости)  
5. AttendanceLog.exe -report (вывести отчет о посещаемости)  
    - выводить Topic лекции;
    - если студент не посетил ни одной лекции, все равно выводить его имя и фамилию;
    - если лекцию никто не посетил, все равно выводить дату и тему.

<!-- ## Результаты
### Команда init
![Init Console](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/init3.png?raw=true)
![Init Result 1](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/init1.png?raw=true)
![Init Result 2](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/init2.png?raw=true)
### Команда student add
![Student](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/students.png?raw=true)
### Команда lecture add
![Lecture](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/lectures.png?raw=true)
### Команда attend
![Attend](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/attend.png?raw=true)
### Команда report
![Report](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/report.png?raw=true) -->