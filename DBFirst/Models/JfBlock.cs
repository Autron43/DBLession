using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class JfBlock
    {
        public JfBlock()
        {
            JfBlockDetails = new HashSet<JfBlockDetail>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Type { get; set; }
        public bool Required { get; set; }
        public int Sort { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid FormGid { get; set; }

        public virtual JfForm FormG { get; set; } = null!;
        public virtual ICollection<JfBlockDetail> JfBlockDetails { get; set; }
    }
}
