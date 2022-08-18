using Microsoft.EntityFrameworkCore;
using DotNetCourse.AttendanceLog.Models;

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

        public int Add(string firstName, string lastName, string uniqueLogin)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var modelToAdd = new Student(firstName, lastName, uniqueLogin);

                db.Students.Add(modelToAdd);

                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public Student? Get(int id)
        {
            var modelToGet = new Student();

            using (var db = new AttendanceLogContext(_options))
            {
                modelToGet = db.Students
                    .SingleOrDefault(model => model.Id == id);
            }

            return modelToGet;
        }

        public Student? Get(string firstName, string lastName, string uniqueLogin)
        {
            var modelToGet = new Student();

            using (var db = new AttendanceLogContext(_options))
            {
                modelToGet = db.Students
                    .SingleOrDefault(model => 
                        model.FirstName == firstName && 
                        model.LastName == lastName && 
                        model.UniqueLogin == uniqueLogin);
            }

            return modelToGet;
        }

        public int Update(int id, string firstName, string lastName, string uniqueLogin)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var modelToUpdate = db.Students
                    .SingleOrDefault(model => model.Id == id);

                if (modelToUpdate == null)
                    return rowsAffected;

                modelToUpdate.FirstName = firstName;
                modelToUpdate.LastName = lastName;
                modelToUpdate.UniqueLogin = uniqueLogin;

                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public int Delete(int id)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var modelToRemove = db.Students
                    .SingleOrDefault(model => model.Id == id);

                if (modelToRemove == null)
                    return rowsAffected;

                db.Students.Remove(modelToRemove);

                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public int Delete(string firstName, string lastName, string uniqueLogin)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var modelToRemove = db.Students
                    .SingleOrDefault(model => 
                        model.FirstName == firstName && 
                        model.LastName == lastName && 
                        model.UniqueLogin == uniqueLogin);

                if (modelToRemove == null)
                    return rowsAffected;

                db.Students.Remove(modelToRemove);

                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public IEnumerable<Student> GetAll()
        {
            var modelsToGet = new List<Student>();

            using (var db = new AttendanceLogContext(_options))
            {
                modelsToGet = db.Students.ToList();
            }

            return modelsToGet;
        }
    }
}
