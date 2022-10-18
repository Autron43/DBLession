using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class OrganizeAuthorization
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public Guid AccountGid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? RemovedAt { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
    }
}
