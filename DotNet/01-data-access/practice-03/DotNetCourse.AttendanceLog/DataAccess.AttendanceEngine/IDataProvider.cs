using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.DataAccess.AttendanceEngine
{
    public interface IDataProvider
    {
        int Add(int lectureId, int studentId, int? mark);

        Attendance? Get(int lectureId, int studentId);

        int Delete(int lectureId, int studentId);

        IEnumerable<Attendance> GetAll();
    }
}