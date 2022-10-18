using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AccountInformation
    {
        public int Id { get; set; }
        public byte[]? Avatar { get; set; }
        public string? Email { get; set; }
        public int Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public int Blood { get; set; }
        public string? CardNo { get; set; }
        public string? IdentityNo { get; set; }
        public string? Mobile { get; set; }
        public int RegisterSource { get; set; }
        public string? Address { get; set; }
        public string? Language { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid AccountGid { get; set; }
        public string? ParticularBloodType { get; set; }
        public string? Tel { get; set; }
        public string? RegisterFrom { get; set; }
        public string? County { get; set; }
        public string? District { get; set; }
        public string? ZipCode { get; set; }
        public DateTime? CovidIdentifiedAt { get; set; }
        public string? NidrsCode { get; set; }

        public virtual Account AccountG { get; set; } = null!;
    }
}
