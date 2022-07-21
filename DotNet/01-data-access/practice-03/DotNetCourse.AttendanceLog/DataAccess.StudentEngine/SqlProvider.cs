using Microsoft.EntityFrameworkCore;
using DotNetCourse.AttendanceLog.Entities;

namespace DotNetCourse.AttendanceLog.DataAccess.StudentEngine
{
    public class SqlProvider : IDataProvider
    {
        private readonly DbContextOptions<AttendanceLogContext> _options;

        public SqlProvider(string connectionString)
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<AttendanceLogContext>();

            _options = dbContextOptionsBuilder
                .UseSqlServer(connectionString)
                .Options;
        }

        public int Add(string firstName, string? middleName, string lastName, string passportSeriesAndNumber)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var student = new Student(firstName, middleName, lastName, passportSeriesAndNumber);

                db.Students.Add(student);
                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public int Add(Student student)
        {
            return Add(student.FirstName, student.MiddleName, student.LastName, student.PassportSeriesAndNumber);
        }
    }
}
