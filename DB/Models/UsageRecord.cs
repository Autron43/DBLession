
using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{

  public class UsageRecord
  {
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// 紀錄的物件ID
    /// </summary>
    [MaxLength(36)]
    public string ObjectId { get; set; }
    /// <summary>
    /// 物件型態
    /// </summary>
    public ObjectType ObjectType { get; set; }
    /// <summary>
    /// 使用者帳號的GID
    /// </summary>
    public Guid AccountGid { get; set; }
    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }
  }
}