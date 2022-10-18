using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class LineLoginToken
    {
        public int Id { get; set; }
        public string? LineUserId { get; set; }
        public string? Token { get; set; }
        public DateTime ExpiredAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
