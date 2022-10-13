using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
    {
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Licencias> Licencias{get; set;}

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

    }