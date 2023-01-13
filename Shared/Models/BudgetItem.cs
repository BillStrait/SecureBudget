using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBudget.Shared.Models
{
    internal class BudgetItem
    {
        public string Name { get; set; } = string.Empty;
        public decimal BudgetedAmount { get; set; }
        public decimal ActualAmount { get; set; }
    }
}
