namespace DotNetCourse.AttendanceLog.BusinessLogic.Database
{
    public class SqlProvider : IDataProvider
    {
        private readonly DataAccess.DatabaseEngine.IDataProvider provider;

        public SqlProvider(DataAccess.DatabaseEngine.IDataProvider provider)
        {
            this.provider = provider;
        }

        public bool Init()
        {
            return provider.Init();
        }

        public IEnumerable<Entities.Attendance> GetReport()
        {
            return provider.GetReport();
        }
    }
}