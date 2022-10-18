using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class CoravelLog
    {
        public int Id { get; set; }
        public string? TaskName { get; set; }
        public bool Result { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
