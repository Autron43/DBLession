using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class MachineUsageLog
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public int MachineId { get; set; }
        public int? CardType { get; set; }
        public string? TimeOfUsage { get; set; }
        public bool IsHandWrite { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual Machine Machine { get; set; } = null!;
    }
}
