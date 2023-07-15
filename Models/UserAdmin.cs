using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConstruAppAPI.Models
{
    public class UserAdmin
    {
        [Key]
        public string UserAdminId { get; set; }

        [Required(ErrorMessage = "O campo UserId é obrigatório.")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "O campo FullName é obrigatório.")]
        [StringLength(50, ErrorMessage = "O FullName deve ter entre 3 e 50 caracteres", MinimumLength = 3)]
        public string FullName { get; set; }
        
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [StringLength(11, ErrorMessage = "O CPF deve ter 11 caracteres", MinimumLength = 11)]
        public string CPF { get; set; }

        [MinLength(1), MaxLength(1)]
        public int Status { get; set; }
    }
}
