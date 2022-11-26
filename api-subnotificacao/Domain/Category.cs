namespace api_subnotificacao.Domain
{
    public class Category : BaseDomain
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<SubCategory> SubCategory { get; set; }
    }
}