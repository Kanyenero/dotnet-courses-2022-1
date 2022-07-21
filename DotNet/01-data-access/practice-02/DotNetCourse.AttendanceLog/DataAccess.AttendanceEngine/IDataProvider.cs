namespace DotNetCourse.AttendanceLog.DataAccess.AttendanceEngine
{
    public interface IDataProvider
    {
        int Attend(int? studentId, int? lectureId, int? mark);
        int Attend(Entities.Student student, Entities.Lecture lecture, int? mark);
    }
}