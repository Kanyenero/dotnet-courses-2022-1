using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.DataAccess.AttendanceEngine
{
    public interface IDataProvider
    {
        int Add(Index<int, int> id, int? mark);

        Attendance Get(Index<int, int> id);

        int Delete(Index<int, int> id);

        IEnumerable<Attendance> GetAll();
    }
}