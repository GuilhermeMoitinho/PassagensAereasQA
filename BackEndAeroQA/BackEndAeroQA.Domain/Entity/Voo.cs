using BackEndAeroQA.Domain.Entity;
using BackEndAeroQA.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

public class Voo : baseEntity
{
    public string Origem { get; set; }
    public string Destino { get; set; }
    [Column("NumeroDoVoo")]
    public int CodigoIATA { get; set; }
    public DateTime DataHoraDePartida { get; set; } = DateTime.ParseExact("2016-05-08", "yyyy-MM-dd", CultureInfo.InvariantCulture);
    public DateTime DataHoraDeChegada { get; set; } = DateTime.ParseExact("2016-05-08", "yyyy-MM-dd", CultureInfo.InvariantCulture);
    public TipoDeClasses Tipo { get; set; }
    public int QuantidadeDosAssentos { get; set; }
    public List<string> Passageiros { get; set; }
    public double ValorDoAssento { get; set; }

    public Voo()
    {
        Id = Guid.NewGuid();
    }
}
