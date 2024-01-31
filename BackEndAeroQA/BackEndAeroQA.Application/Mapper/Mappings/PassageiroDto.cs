using System.Globalization;

namespace BackEndAeroQA.Application.Mapper.Mappings
{
    public class PassageiroDto 
    {
        public Guid Id { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public List<string>? VoosComprados { get; set; }
        public DateTime DataDeNascimento { get; set; } = DateTime.ParseExact("2016-05-08", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        public string Email { get; set; }

        public PassageiroDto()
        {
            Id = Guid.NewGuid();
        }
    }
}
