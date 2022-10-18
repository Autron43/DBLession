using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AccountConfig
    {
        public int Id { get; set; }
        public bool IsAutoAuthed { get; set; }
        public string? PublicKey { get; set; }
        public string? OrgToken { get; set; }
        public string? LineUserId { get; set; }
        public string? AppleUserId { get; set; }
        public string? LineNotifyToken { get; set; }
        public string? EmployeeId { get; set; }
        public string? EmpCode { get; set; }
        public bool? ReceiveSms { get; set; }
        public string? SmsPhone { get; set; }
        public bool ReceiveUsageMail { get; set; }
        public bool ReceivePush { get; set; }
        public string? FaceBookAccessToken { get; set; }
        public string? FaceBookUserId { get; set; }
        public DateTime? FaceBookExpiryAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid AccountGid { get; set; }
        public string? DplusDeviceNo { get; set; }

        public virtual Account AccountG { get; set; } = null!;
    }
}
