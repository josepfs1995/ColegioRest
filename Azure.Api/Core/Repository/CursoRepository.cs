using Azure.Api.Core.Entidades;
using Azure.Api.Core.Interface;

namespace Azure.Api.Core.Repository
{
  public class CursoRepository:GenericRepository<Curso>,ICursoRepository
  {
    private readonly ColegioContext _context;
    public CursoRepository(ColegioContext context):base(context)
    {
      _context = context;
    }
  }
}
