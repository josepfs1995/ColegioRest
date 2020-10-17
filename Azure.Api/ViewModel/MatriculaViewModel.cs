using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.ViewModel
{
  public class MatriculaViewModel
  {
    public Guid Id { get; set; }
    public Guid Id_Alumno { get; set; }
    public DateTime FechaMatricula { get; set; }
    public AlumnoViewModel Alumno { get; set; }
    public IEnumerable<Matricula_DetalleViewModel> Matricula_Detalle { get; set; }
  }
}
