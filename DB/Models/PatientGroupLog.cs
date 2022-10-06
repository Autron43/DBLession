
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{

  public class PatientGroupLog
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 共照群Id
    /// </summary>
    public int PatientGroupId { get; set; }

    /// <summary>
    /// 成員Gid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 操作
    /// </summary>
    public PatientGroupOperation Operation { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }
  }

}