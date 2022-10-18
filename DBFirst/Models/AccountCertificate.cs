using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AccountCertificate
    {
        public int Id { get; set; }
        public int CertiType { get; set; }
        public string? CertificatedContent { get; set; }
        public string? CertificateContent { get; set; }
        public string? Code { get; set; }
        public DateTime ExpiryAt { get; set; }
        public DateTime? CertificateAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid AccountGid { get; set; }

        public virtual Account AccountG { get; set; } = null!;
    }
}
