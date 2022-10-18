using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class PatientGroupOwner
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid AccountGid { get; set; }
        public int PatientGroupId { get; set; }

        public virtual PatientGroup PatientGroup { get; set; } = null!;
    }
}
