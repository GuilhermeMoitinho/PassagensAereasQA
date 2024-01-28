namespace BackEndAeroQA.Application.ServicoDeResposta
{
    public class ServiceResponseCompraDoVoo<T>
    {
        public bool ProcessoConcluido { get; set; }
        public Object Dados { get; set; }

        public string Mensagem { get; set; }
    }
}
