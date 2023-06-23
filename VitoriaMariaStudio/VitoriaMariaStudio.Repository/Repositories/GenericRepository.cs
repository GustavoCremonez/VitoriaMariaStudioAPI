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

        public bool Add<T>(T entity) where T : class
        {
            try
            {
                _dbContext.Add(entity);
                if (_dbContext.SaveChanges() > 0) return true;

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete<T>(T entity) where T : class
        {
            try
            {
                _dbContext.Remove(entity);
                if (_dbContext.SaveChanges() > 0) return true;

                return false;
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

        public bool Update<T>(T entity) where T : class
        {
            try
            {
                _dbContext.Update(entity);
                if (_dbContext.SaveChanges() > 0) return true;

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}