using AttendanceLog.Common.Entities;

namespace AttendanceLog.DataAccess.StudentEngine
{
    public interface IDataProvider
    {
        int Add(string firstName, string? middleName, string lastName, string passportSeriesAndNumber);
        int Add(Student student);
    }
}
