using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Assigment.Data
{
    public interface IQueryServices
    {
        List<T> ExecuteQueryList<T>(string sql);
    }
}
