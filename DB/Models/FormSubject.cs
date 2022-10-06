using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{
  public class FormSubject
  {
    [Key]
    public Guid Gid { get; set; }

    /// <summary>
    /// 填寫量表GID
    /// </summary>
    public int FormResponseId { get; set; }

    /// <summary>
    /// 受測人GID
    /// </summary>
    public Guid SubjectGid { get; set; }
  }
}
