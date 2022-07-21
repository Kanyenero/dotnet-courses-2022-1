using Microsoft.EntityFrameworkCore;
using DotNetCourse.AttendanceLog.Entities;

namespace DotNetCourse.AttendanceLog.DataAccess.AttendanceEngine
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

        public int Attend(int? studentId, int? lectureId, int? mark)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var attendance = new Attendance(studentId, lectureId, mark);

                db.Attendance.Add(attendance);
                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public int Attend(Student student, Lecture lecture, int? mark)
        {
            return Attend(student.Id, lecture.Id, mark);
        }
    }
}
