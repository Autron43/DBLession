using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AccountRole
    {
        public string? Id { get; set; }
        public int RoleId { get; set; }
        public Guid AccountGid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
    }
}
