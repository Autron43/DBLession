using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class JfForm
    {
        public JfForm()
        {
            JfBlocks = new HashSet<JfBlock>();
            JfMessages = new HashSet<JfMessage>();
            JfResults = new HashSet<JfResult>();
            JfTriggers = new HashSet<JfTrigger>();
        }

        public Guid Guid { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Enable { get; set; }
        public Guid? ParentFormGid { get; set; }
        public bool? Score { get; set; }

        public virtual QuestionnaireOrganize? QuestionnaireOrganize { get; set; }
        public virtual ICollection<JfBlock> JfBlocks { get; set; }
        public virtual ICollection<JfMessage> JfMessages { get; set; }
        public virtual ICollection<JfResult> JfResults { get; set; }
        public virtual ICollection<JfTrigger> JfTriggers { get; set; }
    }
}
