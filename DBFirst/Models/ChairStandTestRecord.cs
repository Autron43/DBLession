using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ChairStandTestRecord
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public int StandCount { get; set; }
        public double Duration { get; set; }
        public int Result { get; set; }
        public int Source { get; set; }
        public DateTime MeasureAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
