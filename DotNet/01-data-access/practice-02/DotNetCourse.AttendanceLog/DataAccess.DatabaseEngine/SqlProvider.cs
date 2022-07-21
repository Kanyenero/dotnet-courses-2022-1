using System.Data.SqlClient;
using DotNetCourse.AttendanceLog.Entities;

namespace DotNetCourse.AttendanceLog.DataAccess.DatabaseEngine
{
    public class SqlProvider : IDataProvider
    {
        private readonly IEnumerable<string> createTableExpressions = new List<string>()
        {
            "DROP TABLE IF EXISTS [dbo].[Students]\n" +
            "CREATE TABLE Students\n" +
            "(\n" +
                "[Id] INT IDENTITY(1, 1),\n" +
                "[First_Name] VARCHAR(50) NOT NULL,\n" +
                "[Middle_Name] VARCHAR(50) NULL,\n" +
                "[Last_Name] VARCHAR(50) NOT NULL,\n" +
                "[UQ_Passport_Series_and_Number] VARCHAR(10) UNIQUE,\n" +
                "PRIMARY KEY([Id])\n" +
            ")",

            "DROP TABLE IF EXISTS [dbo].[Lectures]\n" +
            "CREATE TABLE [Lectures]\n" +
            "(\n" +
                "[Id] INT IDENTITY(1, 1),\n" +
                "[Topic] VARCHAR(50) NOT NULL,\n" +
                "[Date] SMALLDATETIME NOT NULL,\n" +
                "PRIMARY KEY([Id])\n" +
            ")",

            "DROP TABLE IF EXISTS [dbo].[Attendance]\n" +
            "CREATE TABLE [Attendance]\n" +
            "(\n" +
                "[Student_Id] INT NOT NULL,\n" +
                "[Lecture_Id] INT NOT NULL,\n" +
                "[Mark] INT CHECK([Mark] >= 2 AND [Mark] <= 5) NULL,\n" +
                "PRIMARY KEY(Student_Id, Lecture_Id),\n" +
                "CONSTRAINT [FK_student]\n" +
                    "FOREIGN KEY ([Student_Id])\n" +
                    "REFERENCES [Students]([Id])\n" +
                    "ON DELETE CASCADE,\n" +
                "CONSTRAINT [FK_lecture]\n" +
                    "FOREIGN KEY ([Lecture_Id])\n" +
                    "REFERENCES [Lectures]([Id])\n" +
                    "ON DELETE CASCADE\n" +
            ")"
        };

        private readonly IEnumerable<string> createStoredProcedureExpressions = new List<string>()
        {
            "CREATE PROCEDURE MarkAttendance (@Student_Id INT, @Lecture_Id INT, @Mark INT)\n" +
            "AS\n" +
            "BEGIN\n" +
                "INSERT INTO [Attendance]\n" +
                "VALUES (@Student_Id, @Lecture_Id, @Mark)\n" +
                "SELECT @@ROWCOUNT\n" +
            "END"
        };

        private readonly string reportExpression =
            "SELECT\n" +
                "[Date],\n" +
                "[Topic],\n" +
                "[Student_Id],\n" +
                "[First_Name],\n" +
                "[Middle_Name],\n" +
                "[Last_Name],\n" +
                "[Mark]\n" +
            "FROM [Lectures]\n" +
                "FULL JOIN\n" +
                "(SELECT * FROM [Students]\n" +
                    "LEFT JOIN [Attendance]\n" +
                    "ON [Attendance].[Student_Id] = [Students].[Id])\n" +
                    "AS [Inner]\n" +
                "ON [Inner].[Lecture_Id] = [Lectures].[Id]";


        public string ConnectionString
        {
            get;
            private set;
        }

        public SqlProvider(string connectionString)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

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

        public IEnumerable<Attendance> GetReport()
        {
            var attendances = new List<Attendance>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandText = reportExpression
                };

                connection.Open();

                try
                {
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int indexLectureDate        = 0;
                        int indexLectureTopic       = 1;
                        int indexStudentId          = 2;
                        int indexStudentFirstName   = 3;
                        int indexStudentMiddleName  = 4;
                        int indexStudentLastName    = 5;
                        int indexMark               = 6;

                        while (reader.Read())
                        {
                            var attendance = new Attendance();

                            if (!reader.IsDBNull(indexLectureDate))
                                attendance.LectureDateTime = (DateTime)reader.GetValue(indexLectureDate);

                            if (!reader.IsDBNull(indexLectureTopic))
                                attendance.LectureTopic = (string)reader.GetValue(indexLectureTopic);

                            if (!reader.IsDBNull(indexStudentId))
                                attendance.StudentId = (int)reader.GetValue(indexStudentId);

                            if (!reader.IsDBNull(indexStudentFirstName))
                                attendance.StudentFirstName = (string)reader.GetValue(indexStudentFirstName);

                            if (!reader.IsDBNull(indexStudentMiddleName))
                                attendance.StudentMiddleName = (string)reader.GetValue(indexStudentMiddleName);

                            if (!reader.IsDBNull(indexStudentLastName))
                                attendance.StudentLastName = (string)reader.GetValue(indexStudentLastName);

                            if (!reader.IsDBNull(indexMark))
                                attendance.Mark = (int)reader.GetValue(indexMark);

                            attendances.Add(attendance);
                        }
                    }
                }
                catch(SqlException)
                {
                }
            }

            return attendances;
        }
    }
}