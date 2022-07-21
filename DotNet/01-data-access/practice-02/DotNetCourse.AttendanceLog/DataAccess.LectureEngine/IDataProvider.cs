namespace DotNetCourse.AttendanceLog.DataAccess.LectureEngine
{
    public interface IDataProvider
    {
        int Add(string topic, DateTime date);
        int Add(Entities.Lecture lecture);
    }
}