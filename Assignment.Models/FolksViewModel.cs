using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class FolksViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthLocation { get; set; }
        public string Bio { get; set; }
        public List<FolksViewModel> FolksDetails { get; set; }
    }
}