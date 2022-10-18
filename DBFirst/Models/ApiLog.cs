using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ApiLog
    {
        public int Id { get; set; }
        public string? Method { get; set; }
        public string? Uri { get; set; }
        public string? Input { get; set; }
        public string? Headers { get; set; }
        public Guid? AccountGid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
