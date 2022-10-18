using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class LineSession
    {
        public int Id { get; set; }
        public string? LineUserId { get; set; }
        public int OrgId { get; set; }
        public string? Mobile { get; set; }
        public DateTime? Birthday { get; set; }
        public bool Completed { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Gender { get; set; }
        public bool? Register { get; set; }
        public string? UserName { get; set; }
        public int Status { get; set; }
        public string? StatusDesc { get; set; }
        public string? StringInput1 { get; set; }
        public string? StringInput2 { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
