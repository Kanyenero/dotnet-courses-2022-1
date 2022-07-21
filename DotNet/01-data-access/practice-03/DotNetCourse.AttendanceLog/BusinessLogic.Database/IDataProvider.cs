namespace DotNetCourse.AttendanceLog.BusinessLogic.Database
{
    public interface IDataProvider
    {
        bool Init();
        IEnumerable<Entities.Attendance> GetReport();
    }
}
