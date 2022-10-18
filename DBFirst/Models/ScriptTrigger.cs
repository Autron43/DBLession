using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ScriptTrigger
    {
        public int Id { get; set; }
        public int ScriptId { get; set; }
        public int TriggerType { get; set; }
        public DateTime? ScheduleTime { get; set; }
        public string? CronExpression { get; set; }
        public int EventType { get; set; }
        public string? JobId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? DelayTimeTicks { get; set; }

        public virtual Script Script { get; set; } = null!;
    }
}
