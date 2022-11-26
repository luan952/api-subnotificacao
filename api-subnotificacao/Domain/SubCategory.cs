namespace api_subnotificacao.Domain
{
    public class SubCategory : BaseDomain
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}