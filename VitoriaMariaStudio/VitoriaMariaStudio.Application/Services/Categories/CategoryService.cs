using VitoriaMariaStudio.Application.Contracts.Categories;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.Repository.Contracts;

namespace VitoriaMariaStudio.Application.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository _genericRepository;

        public CategoryService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(Category entity)
        {
            return _genericRepository.Add(entity);
        }

        public bool Delete(Category entity)
        {
            return _genericRepository.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _genericRepository.GetAll<Category>();
        }

        public Category GetOne(long id)
        {
            return _genericRepository.GetOne<Category>(id);
        }

        public Category Update(Category entity)
        {
            _genericRepository.Update(entity);

            return _genericRepository.GetOne<Category>(entity.Id);
        }
    }
}