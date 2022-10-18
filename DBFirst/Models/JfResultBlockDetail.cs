using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class JfResultBlockDetail
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public string? Function { get; set; }
        public string? Value { get; set; }
        public int Sort { get; set; }
        public int? Score { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int ResultBlockId { get; set; }
        public int BlockId { get; set; }

        public virtual JfResultBlock Block { get; set; } = null!;
    }
}
