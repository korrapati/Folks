using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.Data
{
    public class SqlConnectionFactory:IDisposable
    {
        private SqlConnection _con;
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        public SqlConnection GetConnection()
        {
            return _con ?? (_con = new SqlConnection(_connectionString));
        }
        public void Dispose()
        {
            if (null != _con)
                _con.Dispose();
        }
    }
}
