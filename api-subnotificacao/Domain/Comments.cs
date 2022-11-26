namespace api_subnotificacao.Domain
{
    public class Comments : BaseDomain
    {
        public string Content { get; set; }
        public bool Aproved { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}