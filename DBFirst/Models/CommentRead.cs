using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class CommentRead
    {
        public Guid Gid { get; set; }
        public string OriginGid { get; set; } = null!;
        public Guid AccountGid { get; set; }
        public DateTime? LastReadTime { get; set; }
        public int OriginType { get; set; }

        public virtual Account AccountG { get; set; } = null!;
    }
}
