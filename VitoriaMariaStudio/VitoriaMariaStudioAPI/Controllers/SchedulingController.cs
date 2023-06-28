using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VitoriaMariaStudio.Application.Contracts.Schedulings;
using VitoriaMariaStudio.Domain.Entities;

namespace VitoriaMariaStudio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulingController : ControllerBase
    {
        private readonly ISchedulingService _schedulingService;

        public SchedulingController(ISchedulingService schedulingService)
        {
            _schedulingService = schedulingService;
        }

        [HttpGet("GetOne")]
        public IActionResult GetOne(long id)
        {
            Scheduling entity = _schedulingService.GetOne(id);

            if (entity == null) return NoContent();

            return Ok(entity);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<Scheduling> entities = _schedulingService.GetAll();

            if (entities.Count == 0) return NoContent();

            return Ok(entities);
        }

        [HttpPost("Create")]
        public IActionResult Create(Scheduling entity)
        {
            bool hasSaved = _schedulingService.Add(entity);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        public IActionResult Update(Scheduling entity)
        {
            Scheduling scheduling = _schedulingService.Update(entity);

            if (scheduling != null) return Ok(scheduling);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        public IActionResult Remove(long id)
        {
            Scheduling scheduling = _schedulingService.GetOne(id);

            if (scheduling == null) return NotFound("Não foi encontrado o agendamento que deseja remover! tente novamente.");

            var hasDeleted = _schedulingService.Delete(scheduling);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}