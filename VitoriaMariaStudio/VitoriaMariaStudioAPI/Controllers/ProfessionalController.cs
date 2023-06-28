using Microsoft.AspNetCore.Mvc;
using VitoriaMariaStudio.Application.Contracts.Professionals;
using VitoriaMariaStudio.Domain.Entities;

namespace VitoriaMariaStudio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionalController : ControllerBase
    {
        private readonly IProfessionalsService _professionalService;

        public ProfessionalController(IProfessionalsService professionalsService)
        {
            _professionalService = professionalsService;
        }

        [HttpGet("GetOne")]
        public IActionResult GetOne(long id)
        {
            Professional entity = _professionalService.GetOne(id);

            if (entity == null) return NoContent();

            return Ok(entity);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<Professional> entities = _professionalService.GetAll();

            if (entities.Count == 0) return NoContent();

            return Ok(entities);
        }

        [HttpPost("Create")]
        public IActionResult Create(Professional entity)
        {
            bool hasSaved = _professionalService.Add(entity);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        public IActionResult Update(Professional entity)
        {
            Professional professional = _professionalService.Update(entity);

            if (professional != null) return Ok(professional);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        public IActionResult Remove(long id)
        {
            Professional professional = _professionalService.GetOne(id);

            if (professional == null) return NotFound("Não foi encontrado a/o professional que deseja remover! tente novamente.");

            var hasDeleted = _professionalService.Delete(professional);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}