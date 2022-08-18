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


## Примеры использования
- Инициализация базы данных
    ```powershell
    > .\AttendanceLog.exe init
    ```
    ![tables](https://github.com/Kanyenero/dotnet-courses-2022-1/blob/master/DotNet/01-data-access/practice-03/Resources/tables.png?raw=true)
- Добавление сущности
    ```powershell
    > .\AttendanceLog.exe student add FirstName:Kendrick LastName:Lamar UniqueLogin:KendrickLamar1
    ```
- Получение сущности
    ```powershell
    > .\AttendanceLog.exe student get Id:1
    1    Kendrick  Lamar               KendrickLamar1

    > .\AttendanceLog.exe student get FirstName:Kendrick LastName:Lamar UniqueLogin:KendrickLamar1
    1    Kendrick  Lamar               KendrickLamar1
    ```
- Обновление сущности
    ```powershell
    > .\AttendanceLog.exe student update Id:1 FirstName:Kendrick LastName:Lamar UniqueLogin:KendrickLamar2
    > .\AttendanceLog.exe student get Id:1
    1    Kendrick  Lamar               KendrickLamar2
    ```
- Удаление сущности
    ```powershell
    > .\AttendanceLog.exe student delete Id:1
    > .\AttendanceLog.exe student delete FirstName:Kendrick LastName:Lamar UniqueLogin:KendrickLamar2
    ```
- Получение всех сущностей
    ```powershell
    > .\AttendanceLog.exe attendances getall
    20.04.2022 4:20:00  Botany         Weed varieties                KendrickLamar1           Kendrick  Lamar               4
    20.04.2022 4:20:00  Botany         Weed varieties                SnoopDoggyDog1           Snoop     Dogg                5
    20.04.2022 6:20:00  Martial Arts   Kick in the balls             KendrickLamar1           Kendrick  Lamar               2
    20.04.2022 6:20:00  Martial Arts   Kick in the balls             MikkeyRourke1            Mikkey    Rourke              5
    ```
