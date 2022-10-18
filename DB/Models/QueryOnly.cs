namespace DB.Models
{
  /// <summary>
  /// 本類別只用做查詢，不產生實際表單
  /// 
  /// 加入DbContext後，需要在OnModelCreating內指定 .HasNoKey().ToView(null)
  /// 例如：
  ///   
  ///   protected override void OnModelCreating(ModelBuilder modelBuilder)
  ///   {
  ///     modelBuilder.Entity【類別名稱】().HasNoKey().ToView(null);
  ///   }
  /// 
  /// </summary>
  public class QueryOnly
  {
  }

  public class IntQueryResult
  {
    public int Result { get; set; }
  }
}
