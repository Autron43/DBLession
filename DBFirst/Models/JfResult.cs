using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class JfResult
    {
        public JfResult()
        {
            JfResultBlocks = new HashSet<JfResultBlock>();
        }

        public int Id { get; set; }
        public int? Score { get; set; }
        public string? Message { get; set; }
        public bool? Warning { get; set; }
        public DateTime RecordAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid RespondentGid { get; set; }
        public int? ParentResponseId { get; set; }
        public Guid FormGid { get; set; }

        public virtual JfForm FormG { get; set; } = null!;
        public virtual ICollection<JfResultBlock> JfResultBlocks { get; set; }
    }
}
