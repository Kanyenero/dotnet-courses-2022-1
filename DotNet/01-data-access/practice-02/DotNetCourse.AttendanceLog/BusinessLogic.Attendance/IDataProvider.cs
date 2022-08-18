using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.BusinessLogic.Attendance
{
    public interface IDataProvider
    {
        int Add(int lectureId, int studentId, int? mark);

        Models.Attendance? Get(int lectureId, int studentId);

        int Delete(int lectureId, int studentId);

        IEnumerable<Models.Attendance> GetAll();
    }
}
