namespace DotNetCourse.DbConnectionApp.DbConnections
{
    public class OleDbConnection : Connection
    {
        public OleDbConnection(string connectionString) : base(connectionString) { }

        public override void CreateConnection()
        {
            using (var connection = new System.Data.OleDb.OleDbConnection(ConnectionString))
            {
                connection.Open();
                ServerVersion = connection.ServerVersion;
            }
        }
    }
}
