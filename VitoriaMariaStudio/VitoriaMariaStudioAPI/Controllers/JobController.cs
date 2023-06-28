using Microsoft.AspNetCore.Mvc;
using VitoriaMariaStudio.Application.Contracts.Jobs;
using VitoriaMariaStudio.Domain.Entities;

namespace VitoriaMariaStudio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet("GetOne")]
        public IActionResult GetOne(long id)
        {
            Job entity = _jobService.GetOne(id);

            if (entity == null) return NoContent();

            return Ok(entity);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<Job> entities = _jobService.GetAll();

            if (entities.Count == 0) return NoContent();

            return Ok(entities);
        }

        [HttpPost("Create")]
        public IActionResult Create(Job entity)
        {
            bool hasSaved = _jobService.Add(entity);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        public IActionResult Update(Job entity)
        {
            Job job = _jobService.Update(entity);

            if (job != null) return Ok(job);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        public IActionResult Remove(long id)
        {
            Job job = _jobService.GetOne(id);

            if (job == null) return NotFound("Não foi encontrado a serviço que deseja remover! tente novamente.");

            var hasDeleted = _jobService.Delete(job);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}