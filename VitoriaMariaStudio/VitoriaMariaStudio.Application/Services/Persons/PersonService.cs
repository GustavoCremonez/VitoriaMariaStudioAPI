using VitoriaMariaStudio.Application.Contracts.Persons;
using VitoriaMariaStudio.Repository.Contracts;
using VitoriaMariaStudio.Domain.Entities;

namespace VitoriaMariaStudio.Application.Services.Persons
{
    public class PersonService : IPersonService
    {
        private readonly IGenericRepository _genericRepository;

        public PersonService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(Person entity)
        {
            return _genericRepository.Add(entity);
        }

        public bool Delete(Person entity)
        {
            return _genericRepository.Delete(entity);
        }

        public List<Person> GetAll()
        {
            return _genericRepository.GetAll<Person>();
        }

        public Person GetOne(long id)
        {
            return _genericRepository.GetOne<Person>(id);
        }

        public Person Update(Person entity)
        {
            _genericRepository.Update(entity);

            return _genericRepository.GetOne<Person>(entity.Id);
        }
    }
}