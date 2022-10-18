
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class LineCustomKeywordResponse
  {
    public int Id { get; set; }
    public int OrgId { get; set; }
    public KeywordSearchType SearchType { get; set; }
    public string Keyword { get; set; }
    [Column("keywordRelatedFunction")] // 錯字修正，此行勿刪
    public string KeywordRelatedFunction { get; set; }
    public string KeywordResponse { get; set; }
    public string ResponseImage { get; set; }
    public RequiredDataType RequiredDataType { get; set; }
    public string TargetPatientGroup { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }

  public enum KeywordSearchType
  {
    Unknown = 0,
    Precise = 1,
    Fuzzy = 2
  }

  public enum RequiredDataType
  {
    NoResponse = -1,
    None = 0,
    Pressure = 1,
    BloodSugar = 2,
    Form = 3
  }
}
