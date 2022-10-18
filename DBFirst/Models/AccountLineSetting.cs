using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AccountLineSetting
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public string? LineUserId { get; set; }
        public int OrgId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? LineNotifyToken { get; set; }
    }
}
