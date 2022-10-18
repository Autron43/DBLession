using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class JfResultBlock
    {
        public JfResultBlock()
        {
            JfResultBlockDetails = new HashSet<JfResultBlockDetail>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Type { get; set; }
        public bool Required { get; set; }
        public int Sort { get; set; }
        public int ResultId { get; set; }

        public virtual JfResult Result { get; set; } = null!;
        public virtual ICollection<JfResultBlockDetail> JfResultBlockDetails { get; set; }
    }
}
