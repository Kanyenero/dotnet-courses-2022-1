using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.BusinessLogic.Lecture
{
    public interface IDataProvider
    {
        int Add(string course, string topic, DateTime date);

        Models.Lecture Get(Index<int> id);

        Models.Lecture Get(string course, string topic, DateTime date);

        int Update(Index<int> id, string course, string topic, DateTime date);

        int Delete(Index<int> id);

        int Delete(string course, string topic, DateTime date);

        IEnumerable<Models.Lecture> GetAll();
    }
}
