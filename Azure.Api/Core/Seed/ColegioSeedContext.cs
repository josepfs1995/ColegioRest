using Azure.Api.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using System;

namespace Azure.Api.Core.Seed
{
  public static class ColegioSeedContext
  {
    public static void Seed(this ModelBuilder builder)
    {
      builder.Entity<Alumno>().HasData(new Alumno
      {
        Id = new Guid("2396bc71-fc3b-4204-ac8d-d1df35cf904c"),
        Apellido = "Fuentes",
        Nombre = "Josep",
        FechaNacimiento = DateTime.Parse("23/08/1995")
      });

      builder.Entity<Curso>().HasData(new Curso
      {
        Id = new Guid("af4d5521-cfc1-4517-8763-f998269d1139"),
        Nombre = "Lenguaje"
      },
      new Curso
      {
        Id = new Guid("a3476a67-e06f-4e40-a15c-78f9f616e363"),
        Nombre = "Matematica"
      },
      new Curso
      {
        Id = new Guid("d07eec5b-c559-46a2-bab5-bda9cac1767c"),
        Nombre = "Ciencias"
      },
      new Curso
      {
        Id = new Guid("4436f676-07c0-4fac-994f-ed7a8e7dd7d7"),
        Nombre = "RR.HH"
      });
    }
  }
}
