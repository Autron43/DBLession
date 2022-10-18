using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AccountDiseaseIdentifiedAtLog
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public DateTime IdentifiedAt { get; set; }
        public int OrgId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Account AccountG { get; set; } = null!;
    }
}
