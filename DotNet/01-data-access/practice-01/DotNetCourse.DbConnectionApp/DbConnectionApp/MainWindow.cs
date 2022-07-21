using DotNetCourse.DbConnectionApp.DbConnections;

namespace DotNetCourse.DbConnectionApp.UserInterface
{
    public partial class MainWindow : Form
    {
        private Connection _connection;
        private string _connectionString;
        private string _dataProvider;
        private readonly List<string> _dataProviders = new()
        {
            "SQL",
            "OLE DB"
        };


        public MainWindow()
        {
            InitializeComponent();
            InitializeProperties();
            InitializeControls();

            _connectionString = string.Empty;
        }


        private void InitializeProperties()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        private void InitializeControls()
        {
            cboDataProvider.DataSource = _dataProviders;
            cboDataProvider.SelectedIndex = 0;
        }


        private void cboDataProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dataProvider = cboDataProvider.SelectedItem.ToString();
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            _connectionString = txtConnectionString.Text;

            if (_connectionString == string.Empty)
            {
                lblInfo.Text = "Info: The connection string is empty.";
                return;
            }

            if (_dataProvider == null)
            {
                lblInfo.Text = "Info: Invalid data provider.";
                return;
            }

            _connection = InitializeConnection(_dataProvider, _connectionString);

            try
            {
                _connection.CreateConnection();
            }
            catch (Exception)
            {
                lblInfo.Text = "Ошибка подключения. Строка подключения задана неверно.";
                return;
            }

            lblInfo.Text = "Версия сервера: " + _connection.ServerVersion;
        }


        private Connection InitializeConnection(string dataProvider, string connectionString)
        {
            Connection connection = null;

            switch (dataProvider)
            {
                case "SQL":
                    connection = new SqlConnection(connectionString);
                    break;

                case "OLE DB":
                    connection = new OleDbConnection(connectionString);
                    break;
            }

            return connection;
        }
    }
}

//  Строка подключения SQL
// 
//  Server=localhost;Database=master;Trusted_Connection=True;
//
//  Строка подключения OleDb
//
//  Provider=SQLOLEDB;Data Source=(local);Integrated Security=SSPI