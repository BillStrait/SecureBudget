using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBudget.Shared.Models
{
    public class Month
    {
        public int MonthNumber { get; set; }
        IEnumerable<FolderMeta> Days { get; set; }
        IEnumerable<BudgetItem> BudgetItems { get; set; }
    }
}
