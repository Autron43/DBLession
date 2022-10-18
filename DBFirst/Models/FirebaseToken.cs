using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class FirebaseToken
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public string? DeviceToken { get; set; }
        public string DeviceType { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UsageCount { get; set; }
    }
}
