using DotNetCourse.AttendanceLog.Models;
using System.Data.SqlClient;

namespace DotNetCourse.AttendanceLog.DataAccess.LectureEngine
{
    public class SqlProvider : IDataProvider
    {
        public string ConnectionString { get; private set; }

        public SqlProvider(string connectionString) => ConnectionString = connectionString;

        public int Add(string course, string topic, DateTime date)
        {
            int rowsAffected = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                string addExpression =
                    "INSERT INTO Lectures" +
                        "(Course, Topic, Date)" +
                    "VALUES (@lectureCourse, @lectureTopic, @lectureDate)";

                var command = new SqlCommand(addExpression, connection);

                var courseParam = new SqlParameter("@lectureCourse", course);
                var topicParam = new SqlParameter("@lectureTopic", topic);
                var dateParam = new SqlParameter("@lectureDate", date);

                command.Parameters.Add(courseParam);
                command.Parameters.Add(topicParam);
                command.Parameters.Add(dateParam);

                connection.Open();

                try
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                }
            }

            return rowsAffected;
		}

        public Lecture Get(Index<int> id)
        {
            var lecture = new Lecture();

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "SELECT\r\n\t" +
                        "LectureID,\r\n\t" +
                        "Course,\r\n\t" +
                        "Topic,\r\n\t" +
                        "Date\r\n" +
                    "FROM\r\n\t" +
                        "Lectures\r\n" +
                    "WHERE\r\n\t" +
                        "LectureID = @lectureId";

                var command = new SqlCommand(sqlExpression, connection);

                var idParam = new SqlParameter("@lectureId", id.Value);

                command.Parameters.Add(idParam);

                connection.Open();

                try
                {
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int idColumnIndex       = 0;
                        int courseColumnIndex   = 1;
                        int topicColumnIndex    = 2;
                        int dateColumnIndex     = 3;

                        while (reader.Read())
                        {
                            lecture.Id.Value = (int)reader.GetValue(idColumnIndex);
                            lecture.Course = (string)reader.GetValue(courseColumnIndex);
                            lecture.Topic = (string)reader.GetValue(topicColumnIndex);
                            lecture.Date = (DateTime)reader.GetValue(dateColumnIndex);
                        }
                    }
                }
                catch (SqlException)
                {
                }
            }

            return lecture;
        }

        public Lecture Get(string course, string topic, DateTime date)
        {
            var lecture = new Lecture();

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "SELECT\r\n\t" +
                        "LectureID,\r\n\t" +
                        "Course,\r\n\t" +
                        "Topic,\r\n\t" +
                        "Date\r\n" +
                    "FROM\r\n\t" +
                        "Lectures\r\n" +
                    "WHERE\r\n\t" +
                        "Course = @course AND Topic = @topic AND Date = @date";

                var command = new SqlCommand(sqlExpression, connection);

                var courseParam = new SqlParameter("@course", course);
                var topicParam = new SqlParameter("@topic", topic);
                var dateParam = new SqlParameter("@date", date);

                command.Parameters.Add(courseParam);
                command.Parameters.Add(topicParam);
                command.Parameters.Add(dateParam);

                connection.Open();

                try
                {
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int idColumnIndex       = 0;
                        int courseColumnIndex   = 1;
                        int topicColumnIndex    = 2;
                        int dateColumnIndex     = 3;

                        while (reader.Read())
                        {
                            lecture.Id.Value = (int)reader.GetValue(idColumnIndex);
                            lecture.Course = (string)reader.GetValue(courseColumnIndex);
                            lecture.Topic = (string)reader.GetValue(topicColumnIndex);
                            lecture.Date = (DateTime)reader.GetValue(dateColumnIndex);
                        }
                    }
                }
                catch (SqlException)
                {
                }
            }

            return lecture;
        }

        public int Update(Index<int> id, string course, string topic, DateTime date)
        {
            int rowsAffected = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "UPDATE Lectures\r\n" +
                    "SET Course = @course, Topic = @topic, Date = @date\r\n" +
                    "WHERE LectureID = @lectureId";

                var command = new SqlCommand(sqlExpression, connection);

                var idParam = new SqlParameter("@lectureId", id.Value);
                var courseParam = new SqlParameter("@course", course);
                var topicParam = new SqlParameter("@topic", topic);
                var dateParam = new SqlParameter("@date", date);

                command.Parameters.Add(idParam);
                command.Parameters.Add(courseParam);
                command.Parameters.Add(topicParam);
                command.Parameters.Add(dateParam);

                connection.Open();

                try
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                }
            }

            return rowsAffected;
        }

        public int Delete(Index<int> id)
        {
            int rowsAffected = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression = "DELETE FROM Lectures WHERE LectureID = @lectureId";

                var command = new SqlCommand(sqlExpression, connection);

                var idParam = new SqlParameter("@lectureId", id.Value);

                command.Parameters.Add(idParam);

                connection.Open();

                try
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                }
            }

            return rowsAffected;
        }

        public int Delete(string course, string topic, DateTime date)
        {
            int rowsAffected = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "DELETE FROM\r\n\t" +
                        "Lectures\r\n" +
                    "WHERE\r\n\t" +
                        "Course = @course AND Topic = @topic AND Date = @date";

                var command = new SqlCommand(sqlExpression, connection);

                var courseParam = new SqlParameter("@course", course);
                var topicParam = new SqlParameter("@topic", topic);
                var dateParam = new SqlParameter("@date", date);

                command.Parameters.Add(courseParam);
                command.Parameters.Add(topicParam);
                command.Parameters.Add(dateParam);

                connection.Open();

                try
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                }
            }

            return rowsAffected;
        }

        public IEnumerable<Lecture> GetAll()
        {
            var lectures = new List<Lecture>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "SELECT\r\n\t" +
                        "LectureID,\r\n\t" +
                        "Course,\r\n\t" +
                        "Topic,\r\n\t" +
                        "Date\r\n" +
                    "FROM Lectures";

                var command = new SqlCommand(sqlExpression, connection);

                connection.Open();

                try
                {
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int idColumnIndex       = 0;
                        int courseColumnIndex   = 1;
                        int topicColumnIndex    = 2;
                        int dateColumnIndex     = 3;

                        while (reader.Read())
                        {
                            var lecture = new Lecture();

                            lecture.Id.Value = (int)reader.GetValue(idColumnIndex);
                            lecture.Course = (string)reader.GetValue(courseColumnIndex);
                            lecture.Topic = (string)reader.GetValue(topicColumnIndex);
                            lecture.Date = (DateTime)reader.GetValue(dateColumnIndex);

                            lectures.Add(lecture);
                        }
                    }
                }
                catch (SqlException)
                {
                }
            }

            return lectures;
        }
    }
}
