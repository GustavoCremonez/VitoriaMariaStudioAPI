using VitoriaMariaStudio.Application.Contracts.Professionals;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Professionals;
using VitoriaMariaStudio.Repository.Contracts;

namespace VitoriaMariaStudio.Application.Services.Professionals
{
    public class ProfessionalService : IProfessionalsService
    {
        private readonly IGenericRepository<Professional, ProfessionalDto> _genericRepository;

        public ProfessionalService(IGenericRepository<Professional, ProfessionalDto> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(ProfessionalDto dto)
        {
            return _genericRepository.Add(dto);
        }

        public bool Delete(long id)
        {
            return _genericRepository.Delete(id);
        }

        public List<ProfessionalDto> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public ProfessionalDto GetOne(long id)
        {
            return _genericRepository.GetOne(id);
        }

        public ProfessionalDto Update(ProfessionalDto dto)
        {
            _genericRepository.Update(dto);

            return _genericRepository.GetOne(dto.Id);
        }
    }
}