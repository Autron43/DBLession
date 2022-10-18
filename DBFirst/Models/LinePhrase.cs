using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class LinePhrase
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public int? OrganizationId { get; set; }

        public virtual Organization? Organization { get; set; }
    }
}
