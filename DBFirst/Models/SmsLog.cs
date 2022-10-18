using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class SmsLog
    {
        public int Id { get; set; }
        public int SmsType { get; set; }
        public string? SendPhone { get; set; }
        public string? Message { get; set; }
        public string? SmsId { get; set; }
        public double CostPoint { get; set; }
        public int? DeliveryStatus { get; set; }
        public string? ProcessMessage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? OrganizationId { get; set; }
        public Guid? AccountGid { get; set; }
        public string? Name { get; set; }

        public virtual Account? AccountG { get; set; }
    }
}
