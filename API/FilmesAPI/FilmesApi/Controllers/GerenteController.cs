using FilmesAPI.Data.Dtos.Gerentes;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        private GerenteService _gerenteService;

        public GerenteController(GerenteService gerenteService)
        {
            _gerenteService = gerenteService;
        }

        [HttpPost]
        public IActionResult AdicionaGerente(CreateGerenteDto dto)
        {
            ReadGerenteDto readDto = _gerenteService.AdicionaGerente(dto);
            return CreatedAtAction(nameof(RecuperaGerentePorId), new { Id = readDto.Id }, readDto);

        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentePorId(int id)
        {
            ReadGerenteDto readDto = _gerenteService.RecuperaGerentePorId(id);
            if(readDto !=null) return Ok(readDto);
          
            return NotFound();

        }

        [HttpGet]
        public IActionResult RecuperaGerentes()
        {
            List<ReadGerenteDto> readDto = _gerenteService.RecuperaGerentes();
            if (readDto == null) return NotFound();
            return Ok(readDto);

        }


        [HttpDelete("{id}")]
        public IActionResult DeletaGerente(int id)
        {
            Result resultado = _gerenteService.DeletaGerente(id); 
           if(resultado.IsFailed) return NotFound();
           return NoContent();
        }
    }
}
