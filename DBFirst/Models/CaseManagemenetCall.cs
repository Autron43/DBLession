using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class CaseManagemenetCall
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public string? Content { get; set; }
        public string? FirebaseId { get; set; }
        public int? OrganizationId { get; set; }
        public int HealthCallType { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? ModUser { get; set; }
        public string? Title { get; set; }

        public virtual Account? CreatedByNavigation { get; set; }
    }
}
