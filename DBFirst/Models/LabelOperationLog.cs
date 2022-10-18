using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class LabelOperationLog
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public int LabelId { get; set; }
        public int OperationType { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Label Label { get; set; } = null!;
    }
}
