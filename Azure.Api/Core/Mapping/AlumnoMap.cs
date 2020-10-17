using Azure.Api.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core.Mapping
{
  public class AlumnoMap : IEntityTypeConfiguration<Alumno>
  {
    public void Configure(EntityTypeBuilder<Alumno> builder)
    {
      builder.HasKey(x => x.Id);
      
      builder.Property(x => x.FechaNacimiento)
        .HasColumnType("Date");

      builder.Property(x => x.Nombre)
        .HasColumnType("Varchar(20)");

      builder.Property(x => x.Apellido)
        .HasColumnType("Varchar(40)");
    }
  }
}
