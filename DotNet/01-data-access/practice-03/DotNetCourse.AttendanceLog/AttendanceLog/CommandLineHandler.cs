﻿using System.CommandLine;
using System.CommandLine.Parsing;
using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog
{
    public class CommandLineHandler
    {
        private readonly RootCommand rootCommand;

        public CommandLineHandler()
        {
            rootCommand = new RootCommand(
                "Using the commands below you can manage the AttendanceLog database " +
                "(CRUD students/lectures/attendancesand and get the corresponding tables)");
        }

        public void RunCommand(string[] args)
        {
            rootCommand.Invoke(args);
        }

        public RootCommand CreateCommandTree()
        {
            var initCommand = CreateInitCommandBranch();
            var studentCommand = CreateStudentCommandBranch();
            var lectureCommand = CreateLectureCommandBranch();
            var attendCommand = CreateAttendanceCommandBranch();

            rootCommand.AddCommand(initCommand);
            rootCommand.AddCommand(studentCommand);
            rootCommand.AddCommand(lectureCommand);
            rootCommand.AddCommand(attendCommand);

            return rootCommand;
        }

        public event EventHandler InitDatabaseEvent = default!;

        private Command CreateInitCommandBranch()
        {
            var initCommand = new Command(
                "init", 
                "Provides the ability to initialize database with tables and stored procedures");

            initCommand.SetHandler(() =>
            {
                InitDatabaseEvent?.Invoke(this, EventArgs.Empty);
            });

            return initCommand;
        }

        public event EventHandler<ModelEventArgs<Student>>? AddStudentEvent;
        public event EventHandler<ModelEventArgs<Student>>? GetStudentEvent;
        public event EventHandler<ModelEventArgs<Student>>? UpdateStudentEvent;
        public event EventHandler<ModelEventArgs<Student>>? DeleteStudentEvent;
        public event EventHandler<ModelEventArgs<Student>>? GetAllStudentEvent;

        private Command CreateStudentCommandBranch()
        {
            var studentCommand = new Command(
                "student",
                "Provides the ability to CRUD students");

            var idOption = CreateSingleTokenOption<int>(name: "Id", isRequired: false, description: "");
            var firstNameOption = CreateSingleTokenOption(name: "FirstName", isRequired: false, description: "");
            var lastNameOption = CreateSingleTokenOption(name: "LastName", isRequired: false, description: "");
            var uniqueLoginOption = CreateSingleTokenOption(name: "UniqueLogin", isRequired: false, description: "");

            var idRequiredOption = CreateSingleTokenOption<int>(name: "Id", isRequired: true, description: "");
            var firstNameRequiredOption = CreateSingleTokenOption(name: "FirstName", isRequired: true, description: "");
            var lastNameRequiredOption = CreateSingleTokenOption(name: "LastName", isRequired: true, description: "");
            var uniqueLoginRequiredOption = CreateSingleTokenOption(name: "UniqueLogin", isRequired: true, description: "");

            var addCommand = new Command(
                "add",
                "");

            addCommand.AddOption(firstNameRequiredOption);
            addCommand.AddOption(lastNameRequiredOption);
            addCommand.AddOption(uniqueLoginRequiredOption);

            addCommand.SetHandler((firstName, lastName, uniqueLogin) => 
            {
                ModelEventArgs<Student> e;

                if (firstName != null && lastName != null && uniqueLogin != null)
                {
                    e = new ModelEventArgs<Student>(new Student(firstName, lastName, uniqueLogin));
                }
                else
                {
                    return;
                }

                AddStudentEvent?.Invoke(this, e);
            }, 
            firstNameRequiredOption,
            lastNameRequiredOption,
            uniqueLoginRequiredOption);

            var getCommand = new Command(
                "get",
                "");

            getCommand.AddOption(idOption);
            getCommand.AddOption(firstNameOption);
            getCommand.AddOption(lastNameOption);
            getCommand.AddOption(uniqueLoginOption);

            getCommand.SetHandler((id, firstName, lastName, uniqueLogin) =>
            {
                ModelEventArgs<Student> e;

                if (id > 0)
                {
                    e = new ModelEventArgs<Student>(new Identifier<int>(id));
                }
                else if (firstName != null && lastName != null && uniqueLogin != null)
                {
                    e = new ModelEventArgs<Student>(new Student(firstName, lastName, uniqueLogin));
                }
                else
                {
                    return;
                }

                GetStudentEvent?.Invoke(this, e);
            },
            idOption,
            firstNameOption,
            lastNameOption,
            uniqueLoginOption);

            var updateCommand = new Command(
                "update",
                "");

            updateCommand.AddOption(idRequiredOption);
            updateCommand.AddOption(firstNameRequiredOption);
            updateCommand.AddOption(lastNameRequiredOption);
            updateCommand.AddOption(uniqueLoginRequiredOption);

            updateCommand.SetHandler((id, firstName, lastName, uniqueLogin) =>
            {
                ModelEventArgs<Student> e;

                if (id > 0 && firstName != null && lastName != null && uniqueLogin != null)
                {
                    e = new ModelEventArgs<Student>(new Student(id, firstName, lastName, uniqueLogin));
                }
                else
                {
                    return;
                }

                UpdateStudentEvent?.Invoke(this, e);
            },
            idRequiredOption,
            firstNameRequiredOption,
            lastNameRequiredOption,
            uniqueLoginRequiredOption);

            var deleteCommand = new Command(
                "delete",
                "");

            deleteCommand.AddOption(idOption);
            deleteCommand.AddOption(firstNameOption);
            deleteCommand.AddOption(lastNameOption);
            deleteCommand.AddOption(uniqueLoginOption);

            deleteCommand.SetHandler((id, firstName, lastName, uniqueLogin) =>
            {
                ModelEventArgs<Student> e;

                if (id > 0)
                {
                    e = new ModelEventArgs<Student>(new Identifier<int>(id));
                }
                else if (firstName != null && lastName != null && uniqueLogin != null)
                {
                    e = new ModelEventArgs<Student>(new Student(firstName, lastName, uniqueLogin));
                }
                else
                {
                    return;
                }

                DeleteStudentEvent?.Invoke(this, e);
            },
            idOption,
            firstNameOption,
            lastNameOption,
            uniqueLoginOption);

            var getAllCommand = new Command(
                "getall",
                "");

            getAllCommand.SetHandler(() =>
            {
                GetAllStudentEvent?.Invoke(this, ModelEventArgs<Student>.Empty);
            });

            studentCommand.AddCommand(addCommand);
            studentCommand.AddCommand(getCommand);
            studentCommand.AddCommand(updateCommand);
            studentCommand.AddCommand(deleteCommand);
            studentCommand.AddCommand(getAllCommand);

            return studentCommand;
        }

        public event EventHandler<ModelEventArgs<Lecture>>? AddLectureEvent;
        public event EventHandler<ModelEventArgs<Lecture>>? GetLectureEvent;
        public event EventHandler<ModelEventArgs<Lecture>>? UpdateLectureEvent;
        public event EventHandler<ModelEventArgs<Lecture>>? DeleteLectureEvent;
        public event EventHandler<ModelEventArgs<Lecture>>? GetAllLectureEvent;

        private Command CreateLectureCommandBranch()
        {
            var lectureCommand = new Command(
                "lecture",
                "Provides the ability to initialize database with tables and stored procedures");

            var idOption = CreateSingleTokenOption<int>(name: "Id", isRequired: false, description: "");
            var dateOption = CreateSingleTokenOption<DateTime>(name: "Date", isRequired: false, description: "");
            var courseOption = CreateSingleTokenOption(name: "Course", isRequired: false, description: "");
            var topicOption = CreateSingleTokenOption(name: "Topic", isRequired: false, description: "");

            var idRequiredOption = CreateSingleTokenOption<int>(name: "Id", isRequired: true, description: "");
            var dateRequiredOption = CreateSingleTokenOption<DateTime>(name: "Date", isRequired: true, description: "");
            var courseRequiredOption = CreateSingleTokenOption(name: "Course", isRequired: true, description: "");
            var topicRequiredOption = CreateSingleTokenOption(name: "Topic", isRequired: true, description: "");

            var addCommand = new Command(
                "add",
                "");

            addCommand.AddOption(dateRequiredOption);
            addCommand.AddOption(courseRequiredOption);
            addCommand.AddOption(topicRequiredOption);

            addCommand.SetHandler((date, course, topic) =>
            {
                if (date < new DateTime(1900, 1, 1) || date > DateTime.Now)
                {
                    Console.WriteLine("Invalid date! Lecture date cannot be less than 1900.01.01 and greater than current date.");

                    return;
                }

                ModelEventArgs<Lecture> e;

                if (course != null && topic != null)
                {
                    e = new ModelEventArgs<Lecture>(new Lecture(date, course, topic));
                }
                else
                {
                    return;
                }

                AddLectureEvent?.Invoke(this, e);
            },
            dateRequiredOption,
            courseRequiredOption,
            topicRequiredOption);

            var getCommand = new Command(
                "get",
                "");

            getCommand.AddOption(idOption);
            getCommand.AddOption(dateOption);
            getCommand.AddOption(courseOption);
            getCommand.AddOption(topicOption);

            getCommand.SetHandler((id, date, course, topic) =>
            {
                ModelEventArgs<Lecture> e;

                if (id > 0)
                {
                    e = new ModelEventArgs<Lecture>(new Identifier<int>(id));
                }
                else if (course != null && topic != null)
                {
                    if (date < new DateTime(1900, 1, 1) || date > DateTime.Now)
                    {
                        Console.WriteLine("Invalid date! Lecture date cannot be less than 1900.01.01 and greater than current date.");

                        return;
                    }

                    e = new ModelEventArgs<Lecture>(new Lecture(date, course, topic));
                }
                else
                {
                    return;
                }

                GetLectureEvent?.Invoke(this, e);
            },
            idOption,
            dateOption,
            courseOption,
            topicOption);

            var updateCommand = new Command(
                "update",
                "");

            updateCommand.AddOption(idRequiredOption);
            updateCommand.AddOption(dateRequiredOption);
            updateCommand.AddOption(courseRequiredOption);
            updateCommand.AddOption(topicRequiredOption);

            updateCommand.SetHandler((id, date, course, topic) => 
            {
                if (date < new DateTime(1900, 1, 1) || date > DateTime.Now)
                {
                    Console.WriteLine("Invalid date! Lecture date cannot be less than 1900.01.01 and greater than current date.");

                    return;
                }

                ModelEventArgs<Lecture> e;

                if (id > 0 && course != null && topic != null)
                {
                    e = new ModelEventArgs<Lecture>(new Lecture(id, date, course, topic));
                }
                else
                {
                    return;
                }

                UpdateLectureEvent?.Invoke(this, e);
            },
            idRequiredOption,
            dateRequiredOption,
            courseRequiredOption,
            topicRequiredOption);

            var deleteCommand = new Command(
                "delete",
                "");

            deleteCommand.AddOption(idOption);
            deleteCommand.AddOption(dateOption);
            deleteCommand.AddOption(courseOption);
            deleteCommand.AddOption(topicOption);

            deleteCommand.SetHandler((id, date, course, topic) =>
            {
                ModelEventArgs<Lecture> e;

                if (id > 0)
                {
                    e = new ModelEventArgs<Lecture>(new Identifier<int>(id));
                }
                else if (course != null && topic != null)
                {
                    if (date < new DateTime(1900, 1, 1) || date > DateTime.Now)
                    {
                        Console.WriteLine("Invalid date! Lecture date cannot be less than 1900.01.01 and greater than current date.");

                        return;
                    }

                    e = new ModelEventArgs<Lecture>(new Lecture(date, course, topic));
                }
                else
                {
                    return;
                }

                DeleteLectureEvent?.Invoke(this, e);
            },
            idOption,
            dateOption,
            courseOption,
            topicOption);

            var getAllCommand = new Command(
                "getall",
                "");

            getAllCommand.SetHandler(() => 
            {
                GetAllLectureEvent?.Invoke(this, ModelEventArgs<Lecture>.Empty);
            });

            lectureCommand.AddCommand(addCommand);
            lectureCommand.AddCommand(getCommand);
            lectureCommand.AddCommand(updateCommand);
            lectureCommand.AddCommand(deleteCommand);
            lectureCommand.AddCommand(getAllCommand);

            return lectureCommand;
        }

        public event EventHandler<ModelEventArgs<Attendance>>? AddAttendanceEvent;
        public event EventHandler<ModelEventArgs<Attendance>>? GetAttendanceEvent;
        public event EventHandler<ModelEventArgs<Attendance>>? DeleteAttendanceEvent;
        public event EventHandler<ModelEventArgs<Attendance>>? GetAllAttendanceEvent;

        private Command CreateAttendanceCommandBranch()
        {
            var attendanceCommand = new Command(
                "attendance",
                "Provides the ability to initialize database with tables and stored procedures");

            var lectureIdRequiredOption = CreateSingleTokenOption<int>(name: "LectureId", isRequired: true, description: "");
            var studentIdRequiredOption = CreateSingleTokenOption<int>(name: "StudentId", isRequired: true, description: "");
            var markOption = CreateSingleTokenOption<int>(name: "Mark", isRequired: false, description: "");

            var addCommand = new Command(
                "add",
                "");

            addCommand.AddOption(lectureIdRequiredOption);
            addCommand.AddOption(studentIdRequiredOption);
            addCommand.AddOption(markOption);

            addCommand.SetHandler((lectureId, studentId, mark) => 
            {
                if (lectureId == 0 || studentId == 0)
                    return;

                ModelEventArgs<Attendance> e;

                if (mark == 0)
                {
                    e = new ModelEventArgs<Attendance>(new Identifier<int, int>(lectureId, studentId));
                }
                else
                {
                    e = new ModelEventArgs<Attendance>(new Attendance(lectureId, studentId, mark));
                }

                AddAttendanceEvent?.Invoke(this, e);
            },
            lectureIdRequiredOption,
            studentIdRequiredOption,
            markOption);

            var getCommand = new Command(
                "get",
                "");

            getCommand.AddOption(lectureIdRequiredOption);
            getCommand.AddOption(studentIdRequiredOption);

            getCommand.SetHandler((lectureId, studentId) => 
            {
                if (lectureId == 0 || studentId == 0)
                    return;

                GetAttendanceEvent?.Invoke(this, new ModelEventArgs<Attendance>(new Identifier<int, int>(lectureId, studentId)));
            },
            lectureIdRequiredOption,
            studentIdRequiredOption);

            var deleteCommand = new Command(
                "delete",
                "");

            deleteCommand.AddOption(lectureIdRequiredOption);
            deleteCommand.AddOption(studentIdRequiredOption);

            deleteCommand.SetHandler((lectureId, studentId) => 
            {
                if (lectureId == 0 || studentId == 0)
                    return;

                DeleteAttendanceEvent?.Invoke(this, new ModelEventArgs<Attendance>(new Identifier<int, int>(lectureId, studentId)));
            },
            lectureIdRequiredOption,
            studentIdRequiredOption);

            var getAllCommand = new Command(
                "getall",
                "");

            getAllCommand.SetHandler(() =>
            {
                GetAllAttendanceEvent?.Invoke(this, ModelEventArgs<Attendance>.Empty);
            });

            attendanceCommand.AddCommand(addCommand);
            attendanceCommand.AddCommand(getCommand);
            attendanceCommand.AddCommand(deleteCommand);
            attendanceCommand.AddCommand(getAllCommand);

            return attendanceCommand;
        }

        private static Option<T> CreateSingleTokenOption<T>(
            string name, 
            bool isRequired = false, 
            string? description = null)
            where T : struct
        {
            var valueToReturnType = typeof(T);
            var valueToReturn = new T();

            var parseArgument = new ParseArgument<T>(parseArgumentResult =>
            {
                string? tokenValue = GetSingleTokenOptionValue(parseArgumentResult, name);

                var parseMethod = valueToReturnType.GetMethod("Parse", new[] { typeof(string) });

                if (parseMethod == null)
                    throw new Exception($"No provided method [Parse] on type '{valueToReturnType}'.");

                var parseMethodInvokeResult = parseMethod.Invoke(valueToReturn, new[] { tokenValue });

                if (parseMethodInvokeResult == null)
                {
                    parseArgumentResult.ErrorMessage = $"[{name}] Cannot parse argument. Format was invalid.";

                    return default;
                }

                if (parseMethodInvokeResult is T)
                    return (T)parseMethodInvokeResult;

                try
                {
                    return (T)Convert.ChangeType(parseMethodInvokeResult, typeof(T));
                }
                catch (InvalidCastException)
                {
                    throw;
                }
            });

            return new Option<T>(name, parseArgument, isDefault: false, description)
            {
                Arity = ArgumentArity.ExactlyOne,
                AllowMultipleArgumentsPerToken = false,
                IsRequired = isRequired
            };
        }

        private static Option<string?> CreateSingleTokenOption(
            string name,
            bool isRequired = false,
            string? description = null)
        {
            var parseArgument = new ParseArgument<string?>(parseArgumentResult =>
            {
                return GetSingleTokenOptionValue(parseArgumentResult, name);
            });

            return new Option<string?>(name, parseArgument, isDefault: false, description)
            {
                Arity = ArgumentArity.ExactlyOne,
                AllowMultipleArgumentsPerToken = false,
                IsRequired = isRequired
            };
        }

        private static string? GetSingleTokenOptionValue(ArgumentResult parseArgumentResult, string optionName)
        {
            if (parseArgumentResult.Tokens.Count == 0)
                return null;

            var token = parseArgumentResult.Tokens[0];

            if (string.IsNullOrWhiteSpace(token.Value))
            {
                parseArgumentResult.ErrorMessage = $"[{optionName}] Option argument was null or whitespace.";

                return null;
            }

            return token.Value;
        }
    }
}
