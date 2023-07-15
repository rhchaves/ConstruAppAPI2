using System.ComponentModel.DataAnnotations;

namespace ConstruAppAPI.Models
{
    public class UserClient
    {
        [Key]
        public string UserClientId { get; set; }

        [Required(ErrorMessage = "O campo UserId é obrigatório.")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "O campo Nome Completo é obrigatório.")]
        [StringLength(50, ErrorMessage = "O Nome Completo deve ter entre 3 e 50 caracteres", MinimumLength = 3)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [StringLength(11, ErrorMessage = "O CPF deve ter 11 caracteres", MinimumLength = 11)]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo Rua é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo Rua deve ter entre 3 e 50 caracteres", MinimumLength = 3)]
        public string Street { get; set; }

        [Required(ErrorMessage = "O campo Número é obrigatório.")]
        [StringLength(10, ErrorMessage = "O campo Número deve ter entre 1 e 10 caracteres", MinimumLength = 1)]
        public string Number { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        [StringLength(8, ErrorMessage = "O CEP deve ter 8 caracteres", MinimumLength = 8)]
        public string ZipCode { get; set; }
        public string? Complemnt { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo Bairro deve ter entre 3 e 50 caracteres", MinimumLength = 3)]
        public string District { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo Cidade deve ter entre 3 e 50 caracteres", MinimumLength = 3)]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo Estado é obrigatório.")]
        [StringLength(2, ErrorMessage = "O Estado deve ter 2 caracteres", MinimumLength = 2)]
        public string State { get; set; }

        [MinLength(1), MaxLength(1)]
        public int Status { get; set; }
    }
}
