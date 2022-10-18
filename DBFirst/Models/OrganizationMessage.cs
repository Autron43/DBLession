using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class OrganizationMessage
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public DateTime? PostDate { get; set; }
        public string? Content { get; set; }
        public int OrganizationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }

        public virtual Account CreatedByNavigation { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
    }
}
