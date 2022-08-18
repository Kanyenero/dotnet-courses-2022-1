using Microsoft.EntityFrameworkCore;
using DotNetCourse.AttendanceLog.Models;

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

        public int Add(int lectureId, int studentId, int? mark)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var modelToAdd = new Attendance(lectureId, studentId, mark);

                db.Attendances.Add(modelToAdd);

                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public Attendance? Get(int lectureId, int studentId)
        {
            var modelToGet = new Attendance();

            using (var db = new AttendanceLogContext(_options))
            {
                modelToGet = db.Attendances
                    .SingleOrDefault(model =>
                        model.LectureId == lectureId &&
                        model.StudentId == studentId);
            }

            return modelToGet;
        }

        public int Delete(int lectureId, int studentId)
        {
            int rowsAffected = 0;

            using (var db = new AttendanceLogContext(_options))
            {
                var modelToRemove = db.Attendances
                    .SingleOrDefault(model => 
                        model.LectureId == lectureId &&
                        model.StudentId == studentId);

                if (modelToRemove == null)
                    return rowsAffected;

                db.Attendances.Remove(modelToRemove);

                rowsAffected = db.SaveChanges();
            }

            return rowsAffected;
        }

        public IEnumerable<Attendance> GetAll()
        {
            var modelsToGet = new List<Attendance>();

            using (var db = new AttendanceLogContext(_options))
            {
                modelsToGet = db.Lectures
                    .Join(
                        db.Attendances,
                        l => l.Id,
                        a => a.LectureId,
                        (lecture, attendance) => new
                        {
                            attendance.LectureId,
                            lecture.Date,
                            lecture.Course,
                            lecture.Topic,
                            attendance.StudentId,
                            attendance.Mark
                        })
                    .Join(
                        db.Students,
                        la => la.StudentId,
                        s => s.Id,
                        (la, s) => new Attendance
                        {
                            LectureId = la.LectureId,
                            LectureDate = la.Date,
                            LectureCourse = la.Course,
                            LectureTopic = la.Topic,
                            StudentId = la.StudentId,
                            StudentUniqueLogin = s.UniqueLogin,
                            StudentFirstName = s.FirstName,
                            StudentLastName = s.LastName,
                            Mark = la.Mark
                        })
                    .ToList();
            }

            return modelsToGet;
        }
    }
}
