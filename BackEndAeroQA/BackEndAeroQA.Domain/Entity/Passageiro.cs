namespace BackEndAeroQA.Domain.Entity
{
    public class Passageiro
    {
        public Guid Id { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Email { get; set; }

        public Passageiro()
        {
            Id = Guid.NewGuid();
        }
    }
}
