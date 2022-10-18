using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class LabelAccount
    {
        public int Id { get; set; }
        public int LabelId { get; set; }
        public Guid AccountGid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual Label Label { get; set; } = null!;
    }
}
