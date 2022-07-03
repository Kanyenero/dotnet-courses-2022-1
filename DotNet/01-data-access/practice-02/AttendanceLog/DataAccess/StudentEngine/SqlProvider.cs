using AttendanceLog.Common.Entities;
using System.Data.SqlClient;

namespace AttendanceLog.DataAccess.StudentEngine
{
    public class SqlProvider : IDataProvider
    {
        public string ConnectionString { get; private set; } = default!;

        public SqlProvider(string connectionString) => ConnectionString = connectionString;

        private readonly string addExpression =
            "INSERT INTO [Students]" +
                "(First_Name, Middle_Name, Last_Name, UQ_Passport_Series_and_Number)" +
            "OUTPUT [Inserted].[Id]" +
            "VALUES (@first_name, @middle_name, @last_name, @passport_series_and_number)";

        public int Add(string firstName, string? middleName, string lastName, string passportSeriesAndNumber)
        {
            int addedStudentId = -1;

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var command = new SqlCommand(addExpression, connection);

                var firstNameParam = new SqlParameter("@first_name", firstName);
                var middleNameParam = new SqlParameter("@middle_name", middleName);
                var lastNameParam = new SqlParameter("@last_name", lastName);
                var passportParam = new SqlParameter("@passport_series_and_number", passportSeriesAndNumber);

                if (middleName == null)
                    middleNameParam.Value = DBNull.Value;

                command.Parameters.Add(firstNameParam);
                command.Parameters.Add(middleNameParam);
                command.Parameters.Add(lastNameParam);
                command.Parameters.Add(passportParam);

                object returnedData = default!;

                try
                {
                    returnedData = command.ExecuteScalar();
                }
                catch(SqlException)
                {
                }

                if (returnedData != null)
                    addedStudentId = (int)returnedData;
            }

            return addedStudentId;
        }

        public int Add(Student student)
        {
            return Add(student.FirstName, student.MiddleName, student.LastName, student.PassportSeriesAndNumber);
        }
    }
}
