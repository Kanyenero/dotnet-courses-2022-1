using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.BusinessLogic.Attendance
{
    public interface IDataProvider
    {
        int Add(Index<int, int> id, int? mark);

        Models.Attendance Get(Index<int, int> id);

        int Delete(Index<int, int> id);

        IEnumerable<Models.Attendance> GetAll();
    }
}
