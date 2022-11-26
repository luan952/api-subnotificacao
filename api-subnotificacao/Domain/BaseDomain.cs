namespace api_subnotificacao.Domain
{
  public class BaseDomain
  {
    public BaseDomain()
    {
      Id = Guid.NewGuid();
      CreatedAt = DateTime.Now;
    }
    public Guid Id { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? CreatedAt { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
  }
}