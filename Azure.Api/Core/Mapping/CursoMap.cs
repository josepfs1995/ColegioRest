using Azure.Api.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Azure.Api.Core.Mapping
{
  public class CursoMap : IEntityTypeConfiguration<Curso>
  {
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
      builder.HasKey(x => x.Id);

      builder.Property(x => x.Nombre)
        .HasColumnType("Varchar(40)");
    }
  }
}
