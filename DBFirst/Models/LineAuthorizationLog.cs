using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class LineAuthorizationLog
    {
        public int Id { get; set; }
        public string? LineUserId { get; set; }
        public int OrgId { get; set; }
        public int ChannelOrgId { get; set; }
        public int? PatientGroupId { get; set; }
        public bool Completed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? CovidPatient { get; set; }
    }
}
