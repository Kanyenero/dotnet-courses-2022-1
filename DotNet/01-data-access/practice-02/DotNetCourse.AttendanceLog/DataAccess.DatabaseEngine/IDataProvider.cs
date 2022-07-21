namespace DotNetCourse.AttendanceLog.DataAccess.DatabaseEngine
{
    public interface IDataProvider
    {
        bool Init();
        IEnumerable<Entities.Attendance> GetReport();
    }
}
