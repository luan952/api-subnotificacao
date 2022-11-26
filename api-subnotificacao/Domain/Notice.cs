namespace api_subnotificacao.Domain
{
    public class Notice : BaseDomain
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Admin Admin { get; set; }
        public Guid AdminId { get; set; }
        public List<SubCategory> SubCategories { get; set; }
        
    }
}