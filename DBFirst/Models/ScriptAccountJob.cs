using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ScriptAccountJob
    {
        public int Id { get; set; }
        public int ScriptAccountId { get; set; }
        public string? JobId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ScriptAccount ScriptAccount { get; set; } = null!;
    }
}
