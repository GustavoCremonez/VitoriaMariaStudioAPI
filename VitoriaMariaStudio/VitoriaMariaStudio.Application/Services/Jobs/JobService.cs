using VitoriaMariaStudio.Application.Contracts.Jobs;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Jobs;
using VitoriaMariaStudio.Repository.Contracts;

namespace VitoriaMariaStudio.Application.Services.Jobs
{
    public class JobService : IJobService
    {
        private readonly IGenericRepository<Job, JobDto> _genericRepository;

        public JobService(IGenericRepository<Job, JobDto> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public List<JobDto> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public JobDto GetOne(long id)
        {
            return _genericRepository.GetOne(id);
        }

        public bool Add(JobDto dto)
        {
            return _genericRepository.Add(dto);
        }

        public bool Delete(long id)
        {
            return _genericRepository.Delete(id);
        }

        public JobDto Update(JobDto dto)
        {
            _genericRepository.Update(dto);

            return _genericRepository.GetOne(dto.Id);
        }
    }
}