using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.Interface
{
    public interface IFolksService
    {
        List<FolksViewModel> GetAllFolksDetails();
    }
}
