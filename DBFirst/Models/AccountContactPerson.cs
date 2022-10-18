using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AccountContactPerson
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public Guid ContactPersonGid { get; set; }
        public bool ReceivePushNotification { get; set; }
        public bool ReceiveEmailReport { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
