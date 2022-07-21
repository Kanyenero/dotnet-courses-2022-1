namespace DotNetCourse.AttendanceLog.BusinessLogic.Lecture
{
    public interface IDataProvider
    {
        int Add(string topic, DateTime date);
        int Add(Entities.Lecture lecture);
    }
}
