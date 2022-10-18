using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AccessLog
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public string? Device { get; set; }
        public int? LoginType { get; set; }
        public string? Uri { get; set; }
        public string? Action { get; set; }
        public string? Ip { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
