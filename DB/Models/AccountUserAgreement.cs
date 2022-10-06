
using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class AccountUserAgreement
  {
    public int Id { get; set; }

    public Guid AccountGid { get; set; }

    public UserAgreementType AgreementType { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? CanceledAt { get; set; }

    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion
  }
}
