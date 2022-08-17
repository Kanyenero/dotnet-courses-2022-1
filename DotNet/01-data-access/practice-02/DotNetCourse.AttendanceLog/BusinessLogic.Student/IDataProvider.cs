using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.BusinessLogic.Student
{
    public interface IDataProvider
    {
        int Add(string firstName, string lastName, string uniqueLogin);

        Models.Student Get(Index<int> id);

        Models.Student Get(string firstName, string lastName, string uniqueLogin);

        int Update(Index<int> id, string firstName, string lastName, string uniqueLogin);

        int Delete(Index<int> id);

        int Delete(string firstName, string lastName, string uniqueLogin);

        IEnumerable<Models.Student> GetAll();
    }
}
