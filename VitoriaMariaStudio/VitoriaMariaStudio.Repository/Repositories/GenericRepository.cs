using AutoMapper;
using VitoriaMariaStudio.Repository.Context;
using VitoriaMariaStudio.Repository.Contracts;

namespace VitoriaMariaStudio.Repository.Repositories
{
    public class GenericRepository<TEntity, TDto> : IGenericRepository<TEntity, TDto> where TEntity : class
                                                                                      where TDto : class
    {
        private readonly StudioDbContext _dbContext;
        private readonly IMapper _mapper;

        public GenericRepository(StudioDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<TDto> GetAll()
        {
            try
            {
                List<TEntity> entity = _dbContext.Set<TEntity>().ToList();
                List<TDto> dto = new List<TDto>();

                entity.ForEach(x =>
                {
                    dto.Add(_mapper.Map<TDto>(x));
                });

                return dto;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TDto GetOne(long id)
        {
            try
            {
                TEntity entity = _dbContext.Set<TEntity>().Find(id);
                TDto dto = _mapper.Map<TDto>(entity);

                return dto;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Add(TDto dto)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(dto);

                _dbContext.Add(entity);
                if (_dbContext.SaveChanges() > 0) return true;

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(long id)
        {
            try
            {
                var entity = _dbContext.Set<TEntity>()
                                       .Find(id);

                _dbContext.Remove(entity);
                if (_dbContext.SaveChanges() > 0) return true;

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(TDto dto)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(dto);

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