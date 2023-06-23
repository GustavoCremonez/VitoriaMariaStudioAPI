using VitoriaMariaStudio.Domain.Entities;

namespace VitoriaMariaStudio.Application.Contracts.Persons
{
    public interface IPersonService
    {
        bool Add(Person entity);

        bool Delete(Person entity);

        Person Update(Person entity);

        Person GetOne(long id);

        List<Person> GetAll();
    }
}