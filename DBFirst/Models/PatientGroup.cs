using DB.EnumFields;
using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class PatientGroup
    {
        public PatientGroup()
        {
            PatientGroupDetails = new HashSet<PatientGroupDetail>();
            PatientGroupOwners = new HashSet<PatientGroupOwner>();
            PatientGroupScripts = new HashSet<PatientGroupScript>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public PatientGroupStatus Status { get; set; }
        public bool WholeAccount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int OrganizationId { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public string? Bulletin { get; set; }
        public string? CategoryText { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<PatientGroupDetail> PatientGroupDetails { get; set; }
        public virtual ICollection<PatientGroupOwner> PatientGroupOwners { get; set; }
        public virtual ICollection<PatientGroupScript> PatientGroupScripts { get; set; }
    }
}
