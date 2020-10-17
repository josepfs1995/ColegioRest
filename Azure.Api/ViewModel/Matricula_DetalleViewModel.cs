using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.ViewModel
{
  public class Matricula_DetalleViewModel
  {
    public Guid Id { get; set; }
    public Guid Id_Matricula { get; set; }
    public Guid Id_Curso { get; set; }
    public CursoViewModel Curso { get; set; }
  }
}
