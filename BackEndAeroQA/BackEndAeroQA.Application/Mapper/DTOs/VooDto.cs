using BackEndAeroQA.Domain.Enum;
using System.Globalization;

namespace BackEndAeroQA.Application.Mapper.Mappings
{
    public class VooDto
    {
        public Guid Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public int NumeroDoVoo { get; set; }
        public DateTime DataHoraDePartida { get; set; } = DateTime.ParseExact("2016-05-08", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        public DateTime DataHoraDeChegada { get; set; } = DateTime.ParseExact("2016-05-08", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        public TipoDeClasses Tipo { get; set; }
        public int QuantidadeDosAssentos { get; set; }
        public List<string> Passageiros { get; set; }
        public double ValorDoAssento { get; set; }

        public VooDto()
        {
            Id = Guid.NewGuid();
        }
    }
}
