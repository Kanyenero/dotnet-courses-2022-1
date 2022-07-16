using AttendanceLog.Common.Entities;

namespace AttendanceLog.BusinessLogic.Attendance
{
    public interface IDataProvider
    {
        int Attend(int? studentId, int? lectureId, int? mark);
        int Attend(Student student, Lecture lecture, int? mark);
        int Attend(Common.Entities.Attendance attendance);
    }
}
