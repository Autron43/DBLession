
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class MachineStatusLog
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 是否充電
    /// </summary>
    public bool? Charging { get; set; }

    /// <summary>
    /// 網路連接類型
    /// </summary>
    [MaxLength(20)]
    public string NetworkType { get; set; }

    /// <summary>
    /// 登出時間
    /// </summary>
    public int? LogoutTime { get; set; }

    /// <summary>
    /// 目前頁面
    /// </summary>
    [MaxLength(50)]
    public string CurrentActivity { get; set; }

    /// <summary>
    /// USB總數量
    /// </summary>
    public int? UsbTotal { get; set; }

    /// <summary>
    /// 是否有身高體重設備
    /// </summary>
    public bool? HeightWeightDevice { get; set; }

    /// <summary>
    /// 讀卡設備
    /// </summary>
    [MaxLength(20)]
    public string CardDevice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [MaxLength(30)]
    public string BodyTempDevice { get; set; }

    /// <summary>
    /// 血氧設備
    /// </summary>
    [MaxLength(30)]
    public string Spo2Device { get; set; }

    /// <summary>
    /// 血壓設備使用端口
    /// </summary>
    [MaxLength(150)]
    public string BloodPressurePort { get; set; }

    /// <summary>
    /// 身高體重設備使用端口
    /// </summary>
    [MaxLength(150)]
    public string HeightWeightPort { get; set; }

    /// <summary>
    /// 設備電量
    /// </summary>
    public int? BatteryLevel { get; set; }

    /// <summary>
    /// 設備溫度
    /// </summary>
    public int? BatteryTemp { get; set; }

    /// <summary>
    /// 電流
    /// </summary>
    public int? BatteryCurrent { get; set; }

    /// <summary>
    /// 開機回報資訊
    /// </summary>
    [MaxLength(30)]
    public string Boot { get; set; }

    /// <summary>
    /// 記憶體使用量
    /// </summary>
    public int? MemoryUsage { get; set; }

    /// <summary>
    /// 行動網路傳輸量
    /// </summary>
    [MaxLength(15)]
    public string MobileTraffic { get; set; }

    /// <summary>
    /// 總網路傳輸量
    /// </summary>
    [MaxLength(15)]
    public string TotalTraffic { get; set; }

    /// <summary>
    /// APP版本
    /// </summary>
    [MaxLength(20)]
    public string AppVer { get; set; }

    /// <summary>
    /// 設備IP位址
    /// </summary>
    [MaxLength(30)]
    public string IPAddress { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 設備Id
    /// </summary>
    public int MachineId { get; set; }

    #region 關聯

    [ForeignKey("MachineId")]
    public virtual Machine Machine { get; set; }

    #endregion
  }
}
