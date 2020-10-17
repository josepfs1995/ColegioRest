using AutoMapper;
using Azure.Api.Core.Entidades;
using Azure.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Mapper
{
  public class EntityToViewModelProfile:Profile
  {
    public EntityToViewModelProfile()
    {
      CreateMap<Alumno, AlumnoViewModel>();
      CreateMap<Curso, CursoViewModel>();
      CreateMap<Matricula, MatriculaViewModel>();
      CreateMap<Matricula_Detalle, Matricula_DetalleViewModel>();
    }
  }
}
