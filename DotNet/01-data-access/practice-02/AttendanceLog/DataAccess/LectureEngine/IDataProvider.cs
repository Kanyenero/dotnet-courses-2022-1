using AttendanceLog.Common.Entities;

namespace AttendanceLog.DataAccess.LectureEngine
{
    public interface IDataProvider
    {
        int Add(string topic, DateTime date);
        int Add(Lecture lecture);
    }
}