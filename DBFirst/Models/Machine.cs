using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Machine
    {
        public Machine()
        {
            AccountKpiMachines = new HashSet<AccountKpiMachine>();
            MachineHisLogs = new HashSet<MachineHisLog>();
            MachineStatusLogs = new HashSet<MachineStatusLog>();
            MachineUsageLogs = new HashSet<MachineUsageLog>();
            ProductSerials = new HashSet<ProductSerial>();
            SatisfactionSurveys = new HashSet<SatisfactionSurvey>();
            VitalSigns = new HashSet<VitalSign>();
        }

        public int Id { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? LastTestDate { get; set; }
        public DateTime? LastTestDateO2 { get; set; }
        public string? Macaddress { get; set; }
        public string? SystemVersion { get; set; }
        public string? SystemSerialNo { get; set; }
        public string? DeviceSerialNo { get; set; }
        public bool RootStatus { get; set; }
        public string? MachineNotifyToken { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Available { get; set; }
        public int? OrganizationId { get; set; }

        public virtual Organization? Organization { get; set; }
        public virtual MachineInfo? MachineInfo { get; set; }
        public virtual ICollection<AccountKpiMachine> AccountKpiMachines { get; set; }
        public virtual ICollection<MachineHisLog> MachineHisLogs { get; set; }
        public virtual ICollection<MachineStatusLog> MachineStatusLogs { get; set; }
        public virtual ICollection<MachineUsageLog> MachineUsageLogs { get; set; }
        public virtual ICollection<ProductSerial> ProductSerials { get; set; }
        public virtual ICollection<SatisfactionSurvey> SatisfactionSurveys { get; set; }
        public virtual ICollection<VitalSign> VitalSigns { get; set; }
    }
}
