using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class CourseCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int OrganizationId { get; set; }
        public Guid? AccountGid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Description { get; set; }

        public virtual Organization Organization { get; set; } = null!;
    }
}
