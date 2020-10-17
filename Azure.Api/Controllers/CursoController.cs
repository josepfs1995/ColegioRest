using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Api.Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Azure.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CursoController : ControllerBase
  {
    private readonly ICursoRepository _cursoRepository;
    public CursoController(ICursoRepository cursoRepository)
    {
      _cursoRepository = cursoRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var curso = await _cursoRepository.Get();
      return Ok(curso);
    }
  }
}