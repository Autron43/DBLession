using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class JfTrigger
    {
        public int Id { get; set; }
        public int ConditionId { get; set; }
        public string? ConditionValue { get; set; }
        public int EventBlockId { get; set; }
        public int Action { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid FormGid { get; set; }

        public virtual JfForm FormG { get; set; } = null!;
    }
}
