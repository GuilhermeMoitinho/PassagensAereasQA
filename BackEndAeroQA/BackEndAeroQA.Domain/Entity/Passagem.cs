namespace BackEndAeroQA.Domain.Entity
{
    public class Passagem : baseEntity
    {
        public int Numero { get; set; }
        public Passageiro Passageiro { get; set; }
        public Voo Voo { get; set; }
        public double Valor { get; set; }
        public bool PossuiDespachoBagagem { get; set; }

        public Passagem()
        {
            Id = Guid.NewGuid();
        }
    }
}
