using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuProject.Models

{
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAnimal { get; set; }
        [Required(ErrorMessage = "O nome do animal é obrigatório")]
        [StringLength(50, ErrorMessage = "A nome deve ter no máximo 50 caracteres")]
        [Display(Name = "Nome:")]
        public string Nome { get; set; }
        public string Especie { get; set; }
        public float Peso { get; set; }
    }
}