using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBudget.Shared.Models
{
    public class Budget
    {
        public string DisplayName { get; set; } = string.Empty;
        public string BudgetSalt { get; set; } = string.Empty;
        public string BlobContainer { get; set; } = string.Empty;
        public string BlobName { get; set; } = string.Empty;
        Dictionary<string, FolderMeta> Years { get; set; }
        Dictionary<string,FolderMeta> Accounts { get; set; }
    }
}
