using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class KpiMachineReportDetail
    {
        public DateTime StatsAt { get; set; }
        public int MachineId { get; set; }
        public string? MachineName { get; set; }
        public int Newborns { get; set; }
        public int RegisteredUniqueUsers { get; set; }
        public int BloodPressureTestTimes { get; set; }
        public int TemperatureTestTimes { get; set; }
        public int WeightTestTimes { get; set; }
        public int HeightTestTimes { get; set; }
        public int O2testTimes { get; set; }
        public int BloodsugarTestTimes { get; set; }
        public int BodyfatTestTimes { get; set; }
        public int UsedTimes { get; set; }
        public int GuestUsedTimes { get; set; }
        public int RegisteredUsedTimes { get; set; }
        public int RegisteredidUsedTimes { get; set; }
        public int RegisteredcardUsedTimes { get; set; }
        public int RegisterednhiUsedTimes { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
