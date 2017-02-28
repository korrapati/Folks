using Assigment.Data;
using Assigment.Interface;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.Repository
{
    public class FolksRepository : IFolksService
    {
        private static IQueryServices _query;
        public FolksRepository(IQueryServices query)
        {
            _query = query;
        }
        public List<FolksViewModel> GetAllFolksDetails()
        {
            return _query.ExecuteQueryList<FolksViewModel>("GetAllFolksDetails");
        }
    }
}