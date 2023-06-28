using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using VitoriaMariaStudio.Application.Contracts.Roles;
using VitoriaMariaStudio.Domain.Entities;

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
            Role entity = _roleService.GetOne(id);

            if (entity == null) return NoContent();

            return Ok(entity);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<Role> entities = _roleService.GetAll();

            if (entities.Count == 0) return NoContent();

            return Ok(entities);
        }

        [HttpPost("Create")]
        public IActionResult Create(Role entity)
        {
            bool hasSaved = _roleService.Add(entity);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        public IActionResult Update(Role entity)
        {
            Role role = _roleService.Update(entity);

            if (role != null) return Ok(role);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        public IActionResult Remove(long id)
        {
            Role role = _roleService.GetOne(id);

            if (role == null) return NotFound("Não foi encontrado o cargo que deseja remover! tente novamente.");

            var hasDeleted = _roleService.Delete(role);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}