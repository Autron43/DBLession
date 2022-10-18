using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Comment
    {
        public Guid Gid { get; set; }
        public string? OriginGid { get; set; }
        public int OriginType { get; set; }
        public Guid? MainCommentGid { get; set; }
        public bool IsSecret { get; set; }
        public bool IsAnonymous { get; set; }
        public Guid CreatedBy { get; set; }
        public string? ContentText { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Account CreatedByNavigation { get; set; } = null!;
    }
}
