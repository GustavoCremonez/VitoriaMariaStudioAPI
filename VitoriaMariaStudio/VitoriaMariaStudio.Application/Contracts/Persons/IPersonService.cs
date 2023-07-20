using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Persons;

namespace VitoriaMariaStudio.Application.Contracts.Persons
{
    public interface IPersonService
    {
        bool Add(PersonDto dto);

        bool Delete(long id);

        PersonDto Update(PersonDto dto);

        PersonDto GetOne(long id);

        List<PersonDto> GetAll();
    }
}