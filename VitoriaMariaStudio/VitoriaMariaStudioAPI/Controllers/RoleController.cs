using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using VitoriaMariaStudio.Application.Contracts.Roles;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Roles;

namespace VitoriaMariaStudio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("GetOne")]
        public IActionResult GetOne(long id)
        {
            RoleDto dto = _roleService.GetOne(id);

            if (dto == null) return NoContent();

            return Ok(dto);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<RoleDto> dtos = _roleService.GetAll();

            if (dtos.Count == 0) return NoContent();

            return Ok(dtos);
        }

        [HttpPost("Create")]
        public IActionResult Create(RoleDto dto)
        {
            bool hasSaved = _roleService.Add(dto);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        public IActionResult Update(RoleDto dto)
        {
            RoleDto role = _roleService.Update(dto);

            if (role != null) return Ok(role);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        public IActionResult Remove(long id)
        {
            var hasDeleted = _roleService.Delete(id);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}