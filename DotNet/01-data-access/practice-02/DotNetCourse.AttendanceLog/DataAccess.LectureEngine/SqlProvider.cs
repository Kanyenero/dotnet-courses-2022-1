using Microsoft.EntityFrameworkCore;
using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.DataAccess.LectureEngine
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

        public int Add(string course, string topic, DateTime date)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var modelToAdd = new Lecture(date, course, topic);

                db.Lectures.Add(modelToAdd);

                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public Lecture? Get(int id)
        {
            var modelToGet = new Lecture();

            using (var db = new AttendanceLogContext(_options))
            {
                modelToGet = db.Lectures
                    .SingleOrDefault(model => model.Id == id);
            }

            return modelToGet;
        }

        public Lecture? Get(string course, string topic, DateTime date)
        {
            var modelToGet = new Lecture();

            using (var db = new AttendanceLogContext(_options))
            {
                modelToGet = db.Lectures
                    .SingleOrDefault(model => 
                        model.Course == course && 
                        model.Topic == topic && 
                        model.Date == date);
            }

            return modelToGet;
        }

        public int Update(int id, string course, string topic, DateTime date)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var modelToUpdate = db.Lectures
                    .SingleOrDefault(model => model.Id == id);

                if (modelToUpdate == null)
                    return rowsAffected;

                modelToUpdate.Course = course;
                modelToUpdate.Topic = topic;
                modelToUpdate.Date = date;

                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public int Delete(int id)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var modelToRemove = db.Lectures
                    .SingleOrDefault(model => model.Id == id);

                if (modelToRemove == null)
                    return rowsAffected;

                db.Lectures.Remove(modelToRemove);

                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public int Delete(string course, string topic, DateTime date)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var modelToRemove = db.Lectures
                    .SingleOrDefault(model =>
                        model.Course == course &&
                        model.Topic == topic &&
                        model.Date == date);

                if (modelToRemove == null)
                    return rowsAffected;

                db.Lectures.Remove(modelToRemove);

                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public IEnumerable<Lecture> GetAll()
        {
            var modelsToGet = new List<Lecture>();

            using (var db = new AttendanceLogContext(_options))
            {
                modelsToGet = db.Lectures.ToList();
            }

            return modelsToGet;
        }
    }
}
