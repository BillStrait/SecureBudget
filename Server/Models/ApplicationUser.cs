using Microsoft.AspNetCore.Identity;
using SecureBudget.Shared.Models;

namespace SecureBudget.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string BudgetKey { get; set; } = string.Empty; 
        public IEnumerable<FolderMeta> Budgets { get; set; } = new List<FolderMeta>();
        public IEnumerable<FolderMeta> FamilyBudgets { get; set; } = new List<FolderMeta>();
        public int? FamilyId { get; set; }
    }
}