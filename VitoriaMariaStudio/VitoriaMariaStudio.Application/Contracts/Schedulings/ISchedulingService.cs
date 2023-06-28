using VitoriaMariaStudio.Domain.Entities;

namespace VitoriaMariaStudio.Application.Contracts.Schedulings
{
    public interface ISchedulingService
    {
        bool Add(Scheduling entity);

        bool Delete(Scheduling entity);

        Scheduling Update(Scheduling entity);

        Scheduling GetOne(long id);

        List<Scheduling> GetAll();
    }
}