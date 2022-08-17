using System.Data.SqlClient;

namespace DotNetCourse.AttendanceLog.DataAccess.DatabaseEngine
{
    public class SqlProvider : IDataProvider
    {
        private readonly IEnumerable<string> createTableExpressions = new List<string>()
        {
            "DROP TABLE IF EXISTS dbo.Students\n" +
            "CREATE TABLE Students\n" +
            "(\n" +
                "StudentID INT IDENTITY(1, 1),\n" +
                "FirstName NVARCHAR(10) NOT NULL,\n" +
                "LastName NVARCHAR(20) NOT NULL,\n" +
                "UQ_Login NVARCHAR(25) UNIQUE,\n" +
                "PRIMARY KEY(StudentID)\n" +
            ")",

            "DROP TABLE IF EXISTS dbo.Lectures\n" +
            "CREATE TABLE Lectures\n" +
            "(\n" +
                "LectureID INT IDENTITY(1, 1),\n" +
                "Course NVARCHAR(15) NOT NULL,\n" +
                "Topic NVARCHAR(30) NOT NULL,\n" +
                "Date SMALLDATETIME NOT NULL,\n" +
                "PRIMARY KEY(LectureID)\n" +
            ")",

            "DROP TABLE IF EXISTS dbo.Attendances\n" +
            "CREATE TABLE Attendances\n" +
            "(\n" +
                "LectureID INT NOT NULL,\n" +
                "StudentID INT NOT NULL,\n" +
                "Mark INT CHECK(Mark >= 2 AND Mark <= 5) NULL,\n" +
                "PRIMARY KEY(LectureID, StudentID),\n" +
                "CONSTRAINT FK_Lecture\n" +
                    "FOREIGN KEY (LectureID)\n" +
                    "REFERENCES Lectures(LectureID)\n" +
                    "ON DELETE CASCADE,\n" +
                "CONSTRAINT FK_Student\n" +
                    "FOREIGN KEY (StudentID)\n" +
                    "REFERENCES Students(StudentID)\n" +
                    "ON DELETE CASCADE\n" +
            ")"
        };

        private readonly IEnumerable<string> createStoredProcedureExpressions = new List<string>()
        {
            "CREATE PROCEDURE MarkAttendance (@LectureID INT, @StudentID INT, @Mark INT)\n" +
            "AS\n" +
            "BEGIN\n" +
                "INSERT INTO Attendances\n" +
                "VALUES (@LectureID, @StudentID, @Mark)\n" +
                "SELECT @@ROWCOUNT\n" +
            "END"
        };

        public string ConnectionString { get; private set; }

        public SqlProvider(string connectionString) => ConnectionString = connectionString;

        public bool Init()
        {
            bool executedWithSuccess;

            using (var connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand()
                {
                    Connection = connection
                };

                connection.Open();

                try
                {
                    foreach (var createTableExpression in createTableExpressions)
                    {
                        command.CommandText = createTableExpression;
                        command.ExecuteNonQuery();
                    }

                    foreach (var createStoredProceduresExpression in createStoredProcedureExpressions)
                    {
                        command.CommandText = createStoredProceduresExpression;
                        command.ExecuteNonQuery();
                    }

                    executedWithSuccess = true;
                }
                catch(SqlException)
                {
                    executedWithSuccess = false;
                }
            }

            return executedWithSuccess;
        }
    }
}