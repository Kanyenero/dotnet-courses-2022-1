using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.DataAccess.LectureEngine
{
    public interface IDataProvider
    {
        int Add(string course, string topic, DateTime date);

        Lecture? Get(int id);

        Lecture? Get(string course, string topic, DateTime date);

        int Update(int id, string course, string topic, DateTime date);

        int Delete(int id);

        int Delete(string course, string topic, DateTime date);

        IEnumerable<Lecture> GetAll();
    }
}