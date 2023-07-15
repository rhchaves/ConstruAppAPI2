using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ConstruAppAPI.Models
{
    public class UserIdentity : IdentityUser
    {
        [Required(ErrorMessage = "O campo UserName é obrigatório.")]
        [StringLength(50, ErrorMessage = "O UserName deve ter entre 3 e 50 caracteres", MinimumLength = 3)]
        public override string UserName { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo deve ser um endereço de e-mail válido.")]
        public override string Email { get; set; }
        
        [Required(ErrorMessage = "O campo PhoneNumber é obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo PhoneNumber deve ter 11 dígitos.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O campo deve estar no formato: 11555554444")]
        public override string PhoneNumber { get; set; }

    }
}
