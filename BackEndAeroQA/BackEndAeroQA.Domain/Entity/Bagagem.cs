namespace BackEndAeroQA.Domain.Entity
{
    public class Bagagem : baseEntity
    {
        public string Descricao { get; set; }
        public double Peso { get; set; }
        public bool Extraviada { get; set; }
        public string CpfPassageiro { get; set; }
    }
}
