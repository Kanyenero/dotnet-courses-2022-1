using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.DataAccess.StudentEngine
{
    public interface IDataProvider
    {
        int Add(string firstName, string lastName, string uniqueLogin);

        Student? Get(int id);

        Student? Get(string firstName, string lastName, string uniqueLogin);

        int Update(int id, string firstName, string lastName, string uniqueLogin);

        int Delete(int id);

        int Delete(string firstName, string lastName, string uniqueLogin);

        IEnumerable<Student> GetAll();
    }
}
