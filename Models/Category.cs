using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ConstruAppAPI.Models

{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>(); // inicializa o objeto Products com uma coleção de produtos
        }
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "O campo Name(Nome para registro) é obrigatório.")]
        [StringLength(50, ErrorMessage = "O Nome da categoria deve ter entre 3 e 50 caracteres", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Label(Nome para exibição) é obrigatório.")]
        [StringLength(50, ErrorMessage = "O Label deve ter entre 3 e 50 caracteres", MinimumLength = 3)]
        public string Label { get; set; }

        [StringLength(256, ErrorMessage = "A URI da Imagem deve ter entre 10 e 256 caracteres", MinimumLength = 10)]
        public string? ImageURL { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}