using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ProductSerial
    {
        public string SerialNo { get; set; } = null!;
        public DateTime? RegTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Remark { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? MachineId { get; set; }
        public int? OrganizationId { get; set; }

        public virtual Machine? Machine { get; set; }
        public virtual Organization? Organization { get; set; }
    }
}
