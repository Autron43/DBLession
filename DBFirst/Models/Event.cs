using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Event
    {
        public Event()
        {
            EventApplications = new HashSet<EventApplication>();
        }

        public int Id { get; set; }
        public string? EventName { get; set; }
        public bool Application { get; set; }
        public DateTime ApplyStartTime { get; set; }
        public DateTime ApplyEndTime { get; set; }
        public int? Limit { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Location { get; set; }
        public decimal? Price { get; set; }
        public int Status { get; set; }
        public string? Content { get; set; }
        public string? CoverUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public int OrganizationId { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<EventApplication> EventApplications { get; set; }
    }
}
