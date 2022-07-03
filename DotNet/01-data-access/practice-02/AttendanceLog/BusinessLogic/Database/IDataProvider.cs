using AttendanceLog.Common.Entities;

namespace AttendanceLog.BusinessLogic.Database
{
    public interface IDataProvider
    {
        bool Init();
        IEnumerable<Attendance> GetReport();
    }
}
