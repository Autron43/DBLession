using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class OrganizationLineSetting
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string? ChannelAccessToken { get; set; }
        public string? DefaultMessage { get; set; }
        public string? BefriendWelcomeMessage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int NotifyType { get; set; }
        public string? LineOrgCode { get; set; }
        public string? ChannelId { get; set; }
    }
}
