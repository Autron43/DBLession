using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ScriptExecutionLog
    {
        public int Id { get; set; }
        public int ScriptId { get; set; }
        public bool Success { get; set; }
        public string? Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid AccountGid { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual Script Script { get; set; } = null!;
    }
}
