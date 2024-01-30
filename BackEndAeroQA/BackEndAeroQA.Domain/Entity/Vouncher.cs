namespace BackEndAeroQA.Domain.Entity
{
    public class Vouncher 
    {
        public int NumeroPassagem { get; set; }
        public int NumeroVoo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string NomePassageiro { get; set; }
        public bool PossuiDespachoBagagem { get; set; }
    }
}
