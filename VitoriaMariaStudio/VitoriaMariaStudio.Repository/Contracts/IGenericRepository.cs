namespace VitoriaMariaStudio.Repository.Contracts
{
    public interface IGenericRepository
    {
        bool Add<T>(T entity) where T : class;

        bool Delete<T>(T entity) where T : class;

        bool Update<T>(T entity) where T : class;

        T GetOne<T>(long id) where T : class;

        List<T> GetAll<T>() where T : class;
    }
}