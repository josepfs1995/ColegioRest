using System;
using System.Threading.Tasks;
using Azure.Api.Core.Entidades;
using Azure.Api.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Azure.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AlumnoController : ControllerBase
  {
    private readonly IAlumnoRepository _alumnoRepository;
    private readonly IConfiguration _configuration;
    public AlumnoController(IConfiguration configuration, IAlumnoRepository alumnoRepository)
    {
      _configuration = configuration;
      _alumnoRepository = alumnoRepository;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      //var connectionString = _configuration["KeyJWT"];


      var alumnos = await _alumnoRepository.Get();
      return Ok(alumnos);
    }
    [HttpPost]
    public IActionResult Post(Alumno model)
    {
      model.Id = Guid.NewGuid();
      _alumnoRepository.Add(model);
      return Ok(model.Id);
    }
    [HttpPut]
    public IActionResult Put(Alumno model)
    {
      _alumnoRepository.Update(model);
      return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
      _alumnoRepository.Delete(id);
      return Ok();
    }
  }
}