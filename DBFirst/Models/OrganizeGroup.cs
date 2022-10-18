using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class OrganizeGroup
    {
        public int Id { get; set; }
        public int ParentOrganizeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int OrganizationId { get; set; }

        public virtual Organization Organization { get; set; } = null!;
    }
}
