using Microsoft.EntityFrameworkCore;
using AttendanceLog.Common.Entities;

namespace AttendanceLog.DataAccess.DatabaseEngine
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

        public bool Init()
        {
            bool executedWithSuccess = false;

            using (var db = new AttendanceLogContext(_options))
            {
                try
                {
                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    executedWithSuccess = true;
                }
                catch(Exception)
                {
                    executedWithSuccess = false;
                }
            }

            return executedWithSuccess;
        }

        public IEnumerable<Attendance> GetReport()
        {
            var attendances = new List<Attendance>();

            using (var db = new AttendanceLogContext(_options))
            {
                try
                {
                    var studentAttendance =
                        db.Students.Join(
                            db.Attendance,
                            s => s.Id,
                            a => a.StudentId,
                            (s, a) => new
                            {
                                LectureId = a.LectureId,
                                StudentId = a.StudentId,
                                StudentFirstName = s.FirstName,
                                StudentMiddleName = s.MiddleName,
                                StudentLastName = s.LastName,
                                Mark = a.Mark
                            });

                    var lectureStudentAttendance =
                        db.Lectures.Join(
                            studentAttendance,
                            l => l.Id,
                            sa => sa.LectureId,
                            (l, sa) => new Attendance
                            (
                                l.Id,
                                l.Date,
                                l.Topic,
                                sa.StudentId,
                                sa.StudentFirstName,
                                sa.StudentMiddleName,
                                sa.StudentLastName,
                                sa.Mark
                            ));

                    attendances = lectureStudentAttendance.ToList();
                }
                catch (Exception)
                {
                }
            }

            return attendances;
        }
    }
}