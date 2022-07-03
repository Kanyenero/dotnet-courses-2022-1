### Задание

Разработать консольное приложение, позволяющее отмечать посещение студентов на паре и оценку.
Название: sc.exe

Функциональность:
- sc -init: инициализировать базу данных
    создать таблицу
    - студентов (Students {Name})
    - лекций (Lecture {Date, Topic})
    - посещаемости (Attendance {LectureDate, StudentName, Mark})
    - создать хранимую процедуру, отмечающую определенного студента на лекции
        MarkAttendance @StudentName, @LectureDate, @Mark

- sc -lecture <DATE> <TOPIC>: добавить лекцию в таблицу лекций (по дате)
    например: sc -lecture 18.12.2017 ADONET
- sc -student <NAME>: добавить студента в таблицу студентов
    например: sc -student Ivan
- sc -attend <STUDENT_NAME> <DATE> <MARK>: добавить запись о посещении студента в таблице посещаемости
    например: sc -attend Ivan 18.12.2017 5
    p.s. использовать ранее созданную хранимую процедуру
- sc -report: вывести отчет о посещаемости
    - выводить Topic лекции
    - если студент не посетил ни одной лекции, все равно выводить его имя
    - если лекцию никто не посеил, все равно выводить дату и тему

### Результаты
## Команда init
![Init Console](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/init3.png?raw=true)
![Init Result 1](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/init1.png?raw=true)
![Init Result 2](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/init2.png?raw=true)
## Команда student add
![Student](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/students.png?raw=true)
## Команда lecture add
![Lecture](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/lectures.png?raw=true)
## Команда attend
![Attend](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/attend.png?raw=true)
## Команда report
![Report](https://github.com/Kanyenero/dotnet-cources-2022-1/blob/master/DotNet/01-data-access/practice-02/Resources/report.png?raw=true)