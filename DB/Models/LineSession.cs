
using DB.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
  public class LineSession
  {
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string LineUserId { get; set; }
    public int OrgId { get; set; }
    public string UserName { get; set; }
    public string Mobile { get; set; }
    public AccountGender? Gender { get; set; }
    public DateTime? Birthday { get; set; }
    public bool Completed { get; set; } = false;
    public bool Register { get; set; } = false;
    /// <summary>
    /// session狀態
    /// </summary>
    public LineSessionStatus Status { get; set; }
    /// <summary>
    /// session狀態補充描述
    /// </summary>
    public string StatusDesc { get; set; }
    /// <summary>
    /// 通用string數值紀錄區
    /// </summary>
    public string StringInput1 { get; set; }
    /// <summary>
    /// 通用string數值紀錄區
    /// </summary>
    public string StringInput2 { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }


}
