using System;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class CoderhouseContext : DbContext
{
    public DbSet<Producto> Productos { get; set; }

    public DbSet<Usuario> Usuarios { get; set; }

    public CoderhouseContext()
        : base() { }

    public CoderhouseContext(DbContextOptions<CoderhouseContext> options)
        : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
            "Data Source=10.0.2.2;Initial Catalog=CoderhouseCapas;User ID=sa;Password=Str0ngPassword;TrustServerCertificate=True"
        );
    }    
    }
}
