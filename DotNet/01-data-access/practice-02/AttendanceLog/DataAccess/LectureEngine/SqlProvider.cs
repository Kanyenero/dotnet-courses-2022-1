using AttendanceLog.Common.Entities;
using System.Data.SqlClient;

namespace AttendanceLog.DataAccess.LectureEngine
{
    public class SqlProvider : IDataProvider
    {
        public string ConnectionString { get; private set; } = default!;

        public SqlProvider(string connectionString) => ConnectionString = connectionString;

        private readonly string addExpression =
            "INSERT INTO [Lectures]" +
                "(Topic, Date)" +
            "OUTPUT [Inserted].[Id]" +
            "VALUES (@lecture_topic, @lecture_date)";

        public int Add(string topic, DateTime date)
        {
            int addedLectureId = -1;

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var command = new SqlCommand(addExpression, connection);

                var lectureTopicParam = new SqlParameter("@lecture_topic", topic);
                var lectureDateParam = new SqlParameter("@lecture_date", date);

                command.Parameters.Add(lectureTopicParam);
                command.Parameters.Add(lectureDateParam);

                object returnedData = default!;

                try
                {
                    returnedData = command.ExecuteScalar();
                }
                catch (SqlException)
                {
                }

                if (returnedData != null)
                    addedLectureId = (int)returnedData;
            }

            return addedLectureId;
		}

        public int Add(Lecture lecture)
        {
            return Add(lecture.Topic, lecture.Date);
        }
    }
}
