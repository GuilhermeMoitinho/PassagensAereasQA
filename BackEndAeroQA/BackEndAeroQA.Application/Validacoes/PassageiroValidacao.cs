using BackEndAeroQA.Application.Mapper.Mappings;
using BackEndAeroQA.Domain.Entity;
using FluentValidation;

namespace BackEndAeroQA.Application.Validacoes
{
    public class PassageiroValidacao : AbstractValidator<PassageiroDto>
    {
        public PassageiroValidacao()
        {
            RuleFor(customer => customer.Cpf).NotNull().WithMessage("O CPF é obrigatório.");
            RuleFor(customer => customer.Name).NotNull().WithMessage("O nome é obrigatório.");
            RuleFor(customer => customer.DataDeNascimento).NotNull().WithMessage("A data de nascimento é obrigatória.");
            RuleFor(customer => customer.Email).NotNull().WithMessage("O e-mail é obrigatório.").EmailAddress();

            RuleFor(p => p).Must(BeValid);
        }

        private bool BeValid(PassageiroDto passageiroDto)
        {
            if (passageiroDto.Name.Equals("string") || passageiroDto.Cpf.Equals("string") || passageiroDto.Email.Equals("string"))
            {
                return false;
            }

            if(passageiroDto.Cpf.Length > 11)
            {
                return false;
            }

            return true;
        }
    }
}
