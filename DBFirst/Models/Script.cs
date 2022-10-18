using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Script
    {
        public Script()
        {
            PatientGroupScripts = new HashSet<PatientGroupScript>();
            ScriptAccounts = new HashSet<ScriptAccount>();
            ScriptExecutionLogs = new HashSet<ScriptExecutionLog>();
            ScriptTriggers = new HashSet<ScriptTrigger>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Content { get; set; }
        public string? Xml { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public int OrganizationId { get; set; }
        public string? CronExpression { get; set; }
        public int CronType { get; set; }
        public bool? TriggerOnce { get; set; }
        public DateTime? TriggerTime { get; set; }
        public int TriggerType { get; set; }
        public bool? Enabled { get; set; }
        public string? JobId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<PatientGroupScript> PatientGroupScripts { get; set; }
        public virtual ICollection<ScriptAccount> ScriptAccounts { get; set; }
        public virtual ICollection<ScriptExecutionLog> ScriptExecutionLogs { get; set; }
        public virtual ICollection<ScriptTrigger> ScriptTriggers { get; set; }
    }
}
