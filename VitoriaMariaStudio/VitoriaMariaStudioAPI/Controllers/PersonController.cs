using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VitoriaMariaStudio.Application.Contracts.Persons;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Persons;

namespace VitoriaMariaStudio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("GetOne")]
        [AllowAnonymous]
        public IActionResult GetOne(long id)
        {
            PersonDto dto = _personService.GetOne(id);

            if (dto == null) return NoContent();

            return Ok(dto);
        }

        [HttpGet("GetAll")]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            List<PersonDto> dtos = _personService.GetAll();

            if (dtos.Count == 0) return NoContent();

            return Ok(dtos);
        }

        [HttpPost("Create")]
        [AllowAnonymous]
        public IActionResult Create(PersonDto dto)
        {
            bool hasSaved = _personService.Add(dto);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        [AllowAnonymous]
        public IActionResult Update(PersonDto dto)
        {
            PersonDto person = _personService.Update(dto);

            if (person != null) return Ok(person);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        [AllowAnonymous]
        public IActionResult Remove(long id)
        {
            var hasDeleted = _personService.Delete(id);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}