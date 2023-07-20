using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VitoriaMariaStudio.Application.Contracts.Schedulings;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Schedulings;

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
            SchedulingDto dto = _schedulingService.GetOne(id);

            if (dto == null) return NoContent();

            return Ok(dto);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<SchedulingDto> dtos = _schedulingService.GetAll();

            if (dtos.Count == 0) return NoContent();

            return Ok(dtos);
        }

        [HttpPost("Create")]
        public IActionResult Create(SchedulingDto dto)
        {
            bool hasSaved = _schedulingService.Add(dto);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        public IActionResult Update(SchedulingDto dto)
        {
            SchedulingDto scheduling = _schedulingService.Update(dto);

            if (scheduling != null) return Ok(scheduling);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        public IActionResult Remove(long id)
        {
            var hasDeleted = _schedulingService.Delete(id);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}