using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AccountNotificationSetting
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public bool OrganizationMessage { get; set; }
        public bool CaseManagement { get; set; }
        public bool Course { get; set; }
        public bool FormRecommend { get; set; }
        public bool Event { get; set; }
        public bool Shop { get; set; }
        public bool VitalSign { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Account AccountG { get; set; } = null!;
    }
}
