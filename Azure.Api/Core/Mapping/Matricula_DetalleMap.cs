using Azure.Api.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core.Mapping
{
  public class Matricula_DetalleMap : IEntityTypeConfiguration<Matricula_Detalle>
  {
    public void Configure(EntityTypeBuilder<Matricula_Detalle> builder)
    {
      builder.HasKey(x => x.Id);

      builder.HasOne(m => m.Matricula)
        .WithMany(a => a.Matricula_Detalle)
        .HasForeignKey(x => x.Id_Matricula);

      builder.HasOne(m => m.Curso)
       .WithMany(a => a.Matricula_Detalle)
       .HasForeignKey(x => x.Id_Curso);
    }
  }
}
