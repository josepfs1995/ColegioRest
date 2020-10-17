using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core.Entidades
{
  public class Matricula_Detalle
  {
    public Guid Id { get; set; }
    public Guid Id_Matricula { get; set; }
    public Guid Id_Curso { get; set; }
    public Matricula Matricula { get; set; }
    public Curso Curso { get; set; }
  }
}
