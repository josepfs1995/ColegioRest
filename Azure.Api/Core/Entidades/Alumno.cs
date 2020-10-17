using Azure.Api.Core.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core.Entidades
{
  public class Alumno : IAggregateRoot
  {
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public IEnumerable<Matricula> Matriculas { get; set; }
  }
}
