using System.CommandLine;
using System.CommandLine.Parsing;
using DotNetCourse.AttendanceLog.Entities;

namespace DotNetCourse.AttendanceLog
{
    public class CmdHandler
    {
        private RootCommand rootCommand = default!;

        private readonly BusinessLogic.Student.IDataProvider studentDataProvider;
        private readonly BusinessLogic.Lecture.IDataProvider lectureDataProvider;
        private readonly BusinessLogic.Attendance.IDataProvider attendanceDataProvider;
        private readonly BusinessLogic.Database.IDataProvider databaseDataProvider;

        public CmdHandler(
            BusinessLogic.Student.IDataProvider studentDataProvider,
            BusinessLogic.Lecture.IDataProvider lectureDataProvider,
            BusinessLogic.Attendance.IDataProvider attendanceDataProvider,
            BusinessLogic.Database.IDataProvider databaseDataProvider)
        {
            this.studentDataProvider = studentDataProvider;
            this.lectureDataProvider = lectureDataProvider;
            this.attendanceDataProvider = attendanceDataProvider;
            this.databaseDataProvider = databaseDataProvider;
        }

        public void RunCommand(string[] args)
        {
            rootCommand.Invoke(args);
        }

        public RootCommand CreateCommandTree()
        {
            rootCommand = CreateRootCommand();

            var initCommand = CreateInitCommand();
            var studentCommand = CreateStudentCommand();
            var lectureCommand = CreateLectureCommand();
            var attendCommand = CreateAttendCommand();
            var reportCommand = CreateReportCommand();

            rootCommand.AddCommand(initCommand);
            rootCommand.AddCommand(studentCommand);
            rootCommand.AddCommand(lectureCommand);
            rootCommand.AddCommand(attendCommand);
            rootCommand.AddCommand(reportCommand);

            return rootCommand;
        }

        private static RootCommand CreateRootCommand()
        {
            var rootCommand = new RootCommand(
                description:
                "Using the commands below you can manage the AttendanceLog database " +
                "(add students and lectures, mark an attendance, and get a detailed attendance report)");

            rootCommand.AddAlias("AttendanceLog");

            return rootCommand;
        }

        private Command CreateInitCommand()
        {
            var initCommand = new Command(
                name: "init",
                description: "Provides the ability to initialize database with tables and stored procedures");

            initCommand.SetHandler(() => 
            { 
                bool initWithSuccess = databaseDataProvider.Init();

                if (initWithSuccess)
                    Console.WriteLine("Successfully initialized database");
                else
                    Console.WriteLine("Database initialization failed");
            });

            return initCommand;
        }

        private Command CreateReportCommand()
        {
            var reportCommand = new Command(
                name: "report",
                description: "Provides the ability to print detailed attendance report");

            reportCommand.SetHandler(() => 
            { 
                var attendances = databaseDataProvider.GetReport();

                foreach (var attendance in attendances)
                    Console.WriteLine(attendance);
            });

            return reportCommand;
        }

        private Command CreateStudentCommand()
        {
            var studentCommand = new Command(
                name: "student",
                description: "Provides the ability to work with student entities");

            var studentAddCommand = new Command(
                name: "add",
                description: "Use this command to add student to the database");

            var studentAddDataOption = new Option<Student>(
                name: "--data",
                description: "Use this option to add student to the database\n" +
                             "Expected args: [firstname] [middlename] [lastname] [passport]",
                parseArgument: result =>
                {
                    return ValidateStudentCommandArgumentResult("--data", new int[] { 3, 4 }, result);
                })
                {
                    AllowMultipleArgumentsPerToken = true,
                    Arity = ArgumentArity.OneOrMore
                };

            studentAddCommand.AddOption(studentAddDataOption);
            studentAddCommand.SetHandler((student) =>
            {
                int rowsAffected = studentDataProvider.Add(student);

                if (rowsAffected == 0)
                    Console.WriteLine("The student record is already exists or incorrect");
                else
                    Console.WriteLine("Student recorded successfully");

            }, studentAddDataOption);


            studentCommand.AddCommand(studentAddCommand);

            return studentCommand;
        }

        private Command CreateLectureCommand()
        {
            var lectureCommand = new Command(
                name: "lecture",
                description: "Provides the ability to work with lecture entities");

            var lectureAddCommand = new Command(
                name: "add",
                description: "Provides the ability to add lecture to the database");

            var lectureAddDataOption = new Option<Lecture>(
                name: "--data",
                description: "Use this option to add lecture to the database\n" +
                             "Expected args: [topic] [date]",
                parseArgument: result =>
                {
                    return ValidateLectureCommandArgumentResult("--data", new int[] { 2 }, result);
                })
                {
                    AllowMultipleArgumentsPerToken = true,
                    Arity = ArgumentArity.OneOrMore
                };

            lectureAddCommand.AddOption(lectureAddDataOption);
            lectureAddCommand.SetHandler((lecture) =>
            {
                int rowsAffected = lectureDataProvider.Add(lecture);

                if (rowsAffected == 0)
                    Console.WriteLine("The lecture record is already exists or incorrect");
                else
                    Console.WriteLine("Lecture recorded successfully");

            }, lectureAddDataOption);


            lectureCommand.AddCommand(lectureAddCommand);

            return lectureCommand;
        }

        private Command CreateAttendCommand()
        {
            var attendCommand = new Command(
                name: "attend",
                description: "Provides the ability to attend students on a lectures");


            var attendDataOption = new Option<Attendance>(
                name: "--data",
                description: "Use this option to attend student on a lecture\n" +
                             "Expected args: [studentId] [lectureId] [mark]",
                parseArgument: result =>
                {
                    return ValidateAttendCommandArgumentResult("--data", new int[] { 2, 3 }, result);
                })
                {
                    AllowMultipleArgumentsPerToken = true,
                    Arity = ArgumentArity.OneOrMore
                };

            attendCommand.AddOption(attendDataOption);

            attendCommand.SetHandler((attendance) => {
                int rowsAffected = attendanceDataProvider.Attend(attendance);

                if (rowsAffected == 0)
                    Console.WriteLine("The attendance record is already exists or incorrect");
                else
                    Console.WriteLine("Attendance recorded successfully");

            }, attendDataOption);

            return attendCommand;
        }

        private static Student ValidateStudentCommandArgumentResult(string optionName, int[] expectedTokensCounts, ArgumentResult argumentResult)
        {
            Student student;

            switch (optionName)
            {
                case "--data":
                    {
                        student = ValidateStudentDataTokens(expectedTokensCounts, argumentResult);
                        break;
                    }

                default:
                    return default!;
            }

            return student;
        }

        private static Lecture ValidateLectureCommandArgumentResult(string optionName, int[] expectedTokensCounts, ArgumentResult argumentResult)
        {
            Lecture lecture;

            switch (optionName)
            {
                case "--data":
                    {
                        lecture = ValidateLectureDataTokens(expectedTokensCounts, argumentResult);
                        break;
                    }

                default:
                    return default!;
            }

            return lecture;
        }

        private static Attendance ValidateAttendCommandArgumentResult(string optionName, int[] expectedTokensCounts, ArgumentResult argumentResult)
        {
            Attendance attendance;

            switch (optionName)
            {
                case "--data":
                    {
                        attendance = ValidateAttendDataTokens(expectedTokensCounts, argumentResult);
                        break;
                    }

                default:
                    return default!;
            }

            return attendance;
        }

        private static Student ValidateStudentDataTokens(int[] expectedTokensCounts, ArgumentResult argumentResult)
        {
            int actualTokensCount = argumentResult.Tokens.Count;

            if (!expectedTokensCounts.Contains(actualTokensCount))
            {
                argumentResult.ErrorMessage = $"There is no '--data' option with given number of arguments";
                return default!;
            }

            var student = new Student();

            int firstNameTokenNumber  = 1;
            int middleNameTokenNumber = 2;
            int lastNameTokenNumber   = 3;
            int passportTokenNumber   = 4;

            if (actualTokensCount == 3)
            {
                middleNameTokenNumber = -1;
                lastNameTokenNumber = 2;
                passportTokenNumber = 3;
            }

            int tokenCounter = 0;

            foreach (var token in argumentResult.Tokens)
            {
                tokenCounter++;

                if (tokenCounter == firstNameTokenNumber)
                {
                    if (token.Value != string.Empty)
                    {
                        student.FirstName = token.Value;

                        continue;
                    }

                    argumentResult.ErrorMessage = "--data arguments cannot be empty";
                    return default!;
                }

                if (tokenCounter == middleNameTokenNumber)
                {
                    if (token.Value != string.Empty)
                    {
                        student.MiddleName = token.Value;

                        continue;
                    }

                    argumentResult.ErrorMessage = "--data arguments cannot be empty";
                    return default!;
                }

                if (tokenCounter == lastNameTokenNumber)
                {
                    if (token.Value != string.Empty)
                    {
                        student.LastName = token.Value;

                        continue;
                    }

                    argumentResult.ErrorMessage = "--data arguments cannot be empty";
                    return default!;
                }

                if (tokenCounter == passportTokenNumber)
                {
                    if (token.Value != string.Empty)
                    {
                        student.PassportSeriesAndNumber = token.Value;

                        continue;
                    }

                    argumentResult.ErrorMessage = "--data arguments cannot be empty";
                    return default!;
                }
            }

            return student;
        }

        private static Lecture ValidateLectureDataTokens(int[] expectedTokensCounts, ArgumentResult argumentResult)
        {
            int actualTokensCount = argumentResult.Tokens.Count;

            if (!expectedTokensCounts.Contains(actualTokensCount))
            {
                argumentResult.ErrorMessage = $"There is no '--data' option with given number of arguments";
                return default!;
            }

            var lecture = new Lecture();

            int TopicTokenNumber = 1;
            int DateTokenNumber  = 2;

            int tokenCounter = 0;

            foreach (var token in argumentResult.Tokens)
            {
                tokenCounter++;

                if (tokenCounter == TopicTokenNumber)
                {
                    if (token.Value != string.Empty)
                    {
                        lecture.Topic = token.Value;

                        continue;
                    }

                    argumentResult.ErrorMessage = "--data arguments cannot be empty";
                    return default!;
                }

                if (tokenCounter == DateTokenNumber)
                {
                    if (DateTime.TryParse(token.Value, out var tokenValue))
                    {
                        lecture.Date = tokenValue;

                        continue;
                    }

                    argumentResult.ErrorMessage = "--data datetime argument was incorrect";
                    return default!;
                }
            }

            return lecture;
        }

        private static Attendance ValidateAttendDataTokens(int[] expectedTokensCounts, ArgumentResult argumentResult)
        {
            int actualTokensCount = argumentResult.Tokens.Count;

            if (!expectedTokensCounts.Contains(actualTokensCount))
            {
                argumentResult.ErrorMessage = $"There is no '--data' option with given number of arguments";
                return default!;
            }

            var attendance = new Attendance();

            int StudentIdTokenNumber = 1;
            int LectureIdTokenNumber = 2;
            int MarkTokenNumber = 3;

            if (actualTokensCount == 2)
            {
                MarkTokenNumber = -1;
            }

            int tokenCounter = 0;

            foreach (var token in argumentResult.Tokens)
            {
                tokenCounter++;

                if (tokenCounter == StudentIdTokenNumber)
                {
                    if (int.TryParse(token.Value, out var tokenValue))
                    {
                        if (tokenValue < 1)
                        {
                            argumentResult.ErrorMessage = "--data arguments must be greater than 0";
                            return default!;
                        }

                        attendance.StudentId = tokenValue;

                        continue;
                    }

                    argumentResult.ErrorMessage = "--data arguments must contain only digits";
                    return default!;
                }

                if (tokenCounter == LectureIdTokenNumber)
                {
                    if (int.TryParse(token.Value, out var tokenValue))
                    {
                        if (tokenValue < 1)
                        {
                            argumentResult.ErrorMessage = "--data arguments must be greater than 0";
                            return default!;
                        }

                        attendance.LectureId = tokenValue;

                        continue;
                    }

                    argumentResult.ErrorMessage = "--data arguments must contain only digits";
                    return default!;
                }

                if (tokenCounter == MarkTokenNumber)
                {
                    if (int.TryParse(token.Value, out var tokenValue))
                    {
                        if (tokenValue < 1)
                        {
                            argumentResult.ErrorMessage = "--data arguments must be greater than 0";
                            return default!;
                        }

                        attendance.Mark = tokenValue;

                        continue;
                    }

                    argumentResult.ErrorMessage = "--data arguments must contain only digits";
                    return default!;
                }
            }

            return attendance;
        }
    }
}
