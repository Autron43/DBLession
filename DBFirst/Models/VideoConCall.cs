using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class VideoConCall
    {
        public Guid Gid { get; set; }
        public string? ApiKey { get; set; }
        public string? SessionId { get; set; }
        public string? Token { get; set; }
        public int OrgId { get; set; }
        public string? Name { get; set; }
        public Guid CreatedAccountGid { get; set; }
        public Guid? InviteAccountGid { get; set; }
        public DateTime ExpireTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Account CreatedAccountG { get; set; } = null!;
        public virtual Organization Org { get; set; } = null!;
    }
}
