using Microsoft.EntityFrameworkCore;

namespace DotNetCourse.AttendanceLog.DataAccess.DatabaseEngine
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
                catch (Exception)
                {
                    executedWithSuccess = false;
                }
            }

            return executedWithSuccess;
        }
    }
}