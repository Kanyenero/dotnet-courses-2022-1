using Microsoft.EntityFrameworkCore;
using DotNetCourse.AttendanceLog.Entities;

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

        public int Add(string topic, DateTime date)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var lecture = new Lecture(topic, date);

                db.Lectures.Add(lecture);
                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
		}

        public int Add(Lecture lecture)
        {
            return Add(lecture.Topic, lecture.Date);
        }
    }
}
