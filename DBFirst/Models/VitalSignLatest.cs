using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class VitalSignLatest
    {
        public Guid AccountGid { get; set; }
        public int? Systolic { get; set; }
        public int? Diastolic { get; set; }
        public int? Pulse { get; set; }
        public DateTime? PressureTestTime { get; set; }
        public double? BodyHeight { get; set; }
        public double? BodyWeight { get; set; }
        public double? Bmi { get; set; }
        public DateTime? HeightWeightTestTime { get; set; }
        public double? BodyTemp { get; set; }
        public DateTime? BodyTempTestTime { get; set; }
        public int? O2 { get; set; }
        public DateTime? BloodO2testTime { get; set; }
        public int? BloodSugar { get; set; }
        public int? SugarStatus { get; set; }
        public DateTime? BloodSugarTestTime { get; set; }
        public double? BodyFat { get; set; }
        public double? VatLevel { get; set; }
        public DateTime? BodyFatTestTime { get; set; }
        public double? GripStr { get; set; }
        public DateTime? GripStrTestTime { get; set; }
        public double? UricAcid { get; set; }
        public DateTime? UricAcidTestTime { get; set; }
        public double? Cholesterol { get; set; }
        public DateTime? CholesterolTestTime { get; set; }
        public double? Ketone { get; set; }
        public DateTime? KetoneTestTime { get; set; }
        public double? Hb { get; set; }
        public DateTime? HbTestTime { get; set; }
        public double? Hct { get; set; }
        public DateTime? HctTestTime { get; set; }
        public string? Atk { get; set; }
        public DateTime? AtkTestTime { get; set; }
        public int? AtkSource { get; set; }
        public int? BloodO2source { get; set; }
        public int? BloodSugarSource { get; set; }
        public int? BodyFatSource { get; set; }
        public int? BodyTempSource { get; set; }
        public int? CholesterolSource { get; set; }
        public int? GripStrSource { get; set; }
        public int? HbSource { get; set; }
        public int? HctSource { get; set; }
        public int? HeightWeightSource { get; set; }
        public int? KetoneSource { get; set; }
        public int? PressureSource { get; set; }
        public int? UricAcidSource { get; set; }
        public int? AtkApprovedStatus { get; set; }

        public virtual Account AccountG { get; set; } = null!;
    }
}
