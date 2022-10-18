using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AccountNotificationLog
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public bool Read { get; set; }
        public int ContentType { get; set; }
        public string? ContentId { get; set; }
        public string? ContentUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Account AccountG { get; set; } = null!;
    }
}
