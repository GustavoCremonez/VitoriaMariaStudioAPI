using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VitoriaMariaStudio.Application.Contracts.Categories;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Categories;

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
            CategoryDto dto = _categoryService.GetOne(id);

            if (dto == null) return NoContent();

            return Ok(dto);
        }

        [HttpGet("GetAll")]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            List<CategoryDto> dtos = _categoryService.GetAll();

            if (dtos.Count == 0) return NoContent();

            return Ok(dtos);
        }

        [HttpPost("Create")]
        [AllowAnonymous]
        public IActionResult Create(CategoryDto dto)
        {
            bool hasSaved = _categoryService.Add(dto);

            if (hasSaved) return NoContent();

            return BadRequest();
        }

        [HttpPut("Update")]
        [AllowAnonymous]
        public IActionResult Update(CategoryDto dto)
        {
            CategoryDto category = _categoryService.Update(dto);

            if (category != null) return Ok(category);

            return BadRequest();
        }

        [HttpDelete("Remove")]
        [AllowAnonymous]
        public IActionResult Remove(long id)
        {
            var hasDeleted = _categoryService.Delete(id);

            if (hasDeleted) return NoContent();

            return BadRequest();
        }
    }
}