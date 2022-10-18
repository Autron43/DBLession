using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class JfMessage
    {
        public int Id { get; set; }
        public int MinScore { get; set; }
        public int MaxScore { get; set; }
        public string? Content { get; set; }
        public bool Warning { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid FormGid { get; set; }

        public virtual JfForm FormG { get; set; } = null!;
    }
}
