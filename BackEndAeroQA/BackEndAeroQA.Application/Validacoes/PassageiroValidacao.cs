using BackEndAeroQA.Domain.Entity;
using FluentValidation;

namespace BackEndAeroQA.Application.Validacoes
{
    public class PassageiroValidacao : AbstractValidator<Passageiro>
    {
        public PassageiroValidacao()
        {
            RuleFor(customer => customer.Cpf).NotNull().WithMessage("O CPF é obrigatório.");
            RuleFor(customer => customer.Name).NotNull().WithMessage("O nome é obrigatório.");
            RuleFor(customer => customer.DataDeNascimento).NotNull().WithMessage("A data de nascimento é obrigatória.");
            RuleFor(customer => customer.Email).NotNull().WithMessage("O e-mail é obrigatório.").EmailAddress();

            RuleFor(p => p).Must(BeValid);
        }

        private bool BeValid(Passageiro passageiro)
        {
            if (passageiro.Name.Equals("string") || passageiro.Cpf.Equals("string") || passageiro.Email.Equals("string"))
            {
                return false;
            }

            return true;
        }
    }
}
