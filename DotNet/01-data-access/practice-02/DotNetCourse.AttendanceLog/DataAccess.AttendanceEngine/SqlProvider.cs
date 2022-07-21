using System.Data.SqlClient;

namespace DotNetCourse.AttendanceLog.DataAccess.AttendanceEngine
{
    public class SqlProvider : IDataProvider
    {
        public string ConnectionString { get; private set; } = default!;

        public SqlProvider(string connectionString) => ConnectionString = connectionString;

        public int Attend(int? studentId, int? lectureId, int? mark)
        {
            int rowsAffected = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "MarkAttendance"
                };

                command.Parameters.AddWithValue("@Student_Id", studentId);
                command.Parameters.AddWithValue("@Lecture_Id", lectureId);
                command.Parameters.AddWithValue("@Mark", mark);

                object returnedData = default!;

                try
                {
                    returnedData = command.ExecuteScalar();
                }
                catch (SqlException)
                {
                }

                if (returnedData != null)
                    rowsAffected = (int)returnedData;
            }

            return rowsAffected;
        }

        public int Attend(Entities.Student student, Entities.Lecture lecture, int? mark)
        {
            return Attend(student.Id, lecture.Id, mark);
        }
    }
}
