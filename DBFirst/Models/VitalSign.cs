using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class VitalSign
    {
        public int Id { get; set; }
        public int? Systolic { get; set; }
        public int? Diastolic { get; set; }
        public int? Pulse { get; set; }
        public int? O2 { get; set; }
        public double? BodyTemp { get; set; }
        public int? BloodSugar { get; set; }
        public int BloodStatus { get; set; }
        public int SugarStatus { get; set; }
        public double? BodyHeight { get; set; }
        public double? BodyWeight { get; set; }
        public double? Bmi { get; set; }
        public double? WaistLine { get; set; }
        public double? WaistReduce { get; set; }
        public double? BodyFat { get; set; }
        public double? VatLevel { get; set; }
        public int? Bmr { get; set; }
        public int? MetabolicAge { get; set; }
        public double? MuscleMass { get; set; }
        public double? BoneMass { get; set; }
        public double? BodyWaterMass { get; set; }
        public double? GripStr { get; set; }
        public double? UricAcid { get; set; }
        public double? Cholesterol { get; set; }
        public double? Ketone { get; set; }
        public string? EStethoscopeKey { get; set; }
        public DateTime MeasuredAt { get; set; }
        public int Source { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public int MachineId { get; set; }
        public Guid AccountGid { get; set; }
        public double? Hb { get; set; }
        public double? Hct { get; set; }
        public int MachineUsageLogId { get; set; }
        public int? AtkId { get; set; }
        public string? DeviceModel { get; set; }
        public string? AppleHealthId { get; set; }
        public string? GoogleFitId { get; set; }
        public Guid? SerialNo { get; set; }
        public double? LacticAcid { get; set; }
        public double? Triglyceride { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual AtkRecord? Atk { get; set; }
        public virtual Machine Machine { get; set; } = null!;
    }
}
