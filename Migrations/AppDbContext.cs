using Microsoft.EntityFrameworkCore;

namespace Migrations.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }
    public DbSet<Aluno> Alunos { get; set; }
}

public class Aluno
{
    public int Id { get; set; }
    public string ? Nome { get; set; }
}