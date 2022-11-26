namespace api_subnotificacao.Domain
{
    public class BaseUser : BaseDomain
    {
        public string Cpf { get; set; }
        public string phone { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}