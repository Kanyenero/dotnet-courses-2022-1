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
      Students {StudentID, FirstName, LastName, UniqueLogin},
    - таблицу лекций
      Lecture {LectureID, Date, Course, Topic},
    - таблицу посещаемости
      Attendance {LectureID, StudentID, Mark}
    - хранимую процедуру, отмечающую определенного студента на лекции
      MarkAttendance @LectureID, @StudentID, @Mark

2. Добавить/получить/обновить/удалить лекцию (по дате):
    ```powershell
    AttendanceLog.exe lecture --add <DATE> <COURSE> <TOPIC>

    AttendanceLog.exe lecture --get <ID>
    AttendanceLog.exe lecture --get <DATE> <COURSE> <TOPIC>

    AttendanceLog.exe lecture --update <ID> <DATE> <COURSE> <TOPIC>

    AttendanceLog.exe lecture --delete <ID>
    AttendanceLog.exe lecture --delete <DATE> <COURSE> <TOPIC>
    ```

3. Добавить/получить/обновить/удалить студента:
    ```powershell
    AttendanceLog.exe student --add <FIRSTNAME> <LASTNAME> <UNIQUELOGIN>

    AttendanceLog.exe student --get <ID>
    AttendanceLog.exe student --get <FIRSTNAME> <LASTNAME> <UNIQUELOGIN>

    AttendanceLog.exe student --update <ID> <FIRSTNAME> <LASTNAME> <UNIQUELOGIN>

    AttendanceLog.exe student --delete <ID>
    AttendanceLog.exe student --delete <FIRSTNAME> <LASTNAME> <UNIQUELOGIN>
    ```

4. Добавить запись о посещении студента в таблице посещаемости (использовать хранимую процедуру):
    ```powershell
    AttendanceLog.exe attend <LECTURE_ID> <STUDENT_ID> <MARK>
    ```

5. Вывести отчет о посещаемости:
    ```powershell
    AttendanceLog.exe report
    ```
    - если студент не посетил ни одной лекции, все равно выводить его имя и фамилию;
    - если лекцию никто не посетил, все равно выводить дату и тему.
