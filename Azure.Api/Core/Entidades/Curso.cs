using Azure.Api.Core.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core.Entidades
{
  public class Curso : IAggregateRoot
  {
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public IEnumerable<Matricula_Detalle> Matricula_Detalle { get; set; }
  }
}
