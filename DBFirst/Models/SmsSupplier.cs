using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class SmsSupplier
    {
        public SmsSupplier()
        {
            Organizations = new HashSet<Organization>();
            SmsParameters = new HashSet<SmsParameter>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Account { get; set; }
        public string? Password { get; set; }
        public string? SendUrl { get; set; }
        public string? CostUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<SmsParameter> SmsParameters { get; set; }
    }
}
