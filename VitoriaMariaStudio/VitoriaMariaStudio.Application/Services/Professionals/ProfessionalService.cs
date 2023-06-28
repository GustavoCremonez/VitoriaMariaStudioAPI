using VitoriaMariaStudio.Application.Contracts.Professionals;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.Repository.Contracts;

namespace VitoriaMariaStudio.Application.Services.Professionals
{
    public class ProfessionalService : IProfessionalsService
    {
        private readonly IGenericRepository _genericRepository;

        public ProfessionalService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(Professional entity)
        {
            return _genericRepository.Add(entity);
        }

        public bool Delete(Professional entity)
        {
            return _genericRepository.Delete(entity);
        }

        public List<Professional> GetAll()
        {
            return _genericRepository.GetAll<Professional>();
        }

        public Professional GetOne(long id)
        {
            return _genericRepository.GetOne<Professional>(id);
        }

        public Professional Update(Professional entity)
        {
            _genericRepository.Update(entity);

            return _genericRepository.GetOne<Professional>(entity.Id);
        }
    }
}