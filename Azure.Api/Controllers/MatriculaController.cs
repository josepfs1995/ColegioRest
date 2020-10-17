using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Azure.Api.Core.Entidades;
using Azure.Api.Core.Interface;
using Azure.Api.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Azure.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MatriculaController : ControllerBase
  {
    private readonly IMapper _mapper;
    private readonly IMatriculaRepository _matriculaRepository;
    public MatriculaController(IMapper mapper, IMatriculaRepository matriculaRepository)
    {
      _mapper = mapper;
      _matriculaRepository = matriculaRepository;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var matricula = _mapper.Map<IEnumerable<MatriculaViewModel>>(await _matriculaRepository.Get());
      return Ok(matricula);
    }
    [HttpPost]
    public IActionResult Post(Matricula model)
    {
      model.Id = Guid.NewGuid();
      model.FechaMatricula = DateTime.UtcNow;
      _matriculaRepository.Add(model);
      return Ok(model.Id);
    }
    [HttpPut]
    public IActionResult Put(Matricula model)
    {
      _matriculaRepository.Update(model);
      return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
      _matriculaRepository.Delete(id);
      return Ok();
    }
  }
}