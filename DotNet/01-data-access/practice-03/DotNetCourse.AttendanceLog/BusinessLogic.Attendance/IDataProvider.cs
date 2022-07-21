namespace DotNetCourse.AttendanceLog.BusinessLogic.Attendance
{
    public interface IDataProvider
    {
        int Attend(int? studentId, int? lectureId, int? mark);
        int Attend(Entities.Student student, Entities.Lecture lecture, int? mark);
        int Attend(Entities.Attendance attendance);
    }
}
