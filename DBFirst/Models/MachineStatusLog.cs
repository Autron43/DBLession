using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class MachineStatusLog
    {
        public int Id { get; set; }
        public bool? Charging { get; set; }
        public string? NetworkType { get; set; }
        public int? LogoutTime { get; set; }
        public string? CurrentActivity { get; set; }
        public int? UsbTotal { get; set; }
        public bool? HeightWeightDevice { get; set; }
        public string? CardDevice { get; set; }
        public string? BodyTempDevice { get; set; }
        public string? Spo2Device { get; set; }
        public string? BloodPressurePort { get; set; }
        public string? HeightWeightPort { get; set; }
        public int? BatteryLevel { get; set; }
        public int? BatteryTemp { get; set; }
        public int? BatteryCurrent { get; set; }
        public string? Boot { get; set; }
        public int? MemoryUsage { get; set; }
        public string? MobileTraffic { get; set; }
        public string? TotalTraffic { get; set; }
        public string? AppVer { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int MachineId { get; set; }

        public virtual Machine Machine { get; set; } = null!;
    }
}
