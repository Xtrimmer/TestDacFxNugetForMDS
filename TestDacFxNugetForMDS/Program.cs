using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Dac;

namespace TestDacFxNugetForMDS
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = "mydb.database.windows.net",
                InitialCatalog = "mydb001",
                UserID = "UserID",
                Password = "Password"
            };

            DacDeployOptions deployOptions = new DacDeployOptions()
            {
                IgnoreWhitespace = true,
                IncludeTransactionalScripts = true,
                IgnoreSemicolonBetweenStatements = true
            };

            DacServices service = new DacServices(connectionStringBuilder.ConnectionString);
            service.ExportBacpac("MyDacPack-002", "mydb001");
        }
    }
}
