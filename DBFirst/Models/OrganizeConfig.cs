using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class OrganizeConfig
    {
        public int Id { get; set; }
        public bool Emp { get; set; }
        public int LogoType { get; set; }
        public bool MphrLogo { get; set; }
        public string? LogoText { get; set; }
        public string? ExtensionName { get; set; }
        public Guid? PageIdentity { get; set; }
        public string? FastGoOrgToken { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int OrganizationId { get; set; }
        public int? DefaultRoleId { get; set; }
        public int SmsPoint { get; set; }
        public int UserAgreementType { get; set; }
        public bool? MphrNavBrand { get; set; }
        public string? AppThemeName { get; set; }

        public virtual Organization Organization { get; set; } = null!;
    }
}
