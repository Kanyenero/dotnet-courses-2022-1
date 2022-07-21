using DotNetCourse.AttendanceLog.Entities;

namespace DotNetCourse.AttendanceLog.DataAccess.DatabaseEngine
{
    public interface IDataProvider
    {
        bool Init();
        IEnumerable<Attendance> GetReport();
    }
}
