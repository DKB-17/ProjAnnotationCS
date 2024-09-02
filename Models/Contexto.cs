using Microsoft.EntityFrameworkCore;

namespace ProjAnnotation.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) {}

        public DbSet<Curso> Cursos { get; set; }
    }
}
