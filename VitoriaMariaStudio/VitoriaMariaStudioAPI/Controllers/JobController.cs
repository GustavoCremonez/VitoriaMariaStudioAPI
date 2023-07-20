using Microsoft.AspNetCore.Mvc;
using VitoriaMariaStudio.Application.Contracts.Jobs;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Jobs;

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
            JobDto dto = _jobService.GetOne(id);

            if (dto == null) return NoContent();

            return Ok(dto);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<JobDto> dtos = _jobService.GetAll();

            if (dtos.Count == 0) return NoContent();

            return Ok(dtos);
        }

        [HttpPost("Create")]
        public IActionResult Create(JobDto dto)
        {
            bool hasSaved = _jobService.Add(dto);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        public IActionResult Update(JobDto dto)
        {
            JobDto job = _jobService.Update(dto);

            if (job != null) return Ok(job);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        public IActionResult Remove(long id)
        {
            var hasDeleted = _jobService.Delete(id);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}