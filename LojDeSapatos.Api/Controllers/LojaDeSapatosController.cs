using LojDeSapatos.Application.InputModels;
using LojDeSapatos.Application.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LojDeSapatos.Api.Controllers
{
  [ApiController]
  [Route("api/sapato")]
  public class LojaDeSapatosController : ControllerBase
  {
    private readonly ISapatoService _sapatoService;
    public LojaDeSapatosController(ISapatoService sapatoService)
    {
      _sapatoService = sapatoService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
      var sapatos = _sapatoService.GetAll();
      return Ok(sapatos);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
      var sapato = _sapatoService.GetById(id);
      if (sapato == null)
      {
        return NotFound();
      }
      return Ok(sapato);
    }

    [HttpPost]
    public IActionResult Post([FromBody] NewSapatoInputModel inputModel)
    {
      if (inputModel.Tamanho > 70)
      {
        return BadRequest();
      }

      var id = _sapatoService.Create(inputModel);

      return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
    }
  }
}