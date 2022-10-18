using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class MachineInfo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float? Longitude { get; set; }
        public float? Latitude { get; set; }
        public int Environment { get; set; }
        public string? SimPhoneNumber { get; set; }
        public string? Address { get; set; }
        public bool Xjkproject { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int MachineId { get; set; }
        public int Type { get; set; }
        public string? ZipCode { get; set; }

        public virtual Machine Machine { get; set; } = null!;
    }
}
