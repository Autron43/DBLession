using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ScriptAccount
    {
        public ScriptAccount()
        {
            ScriptAccountJobs = new HashSet<ScriptAccountJob>();
        }

        public int Id { get; set; }
        public int ScriptId { get; set; }
        public Guid AccountGid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? LastExecuted { get; set; }
        public int GroupScriptId { get; set; }
        public Guid CreatedBy { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual PatientGroupScript GroupScript { get; set; } = null!;
        public virtual Script Script { get; set; } = null!;
        public virtual ICollection<ScriptAccountJob> ScriptAccountJobs { get; set; }
    }
}
