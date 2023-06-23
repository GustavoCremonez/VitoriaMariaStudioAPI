using VitoriaMariaStudio.Repository.Context;
using VitoriaMariaStudio.Repository.Contracts;

namespace VitoriaMariaStudio.Repository.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        private readonly StudioDbContext _dbContext;

        public GenericRepository(StudioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add<T>(T entity) where T : class
        {
            try
            {
                _dbContext.Add(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete<T>(T entity) where T : class
        {
            try
            {
                _dbContext.Remove(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> GetAll<T>() where T : class
        {
            try
            {
                var entity = _dbContext.Set<T>().ToList();
                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T GetOne<T>(long id) where T : class
        {
            try
            {
                var entity = _dbContext.Set<T>().Find(id);
                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update<T>(T entity) where T : class
        {
            try
            {
                _dbContext.Update(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}