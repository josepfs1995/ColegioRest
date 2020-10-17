using Azure.Api.Core.Entidades;
using Azure.Api.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core.Repository
{
  public class AlumnoRepository:GenericRepository<Alumno>,IAlumnoRepository
  {
    private readonly ColegioContext _context;
    public AlumnoRepository(ColegioContext context):base(context)
    {
      _context = context;
    }
  }
}
