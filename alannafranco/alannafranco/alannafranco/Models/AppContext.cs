using System.Data.Entity;

namespace alannafranco.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("name=AppContext")
        {
        }

        public System.Data.Entity.DbSet<Genero> Generos { get; set; }
        public System.Data.Entity.DbSet<Autor> Autores { get; set; }
        public System.Data.Entity.DbSet<Livro> Livros { get; set; }
    }
}