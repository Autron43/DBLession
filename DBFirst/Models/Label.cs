using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Label
    {
        public Label()
        {
            LabelAccounts = new HashSet<LabelAccount>();
            LabelOperationLogs = new HashSet<LabelOperationLog>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Color { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public int OrganizationId { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<LabelAccount> LabelAccounts { get; set; }
        public virtual ICollection<LabelOperationLog> LabelOperationLogs { get; set; }
    }
}
