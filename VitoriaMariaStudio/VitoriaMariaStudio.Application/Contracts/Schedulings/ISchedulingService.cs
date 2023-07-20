using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Schedulings;

namespace VitoriaMariaStudio.Application.Contracts.Schedulings
{
    public interface ISchedulingService
    {
        bool Add(SchedulingDto dto);

        bool Delete(long id);

        SchedulingDto Update(SchedulingDto dto);

        SchedulingDto GetOne(long id);

        List<SchedulingDto> GetAll();
    }
}