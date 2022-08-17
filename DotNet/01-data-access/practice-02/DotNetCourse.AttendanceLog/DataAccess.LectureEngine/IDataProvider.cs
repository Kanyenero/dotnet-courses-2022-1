using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.DataAccess.LectureEngine
{
    public interface IDataProvider
    {
        int Add(string course, string topic, DateTime date);

        Lecture Get(Index<int> id);

        Lecture Get(string course, string topic, DateTime date);

        int Update(Index<int> id, string course, string topic, DateTime date);

        int Delete(Index<int> id);

        int Delete(string course, string topic, DateTime date);

        IEnumerable<Lecture> GetAll();
    }
}