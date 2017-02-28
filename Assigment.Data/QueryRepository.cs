using System;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace Assigment.Data
{
    public class QueryRepository : IQueryServices
    {
        private const int TimeOut = 1800;
        public List<T> ExecuteQueryList<T>(string sql)
        {
            using (var _conn = new SqlConnectionFactory().GetConnection())
            {
                return _conn.Query<T>(sql, param: null, commandType: CommandType.StoredProcedure, commandTimeout: TimeOut).ToList();
            }
        }
    }
}
