using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Professionals;

namespace VitoriaMariaStudio.Application.Contracts.Professionals
{
    public interface IProfessionalsService
    {
        bool Add(ProfessionalDto dto);

        bool Delete(long id);

        ProfessionalDto Update(ProfessionalDto dto);

        ProfessionalDto GetOne(long id);

        List<ProfessionalDto> GetAll();
    }
}