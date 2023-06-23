namespace VitoriaMariaStudio.Repository.Contracts
{
    public interface IGenericRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        T GetOne<T>(long id) where T : class;

        List<T> GetAll<T>() where T : class;
    }
}