using Microsoft.EntityFrameworkCore;

namespace Nova_Vida_Tecnologia___Teste_Programador_ASP.NET.Models
{
    
    public class ProfessorDbContext : DbContext
    {
        public ProfessorDbContext(DbContextOptions<ProfessorDbContext> options)
        : base(options)
        { }
        public DbSet<Professores> Professores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
