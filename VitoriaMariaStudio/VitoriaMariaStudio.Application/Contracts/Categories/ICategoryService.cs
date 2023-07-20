using VitoriaMariaStudio.DTO.Categories;

namespace VitoriaMariaStudio.Application.Contracts.Categories
{
    public interface ICategoryService
    {
        bool Add(CategoryDto dto);

        bool Delete(long Id);

        CategoryDto Update(CategoryDto dto);

        CategoryDto GetOne(long id);

        List<CategoryDto> GetAll();
    }
}