using System.ComponentModel.DataAnnotations;

namespace BackEndAeroQA.Domain.Entity
{
    public class Usuario
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo de E-mail é obrigatório.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo de Senha é obrigatório.")]
        public string Senha { get; set; } = string.Empty;

        public DateTime? DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataInativacao { get; set; } = null;

        public Usuario()
        {
            Id = Guid.NewGuid();
        }
    }
}
