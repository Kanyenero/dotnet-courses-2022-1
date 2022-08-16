## Задание

Разработать консольное приложение, позволяющее отмечать посещение студентов на лекции и оценку.
Реализовать стандартные операции CRUD для студентов и лекций.

Функциональность.
1. Инициализировать базу данных  
  ```
  AttendanceLog.exe init
  ```
  Создать:
    - таблицу студентов  
      Students {StudentID, FirstName, LastName, Passport},  
    - таблицу лекций  
      Lecture {LectureID, Date, Course, Topic},  
    - таблицу посещаемости  
      Attendance {LectureID, StudentID, Mark}  
    - хранимую процедуру, отмечающую определенного студента на лекции  
      MarkAttendance @LectureID, @StudentID, @Mark

2. Добавить/получить/обновить/удалить лекцию (по дате)  
  ```powershell
  AttendanceLog.exe lecture --add <DATE> <COURSE> <TOPIC>

  AttendanceLog.exe lecture --get <ID>
  AttendanceLog.exe lecture --get <DATE> <COURSE> <TOPIC>

  AttendanceLog.exe lecture --update <ID> <DATE> <COURSE> <TOPIC>

  AttendanceLog.exe lecture --delete <ID>
  AttendanceLog.exe lecture --delete <DATE> <COURSE> <TOPIC>
  ```
3. Добавить студента в таблицу студентов  
  ```powershell
  AttendanceLog.exe student --add <FIRSTNAME> <LASTNAME> <PASSPORT>

  AttendanceLog.exe student --get <ID>
  AttendanceLog.exe student --get <FIRSTNAME> <LASTNAME> <PASSPORT>

  AttendanceLog.exe student --update <ID> <FIRSTNAME> <LASTNAME> <PASSPORT>

  AttendanceLog.exe student --delete <ID>
  AttendanceLog.exe student --delete <FIRSTNAME> <LASTNAME> <PASSPORT>
  ```
4. Добавить запись о посещении студента в таблице посещаемости  
  ```powershell
  AttendanceLog.exe attend <LECTURE_ID> <STUDENT_ID> <MARK>
  ```
5. Вывести отчет о посещаемости  
  ```powershell
  AttendanceLog.exe report
  ```
    - выводить Topic лекции;
    - если студент не посетил ни одной лекции, все равно выводить его имя и фамилию;
    - если лекцию никто не посетил, все равно выводить дату и тему.

Дополнительно:
- создать алиасы для команд, чтобы их можно было вводить более удобным способом, например  
  ```
  AttendanceLog.exe lecture --с &lt;DATE&gt; &lt;TOPIC&gt;
  ```
  


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