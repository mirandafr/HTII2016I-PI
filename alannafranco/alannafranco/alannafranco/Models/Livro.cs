using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace alannafranco.Models
{
    [Table("livros")]
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 20, ErrorMessage = "O título deve ter entre 20 e 100 caracteres")]
        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "Gênero")]
        public Genero Genero { get; set; }

        public List<Autor> Autores { get; set; }
    }
}