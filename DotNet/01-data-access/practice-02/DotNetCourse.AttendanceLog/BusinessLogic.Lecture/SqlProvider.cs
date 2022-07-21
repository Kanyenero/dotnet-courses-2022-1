namespace DotNetCourse.AttendanceLog.BusinessLogic.Lecture
{
    public class SqlProvider : IDataProvider
    {
        private readonly DataAccess.LectureEngine.IDataProvider provider;

        public SqlProvider(DataAccess.LectureEngine.IDataProvider provider)
        {
            this.provider = provider;
        }

        public int Add(string topic, DateTime date)
        {
            return provider.Add(topic, date);
        }

        public int Add(Entities.Lecture lecture)
        {
            return provider.Add(lecture);
        }
    }
}