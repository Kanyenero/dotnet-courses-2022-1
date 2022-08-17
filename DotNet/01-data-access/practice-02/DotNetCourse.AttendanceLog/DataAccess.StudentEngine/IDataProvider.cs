using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.DataAccess.StudentEngine
{
    public interface IDataProvider
    {
        int Add(string firstName, string lastName, string uniqueLogin);

        Student Get(Index<int> id);

        Student Get(string firstName, string lastName, string uniqueLogin);

        int Update(Index<int> id, string firstName, string lastName, string uniqueLogin);

        int Delete(Index<int> id);

        int Delete(string firstName, string lastName, string uniqueLogin);

        IEnumerable<Student> GetAll();
    }
}
