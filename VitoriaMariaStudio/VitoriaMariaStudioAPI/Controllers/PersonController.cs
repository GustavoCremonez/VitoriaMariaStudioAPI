using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VitoriaMariaStudio.Application.Contracts.Persons;
using VitoriaMariaStudio.Domain.Entities;

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
            Person entity = _personService.GetOne(id);

            if (entity == null) return NotFound();

            return Ok(entity);
        }

        [HttpGet("GetAll")]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            List<Person> entity = _personService.GetAll();

            if (entity.Count == 0) return NotFound();

            return Ok(entity);
        }

        [HttpPost("Create")]
        [AllowAnonymous]
        public IActionResult Create(Person entity)
        {
            bool hasSaved = _personService.Add(entity);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        [AllowAnonymous]
        public IActionResult Update(Person entity)
        {
            Person person = _personService.Update(entity);

            if (person != null) return Ok(person);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        [AllowAnonymous]
        public IActionResult Remove(long id)
        {
            Person person = _personService.GetOne(id);

            if (person == null) return NotFound();

            var hasDeleted = _personService.Delete(person);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}