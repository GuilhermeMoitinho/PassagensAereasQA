using BackEndAeroQA.Domain.Enum;

public class Voo
{
    public Guid Id { get; set; }
    public string Origem { get; set; }
    public string Destino { get; set; }
    public DateTime DataHoraDePartida { get; set; }
    public DateTime DataHoraDeChegada { get; set; }
    public TipoDeClasses Tipo { get; set; }
    public int QuantidadeDosAssentos { get; set; }
    public double ValorDoAssento { get; set; }

    public Voo()
    {
        Id = Guid.NewGuid();
    }
}
