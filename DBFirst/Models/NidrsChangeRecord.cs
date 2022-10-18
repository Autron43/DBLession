using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class NidrsChangeRecord
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public int Gender { get; set; }
        public string? Birthday { get; set; }
        public string? IdentityNo { get; set; }
        public string? Mobile { get; set; }
        public string? Tel { get; set; }
        public string? Address { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? AccountGid { get; set; }

        public virtual Account? AccountG { get; set; }
    }
}
