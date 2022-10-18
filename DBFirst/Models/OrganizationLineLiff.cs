using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class OrganizationLineLiff
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int LiffType { get; set; }
        public string? LiffId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
