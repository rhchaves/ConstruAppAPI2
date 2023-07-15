using System.ComponentModel.DataAnnotations;

namespace ConstruAppAPI.Models

{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "O campo Name(Nome para registro) é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Name deve ter entre 3 e 100 caracteres", MinimumLength = 3)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O campo Label(Nome para exibição) é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Label deve ter entre 3 e 100 caracteres", MinimumLength = 3)]
        public string? Label { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [StringLength(256, ErrorMessage = "A Descrição deve ter entre 10 e 256 caracteres", MinimumLength = 10)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "O campo Marca do Produto é obrigatório.")]
        [StringLength(30, ErrorMessage = "A marca deve ter entre 3 e 30 caracteres", MinimumLength = 3)]
        public string? ProductMark { get; set; }

        [Required(ErrorMessage = "O campo Preço é obrigatório.")]
        public decimal Price { get; set; }

        [StringLength(256, ErrorMessage = "A URI da Imagem deve ter entre 10 e 256 caracteres", MinimumLength = 10)]
        public string? ImageURL { get; set; }

        [MinLength(1), MaxLength(1)]
        public int Status { get; set; }

        public int StockQtd { get; set; }
        public int SoldQtd { get; set; }
        public DateTime CreateRegister { get; set; }
        public DateTime UpdateRegister { get; set; }

        [Required(ErrorMessage = "O campo CategoryId é obrigatório.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "O campo Category é obrigatório.")]
        public Category? Category { get; set; }
    }
}