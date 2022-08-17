using DotNetCourse.AttendanceLog.Models;
using System.Data.SqlClient;

namespace DotNetCourse.AttendanceLog.DataAccess.StudentEngine
{
    public class SqlProvider : IDataProvider
    {
        public string ConnectionString { get; private set; }

        public SqlProvider(string connectionString) => ConnectionString = connectionString;

        public int Add(string firstName, string lastName, string uniqueLogin)
        {
            int rowsAffected = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "INSERT INTO Students\r\n\t" +
                        "(FirstName, LastName, UQ_Login)\r\n" +
                    "VALUES (@firstName, @lastName, @uniqueLogin)";

                var command = new SqlCommand(sqlExpression, connection);

                var firstNameParam = new SqlParameter("@firstName", firstName);
                var lastNameParam = new SqlParameter("@lastName", lastName);
                var uniqueLoginParam = new SqlParameter("@uniqueLogin", uniqueLogin);

                command.Parameters.Add(firstNameParam);
                command.Parameters.Add(lastNameParam);
                command.Parameters.Add(uniqueLoginParam);

                connection.Open();

                try
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch(SqlException)
                {
                }
            }

            return rowsAffected;
        }

        public Student Get(Index<int> id)
        {
            var student = new Student();

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "SELECT\r\n\t" +
                        "StudentID,\r\n\t" +
                        "UQ_Login,\r\n\t" +
                        "FirstName,\r\n\t" +
                        "LastName\r\n" +
                    "FROM\r\n\t" +
                        "Students\r\n" +
                    "WHERE\r\n\t" +
                        "StudentID = @studentId";

                var command = new SqlCommand(sqlExpression, connection);

                var idParam = new SqlParameter("@studentId", id.Value);

                command.Parameters.Add(idParam);

                connection.Open();

                try
                {
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int idColumnIndex           = 0;
                        int uniqueLoginColumnIndex  = 1;
                        int firstNameColumnIndex    = 2;
                        int lastNameColumnIndex     = 3;

                        while (reader.Read())
                        {
                            student.Id.Value = (int)reader.GetValue(idColumnIndex);
                            student.UniqueLogin = (string)reader.GetValue(uniqueLoginColumnIndex);
                            student.FirstName = (string)reader.GetValue(firstNameColumnIndex);
                            student.LastName = (string)reader.GetValue(lastNameColumnIndex);
                        }
                    }
                }
                catch (SqlException)
                {
                }
            }

            return student;
        }

        public Student Get(string firstName, string lastName, string uniqueLogin)
        {
            var student = new Student();

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "SELECT\r\n\t" +
                        "StudentID,\r\n\t" +
                        "UQ_Login,\r\n\t" +
                        "FirstName,\r\n\t" +
                        "LastName\r\n" +
                    "FROM\r\n\t" +
                        "Students\r\n" +
                    "WHERE\r\n\t" +
                        "UQ_Login = @uniqueLogin AND FirstName = @firstName AND LastName = @lastName";

                var command = new SqlCommand(sqlExpression, connection);

                var uniqueLoginParam = new SqlParameter("@uniqueLogin", uniqueLogin);
                var firstNameParam = new SqlParameter("@firstName", firstName);
                var lastNameParam = new SqlParameter("@lastName", lastName);

                command.Parameters.Add(uniqueLoginParam);
                command.Parameters.Add(firstNameParam);
                command.Parameters.Add(lastNameParam);

                connection.Open();

                try
                {
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int idColumnIndex           = 0;
                        int uniqueLoginColumnIndex  = 1;
                        int firstNameColumnIndex    = 2;
                        int lastNameColumnIndex     = 3;

                        while (reader.Read())
                        {
                            student.Id.Value = (int)reader.GetValue(idColumnIndex);
                            student.UniqueLogin = (string)reader.GetValue(uniqueLoginColumnIndex);
                            student.FirstName = (string)reader.GetValue(firstNameColumnIndex);
                            student.LastName = (string)reader.GetValue(lastNameColumnIndex);
                        }
                    }
                }
                catch (SqlException)
                {
                }
            }

            return student;
        }

        public int Update(Index<int> id, string firstName, string lastName, string uniqueLogin)
        {
            int rowsAffected = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "UPDATE Students\r\n" +
                    "SET FirstName = @firstName, LastName = @lastName, UQ_Login = @uniqueLogin\r\n" +
                    "WHERE StudentID = @studentId";

                var command = new SqlCommand(sqlExpression, connection);

                var idParam = new SqlParameter("@studentId", id.Value);
                var firstNameParam = new SqlParameter("@firstName", firstName);
                var lastNameParam = new SqlParameter("@lastName", lastName);
                var uniqueLoginParam = new SqlParameter("@uniqueLogin", uniqueLogin);

                command.Parameters.Add(idParam);
                command.Parameters.Add(firstNameParam);
                command.Parameters.Add(lastNameParam);
                command.Parameters.Add(uniqueLoginParam);

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
                string sqlExpression = "DELETE FROM Students WHERE StudentID = @studentId";

                var command = new SqlCommand(sqlExpression, connection);

                var idParam = new SqlParameter("@studentId", id.Value);

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

        public int Delete(string firstName, string lastName, string uniqueLogin)
        {
            int rowsAffected = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression = 
                    "DELETE FROM\r\n\t" +
                        "Students\r\n" +
                    "WHERE\r\n\t" +
                        "FirstName = @firstName AND LastName = @lastName AND UQ_Login = @uniqueLogin";

                var command = new SqlCommand(sqlExpression, connection);

                var firstNameParam = new SqlParameter("@firstName", firstName);
                var lastNameParam = new SqlParameter("@lastName", lastName);
                var uniqueLoginParam = new SqlParameter("@uniqueLogin", uniqueLogin);

                command.Parameters.Add(firstNameParam);
                command.Parameters.Add(lastNameParam);
                command.Parameters.Add(uniqueLoginParam);

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

        public IEnumerable<Student> GetAll()
        {
            var students = new List<Student>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "SELECT\r\n\t" +
                        "StudentID,\r\n\t" +
                        "UQ_Login,\r\n\t" +
                        "FirstName,\r\n\t" +
                        "LastName\r\n" +
                    "FROM Students";

                var command = new SqlCommand(sqlExpression, connection);

                connection.Open();

                try
                {
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int idColumnIndex = 0;
                        int uniqueLoginColumnIndex = 1;
                        int firstNameColumnIndex = 2;
                        int lastNameColumnIndex = 3;

                        while (reader.Read())
                        {
                            var student = new Student();

                            student.Id.Value = (int)reader.GetValue(idColumnIndex);
                            student.UniqueLogin = (string)reader.GetValue(uniqueLoginColumnIndex);
                            student.FirstName = (string)reader.GetValue(firstNameColumnIndex);
                            student.LastName = (string)reader.GetValue(lastNameColumnIndex);

                            students.Add(student);
                        }
                    }
                }
                catch (SqlException)
                {
                }
            }

            return students;
        }
    }
}
