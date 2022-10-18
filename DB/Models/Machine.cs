
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class Machine
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// IP位置
    /// </summary>
    [MaxLength(30)]
    public string IPAddress { get; set; }

    /// <summary>
    /// 血壓，最後量測日期
    /// </summary>
    public DateTime? LastTestDate { get; set; }

    /// <summary>
    /// 血氧，最後量測日期
    /// </summary>
    public DateTime? LastTestDate_O2 { get; set; }

    /// <summary>
    /// 設備網卡位址
    /// </summary>
    [MaxLength(30)]
    public string MACAddress { get; set; }

    /// <summary>
    /// 系統版本
    /// </summary>
    [MaxLength(10)]
    public string SystemVersion { get; set; }

    /// <summary>
    /// 系統序號
    /// </summary>
    [MaxLength(50)]
    public string SystemSerialNo { get; set; }

    /// <summary>
    /// 裝置序號
    /// </summary>
    [MaxLength(50)]
    public string DeviceSerialNo { get; set; }

    /// <summary>
    /// 機台是否有Root
    /// </summary>
    public bool RootStatus { get; set; }

    /// <summary>
    /// 是否可用
    /// </summary>
    public bool Available { get; set; }

    /// <summary>
    /// 機台推播Token
    /// </summary>
    [MaxLength(200)]
    public string MachineNotifyToken { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 所屬機構Id
    /// </summary>
    public int? OrganizationId { get; set; }

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    public virtual MachineInfo MachineInfo { get; set; }

    public virtual ICollection<MachineStatusLog> MachineStatusLogs { get; set; }

    public virtual ICollection<MachineUsageLog> MachineUsageLogs { get; set; }

    #endregion

    // 備註:
    // 由於目前 App手動輸入 和 網頁手動輸入都需要一個專屬的設備代號(MachineId)
    // 搬遷資料庫或重新建置須注意是否有以下兩個設備:
    // 
    // 1. App手動輸入(App Manual Input): App新增紀錄時專用的設備代號，名稱可隨意，但是Id必須為1
    // 2. Web Manual Input: 即網頁新增紀錄時專用的設備代號，名稱必須相同('Web Manual Input')，Id可隨意 
  }
}
