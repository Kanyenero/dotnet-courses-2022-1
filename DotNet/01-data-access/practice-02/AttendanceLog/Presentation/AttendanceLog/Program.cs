using System.Configuration;

namespace AttendanceLog.Presentation.UserInterface
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            var studentEngine = new DataAccess.StudentEngine.SqlProvider(connectionString);
            var lectureEngine = new DataAccess.LectureEngine.SqlProvider(connectionString);
            var attendanceEngine = new DataAccess.AttendanceEngine.SqlProvider(connectionString);
            var databaseEngine = new DataAccess.DatabaseEngine.SqlProvider(connectionString);

            BusinessLogic.Student.IDataProvider studentLogic = new BusinessLogic.Student.SqlProvider(studentEngine);
            BusinessLogic.Lecture.IDataProvider lectureLogic = new BusinessLogic.Lecture.SqlProvider(lectureEngine);
            BusinessLogic.Attendance.IDataProvider attendanceLogic = new BusinessLogic.Attendance.SqlProvider(attendanceEngine);
            BusinessLogic.Database.IDataProvider databaseLogic = new BusinessLogic.Database.SqlProvider(databaseEngine);

            var commandLineHandler = new CommandLineParsing.Handler(
                studentLogic,
                lectureLogic,
                attendanceLogic,
                databaseLogic);

            commandLineHandler.CreateCommandTree();
            commandLineHandler.RunCommand(args);
        }
    }
}
