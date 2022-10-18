using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public int TokenType { get; set; }
        public string Token { get; set; } = null!;
        public int ContentType { get; set; }
        public string? ContentId { get; set; }
        public string? Content { get; set; }
        public DateTime ExpectedTime { get; set; }
        public DateTime? PushTime { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid ReceiverGid { get; set; }
    }
}
