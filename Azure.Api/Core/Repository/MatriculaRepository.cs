using Azure.Api.Core.Entidades;
using Azure.Api.Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core.Repository
{
  public class MatriculaRepository:GenericRepository<Matricula>, IMatriculaRepository
  {
    private readonly ColegioContext _context;
    public MatriculaRepository(ColegioContext context) : base(context)
    {
      _context = context;
    }

    public override async Task<IEnumerable<Matricula>> Get()
    {
      return await _context.Matricula
                      .Include(x => x.Alumno)
                      .Include(x => x.Matricula_Detalle)
                        .ThenInclude(md=>md.Curso)
                    .ToListAsync();
    }
  }
}
