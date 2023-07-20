using Microsoft.AspNetCore.Mvc;
using VitoriaMariaStudio.Application.Contracts.Professionals;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Professionals;

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
            ProfessionalDto dto = _professionalService.GetOne(id);

            if (dto == null) return NoContent();

            return Ok(dto);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ProfessionalDto> dtos = _professionalService.GetAll();

            if (dtos.Count == 0) return NoContent();

            return Ok(dtos);
        }

        [HttpPost("Create")]
        public IActionResult Create(ProfessionalDto dto)
        {
            bool hasSaved = _professionalService.Add(dto);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        public IActionResult Update(ProfessionalDto dto)
        {
            ProfessionalDto professional = _professionalService.Update(dto);

            if (professional != null) return Ok(professional);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        public IActionResult Remove(long id)
        {
            var hasDeleted = _professionalService.Delete(id);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}