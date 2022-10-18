using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class UsageRecord
    {
        public int Id { get; set; }
        public string? ObjectId { get; set; }
        public int ObjectType { get; set; }
        public Guid AccountGid { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
