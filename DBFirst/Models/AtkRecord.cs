using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AtkRecord
    {
        public int Id { get; set; }
        public string? Result { get; set; }
        public Guid AccountGid { get; set; }
        public Guid InspectorGid { get; set; }
        public string? ImageId { get; set; }
        public Guid? VerifierGid { get; set; }
        public DateTime? VerifierTime { get; set; }
        public string? Remark { get; set; }
        public DateTime UserMeasureTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Source { get; set; }
        public string? RapidTestId { get; set; }
        public int VerifyStatus { get; set; }
        public int? OrgId { get; set; }

        public virtual Account? VerifierG { get; set; }
        public virtual VitalSign? VitalSign { get; set; }
    }
}
