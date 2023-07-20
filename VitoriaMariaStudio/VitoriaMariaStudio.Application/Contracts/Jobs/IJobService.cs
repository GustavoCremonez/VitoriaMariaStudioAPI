using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Jobs;

namespace VitoriaMariaStudio.Application.Contracts.Jobs
{
    public interface IJobService
    {
        bool Add(JobDto dto);

        bool Delete(long id);

        JobDto Update(JobDto dto);

        JobDto GetOne(long id);

        List<JobDto> GetAll();
    }
}