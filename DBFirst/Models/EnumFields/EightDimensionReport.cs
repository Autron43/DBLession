using System.ComponentModel;

namespace DB.EnumFields
{
  public enum EightDimensionReportCategory
  {
    [Description("健康體位")]
    HealthLevel,

    [Description("肺結核防治")]
    TuberculosisPrevention,

    [Description("身體活動")]
    PhysicalActivity,

    [Description("網路成癮")]
    InternetAddiction,

    [Description("視力健康")]
    VisionHealth,

    [Description("睡眠健康")]
    SleepHealth,

    [Description("情緒健康")]
    MoodIndicator,

    [Description("遠離菸害")]
    SmokingHabits,

    [Description("握力測試")]
    Grip
  }

  public enum EightDimensionReportLabel
  {
    [Description("良好")]
    Green,

    [Description("欠佳")]
    Yellow,

    [Description("危險")]
    Red
  }
}
