using DB.EnumFields;
using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class PatientGroupDetail
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public Guid AccountGid { get; set; }
        public int PatientGroupId { get; set; }
        public PatientGroupOperation Status { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual PatientGroup PatientGroup { get; set; } = null!;
    }
}
