using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VitoriaMariaStudio.Application.Contracts.Categories;
using VitoriaMariaStudio.Domain.Entities;

namespace VitoriaMariaStudio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetOne")]
        [AllowAnonymous]
        public IActionResult GetOne(long id)
        {
            Category entity = _categoryService.GetOne(id);

            if (entity == null) return NoContent();

            return Ok(entity);
        }

        [HttpGet("GetAll")]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            List<Category> entities = _categoryService.GetAll();

            if (entities.Count == 0) return NoContent();

            return Ok(entities);
        }

        [HttpPost("Create")]
        [AllowAnonymous]
        public IActionResult Create(Category entity)
        {
            bool hasSaved = _categoryService.Add(entity);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        [AllowAnonymous]
        public IActionResult Update(Category entity)
        {
            Category category = _categoryService.Update(entity);

            if (category != null) return Ok(category);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        [AllowAnonymous]
        public IActionResult Remove(long id)
        {
            Category category = _categoryService.GetOne(id);

            if (category == null) return NotFound("Não foi encontrado a categoria que deseja remover! tente novamente.");

            var hasDeleted = _categoryService.Delete(category);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}