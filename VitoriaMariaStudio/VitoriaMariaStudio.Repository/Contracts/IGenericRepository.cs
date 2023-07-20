namespace VitoriaMariaStudio.Repository.Contracts
{
    public interface IGenericRepository<TEntity, TDto>
    {
        bool Add(TDto dto);

        bool Delete(long id);

        bool Update(TDto dto);

        TDto GetOne(long id);

        List<TDto> GetAll();
    }
}