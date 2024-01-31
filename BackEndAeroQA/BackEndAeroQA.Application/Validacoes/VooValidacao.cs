using BackEndAeroQA.Domain.Entity;
using FluentValidation;
using System;

namespace BackEndAeroQA.Application.Validacoes
{
    public class VooValidacao : AbstractValidator<Voo>
    {
        public VooValidacao()
        {
            RuleFor(customer => customer.NumeroDoVoo).NotNull().WithMessage("O número do voo é obrigatório.");
            RuleFor(customer => customer.ValorDoAssento).NotNull().WithMessage("O valor do assento é obrigatório.");
            RuleFor(customer => customer.Origem).NotNull().WithMessage("A origem é obrigatória.");
            RuleFor(customer => customer.Destino).NotNull().WithMessage("O destino é obrigatório.");
            RuleFor(customer => customer.DataHoraDePartida).NotNull().WithMessage("A data e hora de partida são obrigatórias.");
            RuleFor(customer => customer.DataHoraDeChegada).NotNull().WithMessage("A data e hora de chegada são obrigatórias.");
            RuleFor(customer => customer.Tipo).NotNull().WithMessage("O tipo é obrigatório.");
            RuleFor(customer => customer.QuantidadeDosAssentos).NotNull().WithMessage("A quantidade de assentos é obrigatória.");
            RuleFor(customer => customer.Passageiros).NotNull().WithMessage("A lista de passageiros é obrigatória.");

            RuleFor(p => p).Must(BeValid).WithMessage("A validação específica do voo falhou.");
        }

        private bool BeValid(Voo voo)
        {
            if (voo.DataHoraDePartida.Date < DateTime.Now)
            {
                return false;
            }

            if (voo.Origem.Equals("string"))
            {
                return false;
            }

            if (voo.DataHoraDeChegada.Date < voo.DataHoraDePartida.Date)
            {
                return false;
            }

            if (voo.NumeroDoVoo <= 0)
            {
                return false;
            }

            if (voo.Passageiros.Count > 60)
            {
                return false;
            }

            return true;
        }
    }
}
