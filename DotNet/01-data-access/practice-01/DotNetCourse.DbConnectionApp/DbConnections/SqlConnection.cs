namespace DotNetCourse.DbConnectionApp.DbConnections
{
    public class SqlConnection : Connection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }

        public override void CreateConnection()
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                connection.Open();
                ServerVersion = connection.ServerVersion;
            }
        }
    }
}
