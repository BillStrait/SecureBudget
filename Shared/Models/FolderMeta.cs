using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBudget.Shared.Models
{
    public class FolderMeta
    {
        public string FolderName { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty; 
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; } = string.Empty;
        public int NumberOfChildren { get; set; }
        public FolderMeta()
        {
            FolderName = new Guid().ToString();
        }
    }
}