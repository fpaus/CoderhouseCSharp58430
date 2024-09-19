using Clase11.Models;
using Microsoft.EntityFrameworkCore;


namespace Clase11.Contexts;

public class CoderhouseDbContext : DbContext
{
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    public CoderhouseDbContext()
        : base() { }

    public CoderhouseDbContext(DbContextOptions<CoderhouseDbContext> options)
        : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=10.0.2.2;Initial Catalog=Preparacion;User ID=sa;Password=Str0ngPassword;TrustServerCertificate=True"
        );
    }
}

