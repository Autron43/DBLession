using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class SleepRecord
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public string? AppleHealthId { get; set; }
        public string? GoogleFitId { get; set; }
        public int Quality { get; set; }
        public int Source { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
