using VitoriaMariaStudio.Application.Contracts.Roles;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Roles;
using VitoriaMariaStudio.Repository.Contracts;

namespace VitoriaMariaStudio.Application.Services.Roles
{
    public class RoleService : IRoleService
    {
        private readonly IGenericRepository<Role, RoleDto> _genericRepository;

        public RoleService(IGenericRepository<Role, RoleDto> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(RoleDto dto)
        {
            return _genericRepository.Add(dto);
        }

        public bool Delete(long id)
        {
            return _genericRepository.Delete(id);
        }

        public List<RoleDto> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public RoleDto GetOne(long id)
        {
            return _genericRepository.GetOne(id);
        }

        public RoleDto Update(RoleDto dto)
        {
            _genericRepository.Update(dto);

            return _genericRepository.GetOne(dto.Id);
        }
    }
}