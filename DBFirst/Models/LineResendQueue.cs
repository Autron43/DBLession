using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class LineResendQueue
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public string? Message { get; set; }
        public int Status { get; set; }
        public string? Remark { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int OrganizationId { get; set; }
    }
}
