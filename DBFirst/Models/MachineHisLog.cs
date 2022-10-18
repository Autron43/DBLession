using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class MachineHisLog
    {
        public int Id { get; set; }
        public string? UploadContent { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int MachineId { get; set; }

        public virtual Machine Machine { get; set; } = null!;
    }
}
