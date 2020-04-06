using System;
using System.Collections.Generic;
//using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    public class MCSDDATABASE : IDisposable
    {
        private const string _connectionString = "Data Source=mcsd-sql.database.windows.net;Initial Catalog=MCSD;Integrated Security=False;User ID=tkmyers46;Password=!!**5439mmKK;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection dbConnection { get; set; }

        public SqlCommand sqlCommand { get; set; }

        public MCSDDATABASE()
        {
            dbConnection = new SqlConnection(_connectionString);            
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = dbConnection;
        }

        public MCSDDATABASE(string connectionString)
        {
            dbConnection.ConnectionString = connectionString;
        }

        public void Dispose()
        {
            dbConnection.Close();
        }
    }
}
