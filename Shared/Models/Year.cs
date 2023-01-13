using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBudget.Shared.Models
{
    public class Year
    {
        public int YearNumber { get; set; }
        IEnumerable<FolderMeta> Months { get; set; }
    }
}
