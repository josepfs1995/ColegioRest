using Azure.Api.Core.Entidades;
using Azure.Api.Core.Mapping;
using Azure.Api.Core.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core
{
  public class ColegioContext:DbContext
  {
    public DbSet<Alumno> Alumno { get; set; }
    public DbSet<Curso> Curso { get; set; }
    public DbSet<Matricula> Matricula { get; set; }
    public DbSet<Matricula_Detalle> Matricula_Detalle { get; set; }
    public ColegioContext(DbContextOptions<ColegioContext> options):base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new AlumnoMap());
      modelBuilder.ApplyConfiguration(new CursoMap());
      modelBuilder.ApplyConfiguration(new MatriculaMap());
      modelBuilder.ApplyConfiguration(new Matricula_DetalleMap());
      modelBuilder.Seed();
      base.OnModelCreating(modelBuilder);
    }
  }
}
