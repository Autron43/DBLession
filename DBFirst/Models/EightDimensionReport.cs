using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class EightDimensionReport
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public Guid QuestionnaireGid { get; set; }
        public int Category { get; set; }
        public string? Type { get; set; }
        public int LabelValue { get; set; }
        public string? BmiResult { get; set; }
        public float? BmiValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime TestAt { get; set; }
        public string? Creator { get; set; }

        public virtual Account AccountG { get; set; } = null!;
    }
}
