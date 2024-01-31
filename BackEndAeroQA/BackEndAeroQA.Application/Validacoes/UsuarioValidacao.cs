using BackEndAeroQA.Domain.Entity;
using FluentValidation;

namespace BackEndAeroQA.Application.Validacoes
{
    public class UsuarioValidacao : AbstractValidator<Usuario>
    {
        public UsuarioValidacao()
        {
            RuleFor(customer => customer.Email).NotNull().NotEmpty().WithMessage("O e-mail é obrigatório.");
            RuleFor(customer => customer.Senha).NotNull().NotEmpty().WithMessage("A senha é obrigatória.");

            RuleFor(p => p).Must(BeValid).WithMessage("A validação específica do usuário falhou.");
        }

        private bool BeValid(Usuario usuario)
        {
            if (usuario.DataCadastro < usuario.DataInativacao)
            {
                return false;
            }

            return true;
        }
    }
}
