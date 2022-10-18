using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class HealthPassbook
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
