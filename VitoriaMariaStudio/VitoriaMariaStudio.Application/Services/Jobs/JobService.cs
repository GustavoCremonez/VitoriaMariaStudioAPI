using VitoriaMariaStudio.Application.Contracts.Jobs;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.Repository.Contracts;

namespace VitoriaMariaStudio.Application.Services.Jobs
{
    public class JobService : IJobService
    {
        private readonly IGenericRepository _genericRepository;

        public JobService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(Job entity)
        {
            return _genericRepository.Add(entity);
        }

        public bool Delete(Job entity)
        {
            return _genericRepository.Delete(entity);
        }

        public List<Job> GetAll()
        {
            return _genericRepository.GetAll<Job>();
        }

        public Job GetOne(long id)
        {
            return _genericRepository.GetOne<Job>(id);
        }

        public Job Update(Job entity)
        {
            _genericRepository.Update(entity);

            return _genericRepository.GetOne<Job>(entity.Id);
        }
    }
}