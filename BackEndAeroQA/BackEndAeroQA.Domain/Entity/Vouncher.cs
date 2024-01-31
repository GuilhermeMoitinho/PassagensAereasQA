using BackEndAeroQA.Domain.Enum;

namespace BackEndAeroQA.Domain.Entity
{
    public class Voucher : baseEntity
    {
        public int NumeroVoo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string NomePassageiro { get; set; }
        public string CpfPassageiro { get; set; }
        public PosuuiDespacho PossuiDespachoBagagem { get; set; }

        public Voucher()
        {
            Id = Guid.NewGuid();
        }
    }
}
