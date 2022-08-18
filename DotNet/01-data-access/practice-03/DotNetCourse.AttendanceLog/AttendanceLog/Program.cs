using System.Configuration;
using DotNetCourse.AttendanceLog.Models;
using DotNetCourse.AttendanceLog.BusinessLogic;

namespace DotNetCourse.AttendanceLog
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            DataAccess.DatabaseEngine.IDataProvider databaseEngine = new DataAccess.DatabaseEngine.SqlProvider(connectionString);
            DataAccess.StudentEngine.IDataProvider studentEngine = new DataAccess.StudentEngine.SqlProvider(connectionString);
            DataAccess.LectureEngine.IDataProvider lectureEngine = new DataAccess.LectureEngine.SqlProvider(connectionString);
            DataAccess.AttendanceEngine.IDataProvider attendanceEngine = new DataAccess.AttendanceEngine.SqlProvider(connectionString);

            BusinessLogic.Database.IDataProvider databaseLogic = new BusinessLogic.Database.SqlProvider(databaseEngine);
            IInvocableProvider<Student> studentLogic = new BusinessLogic.Student.SqlProvider(studentEngine);
            IInvocableProvider<Lecture> lectureLogic = new BusinessLogic.Lecture.SqlProvider(lectureEngine);
            IInvocableProvider<Attendance> attendanceLogic = new BusinessLogic.Attendance.SqlProvider(attendanceEngine);

            var commandLineHandler = new CommandLineHandler();

            commandLineHandler.InitDatabaseEvent += delegate (object? s, EventArgs e)
            {
                databaseLogic.Init();
            };

            commandLineHandler.AddStudentEvent += studentLogic.OnAdd;
            commandLineHandler.GetStudentEvent += studentLogic.OnGet;
            commandLineHandler.UpdateStudentEvent += studentLogic.OnUpdate;
            commandLineHandler.DeleteStudentEvent += studentLogic.OnDelete;
            commandLineHandler.GetAllStudentEvent += studentLogic.OnGetAll;

            commandLineHandler.AddLectureEvent += lectureLogic.OnAdd;
            commandLineHandler.GetLectureEvent += lectureLogic.OnGet;
            commandLineHandler.UpdateLectureEvent += lectureLogic.OnUpdate;
            commandLineHandler.DeleteLectureEvent += lectureLogic.OnDelete;
            commandLineHandler.GetAllLectureEvent += lectureLogic.OnGetAll;

            commandLineHandler.AddAttendanceEvent += attendanceLogic.OnAdd;
            commandLineHandler.GetAttendanceEvent += attendanceLogic.OnGet;
            commandLineHandler.DeleteAttendanceEvent += attendanceLogic.OnDelete;
            commandLineHandler.GetAllAttendanceEvent += attendanceLogic.OnGetAll;

            commandLineHandler.CreateCommandTree();
            commandLineHandler.RunCommand(args);
        }
    }
}
