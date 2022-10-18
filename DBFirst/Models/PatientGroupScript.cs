using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class PatientGroupScript
    {
        public PatientGroupScript()
        {
            ScriptAccounts = new HashSet<ScriptAccount>();
        }

        public int Id { get; set; }
        public int ScriptId { get; set; }
        public int PatientGroupId { get; set; }
        public int ApplyTarget { get; set; }
        public bool ApplyToNewMember { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }

        public virtual PatientGroup PatientGroup { get; set; } = null!;
        public virtual Script Script { get; set; } = null!;
        public virtual ICollection<ScriptAccount> ScriptAccounts { get; set; }
    }
}
