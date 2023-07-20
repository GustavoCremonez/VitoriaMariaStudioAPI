using VitoriaMariaStudio.Application.Contracts.Schedulings;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Schedulings;
using VitoriaMariaStudio.Repository.Contracts;

namespace VitoriaMariaStudio.Application.Services.Schedulings
{
    public class SchedulingService : ISchedulingService
    {
        private readonly IGenericRepository<Scheduling, SchedulingDto> _genericRepository;

        public SchedulingService(IGenericRepository<Scheduling, SchedulingDto> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(SchedulingDto dto)
        {
            return _genericRepository.Add(dto);
        }

        public bool Delete(long id)
        {
            return _genericRepository.Delete(id);
        }

        public List<SchedulingDto> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public SchedulingDto GetOne(long id)
        {
            return _genericRepository.GetOne(id);
        }

        public SchedulingDto Update(SchedulingDto dto)
        {
            _genericRepository.Update(dto);

            return _genericRepository.GetOne(dto.Id);
        }
    }
}