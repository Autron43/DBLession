using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class SmsParameter
    {
        public int Id { get; set; }
        public int SmsSupplierId { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public int Sort { get; set; }

        public virtual SmsSupplier SmsSupplier { get; set; } = null!;
    }
}
