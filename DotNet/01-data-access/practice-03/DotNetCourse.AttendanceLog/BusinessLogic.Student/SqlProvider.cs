namespace DotNetCourse.AttendanceLog.BusinessLogic.Student
{
    public class SqlProvider : IDataProvider
    {
        private readonly DataAccess.StudentEngine.IDataProvider provider;

        public SqlProvider(DataAccess.StudentEngine.IDataProvider provider)
        {
            this.provider = provider;
        }

        public int Add(string firstName, string? middleName, string lastName, string passportSeriesAndNumber)
        {
            return provider.Add(firstName, middleName, lastName, passportSeriesAndNumber);
        }

        public int Add(Entities.Student student)
        {
            return provider.Add(student);
        }
    }
}
