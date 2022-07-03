using AttendanceLog.Common.Entities;

namespace AttendanceLog.DataAccess.DatabaseEngine
{
    public interface IDataProvider
    {
        bool Init();
        IEnumerable<Attendance> GetReport();
    }
}
