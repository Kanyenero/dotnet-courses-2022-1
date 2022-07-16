using System.Configuration;

namespace AttendanceLog
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            DataAccess.StudentEngine.IDataProvider studentEngine = new DataAccess.StudentEngine.SqlProvider(connectionString);
            DataAccess.LectureEngine.IDataProvider lectureEngine = new DataAccess.LectureEngine.SqlProvider(connectionString);
            DataAccess.AttendanceEngine.IDataProvider attendanceEngine = new DataAccess.AttendanceEngine.SqlProvider(connectionString);
            DataAccess.DatabaseEngine.IDataProvider databaseEngine = new DataAccess.DatabaseEngine.SqlProvider(connectionString);

            BusinessLogic.Student.IDataProvider studentLogic = new BusinessLogic.Student.SqlProvider(studentEngine);
            BusinessLogic.Lecture.IDataProvider lectureLogic = new BusinessLogic.Lecture.SqlProvider(lectureEngine);
            BusinessLogic.Attendance.IDataProvider attendanceLogic = new BusinessLogic.Attendance.SqlProvider(attendanceEngine);
            BusinessLogic.Database.IDataProvider databaseLogic = new BusinessLogic.Database.SqlProvider(databaseEngine);

            var commandLineHandler = new Util.CommandLineParsing.Handler(
                studentLogic,
                lectureLogic,
                attendanceLogic,
                databaseLogic);

            commandLineHandler.CreateCommandTree();
            commandLineHandler.RunCommand(args);
        }
    }
}
