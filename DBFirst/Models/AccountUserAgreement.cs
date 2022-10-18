using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class AccountUserAgreement
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public int AgreementType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CanceledAt { get; set; }

        public virtual Account AccountG { get; set; } = null!;
    }
}
