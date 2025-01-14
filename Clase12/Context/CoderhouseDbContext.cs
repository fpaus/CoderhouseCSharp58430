﻿using Clase12.Models;
using Microsoft.EntityFrameworkCore;


namespace Clase12.Context;

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
        optionsBuilder.UseSqlServer("Data Source=10.0.2.2;Initial Catalog=Coderhouse;User ID=sa;Password=Str0ngPassword;TrustServerCertificate=True");
    }

}

