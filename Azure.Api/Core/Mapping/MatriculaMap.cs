using Azure.Api.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core.Mapping
{
  public class MatriculaMap : IEntityTypeConfiguration<Matricula>
  {
    public void Configure(EntityTypeBuilder<Matricula> builder)
    {
      builder.HasKey(x => x.Id);

      builder.HasOne(m => m.Alumno)
        .WithMany(a => a.Matriculas)
        .HasForeignKey(x => x.Id_Alumno);
    }
  }
}
