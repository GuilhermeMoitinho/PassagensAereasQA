using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace BackEndAeroQA.Domain.Entity
{
    public class Passageiro : baseEntity
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public List<string>? VoosComprados { get; set; }
        public DateTime DataDeNascimento { get; set; } = DateTime.ParseExact("2016-05-08", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        public string Email { get; set; }

        public Passageiro()
        {
            Id = Guid.NewGuid();
        }
    }
}
