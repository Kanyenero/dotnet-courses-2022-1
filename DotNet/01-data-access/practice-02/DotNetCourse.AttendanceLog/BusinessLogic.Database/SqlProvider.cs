namespace DotNetCourse.AttendanceLog.BusinessLogic.Database
{
    public class SqlProvider : IDataProvider
    {
        private DataAccess.DatabaseEngine.IDataProvider Provider { get; set; }

        public SqlProvider(DataAccess.DatabaseEngine.IDataProvider provider)
        {
            Provider = provider;
        }

        public bool Init()
        {
            return Provider.Init();
        }
    }
}