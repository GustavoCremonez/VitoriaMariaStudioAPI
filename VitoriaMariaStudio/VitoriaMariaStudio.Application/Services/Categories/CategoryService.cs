using VitoriaMariaStudio.Application.Contracts.Categories;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Categories;
using VitoriaMariaStudio.Repository.Contracts;
using VitoriaMariaStudio.Repository.Repositories;

namespace VitoriaMariaStudio.Application.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category, CategoryDto> _genericRepository;

        public CategoryService(IGenericRepository<Category, CategoryDto> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(CategoryDto dto)
        {
            return _genericRepository.Add(dto);
        }

        public bool Delete(long id)
        {
            return _genericRepository.Delete(id);
        }

        public List<CategoryDto> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public CategoryDto GetOne(long id)
        {
            return _genericRepository.GetOne(id);
        }

        public CategoryDto Update(CategoryDto dto)
        {
            _genericRepository.Update(dto);

            return _genericRepository.GetOne(dto.Id);
        }
    }
}