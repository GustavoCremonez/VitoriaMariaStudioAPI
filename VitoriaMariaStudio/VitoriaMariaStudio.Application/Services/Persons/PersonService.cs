using VitoriaMariaStudio.Application.Contracts.Persons;
using VitoriaMariaStudio.Repository.Contracts;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Persons;

namespace VitoriaMariaStudio.Application.Services.Persons
{
    public class PersonService : IPersonService
    {
        private readonly IGenericRepository<Person, PersonDto> _genericRepository;

        public PersonService(IGenericRepository<Person, PersonDto> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public List<PersonDto> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public PersonDto GetOne(long id)
        {
            return _genericRepository.GetOne(id);
        }

        public bool Add(PersonDto dto)
        {
            return _genericRepository.Add(dto);
        }

        public bool Delete(long id)
        {
            return _genericRepository.Delete(id);
        }

        public PersonDto Update(PersonDto dto)
        {
            _genericRepository.Update(dto);

            return _genericRepository.GetOne(dto.Id);
        }
    }
}