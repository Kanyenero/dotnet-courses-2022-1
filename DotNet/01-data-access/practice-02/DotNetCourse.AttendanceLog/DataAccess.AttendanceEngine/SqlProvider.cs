using System.Data.SqlClient;
using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.DataAccess.AttendanceEngine
{
    public class SqlProvider : IDataProvider
    {
        public string ConnectionString { get; private set; }

        public SqlProvider(string connectionString) => ConnectionString = connectionString;

        public int Add(Index<int, int> id, int? mark)
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

                command.Parameters.AddWithValue("@LectureID", id.Value1);
                command.Parameters.AddWithValue("@StudentID", id.Value2);

                if (mark == null)
                    command.Parameters.AddWithValue("@Mark", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Mark", mark);

                try
                {
                    rowsAffected = (int)command.ExecuteScalar();
                }
                catch (SqlException)
                {
                }
            }

            return rowsAffected;
        }

        public Attendance Get(Index<int, int> id)
        {
            var attendance = new Attendance();

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "SELECT\r\n\t" +
                        "a.LectureID,\r\n\t" +
                        "l.[Date],\r\n\t" +
                        "l.Course,\r\n\t" +
                        "l.Topic,\r\n\t" +
                        "a.StudentID,\r\n\t" +
                        "s.UQ_Login,\r\n\t" +
                        "s.FirstName,\r\n\t" +
                        "s.LastName,\r\n\t" +
                        "a.Mark\r\n" +
                    "FROM \r\n\t" +
                        "Lectures AS l\r\n" +
                    "JOIN\r\n\t" +
                        "Attendances AS a ON l.LectureID = a.LectureID\r\nJOIN\r\n\tStudents As s ON s.StudentID = a.StudentID\r\n" +
                    "WHERE\r\n\t" +
                        "a.LectureID = @lectureId AND a.StudentID = @studentId";

                var command = new SqlCommand(sqlExpression, connection);

                var lectureIdParam = new SqlParameter("@lectureId", id.Value1);
                var studentIdParam = new SqlParameter("@studentId", id.Value2);

                command.Parameters.Add(lectureIdParam);
                command.Parameters.Add(studentIdParam);

                connection.Open();

                try
                {
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int LectureIDColumnIndex            = 0;
                        int LectureDateColumnIndex          = 1;
                        int LectureCourseColumnIndex        = 2;
                        int LectureTopicColumnIndex         = 3;
                        int StudentIDColumnIndex            = 4;
                        int StudentUniqueLoginColumnIndex   = 5;
                        int StudentFirstNameColumnIndex     = 6;
                        int StudentLastNameColumnIndex      = 7;
                        int MarkColumnIndex                 = 8;

                        while (reader.Read())
                        {
                            attendance.Id.Value1            = (int)reader.GetValue(LectureIDColumnIndex);
                            attendance.LectureDate          = (DateTime)reader.GetValue(LectureDateColumnIndex);
                            attendance.LectureCourse        = (string)reader.GetValue(LectureCourseColumnIndex);
                            attendance.LectureTopic         = (string)reader.GetValue(LectureTopicColumnIndex);
                            attendance.Id.Value2            = (int)reader.GetValue(StudentIDColumnIndex);
                            attendance.StudentUniqueLogin   = (string)reader.GetValue(StudentUniqueLoginColumnIndex);
                            attendance.StudentFirstName     = (string)reader.GetValue(StudentFirstNameColumnIndex);
                            attendance.StudentLastName      = (string)reader.GetValue(StudentLastNameColumnIndex);

                            if (!reader.IsDBNull(MarkColumnIndex))
                                attendance.Mark = (int)reader.GetValue(MarkColumnIndex);
                        }
                    }
                }
                catch (SqlException)
                {
                }
            }

            return attendance;
        }

        public int Delete(Index<int, int> id)
        {
            int rowsAffected = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression = "DELETE FROM Attendances WHERE LectureID = @lectureId AND StudentID = @studentId";

                var command = new SqlCommand(sqlExpression, connection);

                var lectureIdParam = new SqlParameter("@lectureId", id.Value1);
                var studentIdParam = new SqlParameter("@studentId", id.Value2);

                command.Parameters.Add(lectureIdParam);
                command.Parameters.Add(studentIdParam);

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

        public IEnumerable<Attendance> GetAll()
        {
            var attendances = new List<Attendance>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                string sqlExpression =
                    "SELECT\n" +
                        "l.LectureID,\n" +
                        "l.Date,\n" +
                        "l.Course,\n" +
                        "l.Topic,\n" +
                        "sa.StudentID,\n" +
                        "sa.UQ_Login,\n" +
                        "sa.FirstName,\n" +
                        "sa.LastName,\n" +
                        "sa.Mark\n" +
                    "FROM Lectures AS l\n" +
                        "FULL JOIN\n" +
                        "(SELECT\n" +
                            "s.StudentID,\n" +
                            "s.UQ_Login,\n" +
                            "s.FirstName,\n" +
                            "s.LastName,\n" +
                            "a.LectureID,\n" +
                            "a.Mark\n" +
                        "FROM\n" +
                            "Students AS s\n" +
                        "LEFT JOIN " +
                            "Attendances AS a ON s.StudentID = a.StudentID) AS sa\n" +
                        "ON sa.LectureID = l.LectureID";

                var command = new SqlCommand(sqlExpression, connection);

                connection.Open();

                try
                {
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int LectureIDColumnIndex            = 0;
                        int LectureDateColumnIndex          = 1;
                        int LectureCourseColumnIndex        = 2;
                        int LectureTopicColumnIndex         = 3;
                        int StudentIDColumnIndex            = 4;
                        int StudentUniqueLoginColumnIndex   = 5;
                        int StudentFirstNameColumnIndex     = 6;
                        int StudentLastNameColumnIndex      = 7;
                        int MarkColumnIndex                 = 8;

                        while (reader.Read())
                        {
                            var attendance = new Attendance();

                            if (!reader.IsDBNull(LectureIDColumnIndex))
                                attendance.Id.Value1 = (int)reader.GetValue(LectureIDColumnIndex);

                            if (!reader.IsDBNull(LectureDateColumnIndex))
                                attendance.LectureDate = (DateTime)reader.GetValue(LectureDateColumnIndex);

                            if (!reader.IsDBNull(LectureCourseColumnIndex))
                                attendance.LectureCourse = (string)reader.GetValue(LectureCourseColumnIndex);

                            if (!reader.IsDBNull(LectureTopicColumnIndex))
                                attendance.LectureTopic = (string)reader.GetValue(LectureTopicColumnIndex);

                            if (!reader.IsDBNull(StudentIDColumnIndex))
                                attendance.Id.Value2 = (int)reader.GetValue(StudentIDColumnIndex);

                            if (!reader.IsDBNull(StudentUniqueLoginColumnIndex))
                                attendance.StudentUniqueLogin = (string)reader.GetValue(StudentUniqueLoginColumnIndex);

                            if (!reader.IsDBNull(StudentFirstNameColumnIndex))
                                attendance.StudentFirstName = (string)reader.GetValue(StudentFirstNameColumnIndex);

                            if (!reader.IsDBNull(StudentLastNameColumnIndex))
                                attendance.StudentLastName = (string)reader.GetValue(StudentLastNameColumnIndex);

                            if (!reader.IsDBNull(MarkColumnIndex))
                                attendance.Mark = (int)reader.GetValue(MarkColumnIndex);

                            attendances.Add(attendance);
                        }
                    }
                }
                catch (SqlException)
                {
                }
            }

            return attendances;
        }
    }
}
