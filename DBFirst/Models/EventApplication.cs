using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class EventApplication
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string? Remark { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public Guid AccountGid { get; set; }
        public int EventId { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual Event Event { get; set; } = null!;
    }
}
