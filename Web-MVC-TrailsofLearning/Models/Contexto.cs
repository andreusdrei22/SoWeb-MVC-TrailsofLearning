using Microsoft.EntityFrameworkCore;

namespace Web_MVC_TrailsofLearning.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
