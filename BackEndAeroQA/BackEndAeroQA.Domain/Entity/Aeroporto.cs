namespace BackEndAeroQA.Domain.Entity
{
    public class Aeroporto
    {
        public Guid Id { get; set; } 
        public int Codigo { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}
