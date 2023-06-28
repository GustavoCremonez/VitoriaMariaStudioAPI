using VitoriaMariaStudio.Application.Contracts.Schedulings;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.Repository.Contracts;

namespace VitoriaMariaStudio.Application.Services.Schedulings
{
    public class SchedulingService : ISchedulingService
    {
        private readonly IGenericRepository _genericRepository;

        public SchedulingService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(Scheduling entity)
        {
            return _genericRepository.Add(entity);
        }

        public bool Delete(Scheduling entity)
        {
            return _genericRepository.Delete(entity);
        }

        public List<Scheduling> GetAll()
        {
            return _genericRepository.GetAll<Scheduling>();
        }

        public Scheduling GetOne(long id)
        {
            return _genericRepository.GetOne<Scheduling>(id);
        }

        public Scheduling Update(Scheduling entity)
        {
            _genericRepository.Update(entity);

            return _genericRepository.GetOne<Scheduling>(entity.Id);
        }
    }
}