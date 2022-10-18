
using DB.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class MachineInfo
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 設備名稱
    /// </summary>
    [MaxLength(100)]
    public string Name { get; set; }

    /// <summary>
    /// 經度
    /// </summary>
    public float? Longitude { get; set; }

    /// <summary>
    /// 緯度
    /// </summary>
    public float? Latitude { get; set; }

    /// <summary>
    /// 據點機器環境(是否為測試機)
    /// </summary>
    public MachineEnvironment Environment { get; set; }

    /// <summary>
    /// 據點機器類型
    /// </summary>
    public MachineType Type { get; set; }

    /// <summary>
    /// SIM卡電話號碼
    /// </summary>
    [MaxLength(20)]
    public string SimPhoneNumber { get; set; }

    /// <summary>
    /// 縣市區域
    /// </summary>
    public string ZipCode { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// 雄健康專案
    /// </summary>
    public bool XJKProject { get; set; }

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
