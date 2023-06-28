using VitoriaMariaStudio.Domain.Entities;

namespace VitoriaMariaStudio.Application.Contracts.Jobs
{
    public interface IJobService
    {
        bool Add(Job entity);

        bool Delete(Job entity);

        Job Update(Job entity);

        Job GetOne(long id);

        List<Job> GetAll();
    }
}