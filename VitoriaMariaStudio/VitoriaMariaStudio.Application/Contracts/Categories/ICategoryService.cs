using VitoriaMariaStudio.Domain.Entities;

namespace VitoriaMariaStudio.Application.Contracts.Categories
{
    public interface ICategoryService
    {
        bool Add(Category entity);

        bool Delete(Category entity);

        Category Update(Category entity);

        Category GetOne(long id);

        List<Category> GetAll();
    }
}