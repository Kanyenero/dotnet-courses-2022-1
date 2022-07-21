namespace DotNetCourse.DbConnectionApp.DbConnections
{
    public abstract class Connection
    {
        public string ConnectionString { get; }
        public string ServerVersion { get; protected set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString ?? string.Empty;
            ServerVersion = string.Empty;
        }

        public virtual void CreateConnection() { }
    }
}
