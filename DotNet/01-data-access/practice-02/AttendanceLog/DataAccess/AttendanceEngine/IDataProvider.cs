using AttendanceLog.Common.Entities;

namespace AttendanceLog.DataAccess.AttendanceEngine
{
    public interface IDataProvider
    {
        int Attend(int? studentId, int? lectureId, int? mark);
        int Attend(Student student, Lecture lecture, int? mark);
    }
}