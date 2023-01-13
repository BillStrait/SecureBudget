using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBudget.Shared.Models
{
    public class Family
    {
        public int FamilyId { get; set; }
        public string FamilyName { get; set; } = string.Empty;
        public IEnumerable<int> FamilyMememberIds { get; set; } = new List<int>();
        public IEnumerable<FolderMeta> FamilyBudgets { get; set; } = new List<FolderMeta>();
    }
}