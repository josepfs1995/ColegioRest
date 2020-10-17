using Azure.Api.Core.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core.Entidades
{
  public class Matricula: IAggregateRoot
  {
    public Guid Id { get; set; }
    public Guid Id_Alumno { get; set; }
    public DateTime FechaMatricula { get; set; }
    public Alumno Alumno { get; set; }
    public IEnumerable<Matricula_Detalle> Matricula_Detalle { get; set; }
  }
}
