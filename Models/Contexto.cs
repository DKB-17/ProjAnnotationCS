using Microsoft.EntityFrameworkCore;

namespace ProjAnnotation.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) {}

        public DbSet<Curso> Cursos { get; set; } // lista de cursos
        public DbSet<Aluno> Alunos { get; set; } // lista de alunos
        public DbSet<Sala> Salas { get; set; } // lista de salas
        public DbSet<Atendimento> Atendimentos { get; set; } // lista de atendimento
    }
}
